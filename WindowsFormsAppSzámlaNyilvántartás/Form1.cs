using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;

namespace WindowsFormsAppSzámlaNyilvántartás
{
    public partial class Form1 : Form
    {
        MySqlConnection conn=null;
        MySqlCommand cmd=null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder=new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";
            builder.AllowZeroDateTime = true;
            builder.ConvertZeroDateTime = true;
            conn = new MySqlConnection(builder.ConnectionString);
            try
            {
                conn.Open();
                cmd=conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
            Szamla_lista_update();
        }

        private void Szamla_lista_update()
        {
            listBox1.Items.Clear();
            cmd.CommandText = "SELECT `id`,`tulajdonosNeve`,`egyenleg`,`nyitasdatum` FROM `szamlak` WHERE 1";
            conn.Open();
            using(MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    Szamla uj = new Szamla(dr.GetInt32("id"),dr.GetString("tulajdonosNeve"), dr.GetInt32("egyenleg"),
                        dr.IsDBNull(3) ? DateTime.Now : dr.GetDateTime("nyitasdatum"));
                    listBox1.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTulajdonosNeve.Text))
            {
                MessageBox.Show("Adja meg a tulajdonos nevét!");
                textBoxTulajdonosNeve.Focus();
                return;
            }
            if (numericUpDownEgyenleg.Value == 0)
            {
                MessageBox.Show("Adja meg az egyenleget!");
                numericUpDownEgyenleg.Focus();
                return;
            }
            if (dateNyitasDatum.Value==DateTime.MinValue)
            {
                MessageBox.Show("Adja meg a mennyiséget!");
                dateNyitasDatum.Focus();
                return;
            }
            cmd.CommandText = "INSERT INTO `szamlak` (`id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES (NULL, @tulajdonosNeve, @egyenleg, @nyitasdatum);";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@tulajdonosNeve", textBoxTulajdonosNeve.Text);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDownEgyenleg.Value.ToString());
            cmd.Parameters.AddWithValue("@nyitasdatum", dateNyitasDatum.Value);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve");
                    textBoxId.Text = "";
                    textBoxTulajdonosNeve.Text = "";
                    numericUpDownEgyenleg.Value = numericUpDownEgyenleg.Minimum;
                    dateNyitasDatum.Value = dateNyitasDatum.MinDate;
                }
                else
                {
                    MessageBox.Show("Sikertelen rögzítés!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            Szamla_lista_update();
        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve számla!");
                return;
            }
            cmd.CommandText = "UPDATE `gyumolcsok` SET `tulajdonosNeve` = @tulajdonosNeve, `egyenleg` = @egyenleg, `nyitasdatum` = @nyitasdatum WHERE `szamlak`.`id` = @id;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            cmd.Parameters.AddWithValue("@tulajdonosNeve", textBoxTulajdonosNeve.Text);
            cmd.Parameters.AddWithValue("@egyenleg", numericUpDownEgyenleg.Value);
            cmd.Parameters.AddWithValue("@nyitasdatum", dateNyitasDatum.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres!");
                conn.Close();
                textBoxId.Text = "";
                textBoxTulajdonosNeve.Text = "";
                numericUpDownEgyenleg.Value = numericUpDownEgyenleg.Minimum;
                dateNyitasDatum.Value = dateNyitasDatum.MinDate;
                Szamla_lista_update();
            }
            else
            {
                MessageBox.Show("Az adatok modosítása sikerleten!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `szamlak` WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBoxId.Text);
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Törlés sikeres!");
                conn.Close();
                textBoxId.Text = "";
                textBoxTulajdonosNeve.Text = "";
                numericUpDownEgyenleg.Value = numericUpDownEgyenleg.Minimum;
                dateNyitasDatum.Value =dateNyitasDatum.MinDate;
                Szamla_lista_update();
            }
            else
            {
                MessageBox.Show("Törlés sikertelen!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            Szamla kivalaszott_szamla = (Szamla)listBox1.SelectedItem;
            textBoxId.Text = kivalaszott_szamla.Id.ToString();
            textBoxTulajdonosNeve.Text = kivalaszott_szamla.TulajdonosNeve;
            numericUpDownEgyenleg.Value = kivalaszott_szamla.Egyenleg;
            dateNyitasDatum.Value = kivalaszott_szamla.Nyitasdatum;
        }
    }
}
