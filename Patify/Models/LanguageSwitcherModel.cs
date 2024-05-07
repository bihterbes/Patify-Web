using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Patify.Models
{
    public class LanguageSwitcherModel
    {
        public CultureInfo CurrentUICulture { get; set; }
        public List<CultureInfo> SupportedCultures { get; set; }
        public string CurrentSitecoreRoute { get; set; }
    }
}
