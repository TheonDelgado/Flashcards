using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackList.Stacks = new List<Stack>();
            while(true)
            {
                MainMenu();
                
            }
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Flashcard app!\n");
            
            Console.WriteLine("What would you like to do?\n\n\n");

            Console.WriteLine("Press 'M' to manage stacks\n");
            Console.WriteLine("Press 'S' to start a study session");
            Console.WriteLine("Press 'E' to end program");

            string input = Console.ReadLine().ToUpper();
            switch (input)
            {
                case "M":
                    ManageStacksMenu();
                    break;
                    //Still needs more
            }
        }

        static void ManageStacksMenu()
        {
            Console.Clear();
            Console.WriteLine("Would you like to create a new stack or delete one?\n\n\n");
            Console.WriteLine("Press 'C' for create and 'D' for delete\n");
            Console.WriteLine("Press 'M' to manage cards in a stack\n\n\n");
            Console.WriteLine("You can go back to the main menu by pressing 'B'\n\n");

            string input = Console.ReadLine().ToUpper();

            switch(input)
            {
                case "C":
                    InstantiateStack();
                    break;

                case "D":
                    if(StackListIsEmpty()) return;  
                    StackList.DeleteStack();
                    break;
                case "M":
                    if(StackListIsEmpty()) return;
                    Stack stack = StackList.PickStack();
                    Stack.ManageCards(stack);
                    break;

            }
        }
        static bool StackListIsEmpty()
        {
            bool isEmpty = false;
            if (StackList.Stacks.Count < 1)
            {
                Console.WriteLine("There are no stacks!");
                Console.ReadLine();
                isEmpty = true;
            }
            return isEmpty;
        }

        static void InstantiateStack()
        {
            Console.WriteLine("What would you like the stack to be called?");
            string name = Console.ReadLine();
            var stack = new Stack(name);
            StackList.AddToStacks(stack);
        }

        
    }
}
