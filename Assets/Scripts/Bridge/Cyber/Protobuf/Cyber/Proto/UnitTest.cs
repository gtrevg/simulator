// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: cyber/proto/unit_test.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Apollo.Cyber.Proto {

  /// <summary>Holder for reflection information generated from cyber/proto/unit_test.proto</summary>
  public static partial class UnitTestReflection {

    #region Descriptor
    /// <summary>File descriptor for cyber/proto/unit_test.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UnitTestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtjeWJlci9wcm90by91bml0X3Rlc3QucHJvdG8SEmFwb2xsby5jeWJlci5w",
            "cm90byIxCghVbml0VGVzdBISCgpjbGFzc19uYW1lGAEgASgJEhEKCWNhc2Vf",
            "bmFtZRgCIAEoCSJTCgdDaGF0dGVyEhEKCXRpbWVzdGFtcBgBIAEoBBIXCg9s",
            "aWRhcl90aW1lc3RhbXAYAiABKAQSCwoDc2VxGAMgASgEEg8KB2NvbnRlbnQY",
            "BCABKAwiPwoQQ2hhdHRlckJlbmNobWFyaxINCgVzdGFtcBgBIAEoBBILCgNz",
            "ZXEYAiABKAQSDwoHY29udGVudBgDIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Cyber.Proto.UnitTest), global::Apollo.Cyber.Proto.UnitTest.Parser, new[]{ "ClassName", "CaseName" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Cyber.Proto.Chatter), global::Apollo.Cyber.Proto.Chatter.Parser, new[]{ "Timestamp", "LidarTimestamp", "Seq", "Content" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Apollo.Cyber.Proto.ChatterBenchmark), global::Apollo.Cyber.Proto.ChatterBenchmark.Parser, new[]{ "Stamp", "Seq", "Content" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UnitTest : pb::IMessage<UnitTest> {
    private static readonly pb::MessageParser<UnitTest> _parser = new pb::MessageParser<UnitTest>(() => new UnitTest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UnitTest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Cyber.Proto.UnitTestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnitTest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnitTest(UnitTest other) : this() {
      className_ = other.className_;
      caseName_ = other.caseName_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UnitTest Clone() {
      return new UnitTest(this);
    }

    /// <summary>Field number for the "class_name" field.</summary>
    public const int ClassNameFieldNumber = 1;
    private string className_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClassName {
      get { return className_; }
      set {
        className_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "case_name" field.</summary>
    public const int CaseNameFieldNumber = 2;
    private string caseName_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string CaseName {
      get { return caseName_; }
      set {
        caseName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UnitTest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UnitTest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClassName != other.ClassName) return false;
      if (CaseName != other.CaseName) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClassName.Length != 0) hash ^= ClassName.GetHashCode();
      if (CaseName.Length != 0) hash ^= CaseName.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (ClassName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ClassName);
      }
      if (CaseName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(CaseName);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClassName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClassName);
      }
      if (CaseName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CaseName);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UnitTest other) {
      if (other == null) {
        return;
      }
      if (other.ClassName.Length != 0) {
        ClassName = other.ClassName;
      }
      if (other.CaseName.Length != 0) {
        CaseName = other.CaseName;
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
            ClassName = input.ReadString();
            break;
          }
          case 18: {
            CaseName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Chatter : pb::IMessage<Chatter> {
    private static readonly pb::MessageParser<Chatter> _parser = new pb::MessageParser<Chatter>(() => new Chatter());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Chatter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Cyber.Proto.UnitTestReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chatter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chatter(Chatter other) : this() {
      timestamp_ = other.timestamp_;
      lidarTimestamp_ = other.lidarTimestamp_;
      seq_ = other.seq_;
      content_ = other.content_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Chatter Clone() {
      return new Chatter(this);
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 1;
    private ulong timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "lidar_timestamp" field.</summary>
    public const int LidarTimestampFieldNumber = 2;
    private ulong lidarTimestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong LidarTimestamp {
      get { return lidarTimestamp_; }
      set {
        lidarTimestamp_ = value;
      }
    }

    /// <summary>Field number for the "seq" field.</summary>
    public const int SeqFieldNumber = 3;
    private ulong seq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Seq {
      get { return seq_; }
      set {
        seq_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 4;
    private pb::ByteString content_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Chatter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Chatter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Timestamp != other.Timestamp) return false;
      if (LidarTimestamp != other.LidarTimestamp) return false;
      if (Seq != other.Seq) return false;
      if (Content != other.Content) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Timestamp != 0UL) hash ^= Timestamp.GetHashCode();
      if (LidarTimestamp != 0UL) hash ^= LidarTimestamp.GetHashCode();
      if (Seq != 0UL) hash ^= Seq.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Timestamp != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Timestamp);
      }
      if (LidarTimestamp != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(LidarTimestamp);
      }
      if (Seq != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Seq);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Content);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Timestamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Timestamp);
      }
      if (LidarTimestamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(LidarTimestamp);
      }
      if (Seq != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Seq);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Content);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Chatter other) {
      if (other == null) {
        return;
      }
      if (other.Timestamp != 0UL) {
        Timestamp = other.Timestamp;
      }
      if (other.LidarTimestamp != 0UL) {
        LidarTimestamp = other.LidarTimestamp;
      }
      if (other.Seq != 0UL) {
        Seq = other.Seq;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
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
            Timestamp = input.ReadUInt64();
            break;
          }
          case 16: {
            LidarTimestamp = input.ReadUInt64();
            break;
          }
          case 24: {
            Seq = input.ReadUInt64();
            break;
          }
          case 34: {
            Content = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ChatterBenchmark : pb::IMessage<ChatterBenchmark> {
    private static readonly pb::MessageParser<ChatterBenchmark> _parser = new pb::MessageParser<ChatterBenchmark>(() => new ChatterBenchmark());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ChatterBenchmark> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Apollo.Cyber.Proto.UnitTestReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatterBenchmark() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatterBenchmark(ChatterBenchmark other) : this() {
      stamp_ = other.stamp_;
      seq_ = other.seq_;
      content_ = other.content_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ChatterBenchmark Clone() {
      return new ChatterBenchmark(this);
    }

    /// <summary>Field number for the "stamp" field.</summary>
    public const int StampFieldNumber = 1;
    private ulong stamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Stamp {
      get { return stamp_; }
      set {
        stamp_ = value;
      }
    }

    /// <summary>Field number for the "seq" field.</summary>
    public const int SeqFieldNumber = 2;
    private ulong seq_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Seq {
      get { return seq_; }
      set {
        seq_ = value;
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 3;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ChatterBenchmark);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ChatterBenchmark other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Stamp != other.Stamp) return false;
      if (Seq != other.Seq) return false;
      if (Content != other.Content) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Stamp != 0UL) hash ^= Stamp.GetHashCode();
      if (Seq != 0UL) hash ^= Seq.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Stamp != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Stamp);
      }
      if (Seq != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(Seq);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Content);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Stamp != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Stamp);
      }
      if (Seq != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Seq);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ChatterBenchmark other) {
      if (other == null) {
        return;
      }
      if (other.Stamp != 0UL) {
        Stamp = other.Stamp;
      }
      if (other.Seq != 0UL) {
        Seq = other.Seq;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
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
            Stamp = input.ReadUInt64();
            break;
          }
          case 16: {
            Seq = input.ReadUInt64();
            break;
          }
          case 26: {
            Content = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
