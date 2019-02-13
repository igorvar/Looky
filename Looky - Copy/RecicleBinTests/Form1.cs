using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Shell32;
using System.Runtime.InteropServices;


namespace RecicleBinTests
{
    
    public partial class Form1 : Form
    {
        //Не отображать диалог с уведомлением об удалении объектов
        const int SHERB_NOCONFIRMATION = 0x00000001;
        
        //Не отображать диалог с индикатором прогресса
        const int SHERB_NOPROGRESSUI = 0x00000002;

        //Когда операция закончится, не проигрывать звук
        const int SHERB_NOSOUND = 0x00000004;

        [DllImport("shell32.dll")]
        static extern int SHEmptyRecycleBin(IntPtr hWnd, string pszRootPath, uint dwFlags);

        //Перечисление и API-функция для открытия файлов. Зачем это нужно -- в самом конце статьи
        public enum ShowCommands : int
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }

        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);

        Shell shell;//экземпляр интерфейса Shell

 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRecycle();
        }



        private void LoadRecycle()
        {
            shell = new Shell();//создаем новый экземпляр интерфейса Shell

            lvRecycle.Items.Clear();//очищаем список lvRecycle

            ListViewItem lvi;
            //получаем экземпляр интерфейса Folder, уже как бы настроенный на корзину
            Folder recycleBin = shell.NameSpace(10);

            //перебираем всё, что содержится в recycleBin, т. е. файлы и папки
            foreach (FolderItem2 f in recycleBin.Items())
            {
                //Добавляем новый элемент в список и присваиваем полученный ListViewItem переменной lvi.
                //Здесь именем элемента является полное имя файла или папки, текстом, отображаемым
                //в колонке "Имя" -- имя файла или папки
                lvi = lvRecycle.Items.Add(f.Path, f.Name, "");
                //добавляем первоначальное расположение файла
                //lvi.SubItems.Add(f.ExtendedProperty("{9B174B33-40FF-11D2-A27E-00C04FC30871}2"));
                //добавляем тип файла
                lvi.SubItems.Add(f.Type);
                //если элемент -- папка, то размер не вычисляем
                if (f.IsFolder)
                {
                    lvi.Tag = "d";//это нужно для последующего отделения папок от файлов
                    lvi.SubItems.Add("");
                }
                //иначе показываем размер
                else
                {
                    lvi.Tag = "f";
                    lvi.SubItems.Add(f.Size.ToString() + " B");//размер будет отображен в байтах
                }
                //дата удаления
                lvi.SubItems.Add(((DateTime)f.ExtendedProperty("{9B174B33-40FF-11D2-A27E-00C04FC30871}3")).ToString());
                //lvRecycle.Items.Add(lvi);
            }
            //В ресурсах проекта хранятся два значка -- пустой корзины и полной.
            //Если в корзине что-то есть, показываем значок полной корзины, иначе -- пустой
            /*if (lvRecycle.Items.Count > 0)
                this.Icon = LUNAticExplorer.Properties.Resources.recycle_full;
            else
                this.Icon = LUNAticExplorer.Properties.Resources.recycle_empty;*/

            //нужно всегда освобождать ресурсы из-под более ненужного объекта COM
            //(каковым Shell32 и является)
            Marshal.FinalReleaseComObject(shell);
        }
    }
}
