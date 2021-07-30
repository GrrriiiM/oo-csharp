using System;

namespace oo_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ApresentarTipos();
        }

        static void ApresentarTipos()
        {

            Boolean var1 = default;
            Console.WriteLine($"{nameof(var1)} {var1} {var1.GetType().Name}");

            bool var1_ = default;
            Console.WriteLine($"{nameof(var1_)} {var1_} {var1_.GetType().Name}");

            var var1__ = false;
            Console.WriteLine($"{nameof(var1__)} {var1__} {var1__.GetType().Name}");

            Int16 var2 = default;
            Console.WriteLine($"{nameof(var2)} {var2} {var2.GetType().Name}");

            short var2_ = default;
            Console.WriteLine($"{nameof(var2_)} {var2_} {var2_.GetType().Name}");

            Int32 var3 = default;
            Console.WriteLine($"{nameof(var3)} {var3} {var3.GetType().Name}");

            int var3_ = default;
            Console.WriteLine($"{nameof(var3_)} {var3_} {var3_.GetType().Name}");

            var var3__ = 0;
            Console.WriteLine($"{nameof(var3__)} {var3__} {var3__.GetType().Name}");

            Int64 var4 = default;
            Console.WriteLine($"{nameof(var4)} {var4} {var4.GetType().Name}");

            long var4_ = default;
            Console.WriteLine($"{nameof(var4_)} {var4_} {var4_.GetType().Name}");

            var var4__ = 0L;
            Console.WriteLine($"{nameof(var4__)} {var4__} {var4__.GetType().Name}");

            Single var5 = default;
            Console.WriteLine($"{nameof(var5)} {var5} {var5.GetType().Name}");

            float var5_ = default;
            Console.WriteLine($"{nameof(var5_)} {var5_} {var5_.GetType().Name}");

            var var5__ = 0F;
            Console.WriteLine($"{nameof(var5__)} {var5__} {var5__.GetType().Name}");

            Double var6 = default;
            Console.WriteLine($"{nameof(var6)} {var6} {var6.GetType().Name}");

            double var6_ = default;
            Console.WriteLine($"{nameof(var6_)} {var6_} {var6_.GetType().Name}");

            var var6__ = 0D;
            Console.WriteLine($"{nameof(var6__)} {var6__} {var6__.GetType().Name}");

            Decimal var7 = default;
            Console.WriteLine($"{nameof(var7)} {var7} {var7.GetType().Name}");

            decimal var7_ = default;
            Console.WriteLine($"{nameof(var7_)} {var7_} {var7_.GetType().Name}");

            var var7__ = 0M;
            Console.WriteLine($"{nameof(var7__)} {var7__} {var7__.GetType().Name}");

            Char var8 = default;
            Console.WriteLine($"{nameof(var8)} {var8} {var8.GetType().Name}");

            char var8_ = default;
            Console.WriteLine($"{nameof(var8_)} {var8_} {var8_.GetType().Name}");

            var var8__ = 'a';
            Console.WriteLine($"{nameof(var8__)} {var8__} {var8__.GetType().Name}");
            
            String var9 = default;
            Console.WriteLine($"{nameof(var9)} {var9 ?? "null"} {(var9 = "").GetType().Name}");

            string var9_ = default;
            Console.WriteLine($"{nameof(var9_)} {var9_ ?? "null"} {(var9_ = "").GetType().Name}");

            var var9__ = "abc";
            Console.WriteLine($"{nameof(var9__)} {var9__ ?? "null"} {(var9__ = "").GetType().Name}");

            DateTime var10 = default;
            Console.WriteLine($"{nameof(var10)} {var10} {var10.GetType().Name}");

            var var10__ = new DateTime(2010, 1, 10);
            Console.WriteLine($"{nameof(var10__)} {var10__} {var10__.GetType().Name}");
        }
    }
}
