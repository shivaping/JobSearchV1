using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobSearch.WebAPIHelper
{
    public interface ITokenContainer
    {
        object ApiToken { get; set; }
        string UserName { get; set; }
    }
}
