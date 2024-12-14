using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000393 RID: 915
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DGPMABEJOMJ : IMessage<DGPMABEJOMJ>, IMessage, IEquatable<DGPMABEJOMJ>, IDeepCloneable<DGPMABEJOMJ>, IBufferMessage
	{
		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060028A2 RID: 10402 RVA: 0x00071100 File Offset: 0x0006F300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DGPMABEJOMJ> Parser
		{
			get
			{
				return DGPMABEJOMJ._parser;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x00071107 File Offset: 0x0006F307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DGPMABEJOMJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060028A4 RID: 10404 RVA: 0x00071119 File Offset: 0x0006F319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DGPMABEJOMJ.Descriptor;
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00071120 File Offset: 0x0006F320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DGPMABEJOMJ()
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00071128 File Offset: 0x0006F328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DGPMABEJOMJ(DGPMABEJOMJ other) : this()
		{
			this.mALKHNFHFAE_ = ((other.mALKHNFHFAE_ != null) ? other.mALKHNFHFAE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0007115D File Offset: 0x0006F35D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DGPMABEJOMJ Clone()
		{
			return new DGPMABEJOMJ(this);
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060028A8 RID: 10408 RVA: 0x00071165 File Offset: 0x0006F365
		// (set) Token: 0x060028A9 RID: 10409 RVA: 0x0007116D File Offset: 0x0006F36D
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

		// Token: 0x060028AA RID: 10410 RVA: 0x00071176 File Offset: 0x0006F376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DGPMABEJOMJ);
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x00071184 File Offset: 0x0006F384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DGPMABEJOMJ other)
		{
			return other != null && (other == this || (object.Equals(this.MALKHNFHFAE, other.MALKHNFHFAE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000711B8 File Offset: 0x0006F3B8
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

		// Token: 0x060028AD RID: 10413 RVA: 0x000711F4 File Offset: 0x0006F3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x000711FC File Offset: 0x0006F3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00071205 File Offset: 0x0006F405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.mALKHNFHFAE_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.MALKHNFHFAE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x00071238 File Offset: 0x0006F438
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

		// Token: 0x060028B1 RID: 10417 RVA: 0x00071278 File Offset: 0x0006F478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DGPMABEJOMJ other)
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

		// Token: 0x060028B2 RID: 10418 RVA: 0x000712CC File Offset: 0x0006F4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x000712D8 File Offset: 0x0006F4D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
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

		// Token: 0x04001066 RID: 4198
		private static readonly MessageParser<DGPMABEJOMJ> _parser = new MessageParser<DGPMABEJOMJ>(() => new DGPMABEJOMJ());

		// Token: 0x04001067 RID: 4199
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001068 RID: 4200
		public const int MALKHNFHFAEFieldNumber = 9;

		// Token: 0x04001069 RID: 4201
		private DPCAMGELHBP mALKHNFHFAE_;
	}
}
