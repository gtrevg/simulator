// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: modules/canbus/proto/canbus_conf.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Canbus {

  /// <summary>Holder for reflection information generated from modules/canbus/proto/canbus_conf.proto</summary>
  public static partial class CanbusConfReflection {

    #region Descriptor
    /// <summary>File descriptor for modules/canbus/proto/canbus_conf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CanbusConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZtb2R1bGVzL2NhbmJ1cy9wcm90by9jYW5idXNfY29uZi5wcm90bxINYXBv",
            "bGxvLmNhbmJ1cxo1bW9kdWxlcy9kcml2ZXJzL2NhbmJ1cy9wcm90by9jYW5f",
            "Y2FyZF9wYXJhbWV0ZXIucHJvdG8aLG1vZHVsZXMvY2FuYnVzL3Byb3RvL3Zl",
            "aGljbGVfcGFyYW1ldGVyLnByb3RvIuABCgpDYW5idXNDb25mEjoKEXZlaGlj",
            "bGVfcGFyYW1ldGVyGAEgASgLMh8uYXBvbGxvLmNhbmJ1cy5WZWhpY2xlUGFy",
            "YW1ldGVyEkMKEmNhbl9jYXJkX3BhcmFtZXRlchgCIAEoCzInLmFwb2xsby5k",
            "cml2ZXJzLmNhbmJ1cy5DQU5DYXJkUGFyYW1ldGVyEhkKEWVuYWJsZV9kZWJ1",
            "Z19tb2RlGAMgASgIEhsKE2VuYWJsZV9yZWNlaXZlcl9sb2cYBCABKAgSGQoR",
            "ZW5hYmxlX3NlbmRlcl9sb2cYBSABKAhiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Drivers.Canbus.CanCardParameterReflection.Descriptor, global::Apollo.Canbus.VehicleParameterReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Canbus.CanbusConf), global::Apollo.Canbus.CanbusConf.Parser, new[]{ "VehicleParameter", "CanCardParameter", "EnableDebugMode", "EnableReceiverLog", "EnableSenderLog" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CanbusConf : pb::IMessage<CanbusConf> {
    private static readonly pb::MessageParser<CanbusConf> _parser = new pb::MessageParser<CanbusConf>(() => new CanbusConf());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CanbusConf> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Canbus.CanbusConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanbusConf() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanbusConf(CanbusConf other) : this() {
      VehicleParameter = other.vehicleParameter_ != null ? other.VehicleParameter.Clone() : null;
      CanCardParameter = other.canCardParameter_ != null ? other.CanCardParameter.Clone() : null;
      enableDebugMode_ = other.enableDebugMode_;
      enableReceiverLog_ = other.enableReceiverLog_;
      enableSenderLog_ = other.enableSenderLog_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CanbusConf Clone() {
      return new CanbusConf(this);
    }

    /// <summary>Field number for the "vehicle_parameter" field.</summary>
    public const int VehicleParameterFieldNumber = 1;
    private global::Apollo.Canbus.VehicleParameter vehicleParameter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Canbus.VehicleParameter VehicleParameter {
      get { return vehicleParameter_; }
      set {
        vehicleParameter_ = value;
      }
    }

    /// <summary>Field number for the "can_card_parameter" field.</summary>
    public const int CanCardParameterFieldNumber = 2;
    private global::Apollo.Drivers.Canbus.CANCardParameter canCardParameter_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Drivers.Canbus.CANCardParameter CanCardParameter {
      get { return canCardParameter_; }
      set {
        canCardParameter_ = value;
      }
    }

    /// <summary>Field number for the "enable_debug_mode" field.</summary>
    public const int EnableDebugModeFieldNumber = 3;
    private bool enableDebugMode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableDebugMode {
      get { return enableDebugMode_; }
      set {
        enableDebugMode_ = value;
      }
    }

    /// <summary>Field number for the "enable_receiver_log" field.</summary>
    public const int EnableReceiverLogFieldNumber = 4;
    private bool enableReceiverLog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableReceiverLog {
      get { return enableReceiverLog_; }
      set {
        enableReceiverLog_ = value;
      }
    }

    /// <summary>Field number for the "enable_sender_log" field.</summary>
    public const int EnableSenderLogFieldNumber = 5;
    private bool enableSenderLog_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool EnableSenderLog {
      get { return enableSenderLog_; }
      set {
        enableSenderLog_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CanbusConf);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CanbusConf other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(VehicleParameter, other.VehicleParameter)) return false;
      if (!object.Equals(CanCardParameter, other.CanCardParameter)) return false;
      if (EnableDebugMode != other.EnableDebugMode) return false;
      if (EnableReceiverLog != other.EnableReceiverLog) return false;
      if (EnableSenderLog != other.EnableSenderLog) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (vehicleParameter_ != null) hash ^= VehicleParameter.GetHashCode();
      if (canCardParameter_ != null) hash ^= CanCardParameter.GetHashCode();
      if (EnableDebugMode != false) hash ^= EnableDebugMode.GetHashCode();
      if (EnableReceiverLog != false) hash ^= EnableReceiverLog.GetHashCode();
      if (EnableSenderLog != false) hash ^= EnableSenderLog.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (vehicleParameter_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(VehicleParameter);
      }
      if (canCardParameter_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(CanCardParameter);
      }
      if (EnableDebugMode != false) {
        output.WriteRawTag(24);
        output.WriteBool(EnableDebugMode);
      }
      if (EnableReceiverLog != false) {
        output.WriteRawTag(32);
        output.WriteBool(EnableReceiverLog);
      }
      if (EnableSenderLog != false) {
        output.WriteRawTag(40);
        output.WriteBool(EnableSenderLog);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (vehicleParameter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VehicleParameter);
      }
      if (canCardParameter_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CanCardParameter);
      }
      if (EnableDebugMode != false) {
        size += 1 + 1;
      }
      if (EnableReceiverLog != false) {
        size += 1 + 1;
      }
      if (EnableSenderLog != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CanbusConf other) {
      if (other == null) {
        return;
      }
      if (other.vehicleParameter_ != null) {
        if (vehicleParameter_ == null) {
          vehicleParameter_ = new global::Apollo.Canbus.VehicleParameter();
        }
        VehicleParameter.MergeFrom(other.VehicleParameter);
      }
      if (other.canCardParameter_ != null) {
        if (canCardParameter_ == null) {
          canCardParameter_ = new global::Apollo.Drivers.Canbus.CANCardParameter();
        }
        CanCardParameter.MergeFrom(other.CanCardParameter);
      }
      if (other.EnableDebugMode != false) {
        EnableDebugMode = other.EnableDebugMode;
      }
      if (other.EnableReceiverLog != false) {
        EnableReceiverLog = other.EnableReceiverLog;
      }
      if (other.EnableSenderLog != false) {
        EnableSenderLog = other.EnableSenderLog;
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
            if (vehicleParameter_ == null) {
              vehicleParameter_ = new global::Apollo.Canbus.VehicleParameter();
            }
            input.ReadMessage(vehicleParameter_);
            break;
          }
          case 18: {
            if (canCardParameter_ == null) {
              canCardParameter_ = new global::Apollo.Drivers.Canbus.CANCardParameter();
            }
            input.ReadMessage(canCardParameter_);
            break;
          }
          case 24: {
            EnableDebugMode = input.ReadBool();
            break;
          }
          case 32: {
            EnableReceiverLog = input.ReadBool();
            break;
          }
          case 40: {
            EnableSenderLog = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
