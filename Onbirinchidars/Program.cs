namespace Onbirinchidars;
internal class Program
{
    static void Main(string[] args)
    {
        var school1 = CreateSchool2();
        FillSchoolObject(school1);
        Console.WriteLine();
        DisplaySchoolObject(school1);
        Console.WriteLine(GetFreeSpaces(school1));
    }

    static School CreateSchool2()
    {
        return new School();
    }

    static void FillSchoolObject(School school)
    {
        Console.Write("Maktab raqami: ");
        school.Number = int.Parse(Console.ReadLine());

        Console.Write("Maktab nomi: ");
        school.Name = Console.ReadLine();

        Console.Write("Maktab manzili: ");
        school.Location = Console.ReadLine();

        Console.Write("Maktab sigimi: ");
        school.Capacity = int.Parse(Console.ReadLine());

        Console.Write("Talabalar soni: ");
        school.CurrentStudentCount = int.Parse(Console.ReadLine());
    }

    static void DisplaySchoolObject(School school)
    {
        Console.WriteLine($" Maktab raqami: {school.Number}\n Maktab nomi: {school.Name}\n Maktab manzili: {school.Location}\n Maktab sigimi {school.Capacity}\n Talabalar soni: {school.CurrentStudentCount}"); 
    }

    static int GetFreeSpaces(School school)
    { 
      return school.Capacity - school.CurrentStudentCount;  
    
    }
}
