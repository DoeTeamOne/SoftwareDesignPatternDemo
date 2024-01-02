using CompositePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Implementation
{
    public  class Directory:FileSystemItem
    {
        private long _size;
        private List<FileSystemItem> _filesystemitems = new List<FileSystemItem>();
        public Directory(string name, long size):base(name) 
        { 
            _size = size;
        }

        
        public void Add(FileSystemItem item)
        {
            _filesystemitems.Add(item);
        }
        public void Remove(FileSystemItem item) 
        {
        _filesystemitems.Remove(item);
        }

        public override long GetSize()
        {
            var treeSize = _size;
            foreach (var item in _filesystemitems)
            {
                treeSize += item.GetSize(); // this is cool Recursive Call 
            }
            return treeSize;
        }
    }
}
