//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint3x3 : System.IEquatable<uint3x3>, IFormattable
    {
        public uint3 c0;
        public uint3 c1;
        public uint3 c2;

        /// <summary>uint3x3 identity transform.</summary>
        public static readonly uint3x3 identity = new uint3x3(1u, 0u, 0u,   0u, 1u, 0u,   0u, 0u, 1u);

        /// <summary>uint3x3 zero value.</summary>
        public static readonly uint3x3 zero;

        /// <summary>Constructs a uint3x3 matrix from three uint3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in uint3 c0, in uint3 c1, in uint3 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a uint3x3 matrix from 9 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(uint m00, uint m01, uint m02,
                       uint m10, uint m11, uint m12,
                       uint m20, uint m21, uint m22)
        { 
            this.c0 = new uint3(m00, m10, m20);
            this.c1 = new uint3(m01, m11, m21);
            this.c2 = new uint3(m02, m12, m22);
        }

        /// <summary>Constructs a uint3x3 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a uint3x3 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in bool v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v);
            this.c2 = math.select(new uint3(0u), new uint3(1u), v);
        }

        /// <summary>Constructs a uint3x3 matrix from a bool3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in bool3x3 v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v.c0);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v.c1);
            this.c2 = math.select(new uint3(0u), new uint3(1u), v.c2);
        }

        /// <summary>Constructs a uint3x3 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in int v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
        }

        /// <summary>Constructs a uint3x3 matrix from a int3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in int3x3 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
        }

        /// <summary>Constructs a uint3x3 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in float v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
        }

        /// <summary>Constructs a uint3x3 matrix from a float3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in float3x3 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
        }

        /// <summary>Constructs a uint3x3 matrix from a single double value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in double v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
        }

        /// <summary>Constructs a uint3x3 matrix from a double3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(in double3x3 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
        }


        /// <summary>Implicitly converts a single uint value to a uint3x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3x3(in uint v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a single bool value to a uint3x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in bool v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a bool3x3 matrix to a uint3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in bool3x3 v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a single int value to a uint3x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in int v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a int3x3 matrix to a uint3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in int3x3 v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a single float value to a uint3x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in float v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a float3x3 matrix to a uint3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in float3x3 v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a single double value to a uint3x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in double v) { return new uint3x3(v); }

        /// <summary>Explicitly converts a double3x3 matrix to a uint3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(in double3x3 v) { return new uint3x3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise increment operation on a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ++ (uint3x3 val) { return new uint3x3 (++val.c0, ++val.c1, ++val.c2); }


        /// <summary>Returns the result of a componentwise decrement operation on a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator -- (uint3x3 val) { return new uint3x3 (--val.c0, --val.c1, --val.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (in uint3x3 lhs, in uint3x3 rhs) { return new bool3x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (in uint3x3 lhs, in uint rhs) { return new bool3x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (in uint lhs, in uint3x3 rhs) { return new bool3x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (in uint3x3 lhs, in uint3x3 rhs) { return new bool3x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (in uint3x3 lhs, in uint rhs) { return new bool3x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (in uint lhs, in uint3x3 rhs) { return new bool3x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (in uint3x3 lhs, in uint3x3 rhs) { return new bool3x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (in uint3x3 lhs, in uint rhs) { return new bool3x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (in uint lhs, in uint3x3 rhs) { return new bool3x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (in uint3x3 lhs, in uint3x3 rhs) { return new bool3x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (in uint3x3 lhs, in uint rhs) { return new bool3x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (in uint lhs, in uint3x3 rhs) { return new bool3x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint3x3 val) { return new uint3x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise unary plus operation on a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint3x3 val) { return new uint3x3 (+val.c0, +val.c1, +val.c2); }


        /// <summary>Returns the result of a componentwise left shift operation on a uint3x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator << (in uint3x3 x, int n) { return new uint3x3 (x.c0 << n, x.c1 << n, x.c2 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a uint3x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator >> (in uint3x3 x, int n) { return new uint3x3 (x.c0 >> n, x.c1 >> n, x.c2 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (in uint3x3 lhs, in uint3x3 rhs) { return new bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (in uint3x3 lhs, in uint rhs) { return new bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (in uint lhs, in uint3x3 rhs) { return new bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (in uint3x3 lhs, in uint3x3 rhs) { return new bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (in uint3x3 lhs, in uint rhs) { return new bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (in uint lhs, in uint3x3 rhs) { return new bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ~ (uint3x3 val) { return new uint3x3 (~val.c0, ~val.c1, ~val.c2); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two uint3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (in uint3x3 lhs, in uint3x3 rhs) { return new uint3x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint3x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (in uint3x3 lhs, in uint rhs) { return new uint3x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (in uint lhs, in uint3x3 rhs) { return new uint3x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }



        /// <summary>Returns the uint3 element at a specified index.</summary>
        unsafe public ref uint3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint3x3* array = &this) { return ref ((uint3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the uint3x3 is equal to a given uint3x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(uint3x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the uint3x3 is equal to a given uint3x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((uint3x3)o); }


        /// <summary>Returns a hash code for the uint3x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the uint3x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

        /// <summary>Returns a string representation of the uint3x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a uint3x3 matrix constructed from three uint3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in uint3 c0, in uint3 c1, in uint3 c2) { return new uint3x3(c0, c1, c2); }

        /// <summary>Returns a uint3x3 matrix constructed from from 9 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(uint m00, uint m01, uint m02,
                                      uint m10, uint m11, uint m12,
                                      uint m20, uint m21, uint m22)
        {
            return new uint3x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22);
        }

        /// <summary>Returns a uint3x3 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in uint v) { return new uint3x3(v); }

        /// <summary>Returns a uint3x3 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in bool v) { return new uint3x3(v); }

        /// <summary>Return a uint3x3 matrix constructed from a bool3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in bool3x3 v) { return new uint3x3(v); }

        /// <summary>Returns a uint3x3 matrix constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in int v) { return new uint3x3(v); }

        /// <summary>Return a uint3x3 matrix constructed from a int3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in int3x3 v) { return new uint3x3(v); }

        /// <summary>Returns a uint3x3 matrix constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in float v) { return new uint3x3(v); }

        /// <summary>Return a uint3x3 matrix constructed from a float3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in float3x3 v) { return new uint3x3(v); }

        /// <summary>Returns a uint3x3 matrix constructed from a single double value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in double v) { return new uint3x3(v); }

        /// <summary>Return a uint3x3 matrix constructed from a double3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(in double3x3 v) { return new uint3x3(v); }

        /// <summary>Return the uint3x3 transpose of a uint3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 transpose(in uint3x3 v)
        {
            return uint3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

        /// <summary>Returns a uint hash code of a uint3x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(in uint3x3 v)
        {
            return csum(v.c0 * uint3(0xAC60D0C3u, 0x9263662Fu, 0xE69626FFu) + 
                        v.c1 * uint3(0xBD010EEBu, 0x9CEDE1D1u, 0x43BE0B51u) + 
                        v.c2 * uint3(0xAF836EE1u, 0xB130C137u, 0x54834775u)) + 0x7C022221u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a uint3x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(in uint3x3 v)
        {
            return (v.c0 * uint3(0xA2D00EDFu, 0xA8977779u, 0x9F1C739Bu) + 
                    v.c1 * uint3(0x4B1BD187u, 0x9DF50593u, 0xF18EEB85u) + 
                    v.c2 * uint3(0x9E19BFC3u, 0x8196B06Fu, 0xD24EFA19u)) + 0x7D8048BBu;
        }

    }
}
