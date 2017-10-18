﻿using System.Collections.Generic;
using POS.BLL.Security.Domain;

namespace POS.BLL.Security
{
    public static class LoginInformation
    {
        public static UserInformationModel UserInformation { get; set; }
        public static IList<MenuModel> PermittedMenues { get; set; }
        public static bool IsApprover { get; set; }
        public static int IncomingLeaveRequest { get; set; }
    }
}