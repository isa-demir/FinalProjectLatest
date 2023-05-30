using System.Security.Claims;

namespace Core.Extensions
{
    /// <summary>
    /// Bir kisinin claimlerine ulasmak .Net tarafinda biraz ugrastirici bir is. Asagidaki kodlari yazmamiz gerekiyor.
    /// ClaimsPrincipal -> O anki kisinin JWT ile gelen claimlerini okumak icin gerekli olan class.
    /// 
    ///  Claims metodu, belirli bir türdeki talepleri (örneğin, kullanıcının isim veya e-posta taleplerini)
    ///  çekmek için kullanılabilirken, ClaimRoles metodu kullanıcının rollerini temsil eden talepleri çekmek
    ///  için kullanılabilir.
    /// </summary>
    public static class ClaimsPrincipalExtensions
    {
        public static List<string> Claims(this ClaimsPrincipal claimsPrincipal, string claimType)
        {
            var result = claimsPrincipal?.FindAll(claimType)?.Select(x => x.Value).ToList();
            return result;
        }

        public static List<string> ClaimRoles(this ClaimsPrincipal claimsPrincipal)
        {
            return claimsPrincipal?.Claims(ClaimTypes.Role);
        }
    }
}
