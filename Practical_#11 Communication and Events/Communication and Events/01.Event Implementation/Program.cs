using _01.Event_Implementation;

/*
    1. Create a class Dispatcher with a property name and a class Handler.

    2. Create a public delegate called NameChangeEventHandler with return type void in the Namespace of the Dispatcher
    (but outside of the Dispatcher class) and an event (a field of the delegate’s type) inside the Dispatcher class called NameChange.

    3. Create a class NameChangeEventArgs which inherits the EventArgs class and has a property - name which is received through the
    constructor and has a private setter and a public getter.

    4. Create also a method called OnNameChange(NameChangeEventArgs args) in the Dispatcher - 
    this is the method that should be called to fire the event.
    In the setter for the Dispatcher’s name, call the OnNameChange method and pass it an object of NameChangeEventArgs type
    with the new value for the name passed to the setter.

    5. Implement a method OnDispatcherNameChange(object sender, NameChangeEventArgs args) in the Handler class,
    the implementation should write on the console “Dispatcher’s name changed to <newName>”. At the start of your
    program create a new Dispatcher and Handler, then add the Handler’s OnDispatcherNameChange method to the
    NameChange event in the Dispatcher.
 */

Dispatcher dis = new Dispatcher();
Handler handler = new Handler();

// Додаємо метод до івенту в Dispatcher
dis.NameChange += handler.OnDispatcherNameChange;

string? disName = Console.ReadLine();

while(disName != "End")
{
    dis.Name = disName;
    disName = Console.ReadLine();
}

