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
            button_schaerfe = new RadioButton();
            extracheesebutton = new RadioButton();
            pineapple_button = new RadioButton();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Tag = "";
            // 
            // button_schaerfe
            // 
            button_schaerfe.AutoSize = true;
            button_schaerfe.Location = new Point(63, 129);
            button_schaerfe.Name = "button_schaerfe";
            button_schaerfe.Size = new Size(97, 19);
            button_schaerfe.TabIndex = 3;
            button_schaerfe.TabStop = true;
            button_schaerfe.Text = "Level of Spice";
            button_schaerfe.UseVisualStyleBackColor = true;
            button_schaerfe.CheckedChanged += button_schaerfe_CheckedChanged;
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
            // pineapple_button
            // 
            pineapple_button.AutoSize = true;
            pineapple_button.Location = new Point(63, 154);
            pineapple_button.Name = "pineapple_button";
            pineapple_button.Size = new Size(106, 19);
            pineapple_button.TabIndex = 5;
            pineapple_button.TabStop = true;
            pineapple_button.Text = "extra pineapple";
            pineapple_button.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(63, 293);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(331, 45);
            trackBar1.TabIndex = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar1);
            Controls.Add(pineapple_button);
            Controls.Add(extracheesebutton);
            Controls.Add(button_schaerfe);
            Controls.Add(comboBox1);
            Controls.Add(splitter1);
            Controls.Add(order);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button order;
        private Splitter splitter1;
        private ComboBox comboBox1;
        private RadioButton button_schaerfe;
        private RadioButton extracheesebutton;
        private RadioButton pineapple_button;
        private TrackBar trackBar1;
    }
}