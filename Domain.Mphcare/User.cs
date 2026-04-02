using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Mphcare.Common;

namespace Domain.Mphcare
{
    public class User : BaseDomainEntity
    {
        public string fullname { get ; private set; }


        public string CCCD { get; private set; }


        public string phone { get; private set; }






    }
}
