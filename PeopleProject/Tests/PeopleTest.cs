using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleProject.Tests
{

    [TestFixture]
    public class PeopleTest
    {
        People people;

        [SetUp]
        public void Setup()
        {
            people = new People();
        }

        [Test]
        public void AtlagEletkor()
        {
            people.UjSzemely(20);
            people.UjSzemely(30);
            people.UjSzemely(40);
            people.UjSzemely(50);
            people.UjSzemely(60);
            Assert.That(people.AtlagEletkor(20, 60), Is.EqualTo(40));
        }

        [Test]
        public void AtlagEletkorTort()
        {
            people.UjSzemely(12);
            people.UjSzemely(13);
            Assert.That(people.AtlagEletkor(10, 20), Is.EqualTo(12.5));
        }

        [Test]
        public void AtlagEletkorHarmad()
        {
            people.UjSzemely(12);
            people.UjSzemely(13);
            people.UjSzemely(12);
            Assert.That(people.AtlagEletkor(10, 20), Is.EqualTo(12.3333).Within(0.01));
        }

        [Test]
        public void AtlagEletkorInterval()
        {
            people.UjSzemely(20);
            people.UjSzemely(30);
            people.UjSzemely(40);
            people.UjSzemely(50);
            people.UjSzemely(60);

            Assert.That(people.AtlagEletkor(30, 50), Is.EqualTo(40));
        }

        [Test]
        public void AtlagEletkorEletkorCount()
        {
            Assert.That(() => people.AtlagEletkor(20, 60), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void AtlagEletkorInvalidRange()
        {
            people.UjSzemely(20);
            people.UjSzemely(30);
            people.UjSzemely(40);
            people.UjSzemely(50);
            people.UjSzemely(60);
            Assert.That(() => people.AtlagEletkor(60, 10), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void AtlagEletkorInvalidMin()
        {
            people.UjSzemely(20);
            people.UjSzemely(30);
            people.UjSzemely(40);
            people.UjSzemely(50);
            people.UjSzemely(60);
            Assert.That(() => people.AtlagEletkor(-10, 60), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void AtlagEletkorInvalidMax()
        {
            people.UjSzemely(20);
            people.UjSzemely(30);
            people.UjSzemely(40);
            people.UjSzemely(50);
            people.UjSzemely(60);
            Assert.That(() => people.AtlagEletkor(10, -60), Throws.TypeOf<ArgumentException>());
        }
    }
}
