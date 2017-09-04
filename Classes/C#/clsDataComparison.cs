using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

public sealed class PublicationFactory
{

	private PublicationFactory()
	{
	}

	/// <summary>
	/// Create a diffgram from two datasets
	/// diffgram contains the list of row to create, update and delete to pass from old to new step
	/// old and new datasets must have the same schema
	/// the old dataset give the list of table to compute
	/// Is supposed that all data have a ToString() method wich render a representative value of the data
	/// Is supposed that a column named "PK" got a unique string identifier
	/// </summary>
	/// <param name="oldDataSet">Old step</param>
	/// <param name="newDataSet">Current step</param>
	/// <returns>diffgram as dataset</returns>
	public static DataSet DeltaMaker(DataSet oldDataSet, DataSet newDataSet)
	{
		DataSet datasetdiff = default(DataSet);
		DataRow tempRow = default(DataRow);
		DataTable tempTable = default(DataTable);
		string tempTableName = null;
		datasetdiff = new DataSet();

		// concat all data of each field, in order to compare content
		TTSDataHelper.BeginSerializeHelper(oldDataSet);
		TTSDataHelper.BeginSerializeHelper(newDataSet);

		for (int i = 0; i <= oldDataSet.Tables.Count - 1; i++) {
			tempTableName = oldDataSet.Tables(i).TableName;
			IEnumerable<DataRow> orig = oldDataSet.Tables(tempTableName).AsEnumerable();
			IEnumerable<DataRow> updated = newDataSet.Tables(tempTableName).AsEnumerable();

			// in updated, wich don't exist in origin
			IEnumerable<DataRow> Added = ;
			//  in updated, data different from origin
			// ignore just added
			IEnumerable<DataRow> Modif = ;
			// in origin, non existing in updated
			IEnumerable<DataRow> Deleted = ;

			datasetdiff.Tables.Add(oldDataSet.Tables(tempTableName).Clone());
			tempTable = datasetdiff.Tables(tempTableName);
			tempTable.BeginLoadData();

			// Create, accept then delete
			foreach (DataRow row in Deleted) {
				tempRow = tempTable.Rows.Add(row.ItemArray);
				tempRow.AcceptChanges();
				tempRow.Delete();
			}

			// Create added
			foreach (DataRow row in Added) {
				tempRow = tempTable.Rows.Add(row.ItemArray);
				tempRow.AcceptChanges();
				tempRow.SetAdded();
			}
			// Create modified
			foreach (DataRow row in Modif) {
				tempRow = tempTable.Rows.Add(row.ItemArray);
				tempRow.AcceptChanges();
				tempRow.SetModified();
			}
			tempTable.EndLoadData();

			tempTable.Columns.Remove("SERIALIZED");
		}

		//remove data comparison helper
		TTSDataHelper.EndSerializeHelper(oldDataSet);
		TTSDataHelper.EndSerializeHelper(newDataSet);

		return datasetdiff;
	}
}

internal sealed class TTSDataHelper
{
	private TTSDataHelper()
	{
	}


	public static char separator = '§';
	public static void BeginSerializeHelper(DataSet dataset)
	{
		string serialized = null;
		foreach (DataTable table in dataset.Tables) {
			table.Columns.Add("SERIALIZED", typeof(string));
			foreach (DataRow row in table.Rows) {
				serialized = string.Empty;
				for (int i = 0; i <= table.Columns.Count - 3; i++) {
					serialized += row(i).ToString() + separator;
				}
				row("SERIALIZED") = serialized;
			}
		}
	}

	public static void EndSerializeHelper(DataSet dataSet)
	{
		foreach (DataTable table in dataSet.Tables) {
			table.Columns.Remove("SERIALIZED");
		}
	}

}
