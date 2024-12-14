using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D11 RID: 3345
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PropAeonInfo : IMessage<PropAeonInfo>, IMessage, IEquatable<PropAeonInfo>, IDeepCloneable<PropAeonInfo>, IBufferMessage
	{
		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x0600955B RID: 38235 RVA: 0x0018CED4 File Offset: 0x0018B0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PropAeonInfo> Parser
		{
			get
			{
				return PropAeonInfo._parser;
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x0018CEDB File Offset: 0x0018B0DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PropAeonInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x0600955D RID: 38237 RVA: 0x0018CEED File Offset: 0x0018B0ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PropAeonInfo.Descriptor;
			}
		}

		// Token: 0x0600955E RID: 38238 RVA: 0x0018CEF4 File Offset: 0x0018B0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropAeonInfo()
		{
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x0018CEFC File Offset: 0x0018B0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropAeonInfo(PropAeonInfo other) : this()
		{
			this.dialogueGroupId_ = other.dialogueGroupId_;
			this.aeonId_ = other.aeonId_;
			this.addExp_ = other.addExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009560 RID: 38240 RVA: 0x0018CF39 File Offset: 0x0018B139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PropAeonInfo Clone()
		{
			return new PropAeonInfo(this);
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x06009561 RID: 38241 RVA: 0x0018CF41 File Offset: 0x0018B141
		// (set) Token: 0x06009562 RID: 38242 RVA: 0x0018CF49 File Offset: 0x0018B149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DialogueGroupId
		{
			get
			{
				return this.dialogueGroupId_;
			}
			set
			{
				this.dialogueGroupId_ = value;
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x06009563 RID: 38243 RVA: 0x0018CF52 File Offset: 0x0018B152
		// (set) Token: 0x06009564 RID: 38244 RVA: 0x0018CF5A File Offset: 0x0018B15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x06009565 RID: 38245 RVA: 0x0018CF63 File Offset: 0x0018B163
		// (set) Token: 0x06009566 RID: 38246 RVA: 0x0018CF6B File Offset: 0x0018B16B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AddExp
		{
			get
			{
				return this.addExp_;
			}
			set
			{
				this.addExp_ = value;
			}
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x0018CF74 File Offset: 0x0018B174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PropAeonInfo);
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x0018CF84 File Offset: 0x0018B184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PropAeonInfo other)
		{
			return other != null && (other == this || (this.DialogueGroupId == other.DialogueGroupId && this.AeonId == other.AeonId && this.AddExp == other.AddExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x0018CFE0 File Offset: 0x0018B1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DialogueGroupId != 0U)
			{
				num ^= this.DialogueGroupId.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
			if (this.AddExp != 0U)
			{
				num ^= this.AddExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x0018D051 File Offset: 0x0018B251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x0018D059 File Offset: 0x0018B259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600956C RID: 38252 RVA: 0x0018D064 File Offset: 0x0018B264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AddExp != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.AddExp);
			}
			if (this.DialogueGroupId != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.DialogueGroupId);
			}
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.AeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x0018D0DC File Offset: 0x0018B2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DialogueGroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DialogueGroupId);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
			if (this.AddExp != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AddExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x0018D14C File Offset: 0x0018B34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PropAeonInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DialogueGroupId != 0U)
			{
				this.DialogueGroupId = other.DialogueGroupId;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
			}
			if (other.AddExp != 0U)
			{
				this.AddExp = other.AddExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x0018D1B0 File Offset: 0x0018B3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009570 RID: 38256 RVA: 0x0018D1BC File Offset: 0x0018B3BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 88U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.AeonId = input.ReadUInt32();
						}
					}
					else
					{
						this.DialogueGroupId = input.ReadUInt32();
					}
				}
				else
				{
					this.AddExp = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040039E0 RID: 14816
		private static readonly MessageParser<PropAeonInfo> _parser = new MessageParser<PropAeonInfo>(() => new PropAeonInfo());

		// Token: 0x040039E1 RID: 14817
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E2 RID: 14818
		public const int DialogueGroupIdFieldNumber = 11;

		// Token: 0x040039E3 RID: 14819
		private uint dialogueGroupId_;

		// Token: 0x040039E4 RID: 14820
		public const int AeonIdFieldNumber = 12;

		// Token: 0x040039E5 RID: 14821
		private uint aeonId_;

		// Token: 0x040039E6 RID: 14822
		public const int AddExpFieldNumber = 3;

		// Token: 0x040039E7 RID: 14823
		private uint addExp_;
	}
}
