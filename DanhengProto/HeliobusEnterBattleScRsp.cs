using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008BD RID: 2237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusEnterBattleScRsp : IMessage<HeliobusEnterBattleScRsp>, IMessage, IEquatable<HeliobusEnterBattleScRsp>, IDeepCloneable<HeliobusEnterBattleScRsp>, IBufferMessage
	{
		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x060063B9 RID: 25529 RVA: 0x0010B2AF File Offset: 0x001094AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusEnterBattleScRsp> Parser
		{
			get
			{
				return HeliobusEnterBattleScRsp._parser;
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x060063BA RID: 25530 RVA: 0x0010B2B6 File Offset: 0x001094B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusEnterBattleScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x060063BB RID: 25531 RVA: 0x0010B2C8 File Offset: 0x001094C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusEnterBattleScRsp.Descriptor;
			}
		}

		// Token: 0x060063BC RID: 25532 RVA: 0x0010B2CF File Offset: 0x001094CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusEnterBattleScRsp()
		{
		}

		// Token: 0x060063BD RID: 25533 RVA: 0x0010B2D8 File Offset: 0x001094D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusEnterBattleScRsp(HeliobusEnterBattleScRsp other) : this()
		{
			this.battleInfo_ = ((other.battleInfo_ != null) ? other.battleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063BE RID: 25534 RVA: 0x0010B330 File Offset: 0x00109530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusEnterBattleScRsp Clone()
		{
			return new HeliobusEnterBattleScRsp(this);
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x060063BF RID: 25535 RVA: 0x0010B338 File Offset: 0x00109538
		// (set) Token: 0x060063C0 RID: 25536 RVA: 0x0010B340 File Offset: 0x00109540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneBattleInfo BattleInfo
		{
			get
			{
				return this.battleInfo_;
			}
			set
			{
				this.battleInfo_ = value;
			}
		}

		// Token: 0x17001C1D RID: 7197
		// (get) Token: 0x060063C1 RID: 25537 RVA: 0x0010B349 File Offset: 0x00109549
		// (set) Token: 0x060063C2 RID: 25538 RVA: 0x0010B351 File Offset: 0x00109551
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

		// Token: 0x17001C1E RID: 7198
		// (get) Token: 0x060063C3 RID: 25539 RVA: 0x0010B35A File Offset: 0x0010955A
		// (set) Token: 0x060063C4 RID: 25540 RVA: 0x0010B362 File Offset: 0x00109562
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x060063C5 RID: 25541 RVA: 0x0010B36B File Offset: 0x0010956B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusEnterBattleScRsp);
		}

		// Token: 0x060063C6 RID: 25542 RVA: 0x0010B37C File Offset: 0x0010957C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusEnterBattleScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.BattleInfo, other.BattleInfo) && this.Retcode == other.Retcode && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063C7 RID: 25543 RVA: 0x0010B3DC File Offset: 0x001095DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battleInfo_ != null)
			{
				num ^= this.BattleInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060063C8 RID: 25544 RVA: 0x0010B44A File Offset: 0x0010964A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060063C9 RID: 25545 RVA: 0x0010B452 File Offset: 0x00109652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063CA RID: 25546 RVA: 0x0010B45C File Offset: 0x0010965C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.battleInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EventId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060063CB RID: 25547 RVA: 0x0010B4D4 File Offset: 0x001096D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattleInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060063CC RID: 25548 RVA: 0x0010B544 File Offset: 0x00109744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusEnterBattleScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battleInfo_ != null)
			{
				if (this.battleInfo_ == null)
				{
					this.BattleInfo = new SceneBattleInfo();
				}
				this.BattleInfo.MergeFrom(other.BattleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x0010B5C0 File Offset: 0x001097C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x0010B5CC File Offset: 0x001097CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					if (num != 80U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EventId = input.ReadUInt32();
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.battleInfo_ == null)
					{
						this.BattleInfo = new SceneBattleInfo();
					}
					input.ReadMessage(this.BattleInfo);
				}
			}
		}

		// Token: 0x04002674 RID: 9844
		private static readonly MessageParser<HeliobusEnterBattleScRsp> _parser = new MessageParser<HeliobusEnterBattleScRsp>(() => new HeliobusEnterBattleScRsp());

		// Token: 0x04002675 RID: 9845
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002676 RID: 9846
		public const int BattleInfoFieldNumber = 6;

		// Token: 0x04002677 RID: 9847
		private SceneBattleInfo battleInfo_;

		// Token: 0x04002678 RID: 9848
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002679 RID: 9849
		private uint retcode_;

		// Token: 0x0400267A RID: 9850
		public const int EventIdFieldNumber = 12;

		// Token: 0x0400267B RID: 9851
		private uint eventId_;
	}
}
