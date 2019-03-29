using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guessanumber
{
    public partial class FirstForm : Form
    {
        SecondForm form_2;
        public int MaximumNumber { get; set; }

        public FirstForm()
        {
            InitializeComponent();
            MaximumNumber = 10;
            form_2 = new SecondForm(this, MaximumNumber);
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {
            
        }

        private void TitleName_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            

        }

        private void Button1to10_Click(object sender, EventArgs e)
        {
            CreateSecondForm(Button1to10.Text);
            MaximumNumber = 10;
        }

        private void Button1to20_Click(object sender, EventArgs e)
        {
            CreateSecondForm(Button1to20.Text);
            MaximumNumber = 20;
        }

        private void Button1to50_Click(object sender, EventArgs e)
        {
            CreateSecondForm(Button1to50.Text);
            MaximumNumber = 50;
        }

        private void CreateSecondForm(string label)
        {
            form_2.AssignLabel(label);
            form_2.Show();
            Application.OpenForms["FirstForm"].Hide();
        }
    }
}
