using System.Data;
using System.Data.OleDb;

namespace MDE_Version_2._0
{
    class AccessErfassung : AccessBase
    {
        public DataTable SchemaDaten()
        {

            ///Lädt das Schema Aus der Access Datei/Datenbank
            DataTable datatable = new DataTable();
            OleDbDataAdapter oledataadapter = new OleDbDataAdapter();
            OleDbCommand selectcommand = new OleDbCommand();
            selectcommand.CommandText = "Select TOP 1 * from Erfassung";
            selectcommand.Connection = AccessVerbindung();
            oledataadapter.SelectCommand = selectcommand;
            oledataadapter.FillSchema(datatable, SchemaType.Source);
            return datatable;
               
        }
      
        public void Accessdateischreiben(DataTable datatable)
        {

            OleDbDataAdapter oledbdataadapter = new OleDbDataAdapter();
            oledbdataadapter.SelectCommand = new OleDbCommand("Select TOP 1 * FROM Erfassung", AccessVerbindung());

            OleDbCommandBuilder Insertcommandbuilder = new OleDbCommandBuilder(oledbdataadapter);
            OleDbCommandBuilder Editcommandbuilder = new OleDbCommandBuilder(oledbdataadapter);
            OleDbCommandBuilder Deletecommandbuilder = new OleDbCommandBuilder(oledbdataadapter);



            oledbdataadapter.InsertCommand = Insertcommandbuilder.GetInsertCommand(true);
            oledbdataadapter.UpdateCommand = Editcommandbuilder.GetUpdateCommand(true);
            oledbdataadapter.DeleteCommand = Deletecommandbuilder.GetDeleteCommand(true);

            oledbdataadapter.Update(datatable);

            
            
            //oledbdataadapter.Update()



        }




    }
}
