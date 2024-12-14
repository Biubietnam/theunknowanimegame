using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000229 RID: 553
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGiveUpScRsp : IMessage<ChessRogueGiveUpScRsp>, IMessage, IEquatable<ChessRogueGiveUpScRsp>, IDeepCloneable<ChessRogueGiveUpScRsp>, IBufferMessage
	{
		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x0004878E File Offset: 0x0004698E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGiveUpScRsp> Parser
		{
			get
			{
				return ChessRogueGiveUpScRsp._parser;
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060018DF RID: 6367 RVA: 0x00048795 File Offset: 0x00046995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGiveUpScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x000487A7 File Offset: 0x000469A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGiveUpScRsp.Descriptor;
			}
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x000487AE File Offset: 0x000469AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpScRsp()
		{
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x000487B8 File Offset: 0x000469B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpScRsp(ChessRogueGiveUpScRsp other) : this()
		{
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.rogueAeonInfo_ = ((other.rogueAeonInfo_ != null) ? other.rogueAeonInfo_.Clone() : null);
			this.queryInfo_ = ((other.queryInfo_ != null) ? other.queryInfo_.Clone() : null);
			this.finishInfo_ = ((other.finishInfo_ != null) ? other.finishInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x00048874 File Offset: 0x00046A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpScRsp Clone()
		{
			return new ChessRogueGiveUpScRsp(this);
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x0004887C File Offset: 0x00046A7C
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00048884 File Offset: 0x00046A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGetInfo RogueGetInfo
		{
			get
			{
				return this.rogueGetInfo_;
			}
			set
			{
				this.rogueGetInfo_ = value;
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060018E6 RID: 6374 RVA: 0x0004888D File Offset: 0x00046A8D
		// (set) Token: 0x060018E7 RID: 6375 RVA: 0x00048895 File Offset: 0x00046A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x0004889E File Offset: 0x00046A9E
		// (set) Token: 0x060018E9 RID: 6377 RVA: 0x000488A6 File Offset: 0x00046AA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueInfo StageInfo
		{
			get
			{
				return this.stageInfo_;
			}
			set
			{
				this.stageInfo_ = value;
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060018EA RID: 6378 RVA: 0x000488AF File Offset: 0x00046AAF
		// (set) Token: 0x060018EB RID: 6379 RVA: 0x000488B7 File Offset: 0x00046AB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueAeonInfo RogueAeonInfo
		{
			get
			{
				return this.rogueAeonInfo_;
			}
			set
			{
				this.rogueAeonInfo_ = value;
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x000488C0 File Offset: 0x00046AC0
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x000488C8 File Offset: 0x00046AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryInfo QueryInfo
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

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x000488D1 File Offset: 0x00046AD1
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x000488D9 File Offset: 0x00046AD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishInfo FinishInfo
		{
			get
			{
				return this.finishInfo_;
			}
			set
			{
				this.finishInfo_ = value;
			}
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x000488E2 File Offset: 0x00046AE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGiveUpScRsp);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x000488F0 File Offset: 0x00046AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGiveUpScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueGetInfo, other.RogueGetInfo) && this.Retcode == other.Retcode && object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this.RogueAeonInfo, other.RogueAeonInfo) && object.Equals(this.QueryInfo, other.QueryInfo) && object.Equals(this.FinishInfo, other.FinishInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x00048994 File Offset: 0x00046B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.rogueAeonInfo_ != null)
			{
				num ^= this.RogueAeonInfo.GetHashCode();
			}
			if (this.queryInfo_ != null)
			{
				num ^= this.QueryInfo.GetHashCode();
			}
			if (this.finishInfo_ != null)
			{
				num ^= this.FinishInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00048A41 File Offset: 0x00046C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00048A49 File Offset: 0x00046C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00048A54 File Offset: 0x00046C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.queryInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.QueryInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.RogueAeonInfo);
			}
			if (this.finishInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.FinishInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.StageInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00048B20 File Offset: 0x00046D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueGetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.rogueAeonInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueAeonInfo);
			}
			if (this.queryInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryInfo);
			}
			if (this.finishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FinishInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00048BD8 File Offset: 0x00046DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGiveUpScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueGetInfo_ != null)
			{
				if (this.rogueGetInfo_ == null)
				{
					this.RogueGetInfo = new ChessRogueGetInfo();
				}
				this.RogueGetInfo.MergeFrom(other.RogueGetInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChessRogueInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.rogueAeonInfo_ != null)
			{
				if (this.rogueAeonInfo_ == null)
				{
					this.RogueAeonInfo = new ChessRogueAeonInfo();
				}
				this.RogueAeonInfo.MergeFrom(other.RogueAeonInfo);
			}
			if (other.queryInfo_ != null)
			{
				if (this.queryInfo_ == null)
				{
					this.QueryInfo = new ChessRogueQueryInfo();
				}
				this.QueryInfo.MergeFrom(other.QueryInfo);
			}
			if (other.finishInfo_ != null)
			{
				if (this.finishInfo_ == null)
				{
					this.FinishInfo = new ChessRogueFinishInfo();
				}
				this.FinishInfo.MergeFrom(other.FinishInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00048CF0 File Offset: 0x00046EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00048CFC File Offset: 0x00046EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 90U)
				{
					if (num == 26U)
					{
						if (this.queryInfo_ == null)
						{
							this.QueryInfo = new ChessRogueQueryInfo();
						}
						input.ReadMessage(this.QueryInfo);
						continue;
					}
					if (num == 82U)
					{
						if (this.rogueAeonInfo_ == null)
						{
							this.RogueAeonInfo = new ChessRogueAeonInfo();
						}
						input.ReadMessage(this.RogueAeonInfo);
						continue;
					}
					if (num == 90U)
					{
						if (this.finishInfo_ == null)
						{
							this.FinishInfo = new ChessRogueFinishInfo();
						}
						input.ReadMessage(this.FinishInfo);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChessRogueInfo();
						}
						input.ReadMessage(this.StageInfo);
						continue;
					}
					if (num == 122U)
					{
						if (this.rogueGetInfo_ == null)
						{
							this.RogueGetInfo = new ChessRogueGetInfo();
						}
						input.ReadMessage(this.RogueGetInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A9E RID: 2718
		private static readonly MessageParser<ChessRogueGiveUpScRsp> _parser = new MessageParser<ChessRogueGiveUpScRsp>(() => new ChessRogueGiveUpScRsp());

		// Token: 0x04000A9F RID: 2719
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000AA0 RID: 2720
		public const int RogueGetInfoFieldNumber = 15;

		// Token: 0x04000AA1 RID: 2721
		private ChessRogueGetInfo rogueGetInfo_;

		// Token: 0x04000AA2 RID: 2722
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04000AA3 RID: 2723
		private uint retcode_;

		// Token: 0x04000AA4 RID: 2724
		public const int StageInfoFieldNumber = 14;

		// Token: 0x04000AA5 RID: 2725
		private ChessRogueInfo stageInfo_;

		// Token: 0x04000AA6 RID: 2726
		public const int RogueAeonInfoFieldNumber = 10;

		// Token: 0x04000AA7 RID: 2727
		private ChessRogueAeonInfo rogueAeonInfo_;

		// Token: 0x04000AA8 RID: 2728
		public const int QueryInfoFieldNumber = 3;

		// Token: 0x04000AA9 RID: 2729
		private ChessRogueQueryInfo queryInfo_;

		// Token: 0x04000AAA RID: 2730
		public const int FinishInfoFieldNumber = 11;

		// Token: 0x04000AAB RID: 2731
		private ChessRogueFinishInfo finishInfo_;
	}
}
