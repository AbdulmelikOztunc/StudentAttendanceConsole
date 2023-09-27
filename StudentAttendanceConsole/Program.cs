namespace StudentAttendanceConsoleApp;

internal class Program
{
	static void Main(string[] args)
	{
		List<string> students = new List<string>
		{
			"Taner",
			"Ahmet",
			"Mehmet"
		};

		List<string> inClass = new List<string>();

		Console.WriteLine("Hi, this is my students!");

		int studentCount = students.Count;

		for (int i = 0; i < studentCount; i++)
		{
			Console.WriteLine($"{i + 1:00}. {students[i]}");
		}

		while (true)
		{
			Console.Write("Tell me who is in class? (Enter student number or 'exit' to quit): ");
			string input = Console.ReadLine();

			if (input.ToLower() == "exit")
			{
				Console.WriteLine("Exiting the program...");
				break;
			}

			if (int.TryParse(input, out int studentNumber))
			{
				if (studentNumber >= 1 && studentNumber <= studentCount)
				{
					string selectedStudent = students[studentNumber - 1];

					if (inClass.Contains(selectedStudent))
					{
						Console.WriteLine($"{selectedStudent} is already in class.");
					}
					else
					{
						inClass.Add(selectedStudent);
						Console.WriteLine($"{selectedStudent} is now in class.");
					}
				}
				else
				{
					Console.WriteLine("Invalid student number. Please enter a valid number.");
				}
			}
			else
			{
				Console.WriteLine("Invalid input. Please enter a valid student number or 'exit' to quit.");
			}
		}

		if (inClass.Count == studentCount)
		{
			Console.WriteLine("All students are in class. Exiting the program...");
		}
	}
}
