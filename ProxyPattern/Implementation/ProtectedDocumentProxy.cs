using ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Implementation
{
    public class ProtectedDocumentProxy : IDocument
    {
        private string _filename;
        private string _userRole;
        DocumentProxy _documentProxy;

        public ProtectedDocumentProxy(string filename,string userRole) 
        {
            _filename = filename;
            _userRole = userRole;
            _documentProxy = new DocumentProxy(_filename);
        }

      

        public string DisplayDocument()
        {
           if(_userRole != "Viewer")
            {
                throw new UnauthorizedAccessException();
            }
          return  _documentProxy.DisplayDocument();
        }
    }
}
