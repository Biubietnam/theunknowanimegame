using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AF5 RID: 2805
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MKGIECKGJEP : IMessage<MKGIECKGJEP>, IMessage, IEquatable<MKGIECKGJEP>, IDeepCloneable<MKGIECKGJEP>, IBufferMessage
	{
		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x06007C17 RID: 31767 RVA: 0x00148A21 File Offset: 0x00146C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MKGIECKGJEP> Parser
		{
			get
			{
				return MKGIECKGJEP._parser;
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x06007C18 RID: 31768 RVA: 0x00148A28 File Offset: 0x00146C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MKGIECKGJEPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x06007C19 RID: 31769 RVA: 0x00148A3A File Offset: 0x00146C3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MKGIECKGJEP.Descriptor;
			}
		}

		// Token: 0x06007C1A RID: 31770 RVA: 0x00148A41 File Offset: 0x00146C41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKGIECKGJEP()
		{
		}

		// Token: 0x06007C1B RID: 31771 RVA: 0x00148A4C File Offset: 0x00146C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKGIECKGJEP(MKGIECKGJEP other) : this()
		{
			this.wave_ = other.wave_;
			this.eCAGLELIOBN_ = other.eCAGLELIOBN_;
			this.mMEOFONFOLP_ = other.mMEOFONFOLP_;
			this.aDPPOPDFHPK_ = other.aDPPOPDFHPK_;
			this.lGKAIBKLJKG_ = other.lGKAIBKLJKG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007C1C RID: 31772 RVA: 0x00148AAC File Offset: 0x00146CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MKGIECKGJEP Clone()
		{
			return new MKGIECKGJEP(this);
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x06007C1D RID: 31773 RVA: 0x00148AB4 File Offset: 0x00146CB4
		// (set) Token: 0x06007C1E RID: 31774 RVA: 0x00148ABC File Offset: 0x00146CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Wave
		{
			get
			{
				return this.wave_;
			}
			set
			{
				this.wave_ = value;
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x06007C1F RID: 31775 RVA: 0x00148AC5 File Offset: 0x00146CC5
		// (set) Token: 0x06007C20 RID: 31776 RVA: 0x00148ACD File Offset: 0x00146CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double ECAGLELIOBN
		{
			get
			{
				return this.eCAGLELIOBN_;
			}
			set
			{
				this.eCAGLELIOBN_ = value;
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x06007C21 RID: 31777 RVA: 0x00148AD6 File Offset: 0x00146CD6
		// (set) Token: 0x06007C22 RID: 31778 RVA: 0x00148ADE File Offset: 0x00146CDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double MMEOFONFOLP
		{
			get
			{
				return this.mMEOFONFOLP_;
			}
			set
			{
				this.mMEOFONFOLP_ = value;
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x06007C23 RID: 31779 RVA: 0x00148AE7 File Offset: 0x00146CE7
		// (set) Token: 0x06007C24 RID: 31780 RVA: 0x00148AEF File Offset: 0x00146CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ADPPOPDFHPK
		{
			get
			{
				return this.aDPPOPDFHPK_;
			}
			set
			{
				this.aDPPOPDFHPK_ = value;
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x06007C25 RID: 31781 RVA: 0x00148AF8 File Offset: 0x00146CF8
		// (set) Token: 0x06007C26 RID: 31782 RVA: 0x00148B00 File Offset: 0x00146D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LGKAIBKLJKG
		{
			get
			{
				return this.lGKAIBKLJKG_;
			}
			set
			{
				this.lGKAIBKLJKG_ = value;
			}
		}

		// Token: 0x06007C27 RID: 31783 RVA: 0x00148B09 File Offset: 0x00146D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MKGIECKGJEP);
		}

		// Token: 0x06007C28 RID: 31784 RVA: 0x00148B18 File Offset: 0x00146D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MKGIECKGJEP other)
		{
			return other != null && (other == this || (this.Wave == other.Wave && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.ECAGLELIOBN, other.ECAGLELIOBN) && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.MMEOFONFOLP, other.MMEOFONFOLP) && this.ADPPOPDFHPK == other.ADPPOPDFHPK && this.LGKAIBKLJKG == other.LGKAIBKLJKG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C29 RID: 31785 RVA: 0x00148BA8 File Offset: 0x00146DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.ECAGLELIOBN != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.ECAGLELIOBN);
			}
			if (this.MMEOFONFOLP != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.MMEOFONFOLP);
			}
			if (this.ADPPOPDFHPK != 0U)
			{
				num ^= this.ADPPOPDFHPK.GetHashCode();
			}
			if (this.LGKAIBKLJKG != 0U)
			{
				num ^= this.LGKAIBKLJKG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007C2A RID: 31786 RVA: 0x00148C61 File Offset: 0x00146E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007C2B RID: 31787 RVA: 0x00148C69 File Offset: 0x00146E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C2C RID: 31788 RVA: 0x00148C74 File Offset: 0x00146E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Wave != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Wave);
			}
			if (this.ECAGLELIOBN != 0.0)
			{
				output.WriteRawTag(17);
				output.WriteDouble(this.ECAGLELIOBN);
			}
			if (this.MMEOFONFOLP != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.MMEOFONFOLP);
			}
			if (this.ADPPOPDFHPK != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ADPPOPDFHPK);
			}
			if (this.LGKAIBKLJKG != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.LGKAIBKLJKG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C2D RID: 31789 RVA: 0x00148D34 File Offset: 0x00146F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.ECAGLELIOBN != 0.0)
			{
				num += 9;
			}
			if (this.MMEOFONFOLP != 0.0)
			{
				num += 9;
			}
			if (this.ADPPOPDFHPK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ADPPOPDFHPK);
			}
			if (this.LGKAIBKLJKG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LGKAIBKLJKG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007C2E RID: 31790 RVA: 0x00148DD0 File Offset: 0x00146FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MKGIECKGJEP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.ECAGLELIOBN != 0.0)
			{
				this.ECAGLELIOBN = other.ECAGLELIOBN;
			}
			if (other.MMEOFONFOLP != 0.0)
			{
				this.MMEOFONFOLP = other.MMEOFONFOLP;
			}
			if (other.ADPPOPDFHPK != 0U)
			{
				this.ADPPOPDFHPK = other.ADPPOPDFHPK;
			}
			if (other.LGKAIBKLJKG != 0U)
			{
				this.LGKAIBKLJKG = other.LGKAIBKLJKG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C2F RID: 31791 RVA: 0x00148E6E File Offset: 0x0014706E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C30 RID: 31792 RVA: 0x00148E78 File Offset: 0x00147078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 17U)
				{
					if (num == 8U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
					if (num == 17U)
					{
						this.ECAGLELIOBN = input.ReadDouble();
						continue;
					}
				}
				else
				{
					if (num == 25U)
					{
						this.MMEOFONFOLP = input.ReadDouble();
						continue;
					}
					if (num == 32U)
					{
						this.ADPPOPDFHPK = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.LGKAIBKLJKG = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002FBA RID: 12218
		private static readonly MessageParser<MKGIECKGJEP> _parser = new MessageParser<MKGIECKGJEP>(() => new MKGIECKGJEP());

		// Token: 0x04002FBB RID: 12219
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FBC RID: 12220
		public const int WaveFieldNumber = 1;

		// Token: 0x04002FBD RID: 12221
		private uint wave_;

		// Token: 0x04002FBE RID: 12222
		public const int ECAGLELIOBNFieldNumber = 2;

		// Token: 0x04002FBF RID: 12223
		private double eCAGLELIOBN_;

		// Token: 0x04002FC0 RID: 12224
		public const int MMEOFONFOLPFieldNumber = 3;

		// Token: 0x04002FC1 RID: 12225
		private double mMEOFONFOLP_;

		// Token: 0x04002FC2 RID: 12226
		public const int ADPPOPDFHPKFieldNumber = 4;

		// Token: 0x04002FC3 RID: 12227
		private uint aDPPOPDFHPK_;

		// Token: 0x04002FC4 RID: 12228
		public const int LGKAIBKLJKGFieldNumber = 5;

		// Token: 0x04002FC5 RID: 12229
		private uint lGKAIBKLJKG_;
	}
}
