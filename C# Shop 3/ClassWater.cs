using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_3
{
    public class Water : Products
    {

        //ATTRIBUTI

        private double litri;
        private int ph;
        private string sorgente;
        private string marca;
        private string tipo;
        private string materialeBottiglia;


        //COSTRUTTORE

        public Water(string nomeBevanda, string categoriaBevanda, string descrizioneBevanda, int prezzoBevanda, double litri, int ph, string sorgente, string marca, string tipo, string materialeBottiglia) : base(nomeBevanda, categoriaBevanda, descrizioneBevanda, prezzoBevanda)
        {
            if (ph < 0 || ph > 10)
            {
                throw new ArgumentException("Non puoi creare una bottiglia d'acqua con un ph negativo o superiore a 10!");
            }
            else
            {
                this.litri = litri;
                this.ph = ph;
                this.sorgente = sorgente;
                this.marca = marca;
                this.tipo = tipo; // (Minerale, Frizzante...)
                this.materialeBottiglia = materialeBottiglia;
            }
        }


        //GETTERS

        public double GetLitri()
        {
            return this.litri;
        }

        public int GetPh()
        {
            return this.ph;
        }

        public string GetSorgente()
        {
            return this.sorgente;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public string GetTipo()
        {
            return this.tipo;
        }

        public string GetMaterialeBottiglia()
        {
            return this.materialeBottiglia;
        }


        //SETTERS

        public void SetPh(int ph)
        {
            this.ph = ph;
        }

        public void SetLitri(double litri)
        {
            this.litri = litri;
        }

        // METODI

        public double Bevi()
        {
            double litriDaBere = 0.5d;
            Console.WriteLine("Bevo la bottiglia...");
            this.litri = litri - litriDaBere;
            Thread.Sleep(5000);

            if (this.litri == 0)
            {
                throw new Exception("L'acqua è finita!");
            }

            Console.WriteLine("Numero litri dopo aver bevuto: " + this.litri);

            return this.litri;           
        }

        public double Riempi()
        {
            double litriDaRiempire = 0;

            Console.WriteLine("Di quanti litri vuoi riempire?");
            litriDaRiempire = float.Parse(Console.ReadLine());
            Console.WriteLine("*Riempie la bottiglia*");
            double litriFinali = this.litri + litriDaRiempire;
            Thread.Sleep(5000);

            if (litriFinali > this.litri)
            {
                throw new Exception("Non puoi riempire la bottiglia oltre la capienza massima!");
            }
            else if (litriFinali == this.litri)
            {
                Console.WriteLine("Bottiglia riempita!");
            }

                      

            return this.litri;
        }

        public double Svuota()
        {
            Console.WriteLine("*Svuota la bottiglia*");
            Thread.Sleep(5000);
            this.litri = 0;
            Console.WriteLine("Bottiglia vuota!");
            return this.litri;
        }
    }
}
