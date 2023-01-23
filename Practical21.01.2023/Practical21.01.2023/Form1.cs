using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical21._01._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            string s ="";
            if (selectedState== "Процессор")
            {
                s = s + "Win32_Processor";
            }
            else if (selectedState== "Видеокарта")
            {
                s = s + "Win32_VideoController";
            }
            else if (selectedState == "Чипсет")
            {
                s = s + "Win32_IDEController";
            }
            else if (selectedState == "Батарея")
            {
                s = s + "Win32_Battery";
            }
            else if (selectedState == "Биос")
            {
                s = s + "Win32_BIOS";
            }
            else if (selectedState == "Оперативная память")
            {
                s = s + "Win32_PhysicalMemory";
            }
            else if (selectedState == "Кэш")
            {
                s = s + "Win32_CacheMemory";
            }
            else if (selectedState == "USB")
            {
                s = s + "Win32_USBController";
            }
            else if (selectedState == "Диск")
            {
                s = s + "Win32_DiskDrive";
            }
            else if (selectedState == "Логические диски")
            {
                s = s + "Win32_LogicalDisk";
            }
            else if (selectedState == "Клавиатура")
            {
                s = s + "Win32_Keyboard";
            }
            else if (selectedState == "Сеть")
            {
                s = s + "Win32_NetworkAdapter";
            }
            else if (selectedState == "Пользователи")
            {
                s = s + "Win32_Account";
            }

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM "+s);

            foreach (ManagementObject obj in searcher.Get())
            {
                foreach (PropertyData dat in obj.Properties)
                {
                    dataGridView1.RowCount += 1;
                    dataGridView1[0, dataGridView1.RowCount - 1].Value = dat.Name;
                    dataGridView1[1, dataGridView1.RowCount - 1].Value = dat.Value;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
