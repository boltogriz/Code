// See https://aka.ms/new-console-template for more information

MyProgram.Method();

class A
{
    public int a = 1;
}
class B
{
    public int b = 2;
}
class C
{
    public B B = new B();
}
class X
{
    public A A = new A();
    public C C = new C();
}
class MyProgram : X
{
    public static void Method()
    {
        MyProgram original = new MyProgram();
        Console.WriteLine("Оригинал : " + original.A.a + " " + original.C.B.b);

        MyProgram clone = original.MemberwiseClone() as MyProgram;
        Console.WriteLine("Клон : " + clone.A.a + " " + clone.C.B.b + "\n");
        clone.A.a = clone.C.B.b = 7;
        Console.WriteLine("Оригинал : " + original.A.a + " " + original.C.B.b);
        Console.WriteLine("Клон : " + clone.A.a + " " + clone.C.B.b);
    }
}


