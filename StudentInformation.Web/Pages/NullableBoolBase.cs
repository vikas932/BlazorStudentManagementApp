using Microsoft.AspNetCore.Components;
using StudentInformation.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentInformation.Web.Pages
{
    public class NullableBoolBase : ComponentBase
    {
        public bool? Foo { get; set; }
        public IEnumerable<SelectionItem> SelectedItems { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadItems();
            return base.OnInitializedAsync();
        }
        private void LoadItems()
        {
            SelectionItem e1 = new SelectionItem
            {
                Text = "",
                blValue = ""
            };
            SelectionItem e2 = new SelectionItem
            {
                Text = "Yes",
                blValue = "true"
            };
            SelectionItem e3 = new SelectionItem
            {
                Text = "No",
                blValue = "false"
            };
            SelectedItems = new List<SelectionItem> { e1, e2, e3 };
        }
    }
}