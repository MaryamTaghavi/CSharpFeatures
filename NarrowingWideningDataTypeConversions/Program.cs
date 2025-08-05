// Narrowing DataType Conversions
// Convert big type to small type 
// It's danger and must be case beacause you may miss the value

int b = 30000 ;
short a = (short) b ; 

// Widening DataType Conversions
// Convert small type to big type
// It's ok and it isn't danger

short a = 2 ;
int b = a ;
