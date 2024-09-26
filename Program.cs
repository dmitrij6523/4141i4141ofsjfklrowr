using Kalkulyator;

start:

Kalkul clas = new Kalkul();

string simb;

Console.WriteLine("Введите первое число");
double x = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Введите действие");
simb = Convert.ToString(Console.ReadLine());

Console.WriteLine("Введите второе число");
double y = Convert.ToDouble(Console.ReadLine());



switch (simb)
{
    case "+":
        clas.plus(x, y);
        goto start;
    case "-":
        clas.minus(x, y);
        goto start;
    case "*":
        clas.multiplication(x, y);
        goto start;
    case "/":
        clas.division(x, y);
        goto start;

    case "округление":
        clas.rounding(x, y);
        goto start;
    case "arksin":
        clas.arksin(x, y);
        goto start;
    case "степень":
        clas.degree(x, y);
        goto start;
    case "квадрат":
        clas.square(x, y);
        goto start;
    case "синус":
        clas.sin(x, y);
        goto start;
    case "тангенс":
        clas.tan(x, y);
        goto start;
}