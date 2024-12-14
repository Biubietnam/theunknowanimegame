using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008DD RID: 2269
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusUnlockSkillScNotify : IMessage<HeliobusUnlockSkillScNotify>, IMessage, IEquatable<HeliobusUnlockSkillScNotify>, IDeepCloneable<HeliobusUnlockSkillScNotify>, IBufferMessage
	{
		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06006530 RID: 25904 RVA: 0x0010EB6D File Offset: 0x0010CD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusUnlockSkillScNotify> Parser
		{
			get
			{
				return HeliobusUnlockSkillScNotify._parser;
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06006531 RID: 25905 RVA: 0x0010EB74 File Offset: 0x0010CD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusUnlockSkillScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06006532 RID: 25906 RVA: 0x0010EB86 File Offset: 0x0010CD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusUnlockSkillScNotify.Descriptor;
			}
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x0010EB8D File Offset: 0x0010CD8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUnlockSkillScNotify()
		{
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x0010EB95 File Offset: 0x0010CD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUnlockSkillScNotify(HeliobusUnlockSkillScNotify other) : this()
		{
			this.skillId_ = other.skillId_;
			this.jKGNKPJOKAF_ = other.jKGNKPJOKAF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x0010EBC6 File Offset: 0x0010CDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusUnlockSkillScNotify Clone()
		{
			return new HeliobusUnlockSkillScNotify(this);
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06006536 RID: 25910 RVA: 0x0010EBCE File Offset: 0x0010CDCE
		// (set) Token: 0x06006537 RID: 25911 RVA: 0x0010EBD6 File Offset: 0x0010CDD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06006538 RID: 25912 RVA: 0x0010EBDF File Offset: 0x0010CDDF
		// (set) Token: 0x06006539 RID: 25913 RVA: 0x0010EBE7 File Offset: 0x0010CDE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JKGNKPJOKAF
		{
			get
			{
				return this.jKGNKPJOKAF_;
			}
			set
			{
				this.jKGNKPJOKAF_ = value;
			}
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x0010EBF0 File Offset: 0x0010CDF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusUnlockSkillScNotify);
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x0010EBFE File Offset: 0x0010CDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusUnlockSkillScNotify other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.JKGNKPJOKAF == other.JKGNKPJOKAF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x0010EC3C File Offset: 0x0010CE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.JKGNKPJOKAF != 0U)
			{
				num ^= this.JKGNKPJOKAF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600653D RID: 25917 RVA: 0x0010EC94 File Offset: 0x0010CE94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600653E RID: 25918 RVA: 0x0010EC9C File Offset: 0x0010CE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600653F RID: 25919 RVA: 0x0010ECA8 File Offset: 0x0010CEA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.SkillId);
			}
			if (this.JKGNKPJOKAF != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.JKGNKPJOKAF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006540 RID: 25920 RVA: 0x0010ED04 File Offset: 0x0010CF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this.JKGNKPJOKAF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JKGNKPJOKAF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006541 RID: 25921 RVA: 0x0010ED5C File Offset: 0x0010CF5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusUnlockSkillScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			if (other.JKGNKPJOKAF != 0U)
			{
				this.JKGNKPJOKAF = other.JKGNKPJOKAF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006542 RID: 25922 RVA: 0x0010EDAC File Offset: 0x0010CFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x0010EDB8 File Offset: 0x0010CFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.JKGNKPJOKAF = input.ReadUInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040026F1 RID: 9969
		private static readonly MessageParser<HeliobusUnlockSkillScNotify> _parser = new MessageParser<HeliobusUnlockSkillScNotify>(() => new HeliobusUnlockSkillScNotify());

		// Token: 0x040026F2 RID: 9970
		private UnknownFieldSet _unknownFields;

		// Token: 0x040026F3 RID: 9971
		public const int SkillIdFieldNumber = 10;

		// Token: 0x040026F4 RID: 9972
		private uint skillId_;

		// Token: 0x040026F5 RID: 9973
		public const int JKGNKPJOKAFFieldNumber = 15;

		// Token: 0x040026F6 RID: 9974
		private uint jKGNKPJOKAF_;
	}
}
