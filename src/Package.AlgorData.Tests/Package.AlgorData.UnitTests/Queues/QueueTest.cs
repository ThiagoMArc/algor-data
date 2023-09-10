using PackageQueue = Package.AlgorData.DataStructures.Queue;

namespace Package.AlgorData.UnitTests.Queues
{
    public class QueueTest
    {
        [Fact(DisplayName="Queue Should Return True When It Is Empty")]
        public void Queue_Should_Return_True_When_It_Is_Empty()
        {
            //Arrange
            PackageQueue.Queue<int> queue = new();

            //Act
            bool isQueueEmpty = queue.IsEmpty();

            //Assert
            Assert.True(isQueueEmpty);
        }

        [Fact(DisplayName="Queue Should Return False When It Is Not Empty")]
        public void Queue_Should_Return_False_When_It_Is_Not_Empty()
        {
            //Arrange
            PackageQueue.Queue<int> queue = new();
            queue.Enqueue(12);
            queue.Enqueue(25);

            //Act
            bool isQueueEmpty = queue.IsEmpty();

            //Assert
            Assert.False(isQueueEmpty);
        }

        [Fact(DisplayName = "Queue Should Return The Least Inserted Iem On A Filled Queue")]
        public void Queue_Should_Return_Least_Inserted_Item_On_A_Filled_Queue()
        {
            //Arrange
            PackageQueue.Queue<string> queue = new();
            queue.Enqueue("uma palavra");
            queue.Enqueue("outra palavra");

            //Act
            string leastInsertedItem = queue.Dequeue();

            //Assert
            Assert.Equal("uma palavra", leastInsertedItem);
        }

        [Fact(DisplayName = "Queue Should Throw InvalidOperationException When Dequeue Operation Occurs On Empty Queue")]
        public void Queue_Should_Throw_InvalidOperationException_When_Dequeue_Operation_Occurs_On_Empty_Queue()
        {
            //Arrange
            PackageQueue.Queue<int> queue = new();

            var expectedErrorMessage = "Can not Dequeue empty queue";

            //Act && Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => { queue.Dequeue(); });
            Assert.Equal(ex.Message, expectedErrorMessage);
        }

        [Fact(DisplayName = "Queue Should Wipe Data When Clear Is Invoked")]
        public void Queue_Should_Wipe_Elements_When_Clear_Is_Invoked()
        {
            //Arrange
            PackageQueue.Queue<int> queue = new();
            queue.Enqueue(12);
            queue.Enqueue(67);

            //Act
            queue.Clear();

            //Assert
            Assert.True(queue.IsEmpty());
        }

        [Theory(DisplayName= "Queue Contains Returns True When A Given Element Is In The Queue Returns False Otherwise")]
        [InlineData("O pau no gato", true)]
        [InlineData("Maria", false)]
        public void Queue_Contains_Returns_True_When_A_Given_Element_Is_In_The_Queue_Returns_False_Otherwise(string text, bool result)
        {
            //Arrange
            PackageQueue.Queue<string> queue = new();

            queue.Enqueue("Atirei");
            queue.Enqueue("O pau no gato");
            queue.Enqueue("Mas o gato não morreu");

            //Act
            var isInqueue = queue.Contains(text);

            //Assert
            Assert.Equal(result, isInqueue);
        }

    }
}