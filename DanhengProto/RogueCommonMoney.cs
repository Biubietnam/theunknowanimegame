using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E5B RID: 3675
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueCommonMoney : IMessage<RogueCommonMoney>, IMessage, IEquatable<RogueCommonMoney>, IDeepCloneable<RogueCommonMoney>, IBufferMessage
	{
		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x0600A3EB RID: 41963 RVA: 0x001B8C28 File Offset: 0x001B6E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueCommonMoney> Parser
		{
			get
			{
				return RogueCommonMoney._parser;
			}
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x0600A3EC RID: 41964 RVA: 0x001B8C2F File Offset: 0x001B6E2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueCommonMoneyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x0600A3ED RID: 41965 RVA: 0x001B8C41 File Offset: 0x001B6E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueCommonMoney.Descriptor;
			}
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x001B8C48 File Offset: 0x001B6E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMoney()
		{
		}

		// Token: 0x0600A3EF RID: 41967 RVA: 0x001B8C50 File Offset: 0x001B6E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMoney(RogueCommonMoney other) : this()
		{
			this.displayType_ = other.displayType_;
			this.num_ = other.num_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x001B8C81 File Offset: 0x001B6E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonMoney Clone()
		{
			return new RogueCommonMoney(this);
		}

		// Token: 0x17002E4A RID: 11850
		// (get) Token: 0x0600A3F1 RID: 41969 RVA: 0x001B8C89 File Offset: 0x001B6E89
		// (set) Token: 0x0600A3F2 RID: 41970 RVA: 0x001B8C91 File Offset: 0x001B6E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DisplayType
		{
			get
			{
				return this.displayType_;
			}
			set
			{
				this.displayType_ = value;
			}
		}

		// Token: 0x17002E4B RID: 11851
		// (get) Token: 0x0600A3F3 RID: 41971 RVA: 0x001B8C9A File Offset: 0x001B6E9A
		// (set) Token: 0x0600A3F4 RID: 41972 RVA: 0x001B8CA2 File Offset: 0x001B6EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x001B8CAB File Offset: 0x001B6EAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueCommonMoney);
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x001B8CB9 File Offset: 0x001B6EB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueCommonMoney other)
		{
			return other != null && (other == this || (this.DisplayType == other.DisplayType && this.Num == other.Num && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x001B8CF8 File Offset: 0x001B6EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DisplayType != 0U)
			{
				num ^= this.DisplayType.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x001B8D50 File Offset: 0x001B6F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x001B8D58 File Offset: 0x001B6F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x001B8D64 File Offset: 0x001B6F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DisplayType != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.DisplayType);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Num);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x001B8DC0 File Offset: 0x001B6FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DisplayType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DisplayType);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x001B8E18 File Offset: 0x001B7018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueCommonMoney other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DisplayType != 0U)
			{
				this.DisplayType = other.DisplayType;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x001B8E68 File Offset: 0x001B7068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x001B8E74 File Offset: 0x001B7074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.DisplayType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400430D RID: 17165
		private static readonly MessageParser<RogueCommonMoney> _parser = new MessageParser<RogueCommonMoney>(() => new RogueCommonMoney());

		// Token: 0x0400430E RID: 17166
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400430F RID: 17167
		public const int DisplayTypeFieldNumber = 4;

		// Token: 0x04004310 RID: 17168
		private uint displayType_;

		// Token: 0x04004311 RID: 17169
		public const int NumFieldNumber = 9;

		// Token: 0x04004312 RID: 17170
		private uint num_;
	}
}
