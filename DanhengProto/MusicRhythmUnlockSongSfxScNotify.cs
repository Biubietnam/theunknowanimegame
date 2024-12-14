using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BF1 RID: 3057
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmUnlockSongSfxScNotify : IMessage<MusicRhythmUnlockSongSfxScNotify>, IMessage, IEquatable<MusicRhythmUnlockSongSfxScNotify>, IDeepCloneable<MusicRhythmUnlockSongSfxScNotify>, IBufferMessage
	{
		// Token: 0x170025EF RID: 9711
		// (get) Token: 0x0600874D RID: 34637 RVA: 0x00164E91 File Offset: 0x00163091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmUnlockSongSfxScNotify> Parser
		{
			get
			{
				return MusicRhythmUnlockSongSfxScNotify._parser;
			}
		}

		// Token: 0x170025F0 RID: 9712
		// (get) Token: 0x0600874E RID: 34638 RVA: 0x00164E98 File Offset: 0x00163098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmUnlockSongSfxScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025F1 RID: 9713
		// (get) Token: 0x0600874F RID: 34639 RVA: 0x00164EAA File Offset: 0x001630AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmUnlockSongSfxScNotify.Descriptor;
			}
		}

		// Token: 0x06008750 RID: 34640 RVA: 0x00164EB1 File Offset: 0x001630B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockSongSfxScNotify()
		{
		}

		// Token: 0x06008751 RID: 34641 RVA: 0x00164EC4 File Offset: 0x001630C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockSongSfxScNotify(MusicRhythmUnlockSongSfxScNotify other) : this()
		{
			this.musicUnlockList_ = other.musicUnlockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008752 RID: 34642 RVA: 0x00164EEE File Offset: 0x001630EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockSongSfxScNotify Clone()
		{
			return new MusicRhythmUnlockSongSfxScNotify(this);
		}

		// Token: 0x170025F2 RID: 9714
		// (get) Token: 0x06008753 RID: 34643 RVA: 0x00164EF6 File Offset: 0x001630F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MusicUnlockList
		{
			get
			{
				return this.musicUnlockList_;
			}
		}

		// Token: 0x06008754 RID: 34644 RVA: 0x00164EFE File Offset: 0x001630FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmUnlockSongSfxScNotify);
		}

		// Token: 0x06008755 RID: 34645 RVA: 0x00164F0C File Offset: 0x0016310C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmUnlockSongSfxScNotify other)
		{
			return other != null && (other == this || (this.musicUnlockList_.Equals(other.musicUnlockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008756 RID: 34646 RVA: 0x00164F40 File Offset: 0x00163140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.musicUnlockList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008757 RID: 34647 RVA: 0x00164F74 File Offset: 0x00163174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x00164F7C File Offset: 0x0016317C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x00164F85 File Offset: 0x00163185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.musicUnlockList_.WriteTo(ref output, MusicRhythmUnlockSongSfxScNotify._repeated_musicUnlockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600875A RID: 34650 RVA: 0x00164FAC File Offset: 0x001631AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.musicUnlockList_.CalculateSize(MusicRhythmUnlockSongSfxScNotify._repeated_musicUnlockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x00164FE5 File Offset: 0x001631E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmUnlockSongSfxScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.musicUnlockList_.Add(other.musicUnlockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600875C RID: 34652 RVA: 0x00165013 File Offset: 0x00163213
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x0016501C File Offset: 0x0016321C
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
					this.musicUnlockList_.AddEntriesFrom(ref input, MusicRhythmUnlockSongSfxScNotify._repeated_musicUnlockList_codec);
				}
			}
		}

		// Token: 0x040033CC RID: 13260
		private static readonly MessageParser<MusicRhythmUnlockSongSfxScNotify> _parser = new MessageParser<MusicRhythmUnlockSongSfxScNotify>(() => new MusicRhythmUnlockSongSfxScNotify());

		// Token: 0x040033CD RID: 13261
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033CE RID: 13262
		public const int MusicUnlockListFieldNumber = 14;

		// Token: 0x040033CF RID: 13263
		private static readonly FieldCodec<uint> _repeated_musicUnlockList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x040033D0 RID: 13264
		private readonly RepeatedField<uint> musicUnlockList_ = new RepeatedField<uint>();
	}
}
