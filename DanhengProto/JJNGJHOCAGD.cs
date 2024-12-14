using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000971 RID: 2417
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JJNGJHOCAGD : IMessage<JJNGJHOCAGD>, IMessage, IEquatable<JJNGJHOCAGD>, IDeepCloneable<JJNGJHOCAGD>, IBufferMessage
	{
		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x06006BF2 RID: 27634 RVA: 0x0011FB65 File Offset: 0x0011DD65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JJNGJHOCAGD> Parser
		{
			get
			{
				return JJNGJHOCAGD._parser;
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x06006BF3 RID: 27635 RVA: 0x0011FB6C File Offset: 0x0011DD6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JJNGJHOCAGDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x06006BF4 RID: 27636 RVA: 0x0011FB7E File Offset: 0x0011DD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JJNGJHOCAGD.Descriptor;
			}
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x0011FB85 File Offset: 0x0011DD85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJNGJHOCAGD()
		{
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x0011FB90 File Offset: 0x0011DD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJNGJHOCAGD(JJNGJHOCAGD other) : this()
		{
			this.fBABHLPMKBK_ = other.fBABHLPMKBK_;
			this.uid_ = other.uid_;
			this.iMIJBGMIOMF_ = other.iMIJBGMIOMF_;
			this.eDKBMNFOOAJ_ = other.eDKBMNFOOAJ_;
			this.gPACHKLFGPC_ = other.gPACHKLFGPC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x0011FBF0 File Offset: 0x0011DDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JJNGJHOCAGD Clone()
		{
			return new JJNGJHOCAGD(this);
		}

		// Token: 0x17001E5A RID: 7770
		// (get) Token: 0x06006BF8 RID: 27640 RVA: 0x0011FBF8 File Offset: 0x0011DDF8
		// (set) Token: 0x06006BF9 RID: 27641 RVA: 0x0011FC00 File Offset: 0x0011DE00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FBABHLPMKBK
		{
			get
			{
				return this.fBABHLPMKBK_;
			}
			set
			{
				this.fBABHLPMKBK_ = value;
			}
		}

		// Token: 0x17001E5B RID: 7771
		// (get) Token: 0x06006BFA RID: 27642 RVA: 0x0011FC09 File Offset: 0x0011DE09
		// (set) Token: 0x06006BFB RID: 27643 RVA: 0x0011FC11 File Offset: 0x0011DE11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Uid
		{
			get
			{
				return this.uid_;
			}
			set
			{
				this.uid_ = value;
			}
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06006BFC RID: 27644 RVA: 0x0011FC1A File Offset: 0x0011DE1A
		// (set) Token: 0x06006BFD RID: 27645 RVA: 0x0011FC22 File Offset: 0x0011DE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IMIJBGMIOMF
		{
			get
			{
				return this.iMIJBGMIOMF_;
			}
			set
			{
				this.iMIJBGMIOMF_ = value;
			}
		}

		// Token: 0x17001E5D RID: 7773
		// (get) Token: 0x06006BFE RID: 27646 RVA: 0x0011FC2B File Offset: 0x0011DE2B
		// (set) Token: 0x06006BFF RID: 27647 RVA: 0x0011FC33 File Offset: 0x0011DE33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EDKBMNFOOAJ
		{
			get
			{
				return this.eDKBMNFOOAJ_;
			}
			set
			{
				this.eDKBMNFOOAJ_ = value;
			}
		}

		// Token: 0x17001E5E RID: 7774
		// (get) Token: 0x06006C00 RID: 27648 RVA: 0x0011FC3C File Offset: 0x0011DE3C
		// (set) Token: 0x06006C01 RID: 27649 RVA: 0x0011FC44 File Offset: 0x0011DE44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GPACHKLFGPC
		{
			get
			{
				return this.gPACHKLFGPC_;
			}
			set
			{
				this.gPACHKLFGPC_ = value;
			}
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x0011FC4D File Offset: 0x0011DE4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JJNGJHOCAGD);
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x0011FC5C File Offset: 0x0011DE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JJNGJHOCAGD other)
		{
			return other != null && (other == this || (this.FBABHLPMKBK == other.FBABHLPMKBK && this.Uid == other.Uid && this.IMIJBGMIOMF == other.IMIJBGMIOMF && this.EDKBMNFOOAJ == other.EDKBMNFOOAJ && this.GPACHKLFGPC == other.GPACHKLFGPC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x0011FCD8 File Offset: 0x0011DED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FBABHLPMKBK != 0U)
			{
				num ^= this.FBABHLPMKBK.GetHashCode();
			}
			if (this.Uid != 0U)
			{
				num ^= this.Uid.GetHashCode();
			}
			if (this.IMIJBGMIOMF != 0U)
			{
				num ^= this.IMIJBGMIOMF.GetHashCode();
			}
			if (this.EDKBMNFOOAJ != 0U)
			{
				num ^= this.EDKBMNFOOAJ.GetHashCode();
			}
			if (this.GPACHKLFGPC != 0U)
			{
				num ^= this.GPACHKLFGPC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x0011FD7B File Offset: 0x0011DF7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x0011FD83 File Offset: 0x0011DF83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x0011FD8C File Offset: 0x0011DF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FBABHLPMKBK != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.FBABHLPMKBK);
			}
			if (this.GPACHKLFGPC != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GPACHKLFGPC);
			}
			if (this.EDKBMNFOOAJ != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EDKBMNFOOAJ);
			}
			if (this.IMIJBGMIOMF != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.IMIJBGMIOMF);
			}
			if (this.Uid != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Uid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x0011FE38 File Offset: 0x0011E038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FBABHLPMKBK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FBABHLPMKBK);
			}
			if (this.Uid != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Uid);
			}
			if (this.IMIJBGMIOMF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IMIJBGMIOMF);
			}
			if (this.EDKBMNFOOAJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EDKBMNFOOAJ);
			}
			if (this.GPACHKLFGPC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GPACHKLFGPC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x0011FED8 File Offset: 0x0011E0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JJNGJHOCAGD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FBABHLPMKBK != 0U)
			{
				this.FBABHLPMKBK = other.FBABHLPMKBK;
			}
			if (other.Uid != 0U)
			{
				this.Uid = other.Uid;
			}
			if (other.IMIJBGMIOMF != 0U)
			{
				this.IMIJBGMIOMF = other.IMIJBGMIOMF;
			}
			if (other.EDKBMNFOOAJ != 0U)
			{
				this.EDKBMNFOOAJ = other.EDKBMNFOOAJ;
			}
			if (other.GPACHKLFGPC != 0U)
			{
				this.GPACHKLFGPC = other.GPACHKLFGPC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006C0A RID: 27658 RVA: 0x0011FF64 File Offset: 0x0011E164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C0B RID: 27659 RVA: 0x0011FF70 File Offset: 0x0011E170
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
						this.FBABHLPMKBK = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.GPACHKLFGPC = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.EDKBMNFOOAJ = input.ReadUInt32();
						continue;
					}
					if (num == 88U)
					{
						this.IMIJBGMIOMF = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Uid = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400294C RID: 10572
		private static readonly MessageParser<JJNGJHOCAGD> _parser = new MessageParser<JJNGJHOCAGD>(() => new JJNGJHOCAGD());

		// Token: 0x0400294D RID: 10573
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400294E RID: 10574
		public const int FBABHLPMKBKFieldNumber = 1;

		// Token: 0x0400294F RID: 10575
		private uint fBABHLPMKBK_;

		// Token: 0x04002950 RID: 10576
		public const int UidFieldNumber = 13;

		// Token: 0x04002951 RID: 10577
		private uint uid_;

		// Token: 0x04002952 RID: 10578
		public const int IMIJBGMIOMFFieldNumber = 11;

		// Token: 0x04002953 RID: 10579
		private uint iMIJBGMIOMF_;

		// Token: 0x04002954 RID: 10580
		public const int EDKBMNFOOAJFieldNumber = 6;

		// Token: 0x04002955 RID: 10581
		private uint eDKBMNFOOAJ_;

		// Token: 0x04002956 RID: 10582
		public const int GPACHKLFGPCFieldNumber = 3;

		// Token: 0x04002957 RID: 10583
		private uint gPACHKLFGPC_;
	}
}
