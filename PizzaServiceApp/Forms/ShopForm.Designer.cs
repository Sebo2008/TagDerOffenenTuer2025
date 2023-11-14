namespace PizzaServiceApp.Forms
{
    partial class ShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Order = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            PizzasAufgelistet = new TextBox();
            SuspendLayout();
            // 
            // Order
            // 
            Order.BackColor = Color.CornflowerBlue;
            Order.Location = new Point(604, 376);
            Order.Name = "Order";
            Order.Size = new Size(184, 71);
            Order.TabIndex = 0;
            Order.Text = "Order";
            Order.UseVisualStyleBackColor = false;
            Order.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.Location = new Point(604, 153);
            button1.Name = "button1";
            button1.Size = new Size(184, 78);
            button1.TabIndex = 1;
            button1.Text = "Enter Coupon Code";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(604, 263);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 57);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // PizzasAufgelistet
            // 
            PizzasAufgelistet.Location = new Point(26, 0);
            PizzasAufgelistet.Multiline = true;
            PizzasAufgelistet.Name = "PizzasAufgelistet";
            PizzasAufgelistet.Size = new Size(397, 458);
            PizzasAufgelistet.TabIndex = 3;
            PizzasAufgelistet.TextChanged += PizzaListe_TextChanged;
            // 
            // ShopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 458);
            Controls.Add(PizzasAufgelistet);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Order);
            Name = "ShopForm";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Order;
        private Button button1;
        private TextBox textBox1;
        private TextBox PizzasAufgelistet;
    }
}