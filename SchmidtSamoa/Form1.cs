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
        private const int Count = 100;
        private static Stopwatch stopWatch = new Stopwatch();
       

        public Form1()
        {
            InitializeComponent();

            InitSchmidtSamoa(1024);
            InitRSA(1024);
        }

       
        private  void InitSchmidtSamoa(int keySize)
        {
            sSamoa = new SchmidtSamoa(keySize);
            int i;
            
            stopWatch.Reset();
            stopWatch.Start();
            for (i = 0; i < Count; i++)
            {
                sSamoa = new SchmidtSamoa(keySize);
            }
            stopWatch.Stop();
            lblSsKeyGenTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";
        }

        private void InitRSA(int keySize)
        {
            rsa = new RSACryptoServiceProvider(keySize);
            int i;
            stopWatch.Reset();
            stopWatch.Start();
           for(i=0; i< Count; i++)
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
            var encryptedMessage = sSamoa.Encrypt(messageInBytes);
          
            stopWatch.Reset();
            stopWatch.Start();
            for (var i = 0; i < Count; i++)
            {
                encryptedMessage = sSamoa.Encrypt(messageInBytes);
              
            }
            stopWatch.Stop();

            ChipertextBox.Text = Encoding.Default.GetString(encryptedMessage);

            lblSsEncTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";

            //rsa
            var messageInBytesRSA = Encoding.Default.GetBytes(textBoxMessage.Text);
            var encryptedMessageByRSA = rsa.Encrypt(messageInBytesRSA, true);
            stopWatch.Reset();
            stopWatch.Start();
            for (var i = 0; i < Count; i++)
            {
                encryptedMessageByRSA = rsa.Encrypt(messageInBytes, true);
            }
            stopWatch.Stop();
            ChipertextBox.Text = Encoding.Default.GetString(encryptedMessageByRSA);
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
            var decryptedMessageByRSA = rsa.Decrypt(encryptedMessageByRSA, true);

            stopWatch.Reset();
            stopWatch.Start();
            for (var i = 0; i < Count; i++)
            {
                decryptedMessageByRSA = rsa.Decrypt(encryptedMessageByRSA, true);
            }
            stopWatch.Stop();

            txtPlainText.Text = Encoding.Default.GetString(decryptedMessageByRSA);
            lblRSAdecTime.Text = (stopWatch.ElapsedTicks / (10 * Count)).ToString() + " ms";
        
        }
      
        
    }

    
}
