using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OCA.WinUI.BaseInformation
{
    public partial class EditAccess : OCA.WinUI.BaseForms.BaseChildForm
    {
        OCA.WinUI.BaseForms.BaseMessageBox mesg = new OCA.WinUI.BaseForms.BaseMessageBox();
        OCA.Business.BaseInformation.Access accessclass = new OCA.Business.BaseInformation.Access();
        OCA.Business.Public puclass = new OCA.Business.Public();
        OCA.Common.DataSets.BaseInformation.Access dsaccess = new OCA.Common.DataSets.BaseInformation.Access();

        public EditAccess()
        {
            InitializeComponent();
        }

        public void Load_DataGridView()
        {
            dsaccess = accessclass.GetAccess();
            dsaccess.AcceptChanges();
            DataGridView.DataSource = dsaccess.Tbl_Access;
            txtAccessName.Clear();
        }

        private void EditAccess_Load(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (DataGridView.SelectedRows.Count == 1)
                {
                    if (DataGridView.SelectedRows[0].Cells["AccessName"].Value.ToString().Trim() != "مدير ارشد")
                    {
                        accessclass.RemoveAccess(DataGridView.SelectedRows[0].Cells["AccessName"].Value.ToString());
                    }
                    else
                        mesg.Warning("خطا", "سطح دسترسی مدیر ارشد قابل حذف نمی باشد!");
                }
                else
                    mesg.Warning("خطا", "لطفا سطح دسترسی مورد نظر را انتخاب کنید!");
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
                    if (DataGridView.SelectedRows[0].Cells["AccessName"].Value.ToString().Trim() != "مدير ارشد")
                    {
                        txtAccessName.Text = DataGridView.SelectedRows[0].Cells["AccessName"].Value.ToString().Trim();
                        BtnEdit.Enabled = false;
                        BtnRemove.Enabled = false;
                        BtnRefresh.Enabled = false;
                        BtnSave.Enabled = true;
                        BtnCancel.Enabled = true;
                        txtAccessName.ReadOnly = false;
                    }
                    else
                        mesg.Warning("خطا", "سطح دسترسی مدیر ارشد قابل ویرایش نمی باشد!");
                }
                else
                    mesg.Warning("خطا", "لطفا سطح دسترسی مورد نظر را انتخاب کنید!");
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
            BtnRefresh.Enabled = true;
            txtAccessName.ReadOnly = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccessName.Text.Trim() != "")
                {
                    accessclass.UpdateAccess(DataGridView.SelectedRows[0].Cells["AccessName"].Value.ToString(), txtAccessName.Text.Trim());
                }
                else
                    mesg.Warning("خطا", "لطفا نام سطح دسترسی را وارد کنید!");
            }
            catch (Exception ex)
            {
                mesg.Error("خطا", ex.Message);
            }

            Load_DataGridView();
            BtnSave.Enabled = false;
            BtnCancel.Enabled = false;
            BtnEdit.Enabled = true;
            BtnRemove.Enabled = true;
            BtnRefresh.Enabled = true;
            txtAccessName.ReadOnly = true;
        }

        private void txtAccessName_TextChanged(object sender, EventArgs e)
        {
            txtAccessName.Text = puclass.SqlInjection(txtAccessName.Text);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Load_DataGridView();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            try
            {
                txtAccessName.Text = DataGridView.SelectedRows[0].Cells["AccessName"].Value.ToString().Trim();
            }
            catch { }
        }

        

        
    }
}

