
using DmsAssignment.Infrastructure.Generic;
using DmsAssignment.Domain.Entities.Extend;

namespace DmsAssignment.Infrastructure.Repositories.AuthenticationRepository
{
    public interface IAuthRepository : IGenericRepository<ApplicationUser>
    {
        //Task<AuthServiceResponseDto> MakeAdminAsync(UpdatePermissionDto updatePermissionDto);
        //Task<AuthServiceResponseDto> MakeUserAsync(UpdatePermissionDto updatePermissionDto);
        //Task<AuthServiceResponseDto> MakeSuperAdminAsync(UpdatePermissionDto updatePermissionDto);
    }
}
