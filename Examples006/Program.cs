Console.WriteLine("Введите Ваше имя");
string username = Console.ReadLine();
if (username.ToLowerInvariant() == "маша") {
    Console.WriteLine("Здравствуй, Машенька!");
}
else {
    Console.Write("Добрый день,");
    Console.Write(username);
}