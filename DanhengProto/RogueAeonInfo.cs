using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DF5 RID: 3573
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAeonInfo : IMessage<RogueAeonInfo>, IMessage, IEquatable<RogueAeonInfo>, IDeepCloneable<RogueAeonInfo>, IBufferMessage
	{
		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x001AD103 File Offset: 0x001AB303
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAeonInfo> Parser
		{
			get
			{
				return RogueAeonInfo._parser;
			}
		}

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x06009FCA RID: 40906 RVA: 0x001AD10A File Offset: 0x001AB30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAeonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x001AD11C File Offset: 0x001AB31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAeonInfo.Descriptor;
			}
		}

		// Token: 0x06009FCC RID: 40908 RVA: 0x001AD123 File Offset: 0x001AB323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAeonInfo()
		{
		}

		// Token: 0x06009FCD RID: 40909 RVA: 0x001AD138 File Offset: 0x001AB338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAeonInfo(RogueAeonInfo other) : this()
		{
			this.aeonIdList_ = other.aeonIdList_.Clone();
			this.isUnlocked_ = other.isUnlocked_;
			this.unlockedAeonNum_ = other.unlockedAeonNum_;
			this.unlockedAeonEnhanceNum_ = other.unlockedAeonEnhanceNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FCE RID: 40910 RVA: 0x001AD191 File Offset: 0x001AB391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAeonInfo Clone()
		{
			return new RogueAeonInfo(this);
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x06009FCF RID: 40911 RVA: 0x001AD199 File Offset: 0x001AB399
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AeonIdList
		{
			get
			{
				return this.aeonIdList_;
			}
		}

		// Token: 0x17002D26 RID: 11558
		// (get) Token: 0x06009FD0 RID: 40912 RVA: 0x001AD1A1 File Offset: 0x001AB3A1
		// (set) Token: 0x06009FD1 RID: 40913 RVA: 0x001AD1A9 File Offset: 0x001AB3A9
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

		// Token: 0x17002D27 RID: 11559
		// (get) Token: 0x06009FD2 RID: 40914 RVA: 0x001AD1B2 File Offset: 0x001AB3B2
		// (set) Token: 0x06009FD3 RID: 40915 RVA: 0x001AD1BA File Offset: 0x001AB3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UnlockedAeonNum
		{
			get
			{
				return this.unlockedAeonNum_;
			}
			set
			{
				this.unlockedAeonNum_ = value;
			}
		}

		// Token: 0x17002D28 RID: 11560
		// (get) Token: 0x06009FD4 RID: 40916 RVA: 0x001AD1C3 File Offset: 0x001AB3C3
		// (set) Token: 0x06009FD5 RID: 40917 RVA: 0x001AD1CB File Offset: 0x001AB3CB
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

		// Token: 0x06009FD6 RID: 40918 RVA: 0x001AD1D4 File Offset: 0x001AB3D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAeonInfo);
		}

		// Token: 0x06009FD7 RID: 40919 RVA: 0x001AD1E4 File Offset: 0x001AB3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAeonInfo other)
		{
			return other != null && (other == this || (this.aeonIdList_.Equals(other.aeonIdList_) && this.IsUnlocked == other.IsUnlocked && this.UnlockedAeonNum == other.UnlockedAeonNum && this.UnlockedAeonEnhanceNum == other.UnlockedAeonEnhanceNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FD8 RID: 40920 RVA: 0x001AD254 File Offset: 0x001AB454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aeonIdList_.GetHashCode();
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
			}
			if (this.UnlockedAeonNum != 0U)
			{
				num ^= this.UnlockedAeonNum.GetHashCode();
			}
			if (this.UnlockedAeonEnhanceNum != 0U)
			{
				num ^= this.UnlockedAeonEnhanceNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FD9 RID: 40921 RVA: 0x001AD2D3 File Offset: 0x001AB4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009FDA RID: 40922 RVA: 0x001AD2DB File Offset: 0x001AB4DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FDB RID: 40923 RVA: 0x001AD2E4 File Offset: 0x001AB4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsUnlocked)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsUnlocked);
			}
			this.aeonIdList_.WriteTo(ref output, RogueAeonInfo._repeated_aeonIdList_codec);
			if (this.UnlockedAeonNum != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.UnlockedAeonNum);
			}
			if (this.UnlockedAeonEnhanceNum != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.UnlockedAeonEnhanceNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FDC RID: 40924 RVA: 0x001AD36C File Offset: 0x001AB56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aeonIdList_.CalculateSize(RogueAeonInfo._repeated_aeonIdList_codec);
			if (this.IsUnlocked)
			{
				num += 2;
			}
			if (this.UnlockedAeonNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnlockedAeonNum);
			}
			if (this.UnlockedAeonEnhanceNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnlockedAeonEnhanceNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x001AD3E4 File Offset: 0x001AB5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAeonInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.aeonIdList_.Add(other.aeonIdList_);
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			if (other.UnlockedAeonNum != 0U)
			{
				this.UnlockedAeonNum = other.UnlockedAeonNum;
			}
			if (other.UnlockedAeonEnhanceNum != 0U)
			{
				this.UnlockedAeonEnhanceNum = other.UnlockedAeonEnhanceNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x001AD459 File Offset: 0x001AB659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x001AD464 File Offset: 0x001AB664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 64U)
					{
						this.IsUnlocked = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						goto IL_44;
					}
				}
				else
				{
					if (num == 82U)
					{
						goto IL_44;
					}
					if (num == 88U)
					{
						this.UnlockedAeonNum = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.UnlockedAeonEnhanceNum = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_44:
				this.aeonIdList_.AddEntriesFrom(ref input, RogueAeonInfo._repeated_aeonIdList_codec);
			}
		}

		// Token: 0x04004188 RID: 16776
		private static readonly MessageParser<RogueAeonInfo> _parser = new MessageParser<RogueAeonInfo>(() => new RogueAeonInfo());

		// Token: 0x04004189 RID: 16777
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400418A RID: 16778
		public const int AeonIdListFieldNumber = 10;

		// Token: 0x0400418B RID: 16779
		private static readonly FieldCodec<uint> _repeated_aeonIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x0400418C RID: 16780
		private readonly RepeatedField<uint> aeonIdList_ = new RepeatedField<uint>();

		// Token: 0x0400418D RID: 16781
		public const int IsUnlockedFieldNumber = 8;

		// Token: 0x0400418E RID: 16782
		private bool isUnlocked_;

		// Token: 0x0400418F RID: 16783
		public const int UnlockedAeonNumFieldNumber = 11;

		// Token: 0x04004190 RID: 16784
		private uint unlockedAeonNum_;

		// Token: 0x04004191 RID: 16785
		public const int UnlockedAeonEnhanceNumFieldNumber = 15;

		// Token: 0x04004192 RID: 16786
		private uint unlockedAeonEnhanceNum_;
	}
}
