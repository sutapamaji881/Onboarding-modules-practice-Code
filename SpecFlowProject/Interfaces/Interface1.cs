using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowProject.Interfaces
{
    interface Interface1
    {
        [Get("/users/{user}")]
        Task<User> GetUser(string user);
    }
}
