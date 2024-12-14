using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D1B RID: 3355
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PunkLordBattleAvatar : IMessage<PunkLordBattleAvatar>, IMessage, IEquatable<PunkLordBattleAvatar>, IDeepCloneable<PunkLordBattleAvatar>, IBufferMessage
	{
		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x0018E524 File Offset: 0x0018C724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PunkLordBattleAvatar> Parser
		{
			get
			{
				return PunkLordBattleAvatar._parser;
			}
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x060095CC RID: 38348 RVA: 0x0018E52B File Offset: 0x0018C72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PunkLordBattleAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x060095CD RID: 38349 RVA: 0x0018E53D File Offset: 0x0018C73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PunkLordBattleAvatar.Descriptor;
			}
		}

		// Token: 0x060095CE RID: 38350 RVA: 0x0018E544 File Offset: 0x0018C744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleAvatar()
		{
		}

		// Token: 0x060095CF RID: 38351 RVA: 0x0018E54C File Offset: 0x0018C74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleAvatar(PunkLordBattleAvatar other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.avatarLevel_ = other.avatarLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095D0 RID: 38352 RVA: 0x0018E57D File Offset: 0x0018C77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PunkLordBattleAvatar Clone()
		{
			return new PunkLordBattleAvatar(this);
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x060095D1 RID: 38353 RVA: 0x0018E585 File Offset: 0x0018C785
		// (set) Token: 0x060095D2 RID: 38354 RVA: 0x0018E58D File Offset: 0x0018C78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
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

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x060095D3 RID: 38355 RVA: 0x0018E596 File Offset: 0x0018C796
		// (set) Token: 0x060095D4 RID: 38356 RVA: 0x0018E59E File Offset: 0x0018C79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarLevel
		{
			get
			{
				return this.avatarLevel_;
			}
			set
			{
				this.avatarLevel_ = value;
			}
		}

		// Token: 0x060095D5 RID: 38357 RVA: 0x0018E5A7 File Offset: 0x0018C7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PunkLordBattleAvatar);
		}

		// Token: 0x060095D6 RID: 38358 RVA: 0x0018E5B5 File Offset: 0x0018C7B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PunkLordBattleAvatar other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.AvatarLevel == other.AvatarLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095D7 RID: 38359 RVA: 0x0018E5F4 File Offset: 0x0018C7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.AvatarLevel != 0U)
			{
				num ^= this.AvatarLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095D8 RID: 38360 RVA: 0x0018E64C File Offset: 0x0018C84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060095D9 RID: 38361 RVA: 0x0018E654 File Offset: 0x0018C854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095DA RID: 38362 RVA: 0x0018E660 File Offset: 0x0018C860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.AvatarLevel != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AvatarLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095DB RID: 38363 RVA: 0x0018E6B8 File Offset: 0x0018C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.AvatarLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095DC RID: 38364 RVA: 0x0018E710 File Offset: 0x0018C910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PunkLordBattleAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.AvatarLevel != 0U)
			{
				this.AvatarLevel = other.AvatarLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095DD RID: 38365 RVA: 0x0018E760 File Offset: 0x0018C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095DE RID: 38366 RVA: 0x0018E76C File Offset: 0x0018C96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarLevel = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003A14 RID: 14868
		private static readonly MessageParser<PunkLordBattleAvatar> _parser = new MessageParser<PunkLordBattleAvatar>(() => new PunkLordBattleAvatar());

		// Token: 0x04003A15 RID: 14869
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003A16 RID: 14870
		public const int AvatarIdFieldNumber = 1;

		// Token: 0x04003A17 RID: 14871
		private uint avatarId_;

		// Token: 0x04003A18 RID: 14872
		public const int AvatarLevelFieldNumber = 2;

		// Token: 0x04003A19 RID: 14873
		private uint avatarLevel_;
	}
}
