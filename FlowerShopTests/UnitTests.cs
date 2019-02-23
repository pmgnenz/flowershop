using NUnit.Framework;
using Moq;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
          // Arrange
            var isdeliveredmock = new Mock<IOrderDAO>();
            isdeliveredmock.Setup((m => m.SetDelivered(It.IsAny<IOrder>())));

            var client1 = new Mock<IClient>();
            IOrder order1 = new Order(isdeliveredmock.Object,client1.Object);
            //ACT
            order1.Deliver(isdeliveredmock.Object);
            

            //Assert
            isdeliveredmock.Verify(m => m.SetDelivered(It.IsAny<IOrder>()),Times.Once());



            
        }
    }
}