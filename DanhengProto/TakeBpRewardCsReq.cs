using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012BF RID: 4799
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeBpRewardCsReq : IMessage<TakeBpRewardCsReq>, IMessage, IEquatable<TakeBpRewardCsReq>, IDeepCloneable<TakeBpRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C2F RID: 15407
		// (get) Token: 0x0600D60C RID: 54796 RVA: 0x0023B129 File Offset: 0x00239329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeBpRewardCsReq> Parser
		{
			get
			{
				return TakeBpRewardCsReq._parser;
			}
		}

		// Token: 0x17003C30 RID: 15408
		// (get) Token: 0x0600D60D RID: 54797 RVA: 0x0023B130 File Offset: 0x00239330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeBpRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C31 RID: 15409
		// (get) Token: 0x0600D60E RID: 54798 RVA: 0x0023B142 File Offset: 0x00239342
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeBpRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D60F RID: 54799 RVA: 0x0023B149 File Offset: 0x00239349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeBpRewardCsReq()
		{
		}

		// Token: 0x0600D610 RID: 54800 RVA: 0x0023B151 File Offset: 0x00239351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeBpRewardCsReq(TakeBpRewardCsReq other) : this()
		{
			this.type_ = other.type_;
			this.optionalRewardId_ = other.optionalRewardId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D611 RID: 54801 RVA: 0x0023B18E File Offset: 0x0023938E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeBpRewardCsReq Clone()
		{
			return new TakeBpRewardCsReq(this);
		}

		// Token: 0x17003C32 RID: 15410
		// (get) Token: 0x0600D612 RID: 54802 RVA: 0x0023B196 File Offset: 0x00239396
		// (set) Token: 0x0600D613 RID: 54803 RVA: 0x0023B19E File Offset: 0x0023939E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BpRewardType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17003C33 RID: 15411
		// (get) Token: 0x0600D614 RID: 54804 RVA: 0x0023B1A7 File Offset: 0x002393A7
		// (set) Token: 0x0600D615 RID: 54805 RVA: 0x0023B1AF File Offset: 0x002393AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionalRewardId
		{
			get
			{
				return this.optionalRewardId_;
			}
			set
			{
				this.optionalRewardId_ = value;
			}
		}

		// Token: 0x17003C34 RID: 15412
		// (get) Token: 0x0600D616 RID: 54806 RVA: 0x0023B1B8 File Offset: 0x002393B8
		// (set) Token: 0x0600D617 RID: 54807 RVA: 0x0023B1C0 File Offset: 0x002393C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600D618 RID: 54808 RVA: 0x0023B1C9 File Offset: 0x002393C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeBpRewardCsReq);
		}

		// Token: 0x0600D619 RID: 54809 RVA: 0x0023B1D8 File Offset: 0x002393D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeBpRewardCsReq other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.OptionalRewardId == other.OptionalRewardId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D61A RID: 54810 RVA: 0x0023B234 File Offset: 0x00239434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != BpRewardType.BpRewaradTypeNone)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.OptionalRewardId != 0U)
			{
				num ^= this.OptionalRewardId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D61B RID: 54811 RVA: 0x0023B2AB File Offset: 0x002394AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D61C RID: 54812 RVA: 0x0023B2B3 File Offset: 0x002394B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D61D RID: 54813 RVA: 0x0023B2BC File Offset: 0x002394BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Level);
			}
			if (this.Type != BpRewardType.BpRewaradTypeNone)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Type);
			}
			if (this.OptionalRewardId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.OptionalRewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D61E RID: 54814 RVA: 0x0023B334 File Offset: 0x00239534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != BpRewardType.BpRewaradTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.OptionalRewardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionalRewardId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D61F RID: 54815 RVA: 0x0023B3A4 File Offset: 0x002395A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeBpRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != BpRewardType.BpRewaradTypeNone)
			{
				this.Type = other.Type;
			}
			if (other.OptionalRewardId != 0U)
			{
				this.OptionalRewardId = other.OptionalRewardId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D620 RID: 54816 RVA: 0x0023B408 File Offset: 0x00239608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D621 RID: 54817 RVA: 0x0023B414 File Offset: 0x00239614
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
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OptionalRewardId = input.ReadUInt32();
						}
					}
					else
					{
						this.Type = (BpRewardType)input.ReadEnum();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005582 RID: 21890
		private static readonly MessageParser<TakeBpRewardCsReq> _parser = new MessageParser<TakeBpRewardCsReq>(() => new TakeBpRewardCsReq());

		// Token: 0x04005583 RID: 21891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005584 RID: 21892
		public const int TypeFieldNumber = 10;

		// Token: 0x04005585 RID: 21893
		private BpRewardType type_;

		// Token: 0x04005586 RID: 21894
		public const int OptionalRewardIdFieldNumber = 12;

		// Token: 0x04005587 RID: 21895
		private uint optionalRewardId_;

		// Token: 0x04005588 RID: 21896
		public const int LevelFieldNumber = 6;

		// Token: 0x04005589 RID: 21897
		private uint level_;
	}
}
