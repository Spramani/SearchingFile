//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace searching_data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class education
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public string college_name { get; set; }
        public string college_join_date { get; set; }
        public string address_of_college { get; set; }
        public string secondary_school { get; set; }
        public string school_join_date { get; set; }
        public string address_of_school { get; set; }
        public System.DateTime create_date { get; set; }
    }
}
