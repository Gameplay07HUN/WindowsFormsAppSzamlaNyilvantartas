using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSzámlaNyilvántartás
{
    internal class Szamla
    {
        int id;
        string tulajdonosNeve;
        int egyenleg;
        DateTime nyitasdatum;

        public int Id { get => id; set => id = value; }
        public string TulajdonosNeve { get => tulajdonosNeve; set => tulajdonosNeve = value; }
        public int Egyenleg { get => egyenleg; set => egyenleg = value; }
        public DateTime Nyitasdatum { get => nyitasdatum; set => nyitasdatum = value; }

        public Szamla(int id, string tulajdonosNeve, int egyenleg, DateTime nyitasdatum)
        {
            Id = id;
            TulajdonosNeve = tulajdonosNeve;
            Egyenleg = egyenleg;
            Nyitasdatum = nyitasdatum;
        }

        public override string ToString()
        {
            return tulajdonosNeve + "(" + egyenleg + ")" + nyitasdatum;
        }
    }
}
