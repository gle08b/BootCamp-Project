using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_with_menu
{
    public partial class Form1 : Form
    {
        const string _password = "456789";
        public Form1()
        {
            InitializeComponent();
        }
        private void lblLinkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new Form3();
            frm.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        enterPassword:
            string password = Form2.Show("Пароль", "Введите ваш пароль!");
            if (password == "")
            {
                this.Close();
            }
            if (password != _password && password != "")
            {
                MessageBox.Show("Пароль неверный.\nПопробуйте ещё раз!", "Неверный пароль", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto enterPassword;
            }
        }

    }
}
