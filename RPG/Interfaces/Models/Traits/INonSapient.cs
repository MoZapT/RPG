using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Interfaces.Models.Traits
{
    internal interface INonSapient
    {
        public string? Name { get; set; }
        public string? AliasName { get; set; }

    }
}
