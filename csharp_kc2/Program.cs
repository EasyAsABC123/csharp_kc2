using csharp_kc2;

Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Student>();
for (int i = 0; i < numberOfRecords; i++)
{
    Console.WriteLine("#### ENTER A NEW STUDENT ####");
    // In this loop, populate the object's properties using Console.ReadLine()
    var student = new Student();

    Console.WriteLine("Enter the value for Name");
    student.Name = Console.ReadLine();

    Console.WriteLine("Are you passing the class? Y/N");
    var response = Console.ReadKey().KeyChar;
    if (response.ToString().ToLower() == "y") { student.PassingClass = true; }

    Console.WriteLine("Enter the value for Height");
    student.Height = Console.ReadLine();

    recordList.Add(student);
}

// Print out the list of records using Console.WriteLine()
foreach(var student in recordList)
{
    Console.WriteLine($"{student}");
}