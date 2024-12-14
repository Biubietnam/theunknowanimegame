using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D9D RID: 3485
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicAffix : IMessage<RelicAffix>, IMessage, IEquatable<RelicAffix>, IDeepCloneable<RelicAffix>, IBufferMessage
	{
		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x06009BB6 RID: 39862 RVA: 0x0019E834 File Offset: 0x0019CA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicAffix> Parser
		{
			get
			{
				return RelicAffix._parser;
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x06009BB7 RID: 39863 RVA: 0x0019E83B File Offset: 0x0019CA3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicAffixReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x06009BB8 RID: 39864 RVA: 0x0019E84D File Offset: 0x0019CA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicAffix.Descriptor;
			}
		}

		// Token: 0x06009BB9 RID: 39865 RVA: 0x0019E854 File Offset: 0x0019CA54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAffix()
		{
		}

		// Token: 0x06009BBA RID: 39866 RVA: 0x0019E85C File Offset: 0x0019CA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAffix(RelicAffix other) : this()
		{
			this.affixId_ = other.affixId_;
			this.cnt_ = other.cnt_;
			this.step_ = other.step_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x0019E899 File Offset: 0x0019CA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAffix Clone()
		{
			return new RelicAffix(this);
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x06009BBC RID: 39868 RVA: 0x0019E8A1 File Offset: 0x0019CAA1
		// (set) Token: 0x06009BBD RID: 39869 RVA: 0x0019E8A9 File Offset: 0x0019CAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AffixId
		{
			get
			{
				return this.affixId_;
			}
			set
			{
				this.affixId_ = value;
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x06009BBE RID: 39870 RVA: 0x0019E8B2 File Offset: 0x0019CAB2
		// (set) Token: 0x06009BBF RID: 39871 RVA: 0x0019E8BA File Offset: 0x0019CABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Cnt
		{
			get
			{
				return this.cnt_;
			}
			set
			{
				this.cnt_ = value;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x06009BC0 RID: 39872 RVA: 0x0019E8C3 File Offset: 0x0019CAC3
		// (set) Token: 0x06009BC1 RID: 39873 RVA: 0x0019E8CB File Offset: 0x0019CACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Step
		{
			get
			{
				return this.step_;
			}
			set
			{
				this.step_ = value;
			}
		}

		// Token: 0x06009BC2 RID: 39874 RVA: 0x0019E8D4 File Offset: 0x0019CAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicAffix);
		}

		// Token: 0x06009BC3 RID: 39875 RVA: 0x0019E8E4 File Offset: 0x0019CAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicAffix other)
		{
			return other != null && (other == this || (this.AffixId == other.AffixId && this.Cnt == other.Cnt && this.Step == other.Step && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x0019E940 File Offset: 0x0019CB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AffixId != 0U)
			{
				num ^= this.AffixId.GetHashCode();
			}
			if (this.Cnt != 0U)
			{
				num ^= this.Cnt.GetHashCode();
			}
			if (this.Step != 0U)
			{
				num ^= this.Step.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BC5 RID: 39877 RVA: 0x0019E9B1 File Offset: 0x0019CBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BC6 RID: 39878 RVA: 0x0019E9B9 File Offset: 0x0019CBB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BC7 RID: 39879 RVA: 0x0019E9C4 File Offset: 0x0019CBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AffixId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AffixId);
			}
			if (this.Cnt != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Cnt);
			}
			if (this.Step != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Step);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BC8 RID: 39880 RVA: 0x0019EA38 File Offset: 0x0019CC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AffixId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AffixId);
			}
			if (this.Cnt != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Cnt);
			}
			if (this.Step != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Step);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BC9 RID: 39881 RVA: 0x0019EAA8 File Offset: 0x0019CCA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicAffix other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AffixId != 0U)
			{
				this.AffixId = other.AffixId;
			}
			if (other.Cnt != 0U)
			{
				this.Cnt = other.Cnt;
			}
			if (other.Step != 0U)
			{
				this.Step = other.Step;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x0019EB0C File Offset: 0x0019CD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x0019EB18 File Offset: 0x0019CD18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Step = input.ReadUInt32();
						}
					}
					else
					{
						this.Cnt = input.ReadUInt32();
					}
				}
				else
				{
					this.AffixId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003C74 RID: 15476
		private static readonly MessageParser<RelicAffix> _parser = new MessageParser<RelicAffix>(() => new RelicAffix());

		// Token: 0x04003C75 RID: 15477
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C76 RID: 15478
		public const int AffixIdFieldNumber = 1;

		// Token: 0x04003C77 RID: 15479
		private uint affixId_;

		// Token: 0x04003C78 RID: 15480
		public const int CntFieldNumber = 2;

		// Token: 0x04003C79 RID: 15481
		private uint cnt_;

		// Token: 0x04003C7A RID: 15482
		public const int StepFieldNumber = 3;

		// Token: 0x04003C7B RID: 15483
		private uint step_;
	}
}
