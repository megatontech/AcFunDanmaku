// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: live.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunOBS {

  /// <summary>Holder for reflection information generated from live.proto</summary>
  public static partial class LiveReflection {

    #region Descriptor
    /// <summary>File descriptor for live.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LiveReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpsaXZlLnByb3RvEghBY0Z1bk9CUyKGAQoQU3RhcnRQdXNoUmVxdWVzdBIQ",
            "CghjYXRlZ29yeRgBIAEoBRIMCgR0eXBlGAIgASgFEg8KB2JpdHJhdGUYAyAB",
            "KAUSCwoDZnBzGAQgASgFEhAKCHVua25vd24xGAUgASgFEhAKCHVua25vd24y",
            "GAYgASgFEhAKCHVua25vd24zGAcgASgFYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunOBS.StartPushRequest), global::AcFunOBS.StartPushRequest.Parser, new[]{ "Category", "Type", "Bitrate", "Fps", "Unknown1", "Unknown2", "Unknown3" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class StartPushRequest : pb::IMessage<StartPushRequest> {
    private static readonly pb::MessageParser<StartPushRequest> _parser = new pb::MessageParser<StartPushRequest>(() => new StartPushRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StartPushRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunOBS.LiveReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartPushRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartPushRequest(StartPushRequest other) : this() {
      category_ = other.category_;
      type_ = other.type_;
      bitrate_ = other.bitrate_;
      fps_ = other.fps_;
      unknown1_ = other.unknown1_;
      unknown2_ = other.unknown2_;
      unknown3_ = other.unknown3_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StartPushRequest Clone() {
      return new StartPushRequest(this);
    }

    /// <summary>Field number for the "category" field.</summary>
    public const int CategoryFieldNumber = 1;
    private int category_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Category {
      get { return category_; }
      set {
        category_ = value;
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private int type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "bitrate" field.</summary>
    public const int BitrateFieldNumber = 3;
    private int bitrate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Bitrate {
      get { return bitrate_; }
      set {
        bitrate_ = value;
      }
    }

    /// <summary>Field number for the "fps" field.</summary>
    public const int FpsFieldNumber = 4;
    private int fps_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Fps {
      get { return fps_; }
      set {
        fps_ = value;
      }
    }

    /// <summary>Field number for the "unknown1" field.</summary>
    public const int Unknown1FieldNumber = 5;
    private int unknown1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Unknown1 {
      get { return unknown1_; }
      set {
        unknown1_ = value;
      }
    }

    /// <summary>Field number for the "unknown2" field.</summary>
    public const int Unknown2FieldNumber = 6;
    private int unknown2_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Unknown2 {
      get { return unknown2_; }
      set {
        unknown2_ = value;
      }
    }

    /// <summary>Field number for the "unknown3" field.</summary>
    public const int Unknown3FieldNumber = 7;
    private int unknown3_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Unknown3 {
      get { return unknown3_; }
      set {
        unknown3_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StartPushRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StartPushRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Category != other.Category) return false;
      if (Type != other.Type) return false;
      if (Bitrate != other.Bitrate) return false;
      if (Fps != other.Fps) return false;
      if (Unknown1 != other.Unknown1) return false;
      if (Unknown2 != other.Unknown2) return false;
      if (Unknown3 != other.Unknown3) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Category != 0) hash ^= Category.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Bitrate != 0) hash ^= Bitrate.GetHashCode();
      if (Fps != 0) hash ^= Fps.GetHashCode();
      if (Unknown1 != 0) hash ^= Unknown1.GetHashCode();
      if (Unknown2 != 0) hash ^= Unknown2.GetHashCode();
      if (Unknown3 != 0) hash ^= Unknown3.GetHashCode();
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
      if (Category != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Category);
      }
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Type);
      }
      if (Bitrate != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Bitrate);
      }
      if (Fps != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Fps);
      }
      if (Unknown1 != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Unknown1);
      }
      if (Unknown2 != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Unknown2);
      }
      if (Unknown3 != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(Unknown3);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Category != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Category);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Type);
      }
      if (Bitrate != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Bitrate);
      }
      if (Fps != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Fps);
      }
      if (Unknown1 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown1);
      }
      if (Unknown2 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown2);
      }
      if (Unknown3 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Unknown3);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StartPushRequest other) {
      if (other == null) {
        return;
      }
      if (other.Category != 0) {
        Category = other.Category;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Bitrate != 0) {
        Bitrate = other.Bitrate;
      }
      if (other.Fps != 0) {
        Fps = other.Fps;
      }
      if (other.Unknown1 != 0) {
        Unknown1 = other.Unknown1;
      }
      if (other.Unknown2 != 0) {
        Unknown2 = other.Unknown2;
      }
      if (other.Unknown3 != 0) {
        Unknown3 = other.Unknown3;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Category = input.ReadInt32();
            break;
          }
          case 16: {
            Type = input.ReadInt32();
            break;
          }
          case 24: {
            Bitrate = input.ReadInt32();
            break;
          }
          case 32: {
            Fps = input.ReadInt32();
            break;
          }
          case 40: {
            Unknown1 = input.ReadInt32();
            break;
          }
          case 48: {
            Unknown2 = input.ReadInt32();
            break;
          }
          case 56: {
            Unknown3 = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code