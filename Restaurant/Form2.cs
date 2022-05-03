using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;

namespace Restaurant
{
    public partial class Form2 : Form
    {
        private List<Masa> Masalar = new List<Masa>();
        private List<Urun> Urunler = new List<Urun>();
        private List<UrunHareket> UrunHareketleri = new List<UrunHareket>();
        private string seciliMasa;
        
        public Form2()
        {
            InitializeComponent();
            Urunler.Add(new Urun
            {
                Id = 1,
                UrunKodu = "1",
                UrunAdi = "Paça",
                Birimi = "Porsiyon",
                Fiyat = 20
            });
            Urunler.Add(new Urun
            {
                Id = 48,
                UrunKodu = "48",
                UrunAdi = "Az paça",
                Birimi = "Porsiyon",
                Fiyat = 15
            });
            Urunler.Add(new Urun
            {
                Id = 2,
                UrunKodu = "2",
                UrunAdi = "Ezo",
                Birimi = "Porsiyon",
                Fiyat = 15
            });
            Urunler.Add(new Urun
            {
                Id = 49,
                UrunKodu = "49",
                UrunAdi = "Az ezo",
                Birimi = "Porsiyon",
                Fiyat = 10
            });
            Urunler.Add(new Urun
            {
                Id = 3,
                UrunKodu = "3",
                UrunAdi = "Döner ekmek",
                Birimi = "Porsiyon",
                Fiyat = 25
            });
            Urunler.Add(new Urun
            {
                Id = 4,
                UrunKodu = "4",
                UrunAdi = "150 döner ekmek",
                Birimi = "Porsiyon",
                Fiyat = 37
            });
            Urunler.Add(new Urun
            {
                Id = 5,
                UrunKodu = "5",
                UrunAdi = "Az pilav üstü 100 döner",
                Birimi = "Porsiyon",
                Fiyat = 40
            });
            Urunler.Add(new Urun
            {
                Id = 6,
                UrunKodu = "6",
                UrunAdi = "Tam pilav üstü 100 döner",
                Birimi = "Porsiyon",
                Fiyat = 45
            });
            Urunler.Add(new Urun
            {
                Id = 7,
                UrunKodu = "7",
                UrunAdi = "Az pilav üstü 150 döner",
                Birimi = "Porsiyon",
                Fiyat = 52
            });
            Urunler.Add(new Urun
            {
                Id = 8,
                UrunKodu = "8",
                UrunAdi = "Tam pilav üstü 150 döner",
                Birimi = "Porsiyon",
                Fiyat = 57
            });
            Urunler.Add(new Urun
            {
                Id = 9,
                UrunKodu = "9",
                UrunAdi = "Az pilav",
                Birimi = "Porsiyon",
                Fiyat = 15
            });
            Urunler.Add(new Urun
            {
                Id = 10,
                UrunKodu = "10",
                UrunAdi = "Tam pilav",
                Birimi = "Porsiyon",
                Fiyat = 20
            });
            Urunler.Add(new Urun
            {
                Id = 11,
                UrunKodu = "11",
                UrunAdi = "Pilav üstü kuru",
                Birimi = "Porsiyon",
                Fiyat = 25
            });
            Urunler.Add(new Urun
            {
                Id = 12,
                UrunKodu = "12",
                UrunAdi = "Az yemek",
                Birimi = "Porsiyon",
                Fiyat = 30
            });
            Urunler.Add(new Urun
            {
                Id = 13,
                UrunKodu = "13",
                UrunAdi = "Tam yemek",
                Birimi = "Porsiyon",
                Fiyat = 40
            });
            Urunler.Add(new Urun
            {
                Id = 50,
                UrunKodu = "50",
                UrunAdi = "Karışık yemek",
                Birimi = "Porsiyon",
                Fiyat = 45
            });
            Urunler.Add(new Urun
            {
                Id = 51,
                UrunKodu = "51",
                UrunAdi = "Az karışık yemek",
                Birimi = "Porsiyon",
                Fiyat = 35
            });
            Urunler.Add(new Urun
            {
                Id = 14,
                UrunKodu = "14",
                UrunAdi = "Az yemek üstü 100 döner",
                Birimi = "Porsiyon",
                Fiyat = 55
            });
            Urunler.Add(new Urun
            {
                Id = 15,
                UrunKodu = "15",
                UrunAdi = "Az yemek üstü 150 döner",
                Birimi = "Porsiyon",
                Fiyat = 67
            });
            Urunler.Add(new Urun
            {
                Id = 16,
                UrunKodu = "16",
                UrunAdi = "Tam yemek üstü 100 döner",
                Birimi = "Porsiyon",
                Fiyat = 65
            });
            Urunler.Add(new Urun
            {
                Id = 17,
                UrunKodu = "17",
                UrunAdi = "Tam yemek üstü 150 döner",
                Birimi = "Porsiyon",
                Fiyat = 77
            });
            Urunler.Add(new Urun
            {
                Id = 54,
                UrunKodu = "54",
                UrunAdi = "Az karışık üstü 100 döner",
                Birimi = "Porsiyon",
                Fiyat = 60
            });
            Urunler.Add(new Urun
            {
                Id = 17,
                UrunKodu = "17",
                UrunAdi = "Tam karışık üstü 100 döner",
                Birimi = "Porsiyon",
                Fiyat = 70
            });
            Urunler.Add(new Urun
            {
                Id = 52,
                UrunKodu = "52",
                UrunAdi = "Az karışık üstü 150 döner",
                Birimi = "Porsiyon",
                Fiyat = 72
            });
            Urunler.Add(new Urun
            {
                Id = 53,
                UrunKodu = "53",
                UrunAdi = "Tam karışık üstü 150 döner",
                Birimi = "Porsiyon",
                Fiyat = 82
            });
            Urunler.Add(new Urun
            {
                Id = 19,
                UrunKodu = "19",
                UrunAdi = "Lahmacun",
                Birimi = "Porsiyon",
                Fiyat = 13
            });
            Urunler.Add(new Urun
            {
                Id = 20,
                UrunKodu = "20",
                UrunAdi = "Peynirli pide",
                Birimi = "Porsiyon",
                Fiyat = 40
            });
            Urunler.Add(new Urun
            {
                Id = 21,
                UrunKodu = "21",
                UrunAdi = "Peynirli pide 1.5",
                Birimi = "Porsiyon",
                Fiyat = 60
            });
            Urunler.Add(new Urun
            {
                Id = 22,
                UrunKodu = "22",
                UrunAdi = "Kavurmalı pide",
                Birimi = "Porsiyon",
                Fiyat = 45
            });
            Urunler.Add(new Urun
            {
                Id = 23,
                UrunKodu = "23",
                UrunAdi = "Kavurmalı pide 1.5",
                Birimi = "Porsiyon",
                Fiyat = 67
            });
            Urunler.Add(new Urun
            {
                Id = 24,
                UrunKodu = "24",
                UrunAdi = "Kıymalı pide",
                Birimi = "Porsiyon",
                Fiyat = 45
            });
            Urunler.Add(new Urun
            {
                Id = 25,
                UrunKodu = "25",
                UrunAdi = "Kıymalı pide 1.5",
                Birimi = "Porsiyon",
                Fiyat = 67
            });
            Urunler.Add(new Urun
            {
                Id = 26,
                UrunKodu = "26",
                UrunAdi = "Kuşbaşılı pide",
                Birimi = "Porsiyon",
                Fiyat = 45
            });
            Urunler.Add(new Urun
            {
                Id = 27,
                UrunKodu = "27",
                UrunAdi = "Kuşbaşılı pide 1.5",
                Birimi = "Porsiyon",
                Fiyat = 67
            });
            Urunler.Add(new Urun
            {
                Id = 28,
                UrunKodu = "28",
                UrunAdi = "Karışık pide",
                Birimi = "Porsiyon",
                Fiyat = 45
            });
            Urunler.Add(new Urun
            {
                Id = 29,
                UrunKodu = "29",
                UrunAdi = "Karışık pide 1.5",
                Birimi = "Porsiyon",
                Fiyat = 67
            });
            Urunler.Add(new Urun
            {
                Id = 30,
                UrunKodu = "30",
                UrunAdi = "Sütlaç",
                Birimi = "Porsiyon",
                Fiyat = 20
            });
            Urunler.Add(new Urun
            {
                Id = 31,
                UrunKodu = "31",
                UrunAdi = "Antep baklava",
                Birimi = "Porsiyon",
                Fiyat = 25
            });
            Urunler.Add(new Urun
            {
                Id = 32,
                UrunKodu = "32",
                UrunAdi = "Antep kadayıf",
                Birimi = "Porsiyon",
                Fiyat = 30
            });
            Urunler.Add(new Urun
            {
                Id = 33,
                UrunKodu = "33",
                UrunAdi = "Antep midye",
                Birimi = "Porsiyon",
                Fiyat = 30
            });
            Urunler.Add(new Urun
            {
                Id = 34,
                UrunKodu = "34",
                UrunAdi = "Cemil usta baklava",
                Birimi = "Porsiyon",
                Fiyat = 20
            });
            Urunler.Add(new Urun
            {
                Id = 35,
                UrunKodu = "35",
                UrunAdi = "Su",
                Birimi = "Porsiyon",
                Fiyat = 2
            });
            Urunler.Add(new Urun
            {
                Id = 36,
                UrunKodu = "36",
                UrunAdi = "Büyük ayran",
                Birimi = "Porsiyon",
                Fiyat = 5
            });
            Urunler.Add(new Urun
            {
                Id = 37,
                UrunKodu = "37",
                UrunAdi = "Küçük ayran",
                Birimi = "Porsiyon",
                Fiyat = 3
            });
            Urunler.Add(new Urun
            {
                Id = 38,
                UrunKodu = "38",
                UrunAdi = "Kutu kola",
                Birimi = "Porsiyon",
                Fiyat = 10
            });
            Urunler.Add(new Urun
            {
                Id = 39,
                UrunKodu = "39",
                UrunAdi = "Cam kola",
                Birimi = "Porsiyon",
                Fiyat = 7
            });
            Urunler.Add(new Urun
            {
                Id = 40,
                UrunKodu = "40",
                UrunAdi = "1 lt kola",
                Birimi = "Porsiyon",
                Fiyat = 10
            });
            Urunler.Add(new Urun
            {
                Id = 41,
                UrunKodu = "41",
                UrunAdi = "2.5 lt kola",
                Birimi = "Porsiyon",
                Fiyat = 15
            });
            Urunler.Add(new Urun
            {
                Id = 42,
                UrunKodu = "42",
                UrunAdi = "Kutu fanta",
                Birimi = "Porsiyon",
                Fiyat = 10
            });
            Urunler.Add(new Urun
            {
                Id = 43,
                UrunKodu = "43",
                UrunAdi = "Cam fanta",
                Birimi = "Porsiyon",
                Fiyat = 7
            });
            Urunler.Add(new Urun
            {
                Id = 44,
                UrunKodu = "44",
                UrunAdi = "1 lt fanta",
                Birimi = "Porsiyon",
                Fiyat = 10
            });
            Urunler.Add(new Urun
            {
                Id = 45,
                UrunKodu = "45",
                UrunAdi = "2.5 lt fanta",
                Birimi = "Porsiyon",
                Fiyat = 15
            });
            Urunler.Add(new Urun
            {
                Id = 46,
                UrunKodu = "46",
                UrunAdi = "Meyve suyu",
                Birimi = "Porsiyon",
                Fiyat = 10
            });
            Urunler.Add(new Urun
            {
                Id = 47,
                UrunKodu = "47",
                UrunAdi = "Soda",
                Birimi = "Porsiyon",
                Fiyat = 4
            });
            Masalar.Add(new Masa
            {
                Id = 1,
                MasaKodu = "1",
                MasaAdi = "Masa-1",
            });
            Masalar.Add(new Masa
            {
                Id = 2,
                MasaKodu = "2",
                MasaAdi = "Masa-2",
            });
            Masalar.Add(new Masa
            {
                Id = 3,
                MasaKodu = "3",
                MasaAdi = "Masa-3",
            });
            Masalar.Add(new Masa
            {
                Id = 4,
                MasaKodu = "4",
                MasaAdi = "Masa-4",
            });
            Masalar.Add(new Masa
            {
                Id = 5,
                MasaKodu = "5",
                MasaAdi = "Masa-5",
            });
            Masalar.Add(new Masa
            {
                Id = 6,
                MasaKodu = "6",
                MasaAdi = "Masa-Ön-1",
            });
            Masalar.Add(new Masa
            {
                Id = 7,
                MasaKodu = "7",
                MasaAdi = "Masa-Ön-2",
            });
            Masalar.Add(new Masa
            {
                Id = 8,
                MasaKodu = "8",
                MasaAdi = "Masa-Arka-1",
            });
            Masalar.Add(new Masa
            {
                Id = 9,
                MasaKodu = "9",
                MasaAdi = "Masa-Arka-2",
            });
            Masalar.Add(new Masa
            {
                Id = 10,
                MasaKodu = "10",
                MasaAdi = "Masa-Arka-3",
            });
            Masalar.Add(new Masa
            {
                Id = 11,
                MasaKodu = "11",
                MasaAdi = "Masa-Arka-4",
            });
            Masalar.Add(new Masa
            {
                Id = 12,
                MasaKodu = "12",
                MasaAdi = "Masa-Arka-5",
            });
            Masalar.Add(new Masa
            {
                Id = 13,
                MasaKodu = "13",
                MasaAdi = "Sipariş-1",
            });
            Masalar.Add(new Masa
            {
                Id = 14,
                MasaKodu = "14",
                MasaAdi = "Sipariş-2",
            });
            Masalar.Add(new Masa
            {
                Id = 15,
                MasaKodu = "15",
                MasaAdi = "Sipariş-3",
            });
            Masalar.Add(new Masa
            {
                Id = 16,
                MasaKodu = "16",
                MasaAdi = "Sipariş-4",
            });
            Masalar.Add(new Masa
            {
                Id = 17,
                MasaKodu = "17",
                MasaAdi = "Sipariş-5",
            });
            Masalar.Add(new Masa
            {
                Id = 18,
                MasaKodu = "18",
                MasaAdi = "Sipariş-6",
            });
            ButonOlustur();
            gridControl1.DataSource = UrunHareketleri;
        }
        private void ButonOlustur()
        {
            foreach (var masa in Masalar)
            {
                Button masaButon = new Button
                {
                    Name = masa.MasaKodu,
                    Text = masa.MasaAdi,
                    Height = 80,
                    Width = 80,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.Green,
                };
                flowMasalar.Controls.Add(masaButon);
                masaButon.Click += Masa_Click;
            }
            foreach (var urun in Urunler)
            {
                Button urunButon = new Button
                {
                    Name = urun.UrunKodu,
                    Text = urun.UrunAdi,
                    Height = 80,
                    Width = 80,
                    FlatStyle= FlatStyle.Flat,
                    BackColor= Color.Yellow,
                };
                flowUrunler.Controls.Add(urunButon);
                urunButon.Click += Urun_Click;
            }
        }

        private void Masa_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            Masa masa = Masalar.SingleOrDefault(c => c.MasaKodu == button.Name);
            if (masa.Hareketler == null)
            {
                masa.Hareketler = new List<UrunHareket>();
            }
            seciliMasa = masa.MasaKodu;
            gridControl1.DataSource = masa.Hareketler;
            txtToplam.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);

        }

        private void Urun_Click(object? sender, EventArgs e)
        {
            Button button = (Button)sender;
            Urun urun = Urunler.SingleOrDefault(c => c.UrunKodu == button.Name);
            Masalar.SingleOrDefault(c => c.MasaKodu == seciliMasa).Hareketler.Add(new UrunHareket
            {
                UrunKodu = urun.UrunKodu,
                UrunAdi = urun.UrunAdi,
                Biriimi = urun.Birimi,
                Fiyat = urun.Fiyat,
                Miktar = 1
            });
            gridView1.RefreshData();
            Button button1 = (Button)flowMasalar.Controls.Find(seciliMasa, true).SingleOrDefault();
            button1.BackColor = Color.Red;
            txtToplam.Value = Convert.ToDecimal(colToplam.SummaryItem.SummaryValue);

         
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            Button button1 = (Button)flowMasalar.Controls.Find(seciliMasa, true).SingleOrDefault();
            button1.BackColor = Color.Green;
            var masa = Masalar.SingleOrDefault(c=>c.MasaKodu==button1.Name);
            masa.Hareketler = new List<UrunHareket>();
            gridControl1.DataSource = masa.Hareketler;
            txtToplam.Value = 0;
        }

        PrintDialog PRD=new PrintDialog();
        private void simpleButton1_Click(object sender, EventArgs e)
        {

            PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
            link.Component = gridControl1;
            link.Landscape = true;
            link.ShowPreview();
        }
    }
}
