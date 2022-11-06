/*
    1. Each pet should have a name, an age and a kind;

    2. Your application should support a few basic operations such as creating a pet, creating a clinic, adding a pet to a
       clinic, releasing a pet from a clinic, printing information about a specific room in a clinic or printing information
       about all rooms in a clinic;
    
    3. Clinics should have an odd number of rooms. Attempting to create a clinic with an even number of rooms should fail
       and throw an appropriate exception;
 */

using _08.Pet_Clinics;

public class Program
{
    static List<Pet> pets = new List<Pet>();
    static List<Clinic> clinics = new List<Clinic>();
    private static void Main()
    {
        pets = new List<Pet>();
        clinics = new List<Clinic>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] inputArgs = Console.ReadLine().Split();
            string command = inputArgs[0];

            switch (command)
            {
                case "Create":

                    Create(inputArgs);
                    break;

                case "Add":
                    Pet currentPetAdd = new Pet(" ", 0, " ");

                    foreach (var pet in pets)
                    {
                        if (pet.Name == inputArgs[1])
                        {
                            currentPetAdd = pet;
                        }
                    }

                    foreach (var clinic in clinics)
                    {
                        if (clinic.Name == inputArgs[2])
                        {
                            Console.WriteLine(clinic.Add(currentPetAdd));
                        }
                    }
                    break;

                case "Release":
                    foreach (var clinic in clinics)
                    {
                        if (clinic.Name == inputArgs[1])
                        {
                            Console.WriteLine(clinic.Release());
                        }
                    }
                    break;

                case "HasEmptyRooms":
                    foreach (var clinic in clinics)
                    {
                        Console.WriteLine(clinic.HasEmptyRooms(inputArgs[1]));
                    }
                    break;

                case "Print":
                    foreach (var clinic in clinics)
                    {
                        if (clinic.Name == inputArgs[1] && inputArgs.Length < 3)
                            clinic.Print();
                        else if (inputArgs.Length == 3)
                        {
                            clinic.Print(int.Parse(inputArgs[2]));
                        }
                    }
                    break;
            }
        }
    }

    private static void Create(string[] inputArgs)
    {
        if (inputArgs[1].Equals("Pet"))
        {
            string petName = inputArgs[2];
            int petAge = int.Parse(inputArgs[3]);
            string kind = inputArgs[4];

            pets.Add(new Pet(petName, petAge, kind));
        }

        else if (inputArgs[1].Equals("Clinic"))
        {
            string clinicName = inputArgs[2];
            int roomsCount = int.Parse(inputArgs[3]);

            try
            {
                clinics.Add(new Clinic(clinicName, roomsCount));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}