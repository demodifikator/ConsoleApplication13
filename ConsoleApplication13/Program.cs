using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    public class Bake
    {
        private int Temperature;

        public int TemperatureProp
        {
            get
            {
                return Temperature;
            }

            set
            {
                if (value > 200 || value < 0)
                    Console.WriteLine("It's wrong!");
                else Temperature = value;
            }
        }
    }
    public virtual void OnBake()
    {

    }

    public class ElectricBake: Bake
    {
        public override void OnBake();
        public void OnBake()
        {
            Console.WriteLine("Electric bake is heating!");
        }
    }
    public class GasBake: Bake
    {
        public void OnBake()
        {
            Console.WriteLine("Gas bake is heating!");
        }
    }
    class Ivan
    {
        public string Name{ get; set; }

        public void OnBake(Bake bake)
        {
            bake.OnBake();
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bake bake = new Bake();
            bake.TemperatureProp = 1;
            Console.WriteLine(bake.TemperatureProp);
            ElectricBake electricBake = new ElectricBake();
            electricBake.TemperatureProp = 16;

            Ivan ivan = new Ivan();
            ivan.OnBake;
        }
    }
}
