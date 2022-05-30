using System.Collections.Generic;
using deloso.Roles.Dto;

namespace deloso.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}