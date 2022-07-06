using System;
using Package.AlgorData.DataStructures.Stack;
using Xunit;

namespace Package.AlgorData.DataStructures.UnitTests
{
    public class StackTest
    {
        [Fact(DisplayName="Stack Should Return True When It Is Empty")]
        public void Stack_Should_Return_True_When_It_Is_Empty()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();

            //Act
            var isStackEmpty = stack.IsEmpty();

            //Assert
            Assert.True(isStackEmpty);
        }

        [Fact(DisplayName="Stack Should Return False When It Is Not Empty")]
        public void Stack_Should_Return_False_When_It_Is_Not_Empty()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(12);
            stack.Push(14);
            stack.Push(167);

            //Act
            var isStackEmpty = stack.IsEmpty();


            //Assert
            Assert.False(isStackEmpty);
        }

        [Fact(DisplayName = "Stack Should Return Top Element When Pop Operation Pop On Filled Stack")]
        public void Stack_Should_Remove_And_Return_The_Top_Element_When_Pop_Operation_Occurs_On_Filled_Stack()
        {
             //Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(10);

            //Act
            var poppedElement = stack.Pop();

            //Assert
            Assert.Equal(10, poppedElement);
            Assert.Equal(2, stack.Peek());
        }

        [Fact(DisplayName = "Stack Should Throw InvalidOperationException When Pop Operation Occurs On Empty Stack")]
        public void Stack_Should_Throw_InvalidOperationException_When_Pop_Operation_Occurs_On_Empty_Stack()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
            var expectedErrorMessage = "Can not Pop Empty Stack";

            //Act && Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => { stack.Pop(); });
            Assert.Equal(ex.Message, expectedErrorMessage);
        }

        [Fact(DisplayName = "Stack Should Inform What Is The Top Element When Peek Operation Occurs On Filled Stack")]
        public void Stack_Should_Return_The_Top_Element_When_Peek_Operation_Occurs_On_Filled_Stack()
        {
             //Arrange
            Stack<string> stack = new Stack<string>();
            stack.Push("Palavras");
            stack.Push("Pequenas");
            stack.Push("Ao Vento");

            //Act
            var topElement = stack.Peek();

            //Assert
            Assert.Equal("Ao Vento", topElement);
        }

        [Fact(DisplayName = "Stack Should Throw InvalidOperationException When Peek Operation Occurs On Empty Stack")]
        public void Stack_Should_Throw_InvalidOperationException_When_Peek_Operation_Occurs_On_Empty_Stack()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
            var expectedErrorMessage = "Can not Peek From Empty Stack";

            //Act && Assert
            InvalidOperationException ex = Assert.Throws<InvalidOperationException>(() => { stack.Peek(); });
            Assert.Equal(ex.Message, expectedErrorMessage);
        }

        [Fact(DisplayName="Stack Should Wipe All Elements When Clear Is Invokeds")]
        public void Stack_Should_Wipe_All_Elements_When_Clear_Is_Invoked()
        {
            //Arrange
            Stack<string> stack = new Stack<string>();
            stack.Push("Palavras");
            stack.Push("Pequenas");
            stack.Push("Ao Vento");

            //Act
            stack.Clear();

            //Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact(DisplayName= "Stack Contains Returns True When A Given Element Is In The Stack")]
        public void Stack_Contains_Returns_True_When_A_Given_Element_Is_In_The_Stack()
        {
            //Arrange
            Stack<string> stack = new Stack<string>();
            stack.Push("Atirei");
            stack.Push("O pau no gato");
            stack.Push("Mas o gato não morreu");

            //Act
            var isInStack = stack.Contains("O pau no gato");

            //Assert
            Assert.True(isInStack);
        }

        [Fact(DisplayName= "Stack Contains Returns False When A Given Element Is Not In The Stack")]
        public void Stack_Contains_Returns_False_When_A_Given_Element_Is_Not_In_The_Stack()
        {
            //Arrange
            Stack<string> stack = new Stack<string>();
            stack.Push("Atirei");
            stack.Push("O pau no gato");
            stack.Push("Mas o gato não morreu");

            //Act
            var isInStack = stack.Contains("Maria");

            //Assert
            Assert.False(isInStack);
        }

        [Fact(DisplayName="Stack Count Property Should Return Total Of Elements In The Stack")]
        public void Stack_Count_Property_Should_Return_Total_Of_Elements_In_The_Stack()
        {
            //Arrange
            Stack<int> stack = new Stack<int>();
            stack.Push(12);
            stack.Push(23);
            stack.Push(67);
            stack.Push(100);
            stack.Pop();

            //Act
            var count = stack.Count;

            //Assert
            Assert.True(count == 3);
        }
    }
}
