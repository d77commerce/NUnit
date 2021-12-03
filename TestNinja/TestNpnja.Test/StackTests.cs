using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.Test
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void stack_Push_ReturnTrue()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            Assert.IsTrue(stack.Count == 1);
        }
        [Test]
        public void stack_PushNull_ReturnExeption()
        {
            var stack = new Fundamentals.Stack<string>();
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);
        }
        [Test]
        public void Pop_RemuveFromStack_ReturnTrue()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            Assert.That(() => stack.Pop(), Is.EqualTo(2));
            Assert.IsTrue(stack.Count == 1);
        }
        [Test]
        public void Pop_RemuveFromEmptyStack_ReturnExeption()
        {
            var stack = new Fundamentals.Stack<int>();
          
            Assert.That(() => stack.Pop(), Throws.InvalidOperationException);
        }
        [Test]
        public void stack_Peek_ReturnTrue()
        {
            var stack = new Fundamentals.Stack<int>();
            stack.Push(1);
            Assert.That(()=>stack.Peek(), Is.EqualTo(1));
        }
        [Test]
        public void stack_PeekFromEmptyStack_ReturnExeption()
        {
            var stack = new Fundamentals.Stack<int>();
           
            Assert.That(() => stack.Peek(), Throws.InvalidOperationException);
        }
    }
}
