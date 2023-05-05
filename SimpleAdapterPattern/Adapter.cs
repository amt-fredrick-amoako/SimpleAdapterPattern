namespace SimpleAdapterPattern
{
    public class Adapter : Adaptee, ITarget
    {
        public int SampleMethod(int y)
        {
            return MyMethod(y);
        }
    }
    /* Class Adapter will subclass an existing class
     * and implement a target interface
     */
}
