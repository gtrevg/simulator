// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/map/proto/map_speed_bump.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Hdmap {

  /// <summary>Holder for reflection information generated from modules/map/proto/map_speed_bump.proto</summary>
  public static partial class MapSpeedBumpReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/map/proto/map_speed_bump.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapSpeedBumpReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZtb2R1bGVzL21hcC9wcm90by9tYXBfc3BlZWRfYnVtcC5wcm90bxIMYXBv",
            "bGxvLmhkbWFwGh5tb2R1bGVzL21hcC9wcm90by9tYXBfaWQucHJvdG8aJG1v",
            "ZHVsZXMvbWFwL3Byb3RvL21hcF9nZW9tZXRyeS5wcm90byJ2CglTcGVlZEJ1",
            "bXASHAoCaWQYASABKAsyEC5hcG9sbG8uaGRtYXAuSWQSJAoKb3ZlcmxhcF9p",
            "ZBgCIAMoCzIQLmFwb2xsby5oZG1hcC5JZBIlCghwb3NpdGlvbhgDIAMoCzIT",
            "LmFwb2xsby5oZG1hcC5DdXJ2ZWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Hdmap.MapIdReflection.Descriptor, global::Apollo.Hdmap.MapGeometryReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.SpeedBump), global::Apollo.Hdmap.SpeedBump.Parser, new[]{ "Id", "OverlapId", "Position" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SpeedBump : pb::IMessage<SpeedBump> {
    private static readonly pb::MessageParser<SpeedBump> _parser = new pb::MessageParser<SpeedBump>(() => new SpeedBump());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SpeedBump> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapSpeedBumpReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeedBump() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeedBump(SpeedBump other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      overlapId_ = other.overlapId_.Clone();
      position_ = other.position_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SpeedBump Clone() {
      return new SpeedBump(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private global::Apollo.Hdmap.Id id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Id Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "overlap_id" field.</summary>
    public const int OverlapIdFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Id> _repeated_overlapId_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Hdmap.Id.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Id> overlapId_ = new pbc::RepeatedField<global::Apollo.Hdmap.Id>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Id> OverlapId {
      get { return overlapId_; }
    }

    /// <summary>Field number for the "position" field.</summary>
    public const int PositionFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Curve> _repeated_position_codec
        = pb::FieldCodec.ForMessage(26, global::Apollo.Hdmap.Curve.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Curve> position_ = new pbc::RepeatedField<global::Apollo.Hdmap.Curve>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Curve> Position {
      get { return position_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SpeedBump);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SpeedBump other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if(!overlapId_.Equals(other.overlapId_)) return false;
      if(!position_.Equals(other.position_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      hash ^= overlapId_.GetHashCode();
      hash ^= position_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (id_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Id);
      }
      overlapId_.WriteTo(output, _repeated_overlapId_codec);
      position_.WriteTo(output, _repeated_position_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      size += overlapId_.CalculateSize(_repeated_overlapId_codec);
      size += position_.CalculateSize(_repeated_position_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SpeedBump other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::Apollo.Hdmap.Id();
        }
        Id.MergeFrom(other.Id);
      }
      overlapId_.Add(other.overlapId_);
      position_.Add(other.position_);
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
            if (id_ == null) {
              id_ = new global::Apollo.Hdmap.Id();
            }
            input.ReadMessage(id_);
            break;
          }
          case 18: {
            overlapId_.AddEntriesFrom(input, _repeated_overlapId_codec);
            break;
          }
          case 26: {
            position_.AddEntriesFrom(input, _repeated_position_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
