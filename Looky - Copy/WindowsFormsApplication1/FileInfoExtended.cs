using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class FileInfoExtended
    {
            //System.IO.FileInfo  
        public System.IO.FileInfo  FileInfoStandard { get; private set; }
        public Encoding FileEncoding { get; set; }
        private FileInfoExtended()
        {

        }
        public FileInfoExtended(System.IO.FileInfo fi, Encoding Enc)
        {
            FileInfoStandard = fi;
            FileEncoding = Enc;
        }
    }
}
