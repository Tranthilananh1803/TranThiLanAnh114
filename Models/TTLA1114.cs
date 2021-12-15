using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TranThiLanAnh114.Models
{
    [Table ("TTLA1114s")]
    public class TTLA1114
    {
        [Key]
        [Display(Name = "Mã sinh viên")]
        [StringLength(20)]
        public string TTLAId { get; set; }
        [Display(Name = "Tên sinh viên ")]
        [StringLength(50)]
        public string TTLAName {get; set;}

       [Display(Name = "Giới tính nữ ")]
        [Required]
        public bool TTLAGener {get; set;}
    }
}