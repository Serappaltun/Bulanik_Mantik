using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Bulanik_Mantik
{
    public partial class Form1 : Form
    {
       
        public double girilen_sicaklik;
        public double girilen_seviye;
        public string Sicaklik_Giris_Degiskeni_Sonuc;
        public string Seviye_Giris_Degiskeni_Sonuc;
        public string Rezistans_Cikis_Degiskeni_Sonuc;
        public double Sonuc;
        public double rezistans;
        public  double X1;
        public  double X2;
        public double rezistans_son;
        public int seviye_eleman;
        public int sicaklik_eleman;

      
        ArrayList Sicaklik_Dizi = new ArrayList();
        ArrayList Seviye_Dizi = new ArrayList();
        ArrayList Rezistans_Dizi = new ArrayList();
        ArrayList Sicaklik_Araligi_Dizi = new ArrayList();
        ArrayList Seviye_Araligi_Dizi = new ArrayList();
        ArrayList Kesisen_Dizi_Rezistans = new ArrayList();
        ArrayList Kesisen_Dizi_Sicaklik = new ArrayList();
        ArrayList Kesisen_Dizi_Seviye = new ArrayList();
	
       

       
       
        #region girilen sıcaklık değerinin hangi aralığa ne kadar üye olduğu
        public string Sicaklik_Derece()
      
        {
            girilen_sicaklik = Convert.ToDouble(txtSicaklik.Text);
           
            if (0 <= girilen_sicaklik && girilen_sicaklik  <= 20)
            {
                Sicaklik_Giris_Degiskeni_Sonuc = "Çok Düşük";
                Sicaklik_Araligi_Dizi.Add(Sicaklik_Giris_Degiskeni_Sonuc);
               

                if (girilen_sicaklik < 0 && girilen_sicaklik >20)
                {
                    Sonuc = 0;
                    Sicaklik_Dizi.Add(Sonuc);
                }

                if (0 <= girilen_sicaklik && girilen_sicaklik < 10)
                {
                    Sonuc = 1;
                    Sicaklik_Dizi.Add(Sonuc);
               }
               

                if (10 <= girilen_sicaklik && girilen_sicaklik <= 20)
                {
                    Sonuc = (20 - girilen_sicaklik) / 10;
                    Sicaklik_Dizi.Add(Sonuc);
                }
                               
                
            }

            if (15 <= girilen_sicaklik && girilen_sicaklik <= 40)
            {
                Sicaklik_Giris_Degiskeni_Sonuc = "Düşük";
                Sicaklik_Araligi_Dizi.Add(Sicaklik_Giris_Degiskeni_Sonuc);
                

                if (girilen_sicaklik < 15 && girilen_sicaklik > 40)
                {
                    Sonuc = 0;
                    Sicaklik_Dizi.Add(Sonuc);
                }

                
                if (15 <= girilen_sicaklik && girilen_sicaklik < 27.5)
                {
                    Sonuc = (girilen_sicaklik-15) / 12.5;
                    Sicaklik_Dizi.Add(Sonuc);
                }


                if (27.5 <= girilen_sicaklik && girilen_sicaklik <= 40)
                {
                    Sonuc = (40 - girilen_sicaklik) / 12.5;
                    Sicaklik_Dizi.Add(Sonuc);
                }

               
            }

            if (35 <= girilen_sicaklik && girilen_sicaklik <= 60)
            {
                Sicaklik_Giris_Degiskeni_Sonuc = "Orta";
                Sicaklik_Araligi_Dizi.Add(Sicaklik_Giris_Degiskeni_Sonuc);
                

                if (girilen_sicaklik < 35 && girilen_sicaklik > 60)
                {
                    Sonuc = 0;
                    Sicaklik_Dizi.Add(Sonuc);
                }

                if (35 <= girilen_sicaklik && girilen_sicaklik < 47.5)
                {
                    Sonuc = (girilen_sicaklik - 35) / 12.5;
                    Sicaklik_Dizi.Add(Sonuc);
                }


                if (47.5 <= girilen_sicaklik && girilen_sicaklik <= 60)
                {
                    Sonuc = (60 - girilen_sicaklik) / 12.5;
                    Sicaklik_Dizi.Add(Sonuc);
                }
            }

            if (55 <= girilen_sicaklik && girilen_sicaklik <= 80)
            {
                Sicaklik_Giris_Degiskeni_Sonuc = "Yüksek";
                Sicaklik_Araligi_Dizi.Add(Sicaklik_Giris_Degiskeni_Sonuc);
                

                if (girilen_sicaklik < 55 && girilen_sicaklik > 80)
                {
                    Sonuc = 0;
                    Sicaklik_Dizi.Add(Sonuc);
                }

                if (55 <= girilen_sicaklik && girilen_sicaklik < 67.5)
                {
                    Sonuc = (girilen_sicaklik - 55) / 12.5;
                    Sicaklik_Dizi.Add(Sonuc);
                }


                if (67.5 <= girilen_sicaklik && girilen_sicaklik <= 80)
                {
                    Sonuc = (80 - girilen_sicaklik) / 12.5;
                    Sicaklik_Dizi.Add(Sonuc);
                }
            }

            if (75 <= girilen_sicaklik && girilen_sicaklik <= 100)
            {
                Sicaklik_Giris_Degiskeni_Sonuc = "Çok Yüksek";
                Sicaklik_Araligi_Dizi.Add(Sicaklik_Giris_Degiskeni_Sonuc);
                

                if (girilen_sicaklik < 75 && girilen_sicaklik > 100)
                {
                    Sonuc = 0;
                    Sicaklik_Dizi.Add(Sonuc);
                }

                if (75 <= girilen_sicaklik && girilen_sicaklik < 80)
                {
                    Sonuc = (100 - girilen_sicaklik) / 12.5;
                    Sicaklik_Dizi.Add(Sonuc);
                }


                if (80 <= girilen_sicaklik && girilen_sicaklik <= 100)
                {
                    Sonuc = 1;
                    Sicaklik_Dizi.Add(Sonuc);
                }

               

            }
           
           return Sonuc.ToString();
            
     }
        #endregion

        #region girilen seviye değerinin hangi aralığa ne kadar üye olduğu
        public string Seviye_Degeri()
        {
            //girilen_seviye = double.Parse(txtSeviye.Text);
            girilen_seviye = Convert.ToDouble(txtSeviye.Text);
            //float a = float.Parse(txtSeviye.Text);
            //girilen_seviye = Convert.ToDouble(a);
            if (0 <= girilen_seviye && girilen_seviye <= 1)
            {
                Seviye_Giris_Degiskeni_Sonuc = "Çok Düşük";
                Seviye_Araligi_Dizi.Add(Seviye_Giris_Degiskeni_Sonuc);
            

                if (girilen_seviye < 0 && girilen_seviye>1)
                {
                    Sonuc = 0;
                    Seviye_Dizi.Add(Sonuc); 
                }

                if (0 <= girilen_seviye && girilen_seviye < 0.25)
                {
                    Sonuc = 1;
                    Seviye_Dizi.Add(Sonuc); 
                }


                if (0.25 <= girilen_seviye && girilen_seviye <= 1)
                {
                    Sonuc = (1 - girilen_seviye) / 0.75;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a); 
                }

               
            }

            if (0.5 <= girilen_seviye && girilen_seviye < 2)
            {
                Seviye_Giris_Degiskeni_Sonuc = "Düşük";
                Seviye_Araligi_Dizi.Add(Seviye_Giris_Degiskeni_Sonuc);
                

                if (girilen_seviye < 0.5 && girilen_seviye > 2)
                {
                    Sonuc = 0;
                    Seviye_Dizi.Add(Sonuc); 
                }

                if (0.5 <= girilen_seviye && girilen_seviye < 1.25)
                {
                    Sonuc = (girilen_seviye - 0.5) / 0.75;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a); 
                }


                if (1.25 <= girilen_seviye && girilen_seviye < 2)
                {
                    Sonuc = (2 - girilen_seviye) / 0.75;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a);  
                }


            }

            if (1.5 <= girilen_seviye && girilen_seviye <3.5)
            {
                Seviye_Giris_Degiskeni_Sonuc = "Orta";
                Seviye_Araligi_Dizi.Add(Seviye_Giris_Degiskeni_Sonuc);
                

                if (girilen_seviye < 1.5 && girilen_seviye > 3.5)
                {
                    Sonuc = 0;
                    Seviye_Dizi.Add(Sonuc); 
                }

                if (1.5 <= girilen_seviye && girilen_seviye < 2.5)
                {
                    Sonuc = (girilen_seviye - 1.5) / 1;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a);  
                }


                if (2.5 <= girilen_seviye && girilen_seviye < 3.5)
                {
                    Sonuc = (3.5 - girilen_seviye) / 1;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a); 
                }
            }

            if (3 <= girilen_seviye && girilen_seviye < 4.5)
            {
                Seviye_Giris_Degiskeni_Sonuc = "Yüksek";
                Seviye_Araligi_Dizi.Add(Seviye_Giris_Degiskeni_Sonuc);
                

                if (girilen_seviye < 3 && girilen_seviye > 4.5)
                {
                    Sonuc = 0;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a); 
                }

                if (3 <= girilen_seviye && girilen_seviye < 3.75)
                {
                    Sonuc = (girilen_seviye - 3) / 0.75;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a);  
                }


                if (3.75 <= girilen_seviye && girilen_seviye < 4.5)
                {
                    Sonuc = (4.5 - girilen_seviye) / 0.75;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a); 
                }
            }

            if (4 <= girilen_seviye && girilen_seviye < 5)
            {
                Seviye_Giris_Degiskeni_Sonuc = "Çok Yüksek";
                Seviye_Araligi_Dizi.Add(Seviye_Giris_Degiskeni_Sonuc);
                

                if (girilen_seviye < 4 && girilen_seviye > 5)
                {
                    Sonuc = 0;
                    Seviye_Dizi.Add(Sonuc); 
                }

                if (4 <= girilen_seviye && girilen_seviye < 4.5)
                {
                    Sonuc = (girilen_seviye - 4) / 0.5;
                    Seviye_Dizi.Add(Sonuc); 
                }


                if (4.5 <= girilen_seviye && girilen_seviye < 5)
                {
                    Sonuc = 1;
                    string a = String.Format("{0:0.00}", Sonuc);
                    Seviye_Dizi.Add(a);  
                }
            }

            return Sonuc.ToString();
          
        }
        #endregion

        #region sıcaklık ve seviyeye göre rezistans aralığını bulma
        public string Rezistans_Araligi(string Sicaklik_Giris_Degiskeni_Sonuc, string Seviye_Giris_Degiskeni_Sonuc)
        {
            if (Sicaklik_Giris_Degiskeni_Sonuc == "Çok Düşük")
            {
                if (Seviye_Giris_Degiskeni_Sonuc == "Çok Düşük")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Orta";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Düşük")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Çok";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Orta")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Aşırı Çok";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Yüksek")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Aşırı Çok";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Çok Yüksek")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Aşırı Çok";
                }

                //return Rezistans_Cikis_Degiskeni_Sonuc;
            }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Düşük")
            {
                if (Seviye_Giris_Degiskeni_Sonuc == "Çok Düşük")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Az";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Düşük")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Orta";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Orta")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Çok";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Yüksek")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Çok";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Çok Yüksek")
                {
                    Rezistans_Cikis_Degiskeni_Sonuc = "Çok";
                }
                //return Rezistans_Cikis_Degiskeni_Sonuc;
            }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Orta")
            {
                if (Seviye_Giris_Degiskeni_Sonuc == "Çok Düşük")
                {
                   Rezistans_Cikis_Degiskeni_Sonuc = "Çok Az";
                }

                if (Seviye_Giris_Degiskeni_Sonuc == "Düşük")
               {
                   Rezistans_Cikis_Degiskeni_Sonuc = "Çok Az";
               }

               if (Seviye_Giris_Degiskeni_Sonuc == "Orta")
               {
                   Rezistans_Cikis_Degiskeni_Sonuc = "Orta";
               }

               if (Seviye_Giris_Degiskeni_Sonuc == "Yüksek")
               {
                   Rezistans_Cikis_Degiskeni_Sonuc = "Çok";
               }

               if (Seviye_Giris_Degiskeni_Sonuc == "Çok Yüksek")
              {
                  Rezistans_Cikis_Degiskeni_Sonuc = "Çok";
              }

                   // return Rezistans_Cikis_Degiskeni_Sonuc;
           }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Yüksek")
                {
                    if (Seviye_Giris_Degiskeni_Sonuc == "Çok Düşük")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çıkışta hareket yok";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Düşük")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çok Az";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Orta")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çok Az";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Yüksek")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Az";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Çok Yüksek")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Orta";
                    }

                    //return Rezistans_Cikis_Degiskeni_Sonuc;
                }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Çok Yüksek")
                {
                    if (Seviye_Giris_Degiskeni_Sonuc == "Çok Düşük")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çıkışta hareket yok";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Düşük")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çıkışta hareket yok";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Orta")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çıkışta hareket yok";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Yüksek")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çıkışta hareket yok";
                    }

                    if (Seviye_Giris_Degiskeni_Sonuc == "Çok Yüksek")
                    {
                        Rezistans_Cikis_Degiskeni_Sonuc = "Çıkışta hareket yok";
                    }

                    //return Rezistans_Cikis_Degiskeni_Sonuc;
                }
            
            txtrezistansaraligi.Text = Rezistans_Cikis_Degiskeni_Sonuc;
            return Rezistans_Cikis_Degiskeni_Sonuc;
            }
          
        
        #endregion

        #region rezistans değerinin bulunan aralığa ne kadar üye olduğu
        public string Rezistans_Degeri()
        {

            if (0 <= rezistans && rezistans <= 1)
            {
                Rezistans_Cikis_Degiskeni_Sonuc = "Çok Az";
               

                if (rezistans < 0 && rezistans > 1)
                {
                    Sonuc = 0;
                }

                if (0 <= rezistans && rezistans < 0.25)
                {
                    Sonuc = 1;
                }


                if (0.25 <= rezistans && rezistans <= 1)
                {
                    Sonuc = (1 - rezistans) / 0.75;
                }


            }

            if (0.5 < rezistans && rezistans <= 2)
            {
                Rezistans_Cikis_Degiskeni_Sonuc = "Az";
              
                if (rezistans < 0.5 && rezistans > 2)
                {
                    Sonuc = 0;
                }

                if (0.5 < rezistans && rezistans < 1.25)
                {
                    Sonuc = (rezistans - 0.5) / 0.75;
                }


                if (1.25 <= rezistans && rezistans <= 2)
                {
                    Sonuc = (2 - rezistans) / 0.75;
                }

               

            }

            if (1.5 <= rezistans && rezistans <= 3.5)
            {
                Rezistans_Cikis_Degiskeni_Sonuc = "Orta";
              
                if (rezistans < 1.5 && rezistans > 3.5)
                {
                    Sonuc = 0;
                }

                if (1.5 <= rezistans && rezistans < 2.5)
                {
                    Sonuc = (rezistans - 1.5) / 1;
                }


                if (2.5 <= rezistans && rezistans <= 3.5)
                {
                    Sonuc = (3.5 - rezistans) / 1;
                }
            }

            if (3 <= rezistans && rezistans <= 4.5)
            {
                Rezistans_Cikis_Degiskeni_Sonuc = "Çok";
               
                if (rezistans < 3 && rezistans > 4.5)
                {
                    Sonuc = 0;
                }

                if (3 <= rezistans && rezistans < 3.75)
                {
                    Sonuc = (rezistans - 3) / 0.75;
                }


                if (3.75 <= rezistans && rezistans <= 4.5)
                {
                    Sonuc = (4.5 - rezistans) / 0.75;
                }
            }

            if (4 <= rezistans && rezistans <= 5)
            {
                Rezistans_Cikis_Degiskeni_Sonuc = "Aşırı Çok";
              
                if (rezistans < 4 && rezistans > 5)
                {
                    Sonuc = 0;
                }

                if (4 <= rezistans && rezistans < 4.5)
                {
                    Sonuc = (rezistans - 4) / 0.5;
                }


                if (4.5 <= rezistans && rezistans <= 5)
                {
                    Sonuc = 1;
                }
            }


            txtRezistans.Text = rezistans.ToString();
            return Sonuc.ToString();

        }
        #endregion

        #region Kesişme Sıcaklık

        public static void Kesisme_Sicaklik(double rezistans, string Sicaklik_Giris_Degiskeni_Sonuc, ref double X1, ref double X2)
        {
            ArrayList Kesisen_Dizi_Sicaklik = new ArrayList();

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Çok Düşük")
            {
                X1 = 0;// (rezistans * 10) + 0;
                X2 = 20 - (rezistans * 10);
                Kesisen_Dizi_Sicaklik.Add(X1);
                Kesisen_Dizi_Sicaklik.Add(X2);
            }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Düşük")
            {
                X1 = (rezistans * 12.5) + 15;
                X2 = 40 - (rezistans * 12.5);
                Kesisen_Dizi_Sicaklik.Add(X1);
                Kesisen_Dizi_Sicaklik.Add(X2);
            }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Orta")
            {
                X1 = (rezistans * 12.5) + 35;
                X2 = 60 - (rezistans * 12.5);
                Kesisen_Dizi_Sicaklik.Add(X1);
                Kesisen_Dizi_Sicaklik.Add(X2);
            }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Yüksek")
            {
                X1 = (rezistans * 12.5) + 55;
                X2 = 80 - (rezistans * 12.5);
                Kesisen_Dizi_Sicaklik.Add(X1);
                Kesisen_Dizi_Sicaklik.Add(X2);
            }

            if (Sicaklik_Giris_Degiskeni_Sonuc == "Çok Yüksek")
            {
                X1 = (rezistans * 12.5) + 75;
                X2 = 0;// 100 - (rezistans * 12.5);
                Kesisen_Dizi_Sicaklik.Add(X1);
                Kesisen_Dizi_Sicaklik.Add(X2);
            }

            

        }


        #endregion

        #region Kesişme Seviye
        public static void Kesisme_Seviye(double rezistans, string Seviye_Giris_Degiskeni_Sonuc, ref double X1, ref double X2)
        {
            ArrayList Kesisen_Dizi_Seviye = new ArrayList();

            if (Seviye_Giris_Degiskeni_Sonuc == "Çok Düşük")
            {
                X1 = 0;// (rezistans * 0.5) + 0;
                X2 = 1 - (rezistans *(1-0.25));
                Kesisen_Dizi_Seviye.Add(X1);
                Kesisen_Dizi_Seviye.Add(X2);
            }

            if (Seviye_Giris_Degiskeni_Sonuc == "Düşük")
            {
                X1 = (rezistans * (1.25-0.5)) + 0.5;
                X2 = 2- (rezistans *(2- 1.25));
                Kesisen_Dizi_Seviye.Add(X1);
                Kesisen_Dizi_Seviye.Add(X2);
            }

            if (Seviye_Giris_Degiskeni_Sonuc == "Orta")
            {
                X1 = (rezistans * 1) + 1.5;
                X2 = 3.5 - (rezistans * 1);
                Kesisen_Dizi_Seviye.Add(X1);
                Kesisen_Dizi_Seviye.Add(X2);
            }

            if (Seviye_Giris_Degiskeni_Sonuc == "Yüksek")
            {
                X1 = (rezistans * 0.75) + 3;
                X2 = 4.5 - (rezistans * 0.75);
                Kesisen_Dizi_Seviye.Add(X1);
                Kesisen_Dizi_Seviye.Add(X2);
            }

            if (Seviye_Giris_Degiskeni_Sonuc == "Çok Yüksek")
            {
                X1 = (rezistans * 0.5) + 4;
                X2 = 0;// 5 - (rezistans * 0.5);
                Kesisen_Dizi_Seviye.Add(X1);
                Kesisen_Dizi_Seviye.Add(X2);
            }



        }


        #endregion

        #region Kesişme Rezistans
        public static void Kesisme_Rezistans(double rezistans, string Rezistans_Cikis_Degiskeni_Sonuc, ref  double X1, ref  double X2)
        {
            if (Rezistans_Cikis_Degiskeni_Sonuc == "Çok Az")
            {
                X1 = 0;// (rezistans * 0.5) + 0;
                X2 = 1 - (rezistans * (1-0.25));
            }

            if (Rezistans_Cikis_Degiskeni_Sonuc == "Az")
            {
                X1 = (rezistans * (1.25 - 0.5)) + 0.5;
                X2 = 2 - (rezistans *(2- 1.25));
            }

            if (Rezistans_Cikis_Degiskeni_Sonuc == "Orta")
            {
                X1 = (rezistans *(2.5-1.5)) + 1.5;
                X2 = 3.5 - (rezistans * (3.5-2.5));
           }

            if (Rezistans_Cikis_Degiskeni_Sonuc == "Çok")
            {
                X1 = (rezistans * (3.75-3)) + 3;
                X2 = 4.5 - (rezistans * (4.5-3.75));
            }

            if (Rezistans_Cikis_Degiskeni_Sonuc == "Aşırı Çok")
            {
                X1 = (rezistans * (4.5-4)) + 4;
                X2 = 0;// 5 - (rezistans * 0.5);
            }
            
          
        
        }
        #endregion




        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       
        
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

       
      

        private void button1_Click(object sender, EventArgs e)
        {
           Sicaklik_Derece();
           Seviye_Degeri();
          

           int s = 0;

           #region Sıcaklık ve seviyeye göre rezistansın rakamsal çıkışı
               for (int i = 0; i < Sicaklik_Dizi.Count; i++)

                   for (int j = 0; j < Seviye_Dizi.Count; j++)
                   {

                       double aa = Convert.ToDouble(Sicaklik_Dizi[i]);
                       double bb = Convert.ToDouble(Seviye_Dizi[j]);

                       if (aa < bb)
                       {
                           Rezistans_Dizi.Add(aa.ToString());
                       }
                       else
                       {
                           Rezistans_Dizi.Add(bb.ToString());
                       }



                       listBox2.Items.Add("Eğer sıcaklık " + Sicaklik_Araligi_Dizi[i] + "(" + aa + ")" + " ve seviye " + Seviye_Araligi_Dizi[j] + "(" + bb + ")" + " ise rezistans " + Rezistans_Cikis_Degiskeni_Sonuc + "(" + Rezistans_Dizi[s].ToString() + ")");

                       s++;
                 }

                        Rezistans_Dizi.Sort();
                        int eleman = Rezistans_Dizi.Count-1;

                        rezistans = Convert.ToDouble(Rezistans_Dizi[eleman]);
                     
            #endregion

           #region rezistans garafiği ile rezistans çıkışının kesişme noktaları
           

            for (int i = 0; i < Sicaklik_Araligi_Dizi.Count ; i++)
                for (int j = 0; j <Seviye_Araligi_Dizi.Count ; j++)
                {
                    string a = Convert.ToString( Sicaklik_Araligi_Dizi[i]);
                    string b = Convert.ToString(Seviye_Araligi_Dizi[j]);
                    Rezistans_Araligi(a,b);
                   
                   
                    //rezistans çizgisi
                    Kesisme_Rezistans(rezistans, Rezistans_Cikis_Degiskeni_Sonuc, ref X1, ref X2);
                                       
                    Kesisen_Dizi_Rezistans.Add(X1);
                    Kesisen_Dizi_Rezistans.Add(X2);

                }

           #endregion

           #region Sıcaklık garafiği ile rezistans çıkışının kesişme noktaları

            for (int i = 0; i < Sicaklik_Araligi_Dizi.Count; i++)
            {
                string a = Convert.ToString(Sicaklik_Araligi_Dizi[i]);
                Kesisme_Sicaklik(rezistans, a, ref X1, ref X2);
                Kesisen_Dizi_Sicaklik.Add(X1);
                Kesisen_Dizi_Sicaklik.Add(X2);

            }
            #endregion

           #region Seviye garafiği ile rezistans çıkışının kesişme noktaları

            for (int i = 0; i < Seviye_Araligi_Dizi.Count ; i++)
            {
                string a = Convert.ToString(Seviye_Araligi_Dizi[i]);
                Kesisme_Seviye(rezistans, a, ref X1, ref X2);
                Kesisen_Dizi_Seviye.Add(X1);
                Kesisen_Dizi_Seviye.Add(X2);
            }
            #endregion

   
           txtRezistans.Text = rezistans.ToString();
           txtrezistansaraligi.Text = Rezistans_Cikis_Degiskeni_Sonuc;
      
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

       
        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }

        GraphPane myPane_Rezistans = new GraphPane();
        GraphPane myPane_Sicaklik = new GraphPane();
        GraphPane myPane_Seviye = new GraphPane();

               

        private void zedGraphControl1_DoubleClick(object sender, EventArgs e)
        {
            zedGraphControl1.ZoomOutAll(myPane_Rezistans);
        }


     
        private void button2_Click(object sender, EventArgs e)
        {

            #region sıcaklık grafik çizimi
            LineItem myCurve_Sicalik;

            myPane_Sicaklik = zedGraphControl2.GraphPane;

            myPane_Sicaklik.Title.Text = "Sıcaklık Değerleri";
            myPane_Sicaklik.XAxis.Title.Text = "Sıcaklık";
            myPane_Sicaklik.YAxis.Title.Text = " Üyelik Derecesi";

                        

            PointPairList p_Sicaklik = new PointPairList();

            p_Sicaklik.Add(0,1);
            p_Sicaklik.Add(10,1);
            p_Sicaklik.Add(20,0);
            p_Sicaklik.Add(15,0);
            p_Sicaklik.Add(27.5,1);
            p_Sicaklik.Add(40,0);
            p_Sicaklik.Add(35,0);
            p_Sicaklik.Add(47.5,1);
            p_Sicaklik.Add(60,0);
            p_Sicaklik.Add(55,0);
            p_Sicaklik.Add(67.5,1);
            p_Sicaklik.Add(80,0);
            p_Sicaklik.Add(75,0);
            p_Sicaklik.Add(87.5,1);
            p_Sicaklik.Add(100,1);

            PointPairList pp_Sicaklik = new PointPairList();



            if (Kesisen_Dizi_Sicaklik.Count == 2)
            {
                
                double sayi1 = Convert.ToDouble(Kesisen_Dizi_Sicaklik[0]);
                double sayi2 = Convert.ToDouble(Kesisen_Dizi_Sicaklik[1]);

                pp_Sicaklik.Add(0, rezistans);
                pp_Sicaklik.Add(sayi1, rezistans);
                pp_Sicaklik.Add(sayi1, 0);
                pp_Sicaklik.Add(sayi1, rezistans);
                pp_Sicaklik.Add(sayi2, rezistans);
                pp_Sicaklik.Add(sayi2, 0);
                pp_Sicaklik.Add(sayi2, rezistans);

            }

            else
            {
               

                double sayi1 = Convert.ToDouble(Kesisen_Dizi_Sicaklik[0]);
                double sayi2 = Convert.ToDouble(Kesisen_Dizi_Sicaklik[1]);
                double sayi3 = Convert.ToDouble(Kesisen_Dizi_Sicaklik[2]);
                double sayi4 = Convert.ToDouble(Kesisen_Dizi_Sicaklik[3]);


                pp_Sicaklik.Add(0, rezistans);
                pp_Sicaklik.Add(sayi1, rezistans);
                pp_Sicaklik.Add(sayi1, 0);
                pp_Sicaklik.Add(sayi1, rezistans);
                pp_Sicaklik.Add(sayi2, rezistans);
                pp_Sicaklik.Add(sayi2, 0);
                pp_Sicaklik.Add(sayi2, rezistans);


                pp_Sicaklik.Add(sayi3, rezistans);
                pp_Sicaklik.Add(sayi3, 0);
                pp_Sicaklik.Add(sayi3, rezistans);
                pp_Sicaklik.Add(sayi4, rezistans);
                pp_Sicaklik.Add(sayi4, 0);
                pp_Sicaklik.Add(sayi4, rezistans);


            }

            myCurve_Sicalik = myPane_Sicaklik.AddCurve("Üyelik Derecesi", p_Sicaklik, Color.Gray, SymbolType.None);
            myCurve_Sicalik = myPane_Sicaklik.AddCurve("Rezistans", pp_Sicaklik, Color.Red, SymbolType.None);
            myCurve_Sicalik.Line.Width = 0.7f;
            zedGraphControl2.GraphPane.YAxis.Scale.MaxAuto = true;

            
            zedGraphControl2.AxisChange();
           

            #endregion

            #region seviye grafik çizimi
            LineItem myCurve_Seviye;

            myPane_Seviye = zedGraphControl3.GraphPane;

            myPane_Seviye.Title.Text = "Seviye Değerleri";
            myPane_Seviye.XAxis.Title.Text = "Seviye";
            myPane_Seviye.YAxis.Title.Text = " Üyelik Derecesi";


            PointPairList p_Seviye = new PointPairList();

            p_Seviye.Add(0, 1);
            p_Seviye.Add(0.5, 1);
            p_Seviye.Add(1, 0);
            p_Seviye.Add(0.5, 0);
            p_Seviye.Add(1.25, 1);
            p_Seviye.Add(2, 0);
            p_Seviye.Add(1.5, 0);
            p_Seviye.Add(2.5, 1);
            p_Seviye.Add(3.5, 0);
            p_Seviye.Add(3, 0);
            p_Seviye.Add(3.75, 1);
            p_Seviye.Add(4.5, 0);
            p_Seviye.Add(4, 0);
            p_Seviye.Add(4.5, 1);
            p_Seviye.Add(5, 1);

            PointPairList pp_Seviye = new PointPairList();



            if (Kesisen_Dizi_Seviye.Count == 2)
            {

                double sayi1 = Convert.ToDouble(Kesisen_Dizi_Seviye[0]);
                double sayi2 = Convert.ToDouble(Kesisen_Dizi_Seviye[1]);

                pp_Seviye.Add(0, rezistans);
                pp_Seviye.Add(sayi1, rezistans);
                pp_Seviye.Add(sayi1, 0);
                pp_Seviye.Add(sayi1, rezistans);
                pp_Seviye.Add(sayi2, rezistans);
                pp_Seviye.Add(sayi2, 0);
                pp_Seviye.Add(sayi2, rezistans);

            }

            else
            {


                double sayi1 = Convert.ToDouble(Kesisen_Dizi_Seviye[0]);
                double sayi2 = Convert.ToDouble(Kesisen_Dizi_Seviye[1]);
                double sayi3 = Convert.ToDouble(Kesisen_Dizi_Seviye[2]);
                double sayi4 = Convert.ToDouble(Kesisen_Dizi_Seviye[3]);


                pp_Seviye.Add(0, rezistans);
                pp_Seviye.Add(sayi1, rezistans);
                pp_Seviye.Add(sayi1, 0);
                pp_Seviye.Add(sayi1, rezistans);
                pp_Seviye.Add(sayi2, rezistans);
                pp_Seviye.Add(sayi2, 0);
                pp_Seviye.Add(sayi2, rezistans);


                pp_Seviye.Add(sayi3, rezistans);
                pp_Seviye.Add(sayi3, 0);
                pp_Seviye.Add(sayi3, rezistans);
                pp_Seviye.Add(sayi4, rezistans);
                pp_Seviye.Add(sayi4, 0);
                pp_Seviye.Add(sayi4, rezistans);


            }

            myCurve_Seviye = myPane_Seviye.AddCurve("Üyelik Derecesi", p_Seviye, Color.Gray, SymbolType.None);
            myCurve_Seviye = myPane_Seviye.AddCurve("Rezistans", pp_Seviye, Color.Red, SymbolType.None);
            myCurve_Seviye.Line.Width = 0.7f;
            zedGraphControl3.GraphPane.YAxis.Scale.MaxAuto = true;


            zedGraphControl3.AxisChange();

            #endregion

            #region rezistans grafik çizimi
            LineItem myCurve_Rezistans;

            myPane_Rezistans = zedGraphControl1.GraphPane;

            myPane_Rezistans.Title.Text = "Rezistans Değerleri";
            myPane_Rezistans.XAxis.Title.Text = "Rezistans";
            myPane_Rezistans.YAxis.Title.Text = " Üyelik Derecesi";

            #region grafik ayarı

            //myPane_Rezistans.XAxis.Scale.Max = 1;
            //myPane_Rezistans.YAxis.Scale.Min = 0;
            //myPane_Rezistans.XAxis.Scale.MajorStep = 1;
            //myPane_Rezistans.YAxis.Scale.MajorStep = 0.1;

            //zedGraphControl1.IsShowHScrollBar = true;
            //zedGraphControl1.IsShowVScrollBar = true;
            //zedGraphControl1.IsAutoScrollRange = true;
            //zedGraphControl1.IsScrollY2 = true;

            

            //zedGraphControl1.Location = new Point(10, 10);
            //// Leave a small margin around the outside of the control
            //zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 20);


            //Rectangle formRect = this.ClientRectangle;
            //formRect.Inflate(-10, -10);

            //if (zedGraphControl1.Size != formRect.Size)
            //{
            //    zedGraphControl1.Location = formRect.Location;
            //    zedGraphControl1.Size = formRect.Size;
            //}


            
            //myPane_Rezistans.XAxis.MajorGrid.IsVisible = true;
            //myPane_Rezistans.YAxis.MajorGrid.IsVisible = true;
            //myPane_Rezistans.XAxis.MajorGrid.DashOff = 1;
            //myPane_Rezistans.YAxis.MajorGrid.DashOff = 1;

            //zedGraphControl1.Size = new System.Drawing.Size(400,400);


            //myPane.XAxis.Scale.MajorStep = 50;
            //zedGraphControl1.Location = new Point(0, 0);
            //zedGraphControl1.IsShowPointValues = true;           
            //zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);


            #endregion

            


            PointPairList p_Rezistans = new PointPairList();

            p_Rezistans.Add(0, 1);
            p_Rezistans.Add(0.5, 1);
            p_Rezistans.Add(1, 0);
            p_Rezistans.Add(0.5, 0);
            p_Rezistans.Add(1.25, 1);
            p_Rezistans.Add(2, 0);
            p_Rezistans.Add(1.5, 0);
            p_Rezistans.Add(2.5, 1);
            p_Rezistans.Add(3.5, 0);
            p_Rezistans.Add(3, 0);
            p_Rezistans.Add(3.75, 1);
            p_Rezistans.Add(4.5, 0);
            p_Rezistans.Add(4, 0);
            p_Rezistans.Add(4.5, 1);
            p_Rezistans.Add(5, 1);

            double Z;

            PointPairList pp_Rezistans = new PointPairList();
            if (Kesisen_Dizi_Rezistans.Count == 2)
            {
                double sayi1 = Convert.ToDouble(Kesisen_Dizi_Rezistans[0]);
                double sayi2 = Convert.ToDouble(Kesisen_Dizi_Rezistans[1]);

                pp_Rezistans.Add(0, rezistans);
                pp_Rezistans.Add(sayi1, rezistans);
                pp_Rezistans.Add(sayi1, 0);
                pp_Rezistans.Add(sayi1, rezistans);
                pp_Rezistans.Add(sayi2, rezistans);
                pp_Rezistans.Add(sayi2, 0);
                pp_Rezistans.Add(sayi2, rezistans);

               
                Z = ((sayi1 * rezistans) + (sayi2 * rezistans)) / (rezistans + rezistans);
                textBox1.Text = Z.ToString();
            }

            if (Kesisen_Dizi_Rezistans.Count == 4)
            {
                double sayi1 = Convert.ToDouble(Kesisen_Dizi_Rezistans[0]);
                double sayi2 = Convert.ToDouble(Kesisen_Dizi_Rezistans[1]);
                double sayi3 = Convert.ToDouble(Kesisen_Dizi_Rezistans[2]);
                double sayi4 = Convert.ToDouble(Kesisen_Dizi_Rezistans[3]);

                
                pp_Rezistans.Add(0, rezistans);
                pp_Rezistans.Add(sayi1, rezistans);
                pp_Rezistans.Add(sayi1, 0);
                pp_Rezistans.Add(sayi1, rezistans);
                pp_Rezistans.Add(sayi2, rezistans);
                pp_Rezistans.Add(sayi2, 0);
                pp_Rezistans.Add(sayi2, rezistans);


                pp_Rezistans.Add(sayi3, rezistans);
                pp_Rezistans.Add(sayi3, 0);
                pp_Rezistans.Add(sayi3, rezistans);
                pp_Rezistans.Add(sayi4, rezistans);
                pp_Rezistans.Add(sayi4, 0);
                pp_Rezistans.Add(sayi4, rezistans);


               
                Z = ((sayi1 * rezistans) + (sayi2 * rezistans) + (sayi3 * rezistans) + (sayi4 * rezistans) ) / (rezistans + rezistans + rezistans + rezistans );

                textBox1.Text = Z.ToString();
            }
            if (Kesisen_Dizi_Rezistans.Count == 6)
            {
                    double sayi1 = Convert.ToDouble(Kesisen_Dizi_Rezistans[0]);
                    double sayi2 = Convert.ToDouble(Kesisen_Dizi_Rezistans[1]);
                    double sayi3 = Convert.ToDouble(Kesisen_Dizi_Rezistans[2]);
                    double sayi4 = Convert.ToDouble(Kesisen_Dizi_Rezistans[3]);

                    double sayi5 = Convert.ToDouble(Kesisen_Dizi_Rezistans[4]);
                    double sayi6 = Convert.ToDouble(Kesisen_Dizi_Rezistans[5]);
                    


                    pp_Rezistans.Add(0, rezistans);
                    pp_Rezistans.Add(sayi1, rezistans);
                    pp_Rezistans.Add(sayi1, 0);
                    pp_Rezistans.Add(sayi1, rezistans);
                    pp_Rezistans.Add(sayi2, rezistans);
                    pp_Rezistans.Add(sayi2, 0);
                    pp_Rezistans.Add(sayi2, rezistans);


                    pp_Rezistans.Add(sayi3, rezistans);
                    pp_Rezistans.Add(sayi3, 0);
                    pp_Rezistans.Add(sayi3, rezistans);
                    pp_Rezistans.Add(sayi4, rezistans);
                    pp_Rezistans.Add(sayi4, 0);
                    pp_Rezistans.Add(sayi4, rezistans);


                    pp_Rezistans.Add(sayi5, rezistans);
                    pp_Rezistans.Add(sayi5, 0);
                    pp_Rezistans.Add(sayi5, rezistans);
                    pp_Rezistans.Add(sayi6, rezistans);
                    pp_Rezistans.Add(sayi6, 0);
                    pp_Rezistans.Add(sayi6, rezistans);

                    


                    Z = ((sayi1 * rezistans) + (sayi2 * rezistans) + (sayi3 * rezistans) + (sayi4 * rezistans) + (sayi5 * rezistans) + (sayi6 * rezistans) ) / (rezistans + rezistans + rezistans + rezistans + rezistans + rezistans );

                    textBox1.Text = Z.ToString();
                       
            }

            if (Kesisen_Dizi_Rezistans.Count == 8)
            {
                double sayi1 = Convert.ToDouble(Kesisen_Dizi_Rezistans[0]);
                double sayi2 = Convert.ToDouble(Kesisen_Dizi_Rezistans[1]);
                double sayi3 = Convert.ToDouble(Kesisen_Dizi_Rezistans[2]);
                double sayi4 = Convert.ToDouble(Kesisen_Dizi_Rezistans[3]);

                double sayi5 = Convert.ToDouble(Kesisen_Dizi_Rezistans[4]);
                double sayi6 = Convert.ToDouble(Kesisen_Dizi_Rezistans[5]);
                double sayi7 = Convert.ToDouble(Kesisen_Dizi_Rezistans[6]);
                double sayi8 = Convert.ToDouble(Kesisen_Dizi_Rezistans[7]);



                pp_Rezistans.Add(0, rezistans);
                pp_Rezistans.Add(sayi1, rezistans);
                pp_Rezistans.Add(sayi1, 0);
                pp_Rezistans.Add(sayi1, rezistans);
                pp_Rezistans.Add(sayi2, rezistans);
                pp_Rezistans.Add(sayi2, 0);
                pp_Rezistans.Add(sayi2, rezistans);


                pp_Rezistans.Add(sayi3, rezistans);
                pp_Rezistans.Add(sayi3, 0);
                pp_Rezistans.Add(sayi3, rezistans);
                pp_Rezistans.Add(sayi4, rezistans);
                pp_Rezistans.Add(sayi4, 0);
                pp_Rezistans.Add(sayi4, rezistans);


                pp_Rezistans.Add(sayi5, rezistans);
                pp_Rezistans.Add(sayi5, 0);
                pp_Rezistans.Add(sayi5, rezistans);
                pp_Rezistans.Add(sayi6, rezistans);
                pp_Rezistans.Add(sayi6, 0);
                pp_Rezistans.Add(sayi6, rezistans);

                pp_Rezistans.Add(sayi7, rezistans);
                pp_Rezistans.Add(sayi7, 0);
                pp_Rezistans.Add(sayi7, rezistans);
                pp_Rezistans.Add(sayi8, rezistans);
                pp_Rezistans.Add(sayi8, 0);
                pp_Rezistans.Add(sayi8, rezistans);




                Z = ((sayi1 * rezistans) + (sayi2 * rezistans) + (sayi3 * rezistans) + (sayi4 * rezistans) + (sayi5 * rezistans) + (sayi6 * rezistans) + (sayi7 * rezistans) + (sayi8 * rezistans)) / (rezistans + rezistans + rezistans + rezistans + rezistans + rezistans + rezistans + rezistans);

                textBox1.Text = Z.ToString();

            }
            

           

            myCurve_Rezistans = myPane_Rezistans.AddCurve("Sıcaklık",p_Rezistans, Color.Gray, SymbolType.None);
            myCurve_Rezistans = myPane_Rezistans.AddCurve("Rezistans", pp_Rezistans, Color.Red, SymbolType.None);

            myCurve_Rezistans.Line.Width = 0.7f;
            zedGraphControl1.GraphPane.YAxis.Scale.MaxAuto = true;

           
            zedGraphControl1.AxisChange();
            //zedGraphControl1.Invalidate();
            //zedGraphControl1.Refresh();

#endregion


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSicaklik_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

                     
        }
}
