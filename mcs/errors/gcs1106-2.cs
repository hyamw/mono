// CS1106: `S<T>.Foo(this string)': Extension methods must be defined in a non-generic static class
// Line: 6
// Compiler options: -langversion:linq

static class S<T>
{
	static void Foo (this string s)
	{
	}
}
