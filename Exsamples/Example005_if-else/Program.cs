Console.Write("Введите своё имя : ");
string username = Console.ReadLine();
if (username.ToLower() == "ирина"){
    Console.Write("Наконец то Ирина - добрый день!");
}
else {
    Console.Write("Здравствуйте " + username);
}