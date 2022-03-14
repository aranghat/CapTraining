using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameShared
{
    public class GameAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public GameAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
