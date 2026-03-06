using System;

namespace AliMertBayrak.Models
{
    public class Yorum
    {
        public int Id { get; set; }

        public string? OgrenciAdi { get; set; }

        public string? Duygu { get; set; }

        public DateTime Tarih { get; set; } = DateTime.Now;
    }
}

