
using Business.Constants;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace Business.BusinessAspects.Autofac
{
    // SecuredOperation -> JWT Icin
    public class SecuredOperation : MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;

        //Attribute oldugu icin roller virgul ile ayrilarak gelir.
        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();

        }

        protected override void OnBefore(IInvocation invocation)
        {
            var roleClaims = _httpContextAccessor.HttpContext.User.ClaimRoles();
            foreach (var role in _roles)
            {
                if (roleClaims.Contains(role))
                {
                    return;
                }
            }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
/// <summary>
/// IHttpContextAccessor -> Her bir istek icin bir tane httpcontext'i olusur.
/// _httpContextAccessor değişkeni, HTTP istekleri ve kullanıcı kimlik doğrulama verilerine erişim sağlayan
/// IHttpContextAccessor arayüzünü temsil eder. Bu, doğrulama sürecindeki kullanıcı bilgilerine erişim sağlamak
/// için kullanılır.
/// </summary>
