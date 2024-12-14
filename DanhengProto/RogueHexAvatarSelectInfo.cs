using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EA3 RID: 3747
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueHexAvatarSelectInfo : IMessage<RogueHexAvatarSelectInfo>, IMessage, IEquatable<RogueHexAvatarSelectInfo>, IDeepCloneable<RogueHexAvatarSelectInfo>, IBufferMessage
	{
		// Token: 0x17002F4A RID: 12106
		// (get) Token: 0x0600A766 RID: 42854 RVA: 0x001C2E51 File Offset: 0x001C1051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueHexAvatarSelectInfo> Parser
		{
			get
			{
				return RogueHexAvatarSelectInfo._parser;
			}
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x0600A767 RID: 42855 RVA: 0x001C2E58 File Offset: 0x001C1058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueHexAvatarSelectInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x0600A768 RID: 42856 RVA: 0x001C2E6A File Offset: 0x001C106A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueHexAvatarSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x001C2E71 File Offset: 0x001C1071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectInfo()
		{
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x001C2E84 File Offset: 0x001C1084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectInfo(RogueHexAvatarSelectInfo other) : this()
		{
			this.selectHintId_ = other.selectHintId_;
			this.fGKNNFGHEGG_ = other.fGKNNFGHEGG_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x001C2EBA File Offset: 0x001C10BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueHexAvatarSelectInfo Clone()
		{
			return new RogueHexAvatarSelectInfo(this);
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x0600A76C RID: 42860 RVA: 0x001C2EC2 File Offset: 0x001C10C2
		// (set) Token: 0x0600A76D RID: 42861 RVA: 0x001C2ECA File Offset: 0x001C10CA
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

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x0600A76E RID: 42862 RVA: 0x001C2ED3 File Offset: 0x001C10D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FGKNNFGHEGG
		{
			get
			{
				return this.fGKNNFGHEGG_;
			}
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x001C2EDB File Offset: 0x001C10DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueHexAvatarSelectInfo);
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x001C2EEC File Offset: 0x001C10EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueHexAvatarSelectInfo other)
		{
			return other != null && (other == this || (this.SelectHintId == other.SelectHintId && this.fGKNNFGHEGG_.Equals(other.fGKNNFGHEGG_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x001C2F3C File Offset: 0x001C113C
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

		// Token: 0x0600A772 RID: 42866 RVA: 0x001C2F89 File Offset: 0x001C1189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x001C2F91 File Offset: 0x001C1191
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x001C2F9C File Offset: 0x001C119C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.fGKNNFGHEGG_.WriteTo(ref output, RogueHexAvatarSelectInfo._repeated_fGKNNFGHEGG_codec);
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

		// Token: 0x0600A775 RID: 42869 RVA: 0x001C2FEC File Offset: 0x001C11EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SelectHintId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SelectHintId);
			}
			num += this.fGKNNFGHEGG_.CalculateSize(RogueHexAvatarSelectInfo._repeated_fGKNNFGHEGG_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x001C3040 File Offset: 0x001C1240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueHexAvatarSelectInfo other)
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

		// Token: 0x0600A777 RID: 42871 RVA: 0x001C308D File Offset: 0x001C128D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x001C3098 File Offset: 0x001C1298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U && num != 50U)
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
					this.fGKNNFGHEGG_.AddEntriesFrom(ref input, RogueHexAvatarSelectInfo._repeated_fGKNNFGHEGG_codec);
				}
			}
		}

		// Token: 0x04004473 RID: 17523
		private static readonly MessageParser<RogueHexAvatarSelectInfo> _parser = new MessageParser<RogueHexAvatarSelectInfo>(() => new RogueHexAvatarSelectInfo());

		// Token: 0x04004474 RID: 17524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004475 RID: 17525
		public const int SelectHintIdFieldNumber = 13;

		// Token: 0x04004476 RID: 17526
		private uint selectHintId_;

		// Token: 0x04004477 RID: 17527
		public const int FGKNNFGHEGGFieldNumber = 6;

		// Token: 0x04004478 RID: 17528
		private static readonly FieldCodec<uint> _repeated_fGKNNFGHEGG_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04004479 RID: 17529
		private readonly RepeatedField<uint> fGKNNFGHEGG_ = new RepeatedField<uint>();
	}
}
