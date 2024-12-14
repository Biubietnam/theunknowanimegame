using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C29 RID: 3113
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NOJPFGOHGKE : IMessage<NOJPFGOHGKE>, IMessage, IEquatable<NOJPFGOHGKE>, IDeepCloneable<NOJPFGOHGKE>, IBufferMessage
	{
		// Token: 0x170026B6 RID: 9910
		// (get) Token: 0x060089F1 RID: 35313 RVA: 0x0016C4FD File Offset: 0x0016A6FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NOJPFGOHGKE> Parser
		{
			get
			{
				return NOJPFGOHGKE._parser;
			}
		}

		// Token: 0x170026B7 RID: 9911
		// (get) Token: 0x060089F2 RID: 35314 RVA: 0x0016C504 File Offset: 0x0016A704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NOJPFGOHGKEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026B8 RID: 9912
		// (get) Token: 0x060089F3 RID: 35315 RVA: 0x0016C516 File Offset: 0x0016A716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NOJPFGOHGKE.Descriptor;
			}
		}

		// Token: 0x060089F4 RID: 35316 RVA: 0x0016C51D File Offset: 0x0016A71D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NOJPFGOHGKE()
		{
		}

		// Token: 0x060089F5 RID: 35317 RVA: 0x0016C525 File Offset: 0x0016A725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NOJPFGOHGKE(NOJPFGOHGKE other) : this()
		{
			this.value_ = other.value_;
			this.kDKBJACKELD_ = other.kDKBJACKELD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060089F6 RID: 35318 RVA: 0x0016C556 File Offset: 0x0016A756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NOJPFGOHGKE Clone()
		{
			return new NOJPFGOHGKE(this);
		}

		// Token: 0x170026B9 RID: 9913
		// (get) Token: 0x060089F7 RID: 35319 RVA: 0x0016C55E File Offset: 0x0016A75E
		// (set) Token: 0x060089F8 RID: 35320 RVA: 0x0016C566 File Offset: 0x0016A766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x170026BA RID: 9914
		// (get) Token: 0x060089F9 RID: 35321 RVA: 0x0016C56F File Offset: 0x0016A76F
		// (set) Token: 0x060089FA RID: 35322 RVA: 0x0016C577 File Offset: 0x0016A777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JPNAOEBBGHG KDKBJACKELD
		{
			get
			{
				return this.kDKBJACKELD_;
			}
			set
			{
				this.kDKBJACKELD_ = value;
			}
		}

		// Token: 0x060089FB RID: 35323 RVA: 0x0016C580 File Offset: 0x0016A780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NOJPFGOHGKE);
		}

		// Token: 0x060089FC RID: 35324 RVA: 0x0016C58E File Offset: 0x0016A78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NOJPFGOHGKE other)
		{
			return other != null && (other == this || (this.Value == other.Value && this.KDKBJACKELD == other.KDKBJACKELD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060089FD RID: 35325 RVA: 0x0016C5CC File Offset: 0x0016A7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Value != 0U)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				num ^= this.KDKBJACKELD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060089FE RID: 35326 RVA: 0x0016C62A File Offset: 0x0016A82A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060089FF RID: 35327 RVA: 0x0016C632 File Offset: 0x0016A832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A00 RID: 35328 RVA: 0x0016C63C File Offset: 0x0016A83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.KDKBJACKELD);
			}
			if (this.Value != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Value);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A01 RID: 35329 RVA: 0x0016C698 File Offset: 0x0016A898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Value != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Value);
			}
			if (this.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.KDKBJACKELD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A02 RID: 35330 RVA: 0x0016C6F0 File Offset: 0x0016A8F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NOJPFGOHGKE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Value != 0U)
			{
				this.Value = other.Value;
			}
			if (other.KDKBJACKELD != JPNAOEBBGHG.SwordTrainingStatusTypeNone)
			{
				this.KDKBJACKELD = other.KDKBJACKELD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A03 RID: 35331 RVA: 0x0016C740 File Offset: 0x0016A940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A04 RID: 35332 RVA: 0x0016C74C File Offset: 0x0016A94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Value = input.ReadUInt32();
					}
				}
				else
				{
					this.KDKBJACKELD = (JPNAOEBBGHG)input.ReadEnum();
				}
			}
		}

		// Token: 0x040034E9 RID: 13545
		private static readonly MessageParser<NOJPFGOHGKE> _parser = new MessageParser<NOJPFGOHGKE>(() => new NOJPFGOHGKE());

		// Token: 0x040034EA RID: 13546
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034EB RID: 13547
		public const int ValueFieldNumber = 13;

		// Token: 0x040034EC RID: 13548
		private uint value_;

		// Token: 0x040034ED RID: 13549
		public const int KDKBJACKELDFieldNumber = 8;

		// Token: 0x040034EE RID: 13550
		private JPNAOEBBGHG kDKBJACKELD_;
	}
}
