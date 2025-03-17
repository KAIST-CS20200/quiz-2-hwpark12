module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec f n s =
    if n=1 then s
    else
      if n%2=0 then f (n/2) (s+1)
      else f (n*3+1) (s+1)
  f n 0
