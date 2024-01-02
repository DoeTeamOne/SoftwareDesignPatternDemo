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
    /// Concerete Hundler for ApprovedbyLitigation
    /// </summary>
    public class DocumentApprovedByLitigationHandler: IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document document)
        {
            // Validate here 
            if (!document.ApprovedByLitigation)
            {
                throw new ValidationException(
                    new ValidationResult("Document must be approved by litigation ", new List<string>() { "Approved By Litigation" }), null, null);
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
