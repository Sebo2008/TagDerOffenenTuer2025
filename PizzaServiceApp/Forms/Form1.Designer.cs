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
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            extracheesebutton = new RadioButton();
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
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(511, 450);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Tag = "";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(63, 129);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(94, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // extracheesebutton
            // 
            extracheesebutton.AutoSize = true;
            extracheesebutton.Location = new Point(63, 196);
            extracheesebutton.Name = "extracheesebutton";
            extracheesebutton.Size = new Size(90, 19);
            extracheesebutton.TabIndex = 4;
            extracheesebutton.TabStop = true;
            extracheesebutton.Text = "extra cheese";
            extracheesebutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(extracheesebutton);
            Controls.Add(radioButton1);
            Controls.Add(comboBox1);
            Controls.Add(splitter1);
            Controls.Add(order);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button order;
        private Splitter splitter1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton extracheesebutton;
    }
}