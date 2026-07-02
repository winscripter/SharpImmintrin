namespace SharpImmintrin;

public static partial class CIntrinsicX86Avx
{
    /// <summary>
    ///     See <see cref="System.Runtime.Intrinsics.Vector256{Byte}.Zero"/>
    /// </summary>
    public static __m256i _mm256_setzero_si256()
    {
        throw new InvalidOperationException("Replace with System.Runtime.Intrinsics.Vector256<byte>.Zero");
    }
}

public static partial class CIntrinsicX86Sse2
{
    /// <summary>
    ///     See <see cref="System.Runtime.Intrinsics.Vector128{Byte}.Zero"/>
    /// </summary>
    public static __m128i _mm_setzero_si128()
    {
        throw new InvalidOperationException("Replace with System.Runtime.Intrinsics.Vector128<byte>.Zero");
    }
}
