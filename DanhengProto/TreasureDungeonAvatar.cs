using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001395 RID: 5013
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TreasureDungeonAvatar : IMessage<TreasureDungeonAvatar>, IMessage, IEquatable<TreasureDungeonAvatar>, IDeepCloneable<TreasureDungeonAvatar>, IBufferMessage
	{
		// Token: 0x17003ED1 RID: 16081
		// (get) Token: 0x0600DFB3 RID: 57267 RVA: 0x002533C5 File Offset: 0x002515C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureDungeonAvatar> Parser
		{
			get
			{
				return TreasureDungeonAvatar._parser;
			}
		}

		// Token: 0x17003ED2 RID: 16082
		// (get) Token: 0x0600DFB4 RID: 57268 RVA: 0x002533CC File Offset: 0x002515CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TreasureDungeonAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003ED3 RID: 16083
		// (get) Token: 0x0600DFB5 RID: 57269 RVA: 0x002533DE File Offset: 0x002515DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureDungeonAvatar.Descriptor;
			}
		}

		// Token: 0x0600DFB6 RID: 57270 RVA: 0x002533E5 File Offset: 0x002515E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonAvatar()
		{
		}

		// Token: 0x0600DFB7 RID: 57271 RVA: 0x002533ED File Offset: 0x002515ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonAvatar(TreasureDungeonAvatar other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DFB8 RID: 57272 RVA: 0x0025341E File Offset: 0x0025161E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureDungeonAvatar Clone()
		{
			return new TreasureDungeonAvatar(this);
		}

		// Token: 0x17003ED4 RID: 16084
		// (get) Token: 0x0600DFB9 RID: 57273 RVA: 0x00253426 File Offset: 0x00251626
		// (set) Token: 0x0600DFBA RID: 57274 RVA: 0x0025342E File Offset: 0x0025162E
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

		// Token: 0x17003ED5 RID: 16085
		// (get) Token: 0x0600DFBB RID: 57275 RVA: 0x00253437 File Offset: 0x00251637
		// (set) Token: 0x0600DFBC RID: 57276 RVA: 0x0025343F File Offset: 0x0025163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarType AvatarType
		{
			get
			{
				return this.avatarType_;
			}
			set
			{
				this.avatarType_ = value;
			}
		}

		// Token: 0x0600DFBD RID: 57277 RVA: 0x00253448 File Offset: 0x00251648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureDungeonAvatar);
		}

		// Token: 0x0600DFBE RID: 57278 RVA: 0x00253456 File Offset: 0x00251656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureDungeonAvatar other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DFBF RID: 57279 RVA: 0x00253494 File Offset: 0x00251694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.AvatarType != AvatarType.None)
			{
				num ^= this.AvatarType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DFC0 RID: 57280 RVA: 0x002534F2 File Offset: 0x002516F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DFC1 RID: 57281 RVA: 0x002534FA File Offset: 0x002516FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DFC2 RID: 57282 RVA: 0x00253504 File Offset: 0x00251704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DFC3 RID: 57283 RVA: 0x0025355C File Offset: 0x0025175C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.AvatarType != AvatarType.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.AvatarType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DFC4 RID: 57284 RVA: 0x002535B4 File Offset: 0x002517B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureDungeonAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DFC5 RID: 57285 RVA: 0x00253604 File Offset: 0x00251804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DFC6 RID: 57286 RVA: 0x00253610 File Offset: 0x00251810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.AvatarId = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarType = (AvatarType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040058E1 RID: 22753
		private static readonly MessageParser<TreasureDungeonAvatar> _parser = new MessageParser<TreasureDungeonAvatar>(() => new TreasureDungeonAvatar());

		// Token: 0x040058E2 RID: 22754
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058E3 RID: 22755
		public const int AvatarIdFieldNumber = 8;

		// Token: 0x040058E4 RID: 22756
		private uint avatarId_;

		// Token: 0x040058E5 RID: 22757
		public const int AvatarTypeFieldNumber = 1;

		// Token: 0x040058E6 RID: 22758
		private AvatarType avatarType_;
	}
}
