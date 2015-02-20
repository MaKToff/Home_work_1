(*
Задания 5 - 8
====================
Tasks 5 - 8

Author: Mikhail Kita, group 171
*)

//the 5th task
type Tree = Null | Node of Tree * int * Tree


//the 6th task
let rec add value tree =
    match tree with
    | Null                       -> Node (Null, value, Null)
    | Node (left, center, right) ->
        if value < center 
        then 
            Node (add value left, center, right)
        else 
            Node (left, center, add value right)


//the 7th task

//the smallest node on the right side with not more than 1 child
let rec goodNode tree = 
    match tree with
    | Null                       -> 0 //because of that can appear problems with '0' :(
                                      //but this situation is impossible :)
    | Node (left, center, right) ->
        if left = Null
        then
            center //this is the appropriate node
        else
            goodNode left

let rec remove value tree =
    match tree with
    | Null                       -> Null
    | Node (left, center, right) ->
        if value < center
        then
            Node (remove value left, center, right)
        else
            if value > center 
            then 
                Node (left, center, remove value right)
            else //value = center
                if (left = Null && right = Null) //this is the leaf
                then
                    Null
                else
                    if right <> Null
                    then 
                        Node (left, goodNode right, remove (goodNode right) right)
                    else
                        match left with
                        | Null                                -> Null
                        | Node (newLeft, newCenter, newRight) -> Node (newLeft, newCenter, newRight)


//the 8th task
let rec printLCR tree =
    match tree with
    | Null                       -> printf ""
    | Node (left, center, right) -> 
        printLCR left
        printf "%d " center
        printLCR right

let rec printLRC tree =
    match tree with
    | Null                       -> printf ""
    | Node (left, center, right) -> 
        printLRC left
        printLRC right
        printf "%d " center

let rec printCLR tree =
    match tree with
    | Null                       -> printf ""
    | Node (left, center, right) -> 
        printf "%d " center
        printCLR left
        printCLR right


let print tree =
    printf "CLR: "
    printCLR tree; 
    printf "\nLRC: "
    printLRC tree; 
    printf "\nLCR: "
    printLCR tree;
    printf "\n"

[<EntryPoint>]
let main args =
    let example = (Node (Node (Null, 2, Node (Null, 4, Null)), 5, Node (Node (Null, 6, Null), 8, Node (Null, 9, Null))))
    let example = add 3 example
    let example = add 7 example
    print example

    printf "\nNow we delete '5':\n"
    let newExample = remove 5 example
    print newExample; 
    0
