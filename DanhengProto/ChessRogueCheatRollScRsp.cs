using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001F9 RID: 505
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueCheatRollScRsp : IMessage<ChessRogueCheatRollScRsp>, IMessage, IEquatable<ChessRogueCheatRollScRsp>, IDeepCloneable<ChessRogueCheatRollScRsp>, IBufferMessage
	{
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600167A RID: 5754 RVA: 0x0004097F File Offset: 0x0003EB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueCheatRollScRsp> Parser
		{
			get
			{
				return ChessRogueCheatRollScRsp._parser;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x00040986 File Offset: 0x0003EB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueCheatRollScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x00040998 File Offset: 0x0003EB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueCheatRollScRsp.Descriptor;
			}
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x0004099F File Offset: 0x0003EB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCheatRollScRsp()
		{
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000409A8 File Offset: 0x0003EBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCheatRollScRsp(ChessRogueCheatRollScRsp other) : this()
		{
			this.rogueDiceInfo_ = ((other.rogueDiceInfo_ != null) ? other.rogueDiceInfo_.Clone() : null);
			this.lGEMOEGMGPP_ = other.lGEMOEGMGPP_;
			this.diceSurfaceId_ = other.diceSurfaceId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x00040A0C File Offset: 0x0003EC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueCheatRollScRsp Clone()
		{
			return new ChessRogueCheatRollScRsp(this);
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001680 RID: 5760 RVA: 0x00040A14 File Offset: 0x0003EC14
		// (set) Token: 0x06001681 RID: 5761 RVA: 0x00040A1C File Offset: 0x0003EC1C
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x00040A25 File Offset: 0x0003EC25
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x00040A2D File Offset: 0x0003EC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LGEMOEGMGPP
		{
			get
			{
				return this.lGEMOEGMGPP_;
			}
			set
			{
				this.lGEMOEGMGPP_ = value;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x00040A36 File Offset: 0x0003EC36
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x00040A3E File Offset: 0x0003EC3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DiceSurfaceId
		{
			get
			{
				return this.diceSurfaceId_;
			}
			set
			{
				this.diceSurfaceId_ = value;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x00040A47 File Offset: 0x0003EC47
		// (set) Token: 0x06001687 RID: 5767 RVA: 0x00040A4F File Offset: 0x0003EC4F
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

		// Token: 0x06001688 RID: 5768 RVA: 0x00040A58 File Offset: 0x0003EC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueCheatRollScRsp);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00040A68 File Offset: 0x0003EC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueCheatRollScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RogueDiceInfo, other.RogueDiceInfo) && this.LGEMOEGMGPP == other.LGEMOEGMGPP && this.DiceSurfaceId == other.DiceSurfaceId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00040AD8 File Offset: 0x0003ECD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueDiceInfo_ != null)
			{
				num ^= this.RogueDiceInfo.GetHashCode();
			}
			if (this.LGEMOEGMGPP != 0U)
			{
				num ^= this.LGEMOEGMGPP.GetHashCode();
			}
			if (this.DiceSurfaceId != 0U)
			{
				num ^= this.DiceSurfaceId.GetHashCode();
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

		// Token: 0x0600168B RID: 5771 RVA: 0x00040B5F File Offset: 0x0003ED5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00040B67 File Offset: 0x0003ED67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x00040B70 File Offset: 0x0003ED70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.DiceSurfaceId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DiceSurfaceId);
			}
			if (this.LGEMOEGMGPP != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.LGEMOEGMGPP);
			}
			if (this.rogueDiceInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueDiceInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00040C04 File Offset: 0x0003EE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueDiceInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueDiceInfo);
			}
			if (this.LGEMOEGMGPP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LGEMOEGMGPP);
			}
			if (this.DiceSurfaceId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DiceSurfaceId);
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

		// Token: 0x0600168F RID: 5775 RVA: 0x00040C8C File Offset: 0x0003EE8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueCheatRollScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueDiceInfo_ != null)
			{
				if (this.rogueDiceInfo_ == null)
				{
					this.RogueDiceInfo = new ChessRogueDiceInfo();
				}
				this.RogueDiceInfo.MergeFrom(other.RogueDiceInfo);
			}
			if (other.LGEMOEGMGPP != 0U)
			{
				this.LGEMOEGMGPP = other.LGEMOEGMGPP;
			}
			if (other.DiceSurfaceId != 0U)
			{
				this.DiceSurfaceId = other.DiceSurfaceId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x00040D1C File Offset: 0x0003EF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00040D28 File Offset: 0x0003EF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.DiceSurfaceId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.LGEMOEGMGPP = input.ReadUInt32();
						continue;
					}
					if (num == 114U)
					{
						if (this.rogueDiceInfo_ == null)
						{
							this.RogueDiceInfo = new ChessRogueDiceInfo();
						}
						input.ReadMessage(this.RogueDiceInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000984 RID: 2436
		private static readonly MessageParser<ChessRogueCheatRollScRsp> _parser = new MessageParser<ChessRogueCheatRollScRsp>(() => new ChessRogueCheatRollScRsp());

		// Token: 0x04000985 RID: 2437
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000986 RID: 2438
		public const int RogueDiceInfoFieldNumber = 14;

		// Token: 0x04000987 RID: 2439
		private ChessRogueDiceInfo rogueDiceInfo_;

		// Token: 0x04000988 RID: 2440
		public const int LGEMOEGMGPPFieldNumber = 13;

		// Token: 0x04000989 RID: 2441
		private uint lGEMOEGMGPP_;

		// Token: 0x0400098A RID: 2442
		public const int DiceSurfaceIdFieldNumber = 6;

		// Token: 0x0400098B RID: 2443
		private uint diceSurfaceId_;

		// Token: 0x0400098C RID: 2444
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400098D RID: 2445
		private uint retcode_;
	}
}
