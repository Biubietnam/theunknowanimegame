using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BEF RID: 3055
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MusicRhythmUnlockSongNotify : IMessage<MusicRhythmUnlockSongNotify>, IMessage, IEquatable<MusicRhythmUnlockSongNotify>, IDeepCloneable<MusicRhythmUnlockSongNotify>, IBufferMessage
	{
		// Token: 0x170025EA RID: 9706
		// (get) Token: 0x06008739 RID: 34617 RVA: 0x00164C1C File Offset: 0x00162E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MusicRhythmUnlockSongNotify> Parser
		{
			get
			{
				return MusicRhythmUnlockSongNotify._parser;
			}
		}

		// Token: 0x170025EB RID: 9707
		// (get) Token: 0x0600873A RID: 34618 RVA: 0x00164C23 File Offset: 0x00162E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MusicRhythmUnlockSongNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170025EC RID: 9708
		// (get) Token: 0x0600873B RID: 34619 RVA: 0x00164C35 File Offset: 0x00162E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MusicRhythmUnlockSongNotify.Descriptor;
			}
		}

		// Token: 0x0600873C RID: 34620 RVA: 0x00164C3C File Offset: 0x00162E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockSongNotify()
		{
		}

		// Token: 0x0600873D RID: 34621 RVA: 0x00164C4F File Offset: 0x00162E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockSongNotify(MusicRhythmUnlockSongNotify other) : this()
		{
			this.musicUnlockList_ = other.musicUnlockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600873E RID: 34622 RVA: 0x00164C79 File Offset: 0x00162E79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MusicRhythmUnlockSongNotify Clone()
		{
			return new MusicRhythmUnlockSongNotify(this);
		}

		// Token: 0x170025ED RID: 9709
		// (get) Token: 0x0600873F RID: 34623 RVA: 0x00164C81 File Offset: 0x00162E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MusicUnlockList
		{
			get
			{
				return this.musicUnlockList_;
			}
		}

		// Token: 0x06008740 RID: 34624 RVA: 0x00164C89 File Offset: 0x00162E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MusicRhythmUnlockSongNotify);
		}

		// Token: 0x06008741 RID: 34625 RVA: 0x00164C97 File Offset: 0x00162E97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MusicRhythmUnlockSongNotify other)
		{
			return other != null && (other == this || (this.musicUnlockList_.Equals(other.musicUnlockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008742 RID: 34626 RVA: 0x00164CCC File Offset: 0x00162ECC
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

		// Token: 0x06008743 RID: 34627 RVA: 0x00164D00 File Offset: 0x00162F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008744 RID: 34628 RVA: 0x00164D08 File Offset: 0x00162F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008745 RID: 34629 RVA: 0x00164D11 File Offset: 0x00162F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.musicUnlockList_.WriteTo(ref output, MusicRhythmUnlockSongNotify._repeated_musicUnlockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008746 RID: 34630 RVA: 0x00164D38 File Offset: 0x00162F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.musicUnlockList_.CalculateSize(MusicRhythmUnlockSongNotify._repeated_musicUnlockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008747 RID: 34631 RVA: 0x00164D71 File Offset: 0x00162F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MusicRhythmUnlockSongNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.musicUnlockList_.Add(other.musicUnlockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008748 RID: 34632 RVA: 0x00164D9F File Offset: 0x00162F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008749 RID: 34633 RVA: 0x00164DA8 File Offset: 0x00162FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.musicUnlockList_.AddEntriesFrom(ref input, MusicRhythmUnlockSongNotify._repeated_musicUnlockList_codec);
				}
			}
		}

		// Token: 0x040033C6 RID: 13254
		private static readonly MessageParser<MusicRhythmUnlockSongNotify> _parser = new MessageParser<MusicRhythmUnlockSongNotify>(() => new MusicRhythmUnlockSongNotify());

		// Token: 0x040033C7 RID: 13255
		private UnknownFieldSet _unknownFields;

		// Token: 0x040033C8 RID: 13256
		public const int MusicUnlockListFieldNumber = 7;

		// Token: 0x040033C9 RID: 13257
		private static readonly FieldCodec<uint> _repeated_musicUnlockList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x040033CA RID: 13258
		private readonly RepeatedField<uint> musicUnlockList_ = new RepeatedField<uint>();
	}
}
