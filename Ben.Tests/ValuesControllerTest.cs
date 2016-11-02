using System.Linq;
using Ben.Controllers;
using NUnit.Framework;

namespace Ben.Tests
{
    [TestFixture]
    public class ValuesControllerTest
    {
        [Test]
        public void Get()
        {
            // Arrange
            var controller = new ValuesController();
            //todo: ???

            // Act
            var result = controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            Assert.AreEqual("", result.ElementAt(0));
            Assert.AreEqual("", result.ElementAt(1));
        }

        [Test]
        public void GetById()
        {
            // Arrange
            var controller = new ValuesController();
            //todo: ???

            // Act
            var result = controller.Get(1).ToString();

            // Assert
            Assert.AreEqual("Ben has done it", result);
            Assert.Fail("fill in the blanks buddy");
        }

        [Test]
        public void Post()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            var result = controller.Post("value");

            // Assert
            //            Assert.IsInstanceOfType(result, typeof(CreatedNegotiatedContentResult<string>));
            //            Assert.AreEqual("?????", ((CreatedNegotiatedContentResult<string>)result).Location.ToString());
            Assert.Fail("fill in the blanks buddy");
        }

        [Test]
        public void Put()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            // todo: add item to apply the PUT to.

            // Act
            // todo: var result = controller.Put(???, "value");

            // Assert
            // Assert.IsInstanceOfType(result, typeof(???));
            Assert.Fail("fill in the blanks buddy");
        }

        [Test]
        public void Put_DoesNotExist()
        {
            // Arrange
            ValuesController controller = new ValuesController();

            // Act
            var result = controller.Put(999, "value");

            // Assert
            // todo: what should the result be if id 5 does not exist? 
            // Assert.IsInstanceOfType(result, typeof(???));
            Assert.Fail("fill in the blanks buddy");
        }

        [Test]
        public void Delete()
        {
            // Arrange
            ValuesController controller = new ValuesController();
            // todo: add item to apply the DELETE to.

            // Act
            // todo: controller.Delete(???);

            // Assert
            // todo: what response code do you expect?
            // todo: how can you double check the item was deleted?
            Assert.Fail("fill in the blanks buddy");
        }
    }
}
