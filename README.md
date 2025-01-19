# C# ObjectDisposedException Bug Example

This repository demonstrates a common error in C#: attempting to access an object after it has been disposed of.  Specifically, it shows how using a DbContext (or any object with a 'using' statement) and then trying to access it outside of its scope results in an `ObjectDisposedException`.

The `bug.cs` file contains the buggy code.  The `bugSolution.cs` demonstrates how to avoid the error.

## Bug

The bug lies in accessing the `context` object after it's been disposed of by the `using` statement. This is a frequent issue when working with resources that require explicit disposal.

## Solution

The solution involves ensuring all accesses to the `context` occur within the `using` block or retrieving the required data before the context is disposed of.