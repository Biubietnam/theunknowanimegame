using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200003D RID: 61
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddAvatarScNotify : IMessage<AddAvatarScNotify>, IMessage, IEquatable<AddAvatarScNotify>, IDeepCloneable<AddAvatarScNotify>, IBufferMessage
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00007D6B File Offset: 0x00005F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddAvatarScNotify> Parser
		{
			get
			{
				return AddAvatarScNotify._parser;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00007D72 File Offset: 0x00005F72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AddAvatarScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00007D84 File Offset: 0x00005F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddAvatarScNotify.Descriptor;
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00007D8B File Offset: 0x00005F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddAvatarScNotify()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007D94 File Offset: 0x00005F94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddAvatarScNotify(AddAvatarScNotify other) : this()
		{
			this.src_ = other.src_;
			this.baseAvatarId_ = other.baseAvatarId_;
			this.isNew_ = other.isNew_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007DF8 File Offset: 0x00005FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddAvatarScNotify Clone()
		{
			return new AddAvatarScNotify(this);
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00007E00 File Offset: 0x00006000
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00007E08 File Offset: 0x00006008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddAvatarSrcState Src
		{
			get
			{
				return this.src_;
			}
			set
			{
				this.src_ = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00007E11 File Offset: 0x00006011
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00007E19 File Offset: 0x00006019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BaseAvatarId
		{
			get
			{
				return this.baseAvatarId_;
			}
			set
			{
				this.baseAvatarId_ = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00007E22 File Offset: 0x00006022
		// (set) Token: 0x06000271 RID: 625 RVA: 0x00007E2A File Offset: 0x0000602A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00007E33 File Offset: 0x00006033
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00007E3B File Offset: 0x0000603B
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

		// Token: 0x06000274 RID: 628 RVA: 0x00007E44 File Offset: 0x00006044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddAvatarScNotify);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00007E54 File Offset: 0x00006054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddAvatarScNotify other)
		{
			return other != null && (other == this || (this.Src == other.Src && this.BaseAvatarId == other.BaseAvatarId && this.IsNew == other.IsNew && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00007EC4 File Offset: 0x000060C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Src != AddAvatarSrcState.AddAvatarSrcNone)
			{
				num ^= this.Src.GetHashCode();
			}
			if (this.BaseAvatarId != 0U)
			{
				num ^= this.BaseAvatarId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00007F51 File Offset: 0x00006151
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00007F59 File Offset: 0x00006159
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00007F64 File Offset: 0x00006164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNew);
			}
			if (this.Src != AddAvatarSrcState.AddAvatarSrcNone)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.Src);
			}
			if (this.BaseAvatarId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BaseAvatarId);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00007FF4 File Offset: 0x000061F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Src != AddAvatarSrcState.AddAvatarSrcNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Src);
			}
			if (this.BaseAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BaseAvatarId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00008070 File Offset: 0x00006270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddAvatarScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Src != AddAvatarSrcState.AddAvatarSrcNone)
			{
				this.Src = other.Src;
			}
			if (other.BaseAvatarId != 0U)
			{
				this.BaseAvatarId = other.BaseAvatarId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00008100 File Offset: 0x00006300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000810C File Offset: 0x0000630C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.IsNew = input.ReadBool();
						continue;
					}
					if (num == 24U)
					{
						this.Src = (AddAvatarSrcState)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.BaseAvatarId = input.ReadUInt32();
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
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000DB RID: 219
		private static readonly MessageParser<AddAvatarScNotify> _parser = new MessageParser<AddAvatarScNotify>(() => new AddAvatarScNotify());

		// Token: 0x040000DC RID: 220
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000DD RID: 221
		public const int SrcFieldNumber = 3;

		// Token: 0x040000DE RID: 222
		private AddAvatarSrcState src_;

		// Token: 0x040000DF RID: 223
		public const int BaseAvatarIdFieldNumber = 7;

		// Token: 0x040000E0 RID: 224
		private uint baseAvatarId_;

		// Token: 0x040000E1 RID: 225
		public const int IsNewFieldNumber = 1;

		// Token: 0x040000E2 RID: 226
		private bool isNew_;

		// Token: 0x040000E3 RID: 227
		public const int RewardFieldNumber = 9;

		// Token: 0x040000E4 RID: 228
		private ItemList reward_;
	}
}
