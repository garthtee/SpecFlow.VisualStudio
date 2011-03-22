﻿using System;

namespace TechTalk.SpecFlow.Vs2010Integration.Bindings.Reflection
{
    public interface IBindingType
    {
        string Name { get; }
        string FullName { get; }
        bool IsAssignableTo(Type type);
    }
}