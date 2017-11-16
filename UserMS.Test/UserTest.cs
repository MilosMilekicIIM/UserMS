using NUnit.Framework;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UserMS.DataAccess;
using UserMS.Models;

namespace UserMS.Test
{
    public class UserTest
    {
        //private void ClearUsers()
        //{
        //    UserDB.usersInMemory.Clear();
        //}

        //[Test]
        //public void User_Get_All_Success()
        //{
        //    User testUser = new User
        //    {
        //        Id = 1,
        //        Name = "Marko"
        //    };
        //    ClearUsers();
        //    UserDB.CreateUser(testUser);
        //    Assert.AreEqual(1, UserDB.usersInMemory.Count);
        //}

        //[Test]
        //public void Create_User_Success()
        //{
        //    User testUser = new User
        //    {
        //        Id = 1,
        //        Name = "Marko"
        //    };
        //    ClearUsers();
        //    UserDB.CreateUser(testUser);
        //    Assert.AreEqual(testUser.Name, UserDB.GetUserById(1).Name);
        //}
    }
}
