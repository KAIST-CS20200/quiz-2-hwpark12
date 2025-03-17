module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let rec f (n: int64) s =
    if n=1L then s
    else
      if n%2L=0L then f (n/2L) (s+1)
      else f (n*3L+1L) (s+1)
  f (int64 n) 0
