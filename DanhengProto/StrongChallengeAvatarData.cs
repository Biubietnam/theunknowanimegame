using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011F3 RID: 4595
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StrongChallengeAvatarData : IMessage<StrongChallengeAvatarData>, IMessage, IEquatable<StrongChallengeAvatarData>, IDeepCloneable<StrongChallengeAvatarData>, IBufferMessage
	{
		// Token: 0x170039F1 RID: 14833
		// (get) Token: 0x0600CD61 RID: 52577 RVA: 0x0022745B File Offset: 0x0022565B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StrongChallengeAvatarData> Parser
		{
			get
			{
				return StrongChallengeAvatarData._parser;
			}
		}

		// Token: 0x170039F2 RID: 14834
		// (get) Token: 0x0600CD62 RID: 52578 RVA: 0x00227462 File Offset: 0x00225662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StrongChallengeAvatarDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170039F3 RID: 14835
		// (get) Token: 0x0600CD63 RID: 52579 RVA: 0x00227474 File Offset: 0x00225674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StrongChallengeAvatarData.Descriptor;
			}
		}

		// Token: 0x0600CD64 RID: 52580 RVA: 0x0022747B File Offset: 0x0022567B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeAvatarData()
		{
		}

		// Token: 0x0600CD65 RID: 52581 RVA: 0x00227499 File Offset: 0x00225699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeAvatarData(StrongChallengeAvatarData other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD66 RID: 52582 RVA: 0x002274D4 File Offset: 0x002256D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeAvatarData Clone()
		{
			return new StrongChallengeAvatarData(this);
		}

		// Token: 0x170039F4 RID: 14836
		// (get) Token: 0x0600CD67 RID: 52583 RVA: 0x002274DC File Offset: 0x002256DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x170039F5 RID: 14837
		// (get) Token: 0x0600CD68 RID: 52584 RVA: 0x002274E4 File Offset: 0x002256E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<StrongChallengeAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x0600CD69 RID: 52585 RVA: 0x002274EC File Offset: 0x002256EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StrongChallengeAvatarData);
		}

		// Token: 0x0600CD6A RID: 52586 RVA: 0x002274FC File Offset: 0x002256FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StrongChallengeAvatarData other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x00227550 File Offset: 0x00225750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffList_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CD6C RID: 52588 RVA: 0x00227592 File Offset: 0x00225792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CD6D RID: 52589 RVA: 0x0022759A File Offset: 0x0022579A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD6E RID: 52590 RVA: 0x002275A3 File Offset: 0x002257A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, StrongChallengeAvatarData._repeated_avatarList_codec);
			this.buffList_.WriteTo(ref output, StrongChallengeAvatarData._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CD6F RID: 52591 RVA: 0x002275DC File Offset: 0x002257DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(StrongChallengeAvatarData._repeated_buffList_codec);
			num += this.avatarList_.CalculateSize(StrongChallengeAvatarData._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CD70 RID: 52592 RVA: 0x00227628 File Offset: 0x00225828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StrongChallengeAvatarData other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CD71 RID: 52593 RVA: 0x00227667 File Offset: 0x00225867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD72 RID: 52594 RVA: 0x00227670 File Offset: 0x00225870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.buffList_.AddEntriesFrom(ref input, StrongChallengeAvatarData._repeated_buffList_codec);
					}
				}
				else
				{
					this.avatarList_.AddEntriesFrom(ref input, StrongChallengeAvatarData._repeated_avatarList_codec);
				}
			}
		}

		// Token: 0x040052D3 RID: 21203
		private static readonly MessageParser<StrongChallengeAvatarData> _parser = new MessageParser<StrongChallengeAvatarData>(() => new StrongChallengeAvatarData());

		// Token: 0x040052D4 RID: 21204
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052D5 RID: 21205
		public const int BuffListFieldNumber = 13;

		// Token: 0x040052D6 RID: 21206
		private static readonly FieldCodec<uint> _repeated_buffList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x040052D7 RID: 21207
		private readonly RepeatedField<uint> buffList_ = new RepeatedField<uint>();

		// Token: 0x040052D8 RID: 21208
		public const int AvatarListFieldNumber = 11;

		// Token: 0x040052D9 RID: 21209
		private static readonly FieldCodec<StrongChallengeAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<StrongChallengeAvatar>(90U, StrongChallengeAvatar.Parser);

		// Token: 0x040052DA RID: 21210
		private readonly RepeatedField<StrongChallengeAvatar> avatarList_ = new RepeatedField<StrongChallengeAvatar>();
	}
}
