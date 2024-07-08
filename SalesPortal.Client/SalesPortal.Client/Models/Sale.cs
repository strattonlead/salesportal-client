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
    public partial class Sale : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The commissionShared property</summary>
        public double? CommissionShared { get; set; }
        /// <summary>The compensationPlan property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SalesPortal.Client.Models.CompensationPlan? CompensationPlan { get; set; }
#nullable restore
#else
        public global::SalesPortal.Client.Models.CompensationPlan CompensationPlan { get; set; }
#endif
        /// <summary>The compensationPlanId property</summary>
        public long? CompensationPlanId { get; set; }
        /// <summary>The date property</summary>
        public DateTimeOffset? Date { get; set; }
        /// <summary>The id property</summary>
        public long? Id { get; set; }
        /// <summary>The node property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SalesPortal.Client.Models.Node? Node { get; set; }
#nullable restore
#else
        public global::SalesPortal.Client.Models.Node Node { get; set; }
#endif
        /// <summary>The nodeId property</summary>
        public long? NodeId { get; set; }
        /// <summary>The product property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SalesPortal.Client.Models.Product? Product { get; set; }
#nullable restore
#else
        public global::SalesPortal.Client.Models.Product Product { get; set; }
#endif
        /// <summary>The productId property</summary>
        public long? ProductId { get; set; }
        /// <summary>The saleIdentifier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SaleIdentifier { get; set; }
#nullable restore
#else
        public string SaleIdentifier { get; set; }
#endif
        /// <summary>The totalCommissionValue property</summary>
        public double? TotalCommissionValue { get; set; }
        /// <summary>The totalValue property</summary>
        public double? TotalValue { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SalesPortal.Client.Models.Sale"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SalesPortal.Client.Models.Sale CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SalesPortal.Client.Models.Sale();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "commissionShared", n => { CommissionShared = n.GetDoubleValue(); } },
                { "compensationPlan", n => { CompensationPlan = n.GetObjectValue<global::SalesPortal.Client.Models.CompensationPlan>(global::SalesPortal.Client.Models.CompensationPlan.CreateFromDiscriminatorValue); } },
                { "compensationPlanId", n => { CompensationPlanId = n.GetLongValue(); } },
                { "date", n => { Date = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "node", n => { Node = n.GetObjectValue<global::SalesPortal.Client.Models.Node>(global::SalesPortal.Client.Models.Node.CreateFromDiscriminatorValue); } },
                { "nodeId", n => { NodeId = n.GetLongValue(); } },
                { "product", n => { Product = n.GetObjectValue<global::SalesPortal.Client.Models.Product>(global::SalesPortal.Client.Models.Product.CreateFromDiscriminatorValue); } },
                { "productId", n => { ProductId = n.GetLongValue(); } },
                { "saleIdentifier", n => { SaleIdentifier = n.GetStringValue(); } },
                { "totalCommissionValue", n => { TotalCommissionValue = n.GetDoubleValue(); } },
                { "totalValue", n => { TotalValue = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("commissionShared", CommissionShared);
            writer.WriteObjectValue<global::SalesPortal.Client.Models.CompensationPlan>("compensationPlan", CompensationPlan);
            writer.WriteLongValue("compensationPlanId", CompensationPlanId);
            writer.WriteDateTimeOffsetValue("date", Date);
            writer.WriteLongValue("id", Id);
            writer.WriteObjectValue<global::SalesPortal.Client.Models.Node>("node", Node);
            writer.WriteLongValue("nodeId", NodeId);
            writer.WriteObjectValue<global::SalesPortal.Client.Models.Product>("product", Product);
            writer.WriteLongValue("productId", ProductId);
            writer.WriteStringValue("saleIdentifier", SaleIdentifier);
            writer.WriteDoubleValue("totalCommissionValue", TotalCommissionValue);
            writer.WriteDoubleValue("totalValue", TotalValue);
        }
    }
}
