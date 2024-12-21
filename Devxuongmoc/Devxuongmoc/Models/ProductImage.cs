using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Devxuongmoc.Models;

public partial class ProductImage
{
    public int Id { get; set; }
    [Display(Name = "Mã ảnh")]

    public int? Pid { get; set; }
    [Display(Name = "Hình ảnh")]
    public string? Image { get; set; }
}
