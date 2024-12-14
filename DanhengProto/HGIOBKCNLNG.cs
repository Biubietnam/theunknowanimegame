using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E5 RID: 2277
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HGIOBKCNLNG : IMessage<HGIOBKCNLNG>, IMessage, IEquatable<HGIOBKCNLNG>, IDeepCloneable<HGIOBKCNLNG>, IBufferMessage
	{
		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06006589 RID: 25993 RVA: 0x0010F7C7 File Offset: 0x0010D9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HGIOBKCNLNG> Parser
		{
			get
			{
				return HGIOBKCNLNG._parser;
			}
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600658A RID: 25994 RVA: 0x0010F7CE File Offset: 0x0010D9CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HGIOBKCNLNGReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x0600658B RID: 25995 RVA: 0x0010F7E0 File Offset: 0x0010D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HGIOBKCNLNG.Descriptor;
			}
		}

		// Token: 0x0600658C RID: 25996 RVA: 0x0010F7E7 File Offset: 0x0010D9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGIOBKCNLNG()
		{
		}

		// Token: 0x0600658D RID: 25997 RVA: 0x0010F7FC File Offset: 0x0010D9FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGIOBKCNLNG(HGIOBKCNLNG other) : this()
		{
			this.unlockedAeonNum_ = other.unlockedAeonNum_;
			this.aeonIdList_ = other.aeonIdList_.Clone();
			this.gameAeonId_ = other.gameAeonId_;
			this.isUnlocked_ = other.isUnlocked_;
			this.unlockedAeonEnhanceNum_ = other.unlockedAeonEnhanceNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600658E RID: 25998 RVA: 0x0010F861 File Offset: 0x0010DA61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HGIOBKCNLNG Clone()
		{
			return new HGIOBKCNLNG(this);
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x0600658F RID: 25999 RVA: 0x0010F869 File Offset: 0x0010DA69
		// (set) Token: 0x06006590 RID: 26000 RVA: 0x0010F871 File Offset: 0x0010DA71
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

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06006591 RID: 26001 RVA: 0x0010F87A File Offset: 0x0010DA7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AeonIdList
		{
			get
			{
				return this.aeonIdList_;
			}
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06006592 RID: 26002 RVA: 0x0010F882 File Offset: 0x0010DA82
		// (set) Token: 0x06006593 RID: 26003 RVA: 0x0010F88A File Offset: 0x0010DA8A
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

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06006594 RID: 26004 RVA: 0x0010F893 File Offset: 0x0010DA93
		// (set) Token: 0x06006595 RID: 26005 RVA: 0x0010F89B File Offset: 0x0010DA9B
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

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06006596 RID: 26006 RVA: 0x0010F8A4 File Offset: 0x0010DAA4
		// (set) Token: 0x06006597 RID: 26007 RVA: 0x0010F8AC File Offset: 0x0010DAAC
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

		// Token: 0x06006598 RID: 26008 RVA: 0x0010F8B5 File Offset: 0x0010DAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HGIOBKCNLNG);
		}

		// Token: 0x06006599 RID: 26009 RVA: 0x0010F8C4 File Offset: 0x0010DAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HGIOBKCNLNG other)
		{
			return other != null && (other == this || (this.UnlockedAeonNum == other.UnlockedAeonNum && this.aeonIdList_.Equals(other.aeonIdList_) && this.GameAeonId == other.GameAeonId && this.IsUnlocked == other.IsUnlocked && this.UnlockedAeonEnhanceNum == other.UnlockedAeonEnhanceNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600659A RID: 26010 RVA: 0x0010F944 File Offset: 0x0010DB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnlockedAeonNum != 0U)
			{
				num ^= this.UnlockedAeonNum.GetHashCode();
			}
			num ^= this.aeonIdList_.GetHashCode();
			if (this.GameAeonId != 0U)
			{
				num ^= this.GameAeonId.GetHashCode();
			}
			if (this.IsUnlocked)
			{
				num ^= this.IsUnlocked.GetHashCode();
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

		// Token: 0x0600659B RID: 26011 RVA: 0x0010F9DC File Offset: 0x0010DBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600659C RID: 26012 RVA: 0x0010F9E4 File Offset: 0x0010DBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600659D RID: 26013 RVA: 0x0010F9F0 File Offset: 0x0010DBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aeonIdList_.WriteTo(ref output, HGIOBKCNLNG._repeated_aeonIdList_codec);
			if (this.UnlockedAeonEnhanceNum != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.UnlockedAeonEnhanceNum);
			}
			if (this.IsUnlocked)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsUnlocked);
			}
			if (this.UnlockedAeonNum != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.UnlockedAeonNum);
			}
			if (this.GameAeonId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.GameAeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600659E RID: 26014 RVA: 0x0010FA94 File Offset: 0x0010DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnlockedAeonNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnlockedAeonNum);
			}
			num += this.aeonIdList_.CalculateSize(HGIOBKCNLNG._repeated_aeonIdList_codec);
			if (this.GameAeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAeonId);
			}
			if (this.IsUnlocked)
			{
				num += 2;
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

		// Token: 0x0600659F RID: 26015 RVA: 0x0010FB24 File Offset: 0x0010DD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HGIOBKCNLNG other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnlockedAeonNum != 0U)
			{
				this.UnlockedAeonNum = other.UnlockedAeonNum;
			}
			this.aeonIdList_.Add(other.aeonIdList_);
			if (other.GameAeonId != 0U)
			{
				this.GameAeonId = other.GameAeonId;
			}
			if (other.IsUnlocked)
			{
				this.IsUnlocked = other.IsUnlocked;
			}
			if (other.UnlockedAeonEnhanceNum != 0U)
			{
				this.UnlockedAeonEnhanceNum = other.UnlockedAeonEnhanceNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065A0 RID: 26016 RVA: 0x0010FBAD File Offset: 0x0010DDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065A1 RID: 26017 RVA: 0x0010FBB8 File Offset: 0x0010DDB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 24U || num == 26U)
					{
						this.aeonIdList_.AddEntriesFrom(ref input, HGIOBKCNLNG._repeated_aeonIdList_codec);
						continue;
					}
					if (num == 48U)
					{
						this.UnlockedAeonEnhanceNum = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.IsUnlocked = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.UnlockedAeonNum = input.ReadUInt32();
						continue;
					}
					if (num == 104U)
					{
						this.GameAeonId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400270C RID: 9996
		private static readonly MessageParser<HGIOBKCNLNG> _parser = new MessageParser<HGIOBKCNLNG>(() => new HGIOBKCNLNG());

		// Token: 0x0400270D RID: 9997
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400270E RID: 9998
		public const int UnlockedAeonNumFieldNumber = 10;

		// Token: 0x0400270F RID: 9999
		private uint unlockedAeonNum_;

		// Token: 0x04002710 RID: 10000
		public const int AeonIdListFieldNumber = 3;

		// Token: 0x04002711 RID: 10001
		private static readonly FieldCodec<uint> _repeated_aeonIdList_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002712 RID: 10002
		private readonly RepeatedField<uint> aeonIdList_ = new RepeatedField<uint>();

		// Token: 0x04002713 RID: 10003
		public const int GameAeonIdFieldNumber = 13;

		// Token: 0x04002714 RID: 10004
		private uint gameAeonId_;

		// Token: 0x04002715 RID: 10005
		public const int IsUnlockedFieldNumber = 9;

		// Token: 0x04002716 RID: 10006
		private bool isUnlocked_;

		// Token: 0x04002717 RID: 10007
		public const int UnlockedAeonEnhanceNumFieldNumber = 6;

		// Token: 0x04002718 RID: 10008
		private uint unlockedAeonEnhanceNum_;
	}
}
