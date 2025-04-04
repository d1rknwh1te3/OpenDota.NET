namespace OpenDotaDotNet.Routes.Schema.Models;

/// <summary>
/// Represents a database schema.
/// </summary>
public class DatabaseSchema
{
	/// <summary>
	/// Gets the table name.
	/// </summary>
	[JsonPropertyName("table_name")]
	public string TableName { get; init; } = string.Empty;

	/// <summary>
	/// Gets the column name.
	/// </summary>
	[JsonPropertyName("column_name")]
	public string ColumnName { get; init; } = string.Empty;

	/// <summary>
	/// Gets the data type.
	/// </summary>
	[JsonPropertyName("data_type")]
	public string DataType { get; init; } = string.Empty;
}