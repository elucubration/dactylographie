using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ksssssssss
{
    public partial class Form1 : Form
    {
        int Compteur=0, mindex,vic,per;
        int time = 60;
        Random motaleatoire = new Random();
        Class1 classe = new Class1();       
        string[] Array_mots = { "jaune", "vert", "rouge","jouer","remplir","saccager","revoir","dire","accoucher","recevoir","pardonner","regler","revisiter","redire","tirer","tomate","carotte","sentir","percevoir","renifler" };
        
        public void start()
       {                      
            
            int[] Array_index_1 = Referrence_Array(classe.Random_Array);
            int[] Array_index_Control = Referrence_Array_Control(classe.ArrayControl);
            for (int i = 0; i < Array_index_Control[0]; i++)
            {
                flowLayoutPanel1.Controls.Add(classe.ArrayControl[i]);
                //label1.Text += " " + classe.Random_Array[i];
            }


        }
        public int taille_String_Witdh(string a)
        {
            Image aaa = new Bitmap(1, 1);
            Graphics gg = Graphics.FromImage(aaa);
            Font zzz = new Font("Microsoft Sans Serif", 9);
            SizeF ppp = new SizeF();
            ppp = gg.MeasureString(a, zzz);

            return (int)ppp.Width+1;

        }
        public int taille_String_Height(string a)
        {
            Image aaa = new Bitmap(1, 1);
            Graphics gg = Graphics.FromImage(aaa);
            Font zzz = new Font("Microsoft Sans Serif", 9);
            SizeF ppp = new SizeF();
            ppp = gg.MeasureString(a, zzz);
            return (int)ppp.Height+1;

        }
        public void Array_Control()
        {
            List<Control> List_Control = new List<Control>();
            foreach(string item in classe.Random_Array)
            {
                Label l = new Label();
                l.Text = item;
                l.Width = taille_String_Witdh(item);
                l.Height = taille_String_Height(item);
                List_Control.Add(l);
            }
            classe.ArrayControl = List_Control.ToArray();
        }
        public string[] randomListe(string[] a)
        {
            for (int i=0; i<a.Length;i++)
            {
                mindex = motaleatoire.Next(a.Length);
                 a[i] =  a[mindex] ;
            }
            return a;

        }
        
        public Form1()
        {           
            InitializeComponent();
            string[] cas = randomListe(Array_mots);
            classe.Random_Array = cas;
            Array_Control();
            start();
            Label_timer.Text = time + " secondes";
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           

            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

       
        private int[] Referrence_Array_Control(Control[] tab)
        {
            double dep=0;
            List<int> baba = new List<int>();
            for (int i = 0; i < tab.Length; i++)
            {
                dep += tab[i].Width;
                if(dep<flowLayoutPanel1.Width && dep > (flowLayoutPanel1.Width - 80))
                {
                    baba.Add(i);
                    dep = 0;
                }

            }
            int[] arr_controle = baba.ToArray();
            return arr_controle;
        }
        
        private int[] Referrence_Array(string [] tab)
        {
            
            Image faketest = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(faketest);
            List<int> tete = new List<int>();
            Font text = new Font("Microsoft Sans Serif", 9);
            SizeF text_Size = new SizeF();
            Double taill_Witdh=0;
            for (int i = 0 /*1*/; i < tab.Length; i++)
            {
                text_Size = g.MeasureString(tab[i], text);
                taill_Witdh += text_Size.Width;
                if (taill_Witdh<label1.Width && taill_Witdh > (label1.Width-50))
                {
                    tete.Add(i);
                    taill_Witdh = 0;
                }
            }
            
            int[] arr_ample = tete.ToArray();
            return arr_ample;

        }
       

        private void label1_Paint(object sender, PaintEventArgs e)
        {                   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_BackColorChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text += "res";
            if (time > 0)
            {
                time -= 1;
                Label_timer.Text = time.ToString()+" secondes";

            }
            else
            {
                timer1.Stop();
                Label_timer.Text = "time's up !";
                MessageBox.Show("Temps écoulé..");
                textBox1.Enabled = false;                
            }
        }

        private void label2_Paint(object sender, PaintEventArgs e)
        {
            // Set up string.
            string measureString = "Measure String";
            Font stringFont = new Font("Arial", 16);

            // Set maximum width of string.
            int stringWidth = 10000;

           /* // Set string format.
            StringFormat newStringFormat = new StringFormat();
            newStringFormat.FormatFlags = StringFormatFlags.DirectionVertical;*/

            // Measure string.
            SizeF stringSize = new SizeF();
            stringSize = e.Graphics.MeasureString(measureString, stringFont, stringWidth);

            // Draw rectangle representing size of string.
            e.Graphics.DrawRectangle(new Pen(Color.Red, 1), 0.0F, 0.0F, stringSize.Width, stringSize.Height);

            // Draw string to screen.
            e.Graphics.DrawString(measureString, stringFont, Brushes.Red, new PointF(0, 0));
        }

        private void reset_Click(object sender, EventArgs e)
        {
            start();
        }

        
        public void test(int p,string c)
        {
            Font stringfont = new Font("Microsoft Sans Serif", 9);
            Image faketest = new Bitmap(1, 1);
            Graphics g = Graphics.FromImage(faketest);
            int stringwitdh = 100000;
            SizeF stringsd = new SizeF();
            stringsd = g.MeasureString(c, stringfont, stringwitdh);
            int wif = (int)stringsd.Width;

            //label1.Text = wif+" " + stringsd.Width.ToString();
            
            Image nee = new Bitmap(label1.Width-1+classe.var, label1.Height - 1);
            
            
            Graphics gg = Graphics.FromImage(nee);
            if (p == 1)
            {
                gg.DrawRectangle(new Pen(Color.Green, 1), 0.0F, 0.0F, stringsd.Width, stringsd.Height);
                
            }
            else
            {
                gg.DrawRectangle(new Pen(Color.Red, 1), 0.0F, 0.0F, stringsd.Width, stringsd.Height);
            }
            
            label1.Image = nee;
            classe.var -= wif * 2;
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (time==60)
            {
                timer1.Start();
            }

            
            if (e.KeyCode.Equals(Keys.Space))
            {                                                            
                int[] Array_index = Referrence_Array(classe.Random_Array);
                int[] Array_index_Control = Referrence_Array_Control(classe.ArrayControl);


                if (Compteur< Array_mots.Length)
                {                    
                    string Name_textBox = textBox1.Text.ToString();
                    string Trime = Name_textBox.Trim();                                        
                    textBox1.Clear();
                    int p=classe.Verification(Compteur, Trime, classe.Random_Array);
                    if (p==1)
                    {
                        classe.ArrayControl[Compteur].ForeColor = Color.Green;
                        vic++;
                     
                    }
                    else
                    {
                        classe.ArrayControl[Compteur].ForeColor = Color.Red;
                        per++;
                    }
                    Compteur++;        
                    // Affichage du compteur à cette partie du code;
                    label3.Text +=  Compteur.ToString();
                    // Affichge du tableau des index-s de référence;
                    if (Compteur == 2)
                    {
                        foreach (int item in Array_index)
                    {
                        label4.Text += " "+item.ToString();
                        
                    }
                    }
                    
                    if (Array_index_Control.Contains(Compteur) == true)
                    {
                        
                        int Index_ = Array.IndexOf(Array_index_Control, Compteur);
                        label1.ResetText();
                        flowLayoutPanel1.Controls.Clear();
                        if (Index_ != (Array_index_Control.Length) - 1)
                        {
                            for (int i = Array_index_Control[Index_]; i < Array_index_Control[Index_ + 1]; i++)
                            {
                                flowLayoutPanel1.Controls.Add(classe.ArrayControl[i]);
                                
                            }
                        }
                        else
                        {
                            for (int i = Array_index_Control[Index_]; i < classe.Random_Array.Length; i++)
                            {
                                flowLayoutPanel1.Controls.Add(classe.ArrayControl[i]);
                                
                            }
                        }

                    }
                   
                    if (Compteur == Array_mots.Length)
                    {
                        timer1.Stop();
                        textBox1.Enabled = false;
                       
                        MessageBox.Show("Félicitation !");
                        MessageBox.Show("Voici votre score :\n "+vic+" mots réussi. \n "+per+" mots incorrect.\n");

                    }
                }
               
            }
        }

       
    }
}
