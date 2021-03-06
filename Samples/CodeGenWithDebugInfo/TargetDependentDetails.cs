﻿using System.Collections.Generic;
using Llvm.NET;
using Llvm.NET.Values;

namespace TestDebugInfo
{
    internal interface ITargetDependentDetails
    {
        string ShortName { get; }

        string Triple { get; }

        string Cpu { get; }

        string Features { get; }

        IEnumerable<AttributeValue> BuildTargetDependentFunctionAttributes( Context ctx );

        void AddABIAttributesForByValueStructure( Function function, int paramIndex );

        void AddModuleFlags( NativeModule module );
    }
}
