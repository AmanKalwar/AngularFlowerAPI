using API1project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1project.Services
{
    public interface ITokenService
    {
        public string CreateToken(UserDTO userDTO);
    }
}