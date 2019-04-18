using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.ConreteDecorator
{
    public abstract class PizzaDecorator : IPizza
    {
        protected IPizza mPizza;
      

        public PizzaDecorator(IPizza pizza)
        {
            mPizza = pizza;
        }

        // set properti
        public void setPizza(IPizza mPizza)
        {
            this.mPizza = mPizza;
        }

        public IPizza getPizza()
        {
            return mPizza;
        }

        //ghi de phuong thuc cua interface IPizza
        public virtual List<string> doPizza()
        {
            return mPizza.doPizza();
        }
    }
}
