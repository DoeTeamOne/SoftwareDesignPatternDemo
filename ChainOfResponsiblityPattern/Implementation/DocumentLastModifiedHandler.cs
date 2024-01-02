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
    /// Concerete Hundler for DocumentLastModified
    /// </summary>
    public class DocumentLastModifiedHandler:IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document document)
        {
            // Validate here 
            if (document.LastModified <DateTime.UtcNow.AddDays(-30))
            {
                throw new ValidationException(
                    new ValidationResult("Document must be modified in last 30 days ", new List<string>() { "LastModified" }), null, null);
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
