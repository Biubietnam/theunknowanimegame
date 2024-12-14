using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200027D RID: 637
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueQueryScRsp : IMessage<ChessRogueQueryScRsp>, IMessage, IEquatable<ChessRogueQueryScRsp>, IDeepCloneable<ChessRogueQueryScRsp>, IBufferMessage
	{
		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00051766 File Offset: 0x0004F966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueQueryScRsp> Parser
		{
			get
			{
				return ChessRogueQueryScRsp._parser;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0005176D File Offset: 0x0004F96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueQueryScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001C67 RID: 7271 RVA: 0x0005177F File Offset: 0x0004F97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueQueryScRsp.Descriptor;
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00051786 File Offset: 0x0004F986
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryScRsp()
		{
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x00051790 File Offset: 0x0004F990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryScRsp(ChessRogueQueryScRsp other) : this()
		{
			this.rogueGetInfo_ = ((other.rogueGetInfo_ != null) ? other.rogueGetInfo_.Clone() : null);
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this.info_ = ((other.info_ != null) ? other.info_.Clone() : null);
			this.finishInfo_ = ((other.finishInfo_ != null) ? other.finishInfo_.Clone() : null);
			this.queryInfo_ = ((other.queryInfo_ != null) ? other.queryInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0005184C File Offset: 0x0004FA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueQueryScRsp Clone()
		{
			return new ChessRogueQueryScRsp(this);
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x00051854 File Offset: 0x0004FA54
		// (set) Token: 0x06001C6C RID: 7276 RVA: 0x0005185C File Offset: 0x0004FA5C
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

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x00051865 File Offset: 0x0004FA65
		// (set) Token: 0x06001C6E RID: 7278 RVA: 0x0005186D File Offset: 0x0004FA6D
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

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001C6F RID: 7279 RVA: 0x00051876 File Offset: 0x0004FA76
		// (set) Token: 0x06001C70 RID: 7280 RVA: 0x0005187E File Offset: 0x0004FA7E
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

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001C71 RID: 7281 RVA: 0x00051887 File Offset: 0x0004FA87
		// (set) Token: 0x06001C72 RID: 7282 RVA: 0x0005188F File Offset: 0x0004FA8F
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

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001C73 RID: 7283 RVA: 0x00051898 File Offset: 0x0004FA98
		// (set) Token: 0x06001C74 RID: 7284 RVA: 0x000518A0 File Offset: 0x0004FAA0
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

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001C75 RID: 7285 RVA: 0x000518A9 File Offset: 0x0004FAA9
		// (set) Token: 0x06001C76 RID: 7286 RVA: 0x000518B1 File Offset: 0x0004FAB1
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

		// Token: 0x06001C77 RID: 7287 RVA: 0x000518BA File Offset: 0x0004FABA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueQueryScRsp);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x000518C8 File Offset: 0x0004FAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueQueryScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueGetInfo, other.RogueGetInfo) && object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && object.Equals(this.Info, other.Info) && object.Equals(this.FinishInfo, other.FinishInfo) && object.Equals(this.QueryInfo, other.QueryInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0005196C File Offset: 0x0004FB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueGetInfo_ != null)
			{
				num ^= this.RogueGetInfo.GetHashCode();
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num ^= this.RogueCurrentInfo.GetHashCode();
			}
			if (this.info_ != null)
			{
				num ^= this.Info.GetHashCode();
			}
			if (this.finishInfo_ != null)
			{
				num ^= this.FinishInfo.GetHashCode();
			}
			if (this.queryInfo_ != null)
			{
				num ^= this.QueryInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x00051A19 File Offset: 0x0004FC19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00051A21 File Offset: 0x0004FC21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00051A2C File Offset: 0x0004FC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.queryInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.QueryInfo);
			}
			if (this.finishInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.FinishInfo);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RogueCurrentInfo);
			}
			if (this.rogueGetInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RogueGetInfo);
			}
			if (this.info_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Info);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x00051AF8 File Offset: 0x0004FCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueGetInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGetInfo);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueCurrentInfo);
			}
			if (this.info_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Info);
			}
			if (this.finishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FinishInfo);
			}
			if (this.queryInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.QueryInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00051BB0 File Offset: 0x0004FDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueQueryScRsp other)
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
			if (other.finishInfo_ != null)
			{
				if (this.finishInfo_ == null)
				{
					this.FinishInfo = new ChessRogueFinishInfo();
				}
				this.FinishInfo.MergeFrom(other.FinishInfo);
			}
			if (other.queryInfo_ != null)
			{
				if (this.queryInfo_ == null)
				{
					this.QueryInfo = new ChessRogueQueryInfo();
				}
				this.QueryInfo.MergeFrom(other.QueryInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00051CC8 File Offset: 0x0004FEC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00051CD4 File Offset: 0x0004FED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 10U)
					{
						if (this.queryInfo_ == null)
						{
							this.QueryInfo = new ChessRogueQueryInfo();
						}
						input.ReadMessage(this.QueryInfo);
						continue;
					}
					if (num == 58U)
					{
						if (this.finishInfo_ == null)
						{
							this.FinishInfo = new ChessRogueFinishInfo();
						}
						input.ReadMessage(this.FinishInfo);
						continue;
					}
					if (num == 74U)
					{
						if (this.rogueCurrentInfo_ == null)
						{
							this.RogueCurrentInfo = new ChessRogueCurrentInfo();
						}
						input.ReadMessage(this.RogueCurrentInfo);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.rogueGetInfo_ == null)
						{
							this.RogueGetInfo = new ChessRogueGetInfo();
						}
						input.ReadMessage(this.RogueGetInfo);
						continue;
					}
					if (num == 98U)
					{
						if (this.info_ == null)
						{
							this.Info = new ChessRogueGameInfo();
						}
						input.ReadMessage(this.Info);
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000BE2 RID: 3042
		private static readonly MessageParser<ChessRogueQueryScRsp> _parser = new MessageParser<ChessRogueQueryScRsp>(() => new ChessRogueQueryScRsp());

		// Token: 0x04000BE3 RID: 3043
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000BE4 RID: 3044
		public const int RogueGetInfoFieldNumber = 11;

		// Token: 0x04000BE5 RID: 3045
		private ChessRogueGetInfo rogueGetInfo_;

		// Token: 0x04000BE6 RID: 3046
		public const int RogueCurrentInfoFieldNumber = 9;

		// Token: 0x04000BE7 RID: 3047
		private ChessRogueCurrentInfo rogueCurrentInfo_;

		// Token: 0x04000BE8 RID: 3048
		public const int InfoFieldNumber = 12;

		// Token: 0x04000BE9 RID: 3049
		private ChessRogueGameInfo info_;

		// Token: 0x04000BEA RID: 3050
		public const int FinishInfoFieldNumber = 7;

		// Token: 0x04000BEB RID: 3051
		private ChessRogueFinishInfo finishInfo_;

		// Token: 0x04000BEC RID: 3052
		public const int QueryInfoFieldNumber = 1;

		// Token: 0x04000BED RID: 3053
		private ChessRogueQueryInfo queryInfo_;

		// Token: 0x04000BEE RID: 3054
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04000BEF RID: 3055
		private uint retcode_;
	}
}
