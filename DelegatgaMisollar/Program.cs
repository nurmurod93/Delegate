namespace DelegatgaMisollar
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int EnrollNumber { get; set; }
    }
    public class Program
    {
        public delegate int Oshiruvchi(int n);
        public delegate TResult GenericOshiruvchi<T, TResult>(T value);
        public 
        public static void Main(string[] args)
        {
            //Oshiruvchi oshir = Increment;
            //var m = oshir(5);
            //Console.WriteLine(m);
            //GenericOshiruvchi<int, int> genericOshir = new GenericOshiruvchi<int, int>(Increment);
            //Console.WriteLine(genericOshir(8));

            List<Student> students = new List<Student>();
            {
                new Student() { Age = 20, Name = "Falonchi", EnrollNumber = 20134 },
                new Student() { Age = 18, Name = "Pistonchi", EnrollNumber = 45673 },
                new Student() { Age = 19, Name = "Pismadonchi", EnrollNumber = 98272 },
                new Student() { Age = 30, Name = "Palonchi", EnrollNumber = 61235 },
                new Student() { Age = 17, Name = "Fistonchi", EnrollNumber = 10986 },
                new Student() { Age = 25, Name = "Kimbo'lsaham", EnrollNumber = 53498 },
            };

            
        }
        private static string StudentName(Student student)
        {
            return student.Name;
        }
        //private static int Increment(int x);
        //{
        //      return ++x;
        //}
        
    }
}