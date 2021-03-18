using System;
using System.Collections.Generic;

namespace Listas_y_n_meros
{
    class Numeros
    {
        static void Main(string[] args)
        {
           int[] arregloNumeros = new int[5] { 1, 2, 3 , 4 ,5};
           arregloNumeros[1] = 6;
           arregloNumeros[3] = 7;
           arregloNumeros[4] = 8;

          
           
           for (int i=0; i < arregloNumeros.Length - 1; i++)
           {
            if(arregloNumeros[i] == arregloNumeros[0])
            {
                arregloNumeros[i] = arregloNumeros[i+1];
            }   
        
           }
            List<int> listaNumeros = new List<int>();
            listaNumeros.Add(1);
            listaNumeros.Add(2);
            listaNumeros.Add(3);
            listaNumeros.Add(4);
            listaNumeros.Add(5);
            
            listaNumeros[1] = 6;
            listaNumeros[4] = 7;
            listaNumeros.Remove(1);
            listaNumeros.Add(8);
            listaNumeros.Add(9);
            
            for(int i=0; i< listaNumeros.Count;i++)
            {
                Console.Write(listaNumeros[i]+ " ");
            }
            Console.WriteLine();
            for(int i=0; i<listaNumeros.Count;i++)
            {
                listaNumeros[i] = listaNumeros[i]*3;
            }
            
            for (int i=listaNumeros.Count - 1;i>=0;i--)
            {
                if(listaNumeros[i]>20)
                {
                    listaNumeros.RemoveAt(i);
                }
            }
             for(int i=0; i<listaNumeros.Count;i++)
            {
                Console.Write(listaNumeros[i]+ " ");
            }
            List<int> otrosNumeros = new List<int>();
            otrosNumeros.Add(2);
            otrosNumeros.Add(6);
            otrosNumeros.Add(19);
            otrosNumeros.Add(34);
            otrosNumeros.Add(65);
            otrosNumeros.Add(12);
            otrosNumeros.Add(42);
            otrosNumeros.Add(33);
            otrosNumeros.Add(40);
            otrosNumeros.Add(15);

            int numMayor = otrosNumeros[0];

            for(int i = 0; i<otrosNumeros.Count; i++)
            {
                if (otrosNumeros[i] > numMayor)
                {
                    numMayor = otrosNumeros[i];
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("El numero mayor es: " + numMayor);

           
        }
    }
}
