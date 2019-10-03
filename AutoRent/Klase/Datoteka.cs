using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace AutoRent
{
    public class Datoteka
    {
        public static void Upisi(string ime_datoteke, object o)
        {
            try
            {
                FileStream fs = new FileStream(ime_datoteke, FileMode.Create);                
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, o);
                fs.Flush();
                fs.Close();
                MessageBox.Show("Uspesno snimljeni podaci. ","Snimanje datoteke");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        

        public static object Procitaj(string ime_datoteke)
        {
            object o;
            if (!File.Exists(ime_datoteke))
            {
                return null;
            }

            try
            {
                FileStream fs = new FileStream(ime_datoteke, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();               
                o = bf.Deserialize(fs);
                fs.Flush();
                fs.Close();
                return o;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
