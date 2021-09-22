using System;
using static System.Console;

namespace ArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunosAMS =  new string[5];
              alunosAMS[0] =  "Cezar";
              alunosAMS[1] =  "Carlos";
              alunosAMS[2] =  "Jeferson";
              alunosAMS[3] =  "Bruno";
              alunosAMS[4] =  "Talita";

            Console.WriteLine(alunosAMS[2]);
        
            alunosAMS[2] = "Jeferson"; 

            WriteLine($"Novo valor no index 2: {alunosAMS[2]}");

            for(int i = 0; i < alunosAMS.Length; i++) 
            {
                WriteLine($"os nomes sao: {alunosAMS[i]}");
            } 
        }
    }
}
