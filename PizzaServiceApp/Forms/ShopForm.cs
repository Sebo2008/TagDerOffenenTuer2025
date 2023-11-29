using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaServiceApp.Forms
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            Discounts.InitializeCuponCodes();
            Discounts.CalculateTotalPrice();
            label1.Text = Discounts.currentTotalPrice.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Discounts.CheckCode(textBox1.Text.ToString());
            Discounts.CalculateTotalPrice();
            label1.Text = Discounts.currentTotalPrice.ToString();
        }

        private void PizzaListe_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}