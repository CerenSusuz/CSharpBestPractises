using Microsoft.VisualBasic;

namespace Prestige.Biz.Test
{
    public class ActorTest
    {
        [Test]
        public void TestGetOccupation()
        {
            //Arrange
            var currentActor = new Actor();
            var exceptedActor = "Actor";
            //Act
            string result = currentActor.GetOccupation();
            //Assert
            Assert.That(result, Is.EqualTo(exceptedActor));
        }


        [Test]
        public void TestParameterizedConstructor()
        {
            var currentActor = new Actor("John Doe");
            var expectedActor = "John Doe";

            string result = currentActor.ActorName;

            Assert.AreEqual(expectedActor, result);
        }

        [Test]
        public void TestBookActor()
        {
            string details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("John Doe");
            var expected = $"Actor: John Doe is booked {details}";

            string result = currentActor.BookActor();

            Assert.AreEqual (expected, result);
        }


        [Test]
        public void TestBookActorOnSpecificDate()
        {
            string details = "Booking can change if actor starts trouble.";
            var currentActor = new Actor("John Doe");
            var expected = $"Actor: John Doe is booked on {DateTime.Today.ToShortDateString()} {details}";

            string result = currentActor.BookActor(DateTime.Today.ToShortDateString());

            Assert.AreEqual(expected, result);
        }
    }
}