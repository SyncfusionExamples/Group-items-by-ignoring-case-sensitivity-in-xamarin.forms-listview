using Syncfusion.DataSource;
using Syncfusion.DataSource.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grouping
{
    public class CustomGroupComparer : IComparer<GroupResult>, ISortDirection
    {

        #region Constructor

        public CustomGroupComparer()
        {
            this.SortDirection = ListSortDirection.Ascending;
        }

        #endregion

        #region Property

        public ListSortDirection SortDirection
        {
            get;
            set;
        }
        #endregion

        #region IComparer<Group> Members

        /// <summary>
        /// Compares two objects and returns a value indicating whether one is less than, equal to, or greater than the other.
        /// </summary>
        /// <param name="x">The first object to compare.</param>
        /// <param name="y">The second object to compare.</param>
        public int Compare(GroupResult x, GroupResult y)
        {
            int groupX;
            int groupY;

            groupX = x.Count;
            groupY = y.Count;

            // Objects are compared and return the SortDirection
            if (groupX.CompareTo(groupY) > 0)
                return SortDirection == ListSortDirection.Ascending ? 1 : -1;
            else if (groupX.CompareTo(groupY) == -1)
                return SortDirection == ListSortDirection.Ascending ? -1 : 1;
            else
                return 0;

        }

        #endregion

    }
}
