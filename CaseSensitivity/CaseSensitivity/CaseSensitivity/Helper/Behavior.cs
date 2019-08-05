using Syncfusion.DataSource;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Grouping
{
   public class Behavior : Behavior<SfListView>
    {
        SfListView ListView;
        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;
            this.ListView.DataSource.GroupDescriptors.Add(new GroupDescriptor()
            {
                PropertyName = "ContactName",
                KeySelector = (object obj) =>
                {
                    return (obj as Contacts).ContactName.ToUpper();
                }
            });

            base.OnAttachedTo(bindable);

        }

        protected override void OnDetachingFrom(SfListView bindable)
        {

            base.OnDetachingFrom(bindable);
        }
    }
}
