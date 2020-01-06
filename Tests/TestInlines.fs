namespace Tests

open NUnit.Framework
open FsUnitTyped
open Swensen.Unquote

open ClassLibrary1

type [<Measure>] m

[<TestFixture>]
type TestInlines() =
    [<Test>]
    member __.Test1() =
        Inlines.addUp [1.0;2.0;3.0] |> shouldEqual 6.0

    [<Test>]
    member __.Test2() =
        Inlines.addUp [1<m>;2<m>;3<m>] |> shouldEqual 6<m>

    [<Test>]
    member __.Test3() =
        test <@ Inlines.addUp [1<m>;2<m>;3<m>]  = 6<m> @>
