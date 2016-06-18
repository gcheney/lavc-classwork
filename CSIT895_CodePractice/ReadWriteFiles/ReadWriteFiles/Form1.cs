using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ReadWriteFiles
{
    public partial class Form1 : Form
    {
        string file_name;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (.txt)|*.txt|All Files|*.*";
            openFile.FilterIndex = 1;
            openFile.Multiselect = false;

            DialogResult result = openFile.ShowDialog();

            if (result==DialogResult.OK)
            {
                string textLine = "";
                file_name = openFile.FileName;
                StreamReader fileReader = new StreamReader(file_name);
                while (fileReader.Peek() != -1)
                {
                    textLine += fileReader.ReadLine() + "\r\n";
                } 

                txtBox.Text = textLine;
                fileReader.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter fileWriter = new StreamWriter(file_name);

                foreach (string s in txtBox.Lines)
                {
                    fileWriter.WriteLine(s);
                }

                MessageBox.Show("File succesfully saved");
                fileWriter.Close();
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Please use the Save As feature to save a new file.\n");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files|*.txt";
            saveFile.Title = "Save your file as...";
            DialogResult dr = saveFile.ShowDialog();

            if (saveFile.FileName != "" && dr==DialogResult.OK)
            {
                file_name = saveFile.FileName;

                if (File.Exists(file_name))
                {
                    dr = MessageBox.Show("Are you sure? This action cannot be undone.",
                        "Overwrite File", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                if(dr==DialogResult.OK || !File.Exists(file_name)){
                    try
                    {
                        File.Delete(file_name);
                        using (Stream stream = File.Open(file_name, FileMode.CreateNew))
                        using (StreamWriter fileWriter = new StreamWriter(stream))
                        {
                            foreach (string s in txtBox.Lines)
                            {
                                fileWriter.WriteLine(s);
                            }
                            fileWriter.Close();
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Save As Cancelled.");
            }
        }

    }

}
