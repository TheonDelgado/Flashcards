﻿using System;
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
                string input = Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "C":
                        var newCard = new Flashcard();
                        newCard.SetText();
                        Stack.PushCard(newCard);
                        break;
                }
            }
            
        }

        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Flashcard app!\n");
            
            Console.WriteLine("What would you like to do?\n\n\n");

            Console.WriteLine("Press 'C' to create a new Flashcard\n");
            Console.WriteLine("Press 'D' to delete a Flashcard from the stack");
        }
    }
}