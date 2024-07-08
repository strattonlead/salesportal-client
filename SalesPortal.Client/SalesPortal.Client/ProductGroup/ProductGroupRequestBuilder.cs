// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SalesPortal.Client.ProductGroup.CreateProductGroup;
using SalesPortal.Client.ProductGroup.GetProductGroup;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SalesPortal.Client.ProductGroup
{
    /// <summary>
    /// Builds and executes requests for operations under \ProductGroup
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class ProductGroupRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The CreateProductGroup property</summary>
        public global::SalesPortal.Client.ProductGroup.CreateProductGroup.CreateProductGroupRequestBuilder CreateProductGroup
        {
            get => new global::SalesPortal.Client.ProductGroup.CreateProductGroup.CreateProductGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetProductGroup property</summary>
        public global::SalesPortal.Client.ProductGroup.GetProductGroup.GetProductGroupRequestBuilder GetProductGroup
        {
            get => new global::SalesPortal.Client.ProductGroup.GetProductGroup.GetProductGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SalesPortal.Client.ProductGroup.ProductGroupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductGroupRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ProductGroup", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SalesPortal.Client.ProductGroup.ProductGroupRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ProductGroupRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/ProductGroup", rawUrl)
        {
        }
    }
}