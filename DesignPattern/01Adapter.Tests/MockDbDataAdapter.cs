﻿using _01Adapter.Resource;
using System;
using System.Data;

namespace _01Adapter.Tests
{
    public class MockDbDataAdapter : IDbDataAdapter
    {
        public int Fill(DataSet dataSet)
        {
            if(dataSet == null)
            {
                throw new ArgumentNullException(nameof(dataSet));
            }

            var dataTable = new DataTable();

            dataTable.Columns.Add(GlobalStrings.TableColumnEmailAddress, typeof(string));
            var row = dataTable.NewRow();
            row[GlobalStrings.TableColumnEmailAddress] = GlobalStrings.TesztEmailAddress;
            dataTable.Rows.Add(row);

            dataSet.Tables.Add(dataTable);
            dataSet.AcceptChanges();
            return 0;
        }

        #region not implemented
        public IDbCommand SelectCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new System.NotImplementedException();        

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new System.NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new System.NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}