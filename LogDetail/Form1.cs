using LogDetail.JobLogger_LuisBegazo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogDetail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTypeMessage();
        }


        private void LoadTypeMessage()
        {
            try
            {
                cmbTypeMessage.DataSource = Enum.GetValues(typeof(MessageType));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            int typeMessage = 0;
            MessageType messageType;

            try
            {
                message = txtMessage.Text.Trim();

                if (cmbTypeMessage.SelectedValue != null)
                {                                        
                    Enum.TryParse<MessageType>(cmbTypeMessage.SelectedValue.ToString(), out messageType);                    
                    typeMessage = (int)messageType;
                }

                JobLogger_LuisBegazo.JobLogger job = new JobLogger_LuisBegazo.JobLogger();

                #region LogMessageType

                job.LogMsg = chkMessage.Checked ? true : false;
                job.LogError = chkError.Checked ? true : false;
                job.LogWarning = chkWarning.Checked ? true : false;

                #endregion LogTypeMessage

                #region Target

                job.LogToDataBase = chkLogDatabase.Checked ? true : false;
                job.LogToConsole = chkLogConsole.Checked ? true : false;
                job.LogToFile = chkLogFile.Checked ? true : false;

                #endregion Target

                bool result = job.LogMessage(typeMessage, message);
                if(result)
                    MessageBox.Show("Log saved!!!!");
                else
                    MessageBox.Show("Log did not saved!!!!");
                CleanControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanControls()
        {
            LoadTypeMessage();
            txtMessage.Text = string.Empty;
            chkWarning.Checked = false;
            chkMessage.Checked = false;
            chkError.Checked = false;
            chkLogConsole.Checked = false;
            chkLogDatabase.Checked = false;
            chkLogFile.Checked = false;
        }

    }
}

