using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class EditClerk : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.Public pubclass = new OCA.Business.Public();
        OCA.Business.BaseInformation.Clerk clerkclass = new OCA.Business.BaseInformation.Clerk();
        OCA.Common.DataSets.BaseInformation.Clerk dsclerk = new OCA.Common.DataSets.BaseInformation.Clerk();
        OCA.Business.BaseInformation.Semat sematclass = new OCA.Business.BaseInformation.Semat();
        OCA.Common.DataSets.BaseInformation.Semat dssemat = new OCA.Common.DataSets.BaseInformation.Semat();
        OCA.Business.BaseInformation.Access accessclass = new OCA.Business.BaseInformation.Access();
        OCA.Common.DataSets.BaseInformation.Access dsaccess = new OCA.Common.DataSets.BaseInformation.Access();
        OCA.Business.BaseInformation.Unit unitclass = new OCA.Business.BaseInformation.Unit();
        OCA.Common.DataSets.BaseInformation.Unit dsunit = new OCA.Common.DataSets.BaseInformation.Unit();
        OCA.Business.Kartabl.MailBox mailclass = new OCA.Business.Kartabl.MailBox();
        OCA.Business.Kartabl.MessageBox messageclass = new OCA.Business.Kartabl.MessageBox();

        public EditClerk()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            try
            {

                txtName.Clear();
                txtFamily.Clear();
                txtUsername.Clear();
                txtPassword.Clear();
                CmbAccess.Text = "";
                CmbAccess.Items.Clear();
                CmbSemat.Text = "";
                CmbSemat.Items.Clear();
                CmbUnit.Text = "";
                CmbUnit.Items.Clear();
                CmbClerkGroup.Text = "";
                CmbClerkGroup.Items.Clear();

                dsclerk = clerkclass.GetClerkGroups();
                for (int i = 1; i <= dsclerk.Tbl_ClerkGroup.Rows.Count; i++)
                {
                    CmbClerkGroup.Items.Add(dsclerk.Tbl_ClerkGroup[i - 1].GroupName.Trim());
                }

                dsunit = unitclass.GetAllUnits();
                for (int i = 1; i <= dsunit.Tbl_Unit.Rows.Count; i++)
                {
                    CmbUnit.Items.Add(dsunit.Tbl_Unit[i - 1].UnitName.Trim());
                }

                dssemat = sematclass.GetSemats();
                for (int i = 1; i <= dssemat.Tbl_Semat.Rows.Count; i++)
                {
                    CmbSemat.Items.Add(dssemat.Tbl_Semat[i - 1].SematName.Trim());
                }

                dsaccess = accessclass.GetAccess();
                for (int i = 1; i <= dsaccess.Tbl_Access.Rows.Count; i++)
                {
                    CmbAccess.Items.Add(dsaccess.Tbl_Access[i - 1].AccessName.Trim());
                }

                dsclerk = clerkclass.GetClerks();
                dsclerk.AcceptChanges();
                DataGridView.DataSource = dsclerk.Tbl_Clerk;

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void EditClerk_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    if (DataGridView.SelectedRows[0].Cells["ClerkID"].Value.ToString().Trim() != "1")
                    {
                        clerkclass.RemoveClerk(DataGridView.SelectedRows[0].Cells["Username"].Value.ToString());
                    }
                    else
                        mesg.Warning("خطا", "کاربر مدیر اصلی قابل حذف نمی باشد!");
                }
                else
                    mesg.Warning("خطا", "لطفا کاربر مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    txtName.Text = DataGridView.SelectedRows[0].Cells["Name_"].Value.ToString().Trim();
                    txtFamily.Text = DataGridView.SelectedRows[0].Cells["Family"].Value.ToString().Trim();
                    txtUsername.Text = DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim();
                    CmbAccess.Text = DataGridView.SelectedRows[0].Cells["Access"].Value.ToString().Trim();
                    CmbSemat.Text = DataGridView.SelectedRows[0].Cells["Semat"].Value.ToString().Trim();
                    CmbUnit.Text = DataGridView.SelectedRows[0].Cells["Unit"].Value.ToString().Trim();
                    CmbClerkGroup.Text = DataGridView.SelectedRows[0].Cells["ClerkGroup"].Value.ToString().Trim();

                    BtnEdit.Enabled = false;
                    BtnRemove.Enabled = false;
                    BtnSave.Enabled = true;
                    BtnCancel.Enabled = true;
                }
                else
                    mesg.Warning("خطا", "لطفا کاربر مورد نظر را انتخاب کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا نام کاربر را وارد کنید!");
                else if (txtFamily.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا نام خانوادگی کاربر را وارد کنید!");
                else if (txtUsername.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا نام کاربری کاربر را وارد کنید!");
                else if (txtPassword.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا کلمه عبور کاربر را وارد کنید!");
                else if (CmbAccess.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا سطح دسترسی کاربر را انتخاب کنید!");
                else if (CmbSemat.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا سمت کاربر را انتخاب کنید!");
                else if (CmbUnit.Text.Trim() == "")
                    mesg.Error("خطا", "لطفا واحد سازمانی کاربر را انتخاب کنید!");
                else if (CmbClerkGroup.Text.Trim() != "" && CmbClerkGroup.SelectedIndex == -1)
                {
                    mesg.Error("خطا", "لطفا نام گروه کاربری را درست انتخاب کنید!");
                }
                else if (txtUsername.Text.Trim().Length < 4)
                    mesg.Error("خطا", "طول نام کاربری باید حداقل 4 کاراکتر باشد!");
                else if (txtPassword.Text.Trim().Length < 4)
                    mesg.Error("خطا", "طول کلمه عبور باید حداقل 4 کاراکتر باشد!");
                else
                {

                    clerkclass.UpdateClerk(DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim(),
                        txtUsername.Text.Trim(), txtName.Text.Trim(), txtFamily.Text.Trim(), txtPassword.Text.Trim(),
                        CmbClerkGroup.Text.Trim(), CmbAccess.Text.Trim(), CmbSemat.Text.Trim(), CmbUnit.Text.Trim());

                    //Update MailBox Table
                    mailclass.Update_MailColumn("Mail_Owner_User", DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim(), txtUsername.Text.Trim());
                    mailclass.Update_MailColumn("Owner_Name", DataGridView.SelectedRows[0].Cells["Name_"].Value.ToString().Trim() + " " + DataGridView.SelectedRows[0].Cells["Family"].Value.ToString().Trim(), txtName.Text.Trim() + " " + txtFamily.Text.Trim());
                    mailclass.Update_MailColumn("Sender_User", DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim(), txtUsername.Text.Trim());
                    mailclass.Update_MailColumn("Sender_Name", DataGridView.SelectedRows[0].Cells["Name_"].Value.ToString().Trim() + " " + DataGridView.SelectedRows[0].Cells["Family"].Value.ToString().Trim(), txtName.Text.Trim() + " " + txtFamily.Text.Trim());
                    mailclass.Update_MailColumn("Receiver_User", DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim(), txtUsername.Text.Trim());
                    mailclass.Update_MailColumn("Receiver_Name", DataGridView.SelectedRows[0].Cells["Name_"].Value.ToString().Trim() + " " + DataGridView.SelectedRows[0].Cells["Family"].Value.ToString().Trim(), txtName.Text.Trim() + " " + txtFamily.Text.Trim());
                    
                    //Update MessageBox Table
                    messageclass.Update_MessageColumn("Sender_User", DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim(), txtUsername.Text.Trim());
                    messageclass.Update_MessageColumn("Sender_Name", DataGridView.SelectedRows[0].Cells["Name_"].Value.ToString().Trim() + " " + DataGridView.SelectedRows[0].Cells["Family"].Value.ToString().Trim(), txtName.Text.Trim() + " " + txtFamily.Text.Trim());
                    messageclass.Update_MessageColumn("Receiver_User", DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim(), txtUsername.Text.Trim());
                    messageclass.Update_MessageColumn("Receiver_Name", DataGridView.SelectedRows[0].Cells["Name_"].Value.ToString().Trim() + " " + DataGridView.SelectedRows[0].Cells["Family"].Value.ToString().Trim(), txtName.Text.Trim() + " " + txtFamily.Text.Trim());

                    ///////

                    Load_DataGridView();
                    BtnSave.Enabled = false;
                    BtnCancel.Enabled = false;
                    BtnEdit.Enabled = true;
                    BtnRemove.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            CmbSearchKind.Text = "";
            Load_DataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            txtSearch.Text = pubclass.SqlInjection(txtSearch.Text);

            if (CmbSearchKind.Text.Trim() == "شماره پرسنلی")
                clerkclass.SearchClerk("ClerkID", txtSearch.Text.Trim());
            else if (CmbSearchKind.Text.Trim() == "نام خانوادگی")
                clerkclass.SearchClerk("Family", txtSearch.Text.Trim());
            else if (CmbSearchKind.Text.Trim() == "سمت")
                clerkclass.SearchClerk("Semat", txtSearch.Text.Trim());
            else if (CmbSearchKind.Text.Trim() == "دسترسی")
                clerkclass.SearchClerk("Access", txtSearch.Text.Trim());
            else if (CmbSearchKind.Text.Trim() == "واحد سازمانی")
                clerkclass.SearchClerk("Unit", txtSearch.Text.Trim());
            else if (CmbSearchKind.Text.Trim() == "گروه کاربری")
                clerkclass.SearchClerk("ClerkGroup", txtSearch.Text.Trim());
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            txtName.Text = pubclass.SqlInjection(txtName.Text);
        }

        private void txtFamily_TextChanged(object sender, EventArgs e)
        {
            txtFamily.Text = pubclass.SqlInjection(txtFamily.Text);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            txtUsername.Text = pubclass.SqlInjection(txtUsername.Text);
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Text = pubclass.SqlInjection(txtPassword.Text);
        }

        private void CmbAccess_TextChanged(object sender, EventArgs e)
        {
            CmbAccess.Text = pubclass.SqlInjection(CmbAccess.Text);
        }

        private void CmbSemat_TextChanged(object sender, EventArgs e)
        {
            CmbSemat.Text = pubclass.SqlInjection(CmbSemat.Text);
        }

        private void CmbUnit_TextChanged(object sender, EventArgs e)
        {
            CmbUnit.Text = pubclass.SqlInjection(CmbUnit.Text);
        }

        private void CmbSearchKind_TextChanged(object sender, EventArgs e)
        {
            CmbSearchKind.Text = pubclass.SqlInjection(CmbSearchKind.Text);
            txtSearch.Clear();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = DataGridView.SelectedRows[0].Cells["Name_"].Value.ToString().Trim();
                txtFamily.Text = DataGridView.SelectedRows[0].Cells["Family"].Value.ToString().Trim();
                txtUsername.Text = DataGridView.SelectedRows[0].Cells["Username"].Value.ToString().Trim();
                CmbAccess.Text = DataGridView.SelectedRows[0].Cells["Access"].Value.ToString().Trim();
                CmbSemat.Text = DataGridView.SelectedRows[0].Cells["Semat"].Value.ToString().Trim();
                CmbUnit.Text = DataGridView.SelectedRows[0].Cells["Unit"].Value.ToString().Trim();
                CmbClerkGroup.Text = DataGridView.SelectedRows[0].Cells["ClerkGroup"].Value.ToString().Trim();
            }
            catch { }
        }

        private void Btn_EditAccess_Click(object sender, EventArgs e)
        {
            if (CmbAccess.Text.Trim() != "")
            {
                if (accessclass.IsAccessExist(CmbAccess.Text.Trim()))
                {
                    OCA.WinUI.BaseInformation.EditAccess2 editAccess2 = new OCA.WinUI.BaseInformation.EditAccess2();
                    editAccess2.WindowState = FormWindowState.Maximized;
                    editAccess2.CmbAccessName.Text = CmbAccess.Text.Trim();
                    editAccess2.ShowSelectedAccess();
                    editAccess2.MdiParent = this.MdiParent;
                    editAccess2.Show();
                }
                else
                    mesg.Warning("خطا", "گروه دسترسی ای با این نام موجود نیست!");
            }
            else
                mesg.Warning("خطا", "لطفا نام گروه دسترسی را وارد کنید!");
        }


    }
}

