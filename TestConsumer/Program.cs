using Milos.Shared.Core;

var ok = Result<int>.Success(42);
var fail = Result<int>.Failure("something went wrong");

Console.WriteLine(ok);    // Success(42)
Console.WriteLine(fail);  // Failure(something went wrong)