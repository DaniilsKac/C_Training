Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "даниил")
{
    Console.WriteLine("Ура, это же Кот!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}