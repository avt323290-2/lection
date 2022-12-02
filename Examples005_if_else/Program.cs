Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username == "Маша") // if(username.ToLower() == "Маша") -ввод в верхнем и нижнем регистре.
{
     Console.WriteLine("Ура, это же Маша! ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username );
}