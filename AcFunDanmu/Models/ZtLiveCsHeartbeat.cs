// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ZtLiveCsHeartbeat.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from ZtLiveCsHeartbeat.proto</summary>
  public static partial class ZtLiveCsHeartbeatReflection {

    #region Descriptor
    /// <summary>File descriptor for ZtLiveCsHeartbeat.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZtLiveCsHeartbeatReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdadExpdmVDc0hlYXJ0YmVhdC5wcm90bxIKQWNGdW5EYW5tdSJAChFadExp",
            "dmVDc0hlYXJ0YmVhdBIZChFjbGllbnRUaW1lc3RhbXBNcxgBIAEoAxIQCghz",
            "ZXF1ZW5jZRgCIAEoAyJkChRadExpdmVDc0hlYXJ0YmVhdEFjaxIZChFzZXJ2",
            "ZXJUaW1lc3RhbXBNcxgBIAEoAxIZChFjbGllbnRUaW1lc3RhbXBNcxgCIAEo",
            "AxIWCg5jbGllbnRTZXF1ZW5jZRgDIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.ZtLiveCsHeartbeat), global::AcFunDanmu.ZtLiveCsHeartbeat.Parser, new[]{ "ClientTimestampMs", "Sequence" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.ZtLiveCsHeartbeatAck), global::AcFunDanmu.ZtLiveCsHeartbeatAck.Parser, new[]{ "ServerTimestampMs", "ClientTimestampMs", "ClientSequence" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ZtLiveCsHeartbeat : pb::IMessage<ZtLiveCsHeartbeat>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZtLiveCsHeartbeat> _parser = new pb::MessageParser<ZtLiveCsHeartbeat>(() => new ZtLiveCsHeartbeat());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ZtLiveCsHeartbeat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.ZtLiveCsHeartbeatReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsHeartbeat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsHeartbeat(ZtLiveCsHeartbeat other) : this() {
      clientTimestampMs_ = other.clientTimestampMs_;
      sequence_ = other.sequence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsHeartbeat Clone() {
      return new ZtLiveCsHeartbeat(this);
    }

    /// <summary>Field number for the "clientTimestampMs" field.</summary>
    public const int ClientTimestampMsFieldNumber = 1;
    private long clientTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ClientTimestampMs {
      get { return clientTimestampMs_; }
      set {
        clientTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "sequence" field.</summary>
    public const int SequenceFieldNumber = 2;
    private long sequence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Sequence {
      get { return sequence_; }
      set {
        sequence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ZtLiveCsHeartbeat);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ZtLiveCsHeartbeat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClientTimestampMs != other.ClientTimestampMs) return false;
      if (Sequence != other.Sequence) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ClientTimestampMs != 0L) hash ^= ClientTimestampMs.GetHashCode();
      if (Sequence != 0L) hash ^= Sequence.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ClientTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ClientTimestampMs);
      }
      if (Sequence != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Sequence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ClientTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ClientTimestampMs);
      }
      if (Sequence != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Sequence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ClientTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ClientTimestampMs);
      }
      if (Sequence != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Sequence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ZtLiveCsHeartbeat other) {
      if (other == null) {
        return;
      }
      if (other.ClientTimestampMs != 0L) {
        ClientTimestampMs = other.ClientTimestampMs;
      }
      if (other.Sequence != 0L) {
        Sequence = other.Sequence;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 8: {
            ClientTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            Sequence = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ClientTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            Sequence = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ZtLiveCsHeartbeatAck : pb::IMessage<ZtLiveCsHeartbeatAck>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZtLiveCsHeartbeatAck> _parser = new pb::MessageParser<ZtLiveCsHeartbeatAck>(() => new ZtLiveCsHeartbeatAck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ZtLiveCsHeartbeatAck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.ZtLiveCsHeartbeatReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsHeartbeatAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsHeartbeatAck(ZtLiveCsHeartbeatAck other) : this() {
      serverTimestampMs_ = other.serverTimestampMs_;
      clientTimestampMs_ = other.clientTimestampMs_;
      clientSequence_ = other.clientSequence_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsHeartbeatAck Clone() {
      return new ZtLiveCsHeartbeatAck(this);
    }

    /// <summary>Field number for the "serverTimestampMs" field.</summary>
    public const int ServerTimestampMsFieldNumber = 1;
    private long serverTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ServerTimestampMs {
      get { return serverTimestampMs_; }
      set {
        serverTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "clientTimestampMs" field.</summary>
    public const int ClientTimestampMsFieldNumber = 2;
    private long clientTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ClientTimestampMs {
      get { return clientTimestampMs_; }
      set {
        clientTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "clientSequence" field.</summary>
    public const int ClientSequenceFieldNumber = 3;
    private long clientSequence_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ClientSequence {
      get { return clientSequence_; }
      set {
        clientSequence_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ZtLiveCsHeartbeatAck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ZtLiveCsHeartbeatAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ServerTimestampMs != other.ServerTimestampMs) return false;
      if (ClientTimestampMs != other.ClientTimestampMs) return false;
      if (ClientSequence != other.ClientSequence) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ServerTimestampMs != 0L) hash ^= ServerTimestampMs.GetHashCode();
      if (ClientTimestampMs != 0L) hash ^= ClientTimestampMs.GetHashCode();
      if (ClientSequence != 0L) hash ^= ClientSequence.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ServerTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ServerTimestampMs);
      }
      if (ClientTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ClientTimestampMs);
      }
      if (ClientSequence != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ClientSequence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ServerTimestampMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(ServerTimestampMs);
      }
      if (ClientTimestampMs != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ClientTimestampMs);
      }
      if (ClientSequence != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(ClientSequence);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ServerTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerTimestampMs);
      }
      if (ClientTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ClientTimestampMs);
      }
      if (ClientSequence != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ClientSequence);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ZtLiveCsHeartbeatAck other) {
      if (other == null) {
        return;
      }
      if (other.ServerTimestampMs != 0L) {
        ServerTimestampMs = other.ServerTimestampMs;
      }
      if (other.ClientTimestampMs != 0L) {
        ClientTimestampMs = other.ClientTimestampMs;
      }
      if (other.ClientSequence != 0L) {
        ClientSequence = other.ClientSequence;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
          case 8: {
            ServerTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            ClientTimestampMs = input.ReadInt64();
            break;
          }
          case 24: {
            ClientSequence = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ServerTimestampMs = input.ReadInt64();
            break;
          }
          case 16: {
            ClientTimestampMs = input.ReadInt64();
            break;
          }
          case 24: {
            ClientSequence = input.ReadInt64();
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
