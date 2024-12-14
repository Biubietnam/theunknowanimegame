using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C91 RID: 3217
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PGIMFOFDPGF : IMessage<PGIMFOFDPGF>, IMessage, IEquatable<PGIMFOFDPGF>, IDeepCloneable<PGIMFOFDPGF>, IBufferMessage
	{
		// Token: 0x17002831 RID: 10289
		// (get) Token: 0x06008F0B RID: 36619 RVA: 0x0017A198 File Offset: 0x00178398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PGIMFOFDPGF> Parser
		{
			get
			{
				return PGIMFOFDPGF._parser;
			}
		}

		// Token: 0x17002832 RID: 10290
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x0017A19F File Offset: 0x0017839F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PGIMFOFDPGFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002833 RID: 10291
		// (get) Token: 0x06008F0D RID: 36621 RVA: 0x0017A1B1 File Offset: 0x001783B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PGIMFOFDPGF.Descriptor;
			}
		}

		// Token: 0x06008F0E RID: 36622 RVA: 0x0017A1B8 File Offset: 0x001783B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGIMFOFDPGF()
		{
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x0017A1C0 File Offset: 0x001783C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGIMFOFDPGF(PGIMFOFDPGF other) : this()
		{
			this.gHEBOAMPNDN_ = other.gHEBOAMPNDN_;
			this.isMeet_ = other.isMeet_;
			this.dJLKCHKMNMI_ = other.dJLKCHKMNMI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x0017A1FD File Offset: 0x001783FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PGIMFOFDPGF Clone()
		{
			return new PGIMFOFDPGF(this);
		}

		// Token: 0x17002834 RID: 10292
		// (get) Token: 0x06008F11 RID: 36625 RVA: 0x0017A205 File Offset: 0x00178405
		// (set) Token: 0x06008F12 RID: 36626 RVA: 0x0017A20D File Offset: 0x0017840D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GHEBOAMPNDN
		{
			get
			{
				return this.gHEBOAMPNDN_;
			}
			set
			{
				this.gHEBOAMPNDN_ = value;
			}
		}

		// Token: 0x17002835 RID: 10293
		// (get) Token: 0x06008F13 RID: 36627 RVA: 0x0017A216 File Offset: 0x00178416
		// (set) Token: 0x06008F14 RID: 36628 RVA: 0x0017A21E File Offset: 0x0017841E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMeet
		{
			get
			{
				return this.isMeet_;
			}
			set
			{
				this.isMeet_ = value;
			}
		}

		// Token: 0x17002836 RID: 10294
		// (get) Token: 0x06008F15 RID: 36629 RVA: 0x0017A227 File Offset: 0x00178427
		// (set) Token: 0x06008F16 RID: 36630 RVA: 0x0017A22F File Offset: 0x0017842F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DJLKCHKMNMI
		{
			get
			{
				return this.dJLKCHKMNMI_;
			}
			set
			{
				this.dJLKCHKMNMI_ = value;
			}
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x0017A238 File Offset: 0x00178438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PGIMFOFDPGF);
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x0017A248 File Offset: 0x00178448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PGIMFOFDPGF other)
		{
			return other != null && (other == this || (this.GHEBOAMPNDN == other.GHEBOAMPNDN && this.IsMeet == other.IsMeet && this.DJLKCHKMNMI == other.DJLKCHKMNMI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x0017A2A4 File Offset: 0x001784A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GHEBOAMPNDN != 0U)
			{
				num ^= this.GHEBOAMPNDN.GetHashCode();
			}
			if (this.IsMeet)
			{
				num ^= this.IsMeet.GetHashCode();
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				num ^= this.DJLKCHKMNMI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x0017A315 File Offset: 0x00178515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x0017A31D File Offset: 0x0017851D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F1C RID: 36636 RVA: 0x0017A328 File Offset: 0x00178528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DJLKCHKMNMI != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.DJLKCHKMNMI);
			}
			if (this.GHEBOAMPNDN != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.GHEBOAMPNDN);
			}
			if (this.IsMeet)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsMeet);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x0017A3A0 File Offset: 0x001785A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GHEBOAMPNDN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GHEBOAMPNDN);
			}
			if (this.IsMeet)
			{
				num += 2;
			}
			if (this.DJLKCHKMNMI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DJLKCHKMNMI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x0017A404 File Offset: 0x00178604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PGIMFOFDPGF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GHEBOAMPNDN != 0U)
			{
				this.GHEBOAMPNDN = other.GHEBOAMPNDN;
			}
			if (other.IsMeet)
			{
				this.IsMeet = other.IsMeet;
			}
			if (other.DJLKCHKMNMI != 0U)
			{
				this.DJLKCHKMNMI = other.DJLKCHKMNMI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x0017A468 File Offset: 0x00178668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x0017A474 File Offset: 0x00178674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 80U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsMeet = input.ReadBool();
						}
					}
					else
					{
						this.GHEBOAMPNDN = input.ReadUInt32();
					}
				}
				else
				{
					this.DJLKCHKMNMI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040036F3 RID: 14067
		private static readonly MessageParser<PGIMFOFDPGF> _parser = new MessageParser<PGIMFOFDPGF>(() => new PGIMFOFDPGF());

		// Token: 0x040036F4 RID: 14068
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036F5 RID: 14069
		public const int GHEBOAMPNDNFieldNumber = 10;

		// Token: 0x040036F6 RID: 14070
		private uint gHEBOAMPNDN_;

		// Token: 0x040036F7 RID: 14071
		public const int IsMeetFieldNumber = 15;

		// Token: 0x040036F8 RID: 14072
		private bool isMeet_;

		// Token: 0x040036F9 RID: 14073
		public const int DJLKCHKMNMIFieldNumber = 7;

		// Token: 0x040036FA RID: 14074
		private uint dJLKCHKMNMI_;
	}
}
