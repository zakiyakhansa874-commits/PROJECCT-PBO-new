using System;
using System.Collections.Generic;
using System.Text;

namespace inventory_panen_mvc.Models
{
    public interface IUserMenu
    {
        List<string> GetMenu();
    }
}
