using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000977 RID: 2423
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JLHHCIJPOPD : IMessage<JLHHCIJPOPD>, IMessage, IEquatable<JLHHCIJPOPD>, IDeepCloneable<JLHHCIJPOPD>, IBufferMessage
	{
		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x06006C51 RID: 27729 RVA: 0x001211E9 File Offset: 0x0011F3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JLHHCIJPOPD> Parser
		{
			get
			{
				return JLHHCIJPOPD._parser;
			}
		}

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x06006C52 RID: 27730 RVA: 0x001211F0 File Offset: 0x0011F3F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JLHHCIJPOPDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x06006C53 RID: 27731 RVA: 0x00121202 File Offset: 0x0011F402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JLHHCIJPOPD.Descriptor;
			}
		}

		// Token: 0x06006C54 RID: 27732 RVA: 0x00121209 File Offset: 0x0011F409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLHHCIJPOPD()
		{
		}

		// Token: 0x06006C55 RID: 27733 RVA: 0x0012121C File Offset: 0x0011F41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLHHCIJPOPD(JLHHCIJPOPD other) : this()
		{
			this.oFLKHCBDCAJ_ = other.oFLKHCBDCAJ_;
			this.jEMLFADBGMG_ = other.jEMLFADBGMG_;
			this.id_ = other.id_;
			this.avatarIdList_ = other.avatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C56 RID: 27734 RVA: 0x00121275 File Offset: 0x0011F475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JLHHCIJPOPD Clone()
		{
			return new JLHHCIJPOPD(this);
		}

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06006C57 RID: 27735 RVA: 0x0012127D File Offset: 0x0011F47D
		// (set) Token: 0x06006C58 RID: 27736 RVA: 0x00121285 File Offset: 0x0011F485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OFLKHCBDCAJ
		{
			get
			{
				return this.oFLKHCBDCAJ_;
			}
			set
			{
				this.oFLKHCBDCAJ_ = value;
			}
		}

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06006C59 RID: 27737 RVA: 0x0012128E File Offset: 0x0011F48E
		// (set) Token: 0x06006C5A RID: 27738 RVA: 0x00121296 File Offset: 0x0011F496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JEMLFADBGMG
		{
			get
			{
				return this.jEMLFADBGMG_;
			}
			set
			{
				this.jEMLFADBGMG_ = value;
			}
		}

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06006C5B RID: 27739 RVA: 0x0012129F File Offset: 0x0011F49F
		// (set) Token: 0x06006C5C RID: 27740 RVA: 0x001212A7 File Offset: 0x0011F4A7
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

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06006C5D RID: 27741 RVA: 0x001212B0 File Offset: 0x0011F4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarIdList
		{
			get
			{
				return this.avatarIdList_;
			}
		}

		// Token: 0x06006C5E RID: 27742 RVA: 0x001212B8 File Offset: 0x0011F4B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JLHHCIJPOPD);
		}

		// Token: 0x06006C5F RID: 27743 RVA: 0x001212C8 File Offset: 0x0011F4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JLHHCIJPOPD other)
		{
			return other != null && (other == this || (this.OFLKHCBDCAJ == other.OFLKHCBDCAJ && this.JEMLFADBGMG == other.JEMLFADBGMG && this.Id == other.Id && this.avatarIdList_.Equals(other.avatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C60 RID: 27744 RVA: 0x00121338 File Offset: 0x0011F538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OFLKHCBDCAJ != 0L)
			{
				num ^= this.OFLKHCBDCAJ.GetHashCode();
			}
			if (this.JEMLFADBGMG != 0U)
			{
				num ^= this.JEMLFADBGMG.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.avatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C61 RID: 27745 RVA: 0x001213B7 File Offset: 0x0011F5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C62 RID: 27746 RVA: 0x001213BF File Offset: 0x0011F5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C63 RID: 27747 RVA: 0x001213C8 File Offset: 0x0011F5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OFLKHCBDCAJ != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.OFLKHCBDCAJ);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Id);
			}
			if (this.JEMLFADBGMG != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.JEMLFADBGMG);
			}
			this.avatarIdList_.WriteTo(ref output, JLHHCIJPOPD._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C64 RID: 27748 RVA: 0x00121450 File Offset: 0x0011F650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OFLKHCBDCAJ != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OFLKHCBDCAJ);
			}
			if (this.JEMLFADBGMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JEMLFADBGMG);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			num += this.avatarIdList_.CalculateSize(JLHHCIJPOPD._repeated_avatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C65 RID: 27749 RVA: 0x001214D4 File Offset: 0x0011F6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JLHHCIJPOPD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OFLKHCBDCAJ != 0L)
			{
				this.OFLKHCBDCAJ = other.OFLKHCBDCAJ;
			}
			if (other.JEMLFADBGMG != 0U)
			{
				this.JEMLFADBGMG = other.JEMLFADBGMG;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this.avatarIdList_.Add(other.avatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C66 RID: 27750 RVA: 0x00121549 File Offset: 0x0011F749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C67 RID: 27751 RVA: 0x00121554 File Offset: 0x0011F754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 104U)
				{
					if (num == 40U)
					{
						this.OFLKHCBDCAJ = input.ReadInt64();
						continue;
					}
					if (num == 104U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.JEMLFADBGMG = input.ReadUInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.avatarIdList_.AddEntriesFrom(ref input, JLHHCIJPOPD._repeated_avatarIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400297B RID: 10619
		private static readonly MessageParser<JLHHCIJPOPD> _parser = new MessageParser<JLHHCIJPOPD>(() => new JLHHCIJPOPD());

		// Token: 0x0400297C RID: 10620
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400297D RID: 10621
		public const int OFLKHCBDCAJFieldNumber = 5;

		// Token: 0x0400297E RID: 10622
		private long oFLKHCBDCAJ_;

		// Token: 0x0400297F RID: 10623
		public const int JEMLFADBGMGFieldNumber = 14;

		// Token: 0x04002980 RID: 10624
		private uint jEMLFADBGMG_;

		// Token: 0x04002981 RID: 10625
		public const int IdFieldNumber = 13;

		// Token: 0x04002982 RID: 10626
		private uint id_;

		// Token: 0x04002983 RID: 10627
		public const int AvatarIdListFieldNumber = 15;

		// Token: 0x04002984 RID: 10628
		private static readonly FieldCodec<uint> _repeated_avatarIdList_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04002985 RID: 10629
		private readonly RepeatedField<uint> avatarIdList_ = new RepeatedField<uint>();
	}
}
