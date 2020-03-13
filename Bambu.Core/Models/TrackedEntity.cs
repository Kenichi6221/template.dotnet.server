using System;

namespace Bambu.Core.Models
{
    public class TrackedEntity : Entity
    {
        public bool Deleted { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}