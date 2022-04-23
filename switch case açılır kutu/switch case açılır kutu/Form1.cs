using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_case_açılır_kutu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string a;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
              a = comboBox1.Text;
            comboBox2.Items.Clear();
            switch (a)
            {
                case "Türkiye":
                    {
                        comboBox2.Items.Add("Recep Tayyip Erdoğan");
                        comboBox2.Items.Add("Abdullah Gül");
                        comboBox2.Items.Add("Ahmet Necdet Sezer");
                        break;
                    }
                case "İngiltere":
                    {
                        comboBox2.Items.Add("Elizabeth");
                        comboBox2.Items.Add("Churcill");
                        break;
                    }
                case "Almanya":
                    {
                        comboBox2.Items.Add("Angela Merkel");
                        comboBox2.Items.Add("Adolf Hitler");
                        break;

                    }
                case "Amerika":
                    {
                        comboBox2.Items.Add("Donald Trump");
                        comboBox2.Items.Add("Corç Bush");
                        break;
                    }
                case "Rusya":
                    {
                        comboBox2.Items.Add("Vladimir Putin");
                        break;

                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "ÜLKE BAŞKANLARI FORMU";
            comboBox1.Items.Add("Türkiye");
            comboBox1.Items.Add("Almanya");
            comboBox1.Items.Add("İngiltere");
            comboBox1.Items.Add("Amerika");
            comboBox1.Items.Add("Rusya");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        }
    }

