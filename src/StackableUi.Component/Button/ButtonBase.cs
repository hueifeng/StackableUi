using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace StackableUi.Component.Button
{
    public class ButtonBase: SComponentBase
    {
        [Parameter] public EnumButtonType Type { get; set; } = EnumButtonType.Default;
    }
}
