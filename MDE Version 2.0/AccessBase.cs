using ADOX;
using System;
using System.Data.OleDb;

namespace MDE_Version_2._0
{
    class AccessBase
    {

        OleDbConnection OleCon = new OleDbConnection();

        string accessdateipfad;

        public void Accessdateioeffnen()
        {

            try
            {

                AccessVerbindung();
                OleCon.Open();

            }
            catch (Exception)
            {
                throw;
            }

        }

        public virtual OleDbConnection AccessVerbindung()
        {

            OleDbConnectionStringBuilder oleconnectionstringbuilder = new OleDbConnectionStringBuilder();

            oleconnectionstringbuilder.Provider = "Microsoft.Jet.OLEDB.4.0";
            if (accessdateipfad != null)
            {
                oleconnectionstringbuilder.DataSource = accessdateipfad;
            }
            else
            {
                Settings.Einstellungen einstellungen = new Settings.Einstellungen("settings.cfg");
                einstellungen.LoadReader();
                accessdateipfad = (string)einstellungen.Items["AccessDatei"];
                oleconnectionstringbuilder.DataSource = accessdateipfad;
            }
            OleCon.ConnectionString = oleconnectionstringbuilder.ConnectionString;
            return OleCon;
         }

        public virtual void AccessVerbindung(string Pfad)
        {

            OleDbConnectionStringBuilder oleconnectionstringbuilder = new OleDbConnectionStringBuilder();

            oleconnectionstringbuilder.Provider = "Microsoft.Jet.OLEDB.4.0";
            oleconnectionstringbuilder.DataSource = Pfad;
            OleCon.ConnectionString = oleconnectionstringbuilder.ConnectionString;



        }



        public void ErfassungsDateiErstellen(string Pfad)
        {
            try
            {
                var cat = Accessdateierstellen(Pfad);
                var table = Tabelleerstellen(cat);
                cat.Tables.Append(table);
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public virtual ADOX.Catalog Accessdateierstellen(string Pfad)
        {

            try
            {

                string verbindungsstring = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                     "Data Source=" + Pfad +
                     ";Jet OLEDB:Engine Type=5";

                ADOX.Catalog cat = new ADOX.Catalog();
                cat.Create(verbindungsstring);

                 return cat;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public virtual ADOX.Table Tabelleerstellen(ADOX.Catalog cat)
        {

            ADOX.Table table = new ADOX.Table();
            ADOX.Column col = new ADOX.Column();
            

            col.Name = "ID";
            col.DefinedSize = 50;
            col.Type = DataTypeEnum.adInteger;
            col.ParentCatalog = cat;
            col.Properties["AutoIncrement"].Value = true;
            //col.Properties[""]

            table.Name = "Erfassung";
            table.Columns.Append(col);
            table.Columns.Append("Fabrikat", DataTypeEnum.adLongVarWChar, 150);
            table.Columns.Append("Artikelbez", DataTypeEnum.adLongVarWChar, 150);
            table.Columns.Append("EAN", DataTypeEnum.adLongVarWChar, 25);
            table.Columns.Append("Anzahl", DataTypeEnum.adInteger, 50);
            table.Columns.Append("Warenbereich", DataTypeEnum.adLongVarWChar, 150);
            table.Columns.Append("WarenbereichID", DataTypeEnum.adInteger, 150);
            table.Columns.Append("Name", DataTypeEnum.adLongVarWChar, 150);
            table.Keys.Append("ID", KeyTypeEnum.adKeyPrimary, "ID");
            table.Columns["Anzahl"].Attributes = ColumnAttributesEnum.adColNullable;
            //table.Columns["WarenbereichID"].Attributes = ColumnAttributesEnum.adColNullable;
           
            return table; 
        }


    }
}
