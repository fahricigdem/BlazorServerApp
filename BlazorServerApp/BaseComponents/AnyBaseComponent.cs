using System;
using Microsoft.AspNetCore.Components;

namespace BlazorServerApp.BaseComponents
{
    public class AnyBaseComponent : ComponentBase
    {


        public string anything { get; set; } = "Anything";

    }
}
