using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GitProgramaIntento
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = File.ReadAllText(@"D:\Programas 2ndo Semestre\Repositorio1\GitProgramaIntento\Numeross.txt");
            string[] num2 = num.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numeros = new int[num2.Length];

            for (int i = 0; i <= numeros.Length; i++)
            {
                numeros[i] = int.Parse(num2[i]); 

                if(numeros[i]%10 == 0)
                {
                    Console.WriteLine(numeros[i] + " es multiplo de 10 ");
                }

            }
            
            

            //for (int i = 0; i < num2.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
        }
    }
}
