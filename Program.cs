using OOP_which_print_out_learners_details;

class Program
{
    static void Main(string[] args)
    {

        Learners learner1 = new Learners(" Petrus", "Shai", " Systems Development", "1 year", 1800);
        Learners learner2 = new Learners(" Precious", "Mpuru", " Systems Development", "1 year", 1800);
        Learners learner3 = new Learners(" Thuli", "Baloyi", " Systems Development", "1 year", 1800);
        Learners learner4 = new Learners(" Malesela", "Letsoalo", " Systems Development", "1 year", 1800);

        Console.WriteLine(learner1.name + " " + learner1.surname + " " + learner1.course + " " + learner1.duration + " " + learner1.price);
        Console.WriteLine(learner2.name + " " + learner2.surname + " " + learner2.course + " " + learner2.duration + " " + learner2.price);
        Console.WriteLine(learner3.name + " " + learner3.surname + " " + learner3.course + " " + learner3.duration + " " + learner3.price);
        Console.WriteLine(learner4.name + " " + learner4.surname + " " + learner4.course + " " + learner4.duration + " " + learner4.price);
    }
}
