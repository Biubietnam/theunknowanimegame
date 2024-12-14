using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A0F RID: 2575
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LineupAvatar : IMessage<LineupAvatar>, IMessage, IEquatable<LineupAvatar>, IDeepCloneable<LineupAvatar>, IBufferMessage
	{
		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600724B RID: 29259 RVA: 0x00130067 File Offset: 0x0012E267
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LineupAvatar> Parser
		{
			get
			{
				return LineupAvatar._parser;
			}
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600724C RID: 29260 RVA: 0x0013006E File Offset: 0x0012E26E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LineupAvatarReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600724D RID: 29261 RVA: 0x00130080 File Offset: 0x0012E280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineupAvatar.Descriptor;
			}
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x00130087 File Offset: 0x0012E287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupAvatar()
		{
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00130090 File Offset: 0x0012E290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupAvatar(LineupAvatar other) : this()
		{
			this.slot_ = other.slot_;
			this.satiety_ = other.satiety_;
			this.spBar_ = ((other.spBar_ != null) ? other.spBar_.Clone() : null);
			this.id_ = other.id_;
			this.hp_ = other.hp_;
			this.avatarType_ = other.avatarType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x0013010C File Offset: 0x0012E30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupAvatar Clone()
		{
			return new LineupAvatar(this);
		}

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x06007251 RID: 29265 RVA: 0x00130114 File Offset: 0x0012E314
		// (set) Token: 0x06007252 RID: 29266 RVA: 0x0013011C File Offset: 0x0012E31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Slot
		{
			get
			{
				return this.slot_;
			}
			set
			{
				this.slot_ = value;
			}
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06007253 RID: 29267 RVA: 0x00130125 File Offset: 0x0012E325
		// (set) Token: 0x06007254 RID: 29268 RVA: 0x0013012D File Offset: 0x0012E32D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Satiety
		{
			get
			{
				return this.satiety_;
			}
			set
			{
				this.satiety_ = value;
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06007255 RID: 29269 RVA: 0x00130136 File Offset: 0x0012E336
		// (set) Token: 0x06007256 RID: 29270 RVA: 0x0013013E File Offset: 0x0012E33E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpBarInfo SpBar
		{
			get
			{
				return this.spBar_;
			}
			set
			{
				this.spBar_ = value;
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06007257 RID: 29271 RVA: 0x00130147 File Offset: 0x0012E347
		// (set) Token: 0x06007258 RID: 29272 RVA: 0x0013014F File Offset: 0x0012E34F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06007259 RID: 29273 RVA: 0x00130158 File Offset: 0x0012E358
		// (set) Token: 0x0600725A RID: 29274 RVA: 0x00130160 File Offset: 0x0012E360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Hp
		{
			get
			{
				return this.hp_;
			}
			set
			{
				this.hp_ = value;
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x0600725B RID: 29275 RVA: 0x00130169 File Offset: 0x0012E369
		// (set) Token: 0x0600725C RID: 29276 RVA: 0x00130171 File Offset: 0x0012E371
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

		// Token: 0x0600725D RID: 29277 RVA: 0x0013017A File Offset: 0x0012E37A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineupAvatar);
		}

		// Token: 0x0600725E RID: 29278 RVA: 0x00130188 File Offset: 0x0012E388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineupAvatar other)
		{
			return other != null && (other == this || (this.Slot == other.Slot && this.Satiety == other.Satiety && object.Equals(this.SpBar, other.SpBar) && this.Id == other.Id && this.Hp == other.Hp && this.AvatarType == other.AvatarType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600725F RID: 29279 RVA: 0x00130218 File Offset: 0x0012E418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Slot != 0U)
			{
				num ^= this.Slot.GetHashCode();
			}
			if (this.Satiety != 0U)
			{
				num ^= this.Satiety.GetHashCode();
			}
			if (this.spBar_ != null)
			{
				num ^= this.SpBar.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Hp != 0U)
			{
				num ^= this.Hp.GetHashCode();
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

		// Token: 0x06007260 RID: 29280 RVA: 0x001302D7 File Offset: 0x0012E4D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x001302DF File Offset: 0x0012E4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007262 RID: 29282 RVA: 0x001302E8 File Offset: 0x0012E4E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Satiety != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Satiety);
			}
			if (this.Hp != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Hp);
			}
			if (this.AvatarType != AvatarType.None)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.AvatarType);
			}
			if (this.spBar_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SpBar);
			}
			if (this.Slot != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Slot);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007263 RID: 29283 RVA: 0x001303B4 File Offset: 0x0012E5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Slot != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Slot);
			}
			if (this.Satiety != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Satiety);
			}
			if (this.spBar_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpBar);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.Hp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Hp);
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

		// Token: 0x06007264 RID: 29284 RVA: 0x0013046C File Offset: 0x0012E66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineupAvatar other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Slot != 0U)
			{
				this.Slot = other.Slot;
			}
			if (other.Satiety != 0U)
			{
				this.Satiety = other.Satiety;
			}
			if (other.spBar_ != null)
			{
				if (this.spBar_ == null)
				{
					this.SpBar = new SpBarInfo();
				}
				this.SpBar.MergeFrom(other.SpBar);
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.Hp != 0U)
			{
				this.Hp = other.Hp;
			}
			if (other.AvatarType != AvatarType.None)
			{
				this.AvatarType = other.AvatarType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007265 RID: 29285 RVA: 0x00130524 File Offset: 0x0012E724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007266 RID: 29286 RVA: 0x00130530 File Offset: 0x0012E730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num == 16U)
					{
						this.Satiety = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Hp = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.AvatarType = (AvatarType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						if (this.spBar_ == null)
						{
							this.SpBar = new SpBarInfo();
						}
						input.ReadMessage(this.SpBar);
						continue;
					}
					if (num == 112U)
					{
						this.Slot = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BEA RID: 11242
		private static readonly MessageParser<LineupAvatar> _parser = new MessageParser<LineupAvatar>(() => new LineupAvatar());

		// Token: 0x04002BEB RID: 11243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BEC RID: 11244
		public const int SlotFieldNumber = 14;

		// Token: 0x04002BED RID: 11245
		private uint slot_;

		// Token: 0x04002BEE RID: 11246
		public const int SatietyFieldNumber = 2;

		// Token: 0x04002BEF RID: 11247
		private uint satiety_;

		// Token: 0x04002BF0 RID: 11248
		public const int SpBarFieldNumber = 13;

		// Token: 0x04002BF1 RID: 11249
		private SpBarInfo spBar_;

		// Token: 0x04002BF2 RID: 11250
		public const int IdFieldNumber = 15;

		// Token: 0x04002BF3 RID: 11251
		private uint id_;

		// Token: 0x04002BF4 RID: 11252
		public const int HpFieldNumber = 6;

		// Token: 0x04002BF5 RID: 11253
		private uint hp_;

		// Token: 0x04002BF6 RID: 11254
		public const int AvatarTypeFieldNumber = 9;

		// Token: 0x04002BF7 RID: 11255
		private AvatarType avatarType_;
	}
}
