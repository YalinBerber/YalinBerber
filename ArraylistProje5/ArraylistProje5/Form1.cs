using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArraylistProje5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stack yigin = new Stack();
 
        private void btnEkle_Click(object sender, EventArgs e)
        {
            yigin.Push(txtAdSoyad.Text);
            Listele();
        }
        private void Listele()
        {
            listeStack.Items.Clear();
            foreach (string eleman in yigin)
            {
                listeStack.Items.Add(eleman);
            }
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            yigin.Pop();
            Listele();
        }
    }
}
