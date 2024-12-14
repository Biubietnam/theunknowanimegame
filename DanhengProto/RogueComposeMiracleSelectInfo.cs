using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E69 RID: 3689
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueComposeMiracleSelectInfo : IMessage<RogueComposeMiracleSelectInfo>, IMessage, IEquatable<RogueComposeMiracleSelectInfo>, IDeepCloneable<RogueComposeMiracleSelectInfo>, IBufferMessage
	{
		// Token: 0x17002E6D RID: 11885
		// (get) Token: 0x0600A484 RID: 42116 RVA: 0x001BA099 File Offset: 0x001B8299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueComposeMiracleSelectInfo> Parser
		{
			get
			{
				return RogueComposeMiracleSelectInfo._parser;
			}
		}

		// Token: 0x17002E6E RID: 11886
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x001BA0A0 File Offset: 0x001B82A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueComposeMiracleSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E6F RID: 11887
		// (get) Token: 0x0600A486 RID: 42118 RVA: 0x001BA0B2 File Offset: 0x001B82B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueComposeMiracleSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x001BA0B9 File Offset: 0x001B82B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueComposeMiracleSelectInfo()
		{
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x001BA0CC File Offset: 0x001B82CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueComposeMiracleSelectInfo(RogueComposeMiracleSelectInfo other) : this()
		{
			this.selectHintId_ = other.selectHintId_;
			this.fGKNNFGHEGG_ = other.fGKNNFGHEGG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x001BA102 File Offset: 0x001B8302
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueComposeMiracleSelectInfo Clone()
		{
			return new RogueComposeMiracleSelectInfo(this);
		}

		// Token: 0x17002E70 RID: 11888
		// (get) Token: 0x0600A48A RID: 42122 RVA: 0x001BA10A File Offset: 0x001B830A
		// (set) Token: 0x0600A48B RID: 42123 RVA: 0x001BA112 File Offset: 0x001B8312
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

		// Token: 0x17002E71 RID: 11889
		// (get) Token: 0x0600A48C RID: 42124 RVA: 0x001BA11B File Offset: 0x001B831B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FGKNNFGHEGG
		{
			get
			{
				return this.fGKNNFGHEGG_;
			}
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x001BA123 File Offset: 0x001B8323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueComposeMiracleSelectInfo);
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x001BA134 File Offset: 0x001B8334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueComposeMiracleSelectInfo other)
		{
			return other != null && (other == this || (this.SelectHintId == other.SelectHintId && this.fGKNNFGHEGG_.Equals(other.fGKNNFGHEGG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A48F RID: 42127 RVA: 0x001BA184 File Offset: 0x001B8384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SelectHintId != 0U)
			{
				num ^= this.SelectHintId.GetHashCode();
			}
			num ^= this.fGKNNFGHEGG_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A490 RID: 42128 RVA: 0x001BA1D1 File Offset: 0x001B83D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A491 RID: 42129 RVA: 0x001BA1D9 File Offset: 0x001B83D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A492 RID: 42130 RVA: 0x001BA1E4 File Offset: 0x001B83E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fGKNNFGHEGG_.WriteTo(ref output, RogueComposeMiracleSelectInfo._repeated_fGKNNFGHEGG_codec);
			if (this.SelectHintId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.SelectHintId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A493 RID: 42131 RVA: 0x001BA234 File Offset: 0x001B8434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			num += this.fGKNNFGHEGG_.CalculateSize(RogueComposeMiracleSelectInfo._repeated_fGKNNFGHEGG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A494 RID: 42132 RVA: 0x001BA288 File Offset: 0x001B8488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueComposeMiracleSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SelectHintId != 0U)
			{
				this.SelectHintId = other.SelectHintId;
			}
			this.fGKNNFGHEGG_.Add(other.fGKNNFGHEGG_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A495 RID: 42133 RVA: 0x001BA2D5 File Offset: 0x001B84D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A496 RID: 42134 RVA: 0x001BA2E0 File Offset: 0x001B84E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					if (num != 104U)
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
					this.fGKNNFGHEGG_.AddEntriesFrom(ref input, RogueComposeMiracleSelectInfo._repeated_fGKNNFGHEGG_codec);
				}
			}
		}

		// Token: 0x04004336 RID: 17206
		private static readonly MessageParser<RogueComposeMiracleSelectInfo> _parser = new MessageParser<RogueComposeMiracleSelectInfo>(() => new RogueComposeMiracleSelectInfo());

		// Token: 0x04004337 RID: 17207
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004338 RID: 17208
		public const int SelectHintIdFieldNumber = 13;

		// Token: 0x04004339 RID: 17209
		private uint selectHintId_;

		// Token: 0x0400433A RID: 17210
		public const int FGKNNFGHEGGFieldNumber = 1;

		// Token: 0x0400433B RID: 17211
		private static readonly FieldCodec<uint> _repeated_fGKNNFGHEGG_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400433C RID: 17212
		private readonly RepeatedField<uint> fGKNNFGHEGG_ = new RepeatedField<uint>();
	}
}
