using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDE_Version_2._0
{

    class CSV_Create
    {

        public void Create(string []FileName)
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
                        Ean = (string) resultItem["EAN"],
                        Artikelbezeichnung = (string)resultItem["Artikelbez"]

                    };
                    csvModels.Add(csvmodel);

                }
            }
            GenerateFiles(csvModels);
        }

        private void GenerateFiles(List<CsvModel> csvModels)
        {
           var result =  from csvModel in csvModels group csvModel by csvModel.WarenbereichID;
           var ID = new List<int>(); 


            foreach (var items in result)
            {
                ID.Add(items.Key);
            }
            foreach (int item in ID)
            {
            var result2 = from csvModel in csvModels where csvModel.WarenbereichID == item select csvModel;
               
                CreateFiles(result2.ToList<CsvModel>());
            }
            
        }

        private void CreateFiles(List<CsvModel> csvmodel)
        {
            Debug.WriteLine("Neues File");
            foreach (var item in csvmodel)
            {
                Debug.WriteLine("Artikel: " + item.Artikelbezeichnung);
            }

        }


        private class CsvModel
        {
            public string Ean { get; set; }
            public int Anzahl { get; set; }
            public int WarenbereichID { get; set; }
            public string Artikelbezeichnung { get; set; }
        }

    }

    


}
