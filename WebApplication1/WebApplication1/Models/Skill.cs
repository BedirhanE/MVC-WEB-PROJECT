using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    //Create table and column.
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public int SkillPercent { get; set; }
    }
}