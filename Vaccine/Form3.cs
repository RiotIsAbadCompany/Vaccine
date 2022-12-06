using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ExcelLibrary;
using Microsoft.Office.Interop.Excel;
namespace Vaccine
{
    public partial class Form3 : Form
    {
        int years;
        String fname, lname, egn, outstr;

        private void button1_Click(object sender, EventArgs e)
        {
            string ExcelFileLocation = (@"C:\vc\vac.xlsx");
            Microsoft.Office.Interop.Excel.Application oApp;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            oApp = new Microsoft.Office.Interop.Excel.Application();
            oBook = oApp.Workbooks.Add();
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oBook.Worksheets.get_Item(1);
            int i = 0;
            i++;

            for (int j = 0; j < listBox1.Items.Count; j++)
            {
                oSheet.Cells[j + 1, 1] = listBox1.Items[j].ToString(); 
            }
            oBook.SaveAs(ExcelFileLocation);
            oBook.Close();
            oApp.Quit();
            MessageBox.Show("Exported to" + ExcelFileLocation);
        }

        public Form3(int _years,String fn,String ln,String egn2)
        {
            years = _years;
            fname = fn;
            lname = ln;
            egn = egn2;
            InitializeComponent();

        }
        
       /* public Form3(string text)
        {
            if (int.Parse(text) >= 1 && int.Parse(text) <= 6)
            {
                radioButton1.Checked = true;
            }
            else if (int.Parse(text) >= 7 && int.Parse(text) <= 12)
            {
                radioButton2.Checked = true;
            }
            else if (int.Parse(text) >= 13 && int.Parse(text) <= 18)
            {
                radioButton3.Checked = true;
            }
        }
       */
    
        private void Form3_Load(object sender, EventArgs e)
        {
            button1.Text = "OK";
            groupBox1.Enabled = false;
            radioButton1.Text = "хепатит тип В(Първи прием)";
            radioButton3.Text = "ТетаДиф Ваксина";
            radioButton2.Text = "БЦЖ ваксина";
            outstr = fname;
            string outstr2 = lname;
            string outstr3 = egn;
            string outstr4 = years.ToString();
            string outstr5;

            if (years >= 1 && years <= 6)
            {
                radioButton1.Checked = true;
                outstr5 = radioButton1.Text;
                listBox1.Items.Add(outstr5);
            }
            else if (years >= 7 && years <= 12)
            {
                radioButton2.Checked = true;
                outstr5 = radioButton2.Text;
                listBox1.Items.Add(outstr5);

            }
            else if (years >= 13 && years <= 18)
            {
                radioButton3.Checked = true;
                outstr5 = radioButton3.Text;
                listBox1.Items.Add(outstr5);
            }
            listBox1.Items.Add(outstr);
            listBox1.Items.Add(outstr2);
            listBox1.Items.Add(outstr3);
            listBox1.Items.Add(outstr4);
            

        }
    }
}
