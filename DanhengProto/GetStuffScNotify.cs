using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000815 RID: 2069
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStuffScNotify : IMessage<GetStuffScNotify>, IMessage, IEquatable<GetStuffScNotify>, IDeepCloneable<GetStuffScNotify>, IBufferMessage
	{
		// Token: 0x170019F4 RID: 6644
		// (get) Token: 0x06005C38 RID: 23608 RVA: 0x000F523D File Offset: 0x000F343D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStuffScNotify> Parser
		{
			get
			{
				return GetStuffScNotify._parser;
			}
		}

		// Token: 0x170019F5 RID: 6645
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x000F5244 File Offset: 0x000F3444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStuffScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019F6 RID: 6646
		// (get) Token: 0x06005C3A RID: 23610 RVA: 0x000F5256 File Offset: 0x000F3456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStuffScNotify.Descriptor;
			}
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x000F525D File Offset: 0x000F345D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStuffScNotify()
		{
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x000F5265 File Offset: 0x000F3465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStuffScNotify(GetStuffScNotify other) : this()
		{
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this.cCPAJJMFEKC_ = other.cCPAJJMFEKC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C3D RID: 23613 RVA: 0x000F5296 File Offset: 0x000F3496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStuffScNotify Clone()
		{
			return new GetStuffScNotify(this);
		}

		// Token: 0x170019F7 RID: 6647
		// (get) Token: 0x06005C3E RID: 23614 RVA: 0x000F529E File Offset: 0x000F349E
		// (set) Token: 0x06005C3F RID: 23615 RVA: 0x000F52A6 File Offset: 0x000F34A6
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

		// Token: 0x170019F8 RID: 6648
		// (get) Token: 0x06005C40 RID: 23616 RVA: 0x000F52AF File Offset: 0x000F34AF
		// (set) Token: 0x06005C41 RID: 23617 RVA: 0x000F52B7 File Offset: 0x000F34B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStuffType CCPAJJMFEKC
		{
			get
			{
				return this.cCPAJJMFEKC_;
			}
			set
			{
				this.cCPAJJMFEKC_ = value;
			}
		}

		// Token: 0x06005C42 RID: 23618 RVA: 0x000F52C0 File Offset: 0x000F34C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStuffScNotify);
		}

		// Token: 0x06005C43 RID: 23619 RVA: 0x000F52CE File Offset: 0x000F34CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStuffScNotify other)
		{
			return other != null && (other == this || (this.POEDFMELAKE == other.POEDFMELAKE && this.CCPAJJMFEKC == other.CCPAJJMFEKC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C44 RID: 23620 RVA: 0x000F530C File Offset: 0x000F350C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this.CCPAJJMFEKC != GetStuffType.Unknow)
			{
				num ^= this.CCPAJJMFEKC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C45 RID: 23621 RVA: 0x000F536A File Offset: 0x000F356A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C46 RID: 23622 RVA: 0x000F5372 File Offset: 0x000F3572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C47 RID: 23623 RVA: 0x000F537C File Offset: 0x000F357C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this.CCPAJJMFEKC != GetStuffType.Unknow)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.CCPAJJMFEKC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C48 RID: 23624 RVA: 0x000F53D8 File Offset: 0x000F35D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this.CCPAJJMFEKC != GetStuffType.Unknow)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CCPAJJMFEKC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C49 RID: 23625 RVA: 0x000F5430 File Offset: 0x000F3630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStuffScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			if (other.CCPAJJMFEKC != GetStuffType.Unknow)
			{
				this.CCPAJJMFEKC = other.CCPAJJMFEKC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C4A RID: 23626 RVA: 0x000F5480 File Offset: 0x000F3680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C4B RID: 23627 RVA: 0x000F548C File Offset: 0x000F368C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CCPAJJMFEKC = (GetStuffType)input.ReadEnum();
					}
				}
				else
				{
					this.POEDFMELAKE = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040023A6 RID: 9126
		private static readonly MessageParser<GetStuffScNotify> _parser = new MessageParser<GetStuffScNotify>(() => new GetStuffScNotify());

		// Token: 0x040023A7 RID: 9127
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A8 RID: 9128
		public const int POEDFMELAKEFieldNumber = 6;

		// Token: 0x040023A9 RID: 9129
		private uint pOEDFMELAKE_;

		// Token: 0x040023AA RID: 9130
		public const int CCPAJJMFEKCFieldNumber = 10;

		// Token: 0x040023AB RID: 9131
		private GetStuffType cCPAJJMFEKC_;
	}
}
