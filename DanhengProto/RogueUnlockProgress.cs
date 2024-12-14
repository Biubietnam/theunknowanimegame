using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200102B RID: 4139
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueUnlockProgress : IMessage<RogueUnlockProgress>, IMessage, IEquatable<RogueUnlockProgress>, IDeepCloneable<RogueUnlockProgress>, IBufferMessage
	{
		// Token: 0x170033D5 RID: 13269
		// (get) Token: 0x0600B7FA RID: 47098 RVA: 0x001EDA51 File Offset: 0x001EBC51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueUnlockProgress> Parser
		{
			get
			{
				return RogueUnlockProgress._parser;
			}
		}

		// Token: 0x170033D6 RID: 13270
		// (get) Token: 0x0600B7FB RID: 47099 RVA: 0x001EDA58 File Offset: 0x001EBC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueUnlockProgressReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033D7 RID: 13271
		// (get) Token: 0x0600B7FC RID: 47100 RVA: 0x001EDA6A File Offset: 0x001EBC6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueUnlockProgress.Descriptor;
			}
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x001EDA71 File Offset: 0x001EBC71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueUnlockProgress()
		{
		}

		// Token: 0x0600B7FE RID: 47102 RVA: 0x001EDA79 File Offset: 0x001EBC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueUnlockProgress(RogueUnlockProgress other) : this()
		{
			this.unlockId_ = other.unlockId_;
			this.progress_ = other.progress_;
			this.finish_ = other.finish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x001EDAB6 File Offset: 0x001EBCB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueUnlockProgress Clone()
		{
			return new RogueUnlockProgress(this);
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600B800 RID: 47104 RVA: 0x001EDABE File Offset: 0x001EBCBE
		// (set) Token: 0x0600B801 RID: 47105 RVA: 0x001EDAC6 File Offset: 0x001EBCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint UnlockId
		{
			get
			{
				return this.unlockId_;
			}
			set
			{
				this.unlockId_ = value;
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600B802 RID: 47106 RVA: 0x001EDACF File Offset: 0x001EBCCF
		// (set) Token: 0x0600B803 RID: 47107 RVA: 0x001EDAD7 File Offset: 0x001EBCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Progress
		{
			get
			{
				return this.progress_;
			}
			set
			{
				this.progress_ = value;
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600B804 RID: 47108 RVA: 0x001EDAE0 File Offset: 0x001EBCE0
		// (set) Token: 0x0600B805 RID: 47109 RVA: 0x001EDAE8 File Offset: 0x001EBCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Finish
		{
			get
			{
				return this.finish_;
			}
			set
			{
				this.finish_ = value;
			}
		}

		// Token: 0x0600B806 RID: 47110 RVA: 0x001EDAF1 File Offset: 0x001EBCF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueUnlockProgress);
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x001EDB00 File Offset: 0x001EBD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueUnlockProgress other)
		{
			return other != null && (other == this || (this.UnlockId == other.UnlockId && this.Progress == other.Progress && this.Finish == other.Finish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B808 RID: 47112 RVA: 0x001EDB5C File Offset: 0x001EBD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.UnlockId != 0U)
			{
				num ^= this.UnlockId.GetHashCode();
			}
			if (this.Progress != 0U)
			{
				num ^= this.Progress.GetHashCode();
			}
			if (this.Finish)
			{
				num ^= this.Finish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x001EDBCD File Offset: 0x001EBDCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x001EDBD5 File Offset: 0x001EBDD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x001EDBE0 File Offset: 0x001EBDE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.UnlockId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.UnlockId);
			}
			if (this.Finish)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.Finish);
			}
			if (this.Progress != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Progress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x001EDC58 File Offset: 0x001EBE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.UnlockId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.UnlockId);
			}
			if (this.Progress != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Progress);
			}
			if (this.Finish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x001EDCBC File Offset: 0x001EBEBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueUnlockProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.UnlockId != 0U)
			{
				this.UnlockId = other.UnlockId;
			}
			if (other.Progress != 0U)
			{
				this.Progress = other.Progress;
			}
			if (other.Finish)
			{
				this.Finish = other.Finish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B80E RID: 47118 RVA: 0x001EDD20 File Offset: 0x001EBF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x001EDD2C File Offset: 0x001EBF2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Progress = input.ReadUInt32();
						}
					}
					else
					{
						this.Finish = input.ReadBool();
					}
				}
				else
				{
					this.UnlockId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004A8B RID: 19083
		private static readonly MessageParser<RogueUnlockProgress> _parser = new MessageParser<RogueUnlockProgress>(() => new RogueUnlockProgress());

		// Token: 0x04004A8C RID: 19084
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A8D RID: 19085
		public const int UnlockIdFieldNumber = 7;

		// Token: 0x04004A8E RID: 19086
		private uint unlockId_;

		// Token: 0x04004A8F RID: 19087
		public const int ProgressFieldNumber = 13;

		// Token: 0x04004A90 RID: 19088
		private uint progress_;

		// Token: 0x04004A91 RID: 19089
		public const int FinishFieldNumber = 12;

		// Token: 0x04004A92 RID: 19090
		private bool finish_;
	}
}
