# Classes, Methods, & Namespaces

# Object Oriented Programming (OOP) Basics

### Classes

[Classes](https://github.com/nss-evening-cohort-8/bangazon-inc/blob/master/orientation/03_CLASSES.md) are the blueprints for your application. All classes ***must*** be instantiated with the `new` keyword before any of their properties or methods can be accessed or used, unless they use the `static` keyword. Static classes must be stateless.

If you've used classes in JavaScript, then C# is semantically similar; even if JavaScript's implementation is syntactic sugar. You always need to create an instance of a class prior to using it.

### Accessibility Modifiers

Depending on who is using your code, and in what context, you may want to restrict their ability to change or access certain pieces of code.

There are several different accessibility levels available in C#, but we'll primarily be talking about the two most common ones in class; `public` and `private`.

C# accessibility levels are a popular, trivia style, question in interviews so it might be worth your time to review all of them even if we don't really use most of them in class.

[Accessibility Levels - C# Reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/accessibility-levels)

### Properties and Fields

[Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties) & [Fields](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields) are provided as a way to store the state of your class. Idiomatic C# states that fields should be prefixed with an underscore (`_myPrivateField`) and properties are named using Camel Caps (`MyPublicProperty { get; set; }`).

There is a special version of Properties called ***Auto Properties*** that include the default getter and setter for the property.

```csharp
public string HomeAddress { get; set; }
```

You can also customize the accessibility of the getter or setter.

```csharp
public string SocialSecurityNumber { get; private set; }
```

Fields and Properties can be functionally equivalent using the proper access modifiers, but idiomatically speaking, Fields are intended for the internal state of the class and Properties are used to expose values to other areas of the application.

### Methods

You should already be familiar with [methods](https://github.com/nss-evening-cohort-8/bangazon-inc/blob/master/orientation/04_METHODS.md). They are simply functions attached to an object (or instantiated Class) that perform an action.

Take a moment to familiarize yourself with what makes up a [method signature](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods).

```csharp
public class Kangaroo
{
	public void Jump(int howHigh) // <-- method signature
	{
		// make the kangaroo jump
	}
}
```

[Constructor methods](https://github.com/nss-evening-cohort-8/bangazon-inc/blob/master/concepts/csharp-language/constructor-methods.md) are used for designing the initial state of your class

```csharp
public class Whozit
{
	public Whozit() // Named after the class it constructs
	{
		// initial state
	}
}
```

### Namespaces

[Namespacing](https://github.com/nss-evening-cohort-8/bangazon-inc/blob/master/orientation/05_NAMESPACING.md) is just a roadmap for the compiler to follow through your code. If you put something in a different namespace, then the compiler in Visual Studio (msbuild) won't be able to find it until you include that new namespace with `using`.

> A `using` statement is semantically equivalent to `require` or `import` in JavaScript.
>
