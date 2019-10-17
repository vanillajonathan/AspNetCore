// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Microsoft.AspNetCore.DataProtection.AzureKeyVault.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f33a29044fa9d740c9b3213a93e57c84b472c84e0b8a0e1ae48e67a9f8f6de9d5f7f3d52ac23e48ac51801f1dc950abe901da34d2a9e3baadb141a17c77ef3c565dd5ee5054b91cf63bb3c6ab83f72ab3aafe93d0fc3c2348b764fafb0b1c0733de51459aeab46580384bf9d74c4e28164b7cde247f891ba07891c9d872ad2bb")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]

namespace Microsoft.AspNetCore.DataProtection.AzureKeyVault
{
    internal partial class AzureKeyVaultXmlDecryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor
    {
        public AzureKeyVaultXmlDecryptor(System.IServiceProvider serviceProvider) { }
        public System.Xml.Linq.XElement Decrypt(System.Xml.Linq.XElement encryptedElement) { throw null; }
    }
    internal partial class AzureKeyVaultXmlEncryptor : Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor
    {
        internal static string DefaultKeyEncryption;
        internal static System.Func<System.Security.Cryptography.SymmetricAlgorithm> DefaultSymmetricAlgorithmFactory;
        public AzureKeyVaultXmlEncryptor(Microsoft.AspNetCore.DataProtection.AzureKeyVault.IKeyVaultWrappingClient client, string keyId) { }
        internal AzureKeyVaultXmlEncryptor(Microsoft.AspNetCore.DataProtection.AzureKeyVault.IKeyVaultWrappingClient client, string keyId, System.Security.Cryptography.RandomNumberGenerator randomNumberGenerator) { }
        public Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo Encrypt(System.Xml.Linq.XElement plaintextElement) { throw null; }
    }
    internal partial interface IKeyVaultWrappingClient
    {
        System.Threading.Tasks.Task<Microsoft.Azure.KeyVault.Models.KeyOperationResult> UnwrapKeyAsync(string keyIdentifier, string algorithm, byte[] cipherText);
        System.Threading.Tasks.Task<Microsoft.Azure.KeyVault.Models.KeyOperationResult> WrapKeyAsync(string keyIdentifier, string algorithm, byte[] cipherText);
    }
}
