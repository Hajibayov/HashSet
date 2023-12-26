static class Program{
    public static void Main()
    {
        HashSet<string> hobbiesSet = new HashSet<string>();
        hobbiesSet.Add("football");
        hobbiesSet.Add("golf");
        hobbiesSet.Add("tennis");
        hobbiesSet.Add("football");

        List<string> hobbiesList = new List<string>();
        hobbiesList.Add("football");
        hobbiesList.Add("golf");
        hobbiesList.Add("tennis");
        hobbiesList.Add("football");

        Console.WriteLine(hobbiesSet.Count);
        //3
        Console.WriteLine(hobbiesList.Count);
        //4

        //HashSet<string> progLanguages = new HashSet<string>();
        //progLanguages.Add("C#");

        //progLanguages.Remove("C#");
        //progLanguages.RemoveWhere(x => x == "C#");
        //Console.WriteLine(progLanguages.Count);

        //if (progLanguages.Contains("C#"))
        //{
        //    Console.WriteLine("C# is in the HashSet");
        //}

        //HashSet<string> progLanguages = new HashSet<string>();
        //progLanguages.Add("C#");
        //progLanguages.Add("C++");
        //progLanguages.Add("Java");

        //HashSet<string> progLanguages2 = new HashSet<string>();
        //progLanguages2.Add("PHP");
        //progLanguages2.Add("C++");
        //progLanguages2.Add("Ruby");

        //progLanguages.UnionWith(progLanguages2);

        //foreach (string language in progLanguages)
        //{
        //    Console.WriteLine(language);
        //}

        //HashSet<string> progLanguages = new HashSet<string>();
        //progLanguages.Add("C#");
        //progLanguages.Add("C++");
        //progLanguages.Add("Java");

        //HashSet<string> progLanguages2 = new HashSet<string>();
        //progLanguages2.Add("PHP");
        //progLanguages2.Add("C++");
        //progLanguages2.Add("Ruby");

        //progLanguages.IntersectWith(progLanguages2);

        //foreach (string language in progLanguages)
        //{
        //    Console.WriteLine(language);
        //}

        //HashSet<string> progLanguages = new HashSet<string>();
        //progLanguages.Add("C#");
        //progLanguages.Add("C++");
        //progLanguages.Add("Java");

        //HashSet<string> progLanguages2 = new HashSet<string>();
        //progLanguages2.Add("PHP");
        //progLanguages2.Add("C++");
        //progLanguages2.Add("Ruby");

        //progLanguages.ExceptWith(progLanguages2);

        //foreach (string language in progLanguages)
        //{
        //    Console.WriteLine(language);
        //}


        HashSet<string> progLanguages = new HashSet<string>();
        progLanguages.Add("C#");
        progLanguages.Add("C++");
        progLanguages.Add("Java");

        HashSet<string> progLanguages2 = new HashSet<string>();
        progLanguages2.Add("PHP");
        progLanguages2.Add("C++");
        progLanguages2.Add("Ruby");

        progLanguages.SymmetricExceptWith(progLanguages2);

        foreach (string language in progLanguages)
        {
            Console.WriteLine(language);
        }
    }
}