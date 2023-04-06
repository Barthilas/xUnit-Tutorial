using Xunit;
using Xunit.Abstractions;

namespace xUnitTutorial.Tests
{
    [CollectionDefinition("Guid generator")]
    public class GuidGeneratorDefinition: ICollectionFixture<GuidGenerator> { }

    [Collection("Guid generator")]
    public class GuidGeneratorTestsOne/* : IClassFixture<GuidGenerator>, IDisposable*/
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestsOne(ITestOutputHelper output, GuidGenerator guidGenerator)
        {
            _guidGenerator = guidGenerator;
            _output = output;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        //public void Dispose()
        //{
        //    _output.WriteLine($"The class was disposed.");
        //}
    }

    [Collection("Guid generator")]
    public class GuidGeneratorTestsTwo/* : IClassFixture<GuidGenerator>, IDisposable*/
    {
        private readonly GuidGenerator _guidGenerator;
        private readonly ITestOutputHelper _output;

        public GuidGeneratorTestsTwo(ITestOutputHelper output, GuidGenerator guidGenerator)
        {
            _guidGenerator = guidGenerator;
            _output = output;
        }

        [Fact]
        public void GuidTestOne()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        [Fact]
        public void GuidTestTwo()
        {
            var guid = _guidGenerator.RandomGuid;
            _output.WriteLine($"The guid was: {guid}");
        }

        //public void Dispose()
        //{
        //    _output.WriteLine($"The class was disposed.");
        //}
    }
}
