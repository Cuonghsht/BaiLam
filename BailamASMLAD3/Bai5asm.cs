using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BailamASMLAD3
{
    public class Bai5asm
    {
        public class UserProfile
        {
            public string Name { get; set; }
        }

        public class UserService
        {
            public string GetName(UserProfile profile)
            {
                if (profile == null)
                {
                    throw new NullReferenceException("NUll");
                }

                return profile.Name;
            }
        }
    }
}
