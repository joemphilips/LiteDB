using System;
using System.Collections.Generic;
using System.Linq;

namespace LiteDB.Benchmarks.Benchmarks.BsonRef.Models.Generators
{
	public static class BookShelfGenerator<T> where T : IBookShelf, new()
	{
		private static List<string> _bookTitles = new List<string>
		{
			"Adventures of Sherlock Holmes",
			"Adventures of Tom Sawyer, The",
			"Ain-i-Akbari",
			"Alchemist, The",
			"Alice in the Wonderland",
			"All’s Well that Ends well",
			"An American Tragedy",
			"An idealist view of life",
			"Anand Math",
			"Androcles and the Lion",
			"Ape and Essence",
			"Apple Cart",
			"Arabian Nights",
			"Area of Darkness",
			"Arthashastra",
			"Arms and the man",
			"Around the World in Eighty Days",
			"As you like it",
			"Autobiography of an Unknown Indian"
		};

		private static List<string> _authors = new List<string>
		{
			"Sir Arthur Conan Doyle",
			"Mark Twain",
			"Abul Fazal",
			"Paulo Coelho",
			"Lewis Carroll",
			"William Shakespeare",
			"Theodore Dreiser",
			"Dr. S. Radhakrishnan",
			"Bankim Chandra Chatterjee",
			"George Bernard Shaw",
			"A. Huxley",
			"George Bernard Shaw",
			"Sir Richard Burton",
			"V.S. Naipaul",
			"Kautilya",
			"George Bernard Shaw",
			"Jules Verne",
			"William Shakespeare",
			"Nirad C. Choudhury",
		};

		private static Random _random;

		public static List<T> GenerateList(int amountToGenerate)
		{
			_random = new Random(0);

			var generatedList = new List<T>();
			for (var i = 0; i < amountToGenerate; i++)
			{
				generatedList.Add(GenerateShelf());
			}

			return generatedList;
		}

		private static T GenerateShelf()
		{
			return new T
			{
				Id = Guid.NewGuid(),
				Floor = _random.Next(3),
				Column = ((char) (65 + _random.Next(26))).ToString(),
				Row = _random.Next(26).ToString(),
				Books = Enumerable.Range(0, _random.Next(10)).Select(_ => GenerateBook()).ToList()
			};
		}

		private static Book GenerateBook()
		{
			return new Book
			{
				Id = Guid.NewGuid(),
				Title = _bookTitles[_random.Next(_bookTitles.Count)],
				Author = _authors[_random.Next(_authors.Count)],
				Type = (BookType) _random.Next(3),
				PublishDate = DateTimeOffset.Now.AddMonths(_random.Next(10, 50) * -1),
				StarRating = _random.Next(6)
			};
		}
	}
}