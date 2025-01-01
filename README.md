# Uninitialized Property Access in C#

This repository demonstrates a subtle but potentially problematic error in C#: accessing a property before it has been assigned a value.  Uninitialized properties can lead to unpredictable behavior, particularly in multi-threaded scenarios or when the default value is not suitable.

The `bug.cs` file shows the problematic code.  The `bugSolution.cs` file presents a corrected version. 

The key takeaway is to always initialize properties, or check for null or default values before accessing them.