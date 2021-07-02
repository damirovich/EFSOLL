﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var db = new Model001Container();
            var student = from s in db.StudentSet select s;
            if (student != null) {
                if (student.Count() > 0)
                {
                    dataGridView1.DataSource = student.ToList();
                }
                else {
                    MessageBox.Show("Ошибка","Нет данных в БД", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = null;
                }
            }
        }
    }
}
