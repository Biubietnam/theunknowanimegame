using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003AB RID: 939
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DisplayAvatarData : IMessage<DisplayAvatarData>, IMessage, IEquatable<DisplayAvatarData>, IDeepCloneable<DisplayAvatarData>, IBufferMessage
	{
		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x00073E60 File Offset: 0x00072060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DisplayAvatarData> Parser
		{
			get
			{
				return DisplayAvatarData._parser;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x00073E67 File Offset: 0x00072067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DisplayAvatarDataReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x00073E79 File Offset: 0x00072079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DisplayAvatarData.Descriptor;
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x00073E80 File Offset: 0x00072080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarData()
		{
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x00073E88 File Offset: 0x00072088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarData(DisplayAvatarData other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.pos_ = other.pos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00073EB9 File Offset: 0x000720B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarData Clone()
		{
			return new DisplayAvatarData(this);
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x00073EC1 File Offset: 0x000720C1
		// (set) Token: 0x060029BA RID: 10682 RVA: 0x00073EC9 File Offset: 0x000720C9
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x00073ED2 File Offset: 0x000720D2
		// (set) Token: 0x060029BC RID: 10684 RVA: 0x00073EDA File Offset: 0x000720DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x00073EE3 File Offset: 0x000720E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DisplayAvatarData);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x00073EF1 File Offset: 0x000720F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DisplayAvatarData other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.Pos == other.Pos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x00073F30 File Offset: 0x00072130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this.Pos != 0U)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x00073F88 File Offset: 0x00072188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x00073F90 File Offset: 0x00072190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x00073F9C File Offset: 0x0007219C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.Pos != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x00073FF8 File Offset: 0x000721F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this.Pos != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x00074050 File Offset: 0x00072250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DisplayAvatarData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			if (other.Pos != 0U)
			{
				this.Pos = other.Pos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000740A0 File Offset: 0x000722A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x000740AC File Offset: 0x000722AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Pos = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040010D1 RID: 4305
		private static readonly MessageParser<DisplayAvatarData> _parser = new MessageParser<DisplayAvatarData>(() => new DisplayAvatarData());

		// Token: 0x040010D2 RID: 4306
		private UnknownFieldSet _unknownFields;

		// Token: 0x040010D3 RID: 4307
		public const int AvatarIdFieldNumber = 5;

		// Token: 0x040010D4 RID: 4308
		private uint avatarId_;

		// Token: 0x040010D5 RID: 4309
		public const int PosFieldNumber = 8;

		// Token: 0x040010D6 RID: 4310
		private uint pos_;
	}
}
