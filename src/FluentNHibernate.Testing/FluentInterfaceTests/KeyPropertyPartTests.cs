﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using FluentNHibernate.MappingModel;
using NUnit.Framework;
using FluentNHibernate.MappingModel.Identity;

namespace FluentNHibernate.Testing.FluentInterfaceTests
{
    [TestFixture]
    public class KeyPropertyPartTests
    {
        private KeyPropertyMapping mapping;
        private KeyPropertyPart part;

        [SetUp]
        public void SetUp()
        {
            this.mapping = new KeyPropertyMapping();
            this.part = new KeyPropertyPart(mapping);
        }


        [Test]
        public void ShouldSetColumnName()
        {
            part.ColumnName("col1");
            mapping.Columns.First().Name.ShouldEqual("col1");
        }

        [Test]
        public void ShouldSetType()
        {
            part.Type(typeof(string));
            mapping.Type.ShouldEqual(new TypeReference(typeof(string)));
        }
    }
}
