namespace Bai08
{
    internal class TaiKhoan
    {
        public int Index {get;  set;}
        public string SoTK {get; private set;}
        public string TenTK {get; private set;}
        public string DiaChiKH {get; private set;}
        public ulong SoTienTrongTK { get; private set; }

        public TaiKhoan(string soTK, string tenTK, string diaChiKH, ulong soTienTrongTK)
        {
            SoTK = soTK;
            TenTK = tenTK;
            DiaChiKH = diaChiKH;
            SoTienTrongTK = soTienTrongTK;
        }

        public ListViewItem ToListViewItem()
        {
            var item = new ListViewItem(Index.ToString());
            item.SubItems.Add(SoTK);
            item.SubItems.Add(TenTK);
            item.SubItems.Add(DiaChiKH);
            item.SubItems.Add(SoTienTrongTK.ToString());

            return item;
        }
        public static TaiKhoan FromListViewItem(ListViewItem item)
        {

            var subs = item.SubItems;

            var idx = int.Parse(item.Text);

            return new TaiKhoan(
                subs[1].Text,
                subs[2].Text,
                subs[3].Text,
                ulong.Parse(subs[4].Text)
            )
            { 
                Index = idx
            };
        }
    }
}
