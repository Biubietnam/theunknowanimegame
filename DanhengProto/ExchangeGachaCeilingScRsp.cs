using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004D5 RID: 1237
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ExchangeGachaCeilingScRsp : IMessage<ExchangeGachaCeilingScRsp>, IMessage, IEquatable<ExchangeGachaCeilingScRsp>, IDeepCloneable<ExchangeGachaCeilingScRsp>, IBufferMessage
	{
		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x00097C7F File Offset: 0x00095E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ExchangeGachaCeilingScRsp> Parser
		{
			get
			{
				return ExchangeGachaCeilingScRsp._parser;
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x0600374E RID: 14158 RVA: 0x00097C86 File Offset: 0x00095E86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ExchangeGachaCeilingScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FC7 RID: 4039
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x00097C98 File Offset: 0x00095E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExchangeGachaCeilingScRsp.Descriptor;
			}
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00097C9F File Offset: 0x00095E9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeGachaCeilingScRsp()
		{
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x00097CA8 File Offset: 0x00095EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeGachaCeilingScRsp(ExchangeGachaCeilingScRsp other) : this()
		{
			this.gachaCeiling_ = ((other.gachaCeiling_ != null) ? other.gachaCeiling_.Clone() : null);
			this.avatarId_ = other.avatarId_;
			this.retcode_ = other.retcode_;
			this.transferItemList_ = ((other.transferItemList_ != null) ? other.transferItemList_.Clone() : null);
			this.gachaType_ = other.gachaType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x00097D28 File Offset: 0x00095F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExchangeGachaCeilingScRsp Clone()
		{
			return new ExchangeGachaCeilingScRsp(this);
		}

		// Token: 0x17000FC8 RID: 4040
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x00097D30 File Offset: 0x00095F30
		// (set) Token: 0x06003754 RID: 14164 RVA: 0x00097D38 File Offset: 0x00095F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaCeiling GachaCeiling
		{
			get
			{
				return this.gachaCeiling_;
			}
			set
			{
				this.gachaCeiling_ = value;
			}
		}

		// Token: 0x17000FC9 RID: 4041
		// (get) Token: 0x06003755 RID: 14165 RVA: 0x00097D41 File Offset: 0x00095F41
		// (set) Token: 0x06003756 RID: 14166 RVA: 0x00097D49 File Offset: 0x00095F49
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

		// Token: 0x17000FCA RID: 4042
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x00097D52 File Offset: 0x00095F52
		// (set) Token: 0x06003758 RID: 14168 RVA: 0x00097D5A File Offset: 0x00095F5A
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

		// Token: 0x17000FCB RID: 4043
		// (get) Token: 0x06003759 RID: 14169 RVA: 0x00097D63 File Offset: 0x00095F63
		// (set) Token: 0x0600375A RID: 14170 RVA: 0x00097D6B File Offset: 0x00095F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList TransferItemList
		{
			get
			{
				return this.transferItemList_;
			}
			set
			{
				this.transferItemList_ = value;
			}
		}

		// Token: 0x17000FCC RID: 4044
		// (get) Token: 0x0600375B RID: 14171 RVA: 0x00097D74 File Offset: 0x00095F74
		// (set) Token: 0x0600375C RID: 14172 RVA: 0x00097D7C File Offset: 0x00095F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GachaType
		{
			get
			{
				return this.gachaType_;
			}
			set
			{
				this.gachaType_ = value;
			}
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x00097D85 File Offset: 0x00095F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExchangeGachaCeilingScRsp);
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x00097D94 File Offset: 0x00095F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExchangeGachaCeilingScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GachaCeiling, other.GachaCeiling) && this.AvatarId == other.AvatarId && this.Retcode == other.Retcode && object.Equals(this.TransferItemList, other.TransferItemList) && this.GachaType == other.GachaType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x00097E18 File Offset: 0x00096018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gachaCeiling_ != null)
			{
				num ^= this.GachaCeiling.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.transferItemList_ != null)
			{
				num ^= this.TransferItemList.GetHashCode();
			}
			if (this.GachaType != 0U)
			{
				num ^= this.GachaType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x00097EB5 File Offset: 0x000960B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x00097EBD File Offset: 0x000960BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00097EC8 File Offset: 0x000960C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.transferItemList_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TransferItemList);
			}
			if (this.gachaCeiling_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.GachaCeiling);
			}
			if (this.GachaType != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GachaType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x00097F78 File Offset: 0x00096178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gachaCeiling_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GachaCeiling);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.transferItemList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransferItemList);
			}
			if (this.GachaType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GachaType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x00098018 File Offset: 0x00096218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExchangeGachaCeilingScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gachaCeiling_ != null)
			{
				if (this.gachaCeiling_ == null)
				{
					this.GachaCeiling = new GachaCeiling();
				}
				this.GachaCeiling.MergeFrom(other.GachaCeiling);
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.transferItemList_ != null)
			{
				if (this.transferItemList_ == null)
				{
					this.TransferItemList = new ItemList();
				}
				this.TransferItemList.MergeFrom(other.TransferItemList);
			}
			if (other.GachaType != 0U)
			{
				this.GachaType = other.GachaType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x000980D4 File Offset: 0x000962D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x000980E0 File Offset: 0x000962E0
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
						this.AvatarId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						if (this.transferItemList_ == null)
						{
							this.TransferItemList = new ItemList();
						}
						input.ReadMessage(this.TransferItemList);
						continue;
					}
					if (num == 106U)
					{
						if (this.gachaCeiling_ == null)
						{
							this.GachaCeiling = new GachaCeiling();
						}
						input.ReadMessage(this.GachaCeiling);
						continue;
					}
					if (num == 112U)
					{
						this.GachaType = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040015EC RID: 5612
		private static readonly MessageParser<ExchangeGachaCeilingScRsp> _parser = new MessageParser<ExchangeGachaCeilingScRsp>(() => new ExchangeGachaCeilingScRsp());

		// Token: 0x040015ED RID: 5613
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015EE RID: 5614
		public const int GachaCeilingFieldNumber = 13;

		// Token: 0x040015EF RID: 5615
		private GachaCeiling gachaCeiling_;

		// Token: 0x040015F0 RID: 5616
		public const int AvatarIdFieldNumber = 6;

		// Token: 0x040015F1 RID: 5617
		private uint avatarId_;

		// Token: 0x040015F2 RID: 5618
		public const int RetcodeFieldNumber = 5;

		// Token: 0x040015F3 RID: 5619
		private uint retcode_;

		// Token: 0x040015F4 RID: 5620
		public const int TransferItemListFieldNumber = 9;

		// Token: 0x040015F5 RID: 5621
		private ItemList transferItemList_;

		// Token: 0x040015F6 RID: 5622
		public const int GachaTypeFieldNumber = 14;

		// Token: 0x040015F7 RID: 5623
		private uint gachaType_;
	}
}
