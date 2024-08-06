using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Libsodium
    {
        internal const int crypto_aead_aegis256_ABYTES = 32;
        internal const int crypto_aead_aegis256_KEYBYTES = 32;
        internal const int crypto_aead_aegis256_NPUBBYTES = 32;
        internal const int crypto_aead_aegis256_NSECBYTES = 0;

        [LibraryImport(Libraries.Libsodium)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial nuint crypto_aead_aegis256_abytes();

        [LibraryImport(Libraries.Libsodium)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int crypto_aead_aegis256_decrypt(
            Span<byte> m,
            out ulong mlen_p,
            IntPtr nsec,
            ReadOnlySpan<byte> c,
            ulong clen,
            ReadOnlySpan<byte> ad,
            ulong adlen,
            ReadOnlySpan<byte> npub,
            SecureMemoryHandle k);

        [LibraryImport(Libraries.Libsodium)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial int crypto_aead_aegis256_encrypt(
            Span<byte> c,
            out ulong clen_p,
            ReadOnlySpan<byte> m,
            ulong mlen,
            ReadOnlySpan<byte> ad,
            ulong adlen,
            IntPtr nsec,
            ReadOnlySpan<byte> npub,
            SecureMemoryHandle k);

        [LibraryImport(Libraries.Libsodium)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial nuint crypto_aead_aegis256_keybytes();

        [LibraryImport(Libraries.Libsodium)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial nuint crypto_aead_aegis256_npubbytes();

        [LibraryImport(Libraries.Libsodium)]
        [UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
        internal static partial nuint crypto_aead_aegis256_nsecbytes();
    }
}