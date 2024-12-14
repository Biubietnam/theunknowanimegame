using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200014F RID: 335
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BuyNpcStuffCsReq : IMessage<BuyNpcStuffCsReq>, IMessage, IEquatable<BuyNpcStuffCsReq>, IDeepCloneable<BuyNpcStuffCsReq>, IBufferMessage
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000EFA RID: 3834 RVA: 0x0002C574 File Offset: 0x0002A774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BuyNpcStuffCsReq> Parser
		{
			get
			{
				return BuyNpcStuffCsReq._parser;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x0002C57B File Offset: 0x0002A77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BuyNpcStuffCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000EFC RID: 3836 RVA: 0x0002C58D File Offset: 0x0002A78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BuyNpcStuffCsReq.Descriptor;
			}
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x0002C594 File Offset: 0x0002A794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyNpcStuffCsReq()
		{
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x0002C59C File Offset: 0x0002A79C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyNpcStuffCsReq(BuyNpcStuffCsReq other) : this()
		{
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x0002C5C1 File Offset: 0x0002A7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuyNpcStuffCsReq Clone()
		{
			return new BuyNpcStuffCsReq(this);
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x0002C5C9 File Offset: 0x0002A7C9
		// (set) Token: 0x06000F01 RID: 3841 RVA: 0x0002C5D1 File Offset: 0x0002A7D1
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

		// Token: 0x06000F02 RID: 3842 RVA: 0x0002C5DA File Offset: 0x0002A7DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BuyNpcStuffCsReq);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x0002C5E8 File Offset: 0x0002A7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BuyNpcStuffCsReq other)
		{
			return other != null && (other == this || (this.POEDFMELAKE == other.POEDFMELAKE && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x0002C618 File Offset: 0x0002A818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06000F05 RID: 3845 RVA: 0x0002C657 File Offset: 0x0002A857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x0002C65F File Offset: 0x0002A85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x0002C668 File Offset: 0x0002A868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0002C69C File Offset: 0x0002A89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06000F09 RID: 3849 RVA: 0x0002C6DA File Offset: 0x0002A8DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BuyNpcStuffCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x0002C70B File Offset: 0x0002A90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x0002C714 File Offset: 0x0002A914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.POEDFMELAKE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400067A RID: 1658
		private static readonly MessageParser<BuyNpcStuffCsReq> _parser = new MessageParser<BuyNpcStuffCsReq>(() => new BuyNpcStuffCsReq());

		// Token: 0x0400067B RID: 1659
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400067C RID: 1660
		public const int POEDFMELAKEFieldNumber = 3;

		// Token: 0x0400067D RID: 1661
		private uint pOEDFMELAKE_;
	}
}
