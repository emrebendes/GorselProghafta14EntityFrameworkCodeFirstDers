using EntityLayer.Entity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer
{
    public class Ogrenci
    {
       
        public int OgrenciId { get; set; }
       
        public string OgrenciAdi { get; set; }
        public DateTime DTarihi { get; set; }
        public byte[] Resim { get; set; }
        public Bolum bolum { get; set; }
    }
}