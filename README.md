# Fluent Strings

Powerful set of utilities for any kind of string transformations with fluent interface.

```
Project is still in development and some interfaces could be changed
```

## Examples

Let the code speak for itself.

### Insert operations

Something simple at the beginning:
```csharp
string transformed = "<-- some string will be inserted here".Insert("I am inserted!");
transformed.Should().Be("I am inserted!<-- some string will be inserted here");
```
Let's change the position:
```csharp
string transformed = "Some string will be inserted here -->".Insert("I am inserted!").To(The.End);
transformed.Should().Be("Some string will be inserted here -->I am inserted!");
```

And simply put something at the position we want:
```csharp
string transformed = "Start of the sentence <-- some string will be inserted here".Insert("I am inserted!").At(22);
transformed.Should().Be("Start of the sentence I am inserted!<-- some string will be inserted here");
```

Mixing up with markers:
```csharp
string transformed = "MARKER, another maRKer and... marker <-- some string will be inserted here"
                      .Insert("I am inserted!").After("marker ");
transformed.Should().Be("MARKER, another maRKer and... marker I am inserted!<-- some string will be inserted here");
```

Even ignoring case:
```csharp
string transformed = "Marker1, another maRKer2 and... marker <-- some string will be inserted here"
                      .Insert("I am inserted").After("MARKER ").IgnoringCase();
transformed.Should().Be("Marker1, another maRKer2 and... marker I am inserted<-- some string will be inserted here");
```

And applying all the power:
```csharp
string t = "Some string will be inserted before this second 'some' word, but not before this 'some'"
           .Insert("Look at me! I am inserted! ").Before(2, "some").IgnoringCase().From(The.Beginning);
t.Should().Be("Some string will be inserted before this second 'Look at me! I am inserted! some' word, but not before this 'some'");
```

### Remove operations

### Replace operations

### Truncate operations

Just playing around:
```csharp
string transformed = "Some very long string".TruncateTo(9);
transformed.Should().Be("Some very");

transformed = "Some very long string".TruncateTo(11).From(The.End);
transformed.Should().Be("long string");
```

And combining the knowledge:
```csharp
string transformed = "Some very long string".TruncateTo(9);
transformed = transformed.Insert("...").To(The.End);
transformed.Should().Be("Some very...");
```

### Utility operations

More examples could be found in [test classes](https://github.com/MSayfullin/FluentStrings/tree/master/FluentStrings.Tests)

## License

[Ms-PL](https://github.com/MSayfullin/FluentStrings/blob/master/LICENSE)

## Credits

Many thanks to [Fluent Assertions](http://fluentassertions.codeplex.com/) for making my testing experience awesome.
