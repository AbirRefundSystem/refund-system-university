//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RefundSystem_University.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ApplicationApprovalStatu
    {
        public int Id { get; set; }
        public int RefundApplicationId { get; set; }
        public int AuthorizedSignatoryId { get; set; }
        public bool Approved { get; set; }
        public System.DateTime Date { get; set; }
        public string NonApprovalReason { get; set; }
    
        public virtual AuthorizedSignatory AuthorizedSignatory { get; set; }
        public virtual RefundApplication RefundApplication { get; set; }
    }
}
