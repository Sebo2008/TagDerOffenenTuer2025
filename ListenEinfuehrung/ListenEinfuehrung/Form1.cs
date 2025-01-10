namespace ListenEinfuehrung
{
    public partial class Form1 : Form
    {
        public List<int> list;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            newRandomIntsProperties.Visible = false;
            addToEndProperties.Visible = false;
        }
        public void emptyListButton_Click(object sender, EventArgs e)
        {
            if (this.list != null)
            {
                this.list.Clear();
            }
            updateListView();
        }
        public void NewRandomInts_Click(object sender, EventArgs e)
        {
            newRandomIntsProperties.Visible = true;
        }
        public void confirmNewRandomInts_Click(object sender, EventArgs e)
        {
            ListConfig listConfig = new ListConfig();
            int count;
            int min;
            int max;
            try
            {
                count = Int32.Parse(newRandomIntsCount.Text);
                min = Int32.Parse(newRandomIntsMin.Text);
                max = Int32.Parse(newRandomIntsMax.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
                newRandomIntsCount.Text = "";
                newRandomIntsMin.Text = "";
                newRandomIntsMax.Text = "";
                return;
            }
            list = listConfig.NewRandomInts(this.list, count, min, max);
            updateListView();
            newRandomIntsProperties.Visible = false;
            newRandomIntsCount.Text = "";
            newRandomIntsMin.Text = "";
            newRandomIntsMax.Text = "";
        }
        public void updateListView()
        {
            if (this.list != null)
            {
                listView1.Items.Clear();
                chart1.Series[0].Points.Clear();
                for (int i = 0; i < this.list.Count; i++)
                {
                    listView1.Items.Add(this.list[i].ToString());
                    chart1.Series[0].Points.AddXY(i + 1, this.list[i]);
                }
            }
        }
        public void SortList_Click(object sender, EventArgs e)
        {
            ListConfig listConfig = new ListConfig();
            list = listConfig.SortList(this.list);
            updateListView();
        }
        public void AddToEnd_Click(object sender, EventArgs e)
        {
            addToEndProperties.Visible = true;
        }
        public void confirmAddToEnd_Click(object sender, EventArgs e)
        {
            int obj;
            ListConfig listConfig = new ListConfig();
            try
            {
                obj = Int32.Parse(addToEndObj.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
                addToEndObj.Text = "";
                return;
            }
            list = listConfig.AddAtIndex(this.list, this.list.Count, obj);
            updateListView();
            addToEndProperties.Visible = false;
            addToEndObj.Text = "";
        }
        public void AddAtIndex_Click(object sender, EventArgs e)
        {
            addAtIndexProperties.Visible = true;
        }
        public void confirmAddAtIndex_Click(object sender, EventArgs e)
        {
            int index;
            int obj;
            ListConfig listConfig = new ListConfig();
            try
            {
                index = Int32.Parse(addAtIndexIndex.Text) - 1;
                obj = Int32.Parse(addAtIndexObj.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid integer.");
                addAtIndexObj.Text = "";
                addAtIndexIndex.Text = "";
                return;
            }
            list = listConfig.AddAtIndex(this.list, index, obj);
            updateListView();
            addAtIndexProperties.Visible = false;
            addAtIndexObj.Text = "";
            addAtIndexIndex.Text = "";
        }
        public void ZickZack_Click(object sender, EventArgs e)
        {
            ListConfig listConfig = new ListConfig();
            list = listConfig.SortList(this.list);
            list = listConfig.ZickZack(this.list);
            try
            {
                string dir = Directory.GetCurrentDirectory();
                dir = dir.Remove(dir.IndexOf("bin"));
                dir = dir + "\\zickzack.txt";
                StreamWriter sw = new StreamWriter(dir);
                foreach (int i in this.list)
                {
                    sw.WriteLine(i);
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            updateListView();
        }
    }
}
