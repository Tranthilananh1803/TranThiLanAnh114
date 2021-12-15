using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TranThiLanAnh114.Models
{
    [Table ("Universitys")]
    public class UniversityTTLA114
    {
        [Key]
        [Display(Name = "Mã trường đại học")]
        [StringLength(20)]
        public string UniversityID { get; set; }
        [Display(Name = "Tên trường đại học")]
        [StringLength(50)]
        public string UniversityName {get; set;}

    }
}