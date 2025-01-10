namespace ListenEinfuehrung
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            emptyListButton = new Button();
            newRandomInts = new Button();
            sortList = new Button();
            AddToEnd = new Button();
            AddAtIndex = new Button();
            zickZack = new Button();
            newRandomIntsProperties = new Panel();
            confirmNewRandomInts = new Button();
            newRandomIntsMin = new TextBox();
            newRandomIntsMax = new TextBox();
            newRandomIntsCount = new TextBox();
            listView1 = new ListView();
            addToEndProperties = new Panel();
            confirmAddToEnd = new Button();
            addToEndObj = new TextBox();
            addAtIndexProperties = new Panel();
            addAtIndexObj = new TextBox();
            confirmAddAtIndex = new Button();
            addAtIndexIndex = new TextBox();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            newRandomIntsProperties.SuspendLayout();
            addToEndProperties.SuspendLayout();
            addAtIndexProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // emptyListButton
            // 
            emptyListButton.Location = new Point(9, 45);
            emptyListButton.Margin = new Padding(4, 2, 4, 2);
            emptyListButton.Name = "emptyListButton";
            emptyListButton.Size = new Size(201, 100);
            emptyListButton.TabIndex = 0;
            emptyListButton.Text = "EMPTY LIST";
            emptyListButton.UseVisualStyleBackColor = true;
            emptyListButton.Click += emptyListButton_Click;
            // 
            // newRandomInts
            // 
            newRandomInts.Location = new Point(9, 150);
            newRandomInts.Margin = new Padding(4, 2, 4, 2);
            newRandomInts.Name = "newRandomInts";
            newRandomInts.Size = new Size(201, 100);
            newRandomInts.TabIndex = 1;
            newRandomInts.Text = "FILL WITH RANDOM INTS";
            newRandomInts.UseVisualStyleBackColor = true;
            newRandomInts.Click += NewRandomInts_Click;
            // 
            // sortList
            // 
            sortList.Location = new Point(9, 255);
            sortList.Margin = new Padding(4, 2, 4, 2);
            sortList.Name = "sortList";
            sortList.Size = new Size(201, 100);
            sortList.TabIndex = 2;
            sortList.Text = "SORT LIST";
            sortList.UseVisualStyleBackColor = true;
            sortList.Click += SortList_Click;
            // 
            // AddToEnd
            // 
            AddToEnd.Location = new Point(9, 360);
            AddToEnd.Margin = new Padding(4, 2, 4, 2);
            AddToEnd.Name = "AddToEnd";
            AddToEnd.Size = new Size(201, 100);
            AddToEnd.TabIndex = 3;
            AddToEnd.Text = "ADD NEW INT TO END OF LIST";
            AddToEnd.UseVisualStyleBackColor = true;
            AddToEnd.Click += AddToEnd_Click;
            // 
            // AddAtIndex
            // 
            AddAtIndex.Location = new Point(9, 465);
            AddAtIndex.Margin = new Padding(4, 2, 4, 2);
            AddAtIndex.Name = "AddAtIndex";
            AddAtIndex.Size = new Size(201, 100);
            AddAtIndex.TabIndex = 4;
            AddAtIndex.Text = "AddAtIndex";
            AddAtIndex.UseVisualStyleBackColor = true;
            AddAtIndex.Click += AddAtIndex_Click;
            // 
            // zickZack
            // 
            zickZack.Location = new Point(9, 570);
            zickZack.Margin = new Padding(4, 2, 4, 2);
            zickZack.Name = "zickZack";
            zickZack.Size = new Size(201, 100);
            zickZack.TabIndex = 5;
            zickZack.Text = "ZickZack";
            zickZack.UseVisualStyleBackColor = true;
            zickZack.Click += ZickZack_Click;
            // 
            // newRandomIntsProperties
            // 
            newRandomIntsProperties.Controls.Add(confirmNewRandomInts);
            newRandomIntsProperties.Controls.Add(newRandomIntsMin);
            newRandomIntsProperties.Controls.Add(newRandomIntsMax);
            newRandomIntsProperties.Controls.Add(newRandomIntsCount);
            newRandomIntsProperties.Location = new Point(219, 149);
            newRandomIntsProperties.Margin = new Padding(6);
            newRandomIntsProperties.Name = "newRandomIntsProperties";
            newRandomIntsProperties.Size = new Size(243, 245);
            newRandomIntsProperties.TabIndex = 9;
            newRandomIntsProperties.Visible = false;
            // 
            // confirmNewRandomInts
            // 
            confirmNewRandomInts.Location = new Point(6, 192);
            confirmNewRandomInts.Margin = new Padding(6);
            confirmNewRandomInts.Name = "confirmNewRandomInts";
            confirmNewRandomInts.Size = new Size(229, 47);
            confirmNewRandomInts.TabIndex = 3;
            confirmNewRandomInts.Text = "Confirm";
            confirmNewRandomInts.UseVisualStyleBackColor = true;
            confirmNewRandomInts.Click += confirmNewRandomInts_Click;
            // 
            // newRandomIntsMin
            // 
            newRandomIntsMin.Anchor = AnchorStyles.None;
            newRandomIntsMin.Location = new Point(6, 68);
            newRandomIntsMin.Margin = new Padding(6);
            newRandomIntsMin.Name = "newRandomIntsMin";
            newRandomIntsMin.PlaceholderText = "Min";
            newRandomIntsMin.Size = new Size(229, 39);
            newRandomIntsMin.TabIndex = 1;
            // 
            // newRandomIntsMax
            // 
            newRandomIntsMax.Location = new Point(6, 130);
            newRandomIntsMax.Margin = new Padding(6);
            newRandomIntsMax.Name = "newRandomIntsMax";
            newRandomIntsMax.PlaceholderText = "Max";
            newRandomIntsMax.Size = new Size(229, 39);
            newRandomIntsMax.TabIndex = 2;
            // 
            // newRandomIntsCount
            // 
            newRandomIntsCount.Location = new Point(6, 6);
            newRandomIntsCount.Margin = new Padding(6);
            newRandomIntsCount.Name = "newRandomIntsCount";
            newRandomIntsCount.PlaceholderText = "Count";
            newRandomIntsCount.Size = new Size(229, 39);
            newRandomIntsCount.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            listView1.Location = new Point(948, 45);
            listView1.Name = "listView1";
            listView1.Size = new Size(240, 625);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.SmallIcon;
            // 
            // addToEndProperties
            // 
            addToEndProperties.AutoSize = true;
            addToEndProperties.Controls.Add(confirmAddToEnd);
            addToEndProperties.Controls.Add(addToEndObj);
            addToEndProperties.Location = new Point(219, 361);
            addToEndProperties.Margin = new Padding(6);
            addToEndProperties.Name = "addToEndProperties";
            addToEndProperties.Size = new Size(243, 111);
            addToEndProperties.TabIndex = 0;
            addToEndProperties.Visible = false;
            // 
            // confirmAddToEnd
            // 
            confirmAddToEnd.Location = new Point(8, 57);
            confirmAddToEnd.Margin = new Padding(6);
            confirmAddToEnd.Name = "confirmAddToEnd";
            confirmAddToEnd.Size = new Size(229, 47);
            confirmAddToEnd.TabIndex = 13;
            confirmAddToEnd.Text = "Confirm";
            confirmAddToEnd.UseVisualStyleBackColor = true;
            confirmAddToEnd.Click += confirmAddToEnd_Click;
            // 
            // addToEndObj
            // 
            addToEndObj.Location = new Point(6, 6);
            addToEndObj.Margin = new Padding(6);
            addToEndObj.Name = "addToEndObj";
            addToEndObj.PlaceholderText = "Int";
            addToEndObj.Size = new Size(229, 39);
            addToEndObj.TabIndex = 12;
            // 
            // addAtIndexProperties
            // 
            addAtIndexProperties.AutoSize = true;
            addAtIndexProperties.Controls.Add(addAtIndexObj);
            addAtIndexProperties.Controls.Add(confirmAddAtIndex);
            addAtIndexProperties.Controls.Add(addAtIndexIndex);
            addAtIndexProperties.Location = new Point(219, 465);
            addAtIndexProperties.Margin = new Padding(6);
            addAtIndexProperties.Name = "addAtIndexProperties";
            addAtIndexProperties.Size = new Size(243, 161);
            addAtIndexProperties.TabIndex = 10;
            addAtIndexProperties.Visible = false;
            // 
            // addAtIndexObj
            // 
            addAtIndexObj.Location = new Point(6, 57);
            addAtIndexObj.Margin = new Padding(6);
            addAtIndexObj.Name = "addAtIndexObj";
            addAtIndexObj.PlaceholderText = "Int";
            addAtIndexObj.Size = new Size(229, 39);
            addAtIndexObj.TabIndex = 13;
            // 
            // confirmAddAtIndex
            // 
            confirmAddAtIndex.Location = new Point(6, 108);
            confirmAddAtIndex.Margin = new Padding(6);
            confirmAddAtIndex.Name = "confirmAddAtIndex";
            confirmAddAtIndex.Size = new Size(229, 47);
            confirmAddAtIndex.TabIndex = 13;
            confirmAddAtIndex.Text = "Confirm";
            confirmAddAtIndex.UseVisualStyleBackColor = true;
            confirmAddAtIndex.Click += confirmAddAtIndex_Click;
            // 
            // addAtIndexIndex
            // 
            addAtIndexIndex.Location = new Point(6, 6);
            addAtIndexIndex.Margin = new Padding(6);
            addAtIndexIndex.Name = "addAtIndexIndex";
            addAtIndexIndex.PlaceholderText = "Index";
            addAtIndexIndex.Size = new Size(229, 39);
            addAtIndexIndex.TabIndex = 12;
            // 
            // chart1
            // 
            chart1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            chart1.Location = new Point(217, 45);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series2";
            chart1.Series.Add(series1);
            chart1.Size = new Size(725, 625);
            chart1.TabIndex = 11;
            chart1.Text = "chart1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1200, 674);
            Controls.Add(addAtIndexProperties);
            Controls.Add(addToEndProperties);
            Controls.Add(listView1);
            Controls.Add(newRandomIntsProperties);
            Controls.Add(zickZack);
            Controls.Add(AddAtIndex);
            Controls.Add(AddToEnd);
            Controls.Add(sortList);
            Controls.Add(newRandomInts);
            Controls.Add(emptyListButton);
            Controls.Add(chart1);
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(1200, 674);
            Name = "Form1";
            Text = "Form1";
            newRandomIntsProperties.ResumeLayout(false);
            newRandomIntsProperties.PerformLayout();
            addToEndProperties.ResumeLayout(false);
            addToEndProperties.PerformLayout();
            addAtIndexProperties.ResumeLayout(false);
            addAtIndexProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button emptyListButton;
        public Button newRandomInts;
        public Button sortList;
        public Button AddToEnd;
        public Button AddAtIndex;
        public Button zickZack;
        public Panel newRandomIntsProperties;
        public TextBox newRandomIntsCount;
        public TextBox newRandomIntsMin;
        public TextBox newRandomIntsMax;
        public Button confirmNewRandomInts;
        private ListView listView1;
        public Panel addToEndProperties;
        public Button confirmAddToEnd;
        public TextBox addToEndObj;
        public Panel addAtIndexProperties;
        public TextBox addAtIndexObj;
        public Button confirmAddAtIndex;
        public TextBox addAtIndexIndex;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
