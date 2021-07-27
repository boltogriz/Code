using System;

namespace Animal
{
    class Program
    {
        class Animal
        {
            protected string Sound { get; set; }
            public void MakeSound() => Console.WriteLine(Sound);
        }
        class Dog : Animal
        {
            //private string Sound { get; set; } = "Woof-Woof";
            public Dog() => Sound = "Woof-Woof";
            public void BringStick() => Console.WriteLine("Bring a stick");
        }
        class Cat : Animal 
        {
            //private string Sound { get; set; } = "Meow-Meow";
            public Cat() => Sound = "Meow-Meow";
            
            public void CatchMouse() => Console.WriteLine("Catch the mouse");
        }
        static void Main(string[] args)
        {
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
            // 1. Опасное (явное) приведение
            if (false)
            {
                Animal animal = animals[0];

                Dog myDog = (Dog)animal;
                myDog.BringStick();

                Cat myCat = (Cat)animal;
                myCat.CatchMouse();
            }
        }
    }
}
