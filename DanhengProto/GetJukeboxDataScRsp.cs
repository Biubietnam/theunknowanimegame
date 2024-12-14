using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006EB RID: 1771
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetJukeboxDataScRsp : IMessage<GetJukeboxDataScRsp>, IMessage, IEquatable<GetJukeboxDataScRsp>, IDeepCloneable<GetJukeboxDataScRsp>, IBufferMessage
	{
		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004F34 RID: 20276 RVA: 0x000D606F File Offset: 0x000D426F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetJukeboxDataScRsp> Parser
		{
			get
			{
				return GetJukeboxDataScRsp._parser;
			}
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x000D6076 File Offset: 0x000D4276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetJukeboxDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004F36 RID: 20278 RVA: 0x000D6088 File Offset: 0x000D4288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetJukeboxDataScRsp.Descriptor;
			}
		}

		// Token: 0x06004F37 RID: 20279 RVA: 0x000D608F File Offset: 0x000D428F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetJukeboxDataScRsp()
		{
		}

		// Token: 0x06004F38 RID: 20280 RVA: 0x000D60A4 File Offset: 0x000D42A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetJukeboxDataScRsp(GetJukeboxDataScRsp other) : this()
		{
			this.unlockedMusicList_ = other.unlockedMusicList_.Clone();
			this.currentMusicId_ = other.currentMusicId_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F39 RID: 20281 RVA: 0x000D60F1 File Offset: 0x000D42F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetJukeboxDataScRsp Clone()
		{
			return new GetJukeboxDataScRsp(this);
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x06004F3A RID: 20282 RVA: 0x000D60F9 File Offset: 0x000D42F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MusicData> UnlockedMusicList
		{
			get
			{
				return this.unlockedMusicList_;
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x000D6101 File Offset: 0x000D4301
		// (set) Token: 0x06004F3C RID: 20284 RVA: 0x000D6109 File Offset: 0x000D4309
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrentMusicId
		{
			get
			{
				return this.currentMusicId_;
			}
			set
			{
				this.currentMusicId_ = value;
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x000D6112 File Offset: 0x000D4312
		// (set) Token: 0x06004F3E RID: 20286 RVA: 0x000D611A File Offset: 0x000D431A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06004F3F RID: 20287 RVA: 0x000D6123 File Offset: 0x000D4323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetJukeboxDataScRsp);
		}

		// Token: 0x06004F40 RID: 20288 RVA: 0x000D6134 File Offset: 0x000D4334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetJukeboxDataScRsp other)
		{
			return other != null && (other == this || (this.unlockedMusicList_.Equals(other.unlockedMusicList_) && this.CurrentMusicId == other.CurrentMusicId && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F41 RID: 20289 RVA: 0x000D6194 File Offset: 0x000D4394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedMusicList_.GetHashCode();
			if (this.CurrentMusicId != 0U)
			{
				num ^= this.CurrentMusicId.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F42 RID: 20290 RVA: 0x000D61FA File Offset: 0x000D43FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x000D6202 File Offset: 0x000D4402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x000D620C File Offset: 0x000D440C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.CurrentMusicId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.CurrentMusicId);
			}
			this.unlockedMusicList_.WriteTo(ref output, GetJukeboxDataScRsp._repeated_unlockedMusicList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x000D6278 File Offset: 0x000D4478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedMusicList_.CalculateSize(GetJukeboxDataScRsp._repeated_unlockedMusicList_codec);
			if (this.CurrentMusicId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrentMusicId);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x000D62E4 File Offset: 0x000D44E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetJukeboxDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedMusicList_.Add(other.unlockedMusicList_);
			if (other.CurrentMusicId != 0U)
			{
				this.CurrentMusicId = other.CurrentMusicId;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x000D6345 File Offset: 0x000D4545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x000D6350 File Offset: 0x000D4550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 48U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.unlockedMusicList_.AddEntriesFrom(ref input, GetJukeboxDataScRsp._repeated_unlockedMusicList_codec);
						}
					}
					else
					{
						this.CurrentMusicId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001F3C RID: 7996
		private static readonly MessageParser<GetJukeboxDataScRsp> _parser = new MessageParser<GetJukeboxDataScRsp>(() => new GetJukeboxDataScRsp());

		// Token: 0x04001F3D RID: 7997
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F3E RID: 7998
		public const int UnlockedMusicListFieldNumber = 11;

		// Token: 0x04001F3F RID: 7999
		private static readonly FieldCodec<MusicData> _repeated_unlockedMusicList_codec = FieldCodec.ForMessage<MusicData>(90U, MusicData.Parser);

		// Token: 0x04001F40 RID: 8000
		private readonly RepeatedField<MusicData> unlockedMusicList_ = new RepeatedField<MusicData>();

		// Token: 0x04001F41 RID: 8001
		public const int CurrentMusicIdFieldNumber = 6;

		// Token: 0x04001F42 RID: 8002
		private uint currentMusicId_;

		// Token: 0x04001F43 RID: 8003
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04001F44 RID: 8004
		private uint retcode_;
	}
}
