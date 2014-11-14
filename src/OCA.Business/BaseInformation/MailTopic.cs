using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Business.BaseInformation
{
    public class MailTopic
    {
        OCA.Common.DataSets.BaseInformation.MailTopic dsmTopic = new OCA.Common.DataSets.BaseInformation.MailTopic();
        OCA.DataAccess.BaseInformation.MailTopic mTopicclass = new OCA.DataAccess.BaseInformation.MailTopic();

        public OCA.Common.DataSets.BaseInformation.MailTopic GetMailTopics()
        {
            try
            {
                dsmTopic.Clear();
                dsmTopic = mTopicclass.GetMailTopics();
                return dsmTopic;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InsertMailTopic(string TopicName)
        {
            try
            {
                mTopicclass.InsertMailTopic(TopicName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoveMailTopic(string TopicName)
        {
            try
            {
                mTopicclass.RemoveMailTopic(TopicName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void EditMailTopic(string TopicName, string newTopicName)
        {
            try
            {
                mTopicclass.EditMailTopic(TopicName, newTopicName);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
