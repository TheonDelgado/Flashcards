using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class StackList
    {
        public static List<Stack> Stacks { get; set; }

        public void GetStackList()
        {
            for (int i = 0; i < Stacks.Count; i++)
            {
                Console.WriteLine();
                Console.Write(Stacks[i].Name);
                Console.WriteLine();
            }
        }

        public static void AddToStacks(Stack stack)
        {
            Stacks.Add(stack);
        }

        public static void DeleteStack()
        {
            Console.WriteLine("What stack would you like to delete?\n");

            for (int i = 0; i < Stacks.Count; i++)
            {
                Console.WriteLine();
                Console.Write(Stacks[i].Name);
                Console.WriteLine();
            }

            string input = Console.ReadLine();

            for(int i = 0; i < Stacks.Count; i++)
            {
                if(Stacks[i].Name == input)
                {
                    Stacks.RemoveAt(i);
                }
            }
        }
    }
}
