using System;
internal class Megalesson92
{
    static void Main()
    {
        for(int x = 0; x < 10; x++)//Создаём цикл, что выводит 10 паролей
        {
        Passwords();
        }
        Console.ReadKey();
    }
    static void Passwords()
    {
        Random randN = new Random();
        int randNum = randN.Next(3, 20); //Создаём число, что определяет количество символов в пароле
         string alfavit = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ0123456789"; //Создаём строку с символами, что будут использоваться в паролях
         string rez = ""; //Создаём строку результата пароля
        
        for(int i = 0; i < randNum; i++) //Прописываем цикл, что создаёт вариант пароля
        {
            int randS = randN.Next(1,40); //Создаём случайное число, что определяет символ пароля
            rez = rez + alfavit[randS]; //Добавляем символ в результат
        }
        Console.WriteLine(rez);//Выводим результат
    }
}