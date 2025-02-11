using Shouldly;
using PackageStack = Package.AlgorData.DataStructures.Stack;

namespace Package.AlgorData.UnitTests.Stacks
{
    public class StackTest
    {
        [Fact(DisplayName="Stack Should Return True When It Is Empty")]
        public void Stack_Should_Return_True_When_It_Is_Empty()
        {
            //Arrange
            PackageStack.Stack<int> stack = new();

            //Act
            bool isStackEmpty = stack.IsEmpty();

            //Assert
            isStackEmpty.ShouldBeTrue();
        }

        [Fact(DisplayName="Stack Should Return False When It Is Not Empty")]
        public void Stack_Should_Return_False_When_It_Is_Not_Empty()
        {
            //Arrange
            PackageStack.Stack<int> stack = new();

            stack.Push(12);
            stack.Push(14);
            stack.Push(167);

            //Act
            bool isStackEmpty = stack.IsEmpty();

            //Assert
            isStackEmpty.ShouldBeFalse();
        }

        [Fact(DisplayName = "Stack Should Return Top Element When Pop Operation Pop On Filled Stack")]
        public void Stack_Should_Remove_And_Return_The_Top_Element_When_Pop_Operation_Occurs_On_Filled_Stack()
        {
             //Arrange
            PackageStack.Stack<int> stack = new();

            stack.Push(1);
            stack.Push(2);
            stack.Push(10);

            //Act
            int poppedElement = stack.Pop();

            //Assert
            poppedElement.ShouldBe(10);
            stack.Peek().ShouldBe(2);
        }

        [Fact(DisplayName = "Stack Should Throw InvalidOperationException When Pop Operation Occurs On Empty Stack")]
        public void Stack_Should_Throw_InvalidOperationException_When_Pop_Operation_Occurs_On_Empty_Stack()
        {
            //Arrange
            PackageStack.Stack<int> stack = new();

            var expectedErrorMessage = "Can not Pop Empty Stack";

            //Act && Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => { stack.Pop(); });
            ex.Message.ShouldBe(expectedErrorMessage);
        }

        [Fact(DisplayName = "Stack Should Inform What Is The Top Element When Peek Operation Occurs On Filled Stack")]
        public void Stack_Should_Return_The_Top_Element_When_Peek_Operation_Occurs_On_Filled_Stack()
        {
             //Arrange
            PackageStack.Stack<string> stack = new();

            stack.Push("Palavras");
            stack.Push("Pequenas");
            stack.Push("Ao Vento");

            //Act
            var topElement = stack.Peek();

            //Assert
            topElement.ShouldBe("Ao Vento");
        }

        [Fact(DisplayName = "Stack Should Throw InvalidOperationException When Peek Operation Occurs On Empty Stack")]
        public void Stack_Should_Throw_InvalidOperationException_When_Peek_Operation_Occurs_On_Empty_Stack()
        {
            //Arrange
            PackageStack.Stack<int> stack = new();

            var expectedErrorMessage = "Can not Peek From Empty Stack";

            //Act && Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => { stack.Peek(); });
            ex.Message.ShouldBe(expectedErrorMessage);
        }

        [Fact(DisplayName="Stack Should Wipe All Elements When Clear Is Invoked")]
        public void Stack_Should_Wipe_All_Elements_When_Clear_Is_Invoked()
        {
            //Arrange
            PackageStack.Stack<string> stack = new();

            stack.Push("Palavras");
            stack.Push("Pequenas");
            stack.Push("Ao Vento");

            //Act
            stack.Clear();

            //Assert
            stack.IsEmpty().ShouldBeTrue();
        }

        [Theory(DisplayName= "Stack Contains Returns True When A Given Element Is In The Stack Returns False Otherwise")]
        [InlineData("O pau no gato", true)]
        [InlineData("Maria", false)]
        public void Stack_Contains_Returns_True_When_A_Given_Element_Is_In_The_Stack_Returns_False_Otherwise(string text, bool result)
        {
            //Arrange
            PackageStack.Stack<string> stack = new();

            stack.Push("Atirei");
            stack.Push("O pau no gato");
            stack.Push("Mas o gato não morreu");

            //Act
            var isInStack = stack.Contains(text);

            //Assert
            isInStack.ShouldBe(result);
        }

        [Fact(DisplayName="Stack Count Property Should Return Total Of Elements In The Stack")]
        public void Stack_Count_Property_Should_Return_Total_Of_Elements_In_The_Stack()
        {
            //Arrange
            PackageStack.Stack<int> stack = new();
            
            stack.Push(12);
            stack.Push(23);
            stack.Push(67);
            stack.Push(100);
            stack.Pop();

            //Act
            var count = stack.Count;

            //Assert
            count.ShouldBe(3);
        }
    }
}