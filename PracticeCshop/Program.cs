using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCshop
{

    class Program 
    {
        static void Main(string[] args)
        {
            #region Generic 泛型
            //Console.WriteLine(Generic.Max<int>(5,6));
            //Console.WriteLine(Generic.Max<float>(5.2f, 6));
            
            #endregion

            #region 具名委派
            Cust AkiSaan = new Cust();
            Chef BigChef = new Chef();
            PrepairFood order_steak = new PrepairFood(BigChef.Steak);
            PrepairFood order_beef = new PrepairFood(BigChef.RoatBeef);
            PrepairFood order_chicken = new PrepairFood(BigChef.Rried_chicken);
            AkiSaan.hungry(order_steak);
            //匿名委派
            AkiSaan.hungry( BigChef.RoatBeef);
            #endregion



            Console.ReadKey();
        }
    }

    class Generic
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {

                return b;
            }
        }

    }

    #region 具名委派
    public delegate void PrepairFood();
    public class Cust {
        public void hungry(PrepairFood chef) {
            chef();
        }
    }

    public class Chef {
        public void Rried_chicken() {
            Console.WriteLine("炸雞完成!!");
        }
        public void Steak()
        {
            Console.WriteLine("牛排完成!!");
        }
        public void RoatBeef ()
        {
            Console.WriteLine("烤牛肉完成!!");
        }

    }

    #endregion

}
