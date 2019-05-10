// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/canbus/proto/vehicle_parameter.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Canbus {

  /// <summary>Holder for reflection information generated from modules/canbus/proto/vehicle_parameter.proto</summary>
  public static partial class VehicleParameterReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/canbus/proto/vehicle_parameter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VehicleParameterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixtb2R1bGVzL2NhbmJ1cy9wcm90by92ZWhpY2xlX3BhcmFtZXRlci5wcm90",
            "bxINYXBvbGxvLmNhbmJ1cxoibW9kdWxlcy9jYW5idXMvcHJvdG8vY2hhc3Np",
            "cy5wcm90byKYAgoQVmVoaWNsZVBhcmFtZXRlchI7CgVicmFuZBgBIAEoDjIs",
            "LmFwb2xsby5jYW5idXMuVmVoaWNsZVBhcmFtZXRlci5WZWhpY2xlQnJhbmQS",
            "GAoQbWF4X2VuZ2luZV9wZWRhbBgCIAEoARIfChdtYXhfZW5hYmxlX2ZhaWxf",
            "YXR0ZW1wdBgDIAEoBRI4Cgxkcml2aW5nX21vZGUYBCABKA4yIi5hcG9sbG8u",
            "Y2FuYnVzLkNoYXNzaXMuRHJpdmluZ01vZGUiUgoMVmVoaWNsZUJyYW5kEg8K",
            "C0xJTkNPTE5fTUtaEAASBwoDR0VNEAESCQoFTEVYVVMQAhILCgdUUkFOU0lU",
            "EAMSBwoDR0UzEAQSBwoDV0VZEAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Canbus.ChassisReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Canbus.VehicleParameter), global::Apollo.Canbus.VehicleParameter.Parser, new[]{ "Brand", "MaxEnginePedal", "MaxEnableFailAttempt", "DrivingMode" }, null, new[]{ typeof(global::Apollo.Canbus.VehicleParameter.Types.VehicleBrand) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VehicleParameter : pb::IMessage<VehicleParameter> {
    private static readonly pb::MessageParser<VehicleParameter> _parser = new pb::MessageParser<VehicleParameter>(() => new VehicleParameter());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<VehicleParameter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Canbus.VehicleParameterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VehicleParameter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VehicleParameter(VehicleParameter other) : this() {
      brand_ = other.brand_;
      maxEnginePedal_ = other.maxEnginePedal_;
      maxEnableFailAttempt_ = other.maxEnableFailAttempt_;
      drivingMode_ = other.drivingMode_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public VehicleParameter Clone() {
      return new VehicleParameter(this);
    }

    /// <summary>Field number for the "brand" field.</summary>
    public const int BrandFieldNumber = 1;
    private global::Apollo.Canbus.VehicleParameter.Types.VehicleBrand brand_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Canbus.VehicleParameter.Types.VehicleBrand Brand {
      get { return brand_; }
      set {
        brand_ = value;
      }
    }

    /// <summary>Field number for the "max_engine_pedal" field.</summary>
    public const int MaxEnginePedalFieldNumber = 2;
    private double maxEnginePedal_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double MaxEnginePedal {
      get { return maxEnginePedal_; }
      set {
        maxEnginePedal_ = value;
      }
    }

    /// <summary>Field number for the "max_enable_fail_attempt" field.</summary>
    public const int MaxEnableFailAttemptFieldNumber = 3;
    private int maxEnableFailAttempt_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int MaxEnableFailAttempt {
      get { return maxEnableFailAttempt_; }
      set {
        maxEnableFailAttempt_ = value;
      }
    }

    /// <summary>Field number for the "driving_mode" field.</summary>
    public const int DrivingModeFieldNumber = 4;
    private global::Apollo.Canbus.Chassis.Types.DrivingMode drivingMode_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Canbus.Chassis.Types.DrivingMode DrivingMode {
      get { return drivingMode_; }
      set {
        drivingMode_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as VehicleParameter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(VehicleParameter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Brand != other.Brand) return false;
      if (MaxEnginePedal != other.MaxEnginePedal) return false;
      if (MaxEnableFailAttempt != other.MaxEnableFailAttempt) return false;
      if (DrivingMode != other.DrivingMode) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Brand != 0) hash ^= Brand.GetHashCode();
      if (MaxEnginePedal != 0D) hash ^= MaxEnginePedal.GetHashCode();
      if (MaxEnableFailAttempt != 0) hash ^= MaxEnableFailAttempt.GetHashCode();
      if (DrivingMode != 0) hash ^= DrivingMode.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Brand != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Brand);
      }
      if (MaxEnginePedal != 0D) {
        output.WriteRawTag(17);
        output.WriteDouble(MaxEnginePedal);
      }
      if (MaxEnableFailAttempt != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(MaxEnableFailAttempt);
      }
      if (DrivingMode != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) DrivingMode);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Brand != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Brand);
      }
      if (MaxEnginePedal != 0D) {
        size += 1 + 8;
      }
      if (MaxEnableFailAttempt != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxEnableFailAttempt);
      }
      if (DrivingMode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) DrivingMode);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(VehicleParameter other) {
      if (other == null) {
        return;
      }
      if (other.Brand != 0) {
        Brand = other.Brand;
      }
      if (other.MaxEnginePedal != 0D) {
        MaxEnginePedal = other.MaxEnginePedal;
      }
      if (other.MaxEnableFailAttempt != 0) {
        MaxEnableFailAttempt = other.MaxEnableFailAttempt;
      }
      if (other.DrivingMode != 0) {
        DrivingMode = other.DrivingMode;
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
          case 8: {
            brand_ = (global::Apollo.Canbus.VehicleParameter.Types.VehicleBrand) input.ReadEnum();
            break;
          }
          case 17: {
            MaxEnginePedal = input.ReadDouble();
            break;
          }
          case 24: {
            MaxEnableFailAttempt = input.ReadInt32();
            break;
          }
          case 32: {
            drivingMode_ = (global::Apollo.Canbus.Chassis.Types.DrivingMode) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the VehicleParameter message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum VehicleBrand {
        [pbr::OriginalName("LINCOLN_MKZ")] LincolnMkz = 0,
        [pbr::OriginalName("GEM")] Gem = 1,
        [pbr::OriginalName("LEXUS")] Lexus = 2,
        [pbr::OriginalName("TRANSIT")] Transit = 3,
        [pbr::OriginalName("GE3")] Ge3 = 4,
        [pbr::OriginalName("WEY")] Wey = 5,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
