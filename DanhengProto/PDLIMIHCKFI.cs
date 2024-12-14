using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C87 RID: 3207
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PDLIMIHCKFI : IMessage<PDLIMIHCKFI>, IMessage, IEquatable<PDLIMIHCKFI>, IDeepCloneable<PDLIMIHCKFI>, IBufferMessage
	{
		// Token: 0x1700280E RID: 10254
		// (get) Token: 0x06008E90 RID: 36496 RVA: 0x00178CE9 File Offset: 0x00176EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PDLIMIHCKFI> Parser
		{
			get
			{
				return PDLIMIHCKFI._parser;
			}
		}

		// Token: 0x1700280F RID: 10255
		// (get) Token: 0x06008E91 RID: 36497 RVA: 0x00178CF0 File Offset: 0x00176EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PDLIMIHCKFIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002810 RID: 10256
		// (get) Token: 0x06008E92 RID: 36498 RVA: 0x00178D02 File Offset: 0x00176F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PDLIMIHCKFI.Descriptor;
			}
		}

		// Token: 0x06008E93 RID: 36499 RVA: 0x00178D09 File Offset: 0x00176F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDLIMIHCKFI()
		{
		}

		// Token: 0x06008E94 RID: 36500 RVA: 0x00178D11 File Offset: 0x00176F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDLIMIHCKFI(PDLIMIHCKFI other) : this()
		{
			this.pLFPJDMGBBN_ = other.pLFPJDMGBBN_;
			this.hAJMIFLNBHC_ = other.hAJMIFLNBHC_;
			this.gGGBCAGNBFE_ = other.gGGBCAGNBFE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x00178D4E File Offset: 0x00176F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PDLIMIHCKFI Clone()
		{
			return new PDLIMIHCKFI(this);
		}

		// Token: 0x17002811 RID: 10257
		// (get) Token: 0x06008E96 RID: 36502 RVA: 0x00178D56 File Offset: 0x00176F56
		// (set) Token: 0x06008E97 RID: 36503 RVA: 0x00178D5E File Offset: 0x00176F5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PLFPJDMGBBN
		{
			get
			{
				return this.pLFPJDMGBBN_;
			}
			set
			{
				this.pLFPJDMGBBN_ = value;
			}
		}

		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x06008E98 RID: 36504 RVA: 0x00178D67 File Offset: 0x00176F67
		// (set) Token: 0x06008E99 RID: 36505 RVA: 0x00178D6F File Offset: 0x00176F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HAJMIFLNBHC
		{
			get
			{
				return this.hAJMIFLNBHC_;
			}
			set
			{
				this.hAJMIFLNBHC_ = value;
			}
		}

		// Token: 0x17002813 RID: 10259
		// (get) Token: 0x06008E9A RID: 36506 RVA: 0x00178D78 File Offset: 0x00176F78
		// (set) Token: 0x06008E9B RID: 36507 RVA: 0x00178D80 File Offset: 0x00176F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GGGBCAGNBFE
		{
			get
			{
				return this.gGGBCAGNBFE_;
			}
			set
			{
				this.gGGBCAGNBFE_ = value;
			}
		}

		// Token: 0x06008E9C RID: 36508 RVA: 0x00178D89 File Offset: 0x00176F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PDLIMIHCKFI);
		}

		// Token: 0x06008E9D RID: 36509 RVA: 0x00178D98 File Offset: 0x00176F98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PDLIMIHCKFI other)
		{
			return other != null && (other == this || (this.PLFPJDMGBBN == other.PLFPJDMGBBN && this.HAJMIFLNBHC == other.HAJMIFLNBHC && this.GGGBCAGNBFE == other.GGGBCAGNBFE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E9E RID: 36510 RVA: 0x00178DF4 File Offset: 0x00176FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PLFPJDMGBBN)
			{
				num ^= this.PLFPJDMGBBN.GetHashCode();
			}
			if (this.HAJMIFLNBHC != 0U)
			{
				num ^= this.HAJMIFLNBHC.GetHashCode();
			}
			if (this.GGGBCAGNBFE != 0U)
			{
				num ^= this.GGGBCAGNBFE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008E9F RID: 36511 RVA: 0x00178E65 File Offset: 0x00177065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008EA0 RID: 36512 RVA: 0x00178E6D File Offset: 0x0017706D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EA1 RID: 36513 RVA: 0x00178E78 File Offset: 0x00177078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HAJMIFLNBHC != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.HAJMIFLNBHC);
			}
			if (this.PLFPJDMGBBN)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.PLFPJDMGBBN);
			}
			if (this.GGGBCAGNBFE != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GGGBCAGNBFE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x00178EF0 File Offset: 0x001770F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PLFPJDMGBBN)
			{
				num += 2;
			}
			if (this.HAJMIFLNBHC != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HAJMIFLNBHC);
			}
			if (this.GGGBCAGNBFE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GGGBCAGNBFE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EA3 RID: 36515 RVA: 0x00178F54 File Offset: 0x00177154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PDLIMIHCKFI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PLFPJDMGBBN)
			{
				this.PLFPJDMGBBN = other.PLFPJDMGBBN;
			}
			if (other.HAJMIFLNBHC != 0U)
			{
				this.HAJMIFLNBHC = other.HAJMIFLNBHC;
			}
			if (other.GGGBCAGNBFE != 0U)
			{
				this.GGGBCAGNBFE = other.GGGBCAGNBFE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x00178FB8 File Offset: 0x001771B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x00178FC4 File Offset: 0x001771C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GGGBCAGNBFE = input.ReadUInt32();
						}
					}
					else
					{
						this.PLFPJDMGBBN = input.ReadBool();
					}
				}
				else
				{
					this.HAJMIFLNBHC = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040036C4 RID: 14020
		private static readonly MessageParser<PDLIMIHCKFI> _parser = new MessageParser<PDLIMIHCKFI>(() => new PDLIMIHCKFI());

		// Token: 0x040036C5 RID: 14021
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036C6 RID: 14022
		public const int PLFPJDMGBBNFieldNumber = 12;

		// Token: 0x040036C7 RID: 14023
		private bool pLFPJDMGBBN_;

		// Token: 0x040036C8 RID: 14024
		public const int HAJMIFLNBHCFieldNumber = 2;

		// Token: 0x040036C9 RID: 14025
		private uint hAJMIFLNBHC_;

		// Token: 0x040036CA RID: 14026
		public const int GGGBCAGNBFEFieldNumber = 15;

		// Token: 0x040036CB RID: 14027
		private uint gGGBCAGNBFE_;
	}
}
