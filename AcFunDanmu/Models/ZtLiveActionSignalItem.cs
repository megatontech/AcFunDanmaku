// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ZtLiveActionSignalItem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from ZtLiveActionSignalItem.proto</summary>
  public static partial class ZtLiveActionSignalItemReflection {

    #region Descriptor
    /// <summary>File descriptor for ZtLiveActionSignalItem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZtLiveActionSignalItemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxadExpdmVBY3Rpb25TaWduYWxJdGVtLnByb3RvEgpBY0Z1bkRhbm11Ij0K",
            "Flp0TGl2ZUFjdGlvblNpZ25hbEl0ZW0SEgoKc2lnbmFsVHlwZRgBIAEoCRIP",
            "CgdwYXlsb2FkGAIgAygMYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.ZtLiveActionSignalItem), global::AcFunDanmu.ZtLiveActionSignalItem.Parser, new[]{ "SignalType", "Payload" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ZtLiveActionSignalItem : pb::IMessage<ZtLiveActionSignalItem>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZtLiveActionSignalItem> _parser = new pb::MessageParser<ZtLiveActionSignalItem>(() => new ZtLiveActionSignalItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ZtLiveActionSignalItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.ZtLiveActionSignalItemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveActionSignalItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveActionSignalItem(ZtLiveActionSignalItem other) : this() {
      signalType_ = other.signalType_;
      payload_ = other.payload_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveActionSignalItem Clone() {
      return new ZtLiveActionSignalItem(this);
    }

    /// <summary>Field number for the "signalType" field.</summary>
    public const int SignalTypeFieldNumber = 1;
    private string signalType_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SignalType {
      get { return signalType_; }
      set {
        signalType_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 2;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_payload_codec
        = pb::FieldCodec.ForBytes(18);
    private readonly pbc::RepeatedField<pb::ByteString> payload_ = new pbc::RepeatedField<pb::ByteString>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<pb::ByteString> Payload {
      get { return payload_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ZtLiveActionSignalItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ZtLiveActionSignalItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SignalType != other.SignalType) return false;
      if(!payload_.Equals(other.payload_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SignalType.Length != 0) hash ^= SignalType.GetHashCode();
      hash ^= payload_.GetHashCode();
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
      if (SignalType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SignalType);
      }
      payload_.WriteTo(output, _repeated_payload_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (SignalType.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(SignalType);
      }
      payload_.WriteTo(ref output, _repeated_payload_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SignalType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SignalType);
      }
      size += payload_.CalculateSize(_repeated_payload_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ZtLiveActionSignalItem other) {
      if (other == null) {
        return;
      }
      if (other.SignalType.Length != 0) {
        SignalType = other.SignalType;
      }
      payload_.Add(other.payload_);
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
            SignalType = input.ReadString();
            break;
          }
          case 18: {
            payload_.AddEntriesFrom(input, _repeated_payload_codec);
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
            SignalType = input.ReadString();
            break;
          }
          case 18: {
            payload_.AddEntriesFrom(ref input, _repeated_payload_codec);
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
