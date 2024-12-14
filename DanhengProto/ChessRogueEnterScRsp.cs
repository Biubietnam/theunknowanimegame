using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000217 RID: 535
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueEnterScRsp : IMessage<ChessRogueEnterScRsp>, IMessage, IEquatable<ChessRogueEnterScRsp>, IDeepCloneable<ChessRogueEnterScRsp>, IBufferMessage
	{
		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0004481F File Offset: 0x00042A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueEnterScRsp> Parser
		{
			get
			{
				return ChessRogueEnterScRsp._parser;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00044826 File Offset: 0x00042A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueEnterScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060017D1 RID: 6097 RVA: 0x00044838 File Offset: 0x00042A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueEnterScRsp.Descriptor;
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0004483F File Offset: 0x00042A3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterScRsp()
		{
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00044848 File Offset: 0x00042A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterScRsp(ChessRogueEnterScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.id_ = other.id_;
			this.stageInfo_ = ((other.stageInfo_ != null) ? other.stageInfo_.Clone() : null);
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x000448D8 File Offset: 0x00042AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueEnterScRsp Clone()
		{
			return new ChessRogueEnterScRsp(this);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060017D5 RID: 6101 RVA: 0x000448E0 File Offset: 0x00042AE0
		// (set) Token: 0x060017D6 RID: 6102 RVA: 0x000448E8 File Offset: 0x00042AE8
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

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060017D7 RID: 6103 RVA: 0x000448F1 File Offset: 0x00042AF1
		// (set) Token: 0x060017D8 RID: 6104 RVA: 0x000448F9 File Offset: 0x00042AF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x00044902 File Offset: 0x00042B02
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x0004490A File Offset: 0x00042B0A
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

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00044913 File Offset: 0x00042B13
		// (set) Token: 0x060017DC RID: 6108 RVA: 0x0004491B File Offset: 0x00042B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCurrentInfo RogueCurrentInfo
		{
			get
			{
				return this.rogueCurrentInfo_;
			}
			set
			{
				this.rogueCurrentInfo_ = value;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00044924 File Offset: 0x00042B24
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x0004492C File Offset: 0x00042B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGameInfo Info
		{
			get
			{
				return this.info_;
			}
			set
			{
				this.info_ = value;
			}
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00044935 File Offset: 0x00042B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueEnterScRsp);
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00044944 File Offset: 0x00042B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueEnterScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.Id == other.Id && object.Equals(this.StageInfo, other.StageInfo) && object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && object.Equals(this.Info, other.Info) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017E1 RID: 6113 RVA: 0x000449CC File Offset: 0x00042BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.stageInfo_ != null)
			{
				num ^= this.StageInfo.GetHashCode();
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num ^= this.RogueCurrentInfo.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x00044A66 File Offset: 0x00042C66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x00044A6E File Offset: 0x00042C6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00044A78 File Offset: 0x00042C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			if (this.stageInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.StageInfo);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RogueCurrentInfo);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Id);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Info);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00044B24 File Offset: 0x00042D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.stageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StageInfo);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueCurrentInfo);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017E6 RID: 6118 RVA: 0x00044BC4 File Offset: 0x00042DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueEnterScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.stageInfo_ != null)
			{
				if (this.stageInfo_ == null)
				{
					this.StageInfo = new ChessRogueInfo();
				}
				this.StageInfo.MergeFrom(other.StageInfo);
			}
			if (other.rogueCurrentInfo_ != null)
			{
				if (this.rogueCurrentInfo_ == null)
				{
					this.RogueCurrentInfo = new ChessRogueCurrentInfo();
				}
				this.RogueCurrentInfo.MergeFrom(other.RogueCurrentInfo);
			}
			if (other.info_ != null)
			{
				if (this.info_ == null)
				{
					this.Info = new ChessRogueGameInfo();
				}
				this.Info.MergeFrom(other.Info);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017E7 RID: 6119 RVA: 0x00044C98 File Offset: 0x00042E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017E8 RID: 6120 RVA: 0x00044CA4 File Offset: 0x00042EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						if (this.stageInfo_ == null)
						{
							this.StageInfo = new ChessRogueInfo();
						}
						input.ReadMessage(this.StageInfo);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.rogueCurrentInfo_ == null)
						{
							this.RogueCurrentInfo = new ChessRogueCurrentInfo();
						}
						input.ReadMessage(this.RogueCurrentInfo);
						continue;
					}
					if (num == 96U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.info_ == null)
						{
							this.Info = new ChessRogueGameInfo();
						}
						input.ReadMessage(this.Info);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000A17 RID: 2583
		private static readonly MessageParser<ChessRogueEnterScRsp> _parser = new MessageParser<ChessRogueEnterScRsp>(() => new ChessRogueEnterScRsp());

		// Token: 0x04000A18 RID: 2584
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A19 RID: 2585
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04000A1A RID: 2586
		private uint retcode_;

		// Token: 0x04000A1B RID: 2587
		public const int IdFieldNumber = 12;

		// Token: 0x04000A1C RID: 2588
		private uint id_;

		// Token: 0x04000A1D RID: 2589
		public const int StageInfoFieldNumber = 3;

		// Token: 0x04000A1E RID: 2590
		private ChessRogueInfo stageInfo_;

		// Token: 0x04000A1F RID: 2591
		public const int RogueCurrentInfoFieldNumber = 4;

		// Token: 0x04000A20 RID: 2592
		private ChessRogueCurrentInfo rogueCurrentInfo_;

		// Token: 0x04000A21 RID: 2593
		public const int InfoFieldNumber = 15;

		// Token: 0x04000A22 RID: 2594
		private ChessRogueGameInfo info_;
	}
}
