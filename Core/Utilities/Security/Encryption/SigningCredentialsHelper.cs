using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        /// <summary>
        /// JWT, web uygulamalarında güvenli ve taşınabilir bir şekilde kimlik doğrulama ve yetkilendirme
        /// sağlamak için kullanılan bir standarttır. İmzalama, JWT'nin güvenilirliğini sağlamak için kullanılır.
        /// İmzalama kimlik bilgileri, bir JWT'nin doğrulama sürecinde kullanılan algoritma ve anahtar bilgilerini içerir.
        /// Bu yardımcı sınıf, JWT'nin imzalanması için kullanılacak SigningCredentials nesnesini oluşturmayı sağlar.
        /// İmzalama kimlik bilgileri, JWT'nin oluşturulması ve doğrulanması sürecinde kullanılır ve güvenlik
        /// açısından önemli bir rol oynar.
        /// </summary>
        /// <param name="securityKey"></param>
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }
    }
}
