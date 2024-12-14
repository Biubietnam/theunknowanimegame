using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DC1 RID: 3521
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ReportPlayerCsReq : IMessage<ReportPlayerCsReq>, IMessage, IEquatable<ReportPlayerCsReq>, IDeepCloneable<ReportPlayerCsReq>, IBufferMessage
	{
		// Token: 0x17002C76 RID: 11382
		// (get) Token: 0x06009D6F RID: 40303 RVA: 0x001A3901 File Offset: 0x001A1B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ReportPlayerCsReq> Parser
		{
			get
			{
				return ReportPlayerCsReq._parser;
			}
		}

		// Token: 0x17002C77 RID: 11383
		// (get) Token: 0x06009D70 RID: 40304 RVA: 0x001A3908 File Offset: 0x001A1B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ReportPlayerCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C78 RID: 11384
		// (get) Token: 0x06009D71 RID: 40305 RVA: 0x001A391A File Offset: 0x001A1B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReportPlayerCsReq.Descriptor;
			}
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x001A3921 File Offset: 0x001A1B21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerCsReq()
		{
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x001A3934 File Offset: 0x001A1B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerCsReq(ReportPlayerCsReq other) : this()
		{
			this.fPJPECOIPHI_ = other.fPJPECOIPHI_;
			this.uid_ = other.uid_;
			this.hDEJCEFADLP_ = other.hDEJCEFADLP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x001A3971 File Offset: 0x001A1B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReportPlayerCsReq Clone()
		{
			return new ReportPlayerCsReq(this);
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x06009D75 RID: 40309 RVA: 0x001A3979 File Offset: 0x001A1B79
		// (set) Token: 0x06009D76 RID: 40310 RVA: 0x001A3981 File Offset: 0x001A1B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string FPJPECOIPHI
		{
			get
			{
				return this.fPJPECOIPHI_;
			}
			set
			{
				this.fPJPECOIPHI_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x06009D77 RID: 40311 RVA: 0x001A3994 File Offset: 0x001A1B94
		// (set) Token: 0x06009D78 RID: 40312 RVA: 0x001A399C File Offset: 0x001A1B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x06009D79 RID: 40313 RVA: 0x001A39A5 File Offset: 0x001A1BA5
		// (set) Token: 0x06009D7A RID: 40314 RVA: 0x001A39AD File Offset: 0x001A1BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HDEJCEFADLP
		{
			get
			{
				return this.hDEJCEFADLP_;
			}
			set
			{
				this.hDEJCEFADLP_ = value;
			}
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x001A39B6 File Offset: 0x001A1BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReportPlayerCsReq);
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x001A39C4 File Offset: 0x001A1BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReportPlayerCsReq other)
		{
			return other != null && (other == this || (!(this.FPJPECOIPHI != other.FPJPECOIPHI) && this.Uid == other.Uid && this.HDEJCEFADLP == other.HDEJCEFADLP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D7D RID: 40317 RVA: 0x001A3A24 File Offset: 0x001A1C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FPJPECOIPHI.Length != 0)
			{
				num ^= this.FPJPECOIPHI.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.HDEJCEFADLP != 0U)
			{
				num ^= this.HDEJCEFADLP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x001A3A97 File Offset: 0x001A1C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x001A3A9F File Offset: 0x001A1C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x001A3AA8 File Offset: 0x001A1CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FPJPECOIPHI.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.FPJPECOIPHI);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Uid);
			}
			if (this.HDEJCEFADLP != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.HDEJCEFADLP);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x001A3B24 File Offset: 0x001A1D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FPJPECOIPHI.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.FPJPECOIPHI);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.HDEJCEFADLP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HDEJCEFADLP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x001A3B98 File Offset: 0x001A1D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReportPlayerCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FPJPECOIPHI.Length != 0)
			{
				this.FPJPECOIPHI = other.FPJPECOIPHI;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.HDEJCEFADLP != 0U)
			{
				this.HDEJCEFADLP = other.HDEJCEFADLP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x001A3C01 File Offset: 0x001A1E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x001A3C0C File Offset: 0x001A1E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 40U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HDEJCEFADLP = input.ReadUInt32();
						}
					}
					else
					{
						this.Uid = input.ReadUInt32();
					}
				}
				else
				{
					this.FPJPECOIPHI = input.ReadString();
				}
			}
		}

		// Token: 0x04003D3F RID: 15679
		private static readonly MessageParser<ReportPlayerCsReq> _parser = new MessageParser<ReportPlayerCsReq>(() => new ReportPlayerCsReq());

		// Token: 0x04003D40 RID: 15680
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D41 RID: 15681
		public const int FPJPECOIPHIFieldNumber = 3;

		// Token: 0x04003D42 RID: 15682
		private string fPJPECOIPHI_ = "";

		// Token: 0x04003D43 RID: 15683
		public const int UidFieldNumber = 5;

		// Token: 0x04003D44 RID: 15684
		private uint uid_;

		// Token: 0x04003D45 RID: 15685
		public const int HDEJCEFADLPFieldNumber = 11;

		// Token: 0x04003D46 RID: 15686
		private uint hDEJCEFADLP_;
	}
}
