using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ED1 RID: 3793
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicGameDifficultyInfo : IMessage<RogueMagicGameDifficultyInfo>, IMessage, IEquatable<RogueMagicGameDifficultyInfo>, IDeepCloneable<RogueMagicGameDifficultyInfo>, IBufferMessage
	{
		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x0600A986 RID: 43398 RVA: 0x001C8985 File Offset: 0x001C6B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicGameDifficultyInfo> Parser
		{
			get
			{
				return RogueMagicGameDifficultyInfo._parser;
			}
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x0600A987 RID: 43399 RVA: 0x001C898C File Offset: 0x001C6B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicGameDifficultyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0600A988 RID: 43400 RVA: 0x001C899E File Offset: 0x001C6B9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicGameDifficultyInfo.Descriptor;
			}
		}

		// Token: 0x0600A989 RID: 43401 RVA: 0x001C89A5 File Offset: 0x001C6BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameDifficultyInfo()
		{
		}

		// Token: 0x0600A98A RID: 43402 RVA: 0x001C89B8 File Offset: 0x001C6BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameDifficultyInfo(RogueMagicGameDifficultyInfo other) : this()
		{
			this.difficultyIdList_ = other.difficultyIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A98B RID: 43403 RVA: 0x001C89E2 File Offset: 0x001C6BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameDifficultyInfo Clone()
		{
			return new RogueMagicGameDifficultyInfo(this);
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0600A98C RID: 43404 RVA: 0x001C89EA File Offset: 0x001C6BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DifficultyIdList
		{
			get
			{
				return this.difficultyIdList_;
			}
		}

		// Token: 0x0600A98D RID: 43405 RVA: 0x001C89F2 File Offset: 0x001C6BF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicGameDifficultyInfo);
		}

		// Token: 0x0600A98E RID: 43406 RVA: 0x001C8A00 File Offset: 0x001C6C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicGameDifficultyInfo other)
		{
			return other != null && (other == this || (this.difficultyIdList_.Equals(other.difficultyIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A98F RID: 43407 RVA: 0x001C8A34 File Offset: 0x001C6C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.difficultyIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A990 RID: 43408 RVA: 0x001C8A68 File Offset: 0x001C6C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A991 RID: 43409 RVA: 0x001C8A70 File Offset: 0x001C6C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A992 RID: 43410 RVA: 0x001C8A79 File Offset: 0x001C6C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.difficultyIdList_.WriteTo(ref output, RogueMagicGameDifficultyInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A993 RID: 43411 RVA: 0x001C8AA0 File Offset: 0x001C6CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.difficultyIdList_.CalculateSize(RogueMagicGameDifficultyInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A994 RID: 43412 RVA: 0x001C8AD9 File Offset: 0x001C6CD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicGameDifficultyInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.difficultyIdList_.Add(other.difficultyIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A995 RID: 43413 RVA: 0x001C8B07 File Offset: 0x001C6D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A996 RID: 43414 RVA: 0x001C8B10 File Offset: 0x001C6D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.difficultyIdList_.AddEntriesFrom(ref input, RogueMagicGameDifficultyInfo._repeated_difficultyIdList_codec);
				}
			}
		}

		// Token: 0x04004531 RID: 17713
		private static readonly MessageParser<RogueMagicGameDifficultyInfo> _parser = new MessageParser<RogueMagicGameDifficultyInfo>(() => new RogueMagicGameDifficultyInfo());

		// Token: 0x04004532 RID: 17714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004533 RID: 17715
		public const int DifficultyIdListFieldNumber = 14;

		// Token: 0x04004534 RID: 17716
		private static readonly FieldCodec<uint> _repeated_difficultyIdList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04004535 RID: 17717
		private readonly RepeatedField<uint> difficultyIdList_ = new RepeatedField<uint>();
	}
}
