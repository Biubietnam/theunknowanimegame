using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AB5 RID: 2741
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MBGFFCELGHO : IMessage<MBGFFCELGHO>, IMessage, IEquatable<MBGFFCELGHO>, IDeepCloneable<MBGFFCELGHO>, IBufferMessage
	{
		// Token: 0x17002222 RID: 8738
		// (get) Token: 0x0600798D RID: 31117 RVA: 0x00142274 File Offset: 0x00140474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MBGFFCELGHO> Parser
		{
			get
			{
				return MBGFFCELGHO._parser;
			}
		}

		// Token: 0x17002223 RID: 8739
		// (get) Token: 0x0600798E RID: 31118 RVA: 0x0014227B File Offset: 0x0014047B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MBGFFCELGHOReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002224 RID: 8740
		// (get) Token: 0x0600798F RID: 31119 RVA: 0x0014228D File Offset: 0x0014048D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MBGFFCELGHO.Descriptor;
			}
		}

		// Token: 0x06007990 RID: 31120 RVA: 0x00142294 File Offset: 0x00140494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBGFFCELGHO()
		{
		}

		// Token: 0x06007991 RID: 31121 RVA: 0x0014229C File Offset: 0x0014049C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBGFFCELGHO(MBGFFCELGHO other) : this()
		{
			this.nOJOJKCJEOI_ = other.nOJOJKCJEOI_;
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007992 RID: 31122 RVA: 0x001422CD File Offset: 0x001404CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MBGFFCELGHO Clone()
		{
			return new MBGFFCELGHO(this);
		}

		// Token: 0x17002225 RID: 8741
		// (get) Token: 0x06007993 RID: 31123 RVA: 0x001422D5 File Offset: 0x001404D5
		// (set) Token: 0x06007994 RID: 31124 RVA: 0x001422DD File Offset: 0x001404DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NOJOJKCJEOI
		{
			get
			{
				return this.nOJOJKCJEOI_;
			}
			set
			{
				this.nOJOJKCJEOI_ = value;
			}
		}

		// Token: 0x17002226 RID: 8742
		// (get) Token: 0x06007995 RID: 31125 RVA: 0x001422E6 File Offset: 0x001404E6
		// (set) Token: 0x06007996 RID: 31126 RVA: 0x001422EE File Offset: 0x001404EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x001422F7 File Offset: 0x001404F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MBGFFCELGHO);
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x00142305 File Offset: 0x00140505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MBGFFCELGHO other)
		{
			return other != null && (other == this || (this.NOJOJKCJEOI == other.NOJOJKCJEOI && this.POEDFMELAKE == other.POEDFMELAKE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007999 RID: 31129 RVA: 0x00142344 File Offset: 0x00140544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NOJOJKCJEOI != 0U)
			{
				num ^= this.NOJOJKCJEOI.GetHashCode();
			}
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600799A RID: 31130 RVA: 0x0014239C File Offset: 0x0014059C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600799B RID: 31131 RVA: 0x001423A4 File Offset: 0x001405A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600799C RID: 31132 RVA: 0x001423B0 File Offset: 0x001405B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this.NOJOJKCJEOI != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.NOJOJKCJEOI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600799D RID: 31133 RVA: 0x0014240C File Offset: 0x0014060C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NOJOJKCJEOI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NOJOJKCJEOI);
			}
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600799E RID: 31134 RVA: 0x00142464 File Offset: 0x00140664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MBGFFCELGHO other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NOJOJKCJEOI != 0U)
			{
				this.NOJOJKCJEOI = other.NOJOJKCJEOI;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600799F RID: 31135 RVA: 0x001424B4 File Offset: 0x001406B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060079A0 RID: 31136 RVA: 0x001424C0 File Offset: 0x001406C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NOJOJKCJEOI = input.ReadUInt32();
					}
				}
				else
				{
					this.POEDFMELAKE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002EAA RID: 11946
		private static readonly MessageParser<MBGFFCELGHO> _parser = new MessageParser<MBGFFCELGHO>(() => new MBGFFCELGHO());

		// Token: 0x04002EAB RID: 11947
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EAC RID: 11948
		public const int NOJOJKCJEOIFieldNumber = 14;

		// Token: 0x04002EAD RID: 11949
		private uint nOJOJKCJEOI_;

		// Token: 0x04002EAE RID: 11950
		public const int POEDFMELAKEFieldNumber = 4;

		// Token: 0x04002EAF RID: 11951
		private uint pOEDFMELAKE_;
	}
}
