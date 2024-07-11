// <auto-generated/>
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SalesPortal.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.16.0")]
    #pragma warning disable CS1591
    public partial class CreditNotePagedList : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The count property</summary>
        public long? Count { get; set; }
        /// <summary>The data property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::SalesPortal.Client.Models.CreditNote>? Data { get; set; }
#nullable restore
#else
        public List<global::SalesPortal.Client.Models.CreditNote> Data { get; set; }
#endif
        /// <summary>The page property</summary>
        public long? Page { get; set; }
        /// <summary>The search property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Search { get; set; }
#nullable restore
#else
        public string Search { get; set; }
#endif
        /// <summary>The totalCount property</summary>
        public long? TotalCount { get; set; }
        /// <summary>The totalPages property</summary>
        public long? TotalPages { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SalesPortal.Client.Models.CreditNotePagedList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SalesPortal.Client.Models.CreditNotePagedList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SalesPortal.Client.Models.CreditNotePagedList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "count", n => { Count = n.GetLongValue(); } },
                { "data", n => { Data = n.GetCollectionOfObjectValues<global::SalesPortal.Client.Models.CreditNote>(global::SalesPortal.Client.Models.CreditNote.CreateFromDiscriminatorValue)?.AsList(); } },
                { "page", n => { Page = n.GetLongValue(); } },
                { "search", n => { Search = n.GetStringValue(); } },
                { "totalCount", n => { TotalCount = n.GetLongValue(); } },
                { "totalPages", n => { TotalPages = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("count", Count);
            writer.WriteCollectionOfObjectValues<global::SalesPortal.Client.Models.CreditNote>("data", Data);
            writer.WriteLongValue("page", Page);
            writer.WriteStringValue("search", Search);
            writer.WriteLongValue("totalCount", TotalCount);
            writer.WriteLongValue("totalPages", TotalPages);
        }
    }
}
