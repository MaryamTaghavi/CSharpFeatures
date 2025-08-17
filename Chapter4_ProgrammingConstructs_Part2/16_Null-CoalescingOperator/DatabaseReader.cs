namespace _16_Null_CoalescingOperator;

class DatabaseReader
{
    // Nullable data field.
    public int? numericValue = null;
    public bool? boolValue = true;
    // Note the nullable return type.
    public int? GetIntFromDatabase()
    { return numericValue; }
    // Note the nullable return type.
    public bool? GetBoolFromDatabase()
    { return boolValue; }
}
