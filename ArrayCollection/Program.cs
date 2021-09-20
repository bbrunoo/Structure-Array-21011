using System;
using static System.Console;

namespace ArrayCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alunosAMS =  new string[5]{
                "Dani",
                "Maju",
                "Alcino",
                "Bruno",
                "Talita",
            };

         
            WriteLine(alunosAMS[2]);
        
            alunosAMS[2] = "Jeferson"; 

            WriteLine($"Novo valor no index 2: {alunosAMS[2]}");

            WriteLine("-----------------------------------------------");
   

            foreach (string aluno in alunosAMS)
            {
                WriteLine(aluno);
            }

            WriteLine("-----------------------------------------------");

            for(int i = 0; i < alunosAMS.Lenght; i++) 
            {
                WriteLine(alunosAMS[i]);
            } 
        }
    }
}
