internal class Program
{
    private static void Main(string[] args)
    {
        ex01();
        ex02();
        ex03();
        ex2_01();
        ex2_02();
        ex2_03();
        ex2_04();
        ex2_05();
    }
    static void ex01()
    {
        Console.WriteLine("Chuyen do C sang F va K");
        Console.Write("Nhap do C: ");
        double celsius = 0;
        while (!double.TryParse(Console.ReadLine(), out celsius))
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double fahrenheit = (celsius * 9 / 5) + 32;
        double kelvin = celsius + 273.15;
        Console.WriteLine($"Do F: {fahrenheit}");
        Console.WriteLine($"Do K: {kelvin}");
    }
    static void ex02()
    {
        Console.Write("Nhap ban kinh hinh cau: ");
        double radius = 0;
        while (!double.TryParse(Console.ReadLine(), out radius) || radius <= 0)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double area = 4 * Math.PI * Math.Pow(radius, 2);
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Dien tich hinh cau: {area}");
        Console.WriteLine($"The tich hinh cau: {volume}");
    }
    static void ex03()
    {
        Console.WriteLine("Tinh tong, hieu, tich, thuong, chi lay du");
        Console.Write("Nhap so a: ");
        double a = 0;
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        Console.WriteLine("Nhap so b: ");
        double b = 0;
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        Console.WriteLine($$"""
        Tong: {{a + b}}    
        Hieu: {{a - b}}
        Tich: {{a * b}}
        Thuong: {{a / b}}
        Chi lay du: {{a % b}}
        """);
    }
    static void ex2_01()
    {
        Console.WriteLine("Tinh tong, hieu, tich, thuong, chi lay du");
        Console.Write("Nhap so a: ");
        double a = 0;
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        Console.WriteLine("Nhap so b: ");
        double b = 0;
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        Console.WriteLine($$"""
        Tong: {{a + b}}    
        Hieu: {{a - b}}
        Tich: {{a * b}}
        Thuong: {{a / b}}
        Chi lay du: {{a % b}}
        """);
    }
    static void ex2_02()
    {
        Console.WriteLine("Tinh x=y^2+2y+1");
        Console.Write("Nhap so y: ");
        double y = 0;
        while (!double.TryParse(Console.ReadLine(), out y) || y>5 ||y<-5)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double x=Math.Pow(y, 2) + 2 * y + 1;
        Console.WriteLine($"x la: {x}");
    }
    static void ex2_03()
    {
        Console.WriteLine("Tinh van toc");
        Console.Write("Nhap quang duong: ");
        double distance = 0;
        while (!double.TryParse(Console.ReadLine(), out distance) || distance <= 0)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double hours = 0;
        Console.Write("Nhap thoi gian (gio): ");
        while (!double.TryParse(Console.ReadLine(), out hours) || hours <= 0)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double minutes = 0;
        Console.Write("Nhap thoi gian (phut): ");
        while (!double.TryParse(Console.ReadLine(), out minutes) || minutes < 0)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double seconds = 0;
        Console.Write("Nhap thoi gian (giay): ");
        while (!double.TryParse(Console.ReadLine(), out seconds) || seconds < 0)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double totalTimeInHours = hours + (minutes / 60) + (seconds / 3600);
        double speed = distance / totalTimeInHours;
        Console.WriteLine($"Van toc la: {speed} km/h");
        Console.WriteLine($"Van toc la: {speed / 1.609} miles/h");
    }
    static void ex2_04()
    {
        Console.WriteLine("Tinh dien tich hinh chu nhat");
        Console.Write("Nhap chieu dai: ");
        double length = 0;
        while (!double.TryParse(Console.ReadLine(), out length) || length <= 0)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        Console.Write("Nhap chieu rong: ");
        double width = 0;
        while (!double.TryParse(Console.ReadLine(), out width) || width <= 0)
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        double area = length * width;
        Console.WriteLine($"Dien tich hinh chu nhat la: {area}");
    }
    static void ex2_05()
    {
        Console.WriteLine("Nhan biet chu, so va ky tu");
        Console.Write("Nhap 1 ky tu bat ky: ");
        char input;
        while(!char.TryParse(Console.ReadLine(), out input))
        {
            Console.Write("Nhap sai, vui long nhap lai: ");
        }
        if (char.IsLetter(input))
        {
            Console.WriteLine($"{input} la chu cai");
        }
        else if (char.IsDigit(input))
        {
            Console.WriteLine($"{input} la chu so");
        }
        else
        {
            Console.WriteLine($"{input} la ky tu dac biet");
        }
    }
}