using System;

namespace LiteDB.Benchmarks.Benchmarks.BsonRef.Models
{
	public class Book
	{
		[BsonId]
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set;}
		public DateTimeOffset PublishDate { get; set;}
		public BookType Type { get; set; }
		public int StarRating { get; set; }
	}

	public enum BookType
	{
		Digital,
		HardCover,
		SoftCover
	}
}