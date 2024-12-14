using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000B7 RID: 183
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AssistSimpleInfo : IMessage<AssistSimpleInfo>, IMessage, IEquatable<AssistSimpleInfo>, IDeepCloneable<AssistSimpleInfo>, IBufferMessage
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00016161 File Offset: 0x00014361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AssistSimpleInfo> Parser
		{
			get
			{
				return AssistSimpleInfo._parser;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060007D5 RID: 2005 RVA: 0x00016168 File Offset: 0x00014368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AssistSimpleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0001617A File Offset: 0x0001437A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AssistSimpleInfo.Descriptor;
			}
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00016181 File Offset: 0x00014381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AssistSimpleInfo()
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0001618C File Offset: 0x0001438C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AssistSimpleInfo(AssistSimpleInfo other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this.pos_ = other.pos_;
			this.dressedSkinId_ = other.dressedSkinId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x000161E0 File Offset: 0x000143E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AssistSimpleInfo Clone()
		{
			return new AssistSimpleInfo(this);
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x000161E8 File Offset: 0x000143E8
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x000161F0 File Offset: 0x000143F0
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

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x060007DC RID: 2012 RVA: 0x000161F9 File Offset: 0x000143F9
		// (set) Token: 0x060007DD RID: 2013 RVA: 0x00016201 File Offset: 0x00014401
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

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060007DE RID: 2014 RVA: 0x0001620A File Offset: 0x0001440A
		// (set) Token: 0x060007DF RID: 2015 RVA: 0x00016212 File Offset: 0x00014412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DressedSkinId
		{
			get
			{
				return this.dressedSkinId_;
			}
			set
			{
				this.dressedSkinId_ = value;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060007E0 RID: 2016 RVA: 0x0001621B File Offset: 0x0001441B
		// (set) Token: 0x060007E1 RID: 2017 RVA: 0x00016223 File Offset: 0x00014423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0001622C File Offset: 0x0001442C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AssistSimpleInfo);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0001623C File Offset: 0x0001443C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AssistSimpleInfo other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && this.Pos == other.Pos && this.DressedSkinId == other.DressedSkinId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000162A8 File Offset: 0x000144A8
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
			if (this.DressedSkinId != 0U)
			{
				num ^= this.DressedSkinId.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00016332 File Offset: 0x00014532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0001633A File Offset: 0x0001453A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00016344 File Offset: 0x00014544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DressedSkinId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DressedSkinId);
			}
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.Pos != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Pos);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000163D8 File Offset: 0x000145D8
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
			if (this.DressedSkinId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DressedSkinId);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00016460 File Offset: 0x00014660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AssistSimpleInfo other)
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
			if (other.DressedSkinId != 0U)
			{
				this.DressedSkinId = other.DressedSkinId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000164D8 File Offset: 0x000146D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x000164E4 File Offset: 0x000146E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 16U)
					{
						this.DressedSkinId = input.ReadUInt32();
						continue;
					}
					if (num == 64U)
					{
						this.AvatarId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Pos = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040002F0 RID: 752
		private static readonly MessageParser<AssistSimpleInfo> _parser = new MessageParser<AssistSimpleInfo>(() => new AssistSimpleInfo());

		// Token: 0x040002F1 RID: 753
		private UnknownFieldSet _unknownFields;

		// Token: 0x040002F2 RID: 754
		public const int AvatarIdFieldNumber = 8;

		// Token: 0x040002F3 RID: 755
		private uint avatarId_;

		// Token: 0x040002F4 RID: 756
		public const int PosFieldNumber = 10;

		// Token: 0x040002F5 RID: 757
		private uint pos_;

		// Token: 0x040002F6 RID: 758
		public const int DressedSkinIdFieldNumber = 2;

		// Token: 0x040002F7 RID: 759
		private uint dressedSkinId_;

		// Token: 0x040002F8 RID: 760
		public const int LevelFieldNumber = 12;

		// Token: 0x040002F9 RID: 761
		private uint level_;
	}
}
