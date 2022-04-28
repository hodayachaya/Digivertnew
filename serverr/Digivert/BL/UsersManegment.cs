using BL.Models;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UsersManegment
    {
        static DBConection db = new DBConection();
        public static DTOusers LoginUser(string name, int password)
        {
            user userFromTable = db.GetDbSet<user>().FirstOrDefault(U => U.userName == name && U.password == password);
            if (userFromTable == null)
                return null;
            else
                return new DTOusers(userFromTable);

        }

        public static DTOusers RegisterUser(DTOusers AddUser)
        {
            user newLogin = AddUser.UserToTable();
            db.Execute<user>(newLogin, DBConection.ExecuteActions.Insert);
            AddUser.iduser = newLogin.iduser;
            return AddUser;


        }
        public static DTOusers UpdateUser(DTOusers UpdateUser)
        {
            user execUser = UpdateUser.UserToTable();
            db.Execute<user>(execUser, DBConection.ExecuteActions.Update);
            return UpdateUser;


        }
        public static DTOusers DeleteUser(DTOusers DeleteUser)
        {
            user execUser = DeleteUser.UserToTable();
            db.Execute<user>(execUser, DBConection.ExecuteActions.Delete);
            return DeleteUser;


        }
    }
}
