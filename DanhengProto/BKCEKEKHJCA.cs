using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000129 RID: 297
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class BKCEKEKHJCA : IMessage<BKCEKEKHJCA>, IMessage, IEquatable<BKCEKEKHJCA>, IDeepCloneable<BKCEKEKHJCA>, IBufferMessage
	{
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x000282F0 File Offset: 0x000264F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BKCEKEKHJCA> Parser
		{
			get
			{
				return BKCEKEKHJCA._parser;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x000282F7 File Offset: 0x000264F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BKCEKEKHJCAReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D69 RID: 3433 RVA: 0x00028309 File Offset: 0x00026509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BKCEKEKHJCA.Descriptor;
			}
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00028310 File Offset: 0x00026510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BKCEKEKHJCA()
		{
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00028318 File Offset: 0x00026518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BKCEKEKHJCA(BKCEKEKHJCA other) : this()
		{
			this.lIHEADMDLHB_ = other.lIHEADMDLHB_;
			this.type_ = other.type_;
			this.dPKMFLIPHIG_ = other.dPKMFLIPHIG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00028355 File Offset: 0x00026555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BKCEKEKHJCA Clone()
		{
			return new BKCEKEKHJCA(this);
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D6D RID: 3437 RVA: 0x0002835D File Offset: 0x0002655D
		// (set) Token: 0x06000D6E RID: 3438 RVA: 0x00028365 File Offset: 0x00026565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LIHEADMDLHB
		{
			get
			{
				return this.lIHEADMDLHB_;
			}
			set
			{
				this.lIHEADMDLHB_ = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D6F RID: 3439 RVA: 0x0002836E File Offset: 0x0002656E
		// (set) Token: 0x06000D70 RID: 3440 RVA: 0x00028376 File Offset: 0x00026576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x0002837F File Offset: 0x0002657F
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00028387 File Offset: 0x00026587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DPKMFLIPHIG
		{
			get
			{
				return this.dPKMFLIPHIG_;
			}
			set
			{
				this.dPKMFLIPHIG_ = value;
			}
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00028390 File Offset: 0x00026590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BKCEKEKHJCA);
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x000283A0 File Offset: 0x000265A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BKCEKEKHJCA other)
		{
			return other != null && (other == this || (this.LIHEADMDLHB == other.LIHEADMDLHB && this.Type == other.Type && this.DPKMFLIPHIG == other.DPKMFLIPHIG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x000283FC File Offset: 0x000265FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LIHEADMDLHB != 0U)
			{
				num ^= this.LIHEADMDLHB.GetHashCode();
			}
			if (this.Type != 0U)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.DPKMFLIPHIG != 0U)
			{
				num ^= this.DPKMFLIPHIG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0002846D File Offset: 0x0002666D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00028475 File Offset: 0x00026675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00028480 File Offset: 0x00026680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LIHEADMDLHB != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.LIHEADMDLHB);
			}
			if (this.DPKMFLIPHIG != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.DPKMFLIPHIG);
			}
			if (this.Type != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Type);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x000284F8 File Offset: 0x000266F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LIHEADMDLHB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LIHEADMDLHB);
			}
			if (this.Type != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Type);
			}
			if (this.DPKMFLIPHIG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DPKMFLIPHIG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00028568 File Offset: 0x00026768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BKCEKEKHJCA other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LIHEADMDLHB != 0U)
			{
				this.LIHEADMDLHB = other.LIHEADMDLHB;
			}
			if (other.Type != 0U)
			{
				this.Type = other.Type;
			}
			if (other.DPKMFLIPHIG != 0U)
			{
				this.DPKMFLIPHIG = other.DPKMFLIPHIG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x000285CC File Offset: 0x000267CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000285D8 File Offset: 0x000267D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Type = input.ReadUInt32();
						}
					}
					else
					{
						this.DPKMFLIPHIG = input.ReadUInt32();
					}
				}
				else
				{
					this.LIHEADMDLHB = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040005D0 RID: 1488
		private static readonly MessageParser<BKCEKEKHJCA> _parser = new MessageParser<BKCEKEKHJCA>(() => new BKCEKEKHJCA());

		// Token: 0x040005D1 RID: 1489
		private UnknownFieldSet _unknownFields;

		// Token: 0x040005D2 RID: 1490
		public const int LIHEADMDLHBFieldNumber = 5;

		// Token: 0x040005D3 RID: 1491
		private uint lIHEADMDLHB_;

		// Token: 0x040005D4 RID: 1492
		public const int TypeFieldNumber = 12;

		// Token: 0x040005D5 RID: 1493
		private uint type_;

		// Token: 0x040005D6 RID: 1494
		public const int DPKMFLIPHIGFieldNumber = 8;

		// Token: 0x040005D7 RID: 1495
		private uint dPKMFLIPHIG_;
	}
}
