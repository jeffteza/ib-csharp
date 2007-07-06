using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Receive Financial Advisor Event Arguments
    /// </summary>
    public class ReceiveFAEventArgs : EventArgs
    {
        private readonly FADataType faDataType;
        /// <summary>
        /// Specifies the type of Financial Advisor configuration data being received from TWS.
        /// </summary>
        /// <remarks>Valid values include:
        /// 1 = GROUPS
        /// 2 = PROFILE
        /// 3 = ACCOUNT ALIASES
        /// </remarks>
        public FADataType FADataType
        {
            get
            {
                return faDataType;
            }
        }

        private readonly string xml;
        /// <summary>
        /// The XML string containing the previously requested FA configuration information.
        /// </summary>
        public string Xml
        {
            get
            {
                return xml;
            }
        }

        /// <summary>
        /// Full Constructor
        /// </summary>
        /// <param name="faDataType">Specifies the type of Financial Advisor configuration data being received from TWS.</param>
        /// <param name="xml">The XML string containing the previously requested FA configuration information.</param>
        public ReceiveFAEventArgs(FADataType faDataType, string xml)
        {
            this.faDataType = faDataType;
            this.xml = xml;
        }
    }
}
