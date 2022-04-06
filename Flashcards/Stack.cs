using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class Stack
    {
        public string Name { get; set; }
        public static List<Flashcard> flashcards { get; private set; }

        public Stack(string name)
        {
            Name = name;
        }

        public void GetFlashcards()
        {
            for(int i = 0; i < flashcards.Count; i++)
            {
                Console.WriteLine();
                Console.Write(flashcards[i].Id + " "); Console.Write(flashcards[i].Text);
                Console.WriteLine();
            }
        }

        public void PushCard(Flashcard newCard)
        {
            if(flashcards == null)
            {
                flashcards = new List<Flashcard>();
            }
            if (newCard is null)
            {
                throw new InvalidOperationException("Cannot push a null object");
            }
            flashcards.Insert(0, newCard);
            for(int i = 0; i < flashcards.Count; i++)
            {
                flashcards[i].Id++;
            }
        }

        public Flashcard PopCard()
        {
            if (flashcards.Count <= 0)
            {
                throw new Exception("Stack is empty!");
            }

            Flashcard topCard = flashcards[0];
            flashcards.RemoveAt(0);
            return topCard;
        }

        public void DeleteFromStack()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            flashcards.RemoveAt(input - 1);

            for(int i = 0; i < flashcards.Count; i++)
            {
                flashcards[i].Id = flashcards.IndexOf(flashcards[i]) + 1;
            }
        }

        public void ClearStack()
        {
            flashcards.Clear();
        }

    }
}
