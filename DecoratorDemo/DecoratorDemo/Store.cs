using DecoratorDemo.Component;
using DecoratorDemo.ConreteComponent;
using DecoratorDemo.ConreteDecorator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorDemo
{
    public partial class Store : Form
    {
        private List<string> orderList;
        public Store()
        {
            InitializeComponent();
            orderList = new List<string>();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.ImageLocation = "E:\\tomato.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.ImageLocation = "E:\\hen.png";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPizza myPizza;
            if (radioButton2.Checked)
            { 
                //tao pizza goc
                myPizza = new TomatoPizza();               
            }
            else
            {
                //tao pizza goc
                myPizza = new ChickenPizza();
            }

            //them thanh phan pepper
            if (numericUpDown1.Value != 0)
            {
                myPizza = createPepperInstansce(myPizza, numericUpDown1.Value);
            }

            //them thanh phan pepper
            if (numericUpDown2.Value != 0)
            {
                myPizza = createCheeseInstansce(myPizza, numericUpDown2.Value);
            }

            //lay danh sach hinh
            List<string> listOrder = myPizza.doPizza();

            //them hinh 
            for (int i = 0; i < listOrder.Count; i++)
            {
                PictureBox img = new PictureBox();
                img.Size = new Size(130, 100);
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                img.ImageLocation = listOrder[i];
                flowLayoutPanel1.Controls.Add(img);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            flowLayoutPanel1.Controls.Clear();
        }
        public IPizza createPepperInstansce(IPizza pizza, decimal cout)
        {
            for (int i = 0; i < cout; i++)
            {
                pizza = new PepperDecorator(pizza);

            }
            return pizza;
        }
        public IPizza createCheeseInstansce(IPizza pizza, decimal cout)
        {
            for (int i = 0; i < cout; i++)
            {
                pizza = new CheeseDecorator(pizza);

            }
            return pizza;
        }
    }

}
