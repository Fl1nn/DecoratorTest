using DecoratorDemo.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDemo.ConreteDecorator
{
    class PepperDecorator:PizzaDecorator
    {
        private string PepperInfor = "C:\\Users\\Lin\\source\\repos\\DecoratorDemo\\DecoratorDemo\\bin\\Debug\\Resources\\tieu.jpg";
        public PepperDecorator(IPizza pizza):base(pizza)
        {
           
        }

        //ghi de phuong thuc cua interface PizzaDecorator
        public override List<string> doPizza()
        {
            List<string> listOrder = mPizza.doPizza();
            listOrder.AddRange(addPepper());
            return listOrder;
        }

        //them pepper
        private List<string> addPepper()
        {
            return new List<string>() { PepperInfor };
        }
    }
}
