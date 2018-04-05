using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronMultiCapa{

    class Neurona{
        //Pesos para cada entrada P1 y P2; y el peso de la entrada interna U
        private double P1;
        private double P2;
        private double U;
        public Neurona(Random azar) { //Constructor
            P1 = azar.NextDouble();
            P2 = azar.NextDouble();
            U = azar.NextDouble();
        }
        public double calculaSalida(double E1, double E2){
            double valor, S;
            valor = E1 * P1 + E2 * P2 + 1 * U;
            S = 1 / (1 + Math.Exp(-valor));
            return S;
        }
    }


    class Program{
        static void Main(string[] args){
            Random azar = new Random(); //Un solo generador
            Neurona algunaCapasOcultas = new Neurona(azar);
            Neurona algunaCapaSalida = new Neurona(azar);
        }
    }
}
