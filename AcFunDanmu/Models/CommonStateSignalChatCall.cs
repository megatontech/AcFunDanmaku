// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonStateSignalChatCall.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from CommonStateSignalChatCall.proto</summary>
  public static partial class CommonStateSignalChatCallReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonStateSignalChatCall.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonStateSignalChatCallReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9Db21tb25TdGF0ZVNpZ25hbENoYXRDYWxsLnByb3RvEgpBY0Z1bkRhbm11",
            "IlQKGUNvbW1vblN0YXRlU2lnbmFsQ2hhdENhbGwSDgoGY2hhdElkGAEgASgJ",
            "Eg4KBmxpdmVJZBgCIAEoCRIXCg9jYWxsVGltZXN0YW1wTXMYAyABKANiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.CommonStateSignalChatCall), global::AcFunDanmu.CommonStateSignalChatCall.Parser, new[]{ "ChatId", "LiveId", "CallTimestampMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CommonStateSignalChatCall : pb::IMessage<CommonStateSignalChatCall>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CommonStateSignalChatCall> _parser = new pb::MessageParser<CommonStateSignalChatCall>(() => new CommonStateSignalChatCall());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CommonStateSignalChatCall> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.CommonStateSignalChatCallReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalChatCall() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalChatCall(CommonStateSignalChatCall other) : this() {
      chatId_ = other.chatId_;
      liveId_ = other.liveId_;
      callTimestampMs_ = other.callTimestampMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CommonStateSignalChatCall Clone() {
      return new CommonStateSignalChatCall(this);
    }

    /// <summary>Field number for the "chatId" field.</summary>
    public const int ChatIdFieldNumber = 1;
    private string chatId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ChatId {
      get { return chatId_; }
      set {
        chatId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "liveId" field.</summary>
    public const int LiveIdFieldNumber = 2;
    private string liveId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LiveId {
      get { return liveId_; }
      set {
        liveId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "callTimestampMs" field.</summary>
    public const int CallTimestampMsFieldNumber = 3;
    private long callTimestampMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CallTimestampMs {
      get { return callTimestampMs_; }
      set {
        callTimestampMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CommonStateSignalChatCall);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CommonStateSignalChatCall other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChatId != other.ChatId) return false;
      if (LiveId != other.LiveId) return false;
      if (CallTimestampMs != other.CallTimestampMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ChatId.Length != 0) hash ^= ChatId.GetHashCode();
      if (LiveId.Length != 0) hash ^= LiveId.GetHashCode();
      if (CallTimestampMs != 0L) hash ^= CallTimestampMs.GetHashCode();
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
      if (ChatId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ChatId);
      }
      if (LiveId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LiveId);
      }
      if (CallTimestampMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(CallTimestampMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChatId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ChatId);
      }
      if (LiveId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(LiveId);
      }
      if (CallTimestampMs != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(CallTimestampMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ChatId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChatId);
      }
      if (LiveId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LiveId);
      }
      if (CallTimestampMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CallTimestampMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CommonStateSignalChatCall other) {
      if (other == null) {
        return;
      }
      if (other.ChatId.Length != 0) {
        ChatId = other.ChatId;
      }
      if (other.LiveId.Length != 0) {
        LiveId = other.LiveId;
      }
      if (other.CallTimestampMs != 0L) {
        CallTimestampMs = other.CallTimestampMs;
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
          case 10: {
            ChatId = input.ReadString();
            break;
          }
          case 18: {
            LiveId = input.ReadString();
            break;
          }
          case 24: {
            CallTimestampMs = input.ReadInt64();
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
          case 10: {
            ChatId = input.ReadString();
            break;
          }
          case 18: {
            LiveId = input.ReadString();
            break;
          }
          case 24: {
            CallTimestampMs = input.ReadInt64();
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
