using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Devxuongmoc.Models;

public partial class Banner
{
    public int Id { get; set; }
    [Display(Name = "Hình ảnh")]
    public string? Image { get; set; }
    [Display(Name = "Tiêu Đề")]
    public string? Title { get; set; }
    [Display(Name = "Ghi chú")]
    public string? SubTitle { get; set; }

    public string? Urls { get; set; }

    public int Orders { get; set; }

    public string? Type { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? AdminCreated { get; set; }

    public string? AdminUpdated { get; set; }
    [Display(Name = "Mô tả")]
    public string? Notes { get; set; }

    public byte Status { get; set; }

    public bool Isdelete { get; set; }
}
