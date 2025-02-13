let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

printf "%d %d" x y

let swapRef (xRef:byref<int>) (yRef:byref<int>) = 
    let temp = xRef
    xRef <- yRef
    yRef <- temp

swapRef &x &y
printf "%d %d" x y