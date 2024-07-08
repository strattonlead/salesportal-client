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
    public partial class GetCompensationPlanResponse : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The compensationPlan property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SalesPortal.Client.Models.CompensationPlan? CompensationPlan { get; set; }
#nullable restore
#else
        public global::SalesPortal.Client.Models.CompensationPlan CompensationPlan { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SalesPortal.Client.Models.GetCompensationPlanResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SalesPortal.Client.Models.GetCompensationPlanResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SalesPortal.Client.Models.GetCompensationPlanResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "compensationPlan", n => { CompensationPlan = n.GetObjectValue<global::SalesPortal.Client.Models.CompensationPlan>(global::SalesPortal.Client.Models.CompensationPlan.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::SalesPortal.Client.Models.CompensationPlan>("compensationPlan", CompensationPlan);
        }
    }
}