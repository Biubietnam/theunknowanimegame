using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000227 RID: 551
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueGiveUpRollScRsp : IMessage<ChessRogueGiveUpRollScRsp>, IMessage, IEquatable<ChessRogueGiveUpRollScRsp>, IDeepCloneable<ChessRogueGiveUpRollScRsp>, IBufferMessage
	{
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0004828B File Offset: 0x0004648B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueGiveUpRollScRsp> Parser
		{
			get
			{
				return ChessRogueGiveUpRollScRsp._parser;
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x00048292 File Offset: 0x00046492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueGiveUpRollScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060018C7 RID: 6343 RVA: 0x000482A4 File Offset: 0x000464A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueGiveUpRollScRsp.Descriptor;
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x000482AB File Offset: 0x000464AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpRollScRsp()
		{
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x000482B4 File Offset: 0x000464B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpRollScRsp(ChessRogueGiveUpRollScRsp other) : this()
		{
			this.aAPJLBGNFLG_ = ((other.aAPJLBGNFLG_ != null) ? other.aAPJLBGNFLG_.Clone() : null);
			this.rogueDiceInfo_ = ((other.rogueDiceInfo_ != null) ? other.rogueDiceInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0004831C File Offset: 0x0004651C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueGiveUpRollScRsp Clone()
		{
			return new ChessRogueGiveUpRollScRsp(this);
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00048324 File Offset: 0x00046524
		// (set) Token: 0x060018CC RID: 6348 RVA: 0x0004832C File Offset: 0x0004652C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList AAPJLBGNFLG
		{
			get
			{
				return this.aAPJLBGNFLG_;
			}
			set
			{
				this.aAPJLBGNFLG_ = value;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00048335 File Offset: 0x00046535
		// (set) Token: 0x060018CE RID: 6350 RVA: 0x0004833D File Offset: 0x0004653D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueDiceInfo RogueDiceInfo
		{
			get
			{
				return this.rogueDiceInfo_;
			}
			set
			{
				this.rogueDiceInfo_ = value;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x00048346 File Offset: 0x00046546
		// (set) Token: 0x060018D0 RID: 6352 RVA: 0x0004834E File Offset: 0x0004654E
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

		// Token: 0x060018D1 RID: 6353 RVA: 0x00048357 File Offset: 0x00046557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueGiveUpRollScRsp);
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00048368 File Offset: 0x00046568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueGiveUpRollScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.AAPJLBGNFLG, other.AAPJLBGNFLG) && object.Equals(this.RogueDiceInfo, other.RogueDiceInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000483CC File Offset: 0x000465CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aAPJLBGNFLG_ != null)
			{
				num ^= this.AAPJLBGNFLG.GetHashCode();
			}
			if (this.rogueDiceInfo_ != null)
			{
				num ^= this.RogueDiceInfo.GetHashCode();
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

		// Token: 0x060018D4 RID: 6356 RVA: 0x00048437 File Offset: 0x00046637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0004843F File Offset: 0x0004663F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00048448 File Offset: 0x00046648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueDiceInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueDiceInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.aAPJLBGNFLG_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.AAPJLBGNFLG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x000484C0 File Offset: 0x000466C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aAPJLBGNFLG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AAPJLBGNFLG);
			}
			if (this.rogueDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDiceInfo);
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

		// Token: 0x060018D8 RID: 6360 RVA: 0x00048530 File Offset: 0x00046730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueGiveUpRollScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aAPJLBGNFLG_ != null)
			{
				if (this.aAPJLBGNFLG_ == null)
				{
					this.AAPJLBGNFLG = new ItemList();
				}
				this.AAPJLBGNFLG.MergeFrom(other.AAPJLBGNFLG);
			}
			if (other.rogueDiceInfo_ != null)
			{
				if (this.rogueDiceInfo_ == null)
				{
					this.RogueDiceInfo = new ChessRogueDiceInfo();
				}
				this.RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000485C4 File Offset: 0x000467C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x000485D0 File Offset: 0x000467D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 80U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.aAPJLBGNFLG_ == null)
							{
								this.AAPJLBGNFLG = new ItemList();
							}
							input.ReadMessage(this.AAPJLBGNFLG);
						}
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.rogueDiceInfo_ == null)
					{
						this.RogueDiceInfo = new ChessRogueDiceInfo();
					}
					input.ReadMessage(this.RogueDiceInfo);
				}
			}
		}

		// Token: 0x04000A95 RID: 2709
		private static readonly MessageParser<ChessRogueGiveUpRollScRsp> _parser = new MessageParser<ChessRogueGiveUpRollScRsp>(() => new ChessRogueGiveUpRollScRsp());

		// Token: 0x04000A96 RID: 2710
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A97 RID: 2711
		public const int AAPJLBGNFLGFieldNumber = 11;

		// Token: 0x04000A98 RID: 2712
		private ItemList aAPJLBGNFLG_;

		// Token: 0x04000A99 RID: 2713
		public const int RogueDiceInfoFieldNumber = 2;

		// Token: 0x04000A9A RID: 2714
		private ChessRogueDiceInfo rogueDiceInfo_;

		// Token: 0x04000A9B RID: 2715
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04000A9C RID: 2716
		private uint retcode_;
	}
}
