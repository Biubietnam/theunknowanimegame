using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B61 RID: 2913
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyMoveCsReq : IMessage<MonopolyMoveCsReq>, IMessage, IEquatable<MonopolyMoveCsReq>, IDeepCloneable<MonopolyMoveCsReq>, IBufferMessage
	{
		// Token: 0x1700241D RID: 9245
		// (get) Token: 0x060080E8 RID: 33000 RVA: 0x00153E28 File Offset: 0x00152028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyMoveCsReq> Parser
		{
			get
			{
				return MonopolyMoveCsReq._parser;
			}
		}

		// Token: 0x1700241E RID: 9246
		// (get) Token: 0x060080E9 RID: 33001 RVA: 0x00153E2F File Offset: 0x0015202F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyMoveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700241F RID: 9247
		// (get) Token: 0x060080EA RID: 33002 RVA: 0x00153E41 File Offset: 0x00152041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyMoveCsReq.Descriptor;
			}
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x00153E48 File Offset: 0x00152048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyMoveCsReq()
		{
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x00153E50 File Offset: 0x00152050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyMoveCsReq(MonopolyMoveCsReq other) : this()
		{
			this.eKHBLMPONGH_ = other.eKHBLMPONGH_;
			this.kCCFEBKIEIJ_ = other.kCCFEBKIEIJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x00153E81 File Offset: 0x00152081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyMoveCsReq Clone()
		{
			return new MonopolyMoveCsReq(this);
		}

		// Token: 0x17002420 RID: 9248
		// (get) Token: 0x060080EE RID: 33006 RVA: 0x00153E89 File Offset: 0x00152089
		// (set) Token: 0x060080EF RID: 33007 RVA: 0x00153E91 File Offset: 0x00152091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EKHBLMPONGH
		{
			get
			{
				return this.eKHBLMPONGH_;
			}
			set
			{
				this.eKHBLMPONGH_ = value;
			}
		}

		// Token: 0x17002421 RID: 9249
		// (get) Token: 0x060080F0 RID: 33008 RVA: 0x00153E9A File Offset: 0x0015209A
		// (set) Token: 0x060080F1 RID: 33009 RVA: 0x00153EA2 File Offset: 0x001520A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KCCFEBKIEIJ
		{
			get
			{
				return this.kCCFEBKIEIJ_;
			}
			set
			{
				this.kCCFEBKIEIJ_ = value;
			}
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x00153EAB File Offset: 0x001520AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyMoveCsReq);
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x00153EB9 File Offset: 0x001520B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyMoveCsReq other)
		{
			return other != null && (other == this || (this.EKHBLMPONGH == other.EKHBLMPONGH && this.KCCFEBKIEIJ == other.KCCFEBKIEIJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x00153EF8 File Offset: 0x001520F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EKHBLMPONGH != 0U)
			{
				num ^= this.EKHBLMPONGH.GetHashCode();
			}
			if (this.KCCFEBKIEIJ != 0U)
			{
				num ^= this.KCCFEBKIEIJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x00153F50 File Offset: 0x00152150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060080F6 RID: 33014 RVA: 0x00153F58 File Offset: 0x00152158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x00153F64 File Offset: 0x00152164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KCCFEBKIEIJ != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.KCCFEBKIEIJ);
			}
			if (this.EKHBLMPONGH != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.EKHBLMPONGH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060080F8 RID: 33016 RVA: 0x00153FC0 File Offset: 0x001521C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EKHBLMPONGH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EKHBLMPONGH);
			}
			if (this.KCCFEBKIEIJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KCCFEBKIEIJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x00154018 File Offset: 0x00152218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyMoveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EKHBLMPONGH != 0U)
			{
				this.EKHBLMPONGH = other.EKHBLMPONGH;
			}
			if (other.KCCFEBKIEIJ != 0U)
			{
				this.KCCFEBKIEIJ = other.KCCFEBKIEIJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x00154068 File Offset: 0x00152268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x00154074 File Offset: 0x00152274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EKHBLMPONGH = input.ReadUInt32();
					}
				}
				else
				{
					this.KCCFEBKIEIJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400313D RID: 12605
		private static readonly MessageParser<MonopolyMoveCsReq> _parser = new MessageParser<MonopolyMoveCsReq>(() => new MonopolyMoveCsReq());

		// Token: 0x0400313E RID: 12606
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400313F RID: 12607
		public const int EKHBLMPONGHFieldNumber = 13;

		// Token: 0x04003140 RID: 12608
		private uint eKHBLMPONGH_;

		// Token: 0x04003141 RID: 12609
		public const int KCCFEBKIEIJFieldNumber = 3;

		// Token: 0x04003142 RID: 12610
		private uint kCCFEBKIEIJ_;
	}
}
