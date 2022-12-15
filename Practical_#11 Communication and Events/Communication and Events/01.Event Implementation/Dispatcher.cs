using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Event_Implementation
{
    // Делегат на методи для івенту (паттерн методів/шаблон)
    public delegate void NameChangeEventHandler(object sender, NameChangeEventArgs args);
    public class Dispatcher
    {
        string? name;

        // Івент NameChange 
        public event NameChangeEventHandler? NameChange;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
                OnNameChange(new NameChangeEventArgs(value));
                
            }
        }
        
        // Викликаємо івент
        public void OnNameChange(NameChangeEventArgs args)
        {
           this.NameChange(this, args);
        }
    }
}
