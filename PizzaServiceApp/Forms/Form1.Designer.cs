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
            trackBar1 = new TrackBar();
            checkBox1 = new CheckBox();
            extra_cheese = new CheckBox();
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
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(63, 293);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(331, 45);
            trackBar1.TabIndex = 6;
            trackBar1.Scroll += trackBar1_Scroll;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(extra_cheese);
            Controls.Add(checkBox1);
            Controls.Add(trackBar1);
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
        private TrackBar trackBar1;
        private CheckBox checkBox1;
        private CheckBox extra_cheese;
    }
}