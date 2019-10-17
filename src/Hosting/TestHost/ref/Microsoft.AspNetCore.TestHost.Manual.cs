// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Microsoft.AspNetCore.TestHost.Tests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100f33a29044fa9d740c9b3213a93e57c84b472c84e0b8a0e1ae48e67a9f8f6de9d5f7f3d52ac23e48ac51801f1dc950abe901da34d2a9e3baadb141a17c77ef3c565dd5ee5054b91cf63bb3c6ab83f72ab3aafe93d0fc3c2348b764fafb0b1c0733de51459aeab46580384bf9d74c4e28164b7cde247f891ba07891c9d872ad2bb")]


namespace Microsoft.AspNetCore.TestHost
{
    public partial class ClientHandler : System.Net.Http.HttpMessageHandler
    {
        internal ClientHandler(Microsoft.AspNetCore.Http.PathString pathBase, Microsoft.AspNetCore.TestHost.ApplicationWrapper application) { }
    }
    internal partial class ResponseFeature : Microsoft.AspNetCore.Http.Features.IHttpResponseBodyFeature, Microsoft.AspNetCore.Http.Features.IHttpResponseFeature
    {
        public ResponseFeature(System.Action<System.Exception> abort) { }
        public System.IO.Stream Body { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        internal System.IO.Pipelines.PipeWriter BodyWriter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool HasStarted { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.AspNetCore.Http.IHeaderDictionary Headers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ReasonPhrase { get { throw null; } set { } }
        public int StatusCode { get { throw null; } set { } }
        public System.IO.Stream Stream { get { throw null; } }
        public System.IO.Pipelines.PipeWriter Writer { get { throw null; } }
        public System.Threading.Tasks.Task CompleteAsync() { throw null; }
        public void DisableBuffering() { }
        public System.Threading.Tasks.Task FireOnResponseCompletedAsync() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task FireOnSendingHeadersAsync() { throw null; }
        public void OnCompleted(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        public void OnStarting(System.Func<object, System.Threading.Tasks.Task> callback, object state) { }
        public System.Threading.Tasks.Task SendFileAsync(string path, long offset, long? count, System.Threading.CancellationToken cancellation) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public System.Threading.Tasks.Task StartAsync(System.Threading.CancellationToken token = default(System.Threading.CancellationToken)) { throw null; }
    }
    internal abstract partial class ApplicationWrapper
    {
        protected ApplicationWrapper() { }
        internal abstract object CreateContext(Microsoft.AspNetCore.Http.Features.IFeatureCollection features);
        internal abstract void DisposeContext(object context, System.Exception exception);
        internal abstract System.Threading.Tasks.Task ProcessRequestAsync(object context);
    }
}