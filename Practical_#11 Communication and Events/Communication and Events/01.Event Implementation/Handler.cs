using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Event_Implementation
{
    public class Handler
    {
        // Хендлер зміни імені в Dispatcher
        //В параметрі вказується NameChangeEventArgs args для того, що метод для підписки на ЛЮБИЙ івент (оск. NameChangeEventArgs : EventArgs)
        
        public void OnDispatcherNameChange(object sender, NameChangeEventArgs args)
        {
            Console.WriteLine($"Dispatcher's name changed to {args.Name}");
        }
    }
}
