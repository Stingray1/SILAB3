using System;
using System.Windows.Forms;
using Org.BouncyCastle.Math;

namespace SI_Lab3
{
    public partial class Form1 : Form
    {
        private DSA dsa = new DSA();

        public Form1()

        {
            InitializeComponent();
        }

        private void btnSemneaza_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(messageBox.Text))
                MessageBox.Show("Lipseste mesajul", "Important Message");

            BigInteger[] cheieDeSemnare = dsa.GenereazaSemnatura(messageBox.Text);

            cheiePBox.Text = dsa.PrimP.ToString();
            cheieQBox.Text = dsa.PrimQ.ToString();
            GBox.Text = dsa.G.ToString();
            cheieYBox.Text = dsa.CheieY.ToString();
            cheieXBox.Text = dsa.CheiePrivataX.ToString();
            cheieRBox.Text = cheieDeSemnare[0].ToString();
            cheieSBox.Text = cheieDeSemnare[1].ToString();

            msgHashBox.Text = dsa.hashMesaj.ToString();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(messageBox.Text))
                MessageBox.Show("Lipseste mesajul", "Important Message");
            if (string.IsNullOrEmpty(msgHashBox.Text))
                MessageBox.Show("Lipseste hash mesajului", "Important Message");
            if (string.IsNullOrEmpty(cheieRBox.Text))
                MessageBox.Show("Lipseste cheia R", "Important Message");
            if (string.IsNullOrEmpty(cheieSBox.Text))
                MessageBox.Show("Lipseste cheia S", "Important Message");

            BigInteger hashBytes = new BigInteger(msgHashBox.Text);

            BigInteger[] cheieDeSemnare = new BigInteger[2];
            cheieDeSemnare[0] = new BigInteger(cheieRBox.Text);
            cheieDeSemnare[1] = new BigInteger(cheieSBox.Text);

            bool rezultat = dsa.VerificaSemnatura(cheieDeSemnare, messageBox.Text, hashBytes, dsa.CheieY);

            if(rezultat) //daca true
                MessageBox.Show("Semnatura este valida", "Important Message");
            else
                MessageBox.Show("Semnatura nu este valida", "Important Message");
        }
    }
}
