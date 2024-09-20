using System.Numerics;

object foo = 123;
var bar = foo as INumber<int>;
Console.WriteLine(bar is null);
_ = foo as INumber<int>;
_ = foo is INumber<int>;
var goo = (int)foo;
Foo<int>(ref goo);
Span<int> zz = [1, 2, 3];
foreach (ref var item in zz)
{
    item.Dump();
    ref int t = ref item;
    scoped ref int r = ref item;
}
static void Bar(ref int t) { }
static void Var(out int t) { t = default; }
static void Ear(scoped ref int t) { }
static void Gar(scoped Foo t) { }
static void Goo(ref readonly int t) { }
static void Foo<[typevar: Foo] T>(ref int a) => Console.WriteLine();
static void Hoo(params int[]? t) { }
static class Boo
{
    public static void Too(this int t) { }
    public static void Bot(this ref int t) { }
    public static void Eot(this scoped ref int t) { }
    public static void Goo(this ref readonly int t) { }
}
[System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
sealed class FooAttribute : System.Attribute;
ref struct Foo;
readonly ref struct Goo;
record class Doo;
