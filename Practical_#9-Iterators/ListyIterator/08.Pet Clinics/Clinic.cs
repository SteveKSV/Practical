using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Pet_Clinics
{
    public class Clinic
    {
        private string name;
        private Pet[] rooms;

        public Clinic(string name, int roomsCount)
        {
            this.Name = name;
            this.Rooms = new Pet[roomsCount];
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Pet[] Rooms
        {
            get
            {
                return rooms;
            }
            private set
            {
                if (value.Length % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }

                this.rooms = value;
            }
        }

        public bool Add(Pet pet)
        {
            // Індекс центральної кімнати 
            int middleRoomIndex = this.Rooms.Length / 2;

            // Якщо ця кімната порожня - заводимо туди тваринку
            if (this.Rooms[middleRoomIndex] == null)
            {
                this.Rooms[middleRoomIndex] = pet;
                return true;
            }

            // Індекс для індексів кімнат по бокам від центральної (наприклад, 5 кімнат - тоді для 2 та 4 кімнат)
            int awayFromTheMiddleIndex = 1;

            while (true)
            {
                // Індекс лівої кімнати від центральної
                int roomLeftFromTheMiddle = middleRoomIndex - awayFromTheMiddleIndex;

                // Якщо порожня - заодимо тваринку (додаткова умова для того, щоб не вийти за межі кімнат
                // (наприклад, якщо у нас 1 кімната всього)
                if (roomLeftFromTheMiddle >= 0 && this.Rooms[roomLeftFromTheMiddle] == null)
                {
                    this.Rooms[roomLeftFromTheMiddle] = pet;
                    return true;
                }
                
                // Індекс правої кімнати від центральної
                int roomRightFromTheMiddle = middleRoomIndex + awayFromTheMiddleIndex;

                // Така ж умова, як і для лівої, окрім додаткової. 
                if (roomRightFromTheMiddle < this.Rooms.Length && this.Rooms[roomRightFromTheMiddle] == null)
                {
                    this.Rooms[roomRightFromTheMiddle] = pet;
                    return true;
                }

                // Збільшує індекс для інших індексів, щоб заводити тваринок в інші кімнати.
                awayFromTheMiddleIndex++;

                //Якщо кімнати закінчились - повертаємо false, аби вийти з циклу.
                if (awayFromTheMiddleIndex > this.Rooms.Length / 2)
                {
                    return false;
                }
            }
        }
    
        public bool Release()
        {
            // Індекс центральної кімнати
            int currentIndex = this.Rooms.Length / 2;

            // Змінна-лічильник для к-сті провіренних кімнат 
            int checkedRooms = 0;

            while (true)
            {
                if (this.Rooms[currentIndex % this.Rooms.Length] != null)
                {
                    this.Rooms[currentIndex % this.Rooms.Length] = null;
                    return true;
                }
                // Після кожної провіренної кімнати змінна збільшується. 
                checkedRooms++;  
                
                // Якщо змінна дорівнює кількості кімнат - всі кімнати перевірені та відбувається вихід з циклу.
                if (checkedRooms == this.Rooms.Length)
                {
                    return false;
                }

                // Змінюємо індекс кімнати
                currentIndex++;
            }
        }
    
        public bool HasEmptyRooms(string clinicName)
        {
            foreach(var room in this.Rooms)
            {
                if(room == null)
                {
                    return true;
                }
            }
            return false;
        }
        public void Print()
        {
            Console.WriteLine("--------------Print of the rooms--------------");
            foreach(var room in this.Rooms)
            {
                if(room == null)
                {
                    Console.Write("Room Empty");
                }
                Console.WriteLine($"{room}");
                
            }
        }

        public void Print(int room)
        {
            Console.WriteLine($"{Rooms[room - 1]}");
        }
    }

}
