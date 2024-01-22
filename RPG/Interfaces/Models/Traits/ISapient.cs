using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.Traits
{
    internal interface ISapient
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PatronymName { get; set; }
        public string? AliasName { get; set; }

        //
        public string? Culture { get; set; }
        public string? Religion { get; set; }
    }
}
