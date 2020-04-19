using System;
using System.Collections.Generic;
using System.Text;

namespace atividade3poo
{
    class Carimbo : Interacao
    {
        private string cor;
        private string texto;
        private int carga;
        private string cCor;
        private int cCarga;

        public Carimbo(string TTexto, string CCor, int CCarga)
        {
            TrocarTexto(TTexto);
            TrocarCor(CCor);
            Carregar(CCor, CCarga);
        }

        public Carimbo(string cCor, int cCarga, string texto)
        {
            this.cCor = cCor;
            this.cCarga = cCarga;
            this.texto = texto;
        }

        private string Cor
        {
            get { return cor; }
            set { cor = value; }
        }
        private string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        private int Carga
        {
            get { return carga; }
            set { carga = value; }
        }

        public void Usar()
        {
            if (carga >= 1)
            {
                if (!String.IsNullOrEmpty(Texto))
                {
                    if (!String.IsNullOrEmpty(Cor))
                    {
                        Console.Write("(" + Texto + ") na cor " + Cor);
                        carga--;
                    }
                    else
                    {
                        Console.Write("Impossível Carimbar - [Sem Cor] ");
                    }
                }
                else
                {
                    Console.Write("Impossível Carimbar - [Sem Texto]");
                }
            }
            else
            {
                Console.Write("Impossível Carimbar - [Sem Carga]");
            }
        }
        public void Carregar(string CCor, int CCarga)
        {
            TrocarCor(CCor);
            if ((CCarga < 1 && CCarga > 10) && ((Carga + CCarga) > 10))
            {
                Console.Write("Carga atual: [" + Carga + "] - Carga deve estar entre 1 e 10.");
            }
            else
            {
                Carga = CCarga;
            }
        }
        public void TrocarCor(string CCor)
        {
            if (CCor == Cor)
            {
                Console.Write("Carimbo já se encontra com essa cor.");
            }
            else
            {
                Cor = CCor;
            }
        }
        public void TrocarTexto(string TTexto)
        {
            if (TTexto == Texto)
            {
                Console.Write("Carimbo já se encontra com esse texto.");
            }
            else
            {
                Texto = TTexto;
            }
        }
    }
}