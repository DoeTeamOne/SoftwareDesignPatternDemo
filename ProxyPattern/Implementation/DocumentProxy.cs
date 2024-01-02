using ProxyPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern.Implementation
{
    public class DocumentProxy : IDocument
    {
        private Lazy<Document> _document;
        public string _fileName;
        public DocumentProxy(string fileName) 
        {
        _fileName = fileName;
            _document = new Lazy<Document>(()=>new Document(fileName));
            // when we use lazy  the document is sinstantiated but not constructed . it will be constructed wen it is needed
        }
        public string DisplayDocument()
        {
            return _document.Value.DisplayDocument();
        }

        
    }
}
