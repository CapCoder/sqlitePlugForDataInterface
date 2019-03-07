using System;
using System.Collections.Generic;
using System.Text;
using DataInterface;

namespace SQLitePlug
{
    class SQLDataCommand : IDataCommand
    {
        private string tableName;
        private string commandString;

        public void addTable(string table)
        {

        }

        public void changeTableName(string oldName, string newName)
        {

        }

        public void addTables(List<string> tables)
        {

        }

        public void addField(string name, TableRep.DType type)
        {

        }

        public void addFields(IDictionary<string, TableRep.DType> fields)
        {

        }

        public void removeField(string name)
        {

        }

        public void setTable(string table)
        {
            tableName = table;
        }

        public void build()
        {

        }

        public Row execute()
        {
            Row blah = new Row();
            List<Row> listOfRows = new List<Row>();
            listOfRows.Add(blah);
            return blah;
        }
    }
}
