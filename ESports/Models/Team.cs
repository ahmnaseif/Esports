//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESports.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Team
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string ManagerName { get; set; }
        public int TournamentId { get; set; }
        public string Details { get; set; }
    
        public virtual TournamentDetail TournamentDetail { get; set; }
    }
}
