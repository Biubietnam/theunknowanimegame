using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200004B RID: 75
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AdventureRoomInfo : IMessage<AdventureRoomInfo>, IMessage, IEquatable<AdventureRoomInfo>, IDeepCloneable<AdventureRoomInfo>, IBufferMessage
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00009533 File Offset: 0x00007733
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AdventureRoomInfo> Parser
		{
			get
			{
				return AdventureRoomInfo._parser;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000953A File Offset: 0x0000773A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AdventureRoomInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000954C File Offset: 0x0000774C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdventureRoomInfo.Descriptor;
			}
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00009553 File Offset: 0x00007753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRoomInfo()
		{
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000955C File Offset: 0x0000775C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRoomInfo(AdventureRoomInfo other) : this()
		{
			this.remainMonsterNum_ = other.remainMonsterNum_;
			this.scoreId_ = other.scoreId_;
			this.status_ = other.status_;
			this.caughtMonsterNum_ = other.caughtMonsterNum_;
			this.queryInfo_ = ((other.queryInfo_ != null) ? other.queryInfo_.Clone() : null);
			this.sus_ = other.sus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x000095D8 File Offset: 0x000077D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdventureRoomInfo Clone()
		{
			return new AdventureRoomInfo(this);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002FE RID: 766 RVA: 0x000095E0 File Offset: 0x000077E0
		// (set) Token: 0x060002FF RID: 767 RVA: 0x000095E8 File Offset: 0x000077E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RemainMonsterNum
		{
			get
			{
				return this.remainMonsterNum_;
			}
			set
			{
				this.remainMonsterNum_ = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000095F1 File Offset: 0x000077F1
		// (set) Token: 0x06000301 RID: 769 RVA: 0x000095F9 File Offset: 0x000077F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00009602 File Offset: 0x00007802
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0000960A File Offset: 0x0000780A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00009613 File Offset: 0x00007813
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000961B File Offset: 0x0000781B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CaughtMonsterNum
		{
			get
			{
				return this.caughtMonsterNum_;
			}
			set
			{
				this.caughtMonsterNum_ = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00009624 File Offset: 0x00007824
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000962C File Offset: 0x0000782C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunInfo QueryInfo
		{
			get
			{
				return this.queryInfo_;
			}
			set
			{
				this.queryInfo_ = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00009635 File Offset: 0x00007835
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0000963D File Offset: 0x0000783D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double Sus
		{
			get
			{
				return this.sus_;
			}
			set
			{
				this.sus_ = value;
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00009646 File Offset: 0x00007846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdventureRoomInfo);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00009654 File Offset: 0x00007854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdventureRoomInfo other)
		{
			return other != null && (other == this || (this.RemainMonsterNum == other.RemainMonsterNum && this.ScoreId == other.ScoreId && this.Status == other.Status && this.CaughtMonsterNum == other.CaughtMonsterNum && object.Equals(this.QueryInfo, other.QueryInfo) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.Sus, other.Sus) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000096EC File Offset: 0x000078EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RemainMonsterNum != 0U)
			{
				num ^= this.RemainMonsterNum.GetHashCode();
			}
			if (this.ScoreId != 0U)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this.Status != RogueAdventureRoomStatus.None)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.CaughtMonsterNum != 0U)
			{
				num ^= this.CaughtMonsterNum.GetHashCode();
			}
			if (this.queryInfo_ != null)
			{
				num ^= this.QueryInfo.GetHashCode();
			}
			if (this.Sus != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.Sus);
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000097B6 File Offset: 0x000079B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000097BE File Offset: 0x000079BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000097C8 File Offset: 0x000079C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CaughtMonsterNum != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.CaughtMonsterNum);
			}
			if (this.Status != RogueAdventureRoomStatus.None)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.Status);
			}
			if (this.Sus != 0.0)
			{
				output.WriteRawTag(65);
				output.WriteDouble(this.Sus);
			}
			if (this.queryInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.QueryInfo);
			}
			if (this.RemainMonsterNum != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.RemainMonsterNum);
			}
			if (this.ScoreId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000989C File Offset: 0x00007A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RemainMonsterNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RemainMonsterNum);
			}
			if (this.ScoreId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScoreId);
			}
			if (this.Status != RogueAdventureRoomStatus.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this.CaughtMonsterNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CaughtMonsterNum);
			}
			if (this.queryInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryInfo);
			}
			if (this.Sus != 0.0)
			{
				num += 9;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00009950 File Offset: 0x00007B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdventureRoomInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RemainMonsterNum != 0U)
			{
				this.RemainMonsterNum = other.RemainMonsterNum;
			}
			if (other.ScoreId != 0U)
			{
				this.ScoreId = other.ScoreId;
			}
			if (other.Status != RogueAdventureRoomStatus.None)
			{
				this.Status = other.Status;
			}
			if (other.CaughtMonsterNum != 0U)
			{
				this.CaughtMonsterNum = other.CaughtMonsterNum;
			}
			if (other.queryInfo_ != null)
			{
				if (this.queryInfo_ == null)
				{
					this.QueryInfo = new RogueAdventureRoomGameplayWolfGunInfo();
				}
				this.QueryInfo.MergeFrom(other.QueryInfo);
			}
			if (other.Sus != 0.0)
			{
				this.Sus = other.Sus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00009A11 File Offset: 0x00007C11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00009A1C File Offset: 0x00007C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 65U)
				{
					if (num == 24U)
					{
						this.CaughtMonsterNum = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Status = (RogueAdventureRoomStatus)input.ReadEnum();
						continue;
					}
					if (num == 65U)
					{
						this.Sus = input.ReadDouble();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.queryInfo_ == null)
						{
							this.QueryInfo = new RogueAdventureRoomGameplayWolfGunInfo();
						}
						input.ReadMessage(this.QueryInfo);
						continue;
					}
					if (num == 104U)
					{
						this.RemainMonsterNum = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ScoreId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000110 RID: 272
		private static readonly MessageParser<AdventureRoomInfo> _parser = new MessageParser<AdventureRoomInfo>(() => new AdventureRoomInfo());

		// Token: 0x04000111 RID: 273
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000112 RID: 274
		public const int RemainMonsterNumFieldNumber = 13;

		// Token: 0x04000113 RID: 275
		private uint remainMonsterNum_;

		// Token: 0x04000114 RID: 276
		public const int ScoreIdFieldNumber = 14;

		// Token: 0x04000115 RID: 277
		private uint scoreId_;

		// Token: 0x04000116 RID: 278
		public const int StatusFieldNumber = 6;

		// Token: 0x04000117 RID: 279
		private RogueAdventureRoomStatus status_;

		// Token: 0x04000118 RID: 280
		public const int CaughtMonsterNumFieldNumber = 3;

		// Token: 0x04000119 RID: 281
		private uint caughtMonsterNum_;

		// Token: 0x0400011A RID: 282
		public const int QueryInfoFieldNumber = 9;

		// Token: 0x0400011B RID: 283
		private RogueAdventureRoomGameplayWolfGunInfo queryInfo_;

		// Token: 0x0400011C RID: 284
		public const int SusFieldNumber = 8;

		// Token: 0x0400011D RID: 285
		private double sus_;
	}
}
