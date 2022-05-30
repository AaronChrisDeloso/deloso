using System.Collections.Generic;
using deloso.Roles.Dto;

namespace deloso.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
