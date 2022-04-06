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
            Console.WriteLine("Press 'C' for create and 'D' for delete\n\n\n");
            Console.WriteLine("You can go back to the main menu by pressing 'B'\n\n");

            string input = Console.ReadLine().ToUpper();

            switch(input)
            {
                case "C":
                    CheckIfStacksListEmpty();
                    InstantiateStack();
                    break;

                case "D":
                    StackList.DeleteStack();
                    break;

            }
        }

        private static void CheckIfStacksListEmpty()
        {
            if (StackList.Stacks == null)
            {
                StackList.Stacks = new List<Stack>();
            }
        }

        static void InstantiateStack()
        {
            Console.WriteLine("What would you like the stack to be called?");
            string name = Console.ReadLine();
            var stack = new Stack(name);
            StackList.AddToStacks(stack);
        }

        static void AddCardsToStack(Stack stack)
        {
            Console.Clear();
            Console.WriteLine("What would you like to do?\n\n\n");

            Console.WriteLine("Press 'C' to create a new Flashcard\n");
            Console.WriteLine("Press 'D' to delete a Flashcard from the stack");
            Console.WriteLine("Press 'S' to show all Flashcards in the stack");

            string input = Console.ReadLine().ToUpper();
            
            switch (input)
            {
                case "C":
                    var newCard = new Flashcard();
                    newCard.SetText();
                    stack.PushCard(newCard);
                    break;

                case "D":
                    Console.WriteLine("What would you like to delete from the stack?");
                    stack.GetFlashcards();
                    stack.DeleteFromStack();
                    break;

                case "S":
                    stack.GetFlashcards();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
