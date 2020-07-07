using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleCurdRepository database = new PeopleCurdRepository(); 
            this.dataGridName1.DataSource = database.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        class PeopleCurdRepository : RepositoryBase<People> { } //step2

        class People : DomainModel //step1
        {
            public People()
            {

            }
            //成员方法 行为
            public void Eat(int foodSize)
            {
                HungerIndex += foodSize / 2;
            }
            //成员变量 属性
            int HungerIndex;
            public string IdNumber;    // 唯一标识符
            public string Name;
            public bool Gender;
            public int Age;
            public DateTime Birthday;
            public string Profession;
        }
    }
}

