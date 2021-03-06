﻿using System;

namespace TechTalk.SpecFlow.Assist.ValueComparers
{
    public class BoolValueComparer : IValueComparer
    {
        public bool CanCompare(object actualValue)
        {
            return actualValue != null && actualValue.GetType() == typeof (bool);
        }

        public bool Compare(string expectedValue, object actualValue)
        {
            return bool.Parse(expectedValue) == (bool) actualValue;
        }
    }
}