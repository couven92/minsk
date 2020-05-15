using System.Collections.Immutable;
using Minsk.CodeAnalysis.Symbols;

namespace Minsk.CodeAnalysis.Binding
{
    internal sealed class BoundProgram
    {
        public BoundProgram(BoundProgram? previous,
                            ImmutableArray<Diagnostic> diagnostics,
                            FunctionPrototypeSymbol? mainFunction,
                            FunctionPrototypeSymbol? scriptFunction,
                            ImmutableDictionary<FunctionPrototypeSymbol, BoundBlockStatement> functions)
        {
            Previous = previous;
            Diagnostics = diagnostics;
            MainFunction = mainFunction;
            ScriptFunction = scriptFunction;
            Functions = functions;
        }

        public BoundProgram? Previous { get; }
        public ImmutableArray<Diagnostic> Diagnostics { get; }
        public FunctionPrototypeSymbol? MainFunction { get; }
        public FunctionPrototypeSymbol? ScriptFunction { get; }
        public ImmutableDictionary<FunctionPrototypeSymbol, BoundBlockStatement> Functions { get; }
    }
}
