﻿
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;


//namespace TeamBins.DataAccess
//{
//    public interface IRepositary : IDisposable  
//    {
//        void SaveDefaultTeam(int userId, int teamId);


//        IEnumerable<TeamMemberRequest> GetTeamMembersWhoHasntJoined(int teamId);
//        IEnumerable<User> GetNonTeamMemberUsers(int teamId, string searchKey);
//        IQueryable<TeamMember> GetTeamMembers(int teamId);
//        IQueryable<User> GetUsers();
//        void DeleteComment(int commentId);
//       // IEnumerable<User> GetSubscribers(int teamId, string notificationtypeCode);
//        IEnumerable<NotificationType> GetNotificationTypes();
//        void SaveUserNotificationSubscription(UserNotificationSubscription subscription);

//        void SavePasswordResetRequest(PasswordResetRequest request);
//        PasswordResetRequest GetPasswordResetRequest(string activationCode);
//        bool DeleteProject(int projectId);
//        Document GetDocument(string documentKey);
//        List<Document> GetDocuments(int parentId);       
       
//        IEnumerable<Project> GetProjects(int teamId);
//        Project GetProject(int projectId);
//        Project GetProject(int projectId, int createdById);
//        Project GetProject(string name, int createdById);
//        List<Priority> GetPriorities();
//        List<Status> GetStatuses();
//        List<Category> GetCategories();    
//        OperationStatus SaveIssue(Issue bug);
//        OperationStatus SaveDocument(Document image);
//        Project SaveProject(Project project);       
//        OperationStatus SaveUser(User user);
//        User GetUser(string emailAddress);
//        User GetUser(int userId);
//        IEnumerable<Team> GetTeams(int userId);
//        Team GetTeam(int teamId);
//        Team SaveTeam(Team team);       
//        TeamMember SaveTeamMember(TeamMember teamMember);
//        IEnumerable<Issue> GetIssues();
//        IEnumerable<Issue> GetIssues(int teamId);
//        Issue GetIssue(int issueId);
//        IEnumerable<Comment> GetCommentsForIssue(int issueId);
//        OperationStatus SaveComment(Comment comment);
//        Comment GetComment(int commentId);
//        OperationStatus DeleteIssue(int issueId);
//        List<IssueMember> GetIssueMembers(int issueId);
//        //List<User> GetNonIssueMembers(int teamId, int issueId);
//      //  OperationStatus SaveIssueMember(int issueId, int memberId, int addedBy);
//        OperationStatus SaveIssueMemberRelation(IssueMember issueMember);
//        OperationStatus DeleteIssueMember(int issueId, int memberId);
//        OperationStatus SaveTeamMemberRequest(TeamMemberRequest teamMemberRequest);
//        TeamMemberRequest GetTeamMemberRequest(string activationCode);
//        TeamMember GetTeamMember(int userId, int teamId);
//        EmailTemplate GetEmailTemplate(string templateName);

//        Activity GetActivity(int id); 
//        IEnumerable<Activity> GetTeamActivity(int teamId);
//        OperationStatus SaveActivity(Activity comment);
//        OperationStatus DeleteIssueMemberRelation(IssueMember issueMember);
//    }
//}
