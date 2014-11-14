using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class Semat
    {
        OCA.DataAccess.BaseInformation.Semat sematclass = new OCA.DataAccess.BaseInformation.Semat();
        OCA.Common.DataSets.BaseInformation.Semat dssemat = new OCA.Common.DataSets.BaseInformation.Semat();

        public Boolean IsExistSemat(string SematName)
        {
            try
            {
                dssemat.Clear();
                dssemat = sematclass.IsExistSemat(SematName);
                if (dssemat.Tbl_Semat.Rows.Count == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean IsExistSematGroup(string SematGroupName)
        {
            try
            {
                dssemat.Clear();
                dssemat = sematclass.IsExistSematGroup(SematGroupName);
                if (dssemat.Tbl_SematGroup.Rows.Count == 0)
                    return false;
                else
                    return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Semat GetSemats()
        {
            try
            {
                dssemat.Clear();
                dssemat = sematclass.GetSemats();
                return dssemat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Semat GetSematGroups()
        {
            try
            {
                dssemat.Clear();
                dssemat = sematclass.GetSematGroups();
                return dssemat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Semat GetSematGroup(string SematName)
        {
            try
            {
                dssemat.Clear();
                dssemat = sematclass.GetSematGroup(SematName);
                return dssemat;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertSemat(string SematName, string UpperSemat, string SematGroup)
        {
            try
            {
                sematclass.InsertSemat(SematName, UpperSemat, SematGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertSematGroup(string SematGroup)
        {
            try
            {
                sematclass.InsertSematGroup(SematGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveSemat(string SematName)
        {
            try
            {
                sematclass.RemoveSemat(SematName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveSematGroup(string SematGroup)
        {
            try
            {
                sematclass.RemoveSematGroup(SematGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveSubSemats(string SematName)
        {
            try
            {
                dssemat.Clear();
                dssemat = sematclass.GetSemats();

                RemoveSubSemat(SematName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        void RemoveSubSemat(string SematName)
        {
            for (int i = 1; i <= dssemat.Tbl_Semat.Rows.Count; i++)
            {
                if (dssemat.Tbl_Semat[i - 1].UpperSemat.Trim() == SematName)
                    RemoveSubSemat(dssemat.Tbl_Semat[i - 1].SematName.Trim());
            }
            sematclass.RemoveSemat(SematName);
        }

        public void EditSemat(string SematName, string newSematName, string newSematGroup)
        {
            try
            {
                sematclass.EditSemat(SematName, newSematName, newSematGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditSematGroup(string SematGroup, string newSematGroup)
        {
            try
            {
                sematclass.EditSematGroup(SematGroup, newSematGroup);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
