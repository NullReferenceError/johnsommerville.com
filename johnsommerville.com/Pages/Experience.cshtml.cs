using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace johnsommerville.com.Pages
{
    public class ExperienceModel : PageModel
    {
        public List<Employer> Employers = new List<Employer>()
        {
            new Employer("Senior Applications Developer","Texas Woman's University", "Denton, Texas", DateTime.Parse("05/01/2016"),null, 
                new List<string>()
                {
                    "Manage web applications, web apis, and custom workflow solutions for University Departments that align with the University’s Strategic Plan throughout the entire Software Development Lifecycle",
                    "Integrate 3rd party software solutions with the Universities information and student systems",
                    "Server Administrator for applications servers, processing servers, and web servers for custom applications and 3rd party solutions",
                    "Team Foundation Server administrator and DevOps subject matter expert for source code maintenance and Continuous Integration/Continuous Deployment (CI/CD) implementations and configuration",
                    "Create and maintain testing plans and application documentation for internal and external users in a centralized knowledge base"
                },
                new List<string>()
                {
                    "Consolidated several SIS, EIS and directory systems to specific identity web api endpoints and microservices to assist Web Developers with system integrations",
                    "Migrated hundreds of legacy projects and source code from Visual source safe to Git repositories",
                    "Establish best practices for CI/CD implementations with development teams",
                    "Modernize legacy applications from outdated code bases (classic ASP, VB6) to .NET Core and .NET Frameworks",
                    "Create applications with meaningful user experiences using HTML5, Javascript, and client user libraries",
                    "Participate in working groups to improve the organizations needs, including ITSM system implementation working group and change management working group"
                }
                ),
            new Employer("Software Application Developer","Brierley and Partners", "Plano, Texas", DateTime.Parse("08/01/2013"), DateTime.Parse("05/01/2016"), 
                new List<string>()
                {
                    "Provide client development, data modeling, integration and support for clients utilizing the LoyaltyWare framework",
                    "Participate in Agile Methodologies with teams to achieve goals through an entire software development life cycle",
                    "Implement Jenkins as a Continuous Integration utility for migrating code to upper environments",
                    "Create testing plan procedures and technical documentation for supported code"
                },
                new List<string>()
                {
                    "Maintained the Hertz Rewards Program with junior developers",
                    "Designed and Implemented the American Family Insurance Loyalty program with implementation team",
                    "Designed and Implemented the Kelloggs program with implementation team"
                }),
             new Employer("Solutions Engineer","LG Networks, Inc.", "Dallas, Texas", DateTime.Parse("01/01/2013"), DateTime.Parse("08/01/2013"),
                new List<string>()
                {
                    "Act as Windows System Administrator for over 30 small business customers across the DFW metroplex",
                    "Implement, manage, and upgrade Active Directory Domain Controllers, Microsoft Exchange servers, and other various servers per the clients requirements",
                    "Develop and implement custom solutions and scripts for client needs",
                    "Maintained Level 1 and Level 2 help desk support, as well as 24/7 rotating call schedule"
                },
                new List<string>()
                {
                }),
             new Employer("IT Manager and Windows System Administrator","Office Clinic of Dr. John G. McHenry Neuro-Ophthalmology", "Dallas, Texas", DateTime.Parse("05/01/2012"), DateTime.Parse("10/01/2012"),
                new List<string>()
                {
                    "Act as Windows System Administrator for 5 Windows 2008 servers and several SQL databases",
                    "Provide all levels of Technical Support for 60 workstations and users",
                    "Troubleshoot and develop solutions for different types of eye field examination devices"
                },
                new List<string>()
                {
                }),
              new Employer("Operational Support Technician","University of North Texas Libraries", "Denton, Texas", DateTime.Parse("09/01/2010"), DateTime.Parse("05/01/2012"),
                new List<string>()
                {
                    "Managed Windows and Mac OS X systems with software distribution platforms and server management systems",
                    "Provided scripting and development support for network administrators, help desk supervisors, and programmers",
                    "Assist Library patrons and staff with computer technical support, hardware support, and software support"
                },
                new List<string>()
                {
                }),
              new Employer("Co-op/Intern","L-3 Communications, Link Simulation and Training", "Arlington, Texas", DateTime.Parse("07/01/2008"), DateTime.Parse("02/01/2010"),
                new List<string>()
                {
                    "Provide support for program, software, and system engineers",
                    "Pull flight analytics and statistical information for engineers",
                    "Assist engineers with developing flight simulators for Royal Danish Air Force, The Hellenic Air Force (Greece), American Air Force, and the American Navy",
                    "Acquire and maintained a DOD Secret Clearance throughout internship"
                },
                new List<string>()
                {
                }),

        };
        
        public void OnGet()
        {

        }
    }


    //TODO:  Move into DB
    //TODO:  Related Skills accordion?
    //TODO:  Some way to generate location from google maps?
    public class Employer
    {
        public Employer(string jobTitle, string empName, string location, DateTime startDate, DateTime? endDate, List<string> responsibilities, List<string> accomplishments)
        {
            JobTitle = jobTitle;
            EmployerName = empName;
            Location = location;
            StartDate = startDate;
            EndDate = endDate;
            Responsibilities = responsibilities;
            Accomplishments = accomplishments;

        }

        public string Location { get; set; }
        public string JobTitle { get; set; }
        public string EmployerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Responsibilities { get; set; }
        public List <string> Accomplishments { get; set; }
    }
}