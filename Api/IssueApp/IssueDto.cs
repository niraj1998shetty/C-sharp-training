using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueApp
{
    internal class IssueDto
    {
        public int Id { get; set; }
       
        public string Title { get; set; }
       
        public string Description { get; set; }

        public Priority Priority { get; set; }

        public IsuueType isuueType { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? Completed { get; set; }
    }
    public enum Priority
    {
        Low, Medium, high
    }

    public enum IsuueType
    {
        feature, bug, Documentation
    }

}
