namespace Lab5_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circle positiveRadius = new Circle(2.3);
            }
            catch (InvalidRadiusException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                Circle zeroRadius = new Circle(-2.3);
            }
            catch (InvalidRadiusException e)
            {

                Console.WriteLine(e.Message);
            }

            try
            {
                Circle zeroRadius = new Circle(0);
            }
            catch (InvalidRadiusException e)
            {

                Console.WriteLine(e.Message);
            }

        }
    }
}