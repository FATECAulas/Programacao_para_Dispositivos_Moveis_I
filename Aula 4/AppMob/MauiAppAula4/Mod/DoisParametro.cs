using System;
using System.Collections.Generic;
using System.Text;

namespace MauiAppAula4.Mod
{
    public class DoisParametro
    {
        // Atributos
        int aN1 = 0;
        int aN2 = 0;
        int aS = 0;

        // Método construtor
        public DoisParametro() { }

        // Métodos de acesso
        public int gsN1 { get => aN1; set => aN1 = value; }
        public int gsN2 { get => aN2; set => aN2 = value; }
        public int gsS { get => aS; set => aS = value; }

        // Métodos específicos
        public int Somar()
        {
            gsS = gsN1 + gsN2;
            return gsS;
        }

    }

    public class Subtracao 
    {
        // Atributos
        int aN1 = 0;
        int aN2 = 0;
        int aS = 0;

        // Método construtor
        public Subtracao() { }

        // Métodos de acesso
        public int gsN1 { get => aN1; set => aN1 = value; }
        public int gsN2 { get => aN2; set => aN2 = value; }
        public int gsS { get => aS; set => aS = value; }

        // Métodos específicos
        public int Subtrair()
        {
            gsS = gsN1 - gsN2;
            return gsS;
        }
    }

    public class Multiplicacao
    {
        // Atributos
        int aN1 = 0;
        int aN2 = 0;
        int aS = 0;

        // Método construtor
        public Multiplicacao() { }

        // Métodos de acesso
        public int gsN1 { get => aN1; set => aN1 = value; }
        public int gsN2 { get => aN2; set => aN2 = value; }
        public int gsS { get => aS; set => aS = value; }

        // Métodos específicos
        public int Multiplicar()
        {
            gsS = gsN1 * gsN2;
            return gsS;
        }
    }

    public class Divisao
    {
        // Atributos
        int aN1 = 0;
        int aN2 = 0;
        int aS = 0;

        // Método construtor
        public Divisao() { }

        // Métodos de acesso
        public int gsN1 { get => aN1; set => aN1 = value; }
        public int gsN2 { get => aN2; set => aN2 = value; }
        public int gsS { get => aS; set => aS = value; }

        // Métodos específicos
        public int Dividir()
        {
            gsS = gsN1 / gsN2;
            return gsS;
        }
    }
}
