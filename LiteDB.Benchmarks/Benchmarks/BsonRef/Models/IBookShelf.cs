using System;
using System.Collections.Generic;

namespace LiteDB.Benchmarks.Benchmarks.BsonRef.Models
{
	public interface IBookShelf
	{
		Guid Id { get; set; }
		int Floor { get; set; }
		string Column { get; set; }
		string Row { get; set; }
		List<Book> Books { get; set; }
	}
}