using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arraylist_Uygulama_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue kuyruk = new Queue();
        int sira = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSıraAl_Click(object sender, EventArgs e)
        {

            sira ++;
            kuyruk.Enqueue(sira);
            Listele();
        
        }

        private void Listele()
        {
            listeSiralar.Items.Clear();
            foreach (int sira in kuyruk)
            {
                listeSiralar.Items.Add(sira);
            }
        }

        private void btnSiraCikart_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Listele();
        }
    }
}

