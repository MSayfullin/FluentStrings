# Fluent Strings

Powerful set of utilities for any kind of string transformations with fluent interface.

## Download

Fluent Strings can be downloaded either through [NuGet package](https://nuget.org/packages/dokas.FluentStrings/)
or as a [zip archive](https://github.com/MSayfullin/FluentStrings/releases)

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
           .Insert("I am inserted! ").Before(2, "some").IgnoringCase().From(The.Beginning);
t.Should().Be("Some string will be inserted before this second 'I am inserted! some' word, but not before this 'some'");
```

### Remove operations

Eliminating totally:
```csharp
string transformed = "Some string".Remove();
transformed.Should().Be(String.Empty);
```

Or part...
```csharp
string transformed = "THIS part of string will be removed".Remove("THIS");
transformed.Should().Be(" part of string will be removed");
```

...by part:
```csharp
string transformed = "THIS <- this string will be left, but this will be removed -> THIS".Remove("THIS").From(The.End);
transformed.Should().Be("THIS <- this string will be left, but this will be removed -> ");
```

By counting markers:
```csharp
string transformed = "String will be removed ->TEST and this will be removed also ->TEST, except this ->TEST"
                     .Remove(2, "TEST");
transformed.Should().Be("String will be removed -> and this will be removed also ->, except this ->TEST");
```

Or all of them at once:
```csharp
string transformed = "TEST string will be removed from both sides TEST".RemoveAll("tESt").IgnoringCase();
transformed.Should().Be(" string will be removed from both sides ");
```

Starting some position:
```csharp
string transformed = "Some very long string".Remove().Starting(position: 7).From(The.End);
transformed.Should().Be(" string");
```

Or to some marker:
```csharp
string transformed = "Some very VERY long string with very VERY long string at the end".Remove()
                     .To(The.EndOf, 3, of: "vERy").IgnoringCase().From(The.End);
transformed.Should().Be(" long string with very VERY long string at the end");
```

And starting to some positions:
```csharp
string transformed = "Some very long string".Remove().Starting(position: 9).To(position: 0);
transformed.Should().Be("Slong string");
```

### Remove operations for chars

Creating cool effects:
```csharp
string transformed = "Vowels will be removed from this string".RemoveVowels();
transformed.Should().Be("Vwls wll b rmvd frm ths strng");
```

For different culture as well:
```csharp
string transformed = "Очень длинная строка с русскими буквами, ё".RemoveVowels().For("ru");
transformed.Should().Be("чнь длнн стрк с рсскм бквм, ");
```

Or by specifying chars explicitly:
```csharp
string transformed = "Some very long string".RemoveChars('e', 'L', 'G').IgnoringCase();
transformed.Should().Be("Som vry on strin");
```

### Replace operations

Just replacing all for now:
```csharp
string transformed = "Some vERy long string".ReplaceAll("VerY").With("not very").IgnoringCase();
transformed.Should().Be("Some not very long string");
```

### Truncate operations

Just playing around:
```csharp
string transformed = "Some very long string".TruncateTo(9);
transformed.Should().Be("Some very");

transformed = "Some very long string".TruncateTo(11).From(The.End);
transformed.Should().Be("long string");
```

And doing ellipsis:
```csharp
string transformed = "Some very long string".TruncateTo(12).WithEllipsis();
transformed.Should().Be("Some very...");
```

### Utility operations

Better approach for well known:
```csharp
bool isEmpty = "".IsEmpty();
isEmpty.Should().Be(true);
```

Even for `null` case:
```csharp
string sample = null;
bool isEmpty = sample.IsEmpty();
isEmpty.Should().Be(true);
```

And continuing for white spaces:
```csharp
bool isEmptyOrWhiteSpace = "  ".IsEmpty().OrWhiteSpace();
isEmptyOrWhiteSpace.Should().Be(true);
```

Extending the basics:
```csharp
var indexes = "marker with another text marker and another text marker marker".IndexesOf("marker");
indexes.Should().ContainInOrder(0, 25, 49, 56);
```

Breaking restrictions:
```csharp
var indexes = "Some text MARKER another text MarKer marker".IndexesOf("mArkEr").IgnoringCase();
indexes.Should().ContainInOrder(10, 30, 37);
```

And plainly reverse the order:
```csharp
var indexes = "marker with another text marker and another text marker marker".IndexesOf("marker").From(The.End);
indexes.Should().ContainInOrder(56, 49, 25, 0);
```

*More examples could be found in [test classes](https://github.com/MSayfullin/FluentStrings/tree/master/FluentStrings.Tests)*

## License

[Ms-PL](https://github.com/MSayfullin/FluentStrings/blob/master/LICENSE)

## Credits

Many thanks to [Fluent Assertions](http://fluentassertions.codeplex.com/) for making my testing experience awesome.
