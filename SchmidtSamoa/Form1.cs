using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchmidtSamoa
{
    public partial class Form1 : Form
    {
        SchmidtSamoa sSamoa;
        RSACryptoServiceProvider rsa;
        private const int Count = 10;
        private static Stopwatch stopWatch = new Stopwatch();
        private byte[] rsaEncryptedMessage = new byte[128];
       

        public Form1()
        {
            InitializeComponent();

            InitSchmidtSamoa(1024);
            InitRSA(1024);
        }

       
        private  void InitSchmidtSamoa(int keySize)
        {
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < Count; i++)
            {
            sSamoa = new SchmidtSamoa(keySize);
            }
            stopWatch.Stop();
            lblSsKeyGenTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";
        }

        private void InitRSA(int keySize)
        {
            //rsa = new RSACryptoServiceProvider(keySize);
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < Count; i++)
            {
                rsa = new RSACryptoServiceProvider(keySize);
            }
            var size = rsa.KeySize;
            stopWatch.Stop();
            lblRSAKeyGenTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + "ms";
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            var messageInBytes = Encoding.Default.GetBytes(textBoxMessage.Text);
            stopWatch.Reset();
            stopWatch.Start();
            for (var i = 0; i < Count; i++)
            {
            var encryptedMessage = sSamoa.Encrypt(messageInBytes);
            }
            stopWatch.Stop();

            //ChipertextBox.Text = Encoding.Default.GetString(encryptedMessage);
            lblSsEncTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";


            // RSA
            var messageInBytesRSA = Encoding.Default.GetBytes(textBoxMessage.Text);
            stopWatch.Reset();
            stopWatch.Start();
            for (int i = 0; i < Count; i++)
            {
            rsaEncryptedMessage = rsa.Encrypt(messageInBytesRSA, true);

            }
            stopWatch.Stop();
            ChipertextBox.Text = Encoding.Default.GetString(rsaEncryptedMessage);
            lblRSAencTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";

        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            var encryptedMessage = Encoding.Default.GetBytes(ChipertextBox.Text);
            var decryptedMessage = sSamoa.Decrypt(encryptedMessage);

            stopWatch.Reset();
            stopWatch.Start();
            for (var i = 0; i < Count; i++)
            {
             decryptedMessage = sSamoa.Decrypt(encryptedMessage);
            }
            stopWatch.Stop();

            txtPlainText.Text = Encoding.Default.GetString(decryptedMessage);
            lblSsDecryptTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";
       
            //rsa
            var encryptedMessageByRSA = Encoding.Default.GetBytes(ChipertextBox.Text);
            var decryptedMessageByRSA = rsa.Decrypt(rsaEncryptedMessage,true);
            stopWatch.Reset();
            stopWatch.Start();
            for (var i = 0; i < Count; i++)
            {
             decryptedMessageByRSA = rsa.Decrypt(rsaEncryptedMessage, true);
            }
            stopWatch.Stop();
            txtPlainText.Text = Encoding.Default.GetString(decryptedMessageByRSA);
            lblRSAdecTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";
        }

      
      
        
    }

    
}
