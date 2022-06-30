Console.WriteLine("Введите четверть координатной плоскости (от 1 до 4): ");
int quarter = Convert.ToInt32(Console.ReadLine());

string CoordByQuarter(int num)
{
    switch(num)
    {
        case 1:
            return "Координата X (0; +бесконечности), координата Y от (0; +бесконечности)";
        case 2:
            return "Координата X (0; +бесконечности), координата Y от (0; +бесконечности)";
        case 3:
            return "Координата X (-бесконечности; 0), координата Y от (-бесконечности; 0)";
        case 4:
            return "Координата X (0; +бесконечности), координата Y от (-бесконечности; 0)";
        default:
            return "Введен некорректный номер четверти";
    }
}

string result = CoordByQuarter(quarter);
Console.WriteLine(result);