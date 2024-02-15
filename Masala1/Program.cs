

List<int> Varyantlar = new List<int> { 11, 13, 15, 17, 19, 20, 22, 24, 25, 27, 29, 31, 33, 36, 38, 40 };
Console.WriteLine($"------------------------------------------------------------------------------------");
Console.WriteLine($"Sizga sonlar berilgan. Ulardan shunday 3 tasini tanlab olingki yig'indisi 50 bo'lsin");
Console.WriteLine($"Dasturni to'xtatish uchun 0 ni kiriting!");

Console.WriteLine($"------------------------------------------------------------------------------------");
lb:
q1:
q2:
Console.WriteLine($"11 13 15 17");
Console.WriteLine($"19 20 22 24");
Console.WriteLine($"25 27 29 31");
Console.WriteLine($"33 36 38 40");
Console.WriteLine($"-----------");
Console.WriteLine($"Sonlarni kiriting:");
Console.Write($"1-son: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a != 0)
{
    Console.Write($"2-son: ");
    int b = Convert.ToInt32(Console.ReadLine());
    if (b != 0)
    {
        Console.Write($"3-son: ");
        int c = Convert.ToInt32(Console.ReadLine());
        if (c != 0)
        {
            if (Varyantlar.Contains(a) && Varyantlar.Contains(b) && Varyantlar.Contains(c))
            {
                if (a + b + c == 50)
                {
                    Console.WriteLine($"---------------");
                    Console.WriteLine($"Javob: To'g'ri");
                    Console.WriteLine($"---------------");
                }
                else if (Varyantlar.Contains(a) && Varyantlar.Contains(b) && Varyantlar.Contains(c))
                {

                    Console.WriteLine("????????????????????????????????????????????????????????");

                    Console.WriteLine("Siz Jadvaldagi sonlardan kiritmadingiz qaytadan urining!");

                    Console.WriteLine("????????????????????????????????????????????????????????");

                    goto q2;

                }
                else
                {
                   
                    
                    Console.WriteLine($"---------------");
                    Console.WriteLine($"Javob: Noto'g'ri");
                    Console.WriteLine($"---------------");                    
                    
                    goto q1;
                }
            }
            else
            {
                Console.WriteLine($"------------------------------");
                Console.WriteLine($"Berilgan raqamlardan tanlang!");
                Console.WriteLine($"------------------------------");
                goto lb;
            }
        }


    }

}
Console.WriteLine($"-----------------");
Console.WriteLine($"Dastur tugatildi!");
Console.WriteLine($"-----------------");