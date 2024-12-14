using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D3 RID: 1235
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeGachaCeilingCsReq : IMessage<ExchangeGachaCeilingCsReq>, IMessage, IEquatable<ExchangeGachaCeilingCsReq>, IDeepCloneable<ExchangeGachaCeilingCsReq>, IBufferMessage
	{
		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06003736 RID: 14134 RVA: 0x000978F5 File Offset: 0x00095AF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeGachaCeilingCsReq> Parser
		{
			get
			{
				return ExchangeGachaCeilingCsReq._parser;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x000978FC File Offset: 0x00095AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeGachaCeilingCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003738 RID: 14136 RVA: 0x0009790E File Offset: 0x00095B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeGachaCeilingCsReq.Descriptor;
			}
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00097915 File Offset: 0x00095B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeGachaCeilingCsReq()
		{
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x0009791D File Offset: 0x00095B1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeGachaCeilingCsReq(ExchangeGachaCeilingCsReq other) : this()
		{
			this.gachaType_ = other.gachaType_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x0009794E File Offset: 0x00095B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeGachaCeilingCsReq Clone()
		{
			return new ExchangeGachaCeilingCsReq(this);
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x0600373C RID: 14140 RVA: 0x00097956 File Offset: 0x00095B56
		// (set) Token: 0x0600373D RID: 14141 RVA: 0x0009795E File Offset: 0x00095B5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaType
		{
			get
			{
				return this.gachaType_;
			}
			set
			{
				this.gachaType_ = value;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x0600373E RID: 14142 RVA: 0x00097967 File Offset: 0x00095B67
		// (set) Token: 0x0600373F RID: 14143 RVA: 0x0009796F File Offset: 0x00095B6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00097978 File Offset: 0x00095B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeGachaCeilingCsReq);
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00097986 File Offset: 0x00095B86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeGachaCeilingCsReq other)
		{
			return other != null && (other == this || (this.GachaType == other.GachaType && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x000979C4 File Offset: 0x00095BC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GachaType != 0U)
			{
				num ^= this.GachaType.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00097A1C File Offset: 0x00095C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00097A24 File Offset: 0x00095C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x00097A30 File Offset: 0x00095C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.GachaType != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.GachaType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00097A8C File Offset: 0x00095C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GachaType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaType);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00097AE4 File Offset: 0x00095CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeGachaCeilingCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GachaType != 0U)
			{
				this.GachaType = other.GachaType;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00097B34 File Offset: 0x00095D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00097B40 File Offset: 0x00095D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GachaType = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015E5 RID: 5605
		private static readonly MessageParser<ExchangeGachaCeilingCsReq> _parser = new MessageParser<ExchangeGachaCeilingCsReq>(() => new ExchangeGachaCeilingCsReq());

		// Token: 0x040015E6 RID: 5606
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015E7 RID: 5607
		public const int GachaTypeFieldNumber = 8;

		// Token: 0x040015E8 RID: 5608
		private uint gachaType_;

		// Token: 0x040015E9 RID: 5609
		public const int AvatarIdFieldNumber = 2;

		// Token: 0x040015EA RID: 5610
		private uint avatarId_;
	}
}
