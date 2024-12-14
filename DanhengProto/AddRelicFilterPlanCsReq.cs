using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000047 RID: 71
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddRelicFilterPlanCsReq : IMessage<AddRelicFilterPlanCsReq>, IMessage, IEquatable<AddRelicFilterPlanCsReq>, IDeepCloneable<AddRelicFilterPlanCsReq>, IBufferMessage
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00008B63 File Offset: 0x00006D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddRelicFilterPlanCsReq> Parser
		{
			get
			{
				return AddRelicFilterPlanCsReq._parser;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00008B6A File Offset: 0x00006D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AddRelicFilterPlanCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00008B7C File Offset: 0x00006D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRelicFilterPlanCsReq.Descriptor;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00008B83 File Offset: 0x00006D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRelicFilterPlanCsReq()
		{
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00008B98 File Offset: 0x00006D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRelicFilterPlanCsReq(AddRelicFilterPlanCsReq other) : this()
		{
			this.avatarIdOnCreate_ = other.avatarIdOnCreate_;
			this.name_ = other.name_;
			this.icon_ = ((other.icon_ != null) ? other.icon_.Clone() : null);
			this.settings_ = ((other.settings_ != null) ? other.settings_.Clone() : null);
			this.isMarked_ = other.isMarked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00008C18 File Offset: 0x00006E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddRelicFilterPlanCsReq Clone()
		{
			return new AddRelicFilterPlanCsReq(this);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00008C20 File Offset: 0x00006E20
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00008C28 File Offset: 0x00006E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarIdOnCreate
		{
			get
			{
				return this.avatarIdOnCreate_;
			}
			set
			{
				this.avatarIdOnCreate_ = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00008C31 File Offset: 0x00006E31
		// (set) Token: 0x060002CD RID: 717 RVA: 0x00008C39 File Offset: 0x00006E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00008C4C File Offset: 0x00006E4C
		// (set) Token: 0x060002CF RID: 719 RVA: 0x00008C54 File Offset: 0x00006E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanIcon Icon
		{
			get
			{
				return this.icon_;
			}
			set
			{
				this.icon_ = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x00008C5D File Offset: 0x00006E5D
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00008C65 File Offset: 0x00006E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicFilterPlanSettings Settings
		{
			get
			{
				return this.settings_;
			}
			set
			{
				this.settings_ = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00008C6E File Offset: 0x00006E6E
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x00008C76 File Offset: 0x00006E76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMarked
		{
			get
			{
				return this.isMarked_;
			}
			set
			{
				this.isMarked_ = value;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00008C7F File Offset: 0x00006E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddRelicFilterPlanCsReq);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00008C90 File Offset: 0x00006E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddRelicFilterPlanCsReq other)
		{
			return other != null && (other == this || (this.AvatarIdOnCreate == other.AvatarIdOnCreate && !(this.Name != other.Name) && object.Equals(this.Icon, other.Icon) && object.Equals(this.Settings, other.Settings) && this.IsMarked == other.IsMarked && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00008D18 File Offset: 0x00006F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarIdOnCreate != 0U)
			{
				num ^= this.AvatarIdOnCreate.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.icon_ != null)
			{
				num ^= this.Icon.GetHashCode();
			}
			if (this.settings_ != null)
			{
				num ^= this.Settings.GetHashCode();
			}
			if (this.IsMarked)
			{
				num ^= this.IsMarked.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00008DB7 File Offset: 0x00006FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00008DBF File Offset: 0x00006FBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00008DC8 File Offset: 0x00006FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.icon_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Icon);
			}
			if (this.IsMarked)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsMarked);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.Name);
			}
			if (this.AvatarIdOnCreate != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.AvatarIdOnCreate);
			}
			if (this.settings_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.Settings);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00008E7C File Offset: 0x0000707C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarIdOnCreate != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarIdOnCreate);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.icon_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Icon);
			}
			if (this.settings_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Settings);
			}
			if (this.IsMarked)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00008F14 File Offset: 0x00007114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddRelicFilterPlanCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarIdOnCreate != 0U)
			{
				this.AvatarIdOnCreate = other.AvatarIdOnCreate;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.icon_ != null)
			{
				if (this.icon_ == null)
				{
					this.Icon = new RelicFilterPlanIcon();
				}
				this.Icon.MergeFrom(other.Icon);
			}
			if (other.settings_ != null)
			{
				if (this.settings_ == null)
				{
					this.Settings = new RelicFilterPlanSettings();
				}
				this.Settings.MergeFrom(other.Settings);
			}
			if (other.IsMarked)
			{
				this.IsMarked = other.IsMarked;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00008FD5 File Offset: 0x000071D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00008FE0 File Offset: 0x000071E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 50U)
					{
						if (this.icon_ == null)
						{
							this.Icon = new RelicFilterPlanIcon();
						}
						input.ReadMessage(this.Icon);
						continue;
					}
					if (num == 56U)
					{
						this.IsMarked = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 66U)
					{
						this.Name = input.ReadString();
						continue;
					}
					if (num == 88U)
					{
						this.AvatarIdOnCreate = input.ReadUInt32();
						continue;
					}
					if (num == 106U)
					{
						if (this.settings_ == null)
						{
							this.Settings = new RelicFilterPlanSettings();
						}
						input.ReadMessage(this.Settings);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040000FC RID: 252
		private static readonly MessageParser<AddRelicFilterPlanCsReq> _parser = new MessageParser<AddRelicFilterPlanCsReq>(() => new AddRelicFilterPlanCsReq());

		// Token: 0x040000FD RID: 253
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000FE RID: 254
		public const int AvatarIdOnCreateFieldNumber = 11;

		// Token: 0x040000FF RID: 255
		private uint avatarIdOnCreate_;

		// Token: 0x04000100 RID: 256
		public const int NameFieldNumber = 8;

		// Token: 0x04000101 RID: 257
		private string name_ = "";

		// Token: 0x04000102 RID: 258
		public const int IconFieldNumber = 6;

		// Token: 0x04000103 RID: 259
		private RelicFilterPlanIcon icon_;

		// Token: 0x04000104 RID: 260
		public const int SettingsFieldNumber = 13;

		// Token: 0x04000105 RID: 261
		private RelicFilterPlanSettings settings_;

		// Token: 0x04000106 RID: 262
		public const int IsMarkedFieldNumber = 7;

		// Token: 0x04000107 RID: 263
		private bool isMarked_;
	}
}
