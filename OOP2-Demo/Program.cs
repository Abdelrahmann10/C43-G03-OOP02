namespace OOP2_Demo
{
    internal class Program
    {
        public static int Sum01(int x, int y)
        {
            return x + y;
        }

        public static int Sum02(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double Sum03(double x, int y)
        {
            return x + y;
        }


        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static double Sum(int x, int y, int z)
        {
            return x + y + z;
        }


        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Sum(int x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            #region Indexer
            //PhoneBook Note = new PhoneBook(3);
            //Note.AddPerson(0, "Abdelrahman", 123);
            //Note.AddPerson(1, "Ahmed", 123);
            //Note.AddPerson(2, "Sherif", 456);
            //Note.SetNumbers("Abdelrahman", 666);
            //Note["Abdelrahman"] = 888;
            //Console.WriteLine(Note.GetNumber("Abdelrahman"));
            //string Name = "Abdelrahman";
            //Console.WriteLine(Name[0]);
            //Name[0] = "H" //Invalid


            #endregion
            #region Class
            Car C1;
            // Declare For Reference From Type "Car", Reference to NULL
            // Can Refere to an object form type Car or an ogject from another Class
            // Inheriting from Car
            // Clr will allocate 4 bytes for the reference at Stack
            // Clr will allocate 0 bytes at Heap
            //------------------------------------------
            C1 = new Car(10,"BMW");
            // new ;
            //1- Allocate required bytes for the object at 16 bytes
            //3- C1 refer to the object at heap
            #endregion
            #region Access Modifiers
            //Access Modifiers 
            //1. Private 
            //2. Private Protected
            //3.Protected 
            //4. Internal 
            //5. Internal Protected
            //6. Public

            // TypeA typeA = new TypeA();
            #endregion
            #region Polymorphism
            Console.WriteLine();
            ////Polymorphism - Methods OverLoadin
            ////[Order - Count - Type] Parameters
            //// Class - Struct

            //Sum01(1, 2);       // 3
            //Sum02(1, 2, 3);  // 6
            //Sum03(3.14, 2);   // 5.14

            //Sum(1, 2);
            //Sum(1, 2, 3);
            ////Sum();
            #endregion
        }
    }
}
