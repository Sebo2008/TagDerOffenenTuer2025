using PizzaServiceApp.PizzaObject;

namespace PizzaServiceApp
{
    public partial class Form1 : Form



    {
        public PizzaObject.PizzaObject Pizza { get; set; }
        public PizzaObject.PizzaObject Pizzaadded { get; set; }
        public List<string> list { get; set; } = new();

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

            foreach (var item in IngredientObject.StandartIngredients)
            {
                checkedListBox1.Items.Add(item.ingredientName);
            }

            cmb_pizza.SelectedIndex = 0;
        }

        private void order_Click(object sender, EventArgs e)
        {
            this.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void extra_cheese_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void add_pizza_Click(object sender, EventArgs e)
        {
            string extrasString = string.Empty;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                extrasString += $"{item} ";
            }

            MessageBox.Show($"You added {cmb_pizza.SelectedItem} with {extrasString.Trim()}. Level of Spicy: {tb_Schaerfe.Value} to your ordering list");
            
            PizzaObject.Order.AddPizzaToOrder( Convert.ToString(cmb_pizza.SelectedItem),Convert.ToInt32(tb_Schaerfe.Value), checkedListBox1.CheckedItems.OfType<string>().ToList());

            this.list.Add((string)cmb_pizza.SelectedItem);
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }

            this.list.Clear();
        }



        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {






            var test = checkedListBox1.SelectedItems;

        }
    }
}