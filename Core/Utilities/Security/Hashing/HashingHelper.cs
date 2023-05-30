using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        /// <summary>
        /// Bu kod bloğu, verilen bir parolayı hash değerine dönüştürmek için HMAC-SHA512 algoritmasını
        /// kullanan bir yöntem olan CreatePasswordHash'i içermektedir. Bu yöntem, verilen parolanın hash
        /// değerini hesaplar ve bu hash değeri ile bir tuz (salt) oluşturarak geri döndürür.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="passwordHash"></param>
        /// <param name="passwordSalt"></param>
        /// passwordSalt değeri, HMACSHA512 nesnesinin Key özelliğine atanır. Key, HMAC algoritmasının
        /// kullanması için gereken bir tuz (salt) değeridir. HMACSHA512 nesnesi her oluşturulduğunda,
        /// rastgele bir tuz değeri oluşturulur. Bu, her kullanıcı için farklı bir tuz değeri sağlar ve
        /// parola güvenliğini artırır.
        public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key; //Yukarida kullanilan algoritmada olusan key degeridir.
                                         //Her kullanici icin farkli bir deger olusturur.
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
        public static bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}

