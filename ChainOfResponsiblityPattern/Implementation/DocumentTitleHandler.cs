using ChainOfResponsiblityPattern.Abstruction;
using ChainOfResponsiblityPattern.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsiblityPattern.Implementation
{
    /// <summary>
    /// concerete Handler
    /// </summary>
    public class DocumentTitleHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document document)
        {
            // Validate here 
            if(document.Title == string.Empty)
            {
                throw new ValidationException(
                    new ValidationResult("Title  must be filled out",new List<string>() { "Title" }),null,null);
            }
            // go to the next  Handle here
            _successor.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
           _successor = successor;
            return successor;
        }
    }
}
