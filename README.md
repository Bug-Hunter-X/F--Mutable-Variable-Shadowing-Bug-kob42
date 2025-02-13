# F# Mutable Variable Shadowing Bug

This example demonstrates a common error in F# involving mutable variables and shadowing. The `swap` function doesn't correctly swap the values of `x` and `y` because it creates new local variables that shadow the outer mutable variables.

## Bug Description
The `swap` function takes two mutable variables as input. However, inside the `swap` function, it creates new local variables named `x` and `y`.  These inner `x` and `y` variables are assigned the values passed as arguments, but these assignments do not affect the outer `x` and `y` variables. Therefore, after the `swap` function is called, the outer variables retain their original values.

## Solution
The solution modifies the `swap` function to directly operate on the passed mutable references using the `&` operator.