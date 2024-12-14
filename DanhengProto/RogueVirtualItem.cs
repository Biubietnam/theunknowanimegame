using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200102D RID: 4141
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueVirtualItem : IMessage<RogueVirtualItem>, IMessage, IEquatable<RogueVirtualItem>, IDeepCloneable<RogueVirtualItem>, IBufferMessage
	{
		// Token: 0x170033DC RID: 13276
		// (get) Token: 0x0600B813 RID: 47123 RVA: 0x001EDE3D File Offset: 0x001EC03D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueVirtualItem> Parser
		{
			get
			{
				return RogueVirtualItem._parser;
			}
		}

		// Token: 0x170033DD RID: 13277
		// (get) Token: 0x0600B814 RID: 47124 RVA: 0x001EDE44 File Offset: 0x001EC044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueVirtualItemReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033DE RID: 13278
		// (get) Token: 0x0600B815 RID: 47125 RVA: 0x001EDE56 File Offset: 0x001EC056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueVirtualItem.Descriptor;
			}
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x001EDE5D File Offset: 0x001EC05D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItem()
		{
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x001EDE68 File Offset: 0x001EC068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItem(RogueVirtualItem other) : this()
		{
			this.jFNJOJCMKMM_ = other.jFNJOJCMKMM_;
			this.gNGGPEAABBA_ = other.gNGGPEAABBA_;
			this.mMBOIAHGEJJ_ = other.mMBOIAHGEJJ_;
			this.rogueMoney_ = other.rogueMoney_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x001EDEBC File Offset: 0x001EC0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueVirtualItem Clone()
		{
			return new RogueVirtualItem(this);
		}

		// Token: 0x170033DF RID: 13279
		// (get) Token: 0x0600B819 RID: 47129 RVA: 0x001EDEC4 File Offset: 0x001EC0C4
		// (set) Token: 0x0600B81A RID: 47130 RVA: 0x001EDECC File Offset: 0x001EC0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JFNJOJCMKMM
		{
			get
			{
				return this.jFNJOJCMKMM_;
			}
			set
			{
				this.jFNJOJCMKMM_ = value;
			}
		}

		// Token: 0x170033E0 RID: 13280
		// (get) Token: 0x0600B81B RID: 47131 RVA: 0x001EDED5 File Offset: 0x001EC0D5
		// (set) Token: 0x0600B81C RID: 47132 RVA: 0x001EDEDD File Offset: 0x001EC0DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GNGGPEAABBA
		{
			get
			{
				return this.gNGGPEAABBA_;
			}
			set
			{
				this.gNGGPEAABBA_ = value;
			}
		}

		// Token: 0x170033E1 RID: 13281
		// (get) Token: 0x0600B81D RID: 47133 RVA: 0x001EDEE6 File Offset: 0x001EC0E6
		// (set) Token: 0x0600B81E RID: 47134 RVA: 0x001EDEEE File Offset: 0x001EC0EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MMBOIAHGEJJ
		{
			get
			{
				return this.mMBOIAHGEJJ_;
			}
			set
			{
				this.mMBOIAHGEJJ_ = value;
			}
		}

		// Token: 0x170033E2 RID: 13282
		// (get) Token: 0x0600B81F RID: 47135 RVA: 0x001EDEF7 File Offset: 0x001EC0F7
		// (set) Token: 0x0600B820 RID: 47136 RVA: 0x001EDEFF File Offset: 0x001EC0FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RogueMoney
		{
			get
			{
				return this.rogueMoney_;
			}
			set
			{
				this.rogueMoney_ = value;
			}
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x001EDF08 File Offset: 0x001EC108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueVirtualItem);
		}

		// Token: 0x0600B822 RID: 47138 RVA: 0x001EDF18 File Offset: 0x001EC118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueVirtualItem other)
		{
			return other != null && (other == this || (this.JFNJOJCMKMM == other.JFNJOJCMKMM && this.GNGGPEAABBA == other.GNGGPEAABBA && this.MMBOIAHGEJJ == other.MMBOIAHGEJJ && this.RogueMoney == other.RogueMoney && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B823 RID: 47139 RVA: 0x001EDF84 File Offset: 0x001EC184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JFNJOJCMKMM != 0U)
			{
				num ^= this.JFNJOJCMKMM.GetHashCode();
			}
			if (this.GNGGPEAABBA != 0U)
			{
				num ^= this.GNGGPEAABBA.GetHashCode();
			}
			if (this.MMBOIAHGEJJ != 0U)
			{
				num ^= this.MMBOIAHGEJJ.GetHashCode();
			}
			if (this.RogueMoney != 0U)
			{
				num ^= this.RogueMoney.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x001EE00E File Offset: 0x001EC20E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x001EE016 File Offset: 0x001EC216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x001EE020 File Offset: 0x001EC220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RogueMoney != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.RogueMoney);
			}
			if (this.MMBOIAHGEJJ != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MMBOIAHGEJJ);
			}
			if (this.JFNJOJCMKMM != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.JFNJOJCMKMM);
			}
			if (this.GNGGPEAABBA != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GNGGPEAABBA);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x001EE0B0 File Offset: 0x001EC2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JFNJOJCMKMM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JFNJOJCMKMM);
			}
			if (this.GNGGPEAABBA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GNGGPEAABBA);
			}
			if (this.MMBOIAHGEJJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MMBOIAHGEJJ);
			}
			if (this.RogueMoney != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RogueMoney);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x001EE138 File Offset: 0x001EC338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueVirtualItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JFNJOJCMKMM != 0U)
			{
				this.JFNJOJCMKMM = other.JFNJOJCMKMM;
			}
			if (other.GNGGPEAABBA != 0U)
			{
				this.GNGGPEAABBA = other.GNGGPEAABBA;
			}
			if (other.MMBOIAHGEJJ != 0U)
			{
				this.MMBOIAHGEJJ = other.MMBOIAHGEJJ;
			}
			if (other.RogueMoney != 0U)
			{
				this.RogueMoney = other.RogueMoney;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x001EE1B0 File Offset: 0x001EC3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x001EE1BC File Offset: 0x001EC3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.RogueMoney = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.MMBOIAHGEJJ = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.JFNJOJCMKMM = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.GNGGPEAABBA = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004A94 RID: 19092
		private static readonly MessageParser<RogueVirtualItem> _parser = new MessageParser<RogueVirtualItem>(() => new RogueVirtualItem());

		// Token: 0x04004A95 RID: 19093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A96 RID: 19094
		public const int JFNJOJCMKMMFieldNumber = 6;

		// Token: 0x04004A97 RID: 19095
		private uint jFNJOJCMKMM_;

		// Token: 0x04004A98 RID: 19096
		public const int GNGGPEAABBAFieldNumber = 13;

		// Token: 0x04004A99 RID: 19097
		private uint gNGGPEAABBA_;

		// Token: 0x04004A9A RID: 19098
		public const int MMBOIAHGEJJFieldNumber = 3;

		// Token: 0x04004A9B RID: 19099
		private uint mMBOIAHGEJJ_;

		// Token: 0x04004A9C RID: 19100
		public const int RogueMoneyFieldNumber = 1;

		// Token: 0x04004A9D RID: 19101
		private uint rogueMoney_;
	}
}
