using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewAnh
    {
        public Guid Id { get; set; }
        public string MaAnh { get; set; }
        public string TenAnh { get; set; }
        public string DuongDan { get; set; }
        public int? TrangThai { get; set; }
    }
}
