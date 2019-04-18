using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.ConreteDecorator
{
    public class CheeseDecorator:PizzaDecorator
    {
        private string CheeseInfor = "C:\\Users\\Lin\\source\\repos\\DecoratorDemo\\DecoratorDemo\\bin\\Debug\\Resources\\cheese.jpg";

        public CheeseDecorator(IPizza pizza):base(pizza)
        {
            
        }

        //ghi de phuong thuc cua interface PizzaDecorator
        public override List<string> doPizza()
        {
            List<string> listOrder = mPizza.doPizza();
            listOrder.AddRange(addCheese());
            return listOrder;
        }

        //them cheese
        private List<string> addCheese()
        {
            return new List<string>() { CheeseInfor };
        }
    }
}
