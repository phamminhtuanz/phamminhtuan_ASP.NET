using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Devxuongmoc.Models;

public partial class Category
{
    public int Id { get; set; }
    [Display(Name = "Tiêu Đề")]
    public string? Title { get; set; }

    [Display(Name = "Hình Ảnh")]
    public string? Icon { get; set; }
    

    public string? MateTitle { get; set; }

    public string? MetaKeyword { get; set; }

    [Display(Name = "Mô Tả")]
    public string? MetaDescription { get; set; }

    public string? Slug { get; set; }

    [Display(Name = "Đơn ĐH")]
    public int? Orders { get; set; }

    public int? Parentid { get; set; }

    [Display(Name = "NSX")]
    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AdminCreated { get; set; }

    public string? AdminUpdated { get; set; }

    public string? Notes { get; set; }

    public byte? Status { get; set; }

    [Display(Name = "Tình Trạng")]
    public bool? Isdelete { get; set; }
}
