using System.Collections.Immutable;

namespace Minsk.CodeAnalysis.Symbols
{
    public class FunctionPrototypeSymbol : Symbol
    {
        public FunctionPrototypeSymbol(string name, ImmutableArray<ParameterSymbol> parameters, TypeSymbol type)
            : base(name)
        {
            Parameters = parameters;
            Type = type;
        }

        public override SymbolKind Kind => SymbolKind.Function;
        public ImmutableArray<ParameterSymbol> Parameters { get; }
        public TypeSymbol Type { get; }
    }
}