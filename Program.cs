using System;

namespace HelloWorld
// namespace is used to organize code and creates scope
{
  class Program
  // class is a container for data and methods,
  //  which brings functionality to your program.
  //  Every line of code that runs in C# must be inside a class.
  //  In our example, we named the class Program.
  {
    static void Main(string[] args)
    // Main is the entry point of the program,
    // where the program starts executing. static void
    // means that this method does not return any value and can be
    // called without creating an instance of the class.
    // args is an array of strings that can be used to pass
    // arguments to Main for a console based app.
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("Hello World!");
      // This is a comment
      Console.WriteLine("Congratulations!");
      // Console.WriteLine prints the output on the existing line and
      // appends a new line after it.
      string firstTime = "First lines of C# code!";
      // string is a data type that represents a sequence of characters.
      Console.Write(firstTime);
      // Console.Write prints the output on the existing line without
      // appending a new line after it.

      // C# uses a semicolon (;) to end each statement.
      // C# uses a type of dot notation to access methods and properties.
      // In this case, we are accessing the WriteLine method of the
      // Console class. Similar to classes and methods in Python.

      // C# uses literal values (values that never change data type) as this
      // enforces type safety and is believed to reduce bugs in the code.
      // I have already displayed a few literal strings above.
      // C# is a strongly typed language, meaning that every variable must
      // have a type, and the type cannot change after it is declared.

      // Character Literals 
      // A character literal is a single character enclosed in single quotes.
      char letter = 'A';
      // or
      Console.WriteLine('B');
      // Notice the single quotes, this is why you cannot use single quotes for
      // strings in C#. Single quotes are reserved for character literals.

      // Interger Literals
      // An integer literal is a whole number without a decimal point.
      int number = 42;
      // or
      Console.WriteLine(100);

      // Decimals in C#
      // C# has 3 types of decimal numbers:
      // float - single precision (32-bit)
      float singlePrecision = 3.14f; // 'f' suffix indicates a float literal
                                     // double - double precision (64-bit)
      double doublePrecision = 3.14; // no suffic needed, this is the default
                                     // type of decimal - high precision (128-bit)
      decimal highPrecision = 3.14m; // 'm' suffix indicates a decimal literal
                                     // The decimal type is used for financial
                                     // calculations where precision is important,
                                     // such as currency calculations.

      // Boolean Literals
      // A boolean literal is either true or false.
      bool isTrue = true;
      // or
      Console.WriteLine(false);

      // Data types play a central role in C#. In fact, the emphasis on data
      // types is one of the key distinguishing features of C# compared to
      // other languages like JavaScript. The designers of C# believed they
      // can help developers avoid common software bugs by enforcing data
      // types. You'll see this concept unfold as you learn more about C#.

      // Variables in C#
      // A variable is a named storage location in memory that can hold a value.
      // Variables must be declared with a specific data type (as shown above)
      // and conform to camelCase naming conventions.
      string myVariable = "This is a variable";
    }
  }
}