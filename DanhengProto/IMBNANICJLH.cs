using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200092B RID: 2347
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class IMBNANICJLH : IMessage<IMBNANICJLH>, IMessage, IEquatable<IMBNANICJLH>, IDeepCloneable<IMBNANICJLH>, IBufferMessage
	{
		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x060068BA RID: 26810 RVA: 0x00117C75 File Offset: 0x00115E75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<IMBNANICJLH> Parser
		{
			get
			{
				return IMBNANICJLH._parser;
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x060068BB RID: 26811 RVA: 0x00117C7C File Offset: 0x00115E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return IMBNANICJLHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x060068BC RID: 26812 RVA: 0x00117C8E File Offset: 0x00115E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IMBNANICJLH.Descriptor;
			}
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x00117C95 File Offset: 0x00115E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMBNANICJLH()
		{
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x00117CA8 File Offset: 0x00115EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMBNANICJLH(IMBNANICJLH other) : this()
		{
			this.selectHintId_ = other.selectHintId_;
			this.pLNPPJMHGFE_ = other.pLNPPJMHGFE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x00117CDE File Offset: 0x00115EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IMBNANICJLH Clone()
		{
			return new IMBNANICJLH(this);
		}

		// Token: 0x17001D79 RID: 7545
		// (get) Token: 0x060068C0 RID: 26816 RVA: 0x00117CE6 File Offset: 0x00115EE6
		// (set) Token: 0x060068C1 RID: 26817 RVA: 0x00117CEE File Offset: 0x00115EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SelectHintId
		{
			get
			{
				return this.selectHintId_;
			}
			set
			{
				this.selectHintId_ = value;
			}
		}

		// Token: 0x17001D7A RID: 7546
		// (get) Token: 0x060068C2 RID: 26818 RVA: 0x00117CF7 File Offset: 0x00115EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonBuff> PLNPPJMHGFE
		{
			get
			{
				return this.pLNPPJMHGFE_;
			}
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x00117CFF File Offset: 0x00115EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IMBNANICJLH);
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x00117D10 File Offset: 0x00115F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IMBNANICJLH other)
		{
			return other != null && (other == this || (this.SelectHintId == other.SelectHintId && this.pLNPPJMHGFE_.Equals(other.pLNPPJMHGFE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x00117D60 File Offset: 0x00115F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			num ^= this.pLNPPJMHGFE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00117DAD File Offset: 0x00115FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060068C7 RID: 26823 RVA: 0x00117DB5 File Offset: 0x00115FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x00117DC0 File Offset: 0x00115FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pLNPPJMHGFE_.WriteTo(ref output, IMBNANICJLH._repeated_pLNPPJMHGFE_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x00117E10 File Offset: 0x00116010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			num += this.pLNPPJMHGFE_.CalculateSize(IMBNANICJLH._repeated_pLNPPJMHGFE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x00117E64 File Offset: 0x00116064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IMBNANICJLH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this.pLNPPJMHGFE_.Add(other.pLNPPJMHGFE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060068CB RID: 26827 RVA: 0x00117EB1 File Offset: 0x001160B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x00117EBC File Offset: 0x001160BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SelectHintId = input.ReadUInt32();
					}
				}
				else
				{
					this.pLNPPJMHGFE_.AddEntriesFrom(ref input, IMBNANICJLH._repeated_pLNPPJMHGFE_codec);
				}
			}
		}

		// Token: 0x0400282E RID: 10286
		private static readonly MessageParser<IMBNANICJLH> _parser = new MessageParser<IMBNANICJLH>(() => new IMBNANICJLH());

		// Token: 0x0400282F RID: 10287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002830 RID: 10288
		public const int SelectHintIdFieldNumber = 8;

		// Token: 0x04002831 RID: 10289
		private uint selectHintId_;

		// Token: 0x04002832 RID: 10290
		public const int PLNPPJMHGFEFieldNumber = 3;

		// Token: 0x04002833 RID: 10291
		private static readonly FieldCodec<RogueCommonBuff> _repeated_pLNPPJMHGFE_codec = FieldCodec.ForMessage<RogueCommonBuff>(26U, RogueCommonBuff.Parser);

		// Token: 0x04002834 RID: 10292
		private readonly RepeatedField<RogueCommonBuff> pLNPPJMHGFE_ = new RepeatedField<RogueCommonBuff>();
	}
}
