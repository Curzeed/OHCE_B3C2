﻿using OHCE.Langues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OHCE.Test.xUnit
{
      public class LanguesTest
    {
        [Theory]
        [InlineData(PériodeJournée.Soir, Expressions.Français.Bonsoir)]
        [InlineData(PériodeJournée.Matin, Expressions.Français.Bonjour)]
        [InlineData(PériodeJournée.AprèsMidi, Expressions.Français.BonAprèsMidi)]
        [InlineData(PériodeJournée.Nuit, Expressions.Français.BonneNuit)]
        [InlineData(PériodeJournée.Defaut, Expressions.Français.Bonjour)]
        public void DireBonjourTest(PériodeJournée période, string salutationAttendue)
        {
            // ETANT DONNE la langue française
            // ET une période de la journée <période>
            var langue = new LangueFrançaise();

            // QUAND je dis bonjour
            var salutation = langue.DireBonjour(période);

            // ALORS on me répond <salutationAttendue>
            Assert.Equal(salutationAttendue, salutation);
        }

    }
}
