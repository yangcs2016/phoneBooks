using System.Collections.Generic;
using Book.Roles.Dto;

namespace Book.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}