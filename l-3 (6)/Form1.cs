using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace l_3__6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_To_Base.Enabled = false;

        }

        ArrayList Base = new ArrayList();
        Account account;

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void checkBox_only_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_only.Checked)
            {
                 radioButton_Euro.Enabled = false;
                 radioButton_Dollar.Enabled = false;
            }
            else
            {
                radioButton_Euro.Enabled = true;
                radioButton_Dollar.Enabled = true;
            }
        }
        private void checkBox_Agree_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Agree.Checked)
            {
                button_To_Base.Enabled = true;
            }
            else
            {
                button_To_Base.Enabled = false;
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            comboBox_Surname.Text = "";
            textBox_Dollar.Text   = "0";
            textBox_Euro.Text     = "0";
            textBox_Rub.Text      = "0";
            numericUpDown_Gold.Value = 0;
            radioButton_Dollar.Checked = false;
            radioButton_Euro.Checked = false;
            radioButton_Rub.Checked = false;
            radioButton_Gold.Checked = false;
        }

        private void button_To_Base_Click(object sender, EventArgs e)
        {
            if (radioButton_Dollar.Checked == true|| radioButton_Euro.Checked == true || radioButton_Rub.Checked == true)
            {
                if (radioButton_Dollar.Checked)
                {
                    account = new Dollar(comboBox_Surname.Text, double.Parse(textBox_Dollar.Text));
                }
                else if (radioButton_Euro.Checked)
                {
                    account = new Euro(comboBox_Surname.Text, double.Parse(textBox_Euro.Text));
                }
                else if (radioButton_Rub.Checked)
                {
                    account = new Rub(comboBox_Surname.Text, double.Parse(textBox_Rub.Text));
                }
                Base.Add(account);
            }
            if(radioButton_Gold.Checked)
            {
                if (radioButton_Gold.Checked)
                {
                    account = new Gold(comboBox_Surname.Text, double.Parse(numericUpDown_Gold.Text));
                    Base.Add(account);
                }
            }
        }

        private void button_Refresh_Dollar_Click(object sender, EventArgs e)
        {
            listBox_Dollar.Items.Clear();
            for(int i = 0; i < Base.Count; i++)
            {
                account = (Account)Base[i];
                if(account.GetType().Name == "Dollar")
                {
                    listBox_Dollar.Items.Add(account.Information());
                }
            }
        }

        private void button_Refresh_Euro_Click(object sender, EventArgs e)
        {
            listBox_Euro.Items.Clear();
            for (int i = 0; i < Base.Count; i++)
            {
                account = (Account)Base[i];
                if (account.GetType().Name == "Euro")
                {
                    listBox_Euro.Items.Add(account.Information());
                }
            }
        }

        private void button_Refresh_Rub_Click(object sender, EventArgs e)
        {
            listBox_Rub.Items.Clear();
            for (int i = 0; i < Base.Count; i++)
            {
                account = (Account)Base[i];
                if (account.GetType().Name == "Rub")
                {
                    listBox_Rub.Items.Add(account.Information());
                }
            }
        }

        private void button_Refresh_Gold_Click(object sender, EventArgs e)
        {
            listBox_Gold.Items.Clear();
            for (int i = 0; i < Base.Count; i++)
            {
                account = (Account)Base[i];
                if (account.GetType().Name == "Gold")
                {
                    listBox_Gold.Items.Add(account.Information());
                }
            }
        }

        private void button_Refresh_Bank_Click(object sender, EventArgs e)
        {
            double all_rubs = 0;
            double dollars  = 0;
            double euros    = 0;
            double rubs     = 0;
            double gold     = 0;

            for (int i = 0; i < Base.Count; i++)
            {
                account = (Account)Base[i];
                if (account.GetType().Name == "Dollar")
                {
                    dollars += account.Number();
                    all_rubs += account.To_Rub();
                }
                if (account.GetType().Name == "Euro")
                {
                    euros += account.Number();
                    all_rubs += account.To_Rub();
                }
                if (account.GetType().Name == "Rub")
                {
                    rubs += account.Number();
                    all_rubs += account.To_Rub();
                }
                if (account.GetType().Name == "Gold")
                {
                    gold += account.Number();
                    all_rubs += account.To_Rub();
                }
            }
            label_Total_Rub.Text = all_rubs.ToString();
            label_Dollar.Text = dollars.ToString();
            label_Euro.Text = euros.ToString();
            label_Gold.Text = gold.ToString();
            label_Rub.Text = rubs.ToString();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            listBox_Dollar.Font = new Font("Microsoft Sans Serif", trackBar_Font.Value);
            listBox_Euro.Font   = new Font("Microsoft Sans Serif", trackBar_Font.Value);
            listBox_Rub.Font    = new Font("Microsoft Sans Serif", trackBar_Font.Value);
            listBox_Gold.Font   = new Font("Microsoft Sans Serif", trackBar_Font.Value);
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void button_All_Click(object sender, EventArgs e)
        {
            button_All.Click += new EventHandler(button_Refresh_Gold_Click);
            button_All.Click += new EventHandler(button_Refresh_Rub_Click);
            button_All.Click += new EventHandler(button_Refresh_Euro_Click);
            button_All.Click += new EventHandler(button_Refresh_Dollar_Click);
        }    
    }
}
