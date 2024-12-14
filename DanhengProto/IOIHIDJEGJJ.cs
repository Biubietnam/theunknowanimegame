using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000943 RID: 2371
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IOIHIDJEGJJ : IMessage<IOIHIDJEGJJ>, IMessage, IEquatable<IOIHIDJEGJJ>, IDeepCloneable<IOIHIDJEGJJ>, IBufferMessage
	{
		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x060069CC RID: 27084 RVA: 0x0011A4B9 File Offset: 0x001186B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IOIHIDJEGJJ> Parser
		{
			get
			{
				return IOIHIDJEGJJ._parser;
			}
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x060069CD RID: 27085 RVA: 0x0011A4C0 File Offset: 0x001186C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IOIHIDJEGJJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x060069CE RID: 27086 RVA: 0x0011A4D2 File Offset: 0x001186D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IOIHIDJEGJJ.Descriptor;
			}
		}

		// Token: 0x060069CF RID: 27087 RVA: 0x0011A4D9 File Offset: 0x001186D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IOIHIDJEGJJ()
		{
		}

		// Token: 0x060069D0 RID: 27088 RVA: 0x0011A4E4 File Offset: 0x001186E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IOIHIDJEGJJ(IOIHIDJEGJJ other) : this()
		{
			this.iANMNDOBEOF_ = other.iANMNDOBEOF_;
			this.itemId_ = other.itemId_;
			this.cOHAKBPNCDG_ = other.cOHAKBPNCDG_;
			this.gEBIEMEFINN_ = other.gEBIEMEFINN_;
			this.mIBHBOCHMCH_ = other.mIBHBOCHMCH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060069D1 RID: 27089 RVA: 0x0011A544 File Offset: 0x00118744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IOIHIDJEGJJ Clone()
		{
			return new IOIHIDJEGJJ(this);
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x060069D2 RID: 27090 RVA: 0x0011A54C File Offset: 0x0011874C
		// (set) Token: 0x060069D3 RID: 27091 RVA: 0x0011A554 File Offset: 0x00118754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IANMNDOBEOF
		{
			get
			{
				return this.iANMNDOBEOF_;
			}
			set
			{
				this.iANMNDOBEOF_ = value;
			}
		}

		// Token: 0x17001DC2 RID: 7618
		// (get) Token: 0x060069D4 RID: 27092 RVA: 0x0011A55D File Offset: 0x0011875D
		// (set) Token: 0x060069D5 RID: 27093 RVA: 0x0011A565 File Offset: 0x00118765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001DC3 RID: 7619
		// (get) Token: 0x060069D6 RID: 27094 RVA: 0x0011A56E File Offset: 0x0011876E
		// (set) Token: 0x060069D7 RID: 27095 RVA: 0x0011A576 File Offset: 0x00118776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COHAKBPNCDG
		{
			get
			{
				return this.cOHAKBPNCDG_;
			}
			set
			{
				this.cOHAKBPNCDG_ = value;
			}
		}

		// Token: 0x17001DC4 RID: 7620
		// (get) Token: 0x060069D8 RID: 27096 RVA: 0x0011A57F File Offset: 0x0011877F
		// (set) Token: 0x060069D9 RID: 27097 RVA: 0x0011A587 File Offset: 0x00118787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GEBIEMEFINN
		{
			get
			{
				return this.gEBIEMEFINN_;
			}
			set
			{
				this.gEBIEMEFINN_ = value;
			}
		}

		// Token: 0x17001DC5 RID: 7621
		// (get) Token: 0x060069DA RID: 27098 RVA: 0x0011A590 File Offset: 0x00118790
		// (set) Token: 0x060069DB RID: 27099 RVA: 0x0011A598 File Offset: 0x00118798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MIBHBOCHMCH
		{
			get
			{
				return this.mIBHBOCHMCH_;
			}
			set
			{
				this.mIBHBOCHMCH_ = value;
			}
		}

		// Token: 0x060069DC RID: 27100 RVA: 0x0011A5A1 File Offset: 0x001187A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IOIHIDJEGJJ);
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x0011A5B0 File Offset: 0x001187B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IOIHIDJEGJJ other)
		{
			return other != null && (other == this || (this.IANMNDOBEOF == other.IANMNDOBEOF && this.ItemId == other.ItemId && this.COHAKBPNCDG == other.COHAKBPNCDG && this.GEBIEMEFINN == other.GEBIEMEFINN && this.MIBHBOCHMCH == other.MIBHBOCHMCH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x0011A62C File Offset: 0x0011882C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IANMNDOBEOF != 0)
			{
				num ^= this.IANMNDOBEOF.GetHashCode();
			}
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num ^= this.COHAKBPNCDG.GetHashCode();
			}
			if (this.GEBIEMEFINN != 0)
			{
				num ^= this.GEBIEMEFINN.GetHashCode();
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				num ^= this.MIBHBOCHMCH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x0011A6CF File Offset: 0x001188CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x0011A6D7 File Offset: 0x001188D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x0011A6E0 File Offset: 0x001188E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COHAKBPNCDG != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.COHAKBPNCDG);
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.MIBHBOCHMCH);
			}
			if (this.GEBIEMEFINN != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.GEBIEMEFINN);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ItemId);
			}
			if (this.IANMNDOBEOF != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IANMNDOBEOF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x0011A78C File Offset: 0x0011898C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IANMNDOBEOF != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IANMNDOBEOF);
			}
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.COHAKBPNCDG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COHAKBPNCDG);
			}
			if (this.GEBIEMEFINN != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GEBIEMEFINN);
			}
			if (this.MIBHBOCHMCH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MIBHBOCHMCH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x0011A82C File Offset: 0x00118A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IOIHIDJEGJJ other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IANMNDOBEOF != 0)
			{
				this.IANMNDOBEOF = other.IANMNDOBEOF;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.COHAKBPNCDG != 0U)
			{
				this.COHAKBPNCDG = other.COHAKBPNCDG;
			}
			if (other.GEBIEMEFINN != 0)
			{
				this.GEBIEMEFINN = other.GEBIEMEFINN;
			}
			if (other.MIBHBOCHMCH != 0U)
			{
				this.MIBHBOCHMCH = other.MIBHBOCHMCH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060069E4 RID: 27108 RVA: 0x0011A8B8 File Offset: 0x00118AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x0011A8C4 File Offset: 0x00118AC4
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
						this.COHAKBPNCDG = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.MIBHBOCHMCH = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.GEBIEMEFINN = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.ItemId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.IANMNDOBEOF = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002884 RID: 10372
		private static readonly MessageParser<IOIHIDJEGJJ> _parser = new MessageParser<IOIHIDJEGJJ>(() => new IOIHIDJEGJJ());

		// Token: 0x04002885 RID: 10373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002886 RID: 10374
		public const int IANMNDOBEOFFieldNumber = 10;

		// Token: 0x04002887 RID: 10375
		private int iANMNDOBEOF_;

		// Token: 0x04002888 RID: 10376
		public const int ItemIdFieldNumber = 8;

		// Token: 0x04002889 RID: 10377
		private uint itemId_;

		// Token: 0x0400288A RID: 10378
		public const int COHAKBPNCDGFieldNumber = 1;

		// Token: 0x0400288B RID: 10379
		private uint cOHAKBPNCDG_;

		// Token: 0x0400288C RID: 10380
		public const int GEBIEMEFINNFieldNumber = 6;

		// Token: 0x0400288D RID: 10381
		private int gEBIEMEFINN_;

		// Token: 0x0400288E RID: 10382
		public const int MIBHBOCHMCHFieldNumber = 3;

		// Token: 0x0400288F RID: 10383
		private uint mIBHBOCHMCH_;
	}
}
