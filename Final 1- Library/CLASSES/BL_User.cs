using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Final_1__Library.CLASSES
{
    internal class BL_User
    {
        public DataTable LayNguoiDung()
        {
            library1010Entities2 qltvEntity = new library1010Entities2();
            var tps =
            from p in qltvEntity.USERS
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("UserName");
            dt.Columns.Add("PassWord");
            foreach (var p in tps)
            {
                dt.Rows.Add(p.UserName, p.PassWord);
            }
            return dt;
        }
        public DataTable CheckUser (string username,string email)
        {
            DataTable dt = new DataTable();
            library1010Entities2 qltvEntity = new library1010Entities2();
            var tps = (from p in qltvEntity.USERS
                       where p.UserName == username && p.Email == email
                       select p);
            dt.Columns.Add("UserName");
            dt.Columns.Add("PassWord");
            dt.Columns.Add("Email");
          
            foreach (var p in tps)
            {
                dt.Rows.Add(p.UserName, p.PassWord,p.Email);
            }
            return dt;

        }
        public DataTable CheckUserName(string username)
        {
            DataTable dt = new DataTable();
            library1010Entities2 qltvEntity = new library1010Entities2();
            var tps = (from p in qltvEntity.USERS
                       where p.UserName == username 
                       select p);
            dt.Columns.Add("UserName");
            dt.Columns.Add("PassWord");
            dt.Columns.Add("Email");

            foreach (var p in tps)
            {
                dt.Rows.Add(p.UserName, p.PassWord, p.Email);
            }
            return dt;

        }

        public bool EditUser(string username,string password)
        {
            library1010Entities2 qltvEntity = new library1010Entities2();
            var tpQuery = (from p in qltvEntity.USERS
                           where p.UserName == username
                           select p).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.PassWord = password;
              
                qltvEntity.SaveChanges();
            }
            return true;

        }
        public bool AddUser(string username, string password,string email)
        {
            library1010Entities2 qltvEntity = new library1010Entities2();
            
            USER user = new USER();
            user.UserName = username;
            user.PassWord = password;
            user.Email = email;
            qltvEntity.USERS.Add(user);
            qltvEntity.SaveChanges();

            return true;

        }
        public bool CompareUser(string username, string password)
        {
            library1010Entities2 qltvEntity = new library1010Entities2();
            var tps =
            from p in qltvEntity.USERS
            select p;
            int i = 0;
            foreach (var p in tps)
            {
                if (username.Equals(p.UserName))
                {
                    if (password.Equals(p.PassWord))
                    {
                       i++;
                    }
                }
            }
            if (i == 0)
            {
                return false;
            }
            else return true;
            
        }
    }   
    
}
