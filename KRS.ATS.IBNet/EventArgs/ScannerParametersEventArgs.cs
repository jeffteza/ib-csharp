using System;
using System.Collections.Generic;
using System.Text;

namespace Krs.Ats.IBNet
{
    /// <summary>
    /// Scanner Parameters Event Arguments
    /// </summary>
    public class ScannerParametersEventArgs : EventArgs
    {
        private readonly string xml;
        /// <summary>
        /// Document describing available scanner subscription parameters.
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
        /// <param name="xml">Document describing available scanner subscription parameters.</param>
        public ScannerParametersEventArgs(string xml)
        {
            this.xml = xml;
        }
    }
}
