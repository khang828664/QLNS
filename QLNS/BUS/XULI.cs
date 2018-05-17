using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;
using System.Data;

namespace BUS
{
    public class XLTK
    {
        // xử lý đăng nhập 

        Data da = new Data();
        
       
        public string kt(string a, string b)
        {
            string sql = "select  TENDN from NHANVIEN where TENDN='" + a + "' COLLATE SQL_Latin1_General_CP1_CS_AS and  MK= '" + b + "'  COLLATE SQL_Latin1_General_CP1_CS_AS  ";
            return da.ExScalar1(sql);
        }

     }
    public class XLPM
    {


        Data da = new Data();
        //Hàm lấy dữ liệu cho combobox
        //lấy dữ liệu cho combobox9 
        public DataSet TENDANGNHAP()
        {

            string sql = "select TENDN from NHANVIEN";
            return da.EXreader(sql);
        }
        //bombobox 1 
        public DataSet TENSACH()
        {
            string sql = "select TenSach from SACH";
            return da.EXreader(sql);
        }
        //combobox2 
        public DataSet TACGIA()
        {
            string sql = "select Theloai from SACH";
            return da.EXreader(sql);
        }
      
        //
        // lấy table SACH 
        public DataTable SACH()
        {
            string sql = "select  * from SACH ";
            return da.GetTable(sql);
        }
        public DataTable SearchBOOK(BOOK searchbook )

        {
            string sql = "select * from SACH where TenSach ='" + searchbook.TENSACH + "' and TheLoai='" + searchbook.THELOAI + "'";   
            return da.GetTable(sql);
        }
        public DataTable aplyBOOK(BOOK searchbook)

        {
            string sql = "select * from SACH where TenSach ='" + searchbook.TENSACH + "' and TheLoai='" + searchbook.THELOAI + "'and MaSach='" + searchbook.MASACH + "'";
            return da.GetTable(sql);
        }
        public void AddBook (BOOK addbook )
        {
            string sql = "Insert into SACH values( '" + addbook.TEBNXB + "','" + addbook.TENSACH + "','" + addbook.TACGIA + "','" + addbook.THELOAI + "','" + addbook.DONGIA + "','"+addbook.SOLUONG+"')";
            da.ExNonQuery(sql); 
        }
        // kiem tra sach co ton tai hay chua
        public int  KTSACH (string a, string b )
        {
            string sql = "select count (TenSach) from SACH where TenSach = '" + a + "' and TheLoai='"+b+"' ";
            return da.ExScalar(sql);
        }
        public int KTPN(int a)
        {
            string sql = "select count (MaSach) from CTPHIEUNHAP where MaSach = '" + a + "' ";
            return da.ExScalar(sql);
        }
        //kiem tra phieu nhap co ton tai hay chu

        //xoa sach 
        public void deleteBOOK(int a)
        {
            
            string sql = "delete from Sach where MaSach = '" + a + "'";
            da.ExNonQuery(sql); 

        }
        public int  getMaSach( string a  )
        {
            string sql = " select MaSach from SACH where TenSach = '" + a + "' ";
            return da.ExScalar(sql); 
        }
        public void addPHIEUNHAP (PHIEUNHAP phieunhap  )
        {
            string sql = "insert into CTPHIEUNHAP  values ('"+phieunhap.MaSach+"', '" + phieunhap.SOLUONG + "','" + phieunhap.NGAYNHAP + "')";
            da.ExNonQuery(sql); 

        }
        public DataTable SearchPN1(PHIEUNHAP searchpn)

        {
            string sql = "select * from CTPHIEUNHAP where MaSach ='" + searchpn.MaSach+ "'and NgayNhap='"+searchpn.NGAYNHAP+"' ";
            return da.GetTable(sql);
        }

        public void deletePNBOOK(int a)
        {

            string sql = "delete from CTPHIEUNHAP where MaSach = '" + a + "'";
            da.ExNonQuery(sql);

        }
        //Tat ca phieu nhap 
        public DataTable SearchPN2()

        {
            string sql = "select * from CTPHIEUNHAP ";
            return da.GetTable(sql);
        }
        //update sach 
        public void updateBOOK(BOOK book )
        {
            string sql = "UPDATE SACH set  TenNXB = '"+book.TEBNXB+"', TenSach = '"+book.TENSACH+"', TacGia = '"+book.TACGIA+"', TheLoai = '"+book.THELOAI+ "',DonGia = '" + book.DONGIA + "' where MaSach = '" + book.MASACH+"'";
            da.ExNonQuery(sql); 
        }
        //lay soluong sach 
        public int  getSOLUONG(PHIEUNHAP phieunhap )
        {
            string sql = "select SoLuong from SACH where MaSach ='"+phieunhap.MaSach+"'";
            return da.ExScalar(sql); 

        }
        // update soluong sach
        public void updateSOLUONGSACH(BOOK book )
        {
            string sql = " update SACH set SoLuong ='" + book.SOLUONG + "' where MaSach='"+book.MASACH+"'";
            da.ExNonQuery(sql); 
        }

    }


}
