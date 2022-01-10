using System;
using System.Collections.Generic;
using System.Linq;
using ExemploConstrutores.Models;

namespace ExemploConstrutores // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public delegate void Operacao(int x, int y);
        public static void Main(string[] args)
        {
            
            Matematica m = new Matematica(10, 20);
            m.Somar();


            //Operacao op = Calculadora.Somar;
            //Operacao op = new Operacao(Calculadora.Somar);
            //op += Calculadora.Subtrair;
            //op(10, 10);
            

        }
    }
}
