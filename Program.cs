Console.Clear();

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("..... Horas Extras.....");
Thread.Sleep(2000);
Console.ResetColor();


Console.WriteLine($"salario-hora {5.5:C}, {720} horas, sendo {40} horas-extra, salário = {Salario(5.5, 720, 40):C}");

double Salario(double salarioHora, double horasTotais, double horasExtras)
{
    return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 40);
}
