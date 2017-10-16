# Beginning C#

### Data types
- int
- string
- long
- short
- char
- bool
- float (32-bit)
- double (64-bit)

### Converting types
```
// Implicit conversion
int bob = 4
float rob = bob;

// Explicit conversion
float rob = (float)bob;

// Not allowed because of loss of information
float bob = 4.17;
int ross = bob;

// Re-worked to be allowable using casting/type coercion
float bob = 4.17;
int ross = int(bob);
```

### Comparisons
```
// Checking memory locations (equivalent to ===)
X.Equals(Y)
```

### Strings
```
// Formatting strings
("a {1}", "string", "bob")

// Adding expressions to strings
$"{2 + 7}" 
```

### Arrays
- Need to declare how big they are & what types of data they contain
- Size is not mutable! If dynamic sizing needed, use a linked list
```
// Initialize an array of integers named bob
int[] bob = new {1, 2, 3, 4, 5}

// Initialize an empty array of size 5
int[] rob = new int[5];

// Initializing multi-dimensional arrays
int[x][y]
int[x, y]

// Looping through an array
foreach (int val in int[x])
{
    ...(val);
}
```

### Lists
- Behaves like a linked-list
- Indexed, so can iterate using foreach like an array
- Must use collections library
```
// Initializing a list of strings named 'bob'
List<string> bob = new List<string>();
```

### Dictionaries
- Must use collections library
- Has similar methods to linked-lists
```
// Initializing a dictionary named 'bob' by defining the types of keys and values
Dictionary<string, object> bob = new Dictionary<string, object>();

// Iterating through a dictionary
foreach (KeyValuePair<string, object> entry in bob)
{
    bob.key ...
    bob.value ...
}
```

### Functions
- Must define accessibility-levels
```
// Functions must have unique signatures!
public int bob(int ross)
{
    ...
}

// Function that takes an int, returns a str
public int bob(str ross)
{
    ...
}
```

### VS Code Shortcuts
- System.Console.WriteLine:  
```cw + tab => System.Console.WriteLine();```
