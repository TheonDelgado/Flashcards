using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class Flashcard
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string StackId { get; set; }

        public Flashcard()
        {

        }

        public Flashcard(string text)
        {
            Text = text;
        }

        public void SetText()
        {
            Console.WriteLine("What is the text of the flashcard?");
            string input = Console.ReadLine();
            Text = input;
        }

        public void SetToStack(Stack stack)
        {
            StackId = stack.Name;
        }
    }
}
