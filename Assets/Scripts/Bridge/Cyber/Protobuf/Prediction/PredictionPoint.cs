// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/prediction/proto/prediction_point.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Prediction {

  /// <summary>Holder for reflection information generated from modules/prediction/proto/prediction_point.proto</summary>
  public static partial class PredictionPointReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/prediction/proto/prediction_point.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PredictionPointReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9tb2R1bGVzL3ByZWRpY3Rpb24vcHJvdG8vcHJlZGljdGlvbl9wb2ludC5w",
            "cm90bxIRYXBvbGxvLnByZWRpY3Rpb24iRQoTUHJlZGljdGlvblBhdGhQb2lu",
            "dBIJCgF4GAEgASgBEgkKAXkYAiABKAESGAoQdmVsb2NpdHlfaGVhZGluZxgD",
            "IAEoASJqChlQcmVkaWN0aW9uVHJhamVjdG9yeVBvaW50EjoKCnBhdGhfcG9p",
            "bnQYASABKAsyJi5hcG9sbG8ucHJlZGljdGlvbi5QcmVkaWN0aW9uUGF0aFBv",
            "aW50EhEKCXRpbWVzdGFtcBgCIAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Prediction.PredictionPathPoint), global::Apollo.Prediction.PredictionPathPoint.Parser, new[]{ "X", "Y", "VelocityHeading" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Prediction.PredictionTrajectoryPoint), global::Apollo.Prediction.PredictionTrajectoryPoint.Parser, new[]{ "PathPoint", "Timestamp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PredictionPathPoint : pb::IMessage<PredictionPathPoint> {
    private static readonly pb::MessageParser<PredictionPathPoint> _parser = new pb::MessageParser<PredictionPathPoint>(() => new PredictionPathPoint());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PredictionPathPoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Prediction.PredictionPointReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionPathPoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionPathPoint(PredictionPathPoint other) : this() {
      x_ = other.x_;
      y_ = other.y_;
      velocityHeading_ = other.velocityHeading_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionPathPoint Clone() {
      return new PredictionPathPoint(this);
    }

    /// <summary>Field number for the "x" field.</summary>
    public const int XFieldNumber = 1;
    private double x_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double X {
      get { return x_; }
      set {
        x_ = value;
      }
    }

    /// <summary>Field number for the "y" field.</summary>
    public const int YFieldNumber = 2;
    private double y_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Y {
      get { return y_; }
      set {
        y_ = value;
      }
    }

    /// <summary>Field number for the "velocity_heading" field.</summary>
    public const int VelocityHeadingFieldNumber = 3;
    private double velocityHeading_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double VelocityHeading {
      get { return velocityHeading_; }
      set {
        velocityHeading_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PredictionPathPoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PredictionPathPoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (X != other.X) return false;
      if (Y != other.Y) return false;
      if (VelocityHeading != other.VelocityHeading) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (X != 0D) hash ^= X.GetHashCode();
      if (Y != 0D) hash ^= Y.GetHashCode();
      if (VelocityHeading != 0D) hash ^= VelocityHeading.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (X != 0D) {
        output.WriteRawTag(9);
        output.WriteDouble(X);
      }
      if (Y != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Y);
      }
      if (VelocityHeading != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(VelocityHeading);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (X != 0D) {
        size += 1 + 8;
      }
      if (Y != 0D) {
        size += 1 + 8;
      }
      if (VelocityHeading != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PredictionPathPoint other) {
      if (other == null) {
        return;
      }
      if (other.X != 0D) {
        X = other.X;
      }
      if (other.Y != 0D) {
        Y = other.Y;
      }
      if (other.VelocityHeading != 0D) {
        VelocityHeading = other.VelocityHeading;
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
          case 9: {
            X = input.ReadDouble();
            break;
          }
          case 17: {
            Y = input.ReadDouble();
            break;
          }
          case 25: {
            VelocityHeading = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PredictionTrajectoryPoint : pb::IMessage<PredictionTrajectoryPoint> {
    private static readonly pb::MessageParser<PredictionTrajectoryPoint> _parser = new pb::MessageParser<PredictionTrajectoryPoint>(() => new PredictionTrajectoryPoint());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PredictionTrajectoryPoint> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Prediction.PredictionPointReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionTrajectoryPoint() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionTrajectoryPoint(PredictionTrajectoryPoint other) : this() {
      PathPoint = other.pathPoint_ != null ? other.PathPoint.Clone() : null;
      timestamp_ = other.timestamp_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PredictionTrajectoryPoint Clone() {
      return new PredictionTrajectoryPoint(this);
    }

    /// <summary>Field number for the "path_point" field.</summary>
    public const int PathPointFieldNumber = 1;
    private global::Apollo.Prediction.PredictionPathPoint pathPoint_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Prediction.PredictionPathPoint PathPoint {
      get { return pathPoint_; }
      set {
        pathPoint_ = value;
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 2;
    private double timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PredictionTrajectoryPoint);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PredictionTrajectoryPoint other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(PathPoint, other.PathPoint)) return false;
      if (Timestamp != other.Timestamp) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (pathPoint_ != null) hash ^= PathPoint.GetHashCode();
      if (Timestamp != 0D) hash ^= Timestamp.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (pathPoint_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(PathPoint);
      }
      if (Timestamp != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(Timestamp);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (pathPoint_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PathPoint);
      }
      if (Timestamp != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PredictionTrajectoryPoint other) {
      if (other == null) {
        return;
      }
      if (other.pathPoint_ != null) {
        if (pathPoint_ == null) {
          pathPoint_ = new global::Apollo.Prediction.PredictionPathPoint();
        }
        PathPoint.MergeFrom(other.PathPoint);
      }
      if (other.Timestamp != 0D) {
        Timestamp = other.Timestamp;
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
            if (pathPoint_ == null) {
              pathPoint_ = new global::Apollo.Prediction.PredictionPathPoint();
            }
            input.ReadMessage(pathPoint_);
            break;
          }
          case 17: {
            Timestamp = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
