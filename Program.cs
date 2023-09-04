


using Datastruct.Lib.HashTable;

var hashTable = new HashTable<string, string>(5);

hashTable.Add("1", "student A");
hashTable.Add("2", "student B");
hashTable.Add("3", "student C");
hashTable.Add("4", "student D");
hashTable.Add("5", "student E");
hashTable.Add("6", "student F");

hashTable.PrintHashTable();

// find element
var x =  hashTable.Get("3");
Console.WriteLine($"X: {x}");

// test remove
 hashTable.Remove("3");
hashTable.Remove("1");
hashTable.PrintHashTable();



