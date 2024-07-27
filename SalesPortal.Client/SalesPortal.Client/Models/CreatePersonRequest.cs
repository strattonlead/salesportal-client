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
    public partial class CreatePersonRequest : IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The city property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>The companyName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>The country property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>The createCredential property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::SalesPortal.Client.Models.CreateCredentialRequest? CreateCredential { get; set; }
#nullable restore
#else
        public global::SalesPortal.Client.Models.CreateCredentialRequest CreateCredential { get; set; }
#endif
        /// <summary>The credentialId property</summary>
        public long? CredentialId { get; set; }
        /// <summary>The creditNotesWithTaxDate property</summary>
        public DateTimeOffset? CreditNotesWithTaxDate { get; set; }
        /// <summary>The firstName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FirstName { get; set; }
#nullable restore
#else
        public string FirstName { get; set; }
#endif
        /// <summary>The houseNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HouseNumber { get; set; }
#nullable restore
#else
        public string HouseNumber { get; set; }
#endif
        /// <summary>The isCreditNoteSendEnabled property</summary>
        public bool? IsCreditNoteSendEnabled { get; set; }
        /// <summary>The lastName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastName { get; set; }
#nullable restore
#else
        public string LastName { get; set; }
#endif
        /// <summary>The mail property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mail { get; set; }
#nullable restore
#else
        public string Mail { get; set; }
#endif
        /// <summary>The postalCode property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>The street property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Street { get; set; }
#nullable restore
#else
        public string Street { get; set; }
#endif
        /// <summary>The valueAddedTaxId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueAddedTaxId { get; set; }
#nullable restore
#else
        public string ValueAddedTaxId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::SalesPortal.Client.Models.CreatePersonRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::SalesPortal.Client.Models.CreatePersonRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::SalesPortal.Client.Models.CreatePersonRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "city", n => { City = n.GetStringValue(); } },
                { "companyName", n => { CompanyName = n.GetStringValue(); } },
                { "country", n => { Country = n.GetStringValue(); } },
                { "createCredential", n => { CreateCredential = n.GetObjectValue<global::SalesPortal.Client.Models.CreateCredentialRequest>(global::SalesPortal.Client.Models.CreateCredentialRequest.CreateFromDiscriminatorValue); } },
                { "credentialId", n => { CredentialId = n.GetLongValue(); } },
                { "creditNotesWithTaxDate", n => { CreditNotesWithTaxDate = n.GetDateTimeOffsetValue(); } },
                { "firstName", n => { FirstName = n.GetStringValue(); } },
                { "houseNumber", n => { HouseNumber = n.GetStringValue(); } },
                { "isCreditNoteSendEnabled", n => { IsCreditNoteSendEnabled = n.GetBoolValue(); } },
                { "lastName", n => { LastName = n.GetStringValue(); } },
                { "mail", n => { Mail = n.GetStringValue(); } },
                { "postalCode", n => { PostalCode = n.GetStringValue(); } },
                { "street", n => { Street = n.GetStringValue(); } },
                { "valueAddedTaxId", n => { ValueAddedTaxId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("country", Country);
            writer.WriteObjectValue<global::SalesPortal.Client.Models.CreateCredentialRequest>("createCredential", CreateCredential);
            writer.WriteLongValue("credentialId", CredentialId);
            writer.WriteDateTimeOffsetValue("creditNotesWithTaxDate", CreditNotesWithTaxDate);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteStringValue("houseNumber", HouseNumber);
            writer.WriteBoolValue("isCreditNoteSendEnabled", IsCreditNoteSendEnabled);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteStringValue("mail", Mail);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("street", Street);
            writer.WriteStringValue("valueAddedTaxId", ValueAddedTaxId);
        }
    }
}
