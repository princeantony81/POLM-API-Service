using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using POLM_API_Service.Models;

namespace POLM_API_Service.Controllers
{
    public class ProjectController : ApiController
    {
        public List<ProjectModels> Getproject()
        {
              List<ProjectModels> _projects = new List<ProjectModels>();
            _projects.Add(new ProjectModels {  ID = 1,  ProjectName = "CA18-100069",  ReportingProjectID = "FGL GTE" });
            _projects.Add(new ProjectModels { ID = 2, ProjectName = "PR21-100001", ReportingProjectID = "OAP Puerto Rico" });
            _projects.Add(new ProjectModels { ID = 3, ProjectName = "US20-103455", ReportingProjectID = "Florida Crystal" });
            _projects.Add(new ProjectModels { ID = 4, ProjectName = "US20-103486", ReportingProjectID = "Macy's OH" });
            _projects.Add(new ProjectModels { ID = 5, ProjectName = "US21-103857", ReportingProjectID = "Ingram JDC PNA Upgrade" });
            _projects.Add(new ProjectModels { ID = 6, ProjectName = "US21-103862", ReportingProjectID = "Milwaukee Tool" });
            _projects.Add(new ProjectModels { ID = 7, ProjectName = "US21-103879", ReportingProjectID = "Tapestry West Coast" });
            _projects.Add(new ProjectModels { ID = 8, ProjectName = "US21-103880", ReportingProjectID = "Ryder Integrated Logistics" });
            _projects.Add(new ProjectModels { ID = 9, ProjectName = "US21-103896", ReportingProjectID = "Ryder BBBY" });
            _projects.Add(new ProjectModels { ID = 10, ProjectName = "US21-103903", ReportingProjectID = "Macy's WV" });
            _projects.Add(new ProjectModels { ID = 11, ProjectName = "US21-103932", ReportingProjectID = "WebstaurantStore KY" });
            return _projects;
        }
    }
}
