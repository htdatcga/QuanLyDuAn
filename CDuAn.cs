using System;

namespace QuanLyDuAn.Models
{
    public class CDuAn
    {
        // Project ID used in routes (Edit/Delete). Use int if IDs are numeric.
        public int MaDA { get; set; }

        // Project name displayed in the view
        public string TenDuAn { get; set; } = string.Empty;

        // Budget shown with "{0:N0} VNĐ" in the view
        public decimal NganSach { get; set; }
    }
}