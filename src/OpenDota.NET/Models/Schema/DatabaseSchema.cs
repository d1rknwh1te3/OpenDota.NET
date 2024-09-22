namespace OpenDotaDotNet.Models.Schema;

public class DatabaseSchema
{
	/// <summary>
	/// Gets or sets the table name.
	/// </summary>
	[JsonProperty("table_name")]
	public string TableName { get; set; }

	/// <summary>
	/// Gets or sets the column name.
	/// </summary>
	[JsonProperty("column_name")]
	public string ColumnName { get; set; }

	/// <summary>
	/// Gets or sets the data type.
	/// </summary>
	[JsonProperty("data_type")]
	public string DataType { get; set; }
}