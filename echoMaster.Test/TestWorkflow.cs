using FluentAssertions;

namespace echoMaster.Test
{
    public class TestWorkflow
    {
        [Fact] // gör ett simplet test för att testa workflow2
        public void Test1()
        {
            //Given
            string expected = "Hello World";

            string result = "Hello world"; // Making the test fail

            result.Should().BeEquivalentTo(expected);

        }
    }
}