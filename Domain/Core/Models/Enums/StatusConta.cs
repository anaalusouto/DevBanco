using System.ComponentModel;

namespace ClienteCRUD.Core.Models.Enums
{
    public enum StatusConta
    {
        [Description("Fechada")]
        Fechada = 0,
        [Description("Aberta")]
        Aberta = 1,
        [Description("Trancada")]
        Trancada = 2,
        [Description("Bloquieada")]
        Bloquieada = 3,

    }
}
