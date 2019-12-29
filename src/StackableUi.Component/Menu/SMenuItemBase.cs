using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace StackableUi.Component.Menu
{
    public class SMenuItemBase:SComponentBase
    {
        [Parameter]
        public string Route { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public void OnClick()
        {
            if (!string.IsNullOrEmpty(Route))
            {
                NavigationManager.NavigateTo(Route);
            }
        }
    }
}
