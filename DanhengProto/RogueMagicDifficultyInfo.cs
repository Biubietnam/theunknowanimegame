using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EBB RID: 3771
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicDifficultyInfo : IMessage<RogueMagicDifficultyInfo>, IMessage, IEquatable<RogueMagicDifficultyInfo>, IDeepCloneable<RogueMagicDifficultyInfo>, IBufferMessage
	{
		// Token: 0x17002F9C RID: 12188
		// (get) Token: 0x0600A887 RID: 43143 RVA: 0x001C6231 File Offset: 0x001C4431
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicDifficultyInfo> Parser
		{
			get
			{
				return RogueMagicDifficultyInfo._parser;
			}
		}

		// Token: 0x17002F9D RID: 12189
		// (get) Token: 0x0600A888 RID: 43144 RVA: 0x001C6238 File Offset: 0x001C4438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicDifficultyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F9E RID: 12190
		// (get) Token: 0x0600A889 RID: 43145 RVA: 0x001C624A File Offset: 0x001C444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicDifficultyInfo.Descriptor;
			}
		}

		// Token: 0x0600A88A RID: 43146 RVA: 0x001C6251 File Offset: 0x001C4451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicDifficultyInfo()
		{
		}

		// Token: 0x0600A88B RID: 43147 RVA: 0x001C6259 File Offset: 0x001C4459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicDifficultyInfo(RogueMagicDifficultyInfo other) : this()
		{
			this.isUnlocked_ = other.isUnlocked_;
			this.difficultyId_ = other.difficultyId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A88C RID: 43148 RVA: 0x001C628A File Offset: 0x001C448A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicDifficultyInfo Clone()
		{
			return new RogueMagicDifficultyInfo(this);
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x0600A88D RID: 43149 RVA: 0x001C6292 File Offset: 0x001C4492
		// (set) Token: 0x0600A88E RID: 43150 RVA: 0x001C629A File Offset: 0x001C449A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlocked
		{
			get
			{
				return this.isUnlocked_;
			}
			set
			{
				this.isUnlocked_ = value;
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0600A88F RID: 43151 RVA: 0x001C62A3 File Offset: 0x001C44A3
		// (set) Token: 0x0600A890 RID: 43152 RVA: 0x001C62AB File Offset: 0x001C44AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DifficultyId
		{
			get
			{
				return this.difficultyId_;
			}
			set
			{
				this.difficultyId_ = value;
			}
		}

		// Token: 0x0600A891 RID: 43153 RVA: 0x001C62B4 File Offset: 0x001C44B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicDifficultyInfo);
		}

		// Token: 0x0600A892 RID: 43154 RVA: 0x001C62C2 File Offset: 0x001C44C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicDifficultyInfo other)
		{
			return other != null && (other == this || (this.IsUnlocked == other.IsUnlocked && this.DifficultyId == other.DifficultyId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A893 RID: 43155 RVA: 0x001C6300 File Offset: 0x001C4500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this.DifficultyId != 0U)
			{
				num ^= this.DifficultyId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A894 RID: 43156 RVA: 0x001C6358 File Offset: 0x001C4558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A895 RID: 43157 RVA: 0x001C6360 File Offset: 0x001C4560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A896 RID: 43158 RVA: 0x001C636C File Offset: 0x001C456C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DifficultyId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DifficultyId);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsUnlocked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A897 RID: 43159 RVA: 0x001C63C8 File Offset: 0x001C45C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this.DifficultyId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DifficultyId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x001C6414 File Offset: 0x001C4614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicDifficultyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			if (other.DifficultyId != 0U)
			{
				this.DifficultyId = other.DifficultyId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x001C6464 File Offset: 0x001C4664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A89A RID: 43162 RVA: 0x001C6470 File Offset: 0x001C4670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsUnlocked = input.ReadBool();
					}
				}
				else
				{
					this.DifficultyId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040044E2 RID: 17634
		private static readonly MessageParser<RogueMagicDifficultyInfo> _parser = new MessageParser<RogueMagicDifficultyInfo>(() => new RogueMagicDifficultyInfo());

		// Token: 0x040044E3 RID: 17635
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044E4 RID: 17636
		public const int IsUnlockedFieldNumber = 10;

		// Token: 0x040044E5 RID: 17637
		private bool isUnlocked_;

		// Token: 0x040044E6 RID: 17638
		public const int DifficultyIdFieldNumber = 6;

		// Token: 0x040044E7 RID: 17639
		private uint difficultyId_;
	}
}
