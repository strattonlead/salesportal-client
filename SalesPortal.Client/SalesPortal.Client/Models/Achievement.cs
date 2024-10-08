// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace SalesPortal.Client.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.19.0")]
    #pragma warning disable CS1591
    public partial class Achievement : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The achievementDefinition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SalesPortal.Client.Models.AchievementDefinition? AchievementDefinition { get; set; }
#nullable restore
#else
        public global::SalesPortal.Client.Models.AchievementDefinition AchievementDefinition { get; set; }
#endif
        /// <summary>The achievementDefinitionId property</summary>
        public long? AchievementDefinitionId { get; set; }
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
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SalesPortal.Client.Models.Achievement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SalesPortal.Client.Models.Achievement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SalesPortal.Client.Models.Achievement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "achievementDefinition", n => { AchievementDefinition = n.GetObjectValue<global::SalesPortal.Client.Models.AchievementDefinition>(global::SalesPortal.Client.Models.AchievementDefinition.CreateFromDiscriminatorValue); } },
                { "achievementDefinitionId", n => { AchievementDefinitionId = n.GetLongValue(); } },
                { "date", n => { Date = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetLongValue(); } },
                { "node", n => { Node = n.GetObjectValue<global::SalesPortal.Client.Models.Node>(global::SalesPortal.Client.Models.Node.CreateFromDiscriminatorValue); } },
                { "nodeId", n => { NodeId = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::SalesPortal.Client.Models.AchievementDefinition>("achievementDefinition", AchievementDefinition);
            writer.WriteLongValue("achievementDefinitionId", AchievementDefinitionId);
            writer.WriteDateTimeOffsetValue("date", Date);
            writer.WriteLongValue("id", Id);
            writer.WriteObjectValue<global::SalesPortal.Client.Models.Node>("node", Node);
            writer.WriteLongValue("nodeId", NodeId);
        }
    }
}
#pragma warning restore CS0618
