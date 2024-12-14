using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000F7 RID: 247
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BattleRogueMagicInfo : IMessage<BattleRogueMagicInfo>, IMessage, IEquatable<BattleRogueMagicInfo>, IDeepCloneable<BattleRogueMagicInfo>, IBufferMessage
	{
		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00020BDB File Offset: 0x0001EDDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BattleRogueMagicInfo> Parser
		{
			get
			{
				return BattleRogueMagicInfo._parser;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x00020BE2 File Offset: 0x0001EDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BattleRogueMagicInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00020BF4 File Offset: 0x0001EDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattleRogueMagicInfo.Descriptor;
			}
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00020BFB File Offset: 0x0001EDFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicInfo()
		{
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x00020C04 File Offset: 0x0001EE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicInfo(BattleRogueMagicInfo other) : this()
		{
			this.modifierContent_ = ((other.modifierContent_ != null) ? other.modifierContent_.Clone() : null);
			this.detailInfo_ = ((other.detailInfo_ != null) ? other.detailInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x00020C60 File Offset: 0x0001EE60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicInfo Clone()
		{
			return new BattleRogueMagicInfo(this);
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00020C68 File Offset: 0x0001EE68
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00020C70 File Offset: 0x0001EE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicModifierInfo ModifierContent
		{
			get
			{
				return this.modifierContent_;
			}
			set
			{
				this.modifierContent_ = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00020C79 File Offset: 0x0001EE79
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00020C81 File Offset: 0x0001EE81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattleRogueMagicDetailInfo DetailInfo
		{
			get
			{
				return this.detailInfo_;
			}
			set
			{
				this.detailInfo_ = value;
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x00020C8A File Offset: 0x0001EE8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattleRogueMagicInfo);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x00020C98 File Offset: 0x0001EE98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattleRogueMagicInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ModifierContent, other.ModifierContent) && object.Equals(this.DetailInfo, other.DetailInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x00020CEC File Offset: 0x0001EEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.modifierContent_ != null)
			{
				num ^= this.ModifierContent.GetHashCode();
			}
			if (this.detailInfo_ != null)
			{
				num ^= this.DetailInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00020D3E File Offset: 0x0001EF3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000B13 RID: 2835 RVA: 0x00020D46 File Offset: 0x0001EF46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x00020D50 File Offset: 0x0001EF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.modifierContent_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ModifierContent);
			}
			if (this.detailInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.DetailInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000B15 RID: 2837 RVA: 0x00020DAC File Offset: 0x0001EFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.modifierContent_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ModifierContent);
			}
			if (this.detailInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DetailInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000B16 RID: 2838 RVA: 0x00020E04 File Offset: 0x0001F004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattleRogueMagicInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.modifierContent_ != null)
			{
				if (this.modifierContent_ == null)
				{
					this.ModifierContent = new BattleRogueMagicModifierInfo();
				}
				this.ModifierContent.MergeFrom(other.ModifierContent);
			}
			if (other.detailInfo_ != null)
			{
				if (this.detailInfo_ == null)
				{
					this.DetailInfo = new BattleRogueMagicDetailInfo();
				}
				this.DetailInfo.MergeFrom(other.DetailInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000B17 RID: 2839 RVA: 0x00020E84 File Offset: 0x0001F084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000B18 RID: 2840 RVA: 0x00020E90 File Offset: 0x0001F090
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.detailInfo_ == null)
						{
							this.DetailInfo = new BattleRogueMagicDetailInfo();
						}
						input.ReadMessage(this.DetailInfo);
					}
				}
				else
				{
					if (this.modifierContent_ == null)
					{
						this.ModifierContent = new BattleRogueMagicModifierInfo();
					}
					input.ReadMessage(this.ModifierContent);
				}
			}
		}

		// Token: 0x040004A8 RID: 1192
		private static readonly MessageParser<BattleRogueMagicInfo> _parser = new MessageParser<BattleRogueMagicInfo>(() => new BattleRogueMagicInfo());

		// Token: 0x040004A9 RID: 1193
		private UnknownFieldSet _unknownFields;

		// Token: 0x040004AA RID: 1194
		public const int ModifierContentFieldNumber = 1;

		// Token: 0x040004AB RID: 1195
		private BattleRogueMagicModifierInfo modifierContent_;

		// Token: 0x040004AC RID: 1196
		public const int DetailInfoFieldNumber = 2;

		// Token: 0x040004AD RID: 1197
		private BattleRogueMagicDetailInfo detailInfo_;
	}
}
