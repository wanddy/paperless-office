using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.Kartabl
{
    public class Parvandeh
    {
        OCA.DataAccess.Kartabl.Parvandeh parvandehclass = new OCA.DataAccess.Kartabl.Parvandeh();
        OCA.Common.DataSets.Kartabl.Parvandeh dsparvandeh = new OCA.Common.DataSets.Kartabl.Parvandeh();

        public void InsertParvandeh(string ParvandehName)
        {
            try
            {
                parvandehclass.InsertParvandeh(ParvandehName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.Parvandeh GetParvandeh()
        {
            try
            {
                dsparvandeh.Clear();
                dsparvandeh = parvandehclass.GetParvandeh();
                return dsparvandeh;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //parvandehclass.UpdateParvandeh(DataGridView.SelectedRows[0].Cells["ParvandehName"].Value.ToString(), txtParvandehName.Text.Trim());
        public void UpdateParvandeh(string ParvandehName, string newParvandehName)
        {
            try
            {
                parvandehclass.UpdateParvandeh(ParvandehName, newParvandehName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveParvandeh(string ParvandehName)
        {
            try
            {
                parvandehclass.RemoveParvandeh(ParvandehName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
