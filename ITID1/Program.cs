using System.Transactions;

namespace ITID1
{
    #region
    class student
    {
        int age;
        int id;
        string phone;
        string name;
        

        public void print()
        {
            Console.WriteLine($"{id} - {name} {age} - {phone}");
        }
        static void Main(string[] args)
        {
            student student = new student();
            student.print();




          



            

           
            
        }
    }
    #endregion
    #region
    internal class program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the number : ");
            int num = int . Parse( Console.ReadLine() );

            for (int i = 0; i <+12; i++)
            {


                Console.Write($" {num} x {i} = {num * i}");
            }











        }








    }
    #endregion
    #region
    internal class program1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your id : ");
            int id = int . Parse( Console.ReadLine() );

            Console.Write("Enter your age : ");
            int age;

            do
            {
                age = int . Parse( Console.ReadLine() );
            }while ( age < 1 );

            Console.WriteLine
                ($@"
                Name : {name}
                ID : {id}
                age : {age}
                "
                );





        }



    }
    #endregion






}
