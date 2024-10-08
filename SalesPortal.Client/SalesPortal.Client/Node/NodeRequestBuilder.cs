// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SalesPortal.Client.Node.CreateNode;
using SalesPortal.Client.Node.GetNode;
using SalesPortal.Client.Node.UpdateNode;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SalesPortal.Client.Node
{
    /// <summary>
    /// Builds and executes requests for operations under \Node
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    public partial class NodeRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The CreateNode property</summary>
        public global::SalesPortal.Client.Node.CreateNode.CreateNodeRequestBuilder CreateNode
        {
            get => new global::SalesPortal.Client.Node.CreateNode.CreateNodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetNode property</summary>
        public global::SalesPortal.Client.Node.GetNode.GetNodeRequestBuilder GetNode
        {
            get => new global::SalesPortal.Client.Node.GetNode.GetNodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The UpdateNode property</summary>
        public global::SalesPortal.Client.Node.UpdateNode.UpdateNodeRequestBuilder UpdateNode
        {
            get => new global::SalesPortal.Client.Node.UpdateNode.UpdateNodeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SalesPortal.Client.Node.NodeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NodeRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Node", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SalesPortal.Client.Node.NodeRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public NodeRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Node", rawUrl)
        {
        }
    }
}
#pragma warning restore CS0618
