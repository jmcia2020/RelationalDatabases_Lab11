using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.API
{
    /// <summary>
    /// Represents public interface for anyone who has access to hotel information.
    /// </summary>
    public class UserDto
    {
        public string Id { get; set; }

        public string Username { get; set; }
        public string Token { get; set; }

        public IEnumerable<string> Roles { get; set; }
    }
}
