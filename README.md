# XamarinThemeManager

A simple program to manage Xamarin theme resource dictionaries.

## Usage

Use the namespace

```csharp
using Chardon.XamarinThemeManager;
```

Inherit `Chardon.XamarinThemeManager.ThemeManager` class

```csharp
public class MyThemeManager : ThemeManager
{
    public MyThemeManager()
    {
        base(/*...*/); // Designate default resource dictionaries to it.
    }
    
    // Your code
}
```

Or just use `Chardon.XamarinThemeManager.DefaultThemeManager`

```csharp
var myThemeManager = new DefaultThemeManager(/*...(Designate default resource dictionaries)*/);
```
