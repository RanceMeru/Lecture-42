class Program
{//class is a reference type
    static void Main(string[] args)
    
    {//pass by value 
   
    int student1Grade = 75;//we initialize the variable
    Console.WriteLine("Student's grade before extra credit: {0}", student1Grade); //display the before credit grade

    ExtraCredit(student1Grade);//Then we call the other method and put the initalized variable in the paranthesis



        //pass by reference type 
        //the new keyword is what makes a reference type
        int[] grades =  new int[1];
        grades[0] = 75;

    Console.ReadLine();


    }

    public static void ExtraCredit(int studentsGrade)
    {
            //pasing by value
        studentsGrade +=3;
        //if we put the console display in main it will not show what we want it will reset to the default value
        Console.WriteLine("Student's grade after extra credit: {0}" ,studentsGrade);//this ensures that our initial value is changed
    }
}