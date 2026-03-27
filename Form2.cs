using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labka8
{
    public partial class Form2 : Form
    {
        private List<double> numbers = new List<double>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtInput.Text, out double num))
            {
                numbers.Add(num);
                UpdateList();
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            numbers.Sort();
            UpdateList();
        }

        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            numbers = numbers.OrderByDescending(x => x).ToList();
            UpdateList();
        }
        private void UpdateList()
        {
            lstNumbers.Items.Clear();
            foreach (var n in numbers)
            {
                lstNumbers.Items.Add(n);
            }
        }
    }
}
