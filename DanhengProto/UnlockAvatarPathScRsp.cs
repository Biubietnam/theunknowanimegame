using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013B9 RID: 5049
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class UnlockAvatarPathScRsp : IMessage<UnlockAvatarPathScRsp>, IMessage, IEquatable<UnlockAvatarPathScRsp>, IDeepCloneable<UnlockAvatarPathScRsp>, IBufferMessage
	{
		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x0600E117 RID: 57623 RVA: 0x0025722B File Offset: 0x0025542B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<UnlockAvatarPathScRsp> Parser
		{
			get
			{
				return UnlockAvatarPathScRsp._parser;
			}
		}

		// Token: 0x17003F3C RID: 16188
		// (get) Token: 0x0600E118 RID: 57624 RVA: 0x00257232 File Offset: 0x00255432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return UnlockAvatarPathScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F3D RID: 16189
		// (get) Token: 0x0600E119 RID: 57625 RVA: 0x00257244 File Offset: 0x00255444
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnlockAvatarPathScRsp.Descriptor;
			}
		}

		// Token: 0x0600E11A RID: 57626 RVA: 0x0025724B File Offset: 0x0025544B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarPathScRsp()
		{
		}

		// Token: 0x0600E11B RID: 57627 RVA: 0x00257260 File Offset: 0x00255460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarPathScRsp(UnlockAvatarPathScRsp other) : this()
		{
			this.basicTypeIdList_ = other.basicTypeIdList_.Clone();
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E11C RID: 57628 RVA: 0x002572C9 File Offset: 0x002554C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockAvatarPathScRsp Clone()
		{
			return new UnlockAvatarPathScRsp(this);
		}

		// Token: 0x17003F3E RID: 16190
		// (get) Token: 0x0600E11D RID: 57629 RVA: 0x002572D1 File Offset: 0x002554D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BasicTypeIdList
		{
			get
			{
				return this.basicTypeIdList_;
			}
		}

		// Token: 0x17003F3F RID: 16191
		// (get) Token: 0x0600E11E RID: 57630 RVA: 0x002572D9 File Offset: 0x002554D9
		// (set) Token: 0x0600E11F RID: 57631 RVA: 0x002572E1 File Offset: 0x002554E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17003F40 RID: 16192
		// (get) Token: 0x0600E120 RID: 57632 RVA: 0x002572EA File Offset: 0x002554EA
		// (set) Token: 0x0600E121 RID: 57633 RVA: 0x002572F2 File Offset: 0x002554F2
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

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x0600E122 RID: 57634 RVA: 0x002572FB File Offset: 0x002554FB
		// (set) Token: 0x0600E123 RID: 57635 RVA: 0x00257303 File Offset: 0x00255503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiPathAvatarType AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x0600E124 RID: 57636 RVA: 0x0025730C File Offset: 0x0025550C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnlockAvatarPathScRsp);
		}

		// Token: 0x0600E125 RID: 57637 RVA: 0x0025731C File Offset: 0x0025551C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UnlockAvatarPathScRsp other)
		{
			return other != null && (other == this || (this.basicTypeIdList_.Equals(other.basicTypeIdList_) && object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E126 RID: 57638 RVA: 0x00257390 File Offset: 0x00255590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.basicTypeIdList_.GetHashCode();
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E127 RID: 57639 RVA: 0x00257412 File Offset: 0x00255612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E128 RID: 57640 RVA: 0x0025741A File Offset: 0x0025561A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E129 RID: 57641 RVA: 0x00257424 File Offset: 0x00255624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Reward);
			}
			this.basicTypeIdList_.WriteTo(ref output, UnlockAvatarPathScRsp._repeated_basicTypeIdList_codec);
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E12A RID: 57642 RVA: 0x002574AC File Offset: 0x002556AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.basicTypeIdList_.CalculateSize(UnlockAvatarPathScRsp._repeated_basicTypeIdList_codec);
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.AvatarId != MultiPathAvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E12B RID: 57643 RVA: 0x00257530 File Offset: 0x00255730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UnlockAvatarPathScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.basicTypeIdList_.Add(other.basicTypeIdList_);
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.AvatarId != MultiPathAvatarType.None)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E12C RID: 57644 RVA: 0x002575BD File Offset: 0x002557BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E12D RID: 57645 RVA: 0x002575C8 File Offset: 0x002557C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 32U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 74U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				else
				{
					if (num == 80U || num == 82U)
					{
						this.basicTypeIdList_.AddEntriesFrom(ref input, UnlockAvatarPathScRsp._repeated_basicTypeIdList_codec);
						continue;
					}
					if (num == 104U)
					{
						this.AvatarId = (MultiPathAvatarType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400599D RID: 22941
		private static readonly MessageParser<UnlockAvatarPathScRsp> _parser = new MessageParser<UnlockAvatarPathScRsp>(() => new UnlockAvatarPathScRsp());

		// Token: 0x0400599E RID: 22942
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400599F RID: 22943
		public const int BasicTypeIdListFieldNumber = 10;

		// Token: 0x040059A0 RID: 22944
		private static readonly FieldCodec<uint> _repeated_basicTypeIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x040059A1 RID: 22945
		private readonly RepeatedField<uint> basicTypeIdList_ = new RepeatedField<uint>();

		// Token: 0x040059A2 RID: 22946
		public const int RewardFieldNumber = 9;

		// Token: 0x040059A3 RID: 22947
		private ItemList reward_;

		// Token: 0x040059A4 RID: 22948
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040059A5 RID: 22949
		private uint retcode_;

		// Token: 0x040059A6 RID: 22950
		public const int AvatarIdFieldNumber = 13;

		// Token: 0x040059A7 RID: 22951
		private MultiPathAvatarType avatarId_;
	}
}
