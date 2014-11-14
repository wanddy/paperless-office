using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class MailCondition
    {
        OCA.Common.DataSets.BaseInformation.MailCondition dsmCondition = new OCA.Common.DataSets.BaseInformation.MailCondition();
        OCA.DataAccess.BaseInformation.MailCondition mConditionclass = new OCA.DataAccess.BaseInformation.MailCondition();

        public OCA.Common.DataSets.BaseInformation.MailCondition GetMailConditions()
        {
            try
            {
                dsmCondition.Clear();
                dsmCondition = mConditionclass.GetMailConditions();
                return dsmCondition;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertMailCondition(string ConditionName)
        {
            try
            {
                mConditionclass.InsertMailCondition(ConditionName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveMailCondition(string ConditionName)
        {
            try
            {
                mConditionclass.RemoveMailCondition(ConditionName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditMailCondition(string ConditionName, string newConditionName)
        {
            try
            {
                mConditionclass.EditMailCondition(ConditionName, newConditionName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
