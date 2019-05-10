// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/map/proto/map_road.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Hdmap {

  /// <summary>Holder for reflection information generated from modules/map/proto/map_road.proto</summary>
  public static partial class MapRoadReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/map/proto/map_road.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MapRoadReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBtb2R1bGVzL21hcC9wcm90by9tYXBfcm9hZC5wcm90bxIMYXBvbGxvLmhk",
            "bWFwGiRtb2R1bGVzL21hcC9wcm90by9tYXBfZ2VvbWV0cnkucHJvdG8aHm1v",
            "ZHVsZXMvbWFwL3Byb3RvL21hcF9pZC5wcm90byKpAQoMQm91bmRhcnlFZGdl",
            "EiIKBWN1cnZlGAEgASgLMhMuYXBvbGxvLmhkbWFwLkN1cnZlEi0KBHR5cGUY",
            "AiABKA4yHy5hcG9sbG8uaGRtYXAuQm91bmRhcnlFZGdlLlR5cGUiRgoEVHlw",
            "ZRILCgdVTktOT1dOEAASCgoGTk9STUFMEAESEQoNTEVGVF9CT1VOREFSWRAC",
            "EhIKDlJJR0hUX0JPVU5EQVJZEAMiOwoPQm91bmRhcnlQb2x5Z29uEigKBGVk",
            "Z2UYASADKAsyGi5hcG9sbG8uaGRtYXAuQm91bmRhcnlFZGdlInEKDFJvYWRC",
            "b3VuZGFyeRI0Cg1vdXRlcl9wb2x5Z29uGAEgASgLMh0uYXBvbGxvLmhkbWFw",
            "LkJvdW5kYXJ5UG9seWdvbhIrCgRob2xlGAIgAygLMh0uYXBvbGxvLmhkbWFw",
            "LkJvdW5kYXJ5UG9seWdvbiJkCg9Sb2FkUk9JQm91bmRhcnkSHAoCaWQYASAB",
            "KAsyEC5hcG9sbG8uaGRtYXAuSWQSMwoPcm9hZF9ib3VuZGFyaWVzGAIgAygL",
            "MhouYXBvbGxvLmhkbWFwLlJvYWRCb3VuZGFyeSJ8CgtSb2FkU2VjdGlvbhIc",
            "CgJpZBgBIAEoCzIQLmFwb2xsby5oZG1hcC5JZBIhCgdsYW5lX2lkGAIgAygL",
            "MhAuYXBvbGxvLmhkbWFwLklkEiwKCGJvdW5kYXJ5GAMgASgLMhouYXBvbGxv",
            "LmhkbWFwLlJvYWRCb3VuZGFyeSJ3CgRSb2FkEhwKAmlkGAEgASgLMhAuYXBv",
            "bGxvLmhkbWFwLklkEioKB3NlY3Rpb24YAiADKAsyGS5hcG9sbG8uaGRtYXAu",
            "Um9hZFNlY3Rpb24SJQoLanVuY3Rpb25faWQYAyABKAsyEC5hcG9sbG8uaGRt",
            "YXAuSWRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Hdmap.MapGeometryReflection.Descriptor, global::Apollo.Hdmap.MapIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.BoundaryEdge), global::Apollo.Hdmap.BoundaryEdge.Parser, new[]{ "Curve", "Type" }, null, new[]{ typeof(global::Apollo.Hdmap.BoundaryEdge.Types.Type) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.BoundaryPolygon), global::Apollo.Hdmap.BoundaryPolygon.Parser, new[]{ "Edge" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.RoadBoundary), global::Apollo.Hdmap.RoadBoundary.Parser, new[]{ "OuterPolygon", "Hole" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.RoadROIBoundary), global::Apollo.Hdmap.RoadROIBoundary.Parser, new[]{ "Id", "RoadBoundaries" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.RoadSection), global::Apollo.Hdmap.RoadSection.Parser, new[]{ "Id", "LaneId", "Boundary" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Hdmap.Road), global::Apollo.Hdmap.Road.Parser, new[]{ "Id", "Section", "JunctionId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BoundaryEdge : pb::IMessage<BoundaryEdge> {
    private static readonly pb::MessageParser<BoundaryEdge> _parser = new pb::MessageParser<BoundaryEdge>(() => new BoundaryEdge());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoundaryEdge> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapRoadReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundaryEdge() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundaryEdge(BoundaryEdge other) : this() {
      Curve = other.curve_ != null ? other.Curve.Clone() : null;
      type_ = other.type_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundaryEdge Clone() {
      return new BoundaryEdge(this);
    }

    /// <summary>Field number for the "curve" field.</summary>
    public const int CurveFieldNumber = 1;
    private global::Apollo.Hdmap.Curve curve_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Curve Curve {
      get { return curve_; }
      set {
        curve_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::Apollo.Hdmap.BoundaryEdge.Types.Type type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.BoundaryEdge.Types.Type Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoundaryEdge);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoundaryEdge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Curve, other.Curve)) return false;
      if (Type != other.Type) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (curve_ != null) hash ^= Curve.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (curve_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Curve);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (curve_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Curve);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoundaryEdge other) {
      if (other == null) {
        return;
      }
      if (other.curve_ != null) {
        if (curve_ == null) {
          curve_ = new global::Apollo.Hdmap.Curve();
        }
        Curve.MergeFrom(other.Curve);
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
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
            if (curve_ == null) {
              curve_ = new global::Apollo.Hdmap.Curve();
            }
            input.ReadMessage(curve_);
            break;
          }
          case 16: {
            type_ = (global::Apollo.Hdmap.BoundaryEdge.Types.Type) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BoundaryEdge message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum Type {
        [pbr::OriginalName("UNKNOWN")] Unknown = 0,
        [pbr::OriginalName("NORMAL")] Normal = 1,
        [pbr::OriginalName("LEFT_BOUNDARY")] LeftBoundary = 2,
        [pbr::OriginalName("RIGHT_BOUNDARY")] RightBoundary = 3,
      }

    }
    #endregion

  }

  public sealed partial class BoundaryPolygon : pb::IMessage<BoundaryPolygon> {
    private static readonly pb::MessageParser<BoundaryPolygon> _parser = new pb::MessageParser<BoundaryPolygon>(() => new BoundaryPolygon());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BoundaryPolygon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapRoadReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundaryPolygon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundaryPolygon(BoundaryPolygon other) : this() {
      edge_ = other.edge_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BoundaryPolygon Clone() {
      return new BoundaryPolygon(this);
    }

    /// <summary>Field number for the "edge" field.</summary>
    public const int EdgeFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.BoundaryEdge> _repeated_edge_codec
        = pb::FieldCodec.ForMessage(10, global::Apollo.Hdmap.BoundaryEdge.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.BoundaryEdge> edge_ = new pbc::RepeatedField<global::Apollo.Hdmap.BoundaryEdge>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.BoundaryEdge> Edge {
      get { return edge_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BoundaryPolygon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BoundaryPolygon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!edge_.Equals(other.edge_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= edge_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      edge_.WriteTo(output, _repeated_edge_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += edge_.CalculateSize(_repeated_edge_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BoundaryPolygon other) {
      if (other == null) {
        return;
      }
      edge_.Add(other.edge_);
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
            edge_.AddEntriesFrom(input, _repeated_edge_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// boundary with holes
  /// </summary>
  public sealed partial class RoadBoundary : pb::IMessage<RoadBoundary> {
    private static readonly pb::MessageParser<RoadBoundary> _parser = new pb::MessageParser<RoadBoundary>(() => new RoadBoundary());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoadBoundary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapRoadReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadBoundary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadBoundary(RoadBoundary other) : this() {
      OuterPolygon = other.outerPolygon_ != null ? other.OuterPolygon.Clone() : null;
      hole_ = other.hole_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadBoundary Clone() {
      return new RoadBoundary(this);
    }

    /// <summary>Field number for the "outer_polygon" field.</summary>
    public const int OuterPolygonFieldNumber = 1;
    private global::Apollo.Hdmap.BoundaryPolygon outerPolygon_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.BoundaryPolygon OuterPolygon {
      get { return outerPolygon_; }
      set {
        outerPolygon_ = value;
      }
    }

    /// <summary>Field number for the "hole" field.</summary>
    public const int HoleFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.BoundaryPolygon> _repeated_hole_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Hdmap.BoundaryPolygon.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.BoundaryPolygon> hole_ = new pbc::RepeatedField<global::Apollo.Hdmap.BoundaryPolygon>();
    /// <summary>
    /// if boundary without hole, hole is null
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.BoundaryPolygon> Hole {
      get { return hole_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoadBoundary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoadBoundary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(OuterPolygon, other.OuterPolygon)) return false;
      if(!hole_.Equals(other.hole_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (outerPolygon_ != null) hash ^= OuterPolygon.GetHashCode();
      hash ^= hole_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (outerPolygon_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(OuterPolygon);
      }
      hole_.WriteTo(output, _repeated_hole_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (outerPolygon_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(OuterPolygon);
      }
      size += hole_.CalculateSize(_repeated_hole_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoadBoundary other) {
      if (other == null) {
        return;
      }
      if (other.outerPolygon_ != null) {
        if (outerPolygon_ == null) {
          outerPolygon_ = new global::Apollo.Hdmap.BoundaryPolygon();
        }
        OuterPolygon.MergeFrom(other.OuterPolygon);
      }
      hole_.Add(other.hole_);
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
            if (outerPolygon_ == null) {
              outerPolygon_ = new global::Apollo.Hdmap.BoundaryPolygon();
            }
            input.ReadMessage(outerPolygon_);
            break;
          }
          case 18: {
            hole_.AddEntriesFrom(input, _repeated_hole_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoadROIBoundary : pb::IMessage<RoadROIBoundary> {
    private static readonly pb::MessageParser<RoadROIBoundary> _parser = new pb::MessageParser<RoadROIBoundary>(() => new RoadROIBoundary());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoadROIBoundary> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapRoadReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadROIBoundary() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadROIBoundary(RoadROIBoundary other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      roadBoundaries_ = other.roadBoundaries_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadROIBoundary Clone() {
      return new RoadROIBoundary(this);
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

    /// <summary>Field number for the "road_boundaries" field.</summary>
    public const int RoadBoundariesFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.RoadBoundary> _repeated_roadBoundaries_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Hdmap.RoadBoundary.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.RoadBoundary> roadBoundaries_ = new pbc::RepeatedField<global::Apollo.Hdmap.RoadBoundary>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.RoadBoundary> RoadBoundaries {
      get { return roadBoundaries_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoadROIBoundary);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoadROIBoundary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if(!roadBoundaries_.Equals(other.roadBoundaries_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      hash ^= roadBoundaries_.GetHashCode();
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
      roadBoundaries_.WriteTo(output, _repeated_roadBoundaries_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      size += roadBoundaries_.CalculateSize(_repeated_roadBoundaries_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoadROIBoundary other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::Apollo.Hdmap.Id();
        }
        Id.MergeFrom(other.Id);
      }
      roadBoundaries_.Add(other.roadBoundaries_);
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
            roadBoundaries_.AddEntriesFrom(input, _repeated_roadBoundaries_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// road section defines a road cross-section, At least one section must be defined in order to
  /// use a road, If multiple road sections are defined, they must be listed in order along the road
  /// </summary>
  public sealed partial class RoadSection : pb::IMessage<RoadSection> {
    private static readonly pb::MessageParser<RoadSection> _parser = new pb::MessageParser<RoadSection>(() => new RoadSection());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoadSection> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapRoadReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadSection() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadSection(RoadSection other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      laneId_ = other.laneId_.Clone();
      Boundary = other.boundary_ != null ? other.Boundary.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoadSection Clone() {
      return new RoadSection(this);
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

    /// <summary>Field number for the "lane_id" field.</summary>
    public const int LaneIdFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.Id> _repeated_laneId_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Hdmap.Id.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.Id> laneId_ = new pbc::RepeatedField<global::Apollo.Hdmap.Id>();
    /// <summary>
    /// lanes contained in this section
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.Id> LaneId {
      get { return laneId_; }
    }

    /// <summary>Field number for the "boundary" field.</summary>
    public const int BoundaryFieldNumber = 3;
    private global::Apollo.Hdmap.RoadBoundary boundary_;
    /// <summary>
    /// boundary of section
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.RoadBoundary Boundary {
      get { return boundary_; }
      set {
        boundary_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoadSection);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoadSection other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if(!laneId_.Equals(other.laneId_)) return false;
      if (!object.Equals(Boundary, other.Boundary)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      hash ^= laneId_.GetHashCode();
      if (boundary_ != null) hash ^= Boundary.GetHashCode();
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
      laneId_.WriteTo(output, _repeated_laneId_codec);
      if (boundary_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Boundary);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      size += laneId_.CalculateSize(_repeated_laneId_codec);
      if (boundary_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Boundary);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoadSection other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::Apollo.Hdmap.Id();
        }
        Id.MergeFrom(other.Id);
      }
      laneId_.Add(other.laneId_);
      if (other.boundary_ != null) {
        if (boundary_ == null) {
          boundary_ = new global::Apollo.Hdmap.RoadBoundary();
        }
        Boundary.MergeFrom(other.Boundary);
      }
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
            laneId_.AddEntriesFrom(input, _repeated_laneId_codec);
            break;
          }
          case 26: {
            if (boundary_ == null) {
              boundary_ = new global::Apollo.Hdmap.RoadBoundary();
            }
            input.ReadMessage(boundary_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The road is a collection of traffic elements, such as lanes, road boundary etc.
  /// It provides general information about the road.
  /// </summary>
  public sealed partial class Road : pb::IMessage<Road> {
    private static readonly pb::MessageParser<Road> _parser = new pb::MessageParser<Road>(() => new Road());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Road> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Hdmap.MapRoadReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Road() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Road(Road other) : this() {
      Id = other.id_ != null ? other.Id.Clone() : null;
      section_ = other.section_.Clone();
      JunctionId = other.junctionId_ != null ? other.JunctionId.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Road Clone() {
      return new Road(this);
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

    /// <summary>Field number for the "section" field.</summary>
    public const int SectionFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Apollo.Hdmap.RoadSection> _repeated_section_codec
        = pb::FieldCodec.ForMessage(18, global::Apollo.Hdmap.RoadSection.Parser);
    private readonly pbc::RepeatedField<global::Apollo.Hdmap.RoadSection> section_ = new pbc::RepeatedField<global::Apollo.Hdmap.RoadSection>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Apollo.Hdmap.RoadSection> Section {
      get { return section_; }
    }

    /// <summary>Field number for the "junction_id" field.</summary>
    public const int JunctionIdFieldNumber = 3;
    private global::Apollo.Hdmap.Id junctionId_;
    /// <summary>
    /// if lane road not in the junction, junction id is null.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Hdmap.Id JunctionId {
      get { return junctionId_; }
      set {
        junctionId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Road);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Road other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Id, other.Id)) return false;
      if(!section_.Equals(other.section_)) return false;
      if (!object.Equals(JunctionId, other.JunctionId)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      hash ^= section_.GetHashCode();
      if (junctionId_ != null) hash ^= JunctionId.GetHashCode();
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
      section_.WriteTo(output, _repeated_section_codec);
      if (junctionId_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(JunctionId);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Id);
      }
      size += section_.CalculateSize(_repeated_section_codec);
      if (junctionId_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(JunctionId);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Road other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null) {
          id_ = new global::Apollo.Hdmap.Id();
        }
        Id.MergeFrom(other.Id);
      }
      section_.Add(other.section_);
      if (other.junctionId_ != null) {
        if (junctionId_ == null) {
          junctionId_ = new global::Apollo.Hdmap.Id();
        }
        JunctionId.MergeFrom(other.JunctionId);
      }
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
            section_.AddEntriesFrom(input, _repeated_section_codec);
            break;
          }
          case 26: {
            if (junctionId_ == null) {
              junctionId_ = new global::Apollo.Hdmap.Id();
            }
            input.ReadMessage(junctionId_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
