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


            //////button genişliğini ayarladık.
            ////button.Width = 50;

            //////button yüksekliğini ayarladık.
            ////button.Height = 50;

            //////button yazısı belirledik.
            ////button.Text = "My button";

            ////button isimli düğmeyi forma ekledik.
            //this.Controls.Add(button);


            //buttons isimli 8 satırlı ve 8 sütunlu bir dizi tanımladık.
            Button[,] buttons = new Button[8, 8];
            //soldan ve üstten boşluk için değişken tanımladık.
            int top = 0;
            int left = 0;

            //satır sayısı kadar döngüye soktuk.
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {

                //sütun sayısı kadar döngüye soktuk
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;
                    left += 50;
                    buttons[i, j].Top = top;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }
                    this.Controls.Add(buttons[i, j]);
                }
                top += 50;
                left = 0;
            }

        }
    }
}
