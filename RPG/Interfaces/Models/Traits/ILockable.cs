using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.Traits
{
    internal interface ILockable
    {
        public bool IsEnchantedLock { get; set; }
        public bool IsClosed { get; set; }
        public int LockStrength { get; set; }
    }
}
