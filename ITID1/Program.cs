namespace ITID1
{
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

    
    


}
