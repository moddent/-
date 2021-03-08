using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 樂透
{
    public partial class Form1 : Form
    {
        int[] j = new int[6];
        int[] b = new int[7];
        int[] ss = new int[7]; 
        ArrayList k = new ArrayList();
        int[] pp = new int[12];
        int[] pc = new int[12];
        int ii=0;
        int z = 80;
        int[] h = new int[14];
        /*int h1;
        int h2;
        int h3;
        int h4;
        int h5;
        int h6;
        int h7;
        int h8;
        int h9;
        int h10;
        int h11;
        int h12;
        int h13;
        int h14;*/
        public Form1()
        {            
            InitializeComponent();
        }      
        private void button1_Click(object sender, EventArgs e)//開獎
        {
          
            if(timer1.Enabled==false)
            {
                textBox1.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("號碼尚未全部開出!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = true;
            }
            timer1.Enabled = true;
            Array.Resize(ref pp, 11);
            Array.Resize(ref pc, 11);
            Random sd = new Random();     
            byte[] sa = new byte[50];
            for(int d=0;d<ss.Length;d++)
            {               
                int g = sd.Next(1,50);
                if (sa[g] == 0)
                {
                    ss[d] = g;
                    sa[g] = 1;                  
                }
                else d--;
                for (int i = 0; i < 7; i++)
                {
                    b[i] = ss[i];
                }  
            }
            int[] s = new int[14];
            for(int i=0;i<14;i++)
            {
                if(i<=6)
                {
                    s[i] = ss[i] / 10;
                }
                else
                {
                    s[i] = ss[i-7] % 10;
                }
                h[i] = s[i];
            }
            for(int i=0;i<6;i++)
            {
                j[i] = ss[i];
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button8.Enabled = false;
            checkBox1.CheckedChanged += checkBox_CheckedChanged;
            checkBox2.CheckedChanged += checkBox_CheckedChanged;
            checkBox3.CheckedChanged += checkBox_CheckedChanged;
            checkBox4.CheckedChanged += checkBox_CheckedChanged;
            checkBox5.CheckedChanged += checkBox_CheckedChanged;
            checkBox6.CheckedChanged += checkBox_CheckedChanged;
            checkBox7.CheckedChanged += checkBox_CheckedChanged;
            checkBox8.CheckedChanged += checkBox_CheckedChanged;
            checkBox9.CheckedChanged += checkBox_CheckedChanged;
            checkBox10.CheckedChanged += checkBox_CheckedChanged;
            checkBox11.CheckedChanged += checkBox_CheckedChanged;
            checkBox12.CheckedChanged += checkBox_CheckedChanged;
            checkBox13.CheckedChanged += checkBox_CheckedChanged;
            checkBox14.CheckedChanged += checkBox_CheckedChanged;
            checkBox15.CheckedChanged += checkBox_CheckedChanged;
            checkBox16.CheckedChanged += checkBox_CheckedChanged;
            checkBox17.CheckedChanged += checkBox_CheckedChanged;
            checkBox18.CheckedChanged += checkBox_CheckedChanged;
            checkBox19.CheckedChanged += checkBox_CheckedChanged;
            checkBox20.CheckedChanged += checkBox_CheckedChanged;
            checkBox21.CheckedChanged += checkBox_CheckedChanged;
            checkBox22.CheckedChanged += checkBox_CheckedChanged;
            checkBox23.CheckedChanged += checkBox_CheckedChanged;
            checkBox24.CheckedChanged += checkBox_CheckedChanged;
            checkBox25.CheckedChanged += checkBox_CheckedChanged;
            checkBox26.CheckedChanged += checkBox_CheckedChanged;
            checkBox27.CheckedChanged += checkBox_CheckedChanged;
            checkBox28.CheckedChanged += checkBox_CheckedChanged;
            checkBox29.CheckedChanged += checkBox_CheckedChanged;
            checkBox30.CheckedChanged += checkBox_CheckedChanged;
            checkBox31.CheckedChanged += checkBox_CheckedChanged;
            checkBox32.CheckedChanged += checkBox_CheckedChanged;
            checkBox33.CheckedChanged += checkBox_CheckedChanged;
            checkBox34.CheckedChanged += checkBox_CheckedChanged;
            checkBox35.CheckedChanged += checkBox_CheckedChanged;
            checkBox36.CheckedChanged += checkBox_CheckedChanged;
            checkBox37.CheckedChanged += checkBox_CheckedChanged;
            checkBox38.CheckedChanged += checkBox_CheckedChanged;
            checkBox39.CheckedChanged += checkBox_CheckedChanged;
            checkBox40.CheckedChanged += checkBox_CheckedChanged;
            checkBox41.CheckedChanged += checkBox_CheckedChanged;
            checkBox42.CheckedChanged += checkBox_CheckedChanged;
            checkBox43.CheckedChanged += checkBox_CheckedChanged;
            checkBox44.CheckedChanged += checkBox_CheckedChanged;
            checkBox45.CheckedChanged += checkBox_CheckedChanged;
            checkBox46.CheckedChanged += checkBox_CheckedChanged;
            checkBox47.CheckedChanged += checkBox_CheckedChanged;
            checkBox48.CheckedChanged += checkBox_CheckedChanged;
            checkBox49.CheckedChanged += checkBox_CheckedChanged;
            //foreach (Control c in tabControl1.Controls)
            //{
            //    ((CheckBox)c).CheckedChanged += new EventHandler(checkBox_CheckedChanged);
            //}                
        }         
        int a;
        CheckBox c;
        void checkBox_CheckedChanged(object sender, EventArgs e)
        {
             c = (CheckBox)sender;
            a += (c.Checked) ? 1 : -1;
            if ( a > 6)
            {
                MessageBox.Show("超出勾選範圍!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                c.Checked = false;
                return;
            }
            else if (c.Checked && a <= 6)
            {
                string g = c.Text;
                textBox2.Text += g + " ";
            }    
        }
        private void timer1_Tick(object sender, EventArgs e) 
        {            
            z--;
            if (z == 70)
            {
                pictureBox1.Image = imageList1.Images[h[0]];
                pictureBox2.Image = imageList1.Images[h[7]];
            }
            else if (z == 60)
            {
                pictureBox3.Image = imageList1.Images[h[1]];
                pictureBox4.Image = imageList1.Images[h[8]];

            }
            else if(z==50)
            {
                pictureBox5.Image = imageList1.Images[h[2]];
                pictureBox6.Image = imageList1.Images[h[9]];

            }
            else if(z==40)
            {
                pictureBox7.Image = imageList1.Images[h[3]];
                pictureBox8.Image = imageList1.Images[h[10]];

            }
            else if(z==30)
            {
                pictureBox9.Image = imageList1.Images[h[4]];
                pictureBox10.Image = imageList1.Images[h[11]];

            }
            else if(z==20)
            {
                pictureBox11.Image = imageList1.Images[h[5]];
                pictureBox12.Image = imageList1.Images[h[12]];

            }
            else if(z==10)
            {
                pictureBox13.Image = imageList1.Images[h[6]];//特別號
                pictureBox14.Image = imageList1.Images[h[13]];//特別號 
                button1.Enabled = true;
                timer1.Enabled = false;
                z = 80;
            }                   
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)//勾選號碼
        {

        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)//欄位清除
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            button3.Enabled = false;
            button7.Enabled = true;
            button8.Enabled = false;
            k.Clear();
            ii = 0;
        }

        private void button3_Click(object sender, EventArgs e)//兌獎
        {
            int[] de = (int[])k.ToArray(typeof(int));
            int[] ba = new int[k.Count / 6];
            byte[] ex = new byte[k.Count / 6];
            Array.Resize(ref pc, k.Count / 6);
            if (ss[0]!=0)
           {
                textBox3.Text = "";
                button3.Enabled = false;
                button7.Enabled = false;
                /*int[] de = (int[])k.ToArray(typeof(int));
                int[] ba = new int[k.Count / 6];
                byte[] ex = new byte[k.Count / 6];
                Array.Resize(ref pc, k.Count / 6);*/
                for (int c = 0; c < k.Count/6; c++)
                {
                    for (int cc = 0; cc < de.Length; cc++)
                    {
                        if (cc / 6 < c +1)
                        {
                            if (de[cc] == b[0] || de[cc] == b[1] ||de[cc] == b[2] || de[cc] == b[3] ||de[cc] == b[4] ||de[cc] == b[5])
                            {
                                    ba[c]++;
                            }
                            if (de[cc] == b[6])
                            {
                                    ex[c] = 1;
                            }
                            for (int y = 1; y < k.Count/6; y++)
                            {
                                try
                                {
                                    pp[0] = ba[0];
                                    pp[y] = ba[y] - ba[y - 1];
                                    pc[0] = ex[0];
                                    pc[y] = ex[y] - ex[y - 1];
                                }
                                catch (Exception err)
                                {
                                    MessageBox.Show(err.ToString());
                                }    
                            }
                        }
                     
                    }
                }                        
                string[] q = {"\r\n"};
                string[] h = textBox2.Text.Split(q,StringSplitOptions.None);
                for (int x = 0; x < pc.Length; x++)
                {
                    if (pp[x] == 6)
                    {
                        textBox3.Text += "頭獎!" + "------" + "\r\n";
                    }
                
                    if(pp[x] == 5 && pc[x] == 1)
                    {
                        textBox3.Text += "二獎!" + "------" + "\r\n";
                    }
               
                    if (pp[x] == 5 )
                    {
                        textBox3.Text += "三獎!" + "------" + "\r\n";
                    }
                
                    if (pp[x] == 4 && pc[x] == 1)
                    {
                        textBox3.Text += "四獎!" + "------" + "\r\n";
                    }
                
                    if (pp[x] == 4)
                    {
                        textBox3.Text += "五獎!" + "------" + "\r\n";
                    }
                
                    if (pp[x] == 3 && pc[x] == 1)
                    {
                        textBox3.Text += "六獎!" + "------" + "\r\n";
                    }
                
                    if (pp[x] == 2 && pc[x] == 1) 
                    {
                        textBox3.Text += "七獎!" + "------" + "\r\n";
                    }
                
                    if (pp[x] == 3)
                    {
                        textBox3.Text += "普獎!" + "------" + "\r\n";
                    }
                
                    if (pp[x] == 2)
                    {
                        textBox3.Text += "中兩碼!" + "------" + "\r\n";
                    }
                
                    if (pp[x] ==  1)
                    {
                        textBox3.Text += "中一碼!" + "------" + "\r\n";
                    }

                    else
                    {
                        textBox3.Text += "貢龜!" + "------" + "\r\n";
                    }
                }
           }
            else
            {
                MessageBox.Show("請先開獎!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button3.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)//中獎號碼
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//結果
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled==false)
            {
                
               textBox1.Text = " ";
                Array.Sort(j);
                textBox1.Text += string.Join(",", j);
            }  
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("號碼尚未全部開出!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = true;
            }
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            button3.Enabled = true;
            ArrayList i = new ArrayList();
            CheckBox[] f = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9, checkBox10, checkBox11, checkBox12, checkBox13, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28, checkBox29, checkBox30, checkBox31, checkBox32, checkBox33, checkBox34, checkBox35, checkBox36, checkBox37, checkBox38, checkBox39, checkBox40, checkBox41, checkBox42, checkBox43, checkBox44, checkBox45, checkBox46, checkBox47, checkBox48, checkBox49 };
            try
            {
                for (int x = 0; x < 49; x++)
                {
                    if (f[x].Checked)
                    {
                        i.Add(x + 1);
                    }
                }
                if (i.Count < 6)
                {
                    throw new Exception();
                }
                
                    k.AddRange(i);
                for (int l = 0; l < 49; l++)
                    f[l].Checked = false;
                i.Clear();
                ii++;
            }
            catch (Exception)
            {
                MessageBox.Show("至少勾選6個", "警告!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                textBox1.Text = "";
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                pictureBox13.Image = null;
                pictureBox14.Image = null;
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("號碼尚未全部開出!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
         
            button3.Enabled = true;
            Random co = new Random();
            int[] ra = new int[6];
            for (int x = 0; x < 6; x++)
            {
                ra[x] = co.Next(1, 50);
                for (int y = 0; y < x; y++)
                    if (ra[x] == ra[y])
                    {
                        x--;
                    }
            }
            for (int j = 0; j < 6; j++)
            {
                k.Add(ra[j]);
            }
            textBox2.Text +=  string.Join(" ", ra) + "\r\n";
            ii++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(ss[0]!=0)
            {
                textBox5.Text = "";
                string[] x = textBox4.Text.Split(',');
                int[] c = new int[6];
                int k = 0,kk=0;
                if(textBox4.Text!="")
                for (int y = 0; y < 6; y++)
                    c[y] = int.Parse(x[y]);
                for(int j=0;j<6;j++)
                {
                    if (c[j] == ss[0] || c[j] == ss[1] || c[j] == ss[2] || c[j] == ss[3] || c[j] == ss[4] || c[j] == ss[5])
                    {
                        k++;
                    }
                    if(c[j]==ss[6])
                    {
                        kk++;
                    }
                }
                if (k == 6)
                {
                    textBox5.Text += "頭獎!" + "------" + "\r\n";
                }

                else if (k == 5 && kk == 1)
                {
                    textBox5.Text += "二獎!" + "------" + "\r\n";
                }

                else if (k == 5)
                {
                    textBox5.Text += "三獎!" + "------" + "\r\n";
                }

                else if (k == 4 && kk == 1)
                {
                    textBox5.Text += "四獎!" + "------" + "\r\n";
                }

                else if (k == 4)
                {
                    textBox5.Text += "五獎!" + "------" + "\r\n";
                }

                else if (k == 3 && kk == 1)
                {
                    textBox5.Text += "六獎!" + "------" + "\r\n";
                }

                else if (k == 2 && kk == 1)                    
                {
                    textBox5.Text += "七獎!" + "------" + "\r\n";
                }

                else if (k == 3)
                {
                    textBox5.Text += "普獎!" + "------" + "\r\n";
                }

                else if (k == 2)
                {
                    textBox5.Text += "中兩碼!" + "------" + "\r\n";
                }

                else if (k == 1)
                {
                    textBox5.Text += "中一碼!" + "------" + "\r\n";
                }

                else
                {
                    textBox5.Text += "貢龜!" + "------" + "\r\n";
                }
            }
            else
            {
                button8.Enabled = false;
                MessageBox.Show("請先開獎!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button8.Enabled = true;
            }
            
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            button8.Enabled = true;
        }
    }
}
