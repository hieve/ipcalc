using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPCalculator
{
    public partial class Form1 : Form
    {
        string[] OutputText = new string[13];
        string[] ErrorLog = new string[13];

        int IPBox1I = 0;
        int IPBox2I = 0;
        int IPBox3I = 0;
        int IPBox4I = 0;


        int SNBoxI = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Input()
        {
            ParseText();
            AssignIP();
        }
        private void ParseText()
        {
            IPBox1I = checkIP(IPBox1);
            IPBox2I = checkIP(IPBox2);
            IPBox3I = checkIP(IPBox3);
            IPBox4I = checkIP(IPBox4);
            SNBoxI = checkSN(SNBox);
        }

        private int checkIP(TextBox box)
        {
            int dot = 0;
            if (int.TryParse(box.Text, out dot))
            {
                if (dot < 0 || dot > 255)
                {
                    box.BackColor = Color.Red;
                    ERRBox.AppendText("Ungueltige Zahl im" + getTextBoxName(box.Name) + Environment.NewLine);
                }
                else
                {
                    box.BackColor = Color.Green;
                }
            }
            else
            {
                box.BackColor = Color.Red;
                ERRBox.AppendText("Ungueltige Zeichen im" + getTextBoxName(box.Name) + Environment.NewLine);
            }

            return dot;
        }
        private int checkSN(TextBox box)
        {
            int dot = 0;
            if (int.TryParse(box.Text, out dot))
            {
                if (dot < 8 || dot > 32)
                {
                    box.BackColor = Color.Red;
                    ERRBox.AppendText("Ungueltiges Subnetz" + Environment.NewLine);
                }
                else
                {
                    box.BackColor = Color.Green;

                }
            }
            else
            {
                box.BackColor = Color.Red;
                ERRBox.AppendText("Ungueltiges Subnetz"+Environment.NewLine);
            }
            return dot;

        }
        private void AssignIP()
        {
            OutputText[1] = IPBox1I.ToString() + "." + IPBox2I.ToString() + "." + IPBox3I.ToString() + "." + IPBox4I.ToString();
            OutputText[3] = SNBoxI.ToString();
        }

        private String getTextBoxName(String textBoxName)
        {
            String realName = "";

            if(textBoxName.Equals("IPBox1"))
            {
                realName = " 1. Oktett ";
            }
            else if (textBoxName.Equals("IPBox2"))
            {
                realName = " 2. Oktett ";
            }
            else if (textBoxName.Equals("IPBox2"))
            {
                realName = " 2. Oktett ";
            }
            else if (textBoxName.Equals("IPBox3"))
            {
                realName = " 3. Oktett ";
            }
            else if (textBoxName.Equals("IPBox4"))
            {
                realName = " 4. Oktett ";
            }

            return realName;
        }

        private void Output()
        {
            OutputText[0] = "Generated at " + DateTime.Now + Environment.NewLine;
            OUTBox.Text = OutputText[0]+Environment.NewLine+
            "IP-Adresse: " + OutputText[1] + Environment.NewLine+
            "Subnetzmaske: " + OutputText[2] + "\\"+OutputText[3] + Environment.NewLine +
            "Hosts: " + OutputText[4] + Environment.NewLine +
            "IP-Netz: von " + OutputText[5] + " bis " + OutputText[6] + Environment.NewLine +
            "Broadcast-Adresse: " + OutputText[7] + Environment.NewLine +
            Environment.NewLine +
            "Binary:"
            + Environment.NewLine +
            "IP-Adresse: " + OutputText[8] + Environment.NewLine +
            "Subnetzmaske: " + OutputText[9] + Environment.NewLine +
            "Netz-Adresse: " + OutputText[10] + Environment.NewLine +
            "Host-Adresse: " + OutputText[11] + Environment.NewLine +
            "Broadcast-Adresse: " + OutputText[12]+Environment.NewLine;
        }
        private void SNBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            OUTBox.Clear();
            ERRBox.Clear();
            Input();
            Calculation();
            Output();
        }

        private void Calculation()
        {
            Hosts();

        }
        private void Hosts()
        {
            double avalips = 0;
            int subnetbit = 0;
            int allsubnetbits = 32;
            if (SNBoxI >= 8 && SNBoxI <= 32)
            {
                subnetbit = allsubnetbits - SNBoxI;
                avalips = Math.Pow(2, subnetbit) - 2;
                if (SNBoxI == 32)
                {
                    OutputText[4] = "Host Only";
                }
                else if (SNBoxI == 31)
                {
                    OutputText[4] = "2 (Point to Point)";
                }
                else {
                    OutputText[4] = avalips.ToString();
                }
            }
            else
            {
                OutputText[4] = "";
            }
        }
    }
}
