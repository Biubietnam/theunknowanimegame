using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CB1 RID: 3249
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerBoardModuleSync : IMessage<PlayerBoardModuleSync>, IMessage, IEquatable<PlayerBoardModuleSync>, IDeepCloneable<PlayerBoardModuleSync>, IBufferMessage
	{
		// Token: 0x17002893 RID: 10387
		// (get) Token: 0x0600906E RID: 36974 RVA: 0x0017D893 File Offset: 0x0017BA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerBoardModuleSync> Parser
		{
			get
			{
				return PlayerBoardModuleSync._parser;
			}
		}

		// Token: 0x17002894 RID: 10388
		// (get) Token: 0x0600906F RID: 36975 RVA: 0x0017D89A File Offset: 0x0017BA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerBoardModuleSyncReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002895 RID: 10389
		// (get) Token: 0x06009070 RID: 36976 RVA: 0x0017D8AC File Offset: 0x0017BAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBoardModuleSync.Descriptor;
			}
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x0017D8B3 File Offset: 0x0017BAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBoardModuleSync()
		{
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x0017D8D4 File Offset: 0x0017BAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBoardModuleSync(PlayerBoardModuleSync other) : this()
		{
			this.unlockedHeadIconList_ = other.unlockedHeadIconList_.Clone();
			this.kOIMGBMLOPB_ = other.kOIMGBMLOPB_;
			this.signature_ = other.signature_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x0017D921 File Offset: 0x0017BB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBoardModuleSync Clone()
		{
			return new PlayerBoardModuleSync(this);
		}

		// Token: 0x17002896 RID: 10390
		// (get) Token: 0x06009074 RID: 36980 RVA: 0x0017D929 File Offset: 0x0017BB29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HeadIconData> UnlockedHeadIconList
		{
			get
			{
				return this.unlockedHeadIconList_;
			}
		}

		// Token: 0x17002897 RID: 10391
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x0017D931 File Offset: 0x0017BB31
		// (set) Token: 0x06009076 RID: 36982 RVA: 0x0017D939 File Offset: 0x0017BB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool KOIMGBMLOPB
		{
			get
			{
				return this.kOIMGBMLOPB_;
			}
			set
			{
				this.kOIMGBMLOPB_ = value;
			}
		}

		// Token: 0x17002898 RID: 10392
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x0017D942 File Offset: 0x0017BB42
		// (set) Token: 0x06009078 RID: 36984 RVA: 0x0017D94A File Offset: 0x0017BB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x0017D95D File Offset: 0x0017BB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBoardModuleSync);
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x0017D96C File Offset: 0x0017BB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBoardModuleSync other)
		{
			return other != null && (other == this || (this.unlockedHeadIconList_.Equals(other.unlockedHeadIconList_) && this.KOIMGBMLOPB == other.KOIMGBMLOPB && !(this.Signature != other.Signature) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x0017D9D0 File Offset: 0x0017BBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockedHeadIconList_.GetHashCode();
			if (this.KOIMGBMLOPB)
			{
				num ^= this.KOIMGBMLOPB.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x0017DA38 File Offset: 0x0017BC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x0017DA40 File Offset: 0x0017BC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x0017DA4C File Offset: 0x0017BC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockedHeadIconList_.WriteTo(ref output, PlayerBoardModuleSync._repeated_unlockedHeadIconList_codec);
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Signature);
			}
			if (this.KOIMGBMLOPB)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.KOIMGBMLOPB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x0017DABC File Offset: 0x0017BCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockedHeadIconList_.CalculateSize(PlayerBoardModuleSync._repeated_unlockedHeadIconList_codec);
			if (this.KOIMGBMLOPB)
			{
				num += 2;
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009080 RID: 36992 RVA: 0x0017DB20 File Offset: 0x0017BD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerBoardModuleSync other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockedHeadIconList_.Add(other.unlockedHeadIconList_);
			if (other.KOIMGBMLOPB)
			{
				this.KOIMGBMLOPB = other.KOIMGBMLOPB;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x0017DB86 File Offset: 0x0017BD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x0017DB90 File Offset: 0x0017BD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 34U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.KOIMGBMLOPB = input.ReadBool();
						}
					}
					else
					{
						this.Signature = input.ReadString();
					}
				}
				else
				{
					this.unlockedHeadIconList_.AddEntriesFrom(ref input, PlayerBoardModuleSync._repeated_unlockedHeadIconList_codec);
				}
			}
		}

		// Token: 0x04003786 RID: 14214
		private static readonly MessageParser<PlayerBoardModuleSync> _parser = new MessageParser<PlayerBoardModuleSync>(() => new PlayerBoardModuleSync());

		// Token: 0x04003787 RID: 14215
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003788 RID: 14216
		public const int UnlockedHeadIconListFieldNumber = 2;

		// Token: 0x04003789 RID: 14217
		private static readonly FieldCodec<HeadIconData> _repeated_unlockedHeadIconList_codec = FieldCodec.ForMessage<HeadIconData>(18U, HeadIconData.Parser);

		// Token: 0x0400378A RID: 14218
		private readonly RepeatedField<HeadIconData> unlockedHeadIconList_ = new RepeatedField<HeadIconData>();

		// Token: 0x0400378B RID: 14219
		public const int KOIMGBMLOPBFieldNumber = 9;

		// Token: 0x0400378C RID: 14220
		private bool kOIMGBMLOPB_;

		// Token: 0x0400378D RID: 14221
		public const int SignatureFieldNumber = 4;

		// Token: 0x0400378E RID: 14222
		private string signature_ = "";
	}
}
