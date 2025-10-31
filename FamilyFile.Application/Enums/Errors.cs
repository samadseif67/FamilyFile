using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyFile.Application.Enums
{
    public enum Errors
    {
        [Description("خطا:عملیات با خطا مواجهه شد")]
        Cancell=1,
        [Description("عملیات با موفقیت انجام شد")]
        Ok=2

    }
}
