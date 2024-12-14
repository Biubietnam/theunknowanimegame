using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013BF RID: 5055
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockBackGroundMusicScRsp : IMessage<UnlockBackGroundMusicScRsp>, IMessage, IEquatable<UnlockBackGroundMusicScRsp>, IDeepCloneable<UnlockBackGroundMusicScRsp>, IBufferMessage
	{
		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x0600E15A RID: 57690 RVA: 0x00257C1B File Offset: 0x00255E1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockBackGroundMusicScRsp> Parser
		{
			get
			{
				return UnlockBackGroundMusicScRsp._parser;
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x0600E15B RID: 57691 RVA: 0x00257C22 File Offset: 0x00255E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockBackGroundMusicScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x0600E15C RID: 57692 RVA: 0x00257C34 File Offset: 0x00255E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockBackGroundMusicScRsp.Descriptor;
			}
		}

		// Token: 0x0600E15D RID: 57693 RVA: 0x00257C3B File Offset: 0x00255E3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockBackGroundMusicScRsp()
		{
		}

		// Token: 0x0600E15E RID: 57694 RVA: 0x00257C5C File Offset: 0x00255E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockBackGroundMusicScRsp(UnlockBackGroundMusicScRsp other) : this()
		{
			this.unlockedMusicList_ = other.unlockedMusicList_.Clone();
			this.unlockedIds_ = other.unlockedIds_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E15F RID: 57695 RVA: 0x00257CAE File Offset: 0x00255EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockBackGroundMusicScRsp Clone()
		{
			return new UnlockBackGroundMusicScRsp(this);
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x0600E160 RID: 57696 RVA: 0x00257CB6 File Offset: 0x00255EB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MusicData> UnlockedMusicList
		{
			get
			{
				return this.unlockedMusicList_;
			}
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x0600E161 RID: 57697 RVA: 0x00257CBE File Offset: 0x00255EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnlockedIds
		{
			get
			{
				return this.unlockedIds_;
			}
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x0600E162 RID: 57698 RVA: 0x00257CC6 File Offset: 0x00255EC6
		// (set) Token: 0x0600E163 RID: 57699 RVA: 0x00257CCE File Offset: 0x00255ECE
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

		// Token: 0x0600E164 RID: 57700 RVA: 0x00257CD7 File Offset: 0x00255ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockBackGroundMusicScRsp);
		}

		// Token: 0x0600E165 RID: 57701 RVA: 0x00257CE8 File Offset: 0x00255EE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockBackGroundMusicScRsp other)
		{
			return other != null && (other == this || (this.unlockedMusicList_.Equals(other.unlockedMusicList_) && this.unlockedIds_.Equals(other.unlockedIds_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E166 RID: 57702 RVA: 0x00257D4C File Offset: 0x00255F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedMusicList_.GetHashCode();
			num ^= this.unlockedIds_.GetHashCode();
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

		// Token: 0x0600E167 RID: 57703 RVA: 0x00257DA7 File Offset: 0x00255FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E168 RID: 57704 RVA: 0x00257DAF File Offset: 0x00255FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E169 RID: 57705 RVA: 0x00257DB8 File Offset: 0x00255FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedMusicList_.WriteTo(ref output, UnlockBackGroundMusicScRsp._repeated_unlockedMusicList_codec);
			this.unlockedIds_.WriteTo(ref output, UnlockBackGroundMusicScRsp._repeated_unlockedIds_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E16A RID: 57706 RVA: 0x00257E18 File Offset: 0x00256018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedMusicList_.CalculateSize(UnlockBackGroundMusicScRsp._repeated_unlockedMusicList_codec);
			num += this.unlockedIds_.CalculateSize(UnlockBackGroundMusicScRsp._repeated_unlockedIds_codec);
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

		// Token: 0x0600E16B RID: 57707 RVA: 0x00257E7C File Offset: 0x0025607C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockBackGroundMusicScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedMusicList_.Add(other.unlockedMusicList_);
			this.unlockedIds_.Add(other.unlockedIds_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E16C RID: 57708 RVA: 0x00257EDA File Offset: 0x002560DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E16D RID: 57709 RVA: 0x00257EE4 File Offset: 0x002560E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 18U)
					{
						this.unlockedMusicList_.AddEntriesFrom(ref input, UnlockBackGroundMusicScRsp._repeated_unlockedMusicList_codec);
						continue;
					}
					if (num == 72U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 74U)
					{
						goto IL_44;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.unlockedIds_.AddEntriesFrom(ref input, UnlockBackGroundMusicScRsp._repeated_unlockedIds_codec);
			}
		}

		// Token: 0x040059B4 RID: 22964
		private static readonly MessageParser<UnlockBackGroundMusicScRsp> _parser = new MessageParser<UnlockBackGroundMusicScRsp>(() => new UnlockBackGroundMusicScRsp());

		// Token: 0x040059B5 RID: 22965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059B6 RID: 22966
		public const int UnlockedMusicListFieldNumber = 2;

		// Token: 0x040059B7 RID: 22967
		private static readonly FieldCodec<MusicData> _repeated_unlockedMusicList_codec = FieldCodec.ForMessage<MusicData>(18U, MusicData.Parser);

		// Token: 0x040059B8 RID: 22968
		private readonly RepeatedField<MusicData> unlockedMusicList_ = new RepeatedField<MusicData>();

		// Token: 0x040059B9 RID: 22969
		public const int UnlockedIdsFieldNumber = 9;

		// Token: 0x040059BA RID: 22970
		private static readonly FieldCodec<uint> _repeated_unlockedIds_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040059BB RID: 22971
		private readonly RepeatedField<uint> unlockedIds_ = new RepeatedField<uint>();

		// Token: 0x040059BC RID: 22972
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040059BD RID: 22973
		private uint retcode_;
	}
}
