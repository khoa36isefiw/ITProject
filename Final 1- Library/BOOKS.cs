//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Final_1__Library
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOOKS
    {
        public BOOKS()
        {
            this.HISTORY = new HashSet<HISTORY>();
            this.Return_book = new HashSet<Return_book>();
        }
    
        public int ID_Book { get; set; }
        public string Name { get; set; }
        public Nullable<int> ID_publisher { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Update_day { get; set; }
        public int N_books { get; set; }
        public Nullable<int> price { get; set; }
    
        public virtual PUBLISHER PUBLISHER { get; set; }
        public virtual ICollection<HISTORY> HISTORY { get; set; }
        public virtual ICollection<Return_book> Return_book { get; set; }
    }
}
