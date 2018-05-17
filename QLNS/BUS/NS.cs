using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    class NS

    {

        

    }
    public class tk
    {
        public string TENDN  { get; set;}
        public string MK     { get; set; }


    }
    public class BOOK
    {
        public int? MASACH = null;  
        public string TENSACH { get; set;  }
        public string THELOAI { get; set;  }
        public string TACGIA { get; set;  }
        public int  DONGIA { get; set;  }
        public string  TEBNXB { get; set;  }
        public int SOLUONG = 0; 



    }
    public class PHIEUNHAP
    {

        public int? MAPN = null; 
        public int MaSach { get; set;  }
        public int SOLUONG { get; set;  }
        public string NGAYNHAP { get; set;  }
    }

}
