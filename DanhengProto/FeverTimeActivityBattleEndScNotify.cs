using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000517 RID: 1303
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FeverTimeActivityBattleEndScNotify : IMessage<FeverTimeActivityBattleEndScNotify>, IMessage, IEquatable<FeverTimeActivityBattleEndScNotify>, IDeepCloneable<FeverTimeActivityBattleEndScNotify>, IBufferMessage
	{
		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x000A05D7 File Offset: 0x0009E7D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FeverTimeActivityBattleEndScNotify> Parser
		{
			get
			{
				return FeverTimeActivityBattleEndScNotify._parser;
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x000A05DE File Offset: 0x0009E7DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FeverTimeActivityBattleEndScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x000A05F0 File Offset: 0x0009E7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeverTimeActivityBattleEndScNotify.Descriptor;
			}
		}

		// Token: 0x06003A50 RID: 14928 RVA: 0x000A05F7 File Offset: 0x0009E7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeActivityBattleEndScNotify()
		{
		}

		// Token: 0x06003A51 RID: 14929 RVA: 0x000A0600 File Offset: 0x0009E800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeActivityBattleEndScNotify(FeverTimeActivityBattleEndScNotify other) : this()
		{
			this.bFADHPMMODP_ = other.bFADHPMMODP_;
			this.id_ = other.id_;
			this.eGPGPJLOHIL_ = other.eGPGPJLOHIL_;
			this.dHFALDJEAAN_ = other.dHFALDJEAAN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A52 RID: 14930 RVA: 0x000A0654 File Offset: 0x0009E854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeActivityBattleEndScNotify Clone()
		{
			return new FeverTimeActivityBattleEndScNotify(this);
		}

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x000A065C File Offset: 0x0009E85C
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x000A0664 File Offset: 0x0009E864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BFADHPMMODP
		{
			get
			{
				return this.bFADHPMMODP_;
			}
			set
			{
				this.bFADHPMMODP_ = value;
			}
		}

		// Token: 0x170010A9 RID: 4265
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x000A066D File Offset: 0x0009E86D
		// (set) Token: 0x06003A56 RID: 14934 RVA: 0x000A0675 File Offset: 0x0009E875
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

		// Token: 0x170010AA RID: 4266
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x000A067E File Offset: 0x0009E87E
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x000A0686 File Offset: 0x0009E886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeverTimeBattleRank EGPGPJLOHIL
		{
			get
			{
				return this.eGPGPJLOHIL_;
			}
			set
			{
				this.eGPGPJLOHIL_ = value;
			}
		}

		// Token: 0x170010AB RID: 4267
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x000A068F File Offset: 0x0009E88F
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x000A0697 File Offset: 0x0009E897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DHFALDJEAAN
		{
			get
			{
				return this.dHFALDJEAAN_;
			}
			set
			{
				this.dHFALDJEAAN_ = value;
			}
		}

		// Token: 0x06003A5B RID: 14939 RVA: 0x000A06A0 File Offset: 0x0009E8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeverTimeActivityBattleEndScNotify);
		}

		// Token: 0x06003A5C RID: 14940 RVA: 0x000A06B0 File Offset: 0x0009E8B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeverTimeActivityBattleEndScNotify other)
		{
			return other != null && (other == this || (this.BFADHPMMODP == other.BFADHPMMODP && this.Id == other.Id && this.EGPGPJLOHIL == other.EGPGPJLOHIL && this.DHFALDJEAAN == other.DHFALDJEAAN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A5D RID: 14941 RVA: 0x000A071C File Offset: 0x0009E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BFADHPMMODP != 0U)
			{
				num ^= this.BFADHPMMODP.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.EGPGPJLOHIL != FeverTimeBattleRank.C)
			{
				num ^= this.EGPGPJLOHIL.GetHashCode();
			}
			if (this.DHFALDJEAAN != 0U)
			{
				num ^= this.DHFALDJEAAN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A5E RID: 14942 RVA: 0x000A07AC File Offset: 0x0009E9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A5F RID: 14943 RVA: 0x000A07B4 File Offset: 0x0009E9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x000A07C0 File Offset: 0x0009E9C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EGPGPJLOHIL != FeverTimeBattleRank.C)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.EGPGPJLOHIL);
			}
			if (this.BFADHPMMODP != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.BFADHPMMODP);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Id);
			}
			if (this.DHFALDJEAAN != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.DHFALDJEAAN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x000A0850 File Offset: 0x0009EA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BFADHPMMODP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BFADHPMMODP);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.EGPGPJLOHIL != FeverTimeBattleRank.C)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.EGPGPJLOHIL);
			}
			if (this.DHFALDJEAAN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DHFALDJEAAN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A62 RID: 14946 RVA: 0x000A08D8 File Offset: 0x0009EAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeverTimeActivityBattleEndScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BFADHPMMODP != 0U)
			{
				this.BFADHPMMODP = other.BFADHPMMODP;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.EGPGPJLOHIL != FeverTimeBattleRank.C)
			{
				this.EGPGPJLOHIL = other.EGPGPJLOHIL;
			}
			if (other.DHFALDJEAAN != 0U)
			{
				this.DHFALDJEAAN = other.DHFALDJEAAN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x000A0950 File Offset: 0x0009EB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A64 RID: 14948 RVA: 0x000A095C File Offset: 0x0009EB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.EGPGPJLOHIL = (FeverTimeBattleRank)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.BFADHPMMODP = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.DHFALDJEAAN = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400176D RID: 5997
		private static readonly MessageParser<FeverTimeActivityBattleEndScNotify> _parser = new MessageParser<FeverTimeActivityBattleEndScNotify>(() => new FeverTimeActivityBattleEndScNotify());

		// Token: 0x0400176E RID: 5998
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400176F RID: 5999
		public const int BFADHPMMODPFieldNumber = 2;

		// Token: 0x04001770 RID: 6000
		private uint bFADHPMMODP_;

		// Token: 0x04001771 RID: 6001
		public const int IdFieldNumber = 8;

		// Token: 0x04001772 RID: 6002
		private uint id_;

		// Token: 0x04001773 RID: 6003
		public const int EGPGPJLOHILFieldNumber = 1;

		// Token: 0x04001774 RID: 6004
		private FeverTimeBattleRank eGPGPJLOHIL_;

		// Token: 0x04001775 RID: 6005
		public const int DHFALDJEAANFieldNumber = 9;

		// Token: 0x04001776 RID: 6006
		private uint dHFALDJEAAN_;
	}
}
