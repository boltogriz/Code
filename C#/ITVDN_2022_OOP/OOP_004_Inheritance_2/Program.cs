using System.Security.Cryptography.X509Certificates;

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

            if (true)
            {
                Animal animal = animals[0];
                bool dogIsDog = animal is Dog;
                Dog myDog = (dogIsDog == true) ? (Dog)animal : null;
                if (myDog != null)
                    myDog.BringStick();
                Cat myCat = (animal is Cat) ? (Cat)animal : null;
                if (myCat != null)
                    myCat.CatchMouse();
            }
            for (int i = 0; i < animals.Length; i++)
            {
                Animal animal = animals[i];
                if ( animal is Dog)
                {
                    Dog isDog = (Dog)animal;
                    isDog.BringStick();
                }
                else if (animal is Cat)
                {
                    Cat isCat = (Cat)animal;
                    isCat.CatchMouse();
                }
                else 
                {
                    ; // DoNothing
                }
            }
            if (false)
            {
                Animal animl = animals[0];
                Dog MyDog = animl as Dog;
                MyDog?.BringStick();
                Cat myCat = animl as Cat;
                myCat?.CatchMouse();
            }
            if (false)
            {
                Animal animal = animals[0];
                Dog myDog = animal as Dog;
                if (myDog != null)
                    myDog.BringStick();
                Cat myCat = animal as Cat;
                if (myCat != null)
                    myCat.CatchMouse();
            }
            if (false)
            {
                Animal animal = animals[0];

                Dog myDog = (Dog)animal;
                myDog.BringStick();

                Cat myCat = (Cat)animal;
                myCat.CatchMouse();
            }

            Console.ReadKey();
        }
    }
}
