using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000823 RID: 2083
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTelevisionActivityDataScRsp : IMessage<GetTelevisionActivityDataScRsp>, IMessage, IEquatable<GetTelevisionActivityDataScRsp>, IDeepCloneable<GetTelevisionActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06005CC0 RID: 23744 RVA: 0x000F66BF File Offset: 0x000F48BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTelevisionActivityDataScRsp> Parser
		{
			get
			{
				return GetTelevisionActivityDataScRsp._parser;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06005CC1 RID: 23745 RVA: 0x000F66C6 File Offset: 0x000F48C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTelevisionActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06005CC2 RID: 23746 RVA: 0x000F66D8 File Offset: 0x000F48D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTelevisionActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x000F66DF File Offset: 0x000F48DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTelevisionActivityDataScRsp()
		{
		}

		// Token: 0x06005CC4 RID: 23748 RVA: 0x000F66F2 File Offset: 0x000F48F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTelevisionActivityDataScRsp(GetTelevisionActivityDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lPEAPMPCFBD_ = other.lPEAPMPCFBD_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x000F6728 File Offset: 0x000F4928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTelevisionActivityDataScRsp Clone()
		{
			return new GetTelevisionActivityDataScRsp(this);
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06005CC6 RID: 23750 RVA: 0x000F6730 File Offset: 0x000F4930
		// (set) Token: 0x06005CC7 RID: 23751 RVA: 0x000F6738 File Offset: 0x000F4938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06005CC8 RID: 23752 RVA: 0x000F6741 File Offset: 0x000F4941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TelevisionActivityData> LPEAPMPCFBD
		{
			get
			{
				return this.lPEAPMPCFBD_;
			}
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x000F6749 File Offset: 0x000F4949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTelevisionActivityDataScRsp);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x000F6758 File Offset: 0x000F4958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTelevisionActivityDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.lPEAPMPCFBD_.Equals(other.lPEAPMPCFBD_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CCB RID: 23755 RVA: 0x000F67A8 File Offset: 0x000F49A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.lPEAPMPCFBD_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CCC RID: 23756 RVA: 0x000F67F5 File Offset: 0x000F49F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x000F67FD File Offset: 0x000F49FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x000F6808 File Offset: 0x000F4A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lPEAPMPCFBD_.WriteTo(ref output, GetTelevisionActivityDataScRsp._repeated_lPEAPMPCFBD_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CCF RID: 23759 RVA: 0x000F6858 File Offset: 0x000F4A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.lPEAPMPCFBD_.CalculateSize(GetTelevisionActivityDataScRsp._repeated_lPEAPMPCFBD_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CD0 RID: 23760 RVA: 0x000F68AC File Offset: 0x000F4AAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTelevisionActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.lPEAPMPCFBD_.Add(other.lPEAPMPCFBD_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CD1 RID: 23761 RVA: 0x000F68F9 File Offset: 0x000F4AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CD2 RID: 23762 RVA: 0x000F6904 File Offset: 0x000F4B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.lPEAPMPCFBD_.AddEntriesFrom(ref input, GetTelevisionActivityDataScRsp._repeated_lPEAPMPCFBD_codec);
				}
			}
		}

		// Token: 0x040023DD RID: 9181
		private static readonly MessageParser<GetTelevisionActivityDataScRsp> _parser = new MessageParser<GetTelevisionActivityDataScRsp>(() => new GetTelevisionActivityDataScRsp());

		// Token: 0x040023DE RID: 9182
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023DF RID: 9183
		public const int RetcodeFieldNumber = 12;

		// Token: 0x040023E0 RID: 9184
		private uint retcode_;

		// Token: 0x040023E1 RID: 9185
		public const int LPEAPMPCFBDFieldNumber = 1;

		// Token: 0x040023E2 RID: 9186
		private static readonly FieldCodec<TelevisionActivityData> _repeated_lPEAPMPCFBD_codec = FieldCodec.ForMessage<TelevisionActivityData>(10U, TelevisionActivityData.Parser);

		// Token: 0x040023E3 RID: 9187
		private readonly RepeatedField<TelevisionActivityData> lPEAPMPCFBD_ = new RepeatedField<TelevisionActivityData>();
	}
}
