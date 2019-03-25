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
            new Employer("Senior Applications Developer","Texas Woman's University", "Denton, Texas", DateTime.Parse("05/01/2016"),null, new List<string>() { "Resp1", "Resp2" }),
            new Employer("Software Application Developer","Brierley and Partners", "Plano, Texas", DateTime.Parse("08/01/2013"), DateTime.Parse("05/01/2016"), 
                new List<string>()
                {
                    "Provide client development, data modeling, integration and support",
                    "Participate in Agile Methodologies with teams to achieve goals through an entire software development life cycle",
                    "Utilize PetaPoco and NHibernate as ODBC connectors for Application to Database communication",
                    "Implement Jenkins as a Continuous Integration utility for migrating code to upper environments",
                    "Create testing plan procedures and technical documentation for supported code"
            }),
             new Employer("Solutions Engineer","LG Networks, Inc.", "Dallas, Texas", DateTime.Parse("01/01/2013"), DateTime.Parse("08/01/2013"),
                new List<string>()
                {
                    "Created, managed, and upgraded Active Directory Domain Controllers, Microsoft Exchange servers,  and other various servers for over 30 small business clients in the DFW metroplex",
                    "Participate in Agile Methodologies with teams to achieve goals through an entire software development life cycle",
                    "Program solutions for client issues, including VB.NET, C#, or scripts to produce programs that manipulated data or files for small business flow",
                    "Maintained Level 1 and Level 2 help desk support, as well as 24/7 rotating call schedule"
                }),
             new Employer("IT Manager and Windows System Administrator","Office Clinic of Dr. John G. McHenry Neuro-Ophthalmology", "Dallas, Texas", DateTime.Parse("05/01/2012"), DateTime.Parse("10/01/2012"),
                new List<string>()
                {
                    "Manage 5 Windows 2008 servers, several SQL databases, around 60 workstations and users",
                    "Troubleshoot and develop solutions for different types of eye field examination devices"
                }),
              new Employer("Operational Support Technician","University of North Texas Libraries", "Denton, Texas", DateTime.Parse("09/01/2010"), DateTime.Parse("05/01/2012"),
                new List<string>()
                {
                    "Managed Windows and Mac OS X systems with software distribution platforms and server management systems",
                    "Provided support for network administrators, help desk supervisors, and programmers",
                    "Assisted Library patrons and staff with computer technical support, hardware support, and software support"
                }),
              new Employer("Co-op/Intern","L-3 Communications, Link Simulation and Training", "Arlington, Texas", DateTime.Parse("07/01/2008"), DateTime.Parse("02/01/2010"),
                new List<string>()
                {
                    "Provided support for program, software, and system engineers",
                    "Worked in developing flight simulators for Royal Danish Air Force, The Hellenic Air Force (Greece), American Air Force, and the American Navy",
                    "Acquired and maintained a DOD Secret Clearance throughout internship"
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
        public Employer(string jobTitle, string empName, string location, DateTime startDate, DateTime? endDate, List<string> responsibilities)
        {
            JobTitle = jobTitle;
            EmployerName = empName;
            Location = location;
            StartDate = startDate;
            EndDate = endDate;
            Responsibilities = responsibilities;
        }

        public string Location { get; set; }
        public string JobTitle { get; set; }
        public string EmployerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public List<string> Responsibilities { get; set; }
    }
}