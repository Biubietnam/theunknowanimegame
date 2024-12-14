using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D75 RID: 3445
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RankUpAvatarCsReq : IMessage<RankUpAvatarCsReq>, IMessage, IEquatable<RankUpAvatarCsReq>, IDeepCloneable<RankUpAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17002B6F RID: 11119
		// (get) Token: 0x060099E8 RID: 39400 RVA: 0x00199D4D File Offset: 0x00197F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RankUpAvatarCsReq> Parser
		{
			get
			{
				return RankUpAvatarCsReq._parser;
			}
		}

		// Token: 0x17002B70 RID: 11120
		// (get) Token: 0x060099E9 RID: 39401 RVA: 0x00199D54 File Offset: 0x00197F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RankUpAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B71 RID: 11121
		// (get) Token: 0x060099EA RID: 39402 RVA: 0x00199D66 File Offset: 0x00197F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RankUpAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x060099EB RID: 39403 RVA: 0x00199D6D File Offset: 0x00197F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpAvatarCsReq()
		{
		}

		// Token: 0x060099EC RID: 39404 RVA: 0x00199D78 File Offset: 0x00197F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpAvatarCsReq(RankUpAvatarCsReq other) : this()
		{
			this.rank_ = other.rank_;
			this.costData_ = ((other.costData_ != null) ? other.costData_.Clone() : null);
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060099ED RID: 39405 RVA: 0x00199DD0 File Offset: 0x00197FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RankUpAvatarCsReq Clone()
		{
			return new RankUpAvatarCsReq(this);
		}

		// Token: 0x17002B72 RID: 11122
		// (get) Token: 0x060099EE RID: 39406 RVA: 0x00199DD8 File Offset: 0x00197FD8
		// (set) Token: 0x060099EF RID: 39407 RVA: 0x00199DE0 File Offset: 0x00197FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Rank
		{
			get
			{
				return this.rank_;
			}
			set
			{
				this.rank_ = value;
			}
		}

		// Token: 0x17002B73 RID: 11123
		// (get) Token: 0x060099F0 RID: 39408 RVA: 0x00199DE9 File Offset: 0x00197FE9
		// (set) Token: 0x060099F1 RID: 39409 RVA: 0x00199DF1 File Offset: 0x00197FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemCostData CostData
		{
			get
			{
				return this.costData_;
			}
			set
			{
				this.costData_ = value;
			}
		}

		// Token: 0x17002B74 RID: 11124
		// (get) Token: 0x060099F2 RID: 39410 RVA: 0x00199DFA File Offset: 0x00197FFA
		// (set) Token: 0x060099F3 RID: 39411 RVA: 0x00199E02 File Offset: 0x00198002
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

		// Token: 0x060099F4 RID: 39412 RVA: 0x00199E0B File Offset: 0x0019800B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RankUpAvatarCsReq);
		}

		// Token: 0x060099F5 RID: 39413 RVA: 0x00199E1C File Offset: 0x0019801C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RankUpAvatarCsReq other)
		{
			return other != null && (other == this || (this.Rank == other.Rank && object.Equals(this.CostData, other.CostData) && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060099F6 RID: 39414 RVA: 0x00199E7C File Offset: 0x0019807C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Rank != 0U)
			{
				num ^= this.Rank.GetHashCode();
			}
			if (this.costData_ != null)
			{
				num ^= this.CostData.GetHashCode();
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

		// Token: 0x060099F7 RID: 39415 RVA: 0x00199EEA File Offset: 0x001980EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060099F8 RID: 39416 RVA: 0x00199EF2 File Offset: 0x001980F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060099F9 RID: 39417 RVA: 0x00199EFC File Offset: 0x001980FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Rank != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Rank);
			}
			if (this.costData_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CostData);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060099FA RID: 39418 RVA: 0x00199F74 File Offset: 0x00198174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Rank != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Rank);
			}
			if (this.costData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CostData);
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

		// Token: 0x060099FB RID: 39419 RVA: 0x00199FE4 File Offset: 0x001981E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RankUpAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Rank != 0U)
			{
				this.Rank = other.Rank;
			}
			if (other.costData_ != null)
			{
				if (this.costData_ == null)
				{
					this.CostData = new ItemCostData();
				}
				this.CostData.MergeFrom(other.CostData);
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060099FC RID: 39420 RVA: 0x0019A060 File Offset: 0x00198260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060099FD RID: 39421 RVA: 0x0019A06C File Offset: 0x0019826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 88U)
				{
					if (num != 106U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AvatarId = input.ReadUInt32();
						}
					}
					else
					{
						if (this.costData_ == null)
						{
							this.CostData = new ItemCostData();
						}
						input.ReadMessage(this.CostData);
					}
				}
				else
				{
					this.Rank = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003BC9 RID: 15305
		private static readonly MessageParser<RankUpAvatarCsReq> _parser = new MessageParser<RankUpAvatarCsReq>(() => new RankUpAvatarCsReq());

		// Token: 0x04003BCA RID: 15306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BCB RID: 15307
		public const int RankFieldNumber = 11;

		// Token: 0x04003BCC RID: 15308
		private uint rank_;

		// Token: 0x04003BCD RID: 15309
		public const int CostDataFieldNumber = 13;

		// Token: 0x04003BCE RID: 15310
		private ItemCostData costData_;

		// Token: 0x04003BCF RID: 15311
		public const int AvatarIdFieldNumber = 14;

		// Token: 0x04003BD0 RID: 15312
		private uint avatarId_;
	}
}
