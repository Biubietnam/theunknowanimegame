using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009DF RID: 2527
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LAOKOJAIOPD : IMessage<LAOKOJAIOPD>, IMessage, IEquatable<LAOKOJAIOPD>, IDeepCloneable<LAOKOJAIOPD>, IBufferMessage
	{
		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x0012B935 File Offset: 0x00129B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LAOKOJAIOPD> Parser
		{
			get
			{
				return LAOKOJAIOPD._parser;
			}
		}

		// Token: 0x17001F9C RID: 8092
		// (get) Token: 0x0600704A RID: 28746 RVA: 0x0012B93C File Offset: 0x00129B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LAOKOJAIOPDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x0600704B RID: 28747 RVA: 0x0012B94E File Offset: 0x00129B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LAOKOJAIOPD.Descriptor;
			}
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x0012B955 File Offset: 0x00129B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAOKOJAIOPD()
		{
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x0012B95D File Offset: 0x00129B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAOKOJAIOPD(LAOKOJAIOPD other) : this()
		{
			this.oLMOHJOAKGF_ = other.oLMOHJOAKGF_;
			this.iPOGPDABCIF_ = other.iPOGPDABCIF_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x0012B99A File Offset: 0x00129B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LAOKOJAIOPD Clone()
		{
			return new LAOKOJAIOPD(this);
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x0600704F RID: 28751 RVA: 0x0012B9A2 File Offset: 0x00129BA2
		// (set) Token: 0x06007050 RID: 28752 RVA: 0x0012B9AA File Offset: 0x00129BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OLMOHJOAKGF
		{
			get
			{
				return this.oLMOHJOAKGF_;
			}
			set
			{
				this.oLMOHJOAKGF_ = value;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x06007051 RID: 28753 RVA: 0x0012B9B3 File Offset: 0x00129BB3
		// (set) Token: 0x06007052 RID: 28754 RVA: 0x0012B9BB File Offset: 0x00129BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint IPOGPDABCIF
		{
			get
			{
				return this.iPOGPDABCIF_;
			}
			set
			{
				this.iPOGPDABCIF_ = value;
			}
		}

		// Token: 0x17001FA0 RID: 8096
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x0012B9C4 File Offset: 0x00129BC4
		// (set) Token: 0x06007054 RID: 28756 RVA: 0x0012B9CC File Offset: 0x00129BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBoothStatus Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x06007055 RID: 28757 RVA: 0x0012B9D5 File Offset: 0x00129BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LAOKOJAIOPD);
		}

		// Token: 0x06007056 RID: 28758 RVA: 0x0012B9E4 File Offset: 0x00129BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LAOKOJAIOPD other)
		{
			return other != null && (other == this || (this.OLMOHJOAKGF == other.OLMOHJOAKGF && this.IPOGPDABCIF == other.IPOGPDABCIF && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007057 RID: 28759 RVA: 0x0012BA40 File Offset: 0x00129C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OLMOHJOAKGF != 0U)
			{
				num ^= this.OLMOHJOAKGF.GetHashCode();
			}
			if (this.IPOGPDABCIF != 0U)
			{
				num ^= this.IPOGPDABCIF.GetHashCode();
			}
			if (this.Status != RogueBoothStatus.RogueBoothNone)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007058 RID: 28760 RVA: 0x0012BAB7 File Offset: 0x00129CB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007059 RID: 28761 RVA: 0x0012BABF File Offset: 0x00129CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600705A RID: 28762 RVA: 0x0012BAC8 File Offset: 0x00129CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OLMOHJOAKGF != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.OLMOHJOAKGF);
			}
			if (this.IPOGPDABCIF != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.IPOGPDABCIF);
			}
			if (this.Status != RogueBoothStatus.RogueBoothNone)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600705B RID: 28763 RVA: 0x0012BB40 File Offset: 0x00129D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OLMOHJOAKGF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OLMOHJOAKGF);
			}
			if (this.IPOGPDABCIF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.IPOGPDABCIF);
			}
			if (this.Status != RogueBoothStatus.RogueBoothNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600705C RID: 28764 RVA: 0x0012BBB0 File Offset: 0x00129DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LAOKOJAIOPD other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OLMOHJOAKGF != 0U)
			{
				this.OLMOHJOAKGF = other.OLMOHJOAKGF;
			}
			if (other.IPOGPDABCIF != 0U)
			{
				this.IPOGPDABCIF = other.IPOGPDABCIF;
			}
			if (other.Status != RogueBoothStatus.RogueBoothNone)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600705D RID: 28765 RVA: 0x0012BC14 File Offset: 0x00129E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600705E RID: 28766 RVA: 0x0012BC20 File Offset: 0x00129E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 56U)
					{
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Status = (RogueBoothStatus)input.ReadEnum();
						}
					}
					else
					{
						this.IPOGPDABCIF = input.ReadUInt32();
					}
				}
				else
				{
					this.OLMOHJOAKGF = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002B50 RID: 11088
		private static readonly MessageParser<LAOKOJAIOPD> _parser = new MessageParser<LAOKOJAIOPD>(() => new LAOKOJAIOPD());

		// Token: 0x04002B51 RID: 11089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002B52 RID: 11090
		public const int OLMOHJOAKGFFieldNumber = 5;

		// Token: 0x04002B53 RID: 11091
		private uint oLMOHJOAKGF_;

		// Token: 0x04002B54 RID: 11092
		public const int IPOGPDABCIFFieldNumber = 7;

		// Token: 0x04002B55 RID: 11093
		private uint iPOGPDABCIF_;

		// Token: 0x04002B56 RID: 11094
		public const int StatusFieldNumber = 8;

		// Token: 0x04002B57 RID: 11095
		private RogueBoothStatus status_;
	}
}
