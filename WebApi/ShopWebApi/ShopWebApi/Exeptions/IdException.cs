using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWebApi.Exeptions
{
    [Serializable]
    public class IdException : Exception
    {
        public IdException()
        { }

        public IdException(int id)
            : base(String.Format("Invalid Id entered: {0}", id))
        { }

    }
}
