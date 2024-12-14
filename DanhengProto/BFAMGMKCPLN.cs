using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000115 RID: 277
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BFAMGMKCPLN : IMessage<BFAMGMKCPLN>, IMessage, IEquatable<BFAMGMKCPLN>, IDeepCloneable<BFAMGMKCPLN>, IBufferMessage
	{
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00025B27 File Offset: 0x00023D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BFAMGMKCPLN> Parser
		{
			get
			{
				return BFAMGMKCPLN._parser;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00025B2E File Offset: 0x00023D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BFAMGMKCPLNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00025B40 File Offset: 0x00023D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BFAMGMKCPLN.Descriptor;
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x00025B47 File Offset: 0x00023D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFAMGMKCPLN()
		{
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00025B50 File Offset: 0x00023D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFAMGMKCPLN(BFAMGMKCPLN other) : this()
		{
			this.kLGMJMBIODB_ = ((other.kLGMJMBIODB_ != null) ? other.kLGMJMBIODB_.Clone() : null);
			this.oDAAHKFADPF_ = ((other.oDAAHKFADPF_ != null) ? other.oDAAHKFADPF_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x00025BAC File Offset: 0x00023DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BFAMGMKCPLN Clone()
		{
			return new BFAMGMKCPLN(this);
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C77 RID: 3191 RVA: 0x00025BB4 File Offset: 0x00023DB4
		// (set) Token: 0x06000C78 RID: 3192 RVA: 0x00025BBC File Offset: 0x00023DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECHKEPBCIOJ KLGMJMBIODB
		{
			get
			{
				return this.kLGMJMBIODB_;
			}
			set
			{
				this.kLGMJMBIODB_ = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C79 RID: 3193 RVA: 0x00025BC5 File Offset: 0x00023DC5
		// (set) Token: 0x06000C7A RID: 3194 RVA: 0x00025BCD File Offset: 0x00023DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LCCFLFOAKMI ODAAHKFADPF
		{
			get
			{
				return this.oDAAHKFADPF_;
			}
			set
			{
				this.oDAAHKFADPF_ = value;
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00025BD6 File Offset: 0x00023DD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BFAMGMKCPLN);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00025BE4 File Offset: 0x00023DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BFAMGMKCPLN other)
		{
			return other != null && (other == this || (object.Equals(this.KLGMJMBIODB, other.KLGMJMBIODB) && object.Equals(this.ODAAHKFADPF, other.ODAAHKFADPF) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00025C38 File Offset: 0x00023E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.kLGMJMBIODB_ != null)
			{
				num ^= this.KLGMJMBIODB.GetHashCode();
			}
			if (this.oDAAHKFADPF_ != null)
			{
				num ^= this.ODAAHKFADPF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00025C8A File Offset: 0x00023E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00025C92 File Offset: 0x00023E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00025C9C File Offset: 0x00023E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.oDAAHKFADPF_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.ODAAHKFADPF);
			}
			if (this.kLGMJMBIODB_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.KLGMJMBIODB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x00025CF8 File Offset: 0x00023EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.kLGMJMBIODB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KLGMJMBIODB);
			}
			if (this.oDAAHKFADPF_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ODAAHKFADPF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00025D50 File Offset: 0x00023F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BFAMGMKCPLN other)
		{
			if (other == null)
			{
				return;
			}
			if (other.kLGMJMBIODB_ != null)
			{
				if (this.kLGMJMBIODB_ == null)
				{
					this.KLGMJMBIODB = new ECHKEPBCIOJ();
				}
				this.KLGMJMBIODB.MergeFrom(other.KLGMJMBIODB);
			}
			if (other.oDAAHKFADPF_ != null)
			{
				if (this.oDAAHKFADPF_ == null)
				{
					this.ODAAHKFADPF = new LCCFLFOAKMI();
				}
				this.ODAAHKFADPF.MergeFrom(other.ODAAHKFADPF);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00025DD0 File Offset: 0x00023FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00025DDC File Offset: 0x00023FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.kLGMJMBIODB_ == null)
						{
							this.KLGMJMBIODB = new ECHKEPBCIOJ();
						}
						input.ReadMessage(this.KLGMJMBIODB);
					}
				}
				else
				{
					if (this.oDAAHKFADPF_ == null)
					{
						this.ODAAHKFADPF = new LCCFLFOAKMI();
					}
					input.ReadMessage(this.ODAAHKFADPF);
				}
			}
		}

		// Token: 0x04000576 RID: 1398
		private static readonly MessageParser<BFAMGMKCPLN> _parser = new MessageParser<BFAMGMKCPLN>(() => new BFAMGMKCPLN());

		// Token: 0x04000577 RID: 1399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000578 RID: 1400
		public const int KLGMJMBIODBFieldNumber = 11;

		// Token: 0x04000579 RID: 1401
		private ECHKEPBCIOJ kLGMJMBIODB_;

		// Token: 0x0400057A RID: 1402
		public const int ODAAHKFADPFFieldNumber = 8;

		// Token: 0x0400057B RID: 1403
		private LCCFLFOAKMI oDAAHKFADPF_;
	}
}
