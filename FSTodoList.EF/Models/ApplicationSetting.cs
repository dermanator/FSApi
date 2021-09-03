using System;
using System.Collections.Generic;

#nullable disable

namespace FSTodoList.EF.Models
{
    public partial class ApplicationSetting
    {
        public int ApplicationSettingId { get; set; }
        public string SettingKey { get; set; }
        public string SettingValue { get; set; }
        public string SettingDescription { get; set; }
        public string SettingDataType { get; set; }
    }
}
