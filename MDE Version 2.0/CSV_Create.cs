using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDE_Version_2._0
{

    class CSV_Create
    {

        public void Create(string[] FileName)
        {
            var csvModels = new List<CsvModel>();
            var sqlitecore = new SqliteCore();

            foreach (var filename in FileName)
            {
                var result = sqlitecore.LoadTable(filename);

                foreach (DataRow resultItem in result.Rows)
                {
                    var csvmodel = new CsvModel
                    {
                        Anzahl = Convert.ToInt32(resultItem["Anzahl"]),
                        WarenbereichID = Convert.ToInt32(resultItem["WarenbereichID"]),
                        Warenbereich = Convert.ToString(resultItem["Warenbereich"]),
                        Ean = Convert.ToString(resultItem["EAN"]),
                        Artikelbezeichnung = Convert.ToString(resultItem["Artikelbez"])

                    };
                    csvModels.Add(csvmodel);

                }
            }
            GenerateFiles(csvModels);
        }

        private void GenerateFiles(List<CsvModel> csvModels)
        {

            var result = from csvModel in csvModels group csvModel by csvModel.WarenbereichID;
            var ID = new List<int>();


            foreach (var items in result)
            {
                ID.Add(items.Key);
            }
            foreach (int item in ID)
            {
                var result2 = from csvModel in csvModels where csvModel.WarenbereichID == item select csvModel;

                var FirstEntry = result2.First();

                CreateFiles(result2.ToList<CsvModel>(), FirstEntry.Warenbereich.ToString());
            }

        }

        private void CreateFiles(List<CsvModel> csvmodel, string FileName)
        {
            try
            {
                Directory.CreateDirectory(Environment.CurrentDirectory + "\\CSV").Create();
                var filename = FileName.Trim();
                filename = filename.Trim('\\');
                filename = filename.Replace('/', ' ');
                filename.Trim();
                if (FileName == "")
                {
                    filename = "Alpha - Ohne Warengruppe";
                }
                var streamwriter = new StreamWriter(Environment.CurrentDirectory + "/" + "CSV" + "/" + filename + ".csv");
                string stream = "";
                Debug.WriteLine(FileName);
                foreach (var item in csvmodel)
                {
                    stream = item.Ean + ";" + item.Anzahl + Environment.NewLine;
                    streamwriter.Write(stream);
                }

                streamwriter.Close();
            }
            
            catch (Exception)
            {

                throw;
            }
}   


        class CsvModel
        {
            public string Ean { get; set; }
            public int Anzahl { get; set; }
            public int WarenbereichID { get; set; }
            public string Artikelbezeichnung { get; set; }
            public string Warenbereich { get; set; }
        }

    }

    


}
