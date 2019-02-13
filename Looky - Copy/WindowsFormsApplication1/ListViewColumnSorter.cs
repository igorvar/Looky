using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    class ListViewColumnSorter : IComparer
    {
        private CaseInsensitiveComparer ObjectCompare;
        public ListViewColumnSorter()
        {
            ColumnToSort = 0;
            OrderOfSort = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }

        #region IComparer Members

        int IComparer.Compare(object x, object y)
        {
            //throw new NotImplementedException();
            int compareResult;
            ListViewItem listviewX, listviewY;
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;
            object valX;
            object valY;

            //case (listviewX.Name)
            
            switch ((string)(listviewX.ListView.Columns[ColumnToSort].Tag))
            {
                case "Size":
                    FileInfo fiX = ((FileInfoExtended)listviewX.Tag).FileInfoStandard;
                    FileInfo fiY = ((FileInfoExtended)listviewY.Tag).FileInfoStandard;
                    valX = fiX.Length;
                    valY = fiY.Length;
                    break;
                case "DateCreated":
                    valX = ((FileInfoExtended)listviewX.Tag).FileInfoStandard.CreationTime;
                    valY = ((FileInfoExtended)listviewY.Tag).FileInfoStandard.CreationTime;
                    break;
                case "DateModidied":
                    valX = ((FileInfoExtended)listviewX.Tag).FileInfoStandard.LastWriteTime;
                    valY = ((FileInfoExtended)listviewY.Tag).FileInfoStandard.LastWriteTime;
                    break;
                default:
                    valX = listviewX.SubItems[ColumnToSort].Text;
                    valY = listviewY.SubItems[ColumnToSort].Text;
                    break;
            }
            //compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            compareResult = ObjectCompare.Compare(valX, valY);
            if (OrderOfSort == SortOrder.Ascending) return compareResult;
            if (OrderOfSort == SortOrder.Descending) return -compareResult;
            return 0;
        }
        #endregion
        public int ColumnToSort { get; set; }
        public SortOrder OrderOfSort { get; set; }

    }
}
