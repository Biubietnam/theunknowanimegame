using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000A7 RID: 167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class APFBCEPJLDC : IMessage<APFBCEPJLDC>, IMessage, IEquatable<APFBCEPJLDC>, IDeepCloneable<APFBCEPJLDC>, IBufferMessage
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x00014583 File Offset: 0x00012783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<APFBCEPJLDC> Parser
		{
			get
			{
				return APFBCEPJLDC._parser;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0001458A File Offset: 0x0001278A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return APFBCEPJLDCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600072F RID: 1839 RVA: 0x0001459C File Offset: 0x0001279C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return APFBCEPJLDC.Descriptor;
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000145A3 File Offset: 0x000127A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public APFBCEPJLDC()
		{
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000145AC File Offset: 0x000127AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public APFBCEPJLDC(APFBCEPJLDC other) : this()
		{
			this.fKJEBPHPBNB_ = other.fKJEBPHPBNB_;
			this.hp_ = other.hp_;
			this.avatarId_ = other.avatarId_;
			this.spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0001461C File Offset: 0x0001281C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public APFBCEPJLDC Clone()
		{
			return new APFBCEPJLDC(this);
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000733 RID: 1843 RVA: 0x00014624 File Offset: 0x00012824
		// (set) Token: 0x06000734 RID: 1844 RVA: 0x0001462C File Offset: 0x0001282C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FKJEBPHPBNB
		{
			get
			{
				return this.fKJEBPHPBNB_;
			}
			set
			{
				this.fKJEBPHPBNB_ = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000735 RID: 1845 RVA: 0x00014635 File Offset: 0x00012835
		// (set) Token: 0x06000736 RID: 1846 RVA: 0x0001463D File Offset: 0x0001283D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hp
		{
			get
			{
				return this.hp_;
			}
			set
			{
				this.hp_ = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000737 RID: 1847 RVA: 0x00014646 File Offset: 0x00012846
		// (set) Token: 0x06000738 RID: 1848 RVA: 0x0001464E File Offset: 0x0001284E
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

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x00014657 File Offset: 0x00012857
		// (set) Token: 0x0600073A RID: 1850 RVA: 0x0001465F File Offset: 0x0001285F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo SpBar
		{
			get
			{
				return this.spBar_;
			}
			set
			{
				this.spBar_ = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x00014668 File Offset: 0x00012868
		// (set) Token: 0x0600073C RID: 1852 RVA: 0x00014670 File Offset: 0x00012870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x00014679 File Offset: 0x00012879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as APFBCEPJLDC);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00014688 File Offset: 0x00012888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(APFBCEPJLDC other)
		{
			return other != null && (other == this || (this.FKJEBPHPBNB == other.FKJEBPHPBNB && this.Hp == other.Hp && this.AvatarId == other.AvatarId && object.Equals(this.SpBar, other.SpBar) && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00014708 File Offset: 0x00012908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FKJEBPHPBNB != 0U)
			{
				num ^= this.FKJEBPHPBNB.GetHashCode();
			}
			if (this.Hp != 0U)
			{
				num ^= this.Hp.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.spBar_ != null)
			{
				num ^= this.SpBar.GetHashCode();
			}
			if (this.AvatarType != 0U)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x000147A8 File Offset: 0x000129A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000147B0 File Offset: 0x000129B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000147BC File Offset: 0x000129BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.spBar_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SpBar);
			}
			if (this.FKJEBPHPBNB != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.FKJEBPHPBNB);
			}
			if (this.Hp != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Hp);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.AvatarType != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0001486C File Offset: 0x00012A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FKJEBPHPBNB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FKJEBPHPBNB);
			}
			if (this.Hp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hp);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.spBar_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpBar);
			}
			if (this.AvatarType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0001490C File Offset: 0x00012B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(APFBCEPJLDC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FKJEBPHPBNB != 0U)
			{
				this.FKJEBPHPBNB = other.FKJEBPHPBNB;
			}
			if (other.Hp != 0U)
			{
				this.Hp = other.Hp;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.spBar_ != null)
			{
				if (this.spBar_ == null)
				{
					this.SpBar = new SpBarInfo();
				}
				this.SpBar.MergeFrom(other.SpBar);
			}
			if (other.AvatarType != 0U)
			{
				this.AvatarType = other.AvatarType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000149B0 File Offset: 0x00012BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x000149BC File Offset: 0x00012BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 10U)
					{
						if (this.spBar_ == null)
						{
							this.SpBar = new SpBarInfo();
						}
						input.ReadMessage(this.SpBar);
						continue;
					}
					if (num == 40U)
					{
						this.FKJEBPHPBNB = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Hp = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.AvatarId = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.AvatarType = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040002AA RID: 682
		private static readonly MessageParser<APFBCEPJLDC> _parser = new MessageParser<APFBCEPJLDC>(() => new APFBCEPJLDC());

		// Token: 0x040002AB RID: 683
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002AC RID: 684
		public const int FKJEBPHPBNBFieldNumber = 5;

		// Token: 0x040002AD RID: 685
		private uint fKJEBPHPBNB_;

		// Token: 0x040002AE RID: 686
		public const int HpFieldNumber = 7;

		// Token: 0x040002AF RID: 687
		private uint hp_;

		// Token: 0x040002B0 RID: 688
		public const int AvatarIdFieldNumber = 10;

		// Token: 0x040002B1 RID: 689
		private uint avatarId_;

		// Token: 0x040002B2 RID: 690
		public const int SpBarFieldNumber = 1;

		// Token: 0x040002B3 RID: 691
		private SpBarInfo spBar_;

		// Token: 0x040002B4 RID: 692
		public const int AvatarTypeFieldNumber = 15;

		// Token: 0x040002B5 RID: 693
		private uint avatarType_;
	}
}
