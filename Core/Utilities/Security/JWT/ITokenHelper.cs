using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        /// <summary>
        /// Kullanici giris bilgilerini yazip istek gonderdikten sonra, eger giris bilgileri dogru ise veritabanindan
        /// kullanicinin asagidaki bilgileri alinir ve daha sonrasinda JWT'ye dahil edilerek kullaniciya tekrar
        /// gonderilir. Bu sayede kullanicinin yetkilerine gore islemleri yapmasi saglanir.
        /// </summary>
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
