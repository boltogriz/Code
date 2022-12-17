namespace _012_Events
{
    public delegate void EventDelegate();
    public class MyClass
    {
        public event EventDelegate myEvent = null;
        public void invokeEvent()
        {
            myEvent.Invoke();
        }
    }
    internal class Program
    {
        static private void Handler1()
        {
            Console.WriteLine("Обработчик события 1");
        }
        static private void Handler2()
        {
            Console.WriteLine("Обработчик события 2");
        }
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();
            instance.myEvent += new EventDelegate(Handler1);
            instance.myEvent += Handler2;
            instance.invokeEvent();
        }
    }
}