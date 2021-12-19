using DevopsAssignment.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Net;

namespace DevopsAssignment.css{
    public class DevopsRouteView : RouteView
    {
        [Inject]
        public IAccountService AccountService{
            get;set;
        }
        [Inject]
        public NavigationManager NavigationManager{
             get;set;
             }
        protected override void Render(RenderTreeBuilder builder)
        {
            var authority = Attribute.GetCustomAttribute(RouteData.PageType,typeof(AuthorizeAttribute)) !=null;
           if (authority && AccountService.User == null)
            {
                var url = WebUtility.UrlEncode(new Uri(NavigationManager.Uri).PathAndQuery);
            }
            else{
            base.Render(builder);
            }
        }
    }
}