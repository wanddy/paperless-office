using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class Access
    {
        OCA.Common.DataSets.BaseInformation.Access dsaccess = new OCA.Common.DataSets.BaseInformation.Access();
        OCA.DataAccess.BaseInformation.Access accessclass = new OCA.DataAccess.BaseInformation.Access();
        OCA.DataAccess.BaseInformation.Clerk clerkclass = new OCA.DataAccess.BaseInformation.Clerk(); 

        public void InsertAccess(string AccessName, int CreateMail, int EditMail, int Draft, int MailInbox, int MailOutbox,
            int ReferMail, int ArchiveMail, int MailHistory, int SearchMail, int InsertParvandeh, int ViewParvandeh, int MsgInbox,
            int MsgOutbox,int SendMessage, int DeletedMessage, int InsertImportMail, int ViewImportMail, int InsertExportMail,
            int ViewExportMail, int ViewInternalMail, int DefineChart, int ViewChart, int CompanyInfo, int NewSemat,
            int EditSemat, int SematGroup, int NewAccess, int EditAccess2, int EditAccess, int NewClerk, int EditClerk, 
            int ClerkGroup, int NewExOffice, int EditExOffice, int NewAddress, int EditAddress, int MailNumber, int MailTopic,
            int MailCondition, int MailPriority, int MailSecurity, int ReferenceDescription, int ColorSetting, int FaxSetting,
            int PrinterSetting, int ScanerSetting, int EmailSetting, int BackUp, int NewReminder, int EditReminder, int NewNews,
            int EditNews, int TextComm, int VoiceComm, int VideoComm )
        {
            try
            {
                accessclass.InsertAccess(AccessName, CreateMail, EditMail, Draft, MailInbox, MailOutbox, ReferMail, ArchiveMail,
                    MailHistory, SearchMail, InsertParvandeh, ViewParvandeh, MsgInbox, MsgOutbox,SendMessage, DeletedMessage,
                    InsertImportMail, ViewImportMail, InsertExportMail, ViewExportMail, ViewInternalMail, DefineChart, ViewChart,
                    CompanyInfo, NewSemat, EditSemat, SematGroup, NewAccess, EditAccess2, EditAccess, NewClerk, EditClerk, ClerkGroup,
                    NewExOffice, EditExOffice, NewAddress, EditAddress, MailNumber, MailTopic, MailCondition, MailPriority,
                    MailSecurity, ReferenceDescription, ColorSetting, FaxSetting, PrinterSetting, ScanerSetting, EmailSetting,
                    BackUp, NewReminder, EditReminder, NewNews, EditNews, TextComm, VoiceComm, VideoComm );
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAccess(string AccessName, int CreateMail, int EditMail, int Draft, int MailInbox, int MailOutbox,
            int ReferMail, int ArchiveMail, int MailHistory, int SearchMail, int InsertParvandeh, int ViewParvandeh, int MsgInbox,
            int MsgOutbox, int SendMessage, int DeletedMessage, int InsertImportMail, int ViewImportMail, int InsertExportMail,
            int ViewExportMail, int ViewInternalMail, int DefineChart, int ViewChart, int CompanyInfo, int NewSemat,
            int EditSemat, int SematGroup, int NewAccess, int EditAccess2, int EditAccess, int NewClerk, int EditClerk,
            int ClerkGroup, int NewExOffice, int EditExOffice, int NewAddress, int EditAddress, int MailNumber, int MailTopic,
            int MailCondition, int MailPriority, int MailSecurity, int ReferenceDescription, int ColorSetting, int FaxSetting,
            int PrinterSetting, int ScanerSetting, int EmailSetting, int BackUp, int NewReminder, int EditReminder, int NewNews,
            int EditNews, int TextComm, int VoiceComm, int VideoComm)
        {
            try
            {
                accessclass.UpdateAccess(AccessName, CreateMail, EditMail, Draft, MailInbox, MailOutbox, ReferMail, ArchiveMail,
                    MailHistory, SearchMail, InsertParvandeh, ViewParvandeh, MsgInbox, MsgOutbox, SendMessage, DeletedMessage,
                    InsertImportMail, ViewImportMail, InsertExportMail, ViewExportMail, ViewInternalMail, DefineChart, ViewChart,
                    CompanyInfo, NewSemat, EditSemat, SematGroup, NewAccess, EditAccess2, EditAccess, NewClerk, EditClerk, ClerkGroup,
                    NewExOffice, EditExOffice, NewAddress, EditAddress, MailNumber, MailTopic, MailCondition, MailPriority,
                    MailSecurity, ReferenceDescription, ColorSetting, FaxSetting, PrinterSetting, ScanerSetting, EmailSetting,
                    BackUp, NewReminder, EditReminder, NewNews, EditNews, TextComm, VoiceComm, VideoComm);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Access GetAccess()
        {
            try
            {
                dsaccess.Clear();
                dsaccess = accessclass.GetAccess();
                return dsaccess;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.BaseInformation.Access GetAccessByUsername(string Username)
        {
            try
            {
                dsaccess.Clear();

                string AccessName = clerkclass.GetAccessNameByUsername(Username);

                dsaccess = accessclass.GetAccessByAccessname(AccessName);

                return dsaccess;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateAccess(string AccessName, string newAccessName)
        {
            try
            {
                accessclass.UpdateAccess(AccessName, newAccessName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveAccess(string AccessName)
        {
            try
            {
                accessclass.RemoveAccess(AccessName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean IsAccessExist(string AccessName)
        {
            try
            {
                return accessclass.IsAccessExist(AccessName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
