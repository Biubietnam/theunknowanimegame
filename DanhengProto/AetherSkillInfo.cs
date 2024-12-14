using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000071 RID: 113
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherSkillInfo : IMessage<AetherSkillInfo>, IMessage, IEquatable<AetherSkillInfo>, IDeepCloneable<AetherSkillInfo>, IBufferMessage
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0000DE19 File Offset: 0x0000C019
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherSkillInfo> Parser
		{
			get
			{
				return AetherSkillInfo._parser;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0000DE20 File Offset: 0x0000C020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherSkillInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0000DE32 File Offset: 0x0000C032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherSkillInfo.Descriptor;
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0000DE39 File Offset: 0x0000C039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherSkillInfo()
		{
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0000DE41 File Offset: 0x0000C041
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherSkillInfo(AetherSkillInfo other) : this()
		{
			this.itemId_ = other.itemId_;
			this.num_ = other.num_;
			this.skillDressAvatarId_ = other.skillDressAvatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0000DE7E File Offset: 0x0000C07E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherSkillInfo Clone()
		{
			return new AetherSkillInfo(this);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0000DE86 File Offset: 0x0000C086
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0000DE8E File Offset: 0x0000C08E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x0000DE97 File Offset: 0x0000C097
		// (set) Token: 0x060004B6 RID: 1206 RVA: 0x0000DE9F File Offset: 0x0000C09F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Num
		{
			get
			{
				return this.num_;
			}
			set
			{
				this.num_ = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0000DEA8 File Offset: 0x0000C0A8
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillDressAvatarId
		{
			get
			{
				return this.skillDressAvatarId_;
			}
			set
			{
				this.skillDressAvatarId_ = value;
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0000DEB9 File Offset: 0x0000C0B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherSkillInfo);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherSkillInfo other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.Num == other.Num && this.SkillDressAvatarId == other.SkillDressAvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0000DF24 File Offset: 0x0000C124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0U)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Num != 0U)
			{
				num ^= this.Num.GetHashCode();
			}
			if (this.SkillDressAvatarId != 0U)
			{
				num ^= this.SkillDressAvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0000DF95 File Offset: 0x0000C195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0000DF9D File Offset: 0x0000C19D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillDressAvatarId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.SkillDressAvatarId);
			}
			if (this.Num != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Num);
			}
			if (this.ItemId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0000E020 File Offset: 0x0000C220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ItemId);
			}
			if (this.Num != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Num);
			}
			if (this.SkillDressAvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillDressAvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0000E090 File Offset: 0x0000C290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherSkillInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0U)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Num != 0U)
			{
				this.Num = other.Num;
			}
			if (other.SkillDressAvatarId != 0U)
			{
				this.SkillDressAvatarId = other.SkillDressAvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0000E100 File Offset: 0x0000C300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 48U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ItemId = input.ReadUInt32();
						}
					}
					else
					{
						this.Num = input.ReadUInt32();
					}
				}
				else
				{
					this.SkillDressAvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040001BE RID: 446
		private static readonly MessageParser<AetherSkillInfo> _parser = new MessageParser<AetherSkillInfo>(() => new AetherSkillInfo());

		// Token: 0x040001BF RID: 447
		private UnknownFieldSet _unknownFields;

		// Token: 0x040001C0 RID: 448
		public const int ItemIdFieldNumber = 7;

		// Token: 0x040001C1 RID: 449
		private uint itemId_;

		// Token: 0x040001C2 RID: 450
		public const int NumFieldNumber = 6;

		// Token: 0x040001C3 RID: 451
		private uint num_;

		// Token: 0x040001C4 RID: 452
		public const int SkillDressAvatarIdFieldNumber = 4;

		// Token: 0x040001C5 RID: 453
		private uint skillDressAvatarId_;
	}
}
