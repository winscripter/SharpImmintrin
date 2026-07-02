global using __m128d = System.Runtime.Intrinsics.Vector128<double>;
global using __m128 = System.Runtime.Intrinsics.Vector128<float>;
global using __m128i = System.Runtime.Intrinsics.Vector128<byte>;
global using __128i = System.Runtime.Intrinsics.Vector128<byte>;

global using __m256d = System.Runtime.Intrinsics.Vector256<double>;
global using __m256 = System.Runtime.Intrinsics.Vector256<float>;
global using __m256i = System.Runtime.Intrinsics.Vector256<byte>;

global using __m512d = System.Runtime.Intrinsics.Vector512<double>;
global using __m512 = System.Runtime.Intrinsics.Vector512<float>;
global using __m512i = System.Runtime.Intrinsics.Vector512<byte>;

global using __mmask8 = byte;
global using __mmask16 = ushort;
global using __mmask32 = uint;
global using __mmask64 = ulong;
global using __mask8 = byte;
global using __int64 = long;
global using __m64 = float;

// GlobalUsings.cs
global using int8x8_t = System.Runtime.Intrinsics.Vector64<sbyte>;
global using int8x16_t = System.Runtime.Intrinsics.Vector128<sbyte>;
global using int16x4_t = System.Runtime.Intrinsics.Vector64<short>;
global using int16x8_t = System.Runtime.Intrinsics.Vector128<short>;
global using int32x2_t = System.Runtime.Intrinsics.Vector64<int>;
global using int32x4_t = System.Runtime.Intrinsics.Vector128<int>;
global using int64x1_t = System.Runtime.Intrinsics.Vector64<long>;
global using int64x2_t = System.Runtime.Intrinsics.Vector128<long>;

global using uint8x8_t = System.Runtime.Intrinsics.Vector64<byte>;
global using uint8x16_t = System.Runtime.Intrinsics.Vector128<byte>;
global using uint16x4_t = System.Runtime.Intrinsics.Vector64<ushort>;
global using uint16x8_t = System.Runtime.Intrinsics.Vector128<ushort>;
global using uint32x2_t = System.Runtime.Intrinsics.Vector64<uint>;
global using uint32x4_t = System.Runtime.Intrinsics.Vector128<uint>;
global using uint64x1_t = System.Runtime.Intrinsics.Vector64<ulong>;
global using uint64x2_t = System.Runtime.Intrinsics.Vector128<ulong>;

global using float32x2_t = System.Runtime.Intrinsics.Vector64<float>;
global using float32x4_t = System.Runtime.Intrinsics.Vector128<float>;
global using float64x1_t = System.Runtime.Intrinsics.Vector64<double>;
global using float64x2_t = System.Runtime.Intrinsics.Vector128<double>;

// Poly types (crypto NEON) map to integer vectors

global using uint8_t = byte;
global using uint16_t = ushort;
global using uint32_t = uint;
global using uint64_t = ulong;
global using int8_t = sbyte;
global using int16_t = short;
global using int32_t = int;
global using int64_t = long;
global using float32_t = float;
global using float64_t = double;

global using int8x16x2_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>>;
global using float32x2x2_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Single>, System.Runtime.Intrinsics.Vector128<System.Single>>;
global using int32x4x2_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Int32>, System.Runtime.Intrinsics.Vector128<System.Int32>>;
global using int16x8x2_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Int16>, System.Runtime.Intrinsics.Vector128<System.Int16>>;
global using int8x16x3_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>>;
global using int16x8x3_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Int16>, System.Runtime.Intrinsics.Vector128<System.Int16>, System.Runtime.Intrinsics.Vector128<System.Int16>>;
global using int32x4x3_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Int32>, System.Runtime.Intrinsics.Vector128<System.Int32>, System.Runtime.Intrinsics.Vector128<System.Int32>>;
global using float32x2x3_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Single>, System.Runtime.Intrinsics.Vector128<System.Single>, System.Runtime.Intrinsics.Vector128<System.Single>>;
global using int8x16x4_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>>;
global using int16x8x4_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Int16>, System.Runtime.Intrinsics.Vector128<System.Int16>, System.Runtime.Intrinsics.Vector128<System.Int16>, System.Runtime.Intrinsics.Vector128<System.Int16>>;
global using int32x4x4_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Int32>, System.Runtime.Intrinsics.Vector128<System.Int32>, System.Runtime.Intrinsics.Vector128<System.Int32>, System.Runtime.Intrinsics.Vector128<System.Int32>>;
global using float32x2x4_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Single>, System.Runtime.Intrinsics.Vector128<System.Single>, System.Runtime.Intrinsics.Vector128<System.Single>, System.Runtime.Intrinsics.Vector128<System.Single>>;
global using uint8x16x2_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>>;
global using uint8x16x3_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>>;
global using uint8x16x4_t = System.ValueTuple<System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>, System.Runtime.Intrinsics.Vector128<System.Byte>>;

global using poly8x8_t = System.Runtime.Intrinsics.Vector64<byte>;
global using poly8x16_t = System.Runtime.Intrinsics.Vector128<byte>;
global using poly16x8_t = System.Runtime.Intrinsics.Vector64<byte>;
