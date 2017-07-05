using System;
using BoardGame.MoveFactory;
using BoardGame.MoveStrategies;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace BoardGame.Tests
{
    [TestFixture]
    public class MoveFactoryTests
    {
        [TestCase(Direction.N, typeof(MoveNorth))]
        [TestCase(Direction.E, typeof(MoveEast))]
        [TestCase(Direction.S, typeof(MoveSouth))]
        [TestCase(Direction.W, typeof(MoveWest))]
        public void CreateMove_DirectionProvidedInParamters_ShouldCreateInstanceOfTypeProvidedInExpectedResult(Direction direction, Type expectedInstanceType)
        {
            var moveFactory = new MoveFactory.MoveFactory();

            var move = moveFactory.CreateMove(direction);

            Assert.AreEqual(expectedInstanceType, move.GetType());
        }
    }
}