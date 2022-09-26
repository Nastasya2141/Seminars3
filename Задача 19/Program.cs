// Напишите программу, которая принимает на вход пятизначное число и проверяет
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 10000)
    {
        int thousands = number / 10000;
        int ostatok = number % 10;
 
            if(thousands == ostatok)
            {
                number = number / 10;
                int thousands1 = (number / 100) % 10;
                int ostatok1= number % 10;
                if(thousands1 == ostatok1)
                    Console.WriteLine("Число является палиндромом");
            }
            else 
            Console.WriteLine("Число не является палиндромом");
            
    }
    else
    Console.WriteLine($"Ошибка {number} не является пятизначным");