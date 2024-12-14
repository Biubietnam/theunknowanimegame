using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000917 RID: 2327
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IDELAMMCOII : IMessage<IDELAMMCOII>, IMessage, IEquatable<IDELAMMCOII>, IDeepCloneable<IDELAMMCOII>, IBufferMessage
	{
		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x060067CA RID: 26570 RVA: 0x00115618 File Offset: 0x00113818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IDELAMMCOII> Parser
		{
			get
			{
				return IDELAMMCOII._parser;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x060067CB RID: 26571 RVA: 0x0011561F File Offset: 0x0011381F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IDELAMMCOIIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x060067CC RID: 26572 RVA: 0x00115631 File Offset: 0x00113831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IDELAMMCOII.Descriptor;
			}
		}

		// Token: 0x060067CD RID: 26573 RVA: 0x00115638 File Offset: 0x00113838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDELAMMCOII()
		{
		}

		// Token: 0x060067CE RID: 26574 RVA: 0x00115640 File Offset: 0x00113840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDELAMMCOII(IDELAMMCOII other) : this()
		{
			this.mALKHNFHFAE_ = ((other.mALKHNFHFAE_ != null) ? other.mALKHNFHFAE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067CF RID: 26575 RVA: 0x00115675 File Offset: 0x00113875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IDELAMMCOII Clone()
		{
			return new IDELAMMCOII(this);
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x060067D0 RID: 26576 RVA: 0x0011567D File Offset: 0x0011387D
		// (set) Token: 0x060067D1 RID: 26577 RVA: 0x00115685 File Offset: 0x00113885
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

		// Token: 0x060067D2 RID: 26578 RVA: 0x0011568E File Offset: 0x0011388E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IDELAMMCOII);
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x0011569C File Offset: 0x0011389C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IDELAMMCOII other)
		{
			return other != null && (other == this || (object.Equals(this.MALKHNFHFAE, other.MALKHNFHFAE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x001156D0 File Offset: 0x001138D0
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

		// Token: 0x060067D5 RID: 26581 RVA: 0x0011570C File Offset: 0x0011390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x00115714 File Offset: 0x00113914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x0011571D File Offset: 0x0011391D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mALKHNFHFAE_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x00115750 File Offset: 0x00113950
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

		// Token: 0x060067D9 RID: 26585 RVA: 0x00115790 File Offset: 0x00113990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IDELAMMCOII other)
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

		// Token: 0x060067DA RID: 26586 RVA: 0x001157E4 File Offset: 0x001139E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067DB RID: 26587 RVA: 0x001157F0 File Offset: 0x001139F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
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

		// Token: 0x040027DE RID: 10206
		private static readonly MessageParser<IDELAMMCOII> _parser = new MessageParser<IDELAMMCOII>(() => new IDELAMMCOII());

		// Token: 0x040027DF RID: 10207
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027E0 RID: 10208
		public const int MALKHNFHFAEFieldNumber = 5;

		// Token: 0x040027E1 RID: 10209
		private DPCAMGELHBP mALKHNFHFAE_;
	}
}
