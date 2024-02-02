using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frazioneù
{
    internal class Frazione
    {
        public Frazione()
        {
        }

        public int Numeratore { get; set; }
        public int Denominatore { get; set; }
        public Frazione(int numeratore, int denominatore)
        {
            Sempli(ref numeratore, ref denominatore);
            Numeratore = numeratore;
            Denominatore = denominatore;
        }
        public void Sempli(ref int numeratore, ref int denominatore)
        {
            numeratore /= Mcd(numeratore,denominatore); 
            denominatore/= Mcd(numeratore, denominatore); 
        }
        public int Mcd(int n1, int n2)
        {
            int r;
          while(n2!=0)
            {
                r =n1%n2;
                n1 = n2;
                n2= r;
            }
            return n1;
        }
        public static Frazione Parse(string s)
        {
            string[] parts = s.Split('/');
            return new Frazione(int.Parse(parts[0]), int.Parse(parts[1]));
            
        }
        public override string ToString()
        {
            return string.Format("{0}/{1}", Numeratore, Denominatore);
        }

    }
}
