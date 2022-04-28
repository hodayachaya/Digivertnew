using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTOusers
    {
        public int iduser { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DTOusers()
        {

        }

        public DTOusers(user u)
        {
            iduser = u.iduser;
            firstName = u.firstName;
            lastName = u.lastName;

            email = u.email;
            password = u.password;

        }
        public static List<DTOusers> CreateUserDtoList(List<user> userList)
        {
            List<DTOusers> dtoUserList = new List<DTOusers>();
            foreach (var u in userList)
            {
                DTOusers dtoUser = new DTOusers(u);
                dtoUserList.Add(dtoUser);
            }
            return dtoUserList;
        }
        public user UserToTable()
        {
            user u = new user();
            u.iduser = iduser;
            u.email = email;
            u.firstName = firstName;
            u.lastName = lastName;
            u.password = password;
     
            return u;
        }

    }
}

