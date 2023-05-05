namespace SimpleAdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITarget myTarget = new Adapter();
            Console.WriteLine(myTarget.SampleMethod(12));
        }
    }
}