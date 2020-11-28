using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ninjamma_easy_configurator
{
    
     public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
            for (int i = 0; i < 31; i++)
            {
                Mixer.Inputs.SetValue(1 << i, i);
                Mixer.Outputs.SetValue(1 << i, i);
                Mixer.Frequency.SetValue(0, i);
            }

            int input_value = (int)Mixer.Inputs.GetValue(((int)numericUpDown9.Value));

            int output_value = (int)Mixer.Outputs.GetValue(((int)numericUpDown9.Value));


            for (int i = 0; i < 24; i++)
            {

                if ((input_value & (1 << i)) != 0)
                {
                    checkedListBox1.SetItemChecked(i, true);
                }
                else
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                if ((output_value & (1 << i)) != 0)
                {
                    checkedListBox2.SetItemChecked(i, true);
                }
                else
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
                comboBox2.SelectedIndex = (int)Mixer.Frequency.GetValue(((int)numericUpDown9.Value));

            }





        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void Button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = "NAME=";
            textBox1.Text += textBox2.Text;
            textBox1.Text += ",";
            textBox1.Text += "FREQ0=";
            textBox1.Text += (int) (100000/numericUpDown1.Value);
            textBox1.Text += ",";
            textBox1.Text += "SFREQ0=";
            textBox1.Text += numericUpDown5.Value;
            textBox1.Text += ",";
            textBox1.Text += "FREQ1=";
            textBox1.Text += (int)(100000 / numericUpDown2.Value);
            textBox1.Text += ",";
            textBox1.Text += "SFREQ1=";
            textBox1.Text += numericUpDown6.Value;
            textBox1.Text += ",";
            textBox1.Text += "FREQ2=";
            textBox1.Text += (int)(100000 / numericUpDown3.Value);
            textBox1.Text += ",";
            textBox1.Text += "SFREQ2=";
            textBox1.Text += numericUpDown7.Value;
            textBox1.Text += ",";
            textBox1.Text += "FREQ3=";
            textBox1.Text += (int)(100000 / numericUpDown4.Value);
            textBox1.Text += ",";
            for (int f = 0; f < 31; f++)
            {
                textBox1.Text += "MIX";
                textBox1.Text += f;
                textBox1.Text += "IN=";
                textBox1.Text += Mixer.Inputs.GetValue(f);
                textBox1.Text += ",";
                textBox1.Text += "MIX";
                textBox1.Text += f;
                textBox1.Text += "OUT=";
                textBox1.Text += Mixer.Outputs.GetValue(f);
                textBox1.Text += ",";
                textBox1.Text += "MIX";
                textBox1.Text += f;
                textBox1.Text += "F=";
                textBox1.Text += Mixer.Frequency.GetValue(f);
                textBox1.Text +=",";
            }
            textBox1.Text += "OUTPUT0 =38,OUTPUT1=36,OUTPUT2=34,OUTPUT3=32,OUTPUT4=30,OUTPUT5=28,OUTPUT6=26,OUTPUT7=24,OUTPUT8=22,OUTPUT9=19,OUTPUT10=48,OUTPUT11=46,OUTPUT12=44,OUTPUT13=42,OUTPUT14=40,OUTPUT15=4,OUTPUT16=10,OUTPUT17=9,OUTPUT18=8,OUTPUT19=7,OUTPUT20=6,OUTPUT21=5,OUTPUT22=1,OUTPUT23=13,STEPINC=44,";

            textBox1.Text += "HIGPERF=";
            if(checkBox1.Checked)
            {
                textBox1.Text += 1;
            }
            else textBox1.Text += 0;
            textBox1.Text += ",FTYPE00=";
            textBox1.Text += comboBox1.SelectedIndex;
            textBox1.Text += ",";





        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void NumericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown9_ValueChanged_1(object sender, EventArgs e)
        {
           
                int input_value = (int)Mixer.Inputs.GetValue(((int)numericUpDown9.Value));

            int output_value = (int)Mixer.Outputs.GetValue(((int)numericUpDown9.Value));
       

            for (int i = 0; i < 24; i++)
            {

                if ((input_value & (1<<i)) != 0)
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                    else
                    {
                        checkedListBox1.SetItemChecked(i, false);
                    }
                if ((output_value & (1 << i)) != 0)
                {
                    checkedListBox2.SetItemChecked(i, true);
                }
                else
                {
                    checkedListBox2.SetItemChecked(i, false);
                }
                comboBox2.SelectedIndex = (int)Mixer.Frequency.GetValue(((int)numericUpDown9.Value));

            }

            
            

        }

        private void checkedListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int temp_input_val = 0;
            foreach (int items_coches in checkedListBox1.CheckedIndices)
                {
                
                temp_input_val += 1 << items_coches;


            }
           
            Mixer.Inputs.SetValue(temp_input_val,((int) numericUpDown9.Value));
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int temp_output_val = 0;
            foreach (int items_coches in checkedListBox2.CheckedIndices)
            {

                temp_output_val += 1 << items_coches;


            }

            Mixer.Inputs.SetValue(temp_output_val, ((int)numericUpDown9.Value));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mixer.Frequency.SetValue((int)comboBox2.SelectedIndex, ((int)numericUpDown9.Value));

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult Result = saveFileDialog1.ShowDialog();//Show the dialog to save the file.
                                                               //Test result and determine whether the user selected a file name from the saveFileDialog.
            if ((Result == DialogResult.OK) && (saveFileDialog1.FileName.Length > 0))
            {
                //Save the contents of the richTextBox into the file.
                string dirParameter = saveFileDialog1.FileName;
                FileStream fParameter = new FileStream(dirParameter, FileMode.Create, FileAccess.Write);
                StreamWriter m_WriterParameter = new StreamWriter(fParameter);
                m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
                m_WriterParameter.Write(textBox1.Text);
                m_WriterParameter.Flush();
                m_WriterParameter.Close();

                
            }


        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

   



}
