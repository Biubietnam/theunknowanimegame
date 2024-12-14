using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012CB RID: 4811
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeChapterRewardCsReq : IMessage<TakeChapterRewardCsReq>, IMessage, IEquatable<TakeChapterRewardCsReq>, IDeepCloneable<TakeChapterRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C54 RID: 15444
		// (get) Token: 0x0600D697 RID: 54935 RVA: 0x0023C60D File Offset: 0x0023A80D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeChapterRewardCsReq> Parser
		{
			get
			{
				return TakeChapterRewardCsReq._parser;
			}
		}

		// Token: 0x17003C55 RID: 15445
		// (get) Token: 0x0600D698 RID: 54936 RVA: 0x0023C614 File Offset: 0x0023A814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeChapterRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x0600D699 RID: 54937 RVA: 0x0023C626 File Offset: 0x0023A826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeChapterRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D69A RID: 54938 RVA: 0x0023C62D File Offset: 0x0023A82D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChapterRewardCsReq()
		{
		}

		// Token: 0x0600D69B RID: 54939 RVA: 0x0023C635 File Offset: 0x0023A835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChapterRewardCsReq(TakeChapterRewardCsReq other) : this()
		{
			this.cIGPMMBDEJD_ = other.cIGPMMBDEJD_;
			this.fNIGBOMHLBE_ = other.fNIGBOMHLBE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D69C RID: 54940 RVA: 0x0023C666 File Offset: 0x0023A866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeChapterRewardCsReq Clone()
		{
			return new TakeChapterRewardCsReq(this);
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x0600D69D RID: 54941 RVA: 0x0023C66E File Offset: 0x0023A86E
		// (set) Token: 0x0600D69E RID: 54942 RVA: 0x0023C676 File Offset: 0x0023A876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CIGPMMBDEJD
		{
			get
			{
				return this.cIGPMMBDEJD_;
			}
			set
			{
				this.cIGPMMBDEJD_ = value;
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x0600D69F RID: 54943 RVA: 0x0023C67F File Offset: 0x0023A87F
		// (set) Token: 0x0600D6A0 RID: 54944 RVA: 0x0023C687 File Offset: 0x0023A887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FNIGBOMHLBE
		{
			get
			{
				return this.fNIGBOMHLBE_;
			}
			set
			{
				this.fNIGBOMHLBE_ = value;
			}
		}

		// Token: 0x0600D6A1 RID: 54945 RVA: 0x0023C690 File Offset: 0x0023A890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeChapterRewardCsReq);
		}

		// Token: 0x0600D6A2 RID: 54946 RVA: 0x0023C69E File Offset: 0x0023A89E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeChapterRewardCsReq other)
		{
			return other != null && (other == this || (this.CIGPMMBDEJD == other.CIGPMMBDEJD && this.FNIGBOMHLBE == other.FNIGBOMHLBE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D6A3 RID: 54947 RVA: 0x0023C6DC File Offset: 0x0023A8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CIGPMMBDEJD != 0U)
			{
				num ^= this.CIGPMMBDEJD.GetHashCode();
			}
			if (this.FNIGBOMHLBE != 0U)
			{
				num ^= this.FNIGBOMHLBE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D6A4 RID: 54948 RVA: 0x0023C734 File Offset: 0x0023A934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x0023C73C File Offset: 0x0023A93C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x0023C748 File Offset: 0x0023A948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FNIGBOMHLBE != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.FNIGBOMHLBE);
			}
			if (this.CIGPMMBDEJD != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.CIGPMMBDEJD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D6A7 RID: 54951 RVA: 0x0023C7A4 File Offset: 0x0023A9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CIGPMMBDEJD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CIGPMMBDEJD);
			}
			if (this.FNIGBOMHLBE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FNIGBOMHLBE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x0023C7FC File Offset: 0x0023A9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeChapterRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CIGPMMBDEJD != 0U)
			{
				this.CIGPMMBDEJD = other.CIGPMMBDEJD;
			}
			if (other.FNIGBOMHLBE != 0U)
			{
				this.FNIGBOMHLBE = other.FNIGBOMHLBE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x0023C84C File Offset: 0x0023AA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D6AA RID: 54954 RVA: 0x0023C858 File Offset: 0x0023AA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CIGPMMBDEJD = input.ReadUInt32();
					}
				}
				else
				{
					this.FNIGBOMHLBE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040055AF RID: 21935
		private static readonly MessageParser<TakeChapterRewardCsReq> _parser = new MessageParser<TakeChapterRewardCsReq>(() => new TakeChapterRewardCsReq());

		// Token: 0x040055B0 RID: 21936
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055B1 RID: 21937
		public const int CIGPMMBDEJDFieldNumber = 10;

		// Token: 0x040055B2 RID: 21938
		private uint cIGPMMBDEJD_;

		// Token: 0x040055B3 RID: 21939
		public const int FNIGBOMHLBEFieldNumber = 6;

		// Token: 0x040055B4 RID: 21940
		private uint fNIGBOMHLBE_;
	}
}
