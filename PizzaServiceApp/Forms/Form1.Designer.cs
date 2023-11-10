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
            checkBox1 = new CheckBox();
            extra_cheese = new CheckBox();
            text_schaerfe = new Label();
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
            tb_Schaerfe.Location = new Point(63, 190);
            tb_Schaerfe.Name = "tb_Schaerfe";
            tb_Schaerfe.Size = new Size(331, 45);
            tb_Schaerfe.TabIndex = 6;
            tb_Schaerfe.Scroll += trackBar1_Scroll;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(63, 144);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // extra_cheese
            // 
            extra_cheese.AutoSize = true;
            extra_cheese.Location = new Point(63, 119);
            extra_cheese.Name = "extra_cheese";
            extra_cheese.Size = new Size(91, 19);
            extra_cheese.TabIndex = 8;
            extra_cheese.Text = "Extra cheese";
            extra_cheese.UseVisualStyleBackColor = true;
            extra_cheese.CheckedChanged += extra_cheese_CheckedChanged;
            // 
            // text_schaerfe
            // 
            text_schaerfe.AutoSize = true;
            text_schaerfe.Location = new Point(63, 172);
            text_schaerfe.Name = "text_schaerfe";
            text_schaerfe.Size = new Size(55, 15);
            text_schaerfe.TabIndex = 9;
            text_schaerfe.Text = "Schaerfe:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(text_schaerfe);
            Controls.Add(extra_cheese);
            Controls.Add(checkBox1);
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
        private CheckBox checkBox1;
        private CheckBox extra_cheese;
        private Label text_schaerfe;
    }
}