using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStart.Models {
    public class User {
        public int ID { get; set; }
        [StringLength(60, MinimumLength = 2, ErrorMessage = "두 글자 이상 입력해 주세요.")]
        [RegularExpression(@"[a-zA-Z가-힣]*$", ErrorMessage = "영어나 한글외에는 입력할 수 없습니다.")]
        [Required(ErrorMessage ="이름을 반드시 입력해야 합니다.")]
        public string name { get; set; }
        [Required]
        public string gender { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "생일을 입력해 주십시오.")]
        public DateTime birthday { get; set; }
    }
}
