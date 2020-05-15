using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;

namespace Minsk.CodeAnalysis.Symbols
{
    internal static class BuiltinFunctions
    {
        public static readonly FunctionPrototypeSymbol Print = new FunctionPrototypeSymbol("print", ImmutableArray.Create(new ParameterSymbol("text", TypeSymbol.Any, 0)), TypeSymbol.Void);
        public static readonly FunctionPrototypeSymbol Input = new FunctionPrototypeSymbol("input", ImmutableArray<ParameterSymbol>.Empty, TypeSymbol.String);
        public static readonly FunctionPrototypeSymbol Rnd = new FunctionPrototypeSymbol("rnd", ImmutableArray.Create(new ParameterSymbol("max", TypeSymbol.Int, 0)), TypeSymbol.Int);

        internal static IEnumerable<FunctionPrototypeSymbol> GetAll()
            => typeof(BuiltinFunctions).GetFields(BindingFlags.Public | BindingFlags.Static)
                                       .Where(f => f.FieldType == typeof(FunctionPrototypeSymbol))
                                       .Select(f => (FunctionPrototypeSymbol)f.GetValue(null)!);
    }
}