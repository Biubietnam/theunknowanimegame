using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E71 RID: 3697
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueDifficultyLevelInfo : IMessage<RogueDifficultyLevelInfo>, IMessage, IEquatable<RogueDifficultyLevelInfo>, IDeepCloneable<RogueDifficultyLevelInfo>, IBufferMessage
	{
		// Token: 0x17002E8D RID: 11917
		// (get) Token: 0x0600A4EF RID: 42223 RVA: 0x001BB628 File Offset: 0x001B9828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueDifficultyLevelInfo> Parser
		{
			get
			{
				return RogueDifficultyLevelInfo._parser;
			}
		}

		// Token: 0x17002E8E RID: 11918
		// (get) Token: 0x0600A4F0 RID: 42224 RVA: 0x001BB62F File Offset: 0x001B982F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueDifficultyLevelInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E8F RID: 11919
		// (get) Token: 0x0600A4F1 RID: 42225 RVA: 0x001BB641 File Offset: 0x001B9841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueDifficultyLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x001BB648 File Offset: 0x001B9848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDifficultyLevelInfo()
		{
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x001BB65B File Offset: 0x001B985B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDifficultyLevelInfo(RogueDifficultyLevelInfo other) : this()
		{
			this.difficultyIdList_ = other.difficultyIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4F4 RID: 42228 RVA: 0x001BB685 File Offset: 0x001B9885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDifficultyLevelInfo Clone()
		{
			return new RogueDifficultyLevelInfo(this);
		}

		// Token: 0x17002E90 RID: 11920
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x001BB68D File Offset: 0x001B988D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DifficultyIdList
		{
			get
			{
				return this.difficultyIdList_;
			}
		}

		// Token: 0x0600A4F6 RID: 42230 RVA: 0x001BB695 File Offset: 0x001B9895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueDifficultyLevelInfo);
		}

		// Token: 0x0600A4F7 RID: 42231 RVA: 0x001BB6A3 File Offset: 0x001B98A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueDifficultyLevelInfo other)
		{
			return other != null && (other == this || (this.difficultyIdList_.Equals(other.difficultyIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x001BB6D8 File Offset: 0x001B98D8
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

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x001BB70C File Offset: 0x001B990C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x001BB714 File Offset: 0x001B9914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x001BB71D File Offset: 0x001B991D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.difficultyIdList_.WriteTo(ref output, RogueDifficultyLevelInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x001BB744 File Offset: 0x001B9944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.difficultyIdList_.CalculateSize(RogueDifficultyLevelInfo._repeated_difficultyIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x001BB77D File Offset: 0x001B997D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueDifficultyLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.difficultyIdList_.Add(other.difficultyIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x001BB7AB File Offset: 0x001B99AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x001BB7B4 File Offset: 0x001B99B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.difficultyIdList_.AddEntriesFrom(ref input, RogueDifficultyLevelInfo._repeated_difficultyIdList_codec);
				}
			}
		}

		// Token: 0x04004363 RID: 17251
		private static readonly MessageParser<RogueDifficultyLevelInfo> _parser = new MessageParser<RogueDifficultyLevelInfo>(() => new RogueDifficultyLevelInfo());

		// Token: 0x04004364 RID: 17252
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004365 RID: 17253
		public const int DifficultyIdListFieldNumber = 1;

		// Token: 0x04004366 RID: 17254
		private static readonly FieldCodec<uint> _repeated_difficultyIdList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04004367 RID: 17255
		private readonly RepeatedField<uint> difficultyIdList_ = new RepeatedField<uint>();
	}
}
