namespace ClassLibrary1

module Inlines =
    let inline addUp (xs : ^t list) =
        match xs with
        | h :: t ->
            let mutable result = h

            // Change this loop to
            //  for x in xs do
            // And the test using the quotation will re-run and fail, but the other two tests will still show as passing
            for x in t do
                result <- result + x
            result
        | [] -> failwith "Nothing to add"

