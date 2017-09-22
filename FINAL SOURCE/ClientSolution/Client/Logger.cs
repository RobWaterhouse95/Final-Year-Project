using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows;

namespace Client
{
    class Logger
    {
        List<string> sList = new List<string>();
        ClientForm _ParentForm;

        //Pass through the parent form of the logger so it can access the log object
        public Logger(ClientForm form)
        {
            _ParentForm = form;
            //File Header Text
            string entryText = "Test started at: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            string template = "Type, Local Port, Remote Address, Remote Port, Data, Time";
            sList.Add(entryText);
            sList.Add(template);            
        }

        //Append the log list with another log
        public void appendLogFile(string msg)
        {
            //Append the log list with any logs passed through
            sList.Add(msg);
        }

        /// <summary>
        /// Save the file and output all log data to it
        /// </summary>
        public void logToFile()
        {
            //Configure defaults for the file to be saved
            Stream myStream;
            SaveFileDialog saveBox = new SaveFileDialog();
            saveBox.InitialDirectory = Directory.GetCurrentDirectory();
            saveBox.FileName = "Latency-Tool-Log--" + DateTime.Now.ToString("yyyy-MM-dd--HH.mm");
            saveBox.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            saveBox.FilterIndex = 2;
            saveBox.RestoreDirectory = true;

            //Open the save file dialog and output the log data to it
            if (saveBox.ShowDialog() == DialogResult.OK){
                if ((myStream = saveBox.OpenFile()) != null){
                    Byte[] data = returnBArray();
                    myStream.Write(data, 0, data.Length);
                    myStream.Close();
                }
            }

            //Ask the user whether they want to open the file (Yes / No) Popup
            string message = "Do you want to open the file?";
            string caption = "Open file?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes){
                System.Diagnostics.Process.Start(saveBox.FileName);
            }
        }

        /// <summary>
        /// Returns a byte array of the current log list
        /// </summary>
        /// <returns></returns>
        Byte[] returnBArray()
        {
            Byte[] array = sList.SelectMany(s => System.Text.Encoding.ASCII.GetBytes(s + "\r\n")).ToArray();
            return array;
        }
    }
}
