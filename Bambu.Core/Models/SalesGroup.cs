using System.Collections.Generic;

namespace Bambu.Core.Models
{
    public class SalesGroup : TrackedEntity
    {
        public string State { get; set; }
        public int Type { get; set; }

        public virtual ICollection<Salesperson> Salespeople { get; set; }
    }
}