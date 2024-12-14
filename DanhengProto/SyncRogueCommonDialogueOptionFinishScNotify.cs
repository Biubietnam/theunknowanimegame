using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001287 RID: 4743
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueCommonDialogueOptionFinishScNotify : IMessage<SyncRogueCommonDialogueOptionFinishScNotify>, IMessage, IEquatable<SyncRogueCommonDialogueOptionFinishScNotify>, IDeepCloneable<SyncRogueCommonDialogueOptionFinishScNotify>, IBufferMessage
	{
		// Token: 0x17003B89 RID: 15241
		// (get) Token: 0x0600D399 RID: 54169 RVA: 0x0023512C File Offset: 0x0023332C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueCommonDialogueOptionFinishScNotify> Parser
		{
			get
			{
				return SyncRogueCommonDialogueOptionFinishScNotify._parser;
			}
		}

		// Token: 0x17003B8A RID: 15242
		// (get) Token: 0x0600D39A RID: 54170 RVA: 0x00235133 File Offset: 0x00233333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonDialogueOptionFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x0600D39B RID: 54171 RVA: 0x00235145 File Offset: 0x00233345
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueCommonDialogueOptionFinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600D39C RID: 54172 RVA: 0x0023514C File Offset: 0x0023334C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonDialogueOptionFinishScNotify()
		{
		}

		// Token: 0x0600D39D RID: 54173 RVA: 0x00235154 File Offset: 0x00233354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonDialogueOptionFinishScNotify(SyncRogueCommonDialogueOptionFinishScNotify other) : this()
		{
			this.eventUniqueId_ = other.eventUniqueId_;
			this.optionId_ = other.optionId_;
			this.resultOptionInfo_ = ((other.resultOptionInfo_ != null) ? other.resultOptionInfo_.Clone() : null);
			this.dialogueData_ = ((other.dialogueData_ != null) ? other.dialogueData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D39E RID: 54174 RVA: 0x002351C8 File Offset: 0x002333C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonDialogueOptionFinishScNotify Clone()
		{
			return new SyncRogueCommonDialogueOptionFinishScNotify(this);
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x0600D39F RID: 54175 RVA: 0x002351D0 File Offset: 0x002333D0
		// (set) Token: 0x0600D3A0 RID: 54176 RVA: 0x002351D8 File Offset: 0x002333D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x0600D3A1 RID: 54177 RVA: 0x002351E1 File Offset: 0x002333E1
		// (set) Token: 0x0600D3A2 RID: 54178 RVA: 0x002351E9 File Offset: 0x002333E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionId
		{
			get
			{
				return this.optionId_;
			}
			set
			{
				this.optionId_ = value;
			}
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x0600D3A3 RID: 54179 RVA: 0x002351F2 File Offset: 0x002333F2
		// (set) Token: 0x0600D3A4 RID: 54180 RVA: 0x002351FA File Offset: 0x002333FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueOptionInfo ResultOptionInfo
		{
			get
			{
				return this.resultOptionInfo_;
			}
			set
			{
				this.resultOptionInfo_ = value;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x0600D3A5 RID: 54181 RVA: 0x00235203 File Offset: 0x00233403
		// (set) Token: 0x0600D3A6 RID: 54182 RVA: 0x0023520B File Offset: 0x0023340B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueCommonDialogueDataInfo DialogueData
		{
			get
			{
				return this.dialogueData_;
			}
			set
			{
				this.dialogueData_ = value;
			}
		}

		// Token: 0x0600D3A7 RID: 54183 RVA: 0x00235214 File Offset: 0x00233414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueCommonDialogueOptionFinishScNotify);
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x00235224 File Offset: 0x00233424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueCommonDialogueOptionFinishScNotify other)
		{
			return other != null && (other == this || (this.EventUniqueId == other.EventUniqueId && this.OptionId == other.OptionId && object.Equals(this.ResultOptionInfo, other.ResultOptionInfo) && object.Equals(this.DialogueData, other.DialogueData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x00235298 File Offset: 0x00233498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			if (this.resultOptionInfo_ != null)
			{
				num ^= this.ResultOptionInfo.GetHashCode();
			}
			if (this.dialogueData_ != null)
			{
				num ^= this.DialogueData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D3AA RID: 54186 RVA: 0x0023531C File Offset: 0x0023351C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D3AB RID: 54187 RVA: 0x00235324 File Offset: 0x00233524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3AC RID: 54188 RVA: 0x00235330 File Offset: 0x00233530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.OptionId);
			}
			if (this.resultOptionInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ResultOptionInfo);
			}
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this.dialogueData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.DialogueData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3AD RID: 54189 RVA: 0x002353C4 File Offset: 0x002335C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			if (this.resultOptionInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ResultOptionInfo);
			}
			if (this.dialogueData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DialogueData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D3AE RID: 54190 RVA: 0x0023544C File Offset: 0x0023364C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueCommonDialogueOptionFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			if (other.resultOptionInfo_ != null)
			{
				if (this.resultOptionInfo_ == null)
				{
					this.ResultOptionInfo = new RogueCommonDialogueOptionInfo();
				}
				this.ResultOptionInfo.MergeFrom(other.ResultOptionInfo);
			}
			if (other.dialogueData_ != null)
			{
				if (this.dialogueData_ == null)
				{
					this.DialogueData = new RogueCommonDialogueDataInfo();
				}
				this.DialogueData.MergeFrom(other.DialogueData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D3AF RID: 54191 RVA: 0x002354F4 File Offset: 0x002336F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3B0 RID: 54192 RVA: 0x00235500 File Offset: 0x00233700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 24U)
					{
						this.OptionId = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.resultOptionInfo_ == null)
						{
							this.ResultOptionInfo = new RogueCommonDialogueOptionInfo();
						}
						input.ReadMessage(this.ResultOptionInfo);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.EventUniqueId = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.dialogueData_ == null)
						{
							this.DialogueData = new RogueCommonDialogueDataInfo();
						}
						input.ReadMessage(this.DialogueData);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040054B5 RID: 21685
		private static readonly MessageParser<SyncRogueCommonDialogueOptionFinishScNotify> _parser = new MessageParser<SyncRogueCommonDialogueOptionFinishScNotify>(() => new SyncRogueCommonDialogueOptionFinishScNotify());

		// Token: 0x040054B6 RID: 21686
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054B7 RID: 21687
		public const int EventUniqueIdFieldNumber = 7;

		// Token: 0x040054B8 RID: 21688
		private uint eventUniqueId_;

		// Token: 0x040054B9 RID: 21689
		public const int OptionIdFieldNumber = 3;

		// Token: 0x040054BA RID: 21690
		private uint optionId_;

		// Token: 0x040054BB RID: 21691
		public const int ResultOptionInfoFieldNumber = 4;

		// Token: 0x040054BC RID: 21692
		private RogueCommonDialogueOptionInfo resultOptionInfo_;

		// Token: 0x040054BD RID: 21693
		public const int DialogueDataFieldNumber = 11;

		// Token: 0x040054BE RID: 21694
		private RogueCommonDialogueDataInfo dialogueData_;
	}
}
