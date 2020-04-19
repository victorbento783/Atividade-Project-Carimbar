using System;

namespace atividade3poo
{
    interface Interacao
    {
        void Usar();
        void Carregar(string CCor, int CCarga);
        void TrocarCor(string CCor);
        void TrocarTexto(string TTexto);
    }
}