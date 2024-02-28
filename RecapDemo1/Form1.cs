using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] buttons = new Button[8,8];   //Button nesnesi oluşturduk. Button[,] buttons şeklinde yazmazsan matrisli şekilde yapamazsın.,
            int top = 0;
            int left = 0;
            for (int i = 0; i < buttons.GetUpperBound(0); i++) 
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();  //Her button yeni bir buttondur o yüzden hep yenilememiz gerekir.
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    buttons[i,j].Top = top;
                    left += 50;        //Başta sola koydu sonra her yeni bir tanesinde onun 50 sağına koyuyor yeni buttonu.
                    if((i+j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i,j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;  //Burada yaptığımız ise 1 döngü bittiğinde alt satıra geçiyoruz yeni döngüye geldiğimizde.
                left = 0;   //İkinci satıra geçtiğimizde tekrardan en başa koyup ellişer arttırmalı ondan döngü her bittiğinde sıfırlıyoruz.
                
            }
            //button.Text = "My button";   İçine my button yazdırıyoruz.
            //this.Controls.Add(button);    button u ekrana koy.
        }
    }
}
