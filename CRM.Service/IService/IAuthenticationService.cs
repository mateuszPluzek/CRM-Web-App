using CRM.Model.InputModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Service.IService
{
    public interface IAuthenticationService
    {
        Task<bool> LoginAsync(ApplicationUserInputModel model);
        Task<bool> RegisterAsync(ApplicationUserInputModel model);
        Task<bool> ForgotPasswordAsync(ApplicationUserInputModel model);
        Task<bool> ResetPasswordAsync(ApplicationUserInputModel model);
        Task<bool> ChangePasswordAsync(ApplicationUserInputModel model);
        Task<bool> RefreshTokenAsync(ApplicationUserInputModel model);
    }
}
