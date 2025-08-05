// C# is case sensitive and functions like Comare() , Equals() , == , IndexOf() are case sensitive
// Use ToUpper() , ToLower() make a copy of string and this is not good for performance.

if( firstString.ToUpper() == secondString.ToUpper() )
{
    //Do something
}

// All functions for compare have "StringComparison"
if (string.Equals(firstString, secondString, StringComparison.OrdinalIgnoreCase))
{
    // Do something
}
