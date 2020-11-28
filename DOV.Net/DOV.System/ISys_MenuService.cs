using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DOV.System
{
    public partial interface ISys_MenuService
    {
        Task<object> GetMenu();
    }
}
