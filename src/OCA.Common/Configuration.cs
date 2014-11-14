using System;
using System.Collections.Generic;
using System.Text;

namespace OCA.Common
{
    public class Configuration
    {
        private string ConnectionString = "";

        public Configuration()
        {
            DataSets.Public dspub = new DataSets.Public();
            dspub.ReadXml("Configuration.config");
            dspub.AcceptChanges();
            ConnectionString = dspub.Connection[0].ConnectionString;
        }

        public string Connection_String
        {
            get
            {
                return ConnectionString;
            }
        }




    }
}
