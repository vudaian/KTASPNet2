using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace OnTapKiemTra2.Models
{
    public partial class Sinhvien
    {
        [Required(ErrorMessage = "Mã sinh viên không để trống")]
        public string Msv { get; set; }
        [Required(ErrorMessage = "Họ tên sinh viên không được để trống")]
        [MinLength(5, ErrorMessage = "Họ tên có tối thiểu 5 ký tự")]
        public string TenSinhVien { get; set; }
        public string Lop { get; set; }
        [Range(1, 10, ErrorMessage = "Điểm chỉ nhập từ 1 đến 10")]
        public double? Diem { get; set; }
    }
}
