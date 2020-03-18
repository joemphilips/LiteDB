using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using LiteDB.Benchmarks.Benchmarks.BsonRef.Models;
using LiteDB.Benchmarks.Benchmarks.BsonRef.Models.Generators;

namespace LiteDB.Benchmarks.Benchmarks.BsonRef.Generator
{
	/// <summary>
	/// This benchmark is used purely for the sake of providing information
	/// about how long and how many resources it takes to generate the test data.
	/// </summary>
	[BenchmarkCategory(Constants.Categories.BSON_REF, Constants.Categories.DATA_GEN)]
	public class BookShelfGenerationBenchmark
	{
		// Benchmark params
		[Params(10, 50, 100, 500, 1000, 5000, 10000)]
		public int N;

		[Benchmark]
		public List<BookShelfNormal> DataNormalGeneration()
		{
			return BookShelfGenerator<BookShelfNormal>.GenerateList(N);
		}

		[Benchmark]
		public List<BookShelfBsonRef> DataWithBsonRefsGeneration()
		{
			return BookShelfGenerator<BookShelfBsonRef>.GenerateList(N);
		}
	}
}