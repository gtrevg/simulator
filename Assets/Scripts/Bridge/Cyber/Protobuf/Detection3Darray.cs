// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/common/proto/detection3darray.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Common {

  /// <summary>Holder for reflection information generated from modules/common/proto/detection3darray.proto</summary>
  public static partial class Detection3DarrayReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/common/proto/detection3darray.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static Detection3DarrayReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cittb2R1bGVzL2NvbW1vbi9wcm90by9kZXRlY3Rpb24zZGFycmF5LnByb3Rv",
            "Eg1hcG9sbG8uY29tbW9uGiFtb2R1bGVzL2NvbW1vbi9wcm90by9oZWFkZXIu",
            "cHJvdG8aJm1vZHVsZXMvY29tbW9uL3Byb3RvL2RldGVjdGlvbjNkLnByb3Rv",
            "ImkKEERldGVjdGlvbjNEQXJyYXkSJQoGaGVhZGVyGAEgASgLMhUuYXBvbGxv",
            "LmNvbW1vbi5IZWFkZXISLgoKZGV0ZWN0aW9ucxgCIAMoCzIaLmFwb2xsby5j",
            "b21tb24uRGV0ZWN0aW9uM0RiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Common.HeaderReflection.Descriptor, global::Apollo.Common.Detection3DReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Common.Detection3DArray), global::Apollo.Common.Detection3DArray.Parser, new[]{ "Header", "Detections" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Detection3DArray : pb::IMessage<Detection3DArray> {
    private static readonly pb::MessageParser<Detection3DArray> _parser = new pb::MessageParser<Detection3DArray>(() => new Detection3DArray());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Detection3DArray> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Common.Detection3DarrayReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Detection3DArray() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Detection3DArray(Detection3DArray other) : this() {
      Header = other.header_ != null ? other.Header.Clone() : null;
      detections_ = other.detections_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Detection3DArray Clone() {
      return new Detection3DArray(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Apollo.Common.Header header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Common.Header Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "detections" field.</summary>
    public const int DetectionsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Common.Detection3D> _repeated_detections_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Common.Detection3D.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Common.Detection3D> detections_ = new pbc::RepeatedField<global::Apollo.Common.Detection3D>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Common.Detection3D> Detections {
      get { return detections_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Detection3DArray);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Detection3DArray other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if(!detections_.Equals(other.detections_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      hash ^= detections_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      detections_.WriteTo(output, _repeated_detections_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      size += detections_.CalculateSize(_repeated_detections_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Detection3DArray other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          header_ = new global::Apollo.Common.Header();
        }
        Header.MergeFrom(other.Header);
      }
      detections_.Add(other.detections_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (header_ == null) {
              header_ = new global::Apollo.Common.Header();
            }
            input.ReadMessage(header_);
            break;
          }
          case 18: {
            detections_.AddEntriesFrom(input, _repeated_detections_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
