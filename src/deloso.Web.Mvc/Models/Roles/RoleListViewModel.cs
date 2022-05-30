using System.Collections.Generic;
using deloso.Roles.Dto;

namespace deloso.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
