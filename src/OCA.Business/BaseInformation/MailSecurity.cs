using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class MailSecurity
    {
        OCA.Common.DataSets.BaseInformation.MailSecurity dsmSecurity = new OCA.Common.DataSets.BaseInformation.MailSecurity();
        OCA.DataAccess.BaseInformation.MailSecurity mSecurityclass = new OCA.DataAccess.BaseInformation.MailSecurity();

        public OCA.Common.DataSets.BaseInformation.MailSecurity GetMailSecuritys()
        {
            try
            {
                dsmSecurity.Clear();
                dsmSecurity = mSecurityclass.GetMailSecuritys();
                return dsmSecurity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertMailSecurity(string SecurityName)
        {
            try
            {
                mSecurityclass.InsertMailSecurity(SecurityName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveMailSecurity(string SecurityName)
        {
            try
            {
                mSecurityclass.RemoveMailSecurity(SecurityName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditMailSecurity(string SecurityName, string newSecurityName)
        {
            try
            {
                mSecurityclass.EditMailSecurity(SecurityName, newSecurityName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
