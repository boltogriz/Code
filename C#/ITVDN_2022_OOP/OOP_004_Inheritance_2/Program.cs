namespace OOP_004_Inheritance_2
{
    class ClassA
    {
        public void MethodA() => Console.WriteLine("ClassA.MethodA");
    }
    class ClassB : ClassA
    {
        #region Composition
        //public void MethodA() => new ClassA().MethodA(); 
        #endregion
        public void MethodB() => Console.WriteLine("ClassB.MethodB");
    }
    class Animal
    {
        protected string Sound { get; init; }
        public void MakeSound() => Console.WriteLine(Sound);
    }
    class Dog : Animal
    {
        public Dog() => Sound = "Woof-Woof";
        public void BringStick() => Console.WriteLine("Bring a stick");
    }
    class Cat : Animal
    {
        public Cat() => Sound = "Meow-Meow";
        public void CatchMouse() => Console.WriteLine("Catch the mouse");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassB instance = new ClassB();
            instance.MethodA();
            instance.MethodB();
            new ClassA().MethodA();

            Animal dog = new Dog(), cat = new Cat();
            Animal[] animals = { dog, cat };
            for (int i = 0; i < animals.Length; i++)
                animals[i].MakeSound();

            Animal animal = animals[0];

            Dog myDog = (Dog)animal;
            myDog.BringStick();

            Cat myCat = (Cat)animal;
            myCat.CatchMouse();

            Console.ReadKey();
        }
    }
}
