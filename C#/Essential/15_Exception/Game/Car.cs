using System;

namespace _15_Exception
{
    class Car
    {
        IBaseEngine engine;
        CarBody carBody;
        
        public Car(int left = 44, int top = 15, IBaseEngine engine = null, CarBody carBody = null)
        {            
            if (engine != null)
                this.engine = engine;
            else
                this.engine = new Engine();
            if (carBody != null)
                this.carBody = carBody;
            else
                this.carBody = new CarBody(left, top);
        }

        public void Show()
        {
            carBody.Draw();
        }

        // Ускорение.
        public int Acceleration(int delta = 1)
        {
            return engine.Accelerate(delta);
        }

        // Торможение.
        public void Braking()
        {

        }
    }
}
