using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyWatchStore.Models;
using System.Net.Mail;
using System.Net;
using System.Web.Security;

namespace MyWatchStore.Controllers
{
    public class UserController : Controller
    {
        WatchStoreDataContext data = new WatchStoreDataContext();
        // GET: User
        public ActionResult LoginPartial() {
            KHACHHANG kh = Session["KhachHang"] as KHACHHANG;
            if (kh == null)
            {
                ViewBag.TenKhachHang = "";
            }
            else {
                ViewBag.TenKhachHang = kh.TenKH;
            }
            return PartialView();
        }

        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("Index", "WatchStore");
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DangKy() {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection collector) {
            var tenDN = collector["TaiKhoan"];
            var matKhau = collector["MatKhau"];
            if (String.IsNullOrEmpty(tenDN))
            {
                ViewData["Error1"] = "Thiếu tên đăng nhập!";
            }
            else if (String.IsNullOrEmpty(matKhau))
            {
                ViewData["Error2"] = "Thiếu mật khẩu!";
            }
            else {
                KHACHHANG kh = data.KHACHHANGs.SingleOrDefault(n => n.TenDN == tenDN && n.MatKhau == matKhau);
                if (kh != null) {
                    ViewBag.Thongbao = "Đăng nhập thành công!";
                    Session["KhachHang"] = kh;
                    return RedirectToAction("Index", "WatchStore");
                }
                else
                    ViewBag.Thongbao = "Sai tên đăng nhập hoặc mật khẩu!";
            }
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(FormCollection collector, KHACHHANG kh) {
            var hoTen = collector["HoTen"];
            var tenDN = collector["TaiKhoan"];
            var matKhau = collector["MatKhau"];
            var email = collector["Email"];
            var sdt = collector["Sdt"];
            var diaChi = collector["DiaChi"];
            if (String.IsNullOrEmpty(hoTen))
            {
                ViewData["Error1"] = "Thiếu họ tên!";
            }
            else if (String.IsNullOrEmpty(tenDN))
            {
                ViewData["Error2"] = "Thiếu tên đang nhập!";
            }
            else if (String.IsNullOrEmpty(matKhau))
            {
                ViewData["Error3"] = "Thiếu mật khẩu";
            }
            else if (String.IsNullOrEmpty(email))
            {
                ViewData["Error4"] = "Thiếu email";
            }
            else if (String.IsNullOrEmpty(sdt.ToString()))
            {
                ViewData["Error5"] = "Thiếu số điện thoại";
            }
            else if (String.IsNullOrEmpty(diaChi)) {
                ViewData["Error6"] = "Thiếu địa chỉ";
            }
            else
            {
                kh.TenKH = hoTen;
                kh.TenDN = tenDN;
                kh.MatKhau = matKhau;
                kh.Email = email;
                kh.SoDT = sdt;
                kh.DiaChi = diaChi;
                data.KHACHHANGs.InsertOnSubmit(kh);
                data.SubmitChanges();
                return RedirectToAction("Index", "WatchStore");
            }
            return this.DangKy();
        }
    
        // Forgot password
        [HttpGet]
        public ActionResult GuiEmail()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GuiEmail(string body, FormCollection collector, KHACHHANG kh)
        {
            var email = collector["Email"];
            kh = data.KHACHHANGs.SingleOrDefault(n => n.Email == email);
            if (String.IsNullOrEmpty(email) && kh == null)
            {
                ViewData["Error1"] = "Email không được trống";
            }
            else if (kh == null)
            {
                ViewData["Error2"] = "Email không tồn tại";
            }
            else
            {
                try
                {
                    string matKhau = kh.MatKhau;
                    MailMessage mail = new MailMessage();
                    mail.To.Add(email);
                    mail.From = new MailAddress("khaibeo98@gmail.com"); // email cua nguoi gui
                    mail.Subject = "Quen Mat Khau";

                    body = body = "Mat khau cua ban la: " + matKhau + "";

                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com"; //SMTP xac nhan may chu email
                    smtp.Credentials = new System.Net.NetworkCredential
                         ("khaibeo98@gmail.com", "qwerty2709"); // ***su dung chung chi hop le SMTP cho mat khau va email cua nguoi gui***
                    smtp.Port = 587;

                    //SMTP xac nhan ssl
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                    ViewBag.Thongbao = "Vui long kiem tra email cua ban";
                }
                catch (Exception ex)
                {
                    ViewBag.Thongbao = "Loi ngoai le email!" + ex.Message;
                }
            }
            return this.DangKy();
        }
    }
}