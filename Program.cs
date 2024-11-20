int kenar1, kenar2, kenar3;

Console.WriteLine("1.kenarı giriniz");
kenar1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2.kenarı giriniz");
kenar2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("3.kenarı giriniz");
kenar3 = Convert.ToInt32(Console.ReadLine());

int cevre = kenar1+kenar2+kenar3;

Console.WriteLine("Ücgenin Cevresi: " + cevre);

Console.ReadKey();