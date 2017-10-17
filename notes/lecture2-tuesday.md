# Object-Oriented Programming in C#

### **Aspects of Object-oriented Programming**
- Objects
- Instantiation
- Modularity
- Classes
- Inheritance
- Encapsulation
- DRY
- Methods
- Attributes
- Static
- Private
- Internal
- Void
- Organizes code (namespaces)
- Maintenance
- Readability

### **S.O.L.I.D.**
- **S**ingle responsibility principle
    - Only one class for each "controller view" and/or function
- **Op**en/closed principle 
    - Open for extension, closed for changing
    - Leave room for your code to be extended but don't expect it to be changed
    - Write code to be flexible in the future
- **L**iskov substitution principle
    - Anything that inherits from a parent class should be able to return the same kinds of information
    - Classes down the hierarchy should respond to the same methods as the parent
- **I**nterface segregation principle
    - Sharing across a hierarchy
    - An interface is how we can interact with an object or a class
    - Keep the appropriate things as part of the interface and part of the class
- **D**ependency Inversion Principle
    - Strive to make loosely-coupled classes
    - Try not to make one class dependent on information from another
    - Makes it harder to maintain if classes are reliant on one another

### **Why OOP**
- Makes code more readable
- Allows us to share code with derived classes of the main class

### **Related Concepts in OOP**
- Inheritence
- Encapsulation
- Abstraction
    - Determine what goes in each class
    - Public vs. private
- Polymorphism
    - The ability to change behaviors
    - In C#, can use method-overloading

### **Vocabulary**
- **Members:** things inside of a class
    - **Properties:** info that can be get/set (generally public & more accessible)
    - **Fields:** info that's dynamically set when a class is initialized (generally private & less accessible)

    **Example of instantiating an inherited class and setting a variable:**
    ```
    class Tree:Plant
    {
        public int _age {get; private set;}
        public Tree(int age)
        {
            _age = age;
        }
    }
    ```
    *Underscores in front of a variable means it's an internal variable and should not be changed*  

    - **Get/Set:** ways to get and set information, can be defined manually or leave out set to make it read-only
    - **Static:** not intended to be instantiated or inherited from; should be a collection of useful info (e.g. static Math class)
        - Should not change
    - **Abstract:** also not intended to be instantiated but can be inherited from (e.g. class like Animal can be inherited from but never instantiated on its own)
        - **Abstract Methods:** must be overwritten by the derived classes
