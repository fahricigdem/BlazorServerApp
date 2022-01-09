using System;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.BaseComponents
{
    public class DateTimeBaseComponent : ComponentBase
    {

        public DateTime vakit { get; set; }

        public string evakit = DateTime.Now.ToString("dd/MM/yyyy");

        public string something { get; set; } = "Something";

    }
}
