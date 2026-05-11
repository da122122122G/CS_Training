using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TargetProject.Chap02;


namespace TestProject.Practice
{
    [TestClass]
    public class GreetingServiceTests
    {
        [TestMethod("朝の時間帯(代表値)ではGood Morningを返す")]
        public void Greet_ShouldReturn_WhenMorning()
        {
            // Arrange(準備)
            var chap02 = new GreetingService();
            int hour = 8;
            // Act(実行)
            var result = chap02.Greet(hour);
            // Assert(確認)
            Assert.AreEqual("Good Morning", result);
        }

        [TestMethod("昼の時間帯(代表値)ではHelloを返す")]
        public void Greet_ShouldReturn_Whenlunch()
        {
            // Arrange(準備)
            var chap02 = new GreetingService();
            int hour = 15;
            // Act(実行)
            var result = chap02.Greet(hour);
            // Assert(確認)
            Assert.AreEqual("Hello", result);
        }

        [TestMethod("夕方の時間帯(代表値)ではHelloを返す")]
        public void Greet_ShouldReturn_WhenEvening()
        {
            // Arrange(準備)
            var chap02 = new GreetingService();
            int hour = 20;
            // Act(実行)
            var result = chap02.Greet(hour);
            // Assert(確認)
            Assert.AreEqual("Good Evening", result);
        }

        [TestMethod("夜の時間帯(代表値)ではHelloを返す")]
        public void Greet_ShouldReturn_WhenNight()
        {
            // Arrange(準備)
            var chap02 = new GreetingService();
            int hour = 6;
            // Act(実行)
            var result = chap02.Greet(hour);
            // Assert(確認)
            Assert.AreEqual("Good Night", result);
        }
    }
}