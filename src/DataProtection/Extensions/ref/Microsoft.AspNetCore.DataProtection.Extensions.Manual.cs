// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Microsoft.AspNetCore.DataProtection.Extensions.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f33a29044fa9d740c9b3213a93e57c84b472c84e0b8a0e1ae48e67a9f8f6de9d5f7f3d52ac23e48ac51801f1dc950abe901da34d2a9e3baadb141a17c77ef3c565dd5ee5054b91cf63bb3c6ab83f72ab3aafe93d0fc3c2348b764fafb0b1c0733de51459aeab46580384bf9d74c4e28164b7cde247f891ba07891c9d872ad2bb")]

namespace Microsoft.AspNetCore.DataProtection
{
    public static partial class DataProtectionProvider
    {
        internal static Microsoft.AspNetCore.DataProtection.IDataProtectionProvider CreateProvider(System.IO.DirectoryInfo keyDirectory, System.Action<Microsoft.AspNetCore.DataProtection.IDataProtectionBuilder> setupAction, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
    }
    internal sealed partial class TimeLimitedDataProtector : Microsoft.AspNetCore.DataProtection.IDataProtectionProvider, Microsoft.AspNetCore.DataProtection.IDataProtector, Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector
    {
        public TimeLimitedDataProtector(Microsoft.AspNetCore.DataProtection.IDataProtector innerProtector) { }
        public Microsoft.AspNetCore.DataProtection.ITimeLimitedDataProtector CreateProtector(string purpose) { throw null; }
        Microsoft.AspNetCore.DataProtection.IDataProtector Microsoft.AspNetCore.DataProtection.IDataProtectionProvider.CreateProtector(string purpose) { throw null; }
        byte[] Microsoft.AspNetCore.DataProtection.IDataProtector.Protect(byte[] plaintext) { throw null; }
        byte[] Microsoft.AspNetCore.DataProtection.IDataProtector.Unprotect(byte[] protectedData) { throw null; }
        public byte[] Protect(byte[] plaintext, System.DateTimeOffset expiration) { throw null; }
        public byte[] Unprotect(byte[] protectedData, out System.DateTimeOffset expiration) { throw null; }
        internal byte[] UnprotectCore(byte[] protectedData, System.DateTimeOffset now, out System.DateTimeOffset expiration) { throw null; }
    }
}
namespace Microsoft.AspNetCore.DataProtection.Extensions
{
    internal static partial class Resources
    {
        internal static string CryptCommon_GenericError { get { throw null; } }
        internal static System.Globalization.CultureInfo Culture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        internal static System.Resources.ResourceManager ResourceManager { get { throw null; } }
        internal static string TimeLimitedDataProtector_PayloadExpired { get { throw null; } }
        internal static string TimeLimitedDataProtector_PayloadInvalid { get { throw null; } }
        internal static string FormatTimeLimitedDataProtector_PayloadExpired(object p0) { throw null; }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]internal static string GetResourceString(string resourceKey, string defaultValue = null) { throw null; }
    }
}
