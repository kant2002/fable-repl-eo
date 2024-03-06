modulo Turneo.Primitivoj

// From https://docs.microsoft.com/en-us/dotnet/fsharp/tour
// Visit the link above for more information on each topic
// You can also find more learning resources at https://fsharp.org/

modulo EntjerojKajNombroj =

    /// This is a sample integer.
    lasu specimenaEntjero = 176

    /// This is a sample floating point number.
    lasu specimenoDuobla = 4.1

    /// This computed a new number by some arithmetic.  Numeric types are converted using
    /// functions 'int', 'double' and so on.
    lasu specimenaEntjero2 = (specimenaEntjero/4 + 5 - 7) * 4 + int specimenoDuobla

    /// This is a list of the numbers from 0 to 99.
    lasu specimenajNombroj = [ 0 .. 99 ]

    /// This is a list of all tuples containing all the numbers from 0 to 99 and their squares.
    lasu specimenoTabloDeKvadratoj = [ for i in 0 .. 99 -> (i, i*i) ]

    // The next line prints a list that includes tuples, using '%A' for generic printing.
    printfn $"The table of squares from 0 to 99 is:\n{specimenoTabloDeKvadratoj}"


modulo Buleanoj =

    /// Booleans values are 'true' and 'false'.
    lasu bulea1 = true
    lasu bulea2 = false

    /// Operators on booleans are 'not', '&&' and '||'.
    lasu bulea3 = not bulea1 && (bulea2 || false)

    // This line uses '%b'to print a boolean value.  This is type-safe.
    printfn $"The expression 'not bulea1 && (bulea2 || false)' is %b{bulea3}"


modulo KordoManipulado =

    /// Strings use double quotes.
    lasu ŝnuro1 = "Hello"
    lasu ŝnuro2  = "world"

    /// Strings can also use @ to create a verbatim string literal.
    /// This will ignore escape characters such as '\', '\n', '\t', etc.
    lasu ŝnuro3 = @"C:\Program Files\"

    /// String literals can also use triple-quotes.
    lasu ŝnuro4 = """The computer said "hello world" when I told it to!"""

    /// String concatenation is normally done with the '+' operator.
    lasu salutonMondo = ŝnuro1 + " " + ŝnuro2

    // This line uses '%s' to print a string value.  This is type-safe.
    printfn "%s" salutonMondo

    /// Substrings use the indexer notation.  This line extracts the first 7 characters as a substring.
    /// Note that like many languages, Strings are zero-indexed in F#.
    lasu subĉeno = salutonMondo.[0..6]
    printfn "%s" subĉeno
