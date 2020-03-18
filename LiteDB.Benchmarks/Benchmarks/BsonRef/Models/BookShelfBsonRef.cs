using System;
using System.Collections.Generic;

namespace LiteDB.Benchmarks.Benchmarks.BsonRef.Models
{
	public class BookShelfBsonRef : IBookShelf
	{
		public Guid Id { get; set; }
		public int Floor { get; set; }
		public string Column { get; set; }
		public string Row { get; set; }
		[BsonRef]
		public List<Book> Books { get; set; }

		public BookShelfBsonRef()
		{
			Books = new List<Book>();
		}
	}
}