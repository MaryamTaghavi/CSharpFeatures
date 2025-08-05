// Strings are immutable, that means, that means they cann't be change if you want to change them, a copy of that create in heap and after a time GC remove previouse strings.
// We have StrinBuilder that can be change strings without create a copy of them.

StringBuilder sb = new StringBuilder("**** Fantastic Games ****") ;

// StringBuilder can keep 16 characters , but if you want to keep more than you can use this format

StringBuilder sb = new StringBuilder("**** Fantastic Games ****" , 256) ; 

// If you append more than, the StringBuilder object will copy its data into a new instance and grow the buffer by the specified limit.
