﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TicketsLostPastDue
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Cust_SilcoEntities : DbContext
    {
        public Cust_SilcoEntities()
            : base("name=Cust_SilcoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<GetADGroups_Result> GetADGroups(Nullable<int> pappid)
        {
            var pappidParameter = pappid.HasValue ?
                new ObjectParameter("pappid", pappid) :
                new ObjectParameter("pappid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetADGroups_Result>("GetADGroups", pappidParameter);
        }
    
        public virtual ObjectResult<FindSecurityPastDue_Result> FindSecurityPastDue(Nullable<int> appid, string title, string dept, string account)
        {
            var appidParameter = appid.HasValue ?
                new ObjectParameter("appid", appid) :
                new ObjectParameter("appid", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var deptParameter = dept != null ?
                new ObjectParameter("dept", dept) :
                new ObjectParameter("dept", typeof(string));
    
            var accountParameter = account != null ?
                new ObjectParameter("account", account) :
                new ObjectParameter("account", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<FindSecurityPastDue_Result>("FindSecurityPastDue", appidParameter, titleParameter, deptParameter, accountParameter);
        }
    }
}
