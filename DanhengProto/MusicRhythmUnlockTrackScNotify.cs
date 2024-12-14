using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BF3 RID: 3059
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmUnlockTrackScNotify : IMessage<MusicRhythmUnlockTrackScNotify>, IMessage, IEquatable<MusicRhythmUnlockTrackScNotify>, IDeepCloneable<MusicRhythmUnlockTrackScNotify>, IBufferMessage
	{
		// Token: 0x170025F4 RID: 9716
		// (get) Token: 0x06008761 RID: 34657 RVA: 0x00165105 File Offset: 0x00163305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmUnlockTrackScNotify> Parser
		{
			get
			{
				return MusicRhythmUnlockTrackScNotify._parser;
			}
		}

		// Token: 0x170025F5 RID: 9717
		// (get) Token: 0x06008762 RID: 34658 RVA: 0x0016510C File Offset: 0x0016330C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmUnlockTrackScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025F6 RID: 9718
		// (get) Token: 0x06008763 RID: 34659 RVA: 0x0016511E File Offset: 0x0016331E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmUnlockTrackScNotify.Descriptor;
			}
		}

		// Token: 0x06008764 RID: 34660 RVA: 0x00165125 File Offset: 0x00163325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockTrackScNotify()
		{
		}

		// Token: 0x06008765 RID: 34661 RVA: 0x00165138 File Offset: 0x00163338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockTrackScNotify(MusicRhythmUnlockTrackScNotify other) : this()
		{
			this.trackUnlockList_ = other.trackUnlockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008766 RID: 34662 RVA: 0x00165162 File Offset: 0x00163362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockTrackScNotify Clone()
		{
			return new MusicRhythmUnlockTrackScNotify(this);
		}

		// Token: 0x170025F7 RID: 9719
		// (get) Token: 0x06008767 RID: 34663 RVA: 0x0016516A File Offset: 0x0016336A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrackUnlockList
		{
			get
			{
				return this.trackUnlockList_;
			}
		}

		// Token: 0x06008768 RID: 34664 RVA: 0x00165172 File Offset: 0x00163372
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmUnlockTrackScNotify);
		}

		// Token: 0x06008769 RID: 34665 RVA: 0x00165180 File Offset: 0x00163380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmUnlockTrackScNotify other)
		{
			return other != null && (other == this || (this.trackUnlockList_.Equals(other.trackUnlockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600876A RID: 34666 RVA: 0x001651B4 File Offset: 0x001633B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trackUnlockList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600876B RID: 34667 RVA: 0x001651E8 File Offset: 0x001633E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600876C RID: 34668 RVA: 0x001651F0 File Offset: 0x001633F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600876D RID: 34669 RVA: 0x001651F9 File Offset: 0x001633F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trackUnlockList_.WriteTo(ref output, MusicRhythmUnlockTrackScNotify._repeated_trackUnlockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600876E RID: 34670 RVA: 0x00165220 File Offset: 0x00163420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trackUnlockList_.CalculateSize(MusicRhythmUnlockTrackScNotify._repeated_trackUnlockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600876F RID: 34671 RVA: 0x00165259 File Offset: 0x00163459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmUnlockTrackScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.trackUnlockList_.Add(other.trackUnlockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008770 RID: 34672 RVA: 0x00165287 File Offset: 0x00163487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008771 RID: 34673 RVA: 0x00165290 File Offset: 0x00163490
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
					this.trackUnlockList_.AddEntriesFrom(ref input, MusicRhythmUnlockTrackScNotify._repeated_trackUnlockList_codec);
				}
			}
		}

		// Token: 0x040033D2 RID: 13266
		private static readonly MessageParser<MusicRhythmUnlockTrackScNotify> _parser = new MessageParser<MusicRhythmUnlockTrackScNotify>(() => new MusicRhythmUnlockTrackScNotify());

		// Token: 0x040033D3 RID: 13267
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033D4 RID: 13268
		public const int TrackUnlockListFieldNumber = 14;

		// Token: 0x040033D5 RID: 13269
		private static readonly FieldCodec<uint> _repeated_trackUnlockList_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x040033D6 RID: 13270
		private readonly RepeatedField<uint> trackUnlockList_ = new RepeatedField<uint>();
	}
}
