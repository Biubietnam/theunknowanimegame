using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002CF RID: 719
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CKIDOMIINKI : IMessage<CKIDOMIINKI>, IMessage, IEquatable<CKIDOMIINKI>, IDeepCloneable<CKIDOMIINKI>, IBufferMessage
	{
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0005B264 File Offset: 0x00059464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CKIDOMIINKI> Parser
		{
			get
			{
				return CKIDOMIINKI._parser;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x0005B26B File Offset: 0x0005946B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CKIDOMIINKIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0005B27D File Offset: 0x0005947D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CKIDOMIINKI.Descriptor;
			}
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0005B284 File Offset: 0x00059484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKIDOMIINKI()
		{
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0005B28C File Offset: 0x0005948C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKIDOMIINKI(CKIDOMIINKI other) : this()
		{
			this.aLBODJPHAEI_ = other.aLBODJPHAEI_;
			this.bDMJJPCHNEL_ = other.bDMJJPCHNEL_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0005B2BD File Offset: 0x000594BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CKIDOMIINKI Clone()
		{
			return new CKIDOMIINKI(this);
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x0005B2C5 File Offset: 0x000594C5
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x0005B2CD File Offset: 0x000594CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ALBODJPHAEI
		{
			get
			{
				return this.aLBODJPHAEI_;
			}
			set
			{
				this.aLBODJPHAEI_ = value;
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0005B2D6 File Offset: 0x000594D6
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x0005B2DE File Offset: 0x000594DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BDMJJPCHNEL
		{
			get
			{
				return this.bDMJJPCHNEL_;
			}
			set
			{
				this.bDMJJPCHNEL_ = value;
			}
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0005B2E7 File Offset: 0x000594E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CKIDOMIINKI);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0005B2F5 File Offset: 0x000594F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CKIDOMIINKI other)
		{
			return other != null && (other == this || (this.ALBODJPHAEI == other.ALBODJPHAEI && this.BDMJJPCHNEL == other.BDMJJPCHNEL && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0005B334 File Offset: 0x00059534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ALBODJPHAEI != 0U)
			{
				num ^= this.ALBODJPHAEI.GetHashCode();
			}
			if (this.BDMJJPCHNEL != 0U)
			{
				num ^= this.BDMJJPCHNEL.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0005B38C File Offset: 0x0005958C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0005B394 File Offset: 0x00059594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0005B3A0 File Offset: 0x000595A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BDMJJPCHNEL != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.BDMJJPCHNEL);
			}
			if (this.ALBODJPHAEI != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.ALBODJPHAEI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0005B3FC File Offset: 0x000595FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ALBODJPHAEI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ALBODJPHAEI);
			}
			if (this.BDMJJPCHNEL != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BDMJJPCHNEL);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0005B454 File Offset: 0x00059654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CKIDOMIINKI other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ALBODJPHAEI != 0U)
			{
				this.ALBODJPHAEI = other.ALBODJPHAEI;
			}
			if (other.BDMJJPCHNEL != 0U)
			{
				this.BDMJJPCHNEL = other.BDMJJPCHNEL;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0005B4A4 File Offset: 0x000596A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0005B4B0 File Offset: 0x000596B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ALBODJPHAEI = input.ReadUInt32();
					}
				}
				else
				{
					this.BDMJJPCHNEL = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D42 RID: 3394
		private static readonly MessageParser<CKIDOMIINKI> _parser = new MessageParser<CKIDOMIINKI>(() => new CKIDOMIINKI());

		// Token: 0x04000D43 RID: 3395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D44 RID: 3396
		public const int ALBODJPHAEIFieldNumber = 5;

		// Token: 0x04000D45 RID: 3397
		private uint aLBODJPHAEI_;

		// Token: 0x04000D46 RID: 3398
		public const int BDMJJPCHNELFieldNumber = 4;

		// Token: 0x04000D47 RID: 3399
		private uint bDMJJPCHNEL_;
	}
}
