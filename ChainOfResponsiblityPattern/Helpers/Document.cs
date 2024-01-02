using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblityPattern.Helpers
{
    public  class Document
    {
        public string Title { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public bool ApprovedByLitigation { get; set; }
        public bool ApprovedbyManagment { get; set; }
        public Document(string title, DateTimeOffset lastmodified,bool approvedByLitigation, bool approvedbyManagment)
        {
            Title = title;
            LastModified = lastmodified;
             ApprovedByLitigation = approvedByLitigation;
            ApprovedbyManagment = approvedbyManagment;
        }
    }
}
