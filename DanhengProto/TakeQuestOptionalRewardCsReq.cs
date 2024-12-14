using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001315 RID: 4885
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeQuestOptionalRewardCsReq : IMessage<TakeQuestOptionalRewardCsReq>, IMessage, IEquatable<TakeQuestOptionalRewardCsReq>, IDeepCloneable<TakeQuestOptionalRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D3C RID: 15676
		// (get) Token: 0x0600D9F2 RID: 55794 RVA: 0x00244A05 File Offset: 0x00242C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeQuestOptionalRewardCsReq> Parser
		{
			get
			{
				return TakeQuestOptionalRewardCsReq._parser;
			}
		}

		// Token: 0x17003D3D RID: 15677
		// (get) Token: 0x0600D9F3 RID: 55795 RVA: 0x00244A0C File Offset: 0x00242C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeQuestOptionalRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D3E RID: 15678
		// (get) Token: 0x0600D9F4 RID: 55796 RVA: 0x00244A1E File Offset: 0x00242C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeQuestOptionalRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D9F5 RID: 55797 RVA: 0x00244A25 File Offset: 0x00242C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestOptionalRewardCsReq()
		{
		}

		// Token: 0x0600D9F6 RID: 55798 RVA: 0x00244A2D File Offset: 0x00242C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestOptionalRewardCsReq(TakeQuestOptionalRewardCsReq other) : this()
		{
			this.questId_ = other.questId_;
			this.optionalRewardId_ = other.optionalRewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9F7 RID: 55799 RVA: 0x00244A5E File Offset: 0x00242C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestOptionalRewardCsReq Clone()
		{
			return new TakeQuestOptionalRewardCsReq(this);
		}

		// Token: 0x17003D3F RID: 15679
		// (get) Token: 0x0600D9F8 RID: 55800 RVA: 0x00244A66 File Offset: 0x00242C66
		// (set) Token: 0x0600D9F9 RID: 55801 RVA: 0x00244A6E File Offset: 0x00242C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint QuestId
		{
			get
			{
				return this.questId_;
			}
			set
			{
				this.questId_ = value;
			}
		}

		// Token: 0x17003D40 RID: 15680
		// (get) Token: 0x0600D9FA RID: 55802 RVA: 0x00244A77 File Offset: 0x00242C77
		// (set) Token: 0x0600D9FB RID: 55803 RVA: 0x00244A7F File Offset: 0x00242C7F
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

		// Token: 0x0600D9FC RID: 55804 RVA: 0x00244A88 File Offset: 0x00242C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeQuestOptionalRewardCsReq);
		}

		// Token: 0x0600D9FD RID: 55805 RVA: 0x00244A96 File Offset: 0x00242C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeQuestOptionalRewardCsReq other)
		{
			return other != null && (other == this || (this.QuestId == other.QuestId && this.OptionalRewardId == other.OptionalRewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9FE RID: 55806 RVA: 0x00244AD4 File Offset: 0x00242CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.QuestId != 0U)
			{
				num ^= this.QuestId.GetHashCode();
			}
			if (this.OptionalRewardId != 0U)
			{
				num ^= this.OptionalRewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D9FF RID: 55807 RVA: 0x00244B2C File Offset: 0x00242D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DA00 RID: 55808 RVA: 0x00244B34 File Offset: 0x00242D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA01 RID: 55809 RVA: 0x00244B40 File Offset: 0x00242D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionalRewardId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.OptionalRewardId);
			}
			if (this.QuestId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.QuestId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA02 RID: 55810 RVA: 0x00244B9C File Offset: 0x00242D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.QuestId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.QuestId);
			}
			if (this.OptionalRewardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionalRewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DA03 RID: 55811 RVA: 0x00244BF4 File Offset: 0x00242DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeQuestOptionalRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.QuestId != 0U)
			{
				this.QuestId = other.QuestId;
			}
			if (other.OptionalRewardId != 0U)
			{
				this.OptionalRewardId = other.OptionalRewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA04 RID: 55812 RVA: 0x00244C44 File Offset: 0x00242E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA05 RID: 55813 RVA: 0x00244C50 File Offset: 0x00242E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.QuestId = input.ReadUInt32();
					}
				}
				else
				{
					this.OptionalRewardId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040056D2 RID: 22226
		private static readonly MessageParser<TakeQuestOptionalRewardCsReq> _parser = new MessageParser<TakeQuestOptionalRewardCsReq>(() => new TakeQuestOptionalRewardCsReq());

		// Token: 0x040056D3 RID: 22227
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056D4 RID: 22228
		public const int QuestIdFieldNumber = 12;

		// Token: 0x040056D5 RID: 22229
		private uint questId_;

		// Token: 0x040056D6 RID: 22230
		public const int OptionalRewardIdFieldNumber = 9;

		// Token: 0x040056D7 RID: 22231
		private uint optionalRewardId_;
	}
}
