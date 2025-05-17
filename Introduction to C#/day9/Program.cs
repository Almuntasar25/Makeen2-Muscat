using System.Drawing;
using System.Reflection;
using static day9.Casheir;

namespace day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vicale vicale = new car("toyota", "2023", "blue");

            //Console.WriteLine(vicale.getData());

            Casheir ch = new Casheir(new Debit());
            ch.Checkout(300);
            //Igrate grate = new Cash();
            //grate.SayHi();
        }

        //    }
        //    abstract class vicale
        //    {
        //        string name;
        //        string model;
        //        string color;

        //        public vicale(string name, string model, string color)
        //        {
        //            this.name = name;
        //            this.model = model;
        //            this.color = color;
        //        }


        //        public abstract string getData();

        //    }
        //// abstract method*******************
        //    class car : vicale
        //    {
        //        public car(string name, string model, string color) : base(name, model, color)
        //        {

        //        }
        //        public override string getData()
        //        {
        //            return base.getData() + "this is a car";
        //        }

        //        // abstract method*******************

        //        class plan : vicale
        //        {
        //            public plan(string name, string model, string color) : base(name, model, color)
        //            {

        //            }
        //            public override string getData()
        //            {
        //                return base.getData() + "this is a plan";
        //            }
        //        }
        //    }

    }

    public interface Imove
    {
        void Move();
    }

    public interface Iflay
    {
        void Iflay();
    }
    public class Casheir
    {
        Ipay ipay;
        private Cash _cash;
        private Debit _Debit;
        // constractor******************

        public Casheir(Ipay ipay)
        {
            this.ipay = ipay;
        }

        public void Checkout(double amount)
        {
            Console.WriteLine(ipay.getPay(amount));
        }
    }
        public interface Ipay
        {
            public string getPay(double amount);
        }

        public interface Igrate
        {
            public void SayHi();
        }

        public class Cash: Ipay
    {
        
            public string getPay(double amount)
            {
           return $"total cash amount  is {amount}";

            }

        }
    class Debit: Ipay
    {
        public string getPay(double amount)
        {
            return $"total Debit amount  is {amount}";

        }
    }

    class visa: Ipay 
    {
        public string getPay(double amount)
        {
            return $"total visa amount  is {amount}";

        }
    }
    
}


