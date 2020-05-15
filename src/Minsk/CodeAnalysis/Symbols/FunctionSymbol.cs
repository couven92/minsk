using System.Collections.Immutable;
using Minsk.CodeAnalysis.Syntax;

namespace Minsk.CodeAnalysis.Symbols
{
    public sealed class FunctionSymbol : FunctionPrototypeSymbol
    {
        public FunctionSymbol(string name, ImmutableArray<ParameterSymbol> parameters, TypeSymbol type, FunctionDeclarationSyntax declaration)
            : base(name, parameters, type)
        {
            Declaration = declaration;
        }

        public FunctionDeclarationSyntax Declaration { get; }
    }
}