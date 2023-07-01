using Lab3.Models;

namespace Lab3
{
    public partial class Form1 : Form
    {
        ITIContext db = new ITIContext();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dataGridViewTopics.DataSource = db.Topics.ToList();
            comboBox1.DataSource = db.Topics.ToList();
            comboBox1.ValueMember = "TopId";
            comboBox1.DisplayMember = "TopName";
        }

        private void Form1_Load(object sender, EventArgs e)            
        {
           LoadData();           

        }

        private void add_Click(object sender, EventArgs e)
        {
            Topic topic = new Topic();
            topic.TopId = int.Parse(textId.Text);
            topic.TopName = textName.Text;
            db.Topics.Add(topic);
            db.SaveChanges();
            LoadData();
        }

        private void delete_Click(object sender, EventArgs e)
        {          

            Topic topic = db.Topics.Where(t=> t.TopId == (int)(comboBox1.SelectedValue)).FirstOrDefault();
            db.Topics.Remove(topic);
            db.SaveChanges();
            LoadData();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            dataGridViewTopics.DataSource=db.Topics.Where(t=> t.TopName.Contains(textSearch.Text)).ToList();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            Topic topic = db.Topics.Where(t => t.TopId == int.Parse(textId.Text)).FirstOrDefault();
            
            topic.TopName = textName.Text;
            db.Update(topic);
            db.SaveChanges();
            LoadData();

        }

        private void dataGridViewTopics_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textId.Text = dataGridViewTopics.SelectedRows[0].Cells[0].Value.ToString();
            textName.Text = dataGridViewTopics.SelectedRows[0].Cells[1].Value.ToString();

        }
    }
}