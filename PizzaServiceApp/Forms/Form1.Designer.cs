namespace PizzaServiceApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            order = new Button();
            splitter1 = new Splitter();
            cmb_pizza = new ComboBox();
            tb_Schaerfe = new TrackBar();
            text_spicy = new Label();
            add_pizza = new Button();
            listBox1 = new ListBox();
            deinebestellung = new Label();
            checkedListBox1 = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)tb_Schaerfe).BeginInit();
            SuspendLayout();
            // 
            // order
            // 
            order.Location = new Point(578, 375);
            order.Name = "order";
            order.Size = new Size(139, 49);
            order.TabIndex = 0;
            order.Text = "Order";
            order.UseVisualStyleBackColor = true;
            order.Click += order_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(511, 450);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // cmb_pizza
            // 
            cmb_pizza.FormattingEnabled = true;
            cmb_pizza.Location = new Point(63, 57);
            cmb_pizza.Name = "cmb_pizza";
            cmb_pizza.Size = new Size(121, 23);
            cmb_pizza.TabIndex = 2;
            cmb_pizza.Tag = "";
            cmb_pizza.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tb_Schaerfe
            // 
            tb_Schaerfe.Location = new Point(63, 249);
            tb_Schaerfe.Maximum = 5;
            tb_Schaerfe.Name = "tb_Schaerfe";
            tb_Schaerfe.Size = new Size(314, 45);
            tb_Schaerfe.TabIndex = 6;
            tb_Schaerfe.Scroll += trackBar1_Scroll;
            // 
            // text_spicy
            // 
            text_spicy.AutoSize = true;
            text_spicy.Location = new Point(63, 218);
            text_spicy.Name = "text_spicy";
            text_spicy.Size = new Size(82, 15);
            text_spicy.TabIndex = 9;
            text_spicy.Text = "Level of Spicy:";
            // 
            // add_pizza
            // 
            add_pizza.Location = new Point(109, 347);
            add_pizza.Name = "add_pizza";
            add_pizza.Size = new Size(75, 23);
            add_pizza.TabIndex = 10;
            add_pizza.Text = "Add ";
            add_pizza.UseVisualStyleBackColor = true;
            add_pizza.Click += add_pizza_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(578, 141);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(129, 109);
            listBox1.TabIndex = 11;
            // 
            // deinebestellung
            // 
            deinebestellung.AutoSize = true;
            deinebestellung.Location = new Point(578, 80);
            deinebestellung.Name = "deinebestellung";
            deinebestellung.Size = new Size(88, 15);
            deinebestellung.TabIndex = 12;
            deinebestellung.Text = "Selected Pizzas:";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(63, 121);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(195, 94);
            checkedListBox1.TabIndex = 13;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(deinebestellung);
            Controls.Add(listBox1);
            Controls.Add(add_pizza);
            Controls.Add(text_spicy);
            Controls.Add(tb_Schaerfe);
            Controls.Add(cmb_pizza);
            Controls.Add(splitter1);
            Controls.Add(order);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tb_Schaerfe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button order;
        private Splitter splitter1;
        private ComboBox cmb_pizza;
        private TrackBar tb_Schaerfe;
        private Label text_spicy;
        private Button add_pizza;
        private ListBox listBox1;
        private Label deinebestellung;
        private CheckedListBox checkedListBox1;
    }
}