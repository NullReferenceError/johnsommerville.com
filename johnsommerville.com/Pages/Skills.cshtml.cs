using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace johnsommerville.com.Pages
{
    public class SkillsModel : PageModel
    {
        //TODO:  Move into DB
        public List<IndividualSkill> SkillsList = new List<IndividualSkill>
        {
            new IndividualSkill(".NET Framework", SkillLevel.Expert),
            new IndividualSkill(".NET Core", SkillLevel.Expert),
            new IndividualSkill("Docker", SkillLevel.Novice)

        };

        public void OnGet()
        {
        }
    }

    public class IndividualSkill
    {
        public IndividualSkill(string skillName, SkillLevel proficiency)
        {
            SkillName = skillName;
            Proficiency = proficiency;
        }
        public string SkillName { get; set; }
        public SkillLevel Proficiency { get; set; }
    }

    public enum SkillLevel
    {
        None,
        FundamentalAwareness,
        Novice,
        Intermediate,
        Advanced,
        Expert
    }
}