// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions;
using SalesPortal.Client.Sale.CreateSale;
using SalesPortal.Client.Sale.GetSale;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System;
namespace SalesPortal.Client.Sale
{
    /// <summary>
    /// Builds and executes requests for operations under \Sale
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    public partial class SaleRequestBuilder : BaseRequestBuilder
    {
        /// <summary>The CreateSale property</summary>
        public global::SalesPortal.Client.Sale.CreateSale.CreateSaleRequestBuilder CreateSale
        {
            get => new global::SalesPortal.Client.Sale.CreateSale.CreateSaleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The GetSale property</summary>
        public global::SalesPortal.Client.Sale.GetSale.GetSaleRequestBuilder GetSale
        {
            get => new global::SalesPortal.Client.Sale.GetSale.GetSaleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SalesPortal.Client.Sale.SaleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SaleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sale", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::SalesPortal.Client.Sale.SaleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SaleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/Sale", rawUrl)
        {
        }
    }
}