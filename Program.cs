System.Console.Write("How many student for course A? ");
int courseACount = int.Parse(Console.ReadLine());
int courseACounter = 1;

HashSet<int> set = new HashSet<int>();

while (courseACounter <= courseACount)
{
  int studentId = int.Parse(Console.ReadLine());
  set.Add(studentId);

  courseACounter++;
}


System.Console.Write("How many student for course B? ");
int courseBCount = int.Parse(Console.ReadLine());
int courseBCounter = 1;

while (courseBCounter <= courseBCount)
{
  int studentId = int.Parse(Console.ReadLine());
  set.Add(studentId);

  courseBCounter++;
}

System.Console.Write("How many student for course C? ");
int courseCCount = int.Parse(Console.ReadLine());
int courseCCounter = 1;

while (courseCCounter <= courseCCount)
{
  int studentId = int.Parse(Console.ReadLine());
  set.Add(studentId);

  courseCCounter++;
}

System.Console.Write($"Total students: {set.Count}");