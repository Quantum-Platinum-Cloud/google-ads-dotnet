// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v12/resources/ad_group_asset.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V12.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v12/resources/ad_group_asset.proto</summary>
  public static partial class AdGroupAssetReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v12/resources/ad_group_asset.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupAssetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvcmVzb3VyY2VzL2FkX2dyb3Vw",
            "X2Fzc2V0LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTIucmVzb3Vy",
            "Y2VzGjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTIvZW51bXMvYXNzZXRfZmll",
            "bGRfdHlwZS5wcm90bxo2Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjEyL2VudW1z",
            "L2Fzc2V0X2xpbmtfc3RhdHVzLnByb3RvGjFnb29nbGUvYWRzL2dvb2dsZWFk",
            "cy92MTIvZW51bXMvYXNzZXRfc291cmNlLnByb3RvGh9nb29nbGUvYXBpL2Zp",
            "ZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3Rv",
            "IswECgxBZEdyb3VwQXNzZXQSRAoNcmVzb3VyY2VfbmFtZRgBIAEoCUIt4EEF",
            "+kEnCiVnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQWRHcm91cEFzc2V0Ej0K",
            "CGFkX2dyb3VwGAIgASgJQivgQQLgQQX6QSIKIGdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9BZEdyb3VwEjgKBWFzc2V0GAMgASgJQingQQLgQQX6QSAKHmdv",
            "b2dsZWFkcy5nb29nbGVhcGlzLmNvbS9Bc3NldBJdCgpmaWVsZF90eXBlGAQg",
            "ASgOMkEuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLmVudW1zLkFzc2V0Rmll",
            "bGRUeXBlRW51bS5Bc3NldEZpZWxkVHlwZUIG4EEC4EEFElAKBnNvdXJjZRgG",
            "IAEoDjI7Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxMi5lbnVtcy5Bc3NldFNv",
            "dXJjZUVudW0uQXNzZXRTb3VyY2VCA+BBAxJTCgZzdGF0dXMYBSABKA4yQy5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MTIuZW51bXMuQXNzZXRMaW5rU3RhdHVz",
            "RW51bS5Bc3NldExpbmtTdGF0dXM6d+pBdAolZ29vZ2xlYWRzLmdvb2dsZWFw",
            "aXMuY29tL0FkR3JvdXBBc3NldBJLY3VzdG9tZXJzL3tjdXN0b21lcl9pZH0v",
            "YWRHcm91cEFzc2V0cy97YWRfZ3JvdXBfaWR9fnthc3NldF9pZH1+e2ZpZWxk",
            "X3R5cGV9QoMCCiZjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEyLnJlc291",
            "cmNlc0IRQWRHcm91cEFzc2V0UHJvdG9QAVpLZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMi9yZXNvdXJj",
            "ZXM7cmVzb3VyY2VzogIDR0FBqgIiR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEy",
            "LlJlc291cmNlc8oCIkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxMlxSZXNvdXJj",
            "ZXPqAiZHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTI6OlJlc291cmNlc2IG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeReflection.Descriptor, global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusReflection.Descriptor, global::Google.Ads.GoogleAds.V12.Enums.AssetSourceReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V12.Resources.AdGroupAsset), global::Google.Ads.GoogleAds.V12.Resources.AdGroupAsset.Parser, new[]{ "ResourceName", "AdGroup", "Asset", "FieldType", "Source", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A link between an ad group and an asset.
  /// </summary>
  public sealed partial class AdGroupAsset : pb::IMessage<AdGroupAsset>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdGroupAsset> _parser = new pb::MessageParser<AdGroupAsset>(() => new AdGroupAsset());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AdGroupAsset> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V12.Resources.AdGroupAssetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAsset() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAsset(AdGroupAsset other) : this() {
      resourceName_ = other.resourceName_;
      adGroup_ = other.adGroup_;
      asset_ = other.asset_;
      fieldType_ = other.fieldType_;
      source_ = other.source_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AdGroupAsset Clone() {
      return new AdGroupAsset(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the ad group asset.
    /// AdGroupAsset resource names have the form:
    ///
    /// `customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ad_group" field.</summary>
    public const int AdGroupFieldNumber = 2;
    private string adGroup_ = "";
    /// <summary>
    /// Required. Immutable. The ad group to which the asset is linked.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdGroup {
      get { return adGroup_; }
      set {
        adGroup_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 3;
    private string asset_ = "";
    /// <summary>
    /// Required. Immutable. The asset which is linked to the ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "field_type" field.</summary>
    public const int FieldTypeFieldNumber = 4;
    private global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType fieldType_ = global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified;
    /// <summary>
    /// Required. Immutable. Role that the asset takes under the linked ad group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType FieldType {
      get { return fieldType_; }
      set {
        fieldType_ = value;
      }
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 6;
    private global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource source_ = global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource.Unspecified;
    /// <summary>
    /// Output only. Source of the adgroup asset link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource Source {
      get { return source_; }
      set {
        source_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus status_ = global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified;
    /// <summary>
    /// Status of the ad group asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AdGroupAsset);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AdGroupAsset other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (AdGroup != other.AdGroup) return false;
      if (Asset != other.Asset) return false;
      if (FieldType != other.FieldType) return false;
      if (Source != other.Source) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (AdGroup.Length != 0) hash ^= AdGroup.GetHashCode();
      if (Asset.Length != 0) hash ^= Asset.GetHashCode();
      if (FieldType != global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) hash ^= FieldType.GetHashCode();
      if (Source != global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) hash ^= Source.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) hash ^= Status.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (Source != global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Source);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (AdGroup.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(AdGroup);
      }
      if (Asset.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        output.WriteRawTag(32);
        output.WriteEnum((int) FieldType);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (Source != global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Source);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (AdGroup.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdGroup);
      }
      if (Asset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (FieldType != global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) FieldType);
      }
      if (Source != global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
      }
      if (Status != global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AdGroupAsset other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.AdGroup.Length != 0) {
        AdGroup = other.AdGroup;
      }
      if (other.Asset.Length != 0) {
        Asset = other.Asset;
      }
      if (other.FieldType != global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType.Unspecified) {
        FieldType = other.FieldType;
      }
      if (other.Source != global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource.Unspecified) {
        Source = other.Source;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus.Unspecified) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            Source = (global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            AdGroup = input.ReadString();
            break;
          }
          case 26: {
            Asset = input.ReadString();
            break;
          }
          case 32: {
            FieldType = (global::Google.Ads.GoogleAds.V12.Enums.AssetFieldTypeEnum.Types.AssetFieldType) input.ReadEnum();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V12.Enums.AssetLinkStatusEnum.Types.AssetLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            Source = (global::Google.Ads.GoogleAds.V12.Enums.AssetSourceEnum.Types.AssetSource) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
