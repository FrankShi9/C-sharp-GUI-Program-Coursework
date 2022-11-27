using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS2
{
    public partial class Form1 : Form
    {
        int last = 1;
        public Form1()
        {
            InitializeComponent();
        }

        List<Country> countries = new List<Country>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            last = 1;
            int size = 0;
            if (txtName.Text == "" || !int.TryParse(txtPop.Text, out size))
            {
                MessageBox.Show("illegal error");
                return;
            }

            Country c = new Country(txtName.Text, size);
            //Console.WriteLine(size.ToString());
            //Console.WriteLine(c.size);

            if (CountryList.SelectedItems.Count != 0)
            {
                countries.Insert(CountryList.SelectedIndices[0], c);
            }
            countries.Add(c);

            UpdateList();
        }

        private void UpdateList()
        {
            CountryList.Items.Clear();
            foreach (Country c in countries)
            {
                string[] ca = new string[3];
                ListViewItem itm;
                ca[0] = c.name;
                ca[1] = c.size.ToString();
                itm = new ListViewItem(ca);
                CountryList.Items.Add(itm);

            }
        }

        private void btnRemov_Click(object sender, EventArgs e)
        {
            last = 2;
            // default value
            //if (CountryList.SelectedIndices[0] == -1)
            if (countries.Count == 0){
                MessageBox.Show("illegal error");
                return;
            }
            int buf = CountryList.SelectedIndices[0];
            countries.RemoveAt(CountryList.SelectedIndices[0]);
            //UpdateList();
            if(CountryList.Items.Count > 1) { 
                CountryList.Items.RemoveAt(CountryList.SelectedIndices[0]);
                CountryList.Items[buf].Selected = true;
                CountryList.Select();
            }else{
                CountryList.Items.RemoveAt(CountryList.SelectedIndices[0]);
                return;
            }
        }

        private void UpdateInfo(object sender, EventArgs e)
        {
            if (CountryList.SelectedItems.Count == 0) return;
            if (countries.Count == 0) return;
            Console.WriteLine(CountryList.SelectedIndices[0]);
            Country c = countries[CountryList.SelectedIndices[0]];
            txtName.Text = c.name;
            txtPop.Text = c.size.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            last = 3;
            int size = 0;
            if (countries.Count == 0 || txtName.Text == "" || !int.TryParse(txtPop.Text, out size))
            {
                MessageBox.Show("illegal error");
                return;
            }

            Country c = new Country(txtName.Text, size);
            countries[CountryList.SelectedIndices[0]] = c;

            UpdateList();
        }

        private void Sort(object sender, ColumnClickEventArgs e)
        {
            //Console.WriteLine(e.Column);
            //Console.WriteLine(CountryList.Columns);
            int buf = CountryList.SelectedIndices[0];
            if (e.Column == 0)
            {
                if (CountryList.Columns[0].Text == "Name↓")
                {
                    IEnumerable<Country> sc =
                    from c in countries
                    orderby c.name descending
                    select c;

                    CountryList.Items.Clear();
                    foreach (Country c in sc)
                    {
                        string[] ca = new string[3];
                        ListViewItem itm;
                        ca[0] = c.name;
                        ca[1] = c.size.ToString();
                        itm = new ListViewItem(ca);
                        CountryList.Items.Add(itm);
                    }

                    CountryList.Columns[0].Text = "Name↑";
                }
                else
                {
                    IEnumerable<Country> sc =
                    from c in countries
                    orderby c.name ascending
                    select c;

                    CountryList.Items.Clear();
                    foreach (Country c in sc)
                    {
                        string[] ca = new string[3];
                        ListViewItem itm;
                        ca[0] = c.name;
                        ca[1] = c.size.ToString();
                        itm = new ListViewItem(ca);
                        CountryList.Items.Add(itm);
                    }

                    CountryList.Columns[0].Text = "Name↓";
                }
            }
            if (e.Column == 1)
            {
                if (CountryList.Columns[1].Text == "Population Size↓")
                {
                    IEnumerable<Country> sc =
                    from c in countries
                    orderby c.size descending
                    select c;

                    CountryList.Items.Clear();
                    foreach (Country c in sc)
                    {
                        string[] ca = new string[3];
                        ListViewItem itm;
                        ca[0] = c.name;
                        ca[1] = c.size.ToString();
                        itm = new ListViewItem(ca);
                        CountryList.Items.Add(itm);
                    }

                    CountryList.Columns[1].Text = "Population Size↑";
                }
                else
                {
                    IEnumerable<Country> sc =
                    from c in countries
                    orderby c.size ascending
                    select c;

                    CountryList.Items.Clear();
                    foreach (Country c in sc)
                    {
                        string[] ca = new string[3];
                        ListViewItem itm;
                        ca[0] = c.name;
                        ca[1] = c.size.ToString();
                        itm = new ListViewItem(ca);
                        CountryList.Items.Add(itm);
                    }

                    CountryList.Columns[1].Text = "Population Size↓";
                }
            }
            CountryList.Items[countries.Count-1-buf].Selected = true;
            CountryList.Select();
        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13){
                //Console.WriteLine("enter");
                switch (last)
                {
                    case 1:
                        btnAdd_Click(null, null);
                        break;
                    case 2:
                        btnRemov_Click(null, null);
                        break;
                    case 3:
                        btnUpdate_Click(null, null);
                        break;
                }
            }
            return;
        }
    }
}
