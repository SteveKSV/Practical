using System.ComponentModel;
using System.Runtime;
using System.Security.AccessControl;

string url = Console.ReadLine();
string protocol = "";
string server = "";
string resource = "";

if (url.Contains("://"))
{
    for (int i = 0; i < url.Length; i++)
    {
        if (url[i].Equals(':'))
        {
            protocol = url.Substring(0, i);
        }
    }

    if (url.Contains('/'))
    {
        for (int i = 0; i < url.Length; i++)
        {
            if (url[i].Equals('/'))
            {
                string[] parts = url.Split("://");
                string serverResourse = "";

                if (parts[0].Equals(protocol))
                    serverResourse = string.Join("", parts[1]);

                string[] tokens = serverResourse.Split('/');

                if(tokens.Length == 2)
                {
                    server = tokens[0];
                    resource = tokens[1];
                } else if (tokens.Length < 2)
                {
                    server = serverResourse;
                } else if (tokens.Length > 2)
                {
                    string item = string.Join(" ", tokens);
                   
                    string[] elem = item.Split(" ");
                    server = elem[0];

                    string[] resources = new string[elem.Length-1];
                    for (int j = 1; j < elem.Length; j++)
                    {
                        resources[j-1] = elem[j];
                    }
                    resource = string.Join("/", resources);
                }
                
            } 
        }
    }  else
    {
        server = url;
    }
} 
else
{
    protocol = "";
    server = url;
    resource = "";
}

Console.WriteLine("[protocol] = " + protocol);
Console.WriteLine("[server] = " + server);
Console.WriteLine("[resource] = " + resource);