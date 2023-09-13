// See https://aka.ms/new-console-template for more information

using Newtonsoft.Json;
Console.WriteLine("Hello, World!, xaG");

#if DEBUG
Console.WriteLine("DEBUG is defined");
#else
Console.WriteLine("DEBUG is not defined");
#endif

var student = new Student(3,"Anna","二", 88);
var json = JsonConvert.SerializeObject(student);
Console.WriteLine(json);

public record Student(int ID, string Name , string Class , int Score);
