﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechiesWeb.TeamBins.ViewModels;

namespace SmartPlan.ViewModels
{
    public class DashBoardVM
    {
        public IList<TeamVM> Teams { set; get; }
        public List<ProjectVM> Projects { set; get; }
        public List<IssueVM> RecentIssues { set; get; }
        public List<IssueVM> IssuesAssignedToMe { set; get; }
        public DashBoardVM()
        {
            Teams = new List<TeamVM>();
            Projects = new List<ProjectVM>();
            RecentIssues = new List<IssueVM>();
            IssuesAssignedToMe = new List<IssueVM>();
        }
    }
    
    
}