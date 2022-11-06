using _04.Online_Radio_Database;

var songs = new List<Song>();

Console.WriteLine("Enter the number of songs you want to add: ");
var songsCount = int.Parse(Console.ReadLine());


for (int i = 0; i < songsCount; i++)
{
    var input = Console.ReadLine().ToLower().Split(';');

    try
    {
        //Масив для часу
        var time = input[2].Split(':');

        int minutes = int.Parse(time[0]);
        int seconds = int.Parse(time[1]);

        if (minutes * 60 + seconds > 0 || minutes * 60 + seconds < 14 * 60 + 59)
        {
            songs.Add(new Song(input[0], input[1], minutes, seconds));
            Console.WriteLine("Song added.");
        }
        else
        {
            throw new InvalidSongLengthException;
        }
    }
    catch (Exception ise)
    {
        Console.WriteLine(ise.Message);
    }
}

// Загальна к-ість секунд 
int sum = 0;

foreach (var currentElem in songs)
{
    sum += currentElem.Minutes * 60 + currentElem.Seconds;
}

int totalDuration = sum;
int totalHours = totalDuration / 60 / 60;
int totalMinutes = (totalDuration / 60) - (totalHours * 60);
int totalSeconds = totalDuration % 60;


Console.WriteLine($"Songs added: {songs.Count}");
Console.WriteLine($"Playlist length: {totalHours}h {totalMinutes}m {totalSeconds}s");