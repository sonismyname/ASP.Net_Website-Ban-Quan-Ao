
//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WebBanQuanAo.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Order
{

    public Order()
    {

        this.OrderDetails = new HashSet<OrderDetail>();

    }


    public int ID { get; set; }

    public Nullable<System.DateTime> NgayTao { get; set; }

    public string TenKH { get; set; }

    public string DienThoai { get; set; }

    public string DiaChi { get; set; }

    public string Email { get; set; }

    public Nullable<bool> TrangThai { get; set; }



    public virtual ICollection<OrderDetail> OrderDetails { get; set; }

}

}
