Console.Write("Представьтесь пожалуйста - ");

string username = Console.ReadLine();

if (username.ToLower() == "александр")
{
    Console.Write("Здравствуйте, Уважаемый ");
    Console.Write(username);
}
else
{
    Console.WriteLine("Hi! "+ username);
}