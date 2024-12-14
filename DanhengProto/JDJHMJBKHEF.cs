using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200095F RID: 2399
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JDJHMJBKHEF : IMessage<JDJHMJBKHEF>, IMessage, IEquatable<JDJHMJBKHEF>, IDeepCloneable<JDJHMJBKHEF>, IBufferMessage
	{
		// Token: 0x17001E1E RID: 7710
		// (get) Token: 0x06006B21 RID: 27425 RVA: 0x0011DB35 File Offset: 0x0011BD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JDJHMJBKHEF> Parser
		{
			get
			{
				return JDJHMJBKHEF._parser;
			}
		}

		// Token: 0x17001E1F RID: 7711
		// (get) Token: 0x06006B22 RID: 27426 RVA: 0x0011DB3C File Offset: 0x0011BD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JDJHMJBKHEFReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E20 RID: 7712
		// (get) Token: 0x06006B23 RID: 27427 RVA: 0x0011DB4E File Offset: 0x0011BD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JDJHMJBKHEF.Descriptor;
			}
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x0011DB55 File Offset: 0x0011BD55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDJHMJBKHEF()
		{
		}

		// Token: 0x06006B25 RID: 27429 RVA: 0x0011DB60 File Offset: 0x0011BD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDJHMJBKHEF(JDJHMJBKHEF other) : this()
		{
			this.kHHMFIPMFMP_ = other.kHHMFIPMFMP_;
			this.fFDMJAPGFOA_ = other.fFDMJAPGFOA_;
			this.eOAIJOLGFNN_ = other.eOAIJOLGFNN_;
			this.wave_ = other.wave_;
			this.kKCHCLOLPMB_ = other.kKCHCLOLPMB_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B26 RID: 27430 RVA: 0x0011DBC0 File Offset: 0x0011BDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JDJHMJBKHEF Clone()
		{
			return new JDJHMJBKHEF(this);
		}

		// Token: 0x17001E21 RID: 7713
		// (get) Token: 0x06006B27 RID: 27431 RVA: 0x0011DBC8 File Offset: 0x0011BDC8
		// (set) Token: 0x06006B28 RID: 27432 RVA: 0x0011DBD0 File Offset: 0x0011BDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KHHMFIPMFMP
		{
			get
			{
				return this.kHHMFIPMFMP_;
			}
			set
			{
				this.kHHMFIPMFMP_ = value;
			}
		}

		// Token: 0x17001E22 RID: 7714
		// (get) Token: 0x06006B29 RID: 27433 RVA: 0x0011DBD9 File Offset: 0x0011BDD9
		// (set) Token: 0x06006B2A RID: 27434 RVA: 0x0011DBE1 File Offset: 0x0011BDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FFDMJAPGFOA
		{
			get
			{
				return this.fFDMJAPGFOA_;
			}
			set
			{
				this.fFDMJAPGFOA_ = value;
			}
		}

		// Token: 0x17001E23 RID: 7715
		// (get) Token: 0x06006B2B RID: 27435 RVA: 0x0011DBEA File Offset: 0x0011BDEA
		// (set) Token: 0x06006B2C RID: 27436 RVA: 0x0011DBF2 File Offset: 0x0011BDF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public double EOAIJOLGFNN
		{
			get
			{
				return this.eOAIJOLGFNN_;
			}
			set
			{
				this.eOAIJOLGFNN_ = value;
			}
		}

		// Token: 0x17001E24 RID: 7716
		// (get) Token: 0x06006B2D RID: 27437 RVA: 0x0011DBFB File Offset: 0x0011BDFB
		// (set) Token: 0x06006B2E RID: 27438 RVA: 0x0011DC03 File Offset: 0x0011BE03
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

		// Token: 0x17001E25 RID: 7717
		// (get) Token: 0x06006B2F RID: 27439 RVA: 0x0011DC0C File Offset: 0x0011BE0C
		// (set) Token: 0x06006B30 RID: 27440 RVA: 0x0011DC14 File Offset: 0x0011BE14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint KKCHCLOLPMB
		{
			get
			{
				return this.kKCHCLOLPMB_;
			}
			set
			{
				this.kKCHCLOLPMB_ = value;
			}
		}

		// Token: 0x06006B31 RID: 27441 RVA: 0x0011DC1D File Offset: 0x0011BE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JDJHMJBKHEF);
		}

		// Token: 0x06006B32 RID: 27442 RVA: 0x0011DC2C File Offset: 0x0011BE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JDJHMJBKHEF other)
		{
			return other != null && (other == this || (this.KHHMFIPMFMP == other.KHHMFIPMFMP && this.FFDMJAPGFOA == other.FFDMJAPGFOA && ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(this.EOAIJOLGFNN, other.EOAIJOLGFNN) && this.Wave == other.Wave && this.KKCHCLOLPMB == other.KKCHCLOLPMB && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x0011DCB0 File Offset: 0x0011BEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.KHHMFIPMFMP != 0U)
			{
				num ^= this.KHHMFIPMFMP.GetHashCode();
			}
			if (this.FFDMJAPGFOA != 0U)
			{
				num ^= this.FFDMJAPGFOA.GetHashCode();
			}
			if (this.EOAIJOLGFNN != 0.0)
			{
				num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(this.EOAIJOLGFNN);
			}
			if (this.Wave != 0U)
			{
				num ^= this.Wave.GetHashCode();
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				num ^= this.KKCHCLOLPMB.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x0011DD5E File Offset: 0x0011BF5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x0011DD66 File Offset: 0x0011BF66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B36 RID: 27446 RVA: 0x0011DD70 File Offset: 0x0011BF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.KHHMFIPMFMP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.KHHMFIPMFMP);
			}
			if (this.FFDMJAPGFOA != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.FFDMJAPGFOA);
			}
			if (this.EOAIJOLGFNN != 0.0)
			{
				output.WriteRawTag(25);
				output.WriteDouble(this.EOAIJOLGFNN);
			}
			if (this.Wave != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Wave);
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.KKCHCLOLPMB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B37 RID: 27447 RVA: 0x0011DE28 File Offset: 0x0011C028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.KHHMFIPMFMP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KHHMFIPMFMP);
			}
			if (this.FFDMJAPGFOA != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FFDMJAPGFOA);
			}
			if (this.EOAIJOLGFNN != 0.0)
			{
				num += 9;
			}
			if (this.Wave != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Wave);
			}
			if (this.KKCHCLOLPMB != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.KKCHCLOLPMB);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B38 RID: 27448 RVA: 0x0011DEC4 File Offset: 0x0011C0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JDJHMJBKHEF other)
		{
			if (other == null)
			{
				return;
			}
			if (other.KHHMFIPMFMP != 0U)
			{
				this.KHHMFIPMFMP = other.KHHMFIPMFMP;
			}
			if (other.FFDMJAPGFOA != 0U)
			{
				this.FFDMJAPGFOA = other.FFDMJAPGFOA;
			}
			if (other.EOAIJOLGFNN != 0.0)
			{
				this.EOAIJOLGFNN = other.EOAIJOLGFNN;
			}
			if (other.Wave != 0U)
			{
				this.Wave = other.Wave;
			}
			if (other.KKCHCLOLPMB != 0U)
			{
				this.KKCHCLOLPMB = other.KKCHCLOLPMB;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B39 RID: 27449 RVA: 0x0011DF59 File Offset: 0x0011C159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B3A RID: 27450 RVA: 0x0011DF64 File Offset: 0x0011C164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.KHHMFIPMFMP = input.ReadUInt32();
						continue;
					}
					if (num == 16U)
					{
						this.FFDMJAPGFOA = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 25U)
					{
						this.EOAIJOLGFNN = input.ReadDouble();
						continue;
					}
					if (num == 32U)
					{
						this.Wave = input.ReadUInt32();
						continue;
					}
					if (num == 40U)
					{
						this.KKCHCLOLPMB = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002903 RID: 10499
		private static readonly MessageParser<JDJHMJBKHEF> _parser = new MessageParser<JDJHMJBKHEF>(() => new JDJHMJBKHEF());

		// Token: 0x04002904 RID: 10500
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002905 RID: 10501
		public const int KHHMFIPMFMPFieldNumber = 1;

		// Token: 0x04002906 RID: 10502
		private uint kHHMFIPMFMP_;

		// Token: 0x04002907 RID: 10503
		public const int FFDMJAPGFOAFieldNumber = 2;

		// Token: 0x04002908 RID: 10504
		private uint fFDMJAPGFOA_;

		// Token: 0x04002909 RID: 10505
		public const int EOAIJOLGFNNFieldNumber = 3;

		// Token: 0x0400290A RID: 10506
		private double eOAIJOLGFNN_;

		// Token: 0x0400290B RID: 10507
		public const int WaveFieldNumber = 4;

		// Token: 0x0400290C RID: 10508
		private uint wave_;

		// Token: 0x0400290D RID: 10509
		public const int KKCHCLOLPMBFieldNumber = 5;

		// Token: 0x0400290E RID: 10510
		private uint kKCHCLOLPMB_;
	}
}
