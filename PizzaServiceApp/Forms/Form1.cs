using PizzaServiceApp.PizzaObject;

namespace PizzaServiceApp
{
    public partial class Form1 : Form



    {


        public bool cheese { get; set; }


        public Form1()
        {
            InitializeComponent();

            foreach (var item in PizzaObject.PizzaObject.standartPizzasHashSet)
            {
                cmb_pizza.Items.Add(item);


            }
        }

        private void order_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void extra_cheese_CheckedChanged(object sender, EventArgs e)
        {
            if (extra_cheese.Checked) ;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }
    }
}