using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D83 RID: 3459
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RecallPetCsReq : IMessage<RecallPetCsReq>, IMessage, IEquatable<RecallPetCsReq>, IDeepCloneable<RecallPetCsReq>, IBufferMessage
	{
		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x06009A70 RID: 39536 RVA: 0x0019B094 File Offset: 0x00199294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RecallPetCsReq> Parser
		{
			get
			{
				return RecallPetCsReq._parser;
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x06009A71 RID: 39537 RVA: 0x0019B09B File Offset: 0x0019929B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecallPetCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x06009A72 RID: 39538 RVA: 0x0019B0AD File Offset: 0x001992AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallPetCsReq.Descriptor;
			}
		}

		// Token: 0x06009A73 RID: 39539 RVA: 0x0019B0B4 File Offset: 0x001992B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallPetCsReq()
		{
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x0019B0BC File Offset: 0x001992BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallPetCsReq(RecallPetCsReq other) : this()
		{
			this.summonedPetId_ = other.summonedPetId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009A75 RID: 39541 RVA: 0x0019B0E1 File Offset: 0x001992E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallPetCsReq Clone()
		{
			return new RecallPetCsReq(this);
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x06009A76 RID: 39542 RVA: 0x0019B0E9 File Offset: 0x001992E9
		// (set) Token: 0x06009A77 RID: 39543 RVA: 0x0019B0F1 File Offset: 0x001992F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SummonedPetId
		{
			get
			{
				return this.summonedPetId_;
			}
			set
			{
				this.summonedPetId_ = value;
			}
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x0019B0FA File Offset: 0x001992FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallPetCsReq);
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x0019B108 File Offset: 0x00199308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallPetCsReq other)
		{
			return other != null && (other == this || (this.SummonedPetId == other.SummonedPetId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x0019B138 File Offset: 0x00199338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonedPetId != 0U)
			{
				num ^= this.SummonedPetId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x0019B177 File Offset: 0x00199377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x0019B17F File Offset: 0x0019937F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x0019B188 File Offset: 0x00199388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonedPetId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.SummonedPetId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x0019B1BC File Offset: 0x001993BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonedPetId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SummonedPetId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x0019B1FA File Offset: 0x001993FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallPetCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonedPetId != 0U)
			{
				this.SummonedPetId = other.SummonedPetId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x0019B22B File Offset: 0x0019942B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x0019B234 File Offset: 0x00199434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SummonedPetId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BF8 RID: 15352
		private static readonly MessageParser<RecallPetCsReq> _parser = new MessageParser<RecallPetCsReq>(() => new RecallPetCsReq());

		// Token: 0x04003BF9 RID: 15353
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BFA RID: 15354
		public const int SummonedPetIdFieldNumber = 9;

		// Token: 0x04003BFB RID: 15355
		private uint summonedPetId_;
	}
}
