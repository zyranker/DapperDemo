using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DapperDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.dgvPersonList.AutoGenerateColumns = false;
            DisPlayDataOnDgv(LoadPersonList());
            this.cboProv.DataSource = ps.ProvinceList;
            this.cboProv.SelectedIndexChanged -= new System.EventHandler(this.cboProv_SelectedIndexChanged);

        }
        PersonService ps = new PersonService();
        private List<Person> LoadPersonList()
        {
            return ps.GetAllPersons();

        }

        private void btnGetPerById_Click(object sender, EventArgs e)
        {
            string id = numericUpDown1.Value.ToString();
            var person = ps.GetPersonById(id);
            DisPlayDataOnDgv(person);
        }

        private void btnGetPerByLastName_Click(object sender, EventArgs e)
        {
            string lastName = this.txtLastName.Text.Trim();
            if (string.IsNullOrEmpty(lastName))
                return;
            var person = ps.GetPersonByLastName(lastName);
            DisPlayDataOnDgv(person);
        }
        private void DisPlayDataOnDgv(List<Person> personList)
        {
            this.dgvPersonList.DataSource = null;
            this.dgvPersonList.DataSource = personList;
            for (int i = 0; i < this.dgvPersonList.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dgvPersonList.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            var personList = LoadPersonList();
            DisPlayDataOnDgv(personList);
        }

        private void tsmlDeletel_Click(object sender, EventArgs e)
        {
            string id = this.dgvPersonList.CurrentRow.Cells[0].Value.ToString();
            if (ps.DeletePersonById(id))
            {
                DisPlayDataOnDgv(LoadPersonList());
                MessageBox.Show("删除成功");
            }
            else
                MessageBox.Show("删除失败");
        }

        private void cboProv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string province = this.cboProv.SelectedValue.ToString();
            var person = ps.GetPersonByProvince(province);
            DisPlayDataOnDgv(person);
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.cboProv.SelectedIndexChanged += new System.EventHandler(this.cboProv_SelectedIndexChanged);
            timer1.Start();

        }

        private void btnOrderByAge_Click(object sender, EventArgs e)
        {
            var pList = (List<Person>)this.dgvPersonList.DataSource;
            pList = pList.OrderByDescending(item => item.Age).ToList();
            DisPlayDataOnDgv(pList);
        }
        IEnumerable<IGrouping<int, Person>> pGroup = null;
        private void btnGroupByAge_Click(object sender, EventArgs e)
        {
            var dataSource = new List<Person>();
            var pList = (List<Person>)this.dgvPersonList.DataSource;
            pGroup = pList.GroupBy(item => item.Age);
            var ageList = new List<int>();

            pGroup.ToList().ForEach(item => ageList.Add(item.Key));

            ageList.Sort();
            this.cboAge.DataSource = ageList;
            DisPlayDataOnDgv(dataSource);
        }

        private void cboAge_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonOrderbyAge(pGroup, (int)this.cboAge.SelectedValue);
        }
        private void PersonOrderbyAge(IEnumerable<IGrouping<int, Person>> pGroup, int age)
        {
            var dataSource = new List<Person>();
            pGroup.ToList().ForEach((item) =>
            {
                if (item.Key == age)
                {
                    item.ToList().ForEach((p) =>
                    {
                        dataSource.Add(p);
                    });
                }
            });

            DisPlayDataOnDgv(dataSource);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    this.Text = DateTime.Now.ToString();
                }));
            });
        }
    }
}
