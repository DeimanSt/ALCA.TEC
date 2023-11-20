using System;
using System.Configuration;

namespace Al_Soft.Sistema_Usuarios
{
    internal sealed partial class ConfiguracionApp : ApplicationSettingsBase
    {
        [UserScopedSetting]
        public DateTime UltimaGeneracionPDF
        {
            get => (DateTime)(this[nameof(UltimaGeneracionPDF)] ?? DateTime.MinValue);
            set => this[nameof(UltimaGeneracionPDF)] = value;
        }
    }
}