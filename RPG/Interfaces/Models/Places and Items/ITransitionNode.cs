using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Interfaces.Models.Common;
using RPG.Interfaces.Models.Traits;

namespace RPG.Interfaces.Models
{
    internal interface ITransitionNode : ICreation, ILockable
    {
        public bool IsTransparent { get; set; }
        public bool IsPeekable { get; set; }
        public bool IsTeleport { get; set; }
        public ILocation Location { get; set; }
    }
}
