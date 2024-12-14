using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005D5 RID: 1493
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GameAeonInfo : IMessage<GameAeonInfo>, IMessage, IEquatable<GameAeonInfo>, IDeepCloneable<GameAeonInfo>, IBufferMessage
	{
		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x000B5BF1 File Offset: 0x000B3DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GameAeonInfo> Parser
		{
			get
			{
				return GameAeonInfo._parser;
			}
		}

		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x000B5BF8 File Offset: 0x000B3DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameAeonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x060042AF RID: 17071 RVA: 0x000B5C0A File Offset: 0x000B3E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAeonInfo.Descriptor;
			}
		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x000B5C11 File Offset: 0x000B3E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameAeonInfo()
		{
		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x000B5C19 File Offset: 0x000B3E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameAeonInfo(GameAeonInfo other) : this()
		{
			this.unlockedAeonEnhanceNum_ = other.unlockedAeonEnhanceNum_;
			this.isUnlocked_ = other.isUnlocked_;
			this.gameAeonId_ = other.gameAeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042B2 RID: 17074 RVA: 0x000B5C56 File Offset: 0x000B3E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GameAeonInfo Clone()
		{
			return new GameAeonInfo(this);
		}

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x060042B3 RID: 17075 RVA: 0x000B5C5E File Offset: 0x000B3E5E
		// (set) Token: 0x060042B4 RID: 17076 RVA: 0x000B5C66 File Offset: 0x000B3E66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UnlockedAeonEnhanceNum
		{
			get
			{
				return this.unlockedAeonEnhanceNum_;
			}
			set
			{
				this.unlockedAeonEnhanceNum_ = value;
			}
		}

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x060042B5 RID: 17077 RVA: 0x000B5C6F File Offset: 0x000B3E6F
		// (set) Token: 0x060042B6 RID: 17078 RVA: 0x000B5C77 File Offset: 0x000B3E77
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

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x060042B7 RID: 17079 RVA: 0x000B5C80 File Offset: 0x000B3E80
		// (set) Token: 0x060042B8 RID: 17080 RVA: 0x000B5C88 File Offset: 0x000B3E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameAeonId
		{
			get
			{
				return this.gameAeonId_;
			}
			set
			{
				this.gameAeonId_ = value;
			}
		}

		// Token: 0x060042B9 RID: 17081 RVA: 0x000B5C91 File Offset: 0x000B3E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAeonInfo);
		}

		// Token: 0x060042BA RID: 17082 RVA: 0x000B5CA0 File Offset: 0x000B3EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GameAeonInfo other)
		{
			return other != null && (other == this || (this.UnlockedAeonEnhanceNum == other.UnlockedAeonEnhanceNum && this.IsUnlocked == other.IsUnlocked && this.GameAeonId == other.GameAeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042BB RID: 17083 RVA: 0x000B5CFC File Offset: 0x000B3EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnlockedAeonEnhanceNum != 0U)
			{
				num ^= this.UnlockedAeonEnhanceNum.GetHashCode();
			}
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this.GameAeonId != 0U)
			{
				num ^= this.GameAeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x000B5D6D File Offset: 0x000B3F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x000B5D75 File Offset: 0x000B3F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x000B5D80 File Offset: 0x000B3F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnlockedAeonEnhanceNum != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.UnlockedAeonEnhanceNum);
			}
			if (this.GameAeonId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.GameAeonId);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsUnlocked);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042BF RID: 17087 RVA: 0x000B5DF8 File Offset: 0x000B3FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnlockedAeonEnhanceNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnlockedAeonEnhanceNum);
			}
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this.GameAeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060042C0 RID: 17088 RVA: 0x000B5E5C File Offset: 0x000B405C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GameAeonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnlockedAeonEnhanceNum != 0U)
			{
				this.UnlockedAeonEnhanceNum = other.UnlockedAeonEnhanceNum;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			if (other.GameAeonId != 0U)
			{
				this.GameAeonId = other.GameAeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060042C1 RID: 17089 RVA: 0x000B5EC0 File Offset: 0x000B40C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042C2 RID: 17090 RVA: 0x000B5ECC File Offset: 0x000B40CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					if (num != 88U)
					{
						if (num != 104U)
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
						this.GameAeonId = input.ReadUInt32();
					}
				}
				else
				{
					this.UnlockedAeonEnhanceNum = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001A81 RID: 6785
		private static readonly MessageParser<GameAeonInfo> _parser = new MessageParser<GameAeonInfo>(() => new GameAeonInfo());

		// Token: 0x04001A82 RID: 6786
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A83 RID: 6787
		public const int UnlockedAeonEnhanceNumFieldNumber = 10;

		// Token: 0x04001A84 RID: 6788
		private uint unlockedAeonEnhanceNum_;

		// Token: 0x04001A85 RID: 6789
		public const int IsUnlockedFieldNumber = 13;

		// Token: 0x04001A86 RID: 6790
		private bool isUnlocked_;

		// Token: 0x04001A87 RID: 6791
		public const int GameAeonIdFieldNumber = 11;

		// Token: 0x04001A88 RID: 6792
		private uint gameAeonId_;
	}
}
