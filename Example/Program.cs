using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

const int SIZE = 4;

// Collection Expressions

Span<double> a = [1.0, 2.0, 3.0, 4.0];
Span<double> b = [5.0, 6.0, 7.0, 8.0];
Span<double> result = stackalloc double[4];

unsafe
{
    fixed (double* aP = a)
    fixed (double* bP = b)
    fixed (double* resultP = result)
    {
        for (int i = 0; i < SIZE; i += 2)
        {
            Vector128<double> va = Sse2.LoadVector128(&aP[i]);
            Vector128<double> vb = Sse2.LoadVector128(&bP[i]);

            Vector128<double> vr = Sse2.Add(va, vb);

            Sse2.Store(&resultP[i], vr);
        }
    }
}
