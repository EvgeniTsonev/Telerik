//Write a program that parses an URL address given in the format:[protocol]://[server]/[resource]
//        and extracts from it the [protocol], [server] and [resource] elements.
//For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//        [protocol] = "http"
//        [server] = "www.devbg.org"
//        [resource] = "/forum/index.php"



using System;
    class Program
    {
        static void Main()
        {
            string url = "http://www.devbg.org/forum/index.php";
            string[] arguments = new string[] { "://", "/" };
            string[] parsed = url.Split(arguments, 3, StringSplitOptions.None);
            parsed[2] = "/" + parsed[2];
            Console.WriteLine("protocol: {0} ", parsed[0] );
            Console.WriteLine("server: {0} ", parsed[1]);
            Console.WriteLine("resourse: {0} ",parsed[2] );
        }
    }

