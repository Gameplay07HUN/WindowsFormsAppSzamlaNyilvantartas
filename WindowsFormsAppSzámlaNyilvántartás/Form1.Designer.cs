namespace WindowsFormsAppSzámlaNyilvántartás
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTulajdonosNeve = new System.Windows.Forms.Label();
            this.labelEgyenleg = new System.Windows.Forms.Label();
            this.labelNyitasDatum = new System.Windows.Forms.Label();
            this.textBoxTulajdonosNeve = new System.Windows.Forms.TextBox();
            this.numericUpDownEgyenleg = new System.Windows.Forms.NumericUpDown();
            this.buttonUj = new System.Windows.Forms.Button();
            this.buttonModosit = new System.Windows.Forms.Button();
            this.buttonTorles = new System.Windows.Forms.Button();
            this.dateNyitasDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgyenleg)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(318, 44);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(161, 450);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelId.Location = new System.Drawing.Point(285, 42);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 20);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id:";
            // 
            // labelTulajdonosNeve
            // 
            this.labelTulajdonosNeve.AutoSize = true;
            this.labelTulajdonosNeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelTulajdonosNeve.Location = new System.Drawing.Point(184, 80);
            this.labelTulajdonosNeve.Name = "labelTulajdonosNeve";
            this.labelTulajdonosNeve.Size = new System.Drawing.Size(128, 20);
            this.labelTulajdonosNeve.TabIndex = 3;
            this.labelTulajdonosNeve.Text = "Tulajdonos neve:";
            // 
            // labelEgyenleg
            // 
            this.labelEgyenleg.AutoSize = true;
            this.labelEgyenleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEgyenleg.Location = new System.Drawing.Point(213, 114);
            this.labelEgyenleg.Name = "labelEgyenleg";
            this.labelEgyenleg.Size = new System.Drawing.Size(79, 20);
            this.labelEgyenleg.TabIndex = 4;
            this.labelEgyenleg.Text = "Egyenleg:";
            // 
            // labelNyitasDatum
            // 
            this.labelNyitasDatum.AutoSize = true;
            this.labelNyitasDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNyitasDatum.Location = new System.Drawing.Point(184, 149);
            this.labelNyitasDatum.Name = "labelNyitasDatum";
            this.labelNyitasDatum.Size = new System.Drawing.Size(105, 20);
            this.labelNyitasDatum.TabIndex = 5;
            this.labelNyitasDatum.Text = "Nyitás dátum:";
            // 
            // textBoxTulajdonosNeve
            // 
            this.textBoxTulajdonosNeve.Location = new System.Drawing.Point(318, 80);
            this.textBoxTulajdonosNeve.Name = "textBoxTulajdonosNeve";
            this.textBoxTulajdonosNeve.Size = new System.Drawing.Size(100, 20);
            this.textBoxTulajdonosNeve.TabIndex = 6;
            // 
            // numericUpDownEgyenleg
            // 
            this.numericUpDownEgyenleg.Location = new System.Drawing.Point(298, 114);
            this.numericUpDownEgyenleg.Maximum = new decimal(new int[] {
            1569325055,
            23283064,
            0,
            0});
            this.numericUpDownEgyenleg.Name = "numericUpDownEgyenleg";
            this.numericUpDownEgyenleg.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEgyenleg.TabIndex = 7;
            // 
            // buttonUj
            // 
            this.buttonUj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonUj.Location = new System.Drawing.Point(187, 191);
            this.buttonUj.Name = "buttonUj";
            this.buttonUj.Size = new System.Drawing.Size(230, 46);
            this.buttonUj.TabIndex = 9;
            this.buttonUj.Text = "Új számla bevietele";
            this.buttonUj.UseVisualStyleBackColor = true;
            this.buttonUj.Click += new System.EventHandler(this.buttonUj_Click);
            // 
            // buttonModosit
            // 
            this.buttonModosit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonModosit.Location = new System.Drawing.Point(187, 243);
            this.buttonModosit.Name = "buttonModosit";
            this.buttonModosit.Size = new System.Drawing.Size(230, 46);
            this.buttonModosit.TabIndex = 10;
            this.buttonModosit.Text = "Meglévő számla módosítása";
            this.buttonModosit.UseVisualStyleBackColor = true;
            this.buttonModosit.Click += new System.EventHandler(this.buttonModosit_Click);
            // 
            // buttonTorles
            // 
            this.buttonTorles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonTorles.Location = new System.Drawing.Point(187, 295);
            this.buttonTorles.Name = "buttonTorles";
            this.buttonTorles.Size = new System.Drawing.Size(230, 46);
            this.buttonTorles.TabIndex = 11;
            this.buttonTorles.Text = "Meglévő számla törlése";
            this.buttonTorles.UseVisualStyleBackColor = true;
            this.buttonTorles.Click += new System.EventHandler(this.buttonTorles_Click);
            // 
            // dateNyitasDatum
            // 
            this.dateNyitasDatum.Checked = false;
            this.dateNyitasDatum.Location = new System.Drawing.Point(294, 149);
            this.dateNyitasDatum.Name = "dateNyitasDatum";
            this.dateNyitasDatum.Size = new System.Drawing.Size(200, 20);
            this.dateNyitasDatum.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateNyitasDatum);
            this.Controls.Add(this.buttonTorles);
            this.Controls.Add(this.buttonModosit);
            this.Controls.Add(this.buttonUj);
            this.Controls.Add(this.numericUpDownEgyenleg);
            this.Controls.Add(this.textBoxTulajdonosNeve);
            this.Controls.Add(this.labelNyitasDatum);
            this.Controls.Add(this.labelEgyenleg);
            this.Controls.Add(this.labelTulajdonosNeve);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgyenleg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTulajdonosNeve;
        private System.Windows.Forms.Label labelEgyenleg;
        private System.Windows.Forms.Label labelNyitasDatum;
        private System.Windows.Forms.TextBox textBoxTulajdonosNeve;
        private System.Windows.Forms.NumericUpDown numericUpDownEgyenleg;
        private System.Windows.Forms.Button buttonUj;
        private System.Windows.Forms.Button buttonModosit;
        private System.Windows.Forms.Button buttonTorles;
        private System.Windows.Forms.DateTimePicker dateNyitasDatum;
    }
}

