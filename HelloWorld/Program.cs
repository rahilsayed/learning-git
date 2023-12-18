Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();
if(string.IsNullOrEmpty(name)){
    name = "Mr.Nobody";
}
Console.WriteLine("Hello {0}", name);


