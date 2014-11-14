using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OCA.Business.Kartabl
{
    public class MailBox
    {
        OCA.DataAccess.Kartabl.MailBox mailclass = new OCA.DataAccess.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.MailBox dsmail = new OCA.Common.DataSets.Kartabl.MailBox();
        OCA.Common.DataSets.Kartabl.Attach dsattach = new OCA.Common.DataSets.Kartabl.Attach();

        public void InsertDraft(string Draft_User, string Draft_Name, string Draft_Text)
        {
            try
            {
                mailclass.InsertDraft(Draft_User, Draft_Name, Draft_Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetDrafts(string Username)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetDrafts(Username);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveDraft(string Draft_User, string Draft_Name)
        {
            try
            {
                mailclass.RemoveDraft(Draft_User, Draft_Name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchDraft(string Username , string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchDraft(Username , SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetMails(string Owner_Username)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetMails(Owner_Username);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchMailProgress(string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchMailProgress(SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetAllMails()
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetAllMails();
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean IsMailExist(string MailName)
        {
            try
            {
                return mailclass.IsMailExist(MailName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertMail(string Mail_Date, string Mail_Owner_User,string Owner_Name, string Mail_Name, string Sender_User, string Sender_Name, string Receiver_User, string Receiver_Name, string Mail_Topic, string Mail_Priority, string Mail_Security, string Mail_Condition, string Refer_Description, string Mail_Text, string Mail_SignerName, string Mail_Sign)
        {
            try
            {
                byte[] PicSign;

                if (Mail_Sign != "")
                {
                    FileStream myStream = new FileStream(Mail_Sign, FileMode.Open, FileAccess.Read);
                    PicSign = new byte[myStream.Length];
                    myStream.Read(PicSign, 0, (int)myStream.Length);
                    myStream.Close();
                }
                else
                    PicSign = null;

                mailclass.InsertMail(Mail_Date, Mail_Owner_User, Owner_Name, Mail_Name, Sender_User, Sender_Name, Receiver_User, Receiver_Name, Mail_Topic, Mail_Priority, Mail_Security, Mail_Condition, Refer_Description, Mail_Text, Mail_SignerName, PicSign);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal GetMailNum(string Owner_Username, string MailName, string Sender_Username, string Receiver_Username)
        {
            try
            {
                return mailclass.GetMailNum(Owner_Username, MailName, Sender_Username, Receiver_Username);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertAttach(string Mail_Num, string Attach_Name, string Attach_Kind, string StrAttach_File)
        {
            try
            {
                byte[] AttachFile;

                if (StrAttach_File != "")
                {
                    FileStream myStream = new FileStream(StrAttach_File, FileMode.Open, FileAccess.Read);
                    AttachFile = new byte[myStream.Length];
                    myStream.Read(AttachFile, 0, (int)myStream.Length);
                    myStream.Close();
                }
                else
                    AttachFile = null;

                mailclass.InsertAttach(Mail_Num, Attach_Name, Attach_Kind, AttachFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetReceivedMails(string Username)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetReceivedMails(Username);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetSendedMails(string Username)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetSendedMails(Username);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetArchivedMails(string Username)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetArchivedMails(Username);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetInternalMails()
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetInternalMails();
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.Attach GetAttaches(string Mail_Num)
        {
            try
            {
                dsattach.Clear();
                dsattach = mailclass.GetAttaches(Mail_Num);
                return dsattach;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveAttach(string Mail_Num)
        {
            try
            {
                mailclass.RemoveAttach(Mail_Num);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveMail(string Mail_Num)
        {
            try
            {
                mailclass.RemoveMail(Mail_Num);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchReceivedMail(string Username , string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchReceivedMail(Username , SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchSendedMail(string Username, string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchSendedMail(Username, SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchArchivedMail(string SearchKind, string Username, string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchArchivedMail(SearchKind, Username, SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchAllMail(string SearchKind, string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchAllMail(SearchKind, SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchInternalMail(string SearchKind, string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchInternalMail(SearchKind, SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchReceivedDabirkhanehMail(string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchReceivedDabirkhanehMail(SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox SearchSendedDabirkhanehMail(string SearchWord)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.SearchSendedDabirkhanehMail(SearchWord);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetReceivedDabirkhanehMails()
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetReceivedDabirkhanehMails();
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetSendedDabirkhanehMails()
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetSendedDabirkhanehMails();
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void MakeArchiveMail(string Mail_Num)
        {
            try
            {
                mailclass.MakeArchiveMail(Mail_Num);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void SetParvandehMail(string Mail_Num, string ParvandehName)
        {
            try
            {
                mailclass.SetParvandehMail(Mail_Num, ParvandehName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MailBox GetReportMailByMailNum(string Mail_Num)
        {
            try
            {
                dsmail.Clear();
                dsmail = mailclass.GetReportMailByMailNum(Mail_Num);
                return dsmail;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.Attach GetAttachesByName(string Attach_Name, string Mail_Num)
        {
            try
            {
                dsattach.Clear();
                dsattach = mailclass.GetAttachesByName(Attach_Name, Mail_Num);
                return dsattach;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update_Mail(string Mail_Num, string Mail_Date, string Mail_Topic, string Mail_Priority,
            string Mail_Security, string Mail_Condition, string Mail_Text, string Mail_SignerName, string str_PicSign)
        {
            try
            {
                byte[] PicSign;

                if (str_PicSign != "")
                {
                    FileStream myStream = new FileStream(str_PicSign, FileMode.Open, FileAccess.Read);
                    PicSign = new byte[myStream.Length];
                    myStream.Read(PicSign, 0, (int)myStream.Length);
                    myStream.Close();
                    mailclass.Update_MailSign(Mail_Num, PicSign);
                }

                mailclass.Update_Mail(Mail_Num, Mail_Date, Mail_Topic, Mail_Priority, Mail_Security, Mail_Condition, Mail_Text, Mail_SignerName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update_MailColumn(string ColumnName, string OldValue, string NewValue)
        {
            try
            {
                mailclass.Update_MailColumn(ColumnName, OldValue, NewValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }





    }
}
