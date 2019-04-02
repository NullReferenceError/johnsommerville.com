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
            new IndividualSkill("Docker", SkillLevel.Intermediate),
            new IndividualSkill("Kubernetes", SkillLevel.Intermediate),
            new IndividualSkill("JavaScript", SkillLevel.Advanced),
            new IndividualSkill("CSS", SkillLevel.Intermediate),
            new IndividualSkill("SQL Database (T-SQL)", SkillLevel.Advanced),
            new IndividualSkill("Oracle Database (PL/SQL)", SkillLevel.Advanced),
            new IndividualSkill("Git", SkillLevel.Expert),
            new IndividualSkill("TFVC", SkillLevel.Expert),
            new IndividualSkill("Powershell", SkillLevel.Expert),
            new IndividualSkill("Java", SkillLevel.Intermediate),
            new IndividualSkill("PHP", SkillLevel.Intermediate),
            new IndividualSkill("Windows Server Administration", SkillLevel.Expert),
            new IndividualSkill("Unix/Linux Server Administration", SkillLevel.Intermediate),
            new IndividualSkill("MVC Design", SkillLevel.Expert),
            new IndividualSkill("Razor Pages", SkillLevel.Advanced),
            new IndividualSkill("bash", SkillLevel.Intermediate),
            new IndividualSkill("C#", SkillLevel.Expert),
            new IndividualSkill("VB", SkillLevel.Expert),
            new IndividualSkill("C", SkillLevel.Intermediate),
            new IndividualSkill("C++", SkillLevel.Intermediate),
            new IndividualSkill("HTML5", SkillLevel.Advanced),
            new IndividualSkill("AWS", SkillLevel.Intermediate),
            new IndividualSkill("Azure", SkillLevel.Intermediate),
            new IndividualSkill("Google Cloud", SkillLevel.Intermediate),
            new IndividualSkill("CI/CD", SkillLevel.Expert),
            new IndividualSkill("Azure DevOps and TFS", SkillLevel.Expert)

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