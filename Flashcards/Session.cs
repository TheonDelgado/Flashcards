using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcards
{
    internal class Session
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }

        public void StartSession()
        {
            Duration = DateTime.Now.ToString("d");


        }
    }
}
