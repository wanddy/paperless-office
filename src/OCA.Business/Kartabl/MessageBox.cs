using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.Kartabl
{
    public class MessageBox
    {
        OCA.DataAccess.Kartabl.MessageBox messageclass = new OCA.DataAccess.Kartabl.MessageBox();
        OCA.Common.DataSets.Kartabl.MessageBox dsmessage = new OCA.Common.DataSets.Kartabl.MessageBox();


        public void InsertMessage(string Message_Date, string Message_Name, string Owner_User, string Sender_User, string Sender_Name, string Receiver_User, string Receiver_Name, string Message_Text)
        {
            try
            {
                messageclass.InsertMessage(Message_Date, Message_Name, Owner_User, Sender_User, Sender_Name, Receiver_User, Receiver_Name, Message_Text);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MessageBox GetReceivedMessages(string Username)
        {
            try
            {
                dsmessage.Clear();
                dsmessage = messageclass.GetReceivedMessages(Username);
                return dsmessage;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public OCA.Common.DataSets.Kartabl.MessageBox GetSendedMessages(string Username)
        {
            try
            {
                dsmessage.Clear();
                dsmessage = messageclass.GetSendedMessages(Username);
                return dsmessage;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveMessage(string Message_Num)
        {
            try
            {
                messageclass.RemoveMessage(Message_Num);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update_MessageColumn(string ColumnName, string OldValue, string NewValue)
        {
            try
            {
                messageclass.Update_MessageColumn(ColumnName, OldValue, NewValue);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



    }
}
