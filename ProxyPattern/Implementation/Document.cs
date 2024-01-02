using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProxyPattern.Interface;

namespace ProxyPattern.Implementation
{
    public class Document : IDocument
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int AuthorID { get; private set; }
        public DateTimeOffset LastAccessed { get; private set; }
        private string _fileName;

        public Document(string Filename)
        {
            _fileName = Filename;
            LoadDocument(Filename);
        }
        public void LoadDocument(string fileName)
        {
            // Fake Loading
            Thread.Sleep(1000);
            Title = "An Expensive Document ";
            Content = "Lots and Lots of Content";
            AuthorID = 1;
            LastAccessed = DateTimeOffset.UtcNow;

        }

        public string DisplayDocument()
        {
            return $"Title : {Title}, Content :{Content}";
        }
    }
}
