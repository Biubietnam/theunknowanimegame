using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200134B RID: 4939
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TelevisionActivityData : IMessage<TelevisionActivityData>, IMessage, IEquatable<TelevisionActivityData>, IDeepCloneable<TelevisionActivityData>, IBufferMessage
	{
		// Token: 0x17003DEB RID: 15851
		// (get) Token: 0x0600DC6F RID: 56431 RVA: 0x0024AFF9 File Offset: 0x002491F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TelevisionActivityData> Parser
		{
			get
			{
				return TelevisionActivityData._parser;
			}
		}

		// Token: 0x17003DEC RID: 15852
		// (get) Token: 0x0600DC70 RID: 56432 RVA: 0x0024B000 File Offset: 0x00249200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelevisionActivityDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003DED RID: 15853
		// (get) Token: 0x0600DC71 RID: 56433 RVA: 0x0024B012 File Offset: 0x00249212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TelevisionActivityData.Descriptor;
			}
		}

		// Token: 0x0600DC72 RID: 56434 RVA: 0x0024B019 File Offset: 0x00249219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityData()
		{
		}

		// Token: 0x0600DC73 RID: 56435 RVA: 0x0024B021 File Offset: 0x00249221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityData(TelevisionActivityData other) : this()
		{
			this.dNFJOOAJIKG_ = other.dNFJOOAJIKG_;
			this.iCODEPAKPHJ_ = other.iCODEPAKPHJ_;
			this.maxScore_ = other.maxScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC74 RID: 56436 RVA: 0x0024B05E File Offset: 0x0024925E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TelevisionActivityData Clone()
		{
			return new TelevisionActivityData(this);
		}

		// Token: 0x17003DEE RID: 15854
		// (get) Token: 0x0600DC75 RID: 56437 RVA: 0x0024B066 File Offset: 0x00249266
		// (set) Token: 0x0600DC76 RID: 56438 RVA: 0x0024B06E File Offset: 0x0024926E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DNFJOOAJIKG
		{
			get
			{
				return this.dNFJOOAJIKG_;
			}
			set
			{
				this.dNFJOOAJIKG_ = value;
			}
		}

		// Token: 0x17003DEF RID: 15855
		// (get) Token: 0x0600DC77 RID: 56439 RVA: 0x0024B077 File Offset: 0x00249277
		// (set) Token: 0x0600DC78 RID: 56440 RVA: 0x0024B07F File Offset: 0x0024927F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ICODEPAKPHJ
		{
			get
			{
				return this.iCODEPAKPHJ_;
			}
			set
			{
				this.iCODEPAKPHJ_ = value;
			}
		}

		// Token: 0x17003DF0 RID: 15856
		// (get) Token: 0x0600DC79 RID: 56441 RVA: 0x0024B088 File Offset: 0x00249288
		// (set) Token: 0x0600DC7A RID: 56442 RVA: 0x0024B090 File Offset: 0x00249290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x0600DC7B RID: 56443 RVA: 0x0024B099 File Offset: 0x00249299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TelevisionActivityData);
		}

		// Token: 0x0600DC7C RID: 56444 RVA: 0x0024B0A8 File Offset: 0x002492A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TelevisionActivityData other)
		{
			return other != null && (other == this || (this.DNFJOOAJIKG == other.DNFJOOAJIKG && this.ICODEPAKPHJ == other.ICODEPAKPHJ && this.MaxScore == other.MaxScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC7D RID: 56445 RVA: 0x0024B104 File Offset: 0x00249304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DNFJOOAJIKG != 0U)
			{
				num ^= this.DNFJOOAJIKG.GetHashCode();
			}
			if (this.ICODEPAKPHJ != 0U)
			{
				num ^= this.ICODEPAKPHJ.GetHashCode();
			}
			if (this.MaxScore != 0U)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC7E RID: 56446 RVA: 0x0024B175 File Offset: 0x00249375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DC7F RID: 56447 RVA: 0x0024B17D File Offset: 0x0024937D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC80 RID: 56448 RVA: 0x0024B188 File Offset: 0x00249388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxScore != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.MaxScore);
			}
			if (this.DNFJOOAJIKG != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.DNFJOOAJIKG);
			}
			if (this.ICODEPAKPHJ != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.ICODEPAKPHJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC81 RID: 56449 RVA: 0x0024B200 File Offset: 0x00249400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DNFJOOAJIKG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DNFJOOAJIKG);
			}
			if (this.ICODEPAKPHJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICODEPAKPHJ);
			}
			if (this.MaxScore != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC82 RID: 56450 RVA: 0x0024B270 File Offset: 0x00249470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TelevisionActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DNFJOOAJIKG != 0U)
			{
				this.DNFJOOAJIKG = other.DNFJOOAJIKG;
			}
			if (other.ICODEPAKPHJ != 0U)
			{
				this.ICODEPAKPHJ = other.ICODEPAKPHJ;
			}
			if (other.MaxScore != 0U)
			{
				this.MaxScore = other.MaxScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC83 RID: 56451 RVA: 0x0024B2D4 File Offset: 0x002494D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC84 RID: 56452 RVA: 0x0024B2E0 File Offset: 0x002494E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ICODEPAKPHJ = input.ReadUInt32();
						}
					}
					else
					{
						this.DNFJOOAJIKG = input.ReadUInt32();
					}
				}
				else
				{
					this.MaxScore = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040057B3 RID: 22451
		private static readonly MessageParser<TelevisionActivityData> _parser = new MessageParser<TelevisionActivityData>(() => new TelevisionActivityData());

		// Token: 0x040057B4 RID: 22452
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057B5 RID: 22453
		public const int DNFJOOAJIKGFieldNumber = 13;

		// Token: 0x040057B6 RID: 22454
		private uint dNFJOOAJIKG_;

		// Token: 0x040057B7 RID: 22455
		public const int ICODEPAKPHJFieldNumber = 14;

		// Token: 0x040057B8 RID: 22456
		private uint iCODEPAKPHJ_;

		// Token: 0x040057B9 RID: 22457
		public const int MaxScoreFieldNumber = 6;

		// Token: 0x040057BA RID: 22458
		private uint maxScore_;
	}
}
