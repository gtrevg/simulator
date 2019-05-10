// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: cyber/proto/cyber_conf.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Cyber.Proto {

  /// <summary>Holder for reflection information generated from cyber/proto/cyber_conf.proto</summary>
  public static partial class CyberConfReflection {

    #region Descriptor
    /// <summary>File descriptor for cyber/proto/cyber_conf.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CyberConfReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxjeWJlci9wcm90by9jeWJlcl9jb25mLnByb3RvEhJhcG9sbG8uY3liZXIu",
            "cHJvdG8aIGN5YmVyL3Byb3RvL3NjaGVkdWxlcl9jb25mLnByb3RvGiBjeWJl",
            "ci9wcm90by90cmFuc3BvcnRfY29uZi5wcm90bxofY3liZXIvcHJvdG8vcnVu",
            "X21vZGVfY29uZi5wcm90byK7AQoLQ3liZXJDb25maWcSOQoOc2NoZWR1bGVy",
            "X2NvbmYYASABKAsyIS5hcG9sbG8uY3liZXIucHJvdG8uU2NoZWR1bGVyQ29u",
            "ZhI5Cg50cmFuc3BvcnRfY29uZhgCIAEoCzIhLmFwb2xsby5jeWJlci5wcm90",
            "by5UcmFuc3BvcnRDb25mEjYKDXJ1bl9tb2RlX2NvbmYYAyABKAsyHy5hcG9s",
            "bG8uY3liZXIucHJvdG8uUnVuTW9kZUNvbmZiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Apollo.Cyber.Proto.SchedulerConfReflection.Descriptor, global::Apollo.Cyber.Proto.TransportConfReflection.Descriptor, global::Apollo.Cyber.Proto.RunModeConfReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Cyber.Proto.CyberConfig), global::Apollo.Cyber.Proto.CyberConfig.Parser, new[]{ "SchedulerConf", "TransportConf", "RunModeConf" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CyberConfig : pb::IMessage<CyberConfig> {
    private static readonly pb::MessageParser<CyberConfig> _parser = new pb::MessageParser<CyberConfig>(() => new CyberConfig());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CyberConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Cyber.Proto.CyberConfReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CyberConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CyberConfig(CyberConfig other) : this() {
      SchedulerConf = other.schedulerConf_ != null ? other.SchedulerConf.Clone() : null;
      TransportConf = other.transportConf_ != null ? other.TransportConf.Clone() : null;
      RunModeConf = other.runModeConf_ != null ? other.RunModeConf.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CyberConfig Clone() {
      return new CyberConfig(this);
    }

    /// <summary>Field number for the "scheduler_conf" field.</summary>
    public const int SchedulerConfFieldNumber = 1;
    private global::Apollo.Cyber.Proto.SchedulerConf schedulerConf_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Cyber.Proto.SchedulerConf SchedulerConf {
      get { return schedulerConf_; }
      set {
        schedulerConf_ = value;
      }
    }

    /// <summary>Field number for the "transport_conf" field.</summary>
    public const int TransportConfFieldNumber = 2;
    private global::Apollo.Cyber.Proto.TransportConf transportConf_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Cyber.Proto.TransportConf TransportConf {
      get { return transportConf_; }
      set {
        transportConf_ = value;
      }
    }

    /// <summary>Field number for the "run_mode_conf" field.</summary>
    public const int RunModeConfFieldNumber = 3;
    private global::Apollo.Cyber.Proto.RunModeConf runModeConf_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Apollo.Cyber.Proto.RunModeConf RunModeConf {
      get { return runModeConf_; }
      set {
        runModeConf_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CyberConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CyberConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(SchedulerConf, other.SchedulerConf)) return false;
      if (!object.Equals(TransportConf, other.TransportConf)) return false;
      if (!object.Equals(RunModeConf, other.RunModeConf)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (schedulerConf_ != null) hash ^= SchedulerConf.GetHashCode();
      if (transportConf_ != null) hash ^= TransportConf.GetHashCode();
      if (runModeConf_ != null) hash ^= RunModeConf.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (schedulerConf_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(SchedulerConf);
      }
      if (transportConf_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(TransportConf);
      }
      if (runModeConf_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(RunModeConf);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (schedulerConf_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SchedulerConf);
      }
      if (transportConf_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TransportConf);
      }
      if (runModeConf_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RunModeConf);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CyberConfig other) {
      if (other == null) {
        return;
      }
      if (other.schedulerConf_ != null) {
        if (schedulerConf_ == null) {
          schedulerConf_ = new global::Apollo.Cyber.Proto.SchedulerConf();
        }
        SchedulerConf.MergeFrom(other.SchedulerConf);
      }
      if (other.transportConf_ != null) {
        if (transportConf_ == null) {
          transportConf_ = new global::Apollo.Cyber.Proto.TransportConf();
        }
        TransportConf.MergeFrom(other.TransportConf);
      }
      if (other.runModeConf_ != null) {
        if (runModeConf_ == null) {
          runModeConf_ = new global::Apollo.Cyber.Proto.RunModeConf();
        }
        RunModeConf.MergeFrom(other.RunModeConf);
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
            if (schedulerConf_ == null) {
              schedulerConf_ = new global::Apollo.Cyber.Proto.SchedulerConf();
            }
            input.ReadMessage(schedulerConf_);
            break;
          }
          case 18: {
            if (transportConf_ == null) {
              transportConf_ = new global::Apollo.Cyber.Proto.TransportConf();
            }
            input.ReadMessage(transportConf_);
            break;
          }
          case 26: {
            if (runModeConf_ == null) {
              runModeConf_ = new global::Apollo.Cyber.Proto.RunModeConf();
            }
            input.ReadMessage(runModeConf_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
