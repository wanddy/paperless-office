using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class MailPriority
    {
        OCA.Common.DataSets.BaseInformation.MailPriority dsmPriority = new OCA.Common.DataSets.BaseInformation.MailPriority();
        OCA.DataAccess.BaseInformation.MailPriority mPriorityclass = new OCA.DataAccess.BaseInformation.MailPriority();

        public OCA.Common.DataSets.BaseInformation.MailPriority GetMailPrioritys()
        {
            try
            {
                dsmPriority.Clear();
                dsmPriority = mPriorityclass.GetMailPrioritys();
                return dsmPriority;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertMailPriority(string PriorityName)
        {
            try
            {
                mPriorityclass.InsertMailPriority(PriorityName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveMailPriority(string PriorityName)
        {
            try
            {
                mPriorityclass.RemoveMailPriority(PriorityName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditMailPriority(string PriorityName, string newPriorityName)
        {
            try
            {
                mPriorityclass.EditMailPriority(PriorityName, newPriorityName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
