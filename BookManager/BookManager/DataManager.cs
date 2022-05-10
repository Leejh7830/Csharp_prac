using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    public class DataManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        /// <summary>
        /// 객체명
        /// </summary>
        const string BOOK = "book";
        const string USER = "user";

        /// <summary>
        /// List명
        /// </summary>
        const string BOOKS = "books";
        const string USERS = "users";

        /// <summary>
        /// 도서용
        /// </summary>
        const string ISBN = "isbn";
        const string NAME = "name";
        const string PUBLISHER = "publisher";
        const string PAGE = "page";
        const string ISBORROWED = "isBorrowed";
        const string BORROWEDAT = "borrowedAt";
        const string USERID = "userId";
        const string USERNAME = "username";

        /// <summary>
        /// 유저용
        /// </summary>
        const string UNAME = "name";
        const string UID = "id";

        static DataManager()
        {
            // static -> DataManager에 접근하는 순간 바로 호출됨
            // 프로그램 시작하자마자 메모리에 올라감
            Load();
        }

        public static void Load() // xml파일을 읽어들여서 도서관 현황을 보여주는 것
        {
            try
            {

            } catch (Exception ex) // 파일읽기 실패하면 save
            {
                Save();
                Load();
            }
        }

        public static void Save()
        {
            string booksOutput = string.Empty; // ""이랑 같음

            booksOutput += $"<{BOOKS}>\n"; // <books>
            foreach(var item in Books)
            {
                booksOutput += $"\t<{BOOK}>\n";
                booksOutput += $"\t\t<{ISBN}>{item.Isbn}</{ISBN}>\n";
                booksOutput += $"\t\t<{NAME}>{item.Name}</{NAME}>\n";
                booksOutput += $"\t\t<{PUBLISHER}>{item.Publisher}</{PUBLISHER}>\n";
                booksOutput += $"\t\t<{PAGE}>{item.Page}</{PAGE}>\n";
                booksOutput += $"\t\t<{BORROWEDAT}>{item.BorrowedAt}</{BORROWEDAT}>\n";
                booksOutput += $"\t\t<{ISBORROWED}>" + (item.isBorrowed ? 1 : 0) +$"</{ISBORROWED}>\n";
                booksOutput += $"\t\t<{USERID}>{item.UserId}</{USERID}>\n";
                booksOutput += $"\t\t<{USERNAME}>{item.UserName}</{USERNAME}>\n";
                booksOutput += $"\t</{BOOK}>\n";
            }
            booksOutput += $"</{BOOKS}>\n"; // <books>
            Console.WriteLine(booksOutput);
            File.WriteAllText($"./{BOOKS}.xml", booksOutput);

            string usersOutput = string.Empty;
            usersOutput += $"<{USERS}>\n";
            foreach(var item in Users)
            {
                usersOutput += $"\t<{USER}>\n";
                usersOutput += $"\t\t<{UID}>{item.Id}</{UID}>\n";
                usersOutput += $"\t\t<{UNAME}>{item.Name}</{UNAME}>\n";
                usersOutput += $"\t</{USER}>\n";
            }
            usersOutput += $"</{USERS}>\n";
            Console.WriteLine(usersOutput);
            File.WriteAllText($"./{USERS}.xml", usersOutput);


            // throw new NotImplementedException();
        }

    }
}
