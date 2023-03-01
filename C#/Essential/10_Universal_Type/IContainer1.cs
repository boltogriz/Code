namespace _10_Universal_Type
{
    public interface IContainer1<T>
    {
        int ATest1 { get; set; }
        int ATest2 { get; set; }
        T Figure { set; }

        string ToString();
    }
}