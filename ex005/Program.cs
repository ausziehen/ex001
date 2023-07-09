Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "max")
    {
        Console.WriteLine("Ну привет, Max!");
    }
else
    {
        Console.WriteLine("Здравствуйте, ");
        Console.WriteLine(username);
    }