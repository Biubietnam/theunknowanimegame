using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003F3 RID: 1011
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EDIOJBCALHB : IMessage<EDIOJBCALHB>, IMessage, IEquatable<EDIOJBCALHB>, IDeepCloneable<EDIOJBCALHB>, IBufferMessage
	{
		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x0007C85D File Offset: 0x0007AA5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EDIOJBCALHB> Parser
		{
			get
			{
				return EDIOJBCALHB._parser;
			}
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002CFF RID: 11519 RVA: 0x0007C864 File Offset: 0x0007AA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EDIOJBCALHBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x0007C876 File Offset: 0x0007AA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EDIOJBCALHB.Descriptor;
			}
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x0007C87D File Offset: 0x0007AA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDIOJBCALHB()
		{
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0007C890 File Offset: 0x0007AA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDIOJBCALHB(EDIOJBCALHB other) : this()
		{
			this.selectHintId_ = other.selectHintId_;
			this.fCPJHICDAHO_ = other.fCPJHICDAHO_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x0007C8C6 File Offset: 0x0007AAC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EDIOJBCALHB Clone()
		{
			return new EDIOJBCALHB(this);
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x0007C8CE File Offset: 0x0007AACE
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x0007C8D6 File Offset: 0x0007AAD6
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

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x0007C8DF File Offset: 0x0007AADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonBuff> FCPJHICDAHO
		{
			get
			{
				return this.fCPJHICDAHO_;
			}
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x0007C8E7 File Offset: 0x0007AAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EDIOJBCALHB);
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EDIOJBCALHB other)
		{
			return other != null && (other == this || (this.SelectHintId == other.SelectHintId && this.fCPJHICDAHO_.Equals(other.fCPJHICDAHO_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x0007C948 File Offset: 0x0007AB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			num ^= this.fCPJHICDAHO_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x0007C995 File Offset: 0x0007AB95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0007C99D File Offset: 0x0007AB9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x0007C9A8 File Offset: 0x0007ABA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.SelectHintId);
			}
			this.fCPJHICDAHO_.WriteTo(ref output, EDIOJBCALHB._repeated_fCPJHICDAHO_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x0007C9F8 File Offset: 0x0007ABF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			num += this.fCPJHICDAHO_.CalculateSize(EDIOJBCALHB._repeated_fCPJHICDAHO_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0007CA4C File Offset: 0x0007AC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EDIOJBCALHB other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this.fCPJHICDAHO_.Add(other.fCPJHICDAHO_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x0007CA99 File Offset: 0x0007AC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x0007CAA4 File Offset: 0x0007ACA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.fCPJHICDAHO_.AddEntriesFrom(ref input, EDIOJBCALHB._repeated_fCPJHICDAHO_codec);
					}
				}
				else
				{
					this.SelectHintId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400121C RID: 4636
		private static readonly MessageParser<EDIOJBCALHB> _parser = new MessageParser<EDIOJBCALHB>(() => new EDIOJBCALHB());

		// Token: 0x0400121D RID: 4637
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400121E RID: 4638
		public const int SelectHintIdFieldNumber = 9;

		// Token: 0x0400121F RID: 4639
		private uint selectHintId_;

		// Token: 0x04001220 RID: 4640
		public const int FCPJHICDAHOFieldNumber = 14;

		// Token: 0x04001221 RID: 4641
		private static readonly FieldCodec<RogueCommonBuff> _repeated_fCPJHICDAHO_codec = FieldCodec.ForMessage<RogueCommonBuff>(114U, RogueCommonBuff.Parser);

		// Token: 0x04001222 RID: 4642
		private readonly RepeatedField<RogueCommonBuff> fCPJHICDAHO_ = new RepeatedField<RogueCommonBuff>();
	}
}
