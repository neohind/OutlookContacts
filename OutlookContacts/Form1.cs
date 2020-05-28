using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Outlook = NetOffice.OutlookApi;

namespace OutlookContacts
{
    public partial class Form1 : Form
    {
        Outlook.Application m_app = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (m_app == null)
            {
                m_app = new Outlook.Application();
                Outlook._NameSpace ns = m_app.GetNamespace("MAPI");

                foreach(Outlook.MAPIFolder folder in ns.Folders)
                {
                    txtResults.AppendText(string.Format("{0} - {1}\r\n", folder.Name, folder.DefaultItemType));
                    TraverseFolders(folder);                    
                }

                Outlook.MAPIFolder selectedFolder  = ns.GetFolderFromID("00000000C5B7DEF515463948B280312D7005404A02870000");

                foreach(object oItem in selectedFolder.Items)
                {
                    if (oItem is Outlook.ContactItem)
                    {

                        Outlook.ContactItem item = (Outlook.ContactItem)oItem;

                        txtResults.AppendText(string.Format("{0}/{1}\r\n", item.FirstName, item.LastName));

                        if (string.Equals("LastName", item.LastName))
                        {
                            propertyGrid1.SelectedObject = item;

                            var props = TypeDescriptor.GetProperties(item);
                            foreach (PropertyDescriptor prop in props)
                            {
                                try
                                {
                                    txtResults.AppendText(string.Format("{0} : {1}\r\n", prop.DisplayName, prop.GetValue(item)));
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                            }
                        }                        
                    }
                }
                
            }
        }

        private void TraverseFolders(Outlook.MAPIFolder parentFolder)
        {
            foreach (Outlook.MAPIFolder folder in parentFolder.Folders)
            {
                if (folder.DefaultItemType == Outlook.Enums.OlItemType.olContactItem)
                {
                    txtResults.AppendText(string.Format("{0} - {1} [{2}]\r\n", folder.Name, folder.DefaultItemType, folder.EntryID));
                    TraverseFolders(folder);
                }
            }

            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(m_app != null)
                m_app.Dispose();
            m_app = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Encoding cp949 = Encoding.GetEncoding(949);
            using (StreamReader reader = File.OpenText(@"D:\MyData\Desktop\contacts2.CSV"))
            using (FileStream stream = File.Create(@"D:\MyData\Desktop\contacts3.CSV", 1024, FileOptions.None))
            {
                while(reader.EndOfStream == false)
                {
                    string sReadLine = reader.ReadLine();
                    byte[] aryLineData = cp949.GetBytes(sReadLine);
                    stream.Write(aryLineData, 0, aryLineData.Length);
                    stream.WriteByte((byte)13);
                    stream.WriteByte((byte)10);
                }
                reader.Close();
                stream.Close();
            }
        }
    }
}
