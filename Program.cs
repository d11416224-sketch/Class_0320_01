namespace Class_0320_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test joe = new Test();
            Test mary = new Test();

            Test tom;

            //joe.Mid = 80;
            //joe.Final = 76;
            
            joe.SetGrade(80, 76);

            tom = joe;

            //mary.Mid = 65;
            //mary.Final = 80;

            //Console.WriteLine("Joe" + joe.Mid);
            //Console.WriteLine("Joe" + joe.Final);
            Console.WriteLine("Joe" + joe.GetAvg().ToString());


            //Console.WriteLine("Mary" + mary.Mid);
            //Console.WriteLine("Mary" + mary.Final);


            //joe.Mid = 59;
            //joe.Final = 40;

            //Console.WriteLine("Tom" + tom.Mid);
            //Console.WriteLine("Tom" + tom.Final);


        }
    }
}
