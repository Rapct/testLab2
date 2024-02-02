Console.WriteLine("Hello, World!");
Console.WriteLine("Hello, Mengtian Lin");
Console.WriteLine("Version: {0}", Environment.Version.ToString());

int myNum  = 18;
Console.WriteLine("myNum is: "+ myNum);

string[] sections = {"TECH*4982*01", "CPS3330*01", "CPS3330*02"};
Console.WriteLine("The number of section is "+  sections.Length);

Array.Reverse(sections);
Console.Write("\nIn reverse: ");
foreach (var e in sections)
    Console.Write(e.ToString() + " ");

Console.WriteLine("\nUsing foreach method: ");
sections.ToList().ForEach(e => Console.Write(e.ToString() + " "));

Console.WriteLine("\n\nUsing Array class and its method: ");
Array.ForEach(sections, Console.WriteLine);





