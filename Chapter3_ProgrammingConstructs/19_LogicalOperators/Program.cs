// || &&
// | &
// if (A() && B()) => if A() == false B() doesn't check
// if (A() & B()) => even if A() == false B() check
// if (A() || B()) => if A() == true B() doesn't check
// if (A() | B()) => even if A() == true B() check


// The && and || operators both "short-circuit" when necessory. This means that after a complex expression has been determined to be false,
// the remaining subexpressions will not be checked. If you require all expressions to be tested regardless, you can use the related & and | operators.
