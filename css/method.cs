using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Specialized;
using System.Web;

namespace DevopsAssignment.css{
    public static class method{
        public static Value QueryString(this NavigationManger manage)
        {
            return HttpUtility.ParseQueryString(new Uri(NavigationManager.Uri).Query);

        }
        public static string QueryString(this NavigationManager navigationManager,string me)
        {
            return navigationManager.QueryString()[me];
        }
}