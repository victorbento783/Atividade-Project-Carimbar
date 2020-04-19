﻿using System;
using System.Collections.Generic;
using System.Text;

namespace atividade3poo
{
    class Caneta : Interacao
    {
        private string cor;
        private string texto;
        private int carga;

        public Caneta(string CCor, int CCarga, string TTexto)
        {
            Carregar(CCor, CCarga);
            TrocarTexto(TTexto);
            TrocarCor(CCor);
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
                        Console.Clear();
                        Console.Write("\n\n   [Escrevendo]");
                        Console.Write("\n   ( " + Texto + " ) - Coloração: " + Cor);
                        Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                        carga--;
                    }
                    else
                    {
                        Console.Write("\n   Impossível Escrever - [Sem Cor] ");
                        Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                    }
                }
                else
                {
                    Console.Write("\n   Impossível Escrever - [Sem Texto]");
                    Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
                }
            }
            else
            {
                Console.Write("\n   Impossível Escrever - [Sem Carga]");
                Console.Write("\n\n   [Pressione qualquer tecla para continuar]");
            }
        }
        public void Carregar(string CCor, int CCarga)
        {
            TrocarCor(CCor);
            if ((CCarga < 1 && CCarga > 10) && ((Carga + CCarga) > 10))
            {
                Console.Write("\n   Carga atual: [" + Carga + "] - Carga deve estar entre 1 e 10.");
            }
            else
            {
                this.Carga = CCarga;
            }
        }
        public void TrocarCor(string CCor)
        {
            this.Cor = CCor;
        }
        public void TrocarTexto(string TTexto)
        {
            this.Texto = TTexto;
        }
    }
}
