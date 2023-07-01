using Lab3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        ITIContext db = new Models.ITIContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dataGridViewStudents.DataSource= db.Students.Include(s=> s.Dept)
                .Select(s=> new {s.StId,s.StFname,s.StLname,s.Dept.DeptName}).ToList();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
