using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class Book
    {
        public string Isbn { get; set; } // PK
        public string Name { get; set; } // 책이름
        public string Publisher { get; set; } // 출판사
        public int Page { get; set; } // 책페이지수
        public int UserId { get; set; } // FK 대여자ID
        public string UserName { get; set; } // 대여자이름
        public bool isBorrowed  { get; set; } // 대여여부
        public DateTime BorrowedAt { get; set; } // 언제빌렸는지

    }
}
