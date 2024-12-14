using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003CF RID: 975
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DPPBBCKLCBF : IMessage<DPPBBCKLCBF>, IMessage, IEquatable<DPPBBCKLCBF>, IDeepCloneable<DPPBBCKLCBF>, IBufferMessage
	{
		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x00078F6C File Offset: 0x0007716C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DPPBBCKLCBF> Parser
		{
			get
			{
				return DPPBBCKLCBF._parser;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x00078F73 File Offset: 0x00077173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DPPBBCKLCBFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06002B6A RID: 11114 RVA: 0x00078F85 File Offset: 0x00077185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DPPBBCKLCBF.Descriptor;
			}
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x00078F8C File Offset: 0x0007718C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPPBBCKLCBF()
		{
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x00078F94 File Offset: 0x00077194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPPBBCKLCBF(DPPBBCKLCBF other) : this()
		{
			this.jAFJMEHAEGH_ = other.jAFJMEHAEGH_;
			this.bJANMJOAAND_ = other.bJANMJOAAND_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x00078FC5 File Offset: 0x000771C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DPPBBCKLCBF Clone()
		{
			return new DPPBBCKLCBF(this);
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x00078FCD File Offset: 0x000771CD
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x00078FD5 File Offset: 0x000771D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JAFJMEHAEGH
		{
			get
			{
				return this.jAFJMEHAEGH_;
			}
			set
			{
				this.jAFJMEHAEGH_ = value;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x00078FDE File Offset: 0x000771DE
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x00078FE6 File Offset: 0x000771E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BJANMJOAAND
		{
			get
			{
				return this.bJANMJOAAND_;
			}
			set
			{
				this.bJANMJOAAND_ = value;
			}
		}

		// Token: 0x06002B72 RID: 11122 RVA: 0x00078FEF File Offset: 0x000771EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DPPBBCKLCBF);
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00078FFD File Offset: 0x000771FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DPPBBCKLCBF other)
		{
			return other != null && (other == this || (this.JAFJMEHAEGH == other.JAFJMEHAEGH && this.BJANMJOAAND == other.BJANMJOAAND && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x0007903C File Offset: 0x0007723C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JAFJMEHAEGH != 0U)
			{
				num ^= this.JAFJMEHAEGH.GetHashCode();
			}
			if (this.BJANMJOAAND != 0U)
			{
				num ^= this.BJANMJOAAND.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00079094 File Offset: 0x00077294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x0007909C File Offset: 0x0007729C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000790A8 File Offset: 0x000772A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.JAFJMEHAEGH != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.JAFJMEHAEGH);
			}
			if (this.BJANMJOAAND != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.BJANMJOAAND);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x00079104 File Offset: 0x00077304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JAFJMEHAEGH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JAFJMEHAEGH);
			}
			if (this.BJANMJOAAND != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BJANMJOAAND);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x0007915C File Offset: 0x0007735C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DPPBBCKLCBF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JAFJMEHAEGH != 0U)
			{
				this.JAFJMEHAEGH = other.JAFJMEHAEGH;
			}
			if (other.BJANMJOAAND != 0U)
			{
				this.BJANMJOAAND = other.BJANMJOAAND;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000791AC File Offset: 0x000773AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000791B8 File Offset: 0x000773B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BJANMJOAAND = input.ReadUInt32();
					}
				}
				else
				{
					this.JAFJMEHAEGH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400119E RID: 4510
		private static readonly MessageParser<DPPBBCKLCBF> _parser = new MessageParser<DPPBBCKLCBF>(() => new DPPBBCKLCBF());

		// Token: 0x0400119F RID: 4511
		private UnknownFieldSet _unknownFields;

		// Token: 0x040011A0 RID: 4512
		public const int JAFJMEHAEGHFieldNumber = 2;

		// Token: 0x040011A1 RID: 4513
		private uint jAFJMEHAEGH_;

		// Token: 0x040011A2 RID: 4514
		public const int BJANMJOAANDFieldNumber = 8;

		// Token: 0x040011A3 RID: 4515
		private uint bJANMJOAAND_;
	}
}
