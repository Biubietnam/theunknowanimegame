using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200040B RID: 1035
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ELBENNKHNLC : IMessage<ELBENNKHNLC>, IMessage, IEquatable<ELBENNKHNLC>, IDeepCloneable<ELBENNKHNLC>, IBufferMessage
	{
		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002DEC RID: 11756 RVA: 0x0007EF68 File Offset: 0x0007D168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ELBENNKHNLC> Parser
		{
			get
			{
				return ELBENNKHNLC._parser;
			}
		}

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x0007EF6F File Offset: 0x0007D16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ELBENNKHNLCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x0007EF81 File Offset: 0x0007D181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ELBENNKHNLC.Descriptor;
			}
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x0007EF88 File Offset: 0x0007D188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELBENNKHNLC()
		{
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x0007EF90 File Offset: 0x0007D190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELBENNKHNLC(ELBENNKHNLC other) : this()
		{
			this.mALKHNFHFAE_ = ((other.mALKHNFHFAE_ != null) ? other.mALKHNFHFAE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x0007EFC5 File Offset: 0x0007D1C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ELBENNKHNLC Clone()
		{
			return new ELBENNKHNLC(this);
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x0007EFCD File Offset: 0x0007D1CD
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x0007EFD5 File Offset: 0x0007D1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPCAMGELHBP MALKHNFHFAE
		{
			get
			{
				return this.mALKHNFHFAE_;
			}
			set
			{
				this.mALKHNFHFAE_ = value;
			}
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x0007EFDE File Offset: 0x0007D1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ELBENNKHNLC);
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x0007EFEC File Offset: 0x0007D1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ELBENNKHNLC other)
		{
			return other != null && (other == this || (object.Equals(this.MALKHNFHFAE, other.MALKHNFHFAE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x0007F020 File Offset: 0x0007D220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.mALKHNFHFAE_ != null)
			{
				num ^= this.MALKHNFHFAE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x0007F05C File Offset: 0x0007D25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x0007F064 File Offset: 0x0007D264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x0007F06D File Offset: 0x0007D26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mALKHNFHFAE_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x0007F0A0 File Offset: 0x0007D2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.mALKHNFHFAE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x0007F0E0 File Offset: 0x0007D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ELBENNKHNLC other)
		{
			if (other == null)
			{
				return;
			}
			if (other.mALKHNFHFAE_ != null)
			{
				if (this.mALKHNFHFAE_ == null)
				{
					this.MALKHNFHFAE = new DPCAMGELHBP();
				}
				this.MALKHNFHFAE.MergeFrom(other.MALKHNFHFAE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x0007F134 File Offset: 0x0007D334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x0007F140 File Offset: 0x0007D340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.mALKHNFHFAE_ == null)
					{
						this.MALKHNFHFAE = new DPCAMGELHBP();
					}
					input.ReadMessage(this.MALKHNFHFAE);
				}
			}
		}

		// Token: 0x04001277 RID: 4727
		private static readonly MessageParser<ELBENNKHNLC> _parser = new MessageParser<ELBENNKHNLC>(() => new ELBENNKHNLC());

		// Token: 0x04001278 RID: 4728
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001279 RID: 4729
		public const int MALKHNFHFAEFieldNumber = 11;

		// Token: 0x0400127A RID: 4730
		private DPCAMGELHBP mALKHNFHFAE_;
	}
}
