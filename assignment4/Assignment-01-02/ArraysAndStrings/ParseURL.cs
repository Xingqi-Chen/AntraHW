using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using ArraysAndStrings;
public class ParseURL
{
    static string parseURL(string url)
    {
        string[] splited = url.Split("://");
        string protocol = "";
        string back = splited[0];
        if (splited.Length > 1)
        {
            protocol = splited[0];
            back = splited[1];
        }
        string[] tmp = back.Split("/");

        string server = tmp[0];
        string resource = "";
        if (tmp.Length > 1)
        {
            resource = tmp[1];
        }

        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append($"[protocol] = \"{protocol}\"\n");
        stringBuilder.Append($"[server] = \"{server}\"\n");
        stringBuilder.Append($"[resource] = \"{resource}\"\n");
        return stringBuilder.ToString();
    }

    public void solution()
    {
        Console.WriteLine(parseURL("ftp://google.com/abc"));
    }
}
