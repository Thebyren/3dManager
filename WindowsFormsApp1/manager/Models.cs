using System;

namespace WindowsFormsApp1.manager
{
    public class Models
    {
        public int id {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public DateTime Date { get; set; }
        public string Ext { get; set; }
        public byte[] DataBytes { get; set; }

        public Models(string name, string description, DateTime date, string size = "", string ext = ".", byte[] DataBytes = null)
        {
            this.Name = name;
            this.Description = description;
            this.Date = date;
            this.Ext = ext;
            this.Size = size;
            this.DataBytes = DataBytes;
        }
    }
}
