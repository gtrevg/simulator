// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/perception/camera/lib/obstacle/postprocessor/location_refiner/location_refiner.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Perception.Camera.LocationRefiner {

  /// <summary>Holder for reflection information generated from modules/perception/camera/lib/obstacle/postprocessor/location_refiner/location_refiner.proto</summary>
  public static partial class LocationRefinerReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/perception/camera/lib/obstacle/postprocessor/location_refiner/location_refiner.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationRefinerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clxtb2R1bGVzL3BlcmNlcHRpb24vY2FtZXJhL2xpYi9vYnN0YWNsZS9wb3N0",
            "cHJvY2Vzc29yL2xvY2F0aW9uX3JlZmluZXIvbG9jYXRpb25fcmVmaW5lci5w",
            "cm90bxIpYXBvbGxvLnBlcmNlcHRpb24uY2FtZXJhLmxvY2F0aW9uX3JlZmlu",
            "ZXIiTgoUTG9jYXRpb25SZWZpbmVyUGFyYW0SGgoSbWluX2Rpc3RfdG9fY2Ft",
            "ZXJhGAEgASgCEhoKEnJvaV9oMmJvdHRvbV9zY2FsZRgCIAEoAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Perception.Camera.LocationRefiner.LocationRefinerParam), global::Apollo.Perception.Camera.LocationRefiner.LocationRefinerParam.Parser, new[]{ "MinDistToCamera", "RoiH2BottomScale" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class LocationRefinerParam : pb::IMessage<LocationRefinerParam> {
    private static readonly pb::MessageParser<LocationRefinerParam> _parser = new pb::MessageParser<LocationRefinerParam>(() => new LocationRefinerParam());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LocationRefinerParam> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Perception.Camera.LocationRefiner.LocationRefinerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocationRefinerParam() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocationRefinerParam(LocationRefinerParam other) : this() {
      minDistToCamera_ = other.minDistToCamera_;
      roiH2BottomScale_ = other.roiH2BottomScale_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LocationRefinerParam Clone() {
      return new LocationRefinerParam(this);
    }

    /// <summary>Field number for the "min_dist_to_camera" field.</summary>
    public const int MinDistToCameraFieldNumber = 1;
    private float minDistToCamera_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float MinDistToCamera {
      get { return minDistToCamera_; }
      set {
        minDistToCamera_ = value;
      }
    }

    /// <summary>Field number for the "roi_h2bottom_scale" field.</summary>
    public const int RoiH2BottomScaleFieldNumber = 2;
    private float roiH2BottomScale_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float RoiH2BottomScale {
      get { return roiH2BottomScale_; }
      set {
        roiH2BottomScale_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LocationRefinerParam);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LocationRefinerParam other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MinDistToCamera != other.MinDistToCamera) return false;
      if (RoiH2BottomScale != other.RoiH2BottomScale) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (MinDistToCamera != 0F) hash ^= MinDistToCamera.GetHashCode();
      if (RoiH2BottomScale != 0F) hash ^= RoiH2BottomScale.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (MinDistToCamera != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(MinDistToCamera);
      }
      if (RoiH2BottomScale != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(RoiH2BottomScale);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (MinDistToCamera != 0F) {
        size += 1 + 4;
      }
      if (RoiH2BottomScale != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LocationRefinerParam other) {
      if (other == null) {
        return;
      }
      if (other.MinDistToCamera != 0F) {
        MinDistToCamera = other.MinDistToCamera;
      }
      if (other.RoiH2BottomScale != 0F) {
        RoiH2BottomScale = other.RoiH2BottomScale;
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
          case 13: {
            MinDistToCamera = input.ReadFloat();
            break;
          }
          case 21: {
            RoiH2BottomScale = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
