using MVVMLab.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLab.Data
{
    public interface IUserDataProvider
    {
        Task<IEnumerable<UserModel>?> GetAllAsync();

    }

    public class UserDataProvider : IUserDataProvider
    {
        public async Task<IEnumerable<UserModel>?> GetAllAsync()
        {
            await Task.Delay(100); // Simulate a bit of server work

            return new List<UserModel>
            {
                 new UserModel{Id=Guid.NewGuid(),FirstName="Yasin",LastName="Kaufman",IsAdmin=true},
                 new UserModel{Id=Guid.NewGuid(),FirstName="Alaina",LastName="Bridges",IsAdmin=true},
                 new UserModel{Id=Guid.NewGuid(),FirstName="Blair",LastName="Kaur",IsAdmin=false},
                 new UserModel{Id=Guid.NewGuid(),FirstName="Oliver",LastName="Sosa",IsAdmin=false},
                 new UserModel{Id=Guid.NewGuid(),FirstName="Edan",LastName="Dudley",IsAdmin=false},
                 new UserModel{Id=Guid.NewGuid(),FirstName="Izzy",LastName="Hamilton",IsAdmin=false},
                 new UserModel{Id=Guid.NewGuid(),FirstName="King",LastName="Knight",IsAdmin=true},
            };
        }
    }
}
