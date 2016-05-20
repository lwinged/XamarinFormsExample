using System;
using SQLite.Net.Attributes;

namespace XamTest
{
	public class Stock
	{
		[PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		[MaxLength(8)]
		public string Symbol { get; set; }
	}
}

