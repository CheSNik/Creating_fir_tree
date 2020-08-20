using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirTree
{
    class Program
    {
        public class CreateTree
        {
            int height { get; set; }
            int cons { get; set; }


            public void Create(int Height, int CONST)
            {
                this.height = Height;
                this.cons = CONST;
                
                Console.WriteLine();
                if (height>0)
                {
                    for (int a = 0; a < height - 1; a++)
                    {
                        Console.Write(" ");
                    }

                    for (int b = (cons - height) * 2 + 1; b > 0; b--)
                    {
                        Console.Write("*");
                    }
                    Create(height - 1, cons);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height of a tree (less than 100)");
            string Input="";
            int Enter = 0;
            bool Continue = true;
            while (Continue)
            {
                Input = Console.ReadLine();
                bool Cont = true;
                while (Cont)
                {
                try
                {
                    int m = Convert.ToInt32(Input);
                    Cont = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You should enter a number");
                    Input = Console.ReadLine();
                }
                }
                
                Enter = int.Parse(Input);
                if (Enter >= 100)
                    Console.WriteLine("Enter not more than 100");
                else if (Enter <= 0)
                    Console.WriteLine("Your tree is too short");
                else
                    Continue = false;
            }
            int Height = Enter;
            int CONST = Height;
            CreateTree Tree = new CreateTree();
            Tree.Create(Height, CONST);
            Console.ReadKey();
        }
    }
}