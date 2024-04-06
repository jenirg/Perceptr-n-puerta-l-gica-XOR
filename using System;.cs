using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{   //Compuerta Lógica AND
    class Program
    { 
          static void Main(string[] args)
          {
            int [,] datos = {{1,1,1},{1,0,0},{0,1,0},{0,0,0}};
            Random aleatorio = new Random();
            double[] pesos = {aleatorio.NextDouble(), aleatorio.NextDouble(), aleatorio.NextDouble()};
            bool entrenamiento = true;
            int salidaInt;
            while (entrenamiento){
                entrenamiento=false;
                for (int i=0; i < 4; i++)
                {
                    double salidaDoub = datos[i,0]*pesos[0]+datos[i,1]*pesos[1]+pesos[2];
                    if (salidaDoub>0) salidaInt=1;
                    else salidaInt =0;
                    if(salidaInt != datos[i,2])
                    {
                        pesos[0]=aleatorio.NextDouble() - aleatorio.NextDouble();
                        pesos[1]=aleatorio.NextDouble() - aleatorio.NextDouble();
                        pesos[2]=aleatorio.NextDouble() - aleatorio.NextDouble();
                        entrenamiento = true;

                    }
                }
            }
            //Fin del entrenamiento
            console.WriteLine("Pesos útiles: w0 ="+pesos[0].ToString() + "w1 = "+ pesos[1].ToString() + "w2 = " + pesos[2].ToString());
            console.ReadLine();
               for (int i=0; i < 4; i++)
                {
                    double salidaDoub = datos[i,0]*pesos[0]+datos[i,1]*pesos[1]+pesos[2];
                    if (salidaDoub>0) salidaInt=1;
                    else salidaInt =0;
                    Console.WriteLine("Entradas"+ datos[i,0].ToString()+ "AND"+ datos[i,1].ToString + "="+datos[i,2].ToString() )
                    if(salidaInt != datos[i,2])
                    {
                        pesos[0]=aleatorio.NextDouble() - aleatorio.NextDouble();
                        pesos[1]=aleatorio.NextDouble() - aleatorio.NextDouble();
                        pesos[2]=aleatorio.NextDouble() - aleatorio.NextDouble();
                        entrenamiento = true;

                    }
                }
          }

    }
}