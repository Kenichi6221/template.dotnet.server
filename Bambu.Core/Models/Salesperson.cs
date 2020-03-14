using System.Collections.Generic;

namespace Bambu.Core.Models
{
    public class Salesperson : TrackedEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string SalesGroupState { get; set; }
        public int SalesGroupType { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
        public virtual SalesGroup SalesGroup { get; set; }
    }
}