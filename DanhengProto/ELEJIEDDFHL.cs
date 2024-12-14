using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200040D RID: 1037
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ELEJIEDDFHL : IMessage<ELEJIEDDFHL>, IMessage, IEquatable<ELEJIEDDFHL>, IDeepCloneable<ELEJIEDDFHL>, IBufferMessage
	{
		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x0007F23D File Offset: 0x0007D43D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ELEJIEDDFHL> Parser
		{
			get
			{
				return ELEJIEDDFHL._parser;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x0007F244 File Offset: 0x0007D444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ELEJIEDDFHLReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x0007F256 File Offset: 0x0007D456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ELEJIEDDFHL.Descriptor;
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x0007F25D File Offset: 0x0007D45D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELEJIEDDFHL()
		{
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x0007F270 File Offset: 0x0007D470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELEJIEDDFHL(ELEJIEDDFHL other) : this()
		{
			this.gFBBLGMOCDN_ = other.gFBBLGMOCDN_;
			this.lPLHNKCGBBB_ = other.lPLHNKCGBBB_.Clone();
			this.aEIFBHBACGK_ = other.aEIFBHBACGK_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x0007F2BD File Offset: 0x0007D4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELEJIEDDFHL Clone()
		{
			return new ELEJIEDDFHL(this);
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x0007F2C5 File Offset: 0x0007D4C5
		// (set) Token: 0x06002E08 RID: 11784 RVA: 0x0007F2CD File Offset: 0x0007D4CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GFBBLGMOCDN
		{
			get
			{
				return this.gFBBLGMOCDN_;
			}
			set
			{
				this.gFBBLGMOCDN_ = value;
			}
		}

		// Token: 0x17000D2F RID: 3375
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x0007F2D6 File Offset: 0x0007D4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NOJPFGOHGKE> LPLHNKCGBBB
		{
			get
			{
				return this.lPLHNKCGBBB_;
			}
		}

		// Token: 0x17000D30 RID: 3376
		// (get) Token: 0x06002E0A RID: 11786 RVA: 0x0007F2DE File Offset: 0x0007D4DE
		// (set) Token: 0x06002E0B RID: 11787 RVA: 0x0007F2E6 File Offset: 0x0007D4E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AEIFBHBACGK
		{
			get
			{
				return this.aEIFBHBACGK_;
			}
			set
			{
				this.aEIFBHBACGK_ = value;
			}
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x0007F2EF File Offset: 0x0007D4EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ELEJIEDDFHL);
		}

		// Token: 0x06002E0D RID: 11789 RVA: 0x0007F300 File Offset: 0x0007D500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ELEJIEDDFHL other)
		{
			return other != null && (other == this || (this.GFBBLGMOCDN == other.GFBBLGMOCDN && this.lPLHNKCGBBB_.Equals(other.lPLHNKCGBBB_) && this.AEIFBHBACGK == other.AEIFBHBACGK && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E0E RID: 11790 RVA: 0x0007F360 File Offset: 0x0007D560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GFBBLGMOCDN != 0U)
			{
				num ^= this.GFBBLGMOCDN.GetHashCode();
			}
			num ^= this.lPLHNKCGBBB_.GetHashCode();
			if (this.AEIFBHBACGK != 0U)
			{
				num ^= this.AEIFBHBACGK.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x0007F3C6 File Offset: 0x0007D5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x0007F3CE File Offset: 0x0007D5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x0007F3D8 File Offset: 0x0007D5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AEIFBHBACGK != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AEIFBHBACGK);
			}
			this.lPLHNKCGBBB_.WriteTo(ref output, ELEJIEDDFHL._repeated_lPLHNKCGBBB_codec);
			if (this.GFBBLGMOCDN != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GFBBLGMOCDN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x0007F444 File Offset: 0x0007D644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GFBBLGMOCDN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GFBBLGMOCDN);
			}
			num += this.lPLHNKCGBBB_.CalculateSize(ELEJIEDDFHL._repeated_lPLHNKCGBBB_codec);
			if (this.AEIFBHBACGK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AEIFBHBACGK);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0007F4B0 File Offset: 0x0007D6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ELEJIEDDFHL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GFBBLGMOCDN != 0U)
			{
				this.GFBBLGMOCDN = other.GFBBLGMOCDN;
			}
			this.lPLHNKCGBBB_.Add(other.lPLHNKCGBBB_);
			if (other.AEIFBHBACGK != 0U)
			{
				this.AEIFBHBACGK = other.AEIFBHBACGK;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x0007F511 File Offset: 0x0007D711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x0007F51C File Offset: 0x0007D71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 90U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GFBBLGMOCDN = input.ReadUInt32();
						}
					}
					else
					{
						this.lPLHNKCGBBB_.AddEntriesFrom(ref input, ELEJIEDDFHL._repeated_lPLHNKCGBBB_codec);
					}
				}
				else
				{
					this.AEIFBHBACGK = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400127C RID: 4732
		private static readonly MessageParser<ELEJIEDDFHL> _parser = new MessageParser<ELEJIEDDFHL>(() => new ELEJIEDDFHL());

		// Token: 0x0400127D RID: 4733
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400127E RID: 4734
		public const int GFBBLGMOCDNFieldNumber = 14;

		// Token: 0x0400127F RID: 4735
		private uint gFBBLGMOCDN_;

		// Token: 0x04001280 RID: 4736
		public const int LPLHNKCGBBBFieldNumber = 11;

		// Token: 0x04001281 RID: 4737
		private static readonly FieldCodec<NOJPFGOHGKE> _repeated_lPLHNKCGBBB_codec = FieldCodec.ForMessage<NOJPFGOHGKE>(90U, NOJPFGOHGKE.Parser);

		// Token: 0x04001282 RID: 4738
		private readonly RepeatedField<NOJPFGOHGKE> lPLHNKCGBBB_ = new RepeatedField<NOJPFGOHGKE>();

		// Token: 0x04001283 RID: 4739
		public const int AEIFBHBACGKFieldNumber = 3;

		// Token: 0x04001284 RID: 4740
		private uint aEIFBHBACGK_;
	}
}
