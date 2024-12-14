using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011E7 RID: 4583
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StoryLineInfoScNotify : IMessage<StoryLineInfoScNotify>, IMessage, IEquatable<StoryLineInfoScNotify>, IDeepCloneable<StoryLineInfoScNotify>, IBufferMessage
	{
		// Token: 0x170039C4 RID: 14788
		// (get) Token: 0x0600CCCA RID: 52426 RVA: 0x0022599B File Offset: 0x00223B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StoryLineInfoScNotify> Parser
		{
			get
			{
				return StoryLineInfoScNotify._parser;
			}
		}

		// Token: 0x170039C5 RID: 14789
		// (get) Token: 0x0600CCCB RID: 52427 RVA: 0x002259A2 File Offset: 0x00223BA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StoryLineInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039C6 RID: 14790
		// (get) Token: 0x0600CCCC RID: 52428 RVA: 0x002259B4 File Offset: 0x00223BB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StoryLineInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600CCCD RID: 52429 RVA: 0x002259BB File Offset: 0x00223BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StoryLineInfoScNotify()
		{
		}

		// Token: 0x0600CCCE RID: 52430 RVA: 0x002259DC File Offset: 0x00223BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StoryLineInfoScNotify(StoryLineInfoScNotify other) : this()
		{
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.curStoryLineId_ = other.curStoryLineId_;
			this.unfinishedStoryLineIdList_ = other.unfinishedStoryLineIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CCCF RID: 52431 RVA: 0x00225A2E File Offset: 0x00223C2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StoryLineInfoScNotify Clone()
		{
			return new StoryLineInfoScNotify(this);
		}

		// Token: 0x170039C7 RID: 14791
		// (get) Token: 0x0600CCD0 RID: 52432 RVA: 0x00225A36 File Offset: 0x00223C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x170039C8 RID: 14792
		// (get) Token: 0x0600CCD1 RID: 52433 RVA: 0x00225A3E File Offset: 0x00223C3E
		// (set) Token: 0x0600CCD2 RID: 52434 RVA: 0x00225A46 File Offset: 0x00223C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurStoryLineId
		{
			get
			{
				return this.curStoryLineId_;
			}
			set
			{
				this.curStoryLineId_ = value;
			}
		}

		// Token: 0x170039C9 RID: 14793
		// (get) Token: 0x0600CCD3 RID: 52435 RVA: 0x00225A4F File Offset: 0x00223C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnfinishedStoryLineIdList
		{
			get
			{
				return this.unfinishedStoryLineIdList_;
			}
		}

		// Token: 0x0600CCD4 RID: 52436 RVA: 0x00225A57 File Offset: 0x00223C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StoryLineInfoScNotify);
		}

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x00225A68 File Offset: 0x00223C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StoryLineInfoScNotify other)
		{
			return other != null && (other == this || (this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.CurStoryLineId == other.CurStoryLineId && this.unfinishedStoryLineIdList_.Equals(other.unfinishedStoryLineIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CCD6 RID: 52438 RVA: 0x00225ACC File Offset: 0x00223CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialAvatarIdList_.GetHashCode();
			if (this.CurStoryLineId != 0U)
			{
				num ^= this.CurStoryLineId.GetHashCode();
			}
			num ^= this.unfinishedStoryLineIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CCD7 RID: 52439 RVA: 0x00225B27 File Offset: 0x00223D27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CCD8 RID: 52440 RVA: 0x00225B2F File Offset: 0x00223D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CCD9 RID: 52441 RVA: 0x00225B38 File Offset: 0x00223D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unfinishedStoryLineIdList_.WriteTo(ref output, StoryLineInfoScNotify._repeated_unfinishedStoryLineIdList_codec);
			if (this.CurStoryLineId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CurStoryLineId);
			}
			this.trialAvatarIdList_.WriteTo(ref output, StoryLineInfoScNotify._repeated_trialAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CCDA RID: 52442 RVA: 0x00225B98 File Offset: 0x00223D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialAvatarIdList_.CalculateSize(StoryLineInfoScNotify._repeated_trialAvatarIdList_codec);
			if (this.CurStoryLineId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurStoryLineId);
			}
			num += this.unfinishedStoryLineIdList_.CalculateSize(StoryLineInfoScNotify._repeated_unfinishedStoryLineIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CCDB RID: 52443 RVA: 0x00225BFC File Offset: 0x00223DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StoryLineInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			if (other.CurStoryLineId != 0U)
			{
				this.CurStoryLineId = other.CurStoryLineId;
			}
			this.unfinishedStoryLineIdList_.Add(other.unfinishedStoryLineIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CCDC RID: 52444 RVA: 0x00225C5A File Offset: 0x00223E5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x00225C64 File Offset: 0x00223E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.unfinishedStoryLineIdList_.AddEntriesFrom(ref input, StoryLineInfoScNotify._repeated_unfinishedStoryLineIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.CurStoryLineId = input.ReadUInt32();
						continue;
					}
					if (num == 72U || num == 74U)
					{
						this.trialAvatarIdList_.AddEntriesFrom(ref input, StoryLineInfoScNotify._repeated_trialAvatarIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005292 RID: 21138
		private static readonly MessageParser<StoryLineInfoScNotify> _parser = new MessageParser<StoryLineInfoScNotify>(() => new StoryLineInfoScNotify());

		// Token: 0x04005293 RID: 21139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005294 RID: 21140
		public const int TrialAvatarIdListFieldNumber = 9;

		// Token: 0x04005295 RID: 21141
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04005296 RID: 21142
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04005297 RID: 21143
		public const int CurStoryLineIdFieldNumber = 6;

		// Token: 0x04005298 RID: 21144
		private uint curStoryLineId_;

		// Token: 0x04005299 RID: 21145
		public const int UnfinishedStoryLineIdListFieldNumber = 1;

		// Token: 0x0400529A RID: 21146
		private static readonly FieldCodec<uint> _repeated_unfinishedStoryLineIdList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400529B RID: 21147
		private readonly RepeatedField<uint> unfinishedStoryLineIdList_ = new RepeatedField<uint>();
	}
}
