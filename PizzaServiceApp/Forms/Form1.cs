using PizzaServiceApp.PizzaObject;

namespace PizzaServiceApp
{
    public partial class Form1 : Form



    {
        public PizzaObject.PizzaObject Pizza { get; set; }
        public PizzaObject.PizzaObject Pizzaadded { get; set; }


        public bool cheese { get; set; }


        public Form1()
        {
            InitializeComponent();
            IngredientObject.IngredientsJson();

            PizzaObject.PizzaObject.PizzasJson();

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

        private void add_pizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You added {cmb_pizza.SelectedItem} with {extra_cheese.Text} {extra_Dip.Text}. Level of Spicy: {tb_Schaerfe.Value} to your ordering list");
            
        }



        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}