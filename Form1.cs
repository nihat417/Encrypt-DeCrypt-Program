using System.Threading;
using System.Windows.Forms;

namespace Encrypt_DeCrypt_Program;

public partial class Form1 : Form
{
    private CancellationTokenSource cts;

    public Form1()
    {
        InitializeComponent();
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
    }



    private void EncryptFile(string inputFile, string outputFile)
    {
        byte[] key = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        byte[] buffer = new byte[4096];
        long totalBytes = new FileInfo(inputFile).Length;
        long bytesProcessed = 0;
        int bytesRead;

        using (FileStream input = new FileStream(inputFile, FileMode.Open))
        {
            using (FileStream output = new FileStream(outputFile, FileMode.Create))
            {
                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        buffer[i] = (byte)(buffer[i] ^ key[i % key.Length]);
                    }

                    output.Write(buffer, 0, bytesRead);
                    bytesProcessed += bytesRead;

                    
                    int progressPercentage = (int)((double)bytesProcessed / totalBytes * 100);
                    progressBar1.Value = progressPercentage;
                }
            }
        }
    }


    private async void DecryptFileAsync(string inputFile, string outputFile, CancellationToken cancellationToken)
    {
        byte[] key = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        byte[] buffer = new byte[4096];
        long totalBytes = new FileInfo(inputFile).Length;
        long bytesProcessed = 0;
        int bytesRead;

        using (FileStream input = new FileStream(inputFile, FileMode.Open))
        {
            using (FileStream output = new FileStream(outputFile, FileMode.Create))
            {
                while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        output.Close();
                        File.Delete(outputFile);
                        File.Move(inputFile, outputFile);
                        return;
                    }

                    for (int i = 0; i < bytesRead; i++)
                    {
                        buffer[i] = (byte)(buffer[i] ^ key[i % key.Length]);
                    }

                    output.Write(buffer, 0, bytesRead);
                    bytesProcessed += bytesRead;

                    int progressPercentage = (int)((double)bytesProcessed / totalBytes * 100);
                    progressBar1.Value = progressPercentage;
                }
            }
        }
    }



    private void FileBtn_Click(object sender, EventArgs e)
    {
        OpenFileDialog dlg=new OpenFileDialog();
        dlg.DefaultExt = ".txt";
        dlg.Filter = "Text documents (.txt)|*.txt;*.enc;*dec";

        if (dlg.ShowDialog()==DialogResult.OK)
        {
            FileTxt.Text = dlg.FileName;
        }
    }

    private async void EncryptBtn_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(FileTxt.Text))
        {
            string inputFileName = FileTxt.Text;
            string outputFileName = Path.ChangeExtension(inputFileName, ".enc");

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

           

            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken cancellationToken = cts.Token;


            ThreadPool.QueueUserWorkItem(async state =>
            {
                try
                {
                    await Task.Run(() => EncryptFile(inputFileName, outputFileName), cancellationToken);
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Encrypt Canceled");
                }
            });
        }
    }

    private async void DeCryptBtn_Click(object sender, EventArgs e)
    {
    
        if (!string.IsNullOrEmpty(FileTxt.Text))
        {
            string inputFileName = FileTxt.Text;
            string outputFileName = Path.ChangeExtension(inputFileName, ".dec");
    
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
    
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken cancellationToken = cts.Token;
    
           
            ThreadPool.QueueUserWorkItem(async state =>
            {
                try
                {
                    await Task.Run(() => DecryptFileAsync(inputFileName, outputFileName, cancellationToken), cancellationToken);
                }
                catch (OperationCanceledException)
                {                    
                    MessageBox.Show("Decrypt Canceled");
                }
            });
        }
    }

    private void CancelBtn_Click(object sender, EventArgs e)
    {
        cts.Cancel();
    }




    
}