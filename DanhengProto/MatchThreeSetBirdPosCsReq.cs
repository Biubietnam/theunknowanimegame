using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AA5 RID: 2725
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MatchThreeSetBirdPosCsReq : IMessage<MatchThreeSetBirdPosCsReq>, IMessage, IEquatable<MatchThreeSetBirdPosCsReq>, IDeepCloneable<MatchThreeSetBirdPosCsReq>, IBufferMessage
	{
		// Token: 0x170021EA RID: 8682
		// (get) Token: 0x060078C6 RID: 30918 RVA: 0x001402D5 File Offset: 0x0013E4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MatchThreeSetBirdPosCsReq> Parser
		{
			get
			{
				return MatchThreeSetBirdPosCsReq._parser;
			}
		}

		// Token: 0x170021EB RID: 8683
		// (get) Token: 0x060078C7 RID: 30919 RVA: 0x001402DC File Offset: 0x0013E4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MatchThreeSetBirdPosCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021EC RID: 8684
		// (get) Token: 0x060078C8 RID: 30920 RVA: 0x001402EE File Offset: 0x0013E4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeSetBirdPosCsReq.Descriptor;
			}
		}

		// Token: 0x060078C9 RID: 30921 RVA: 0x001402F5 File Offset: 0x0013E4F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSetBirdPosCsReq()
		{
		}

		// Token: 0x060078CA RID: 30922 RVA: 0x001402FD File Offset: 0x0013E4FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSetBirdPosCsReq(MatchThreeSetBirdPosCsReq other) : this()
		{
			this.jKGBGFOPMHM_ = other.jKGBGFOPMHM_;
			this.pos_ = other.pos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060078CB RID: 30923 RVA: 0x0014032E File Offset: 0x0013E52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeSetBirdPosCsReq Clone()
		{
			return new MatchThreeSetBirdPosCsReq(this);
		}

		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x060078CC RID: 30924 RVA: 0x00140336 File Offset: 0x0013E536
		// (set) Token: 0x060078CD RID: 30925 RVA: 0x0014033E File Offset: 0x0013E53E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKGBGFOPMHM
		{
			get
			{
				return this.jKGBGFOPMHM_;
			}
			set
			{
				this.jKGBGFOPMHM_ = value;
			}
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x060078CE RID: 30926 RVA: 0x00140347 File Offset: 0x0013E547
		// (set) Token: 0x060078CF RID: 30927 RVA: 0x0014034F File Offset: 0x0013E54F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x00140358 File Offset: 0x0013E558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeSetBirdPosCsReq);
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x00140366 File Offset: 0x0013E566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeSetBirdPosCsReq other)
		{
			return other != null && (other == this || (this.JKGBGFOPMHM == other.JKGBGFOPMHM && this.Pos == other.Pos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x001403A4 File Offset: 0x0013E5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.JKGBGFOPMHM != 0U)
			{
				num ^= this.JKGBGFOPMHM.GetHashCode();
			}
			if (this.Pos != 0U)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060078D3 RID: 30931 RVA: 0x001403FC File Offset: 0x0013E5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060078D4 RID: 30932 RVA: 0x00140404 File Offset: 0x0013E604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060078D5 RID: 30933 RVA: 0x00140410 File Offset: 0x0013E610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Pos);
			}
			if (this.JKGBGFOPMHM != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JKGBGFOPMHM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060078D6 RID: 30934 RVA: 0x0014046C File Offset: 0x0013E66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.JKGBGFOPMHM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKGBGFOPMHM);
			}
			if (this.Pos != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x001404C4 File Offset: 0x0013E6C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeSetBirdPosCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.JKGBGFOPMHM != 0U)
			{
				this.JKGBGFOPMHM = other.JKGBGFOPMHM;
			}
			if (other.Pos != 0U)
			{
				this.Pos = other.Pos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x00140514 File Offset: 0x0013E714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060078D9 RID: 30937 RVA: 0x00140520 File Offset: 0x0013E720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JKGBGFOPMHM = input.ReadUInt32();
					}
				}
				else
				{
					this.Pos = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002E61 RID: 11873
		private static readonly MessageParser<MatchThreeSetBirdPosCsReq> _parser = new MessageParser<MatchThreeSetBirdPosCsReq>(() => new MatchThreeSetBirdPosCsReq());

		// Token: 0x04002E62 RID: 11874
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E63 RID: 11875
		public const int JKGBGFOPMHMFieldNumber = 15;

		// Token: 0x04002E64 RID: 11876
		private uint jKGBGFOPMHM_;

		// Token: 0x04002E65 RID: 11877
		public const int PosFieldNumber = 7;

		// Token: 0x04002E66 RID: 11878
		private uint pos_;
	}
}
