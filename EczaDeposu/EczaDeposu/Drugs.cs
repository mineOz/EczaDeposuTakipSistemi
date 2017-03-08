using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaDeposu
{
    class Drugs
    {
        private String ilacAdi;
        private int adet;
        private float birimFiyat;
        private int barkodNo;

        public Drugs(String ilacAdi, int adet, float birimFiyat, int barkodNo)
        {
            this.setIlacAdi(ilacAdi);
            this.setAdet(adet);
            this.setBirimFiyat(birimFiyat);
            this.setBarkodNo(barkodNo);

        }
        public String getIlacAdi()
        {
            return this.ilacAdi;
        }
        public void setIlacAdi(String ilacAdi)
        {
            this.ilacAdi = ilacAdi;
        }
        public int getAdet()
        {
            return this.adet;
        }
        public void setAdet(int adet)
        {
            this.adet = adet;
        }
        public float getBirimFiyat()
        {
            return this.birimFiyat;
        }
        public void setBirimFiyat(float birimFiyat)
        {
            this.birimFiyat = birimFiyat;
        }
        public int getBarkodNo()
        {
            return this.barkodNo;
        }
        public void setBarkodNo(int barkodNo)
        {
            this.barkodNo = barkodNo;
        }
        

    }
}
