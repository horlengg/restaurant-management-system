using System;
using System.Collections.Generic;

namespace FoodApp.app.utils
{
    enum Role
    {
        Administrator,
        Staff,
        Manager
    }

    class RoleHelper
    {

        // Alternatively, initialize dynamically from the enum
        public static List<string> roles = new List<string>(Enum.GetNames(typeof(Role)));
    }
}
