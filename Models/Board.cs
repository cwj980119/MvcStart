using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStart.Models {
    public class Board {
        public int ID { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "2~20 글자만 입력이 가능합니다.")]
        public string title { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "2~20 글자만 입력이 가능합니다.")]
        public string author { get; set; }
        public int click { get; set; } = 0;
        public int like_ { get; set; } = 0;
        public DateTime post_time { get; set; } = DateTime.Now;
        [StringLength(200, MinimumLength = 2, ErrorMessage = "1~200자 사이만 입력이 가능합니다.")]
        public string letter { get; set; }
    }
}
