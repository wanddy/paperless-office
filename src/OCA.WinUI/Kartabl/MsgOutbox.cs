using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.Kartabl
{
    public partial class MsgOutbox : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Common.DataSets.Kartabl.MessageBox dsmessage = new OCA.Common.DataSets.Kartabl.MessageBox();
        OCA.Business.Kartabl.MessageBox messageclass = new OCA.Business.Kartabl.MessageBox();

        private static string online_Username;
        public string Online_Username
        {
            set
            {
                online_Username = value;
            }
            get
            {
                return online_Username;
            }
        }

        public MsgOutbox()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            try
            {
                dsmessage = messageclass.GetSendedMessages(online_Username);
                dsmessage.AcceptChanges();
                DataGridView.DataSource = dsmessage.Tbl_MessageBox;
                txtMsgName.Clear();
                txtMsgText.Clear();
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void MsgOutbox_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtMsgName.Text = DataGridView.SelectedRows[0].Cells["Message_Name"].Value.ToString().Trim();
                txtMsgText.Text = DataGridView.SelectedRows[0].Cells["Message_Text"].Value.ToString().Trim();
            }
            catch { }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    if (mesg.Question("سوال", "آیا مطمئن هستید که می خواهید این پیام را حذف کنید؟"))
                    {
                        messageclass.RemoveMessage(DataGridView.SelectedRows[0].Cells["Message_Num"].Value.ToString().Trim());
                    }
                }
                else
                    mesg.Warning("خطا", "لطفا پیام مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }
    }
}

