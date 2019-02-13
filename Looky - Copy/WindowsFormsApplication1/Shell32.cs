using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApplication1
{

    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;
    using System.IO;
    /*class Program
    {
        static void noMain()
        {
            // например, получаем иконку для PDF
            // имя файла - от балды, главное это расширение
            string fileName = "bla-bla-bla.pdf";
            // вся кухня - здесь
            Shell32.SHFILEINFO shfi = new Shell32.SHFILEINFO();
            Shell32.SHGetFileInfo(fileName, Shell32.FILE_ATTRIBUTE_NORMAL, ref shfi,
                (uint)Marshal.SizeOf(shfi), Shell32.SHGFI_ICON | Shell32.SHGFI_USEFILEATTRIBUTES | Shell32.SHGFI_LARGEICON);
            Icon icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();
            User32.DestroyIcon(shfi.hIcon);
            // теперь можем, например, сохранить в bmp
            icon.ToBitmap().Save(@"c:\pdf_icon.bmp");
        }
    }*/
    public class Shell32
    {
        public const int MAX_PATH = /*256*/260;
        [StructLayout(LayoutKind.Sequential)]
        public struct SHITEMID
        {
            public ushort cb;
            [MarshalAs(UnmanagedType.LPArray)]
            public byte[] abID;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct ITEMIDLIST
        {
            public SHITEMID mkid;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public const int NAMESIZE = 80;
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = NAMESIZE)]
            public string szTypeName;
        };
        public const uint SHGFI_ICON = 0x000000100;     // get icon
        public const uint SHGFI_DISPLAYNAME = 0x000000200;     // get display name
        public const uint SHGFI_TYPENAME = 0x000000400;     // get type name
        public const uint SHGFI_ATTRIBUTES = 0x000000800;     // get attributes
        public const uint SHGFI_ICONLOCATION = 0x000001000;     // get icon location
        public const uint SHGFI_EXETYPE = 0x000002000;     // return exe type
        public const uint SHGFI_SYSICONINDEX = 0x000004000;     // get system icon index
        public const uint SHGFI_LINKOVERLAY = 0x000008000;     // put a link overlay on icon
        public const uint SHGFI_SELECTED = 0x000010000;     // show icon in selected state
        public const uint SHGFI_ATTR_SPECIFIED = 0x000020000;     // get only specified attributes
        public const uint SHGFI_LARGEICON = 0x000000000;     // get large icon
        public const uint SHGFI_SMALLICON = 0x000000001;     // get small icon
        public const uint SHGFI_OPENICON = 0x000000002;     // get open icon
        public const uint SHGFI_SHELLICONSIZE = 0x000000004;     // get shell size icon
        public const uint SHGFI_PIDL = 0x000000008;     // pszPath is a pidl
        public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;     // use passed dwFileAttribute
        public const uint SHGFI_ADDOVERLAYS = 0x000000020;     // apply the appropriate overlays
        public const uint SHGFI_OVERLAYINDEX = 0x000000040;     // Get the index of the overlay
        public const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;
        public const uint FILE_ATTRIBUTE_NORMAL = 0x00000080;
        [DllImport("Shell32.dll", CharSet = CharSet.Ansi)]
        public static extern IntPtr SHGetFileInfo(
            string pszPath,
            uint dwFileAttributes,
            ref SHFILEINFO psfi,
            uint cbFileInfo,
            uint uFlags
            );
    }
    public class User32
    {
        [DllImport("User32.dll")]
        public static extern int DestroyIcon(IntPtr hIcon);
    }


    //class Shell32
    //{
    //}
}
