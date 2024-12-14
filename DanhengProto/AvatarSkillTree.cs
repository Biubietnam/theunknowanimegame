using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020000C9 RID: 201
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AvatarSkillTree : IMessage<AvatarSkillTree>, IMessage, IEquatable<AvatarSkillTree>, IDeepCloneable<AvatarSkillTree>, IBufferMessage
	{
		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0001AF54 File Offset: 0x00019154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AvatarSkillTree> Parser
		{
			get
			{
				return AvatarSkillTree._parser;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0001AF5B File Offset: 0x0001915B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AvatarSkillTreeReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0001AF6D File Offset: 0x0001916D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AvatarSkillTree.Descriptor;
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0001AF74 File Offset: 0x00019174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarSkillTree()
		{
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0001AF7C File Offset: 0x0001917C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarSkillTree(AvatarSkillTree other) : this()
		{
			this.pointId_ = other.pointId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0001AFAD File Offset: 0x000191AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AvatarSkillTree Clone()
		{
			return new AvatarSkillTree(this);
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0001AFB5 File Offset: 0x000191B5
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x0001AFBD File Offset: 0x000191BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PointId
		{
			get
			{
				return this.pointId_;
			}
			set
			{
				this.pointId_ = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0001AFC6 File Offset: 0x000191C6
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x0001AFCE File Offset: 0x000191CE
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

		// Token: 0x06000915 RID: 2325 RVA: 0x0001AFD7 File Offset: 0x000191D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AvatarSkillTree);
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0001AFE5 File Offset: 0x000191E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AvatarSkillTree other)
		{
			return other != null && (other == this || (this.PointId == other.PointId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x0001B024 File Offset: 0x00019224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PointId != 0U)
			{
				num ^= this.PointId.GetHashCode();
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

		// Token: 0x06000918 RID: 2328 RVA: 0x0001B07C File Offset: 0x0001927C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001B084 File Offset: 0x00019284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001B090 File Offset: 0x00019290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PointId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PointId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001B0E8 File Offset: 0x000192E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PointId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PointId);
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

		// Token: 0x0600091C RID: 2332 RVA: 0x0001B140 File Offset: 0x00019340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AvatarSkillTree other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PointId != 0U)
			{
				this.PointId = other.PointId;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0001B190 File Offset: 0x00019390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0001B19C File Offset: 0x0001939C
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
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.PointId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040003B3 RID: 947
		private static readonly MessageParser<AvatarSkillTree> _parser = new MessageParser<AvatarSkillTree>(() => new AvatarSkillTree());

		// Token: 0x040003B4 RID: 948
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003B5 RID: 949
		public const int PointIdFieldNumber = 1;

		// Token: 0x040003B6 RID: 950
		private uint pointId_;

		// Token: 0x040003B7 RID: 951
		public const int LevelFieldNumber = 2;

		// Token: 0x040003B8 RID: 952
		private uint level_;
	}
}
