using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000577 RID: 1399
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishEmotionDialoguePerformanceCsReq : IMessage<FinishEmotionDialoguePerformanceCsReq>, IMessage, IEquatable<FinishEmotionDialoguePerformanceCsReq>, IDeepCloneable<FinishEmotionDialoguePerformanceCsReq>, IBufferMessage
	{
		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06003E67 RID: 15975 RVA: 0x000AA99F File Offset: 0x000A8B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishEmotionDialoguePerformanceCsReq> Parser
		{
			get
			{
				return FinishEmotionDialoguePerformanceCsReq._parser;
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06003E68 RID: 15976 RVA: 0x000AA9A6 File Offset: 0x000A8BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishEmotionDialoguePerformanceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06003E69 RID: 15977 RVA: 0x000AA9B8 File Offset: 0x000A8BB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishEmotionDialoguePerformanceCsReq.Descriptor;
			}
		}

		// Token: 0x06003E6A RID: 15978 RVA: 0x000AA9BF File Offset: 0x000A8BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishEmotionDialoguePerformanceCsReq()
		{
		}

		// Token: 0x06003E6B RID: 15979 RVA: 0x000AA9C7 File Offset: 0x000A8BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishEmotionDialoguePerformanceCsReq(FinishEmotionDialoguePerformanceCsReq other) : this()
		{
			this.dialogueId_ = other.dialogueId_;
			this.scriptId_ = other.scriptId_;
			this.fPPEFBKBFDD_ = other.fPPEFBKBFDD_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E6C RID: 15980 RVA: 0x000AAA04 File Offset: 0x000A8C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishEmotionDialoguePerformanceCsReq Clone()
		{
			return new FinishEmotionDialoguePerformanceCsReq(this);
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06003E6D RID: 15981 RVA: 0x000AAA0C File Offset: 0x000A8C0C
		// (set) Token: 0x06003E6E RID: 15982 RVA: 0x000AAA14 File Offset: 0x000A8C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DialogueId
		{
			get
			{
				return this.dialogueId_;
			}
			set
			{
				this.dialogueId_ = value;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06003E6F RID: 15983 RVA: 0x000AAA1D File Offset: 0x000A8C1D
		// (set) Token: 0x06003E70 RID: 15984 RVA: 0x000AAA25 File Offset: 0x000A8C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ScriptId
		{
			get
			{
				return this.scriptId_;
			}
			set
			{
				this.scriptId_ = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06003E71 RID: 15985 RVA: 0x000AAA2E File Offset: 0x000A8C2E
		// (set) Token: 0x06003E72 RID: 15986 RVA: 0x000AAA36 File Offset: 0x000A8C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FPPEFBKBFDD
		{
			get
			{
				return this.fPPEFBKBFDD_;
			}
			set
			{
				this.fPPEFBKBFDD_ = value;
			}
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x000AAA3F File Offset: 0x000A8C3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishEmotionDialoguePerformanceCsReq);
		}

		// Token: 0x06003E74 RID: 15988 RVA: 0x000AAA50 File Offset: 0x000A8C50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishEmotionDialoguePerformanceCsReq other)
		{
			return other != null && (other == this || (this.DialogueId == other.DialogueId && this.ScriptId == other.ScriptId && this.FPPEFBKBFDD == other.FPPEFBKBFDD && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x000AAAAC File Offset: 0x000A8CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DialogueId != 0U)
			{
				num ^= this.DialogueId.GetHashCode();
			}
			if (this.ScriptId != 0U)
			{
				num ^= this.ScriptId.GetHashCode();
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				num ^= this.FPPEFBKBFDD.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x000AAB1D File Offset: 0x000A8D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E77 RID: 15991 RVA: 0x000AAB25 File Offset: 0x000A8D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E78 RID: 15992 RVA: 0x000AAB30 File Offset: 0x000A8D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DialogueId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.DialogueId);
			}
			if (this.ScriptId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.ScriptId);
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.FPPEFBKBFDD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E79 RID: 15993 RVA: 0x000AABA8 File Offset: 0x000A8DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DialogueId);
			}
			if (this.ScriptId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ScriptId);
			}
			if (this.FPPEFBKBFDD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FPPEFBKBFDD);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E7A RID: 15994 RVA: 0x000AAC18 File Offset: 0x000A8E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishEmotionDialoguePerformanceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DialogueId != 0U)
			{
				this.DialogueId = other.DialogueId;
			}
			if (other.ScriptId != 0U)
			{
				this.ScriptId = other.ScriptId;
			}
			if (other.FPPEFBKBFDD != 0U)
			{
				this.FPPEFBKBFDD = other.FPPEFBKBFDD;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E7B RID: 15995 RVA: 0x000AAC7C File Offset: 0x000A8E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E7C RID: 15996 RVA: 0x000AAC88 File Offset: 0x000A8E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.FPPEFBKBFDD = input.ReadUInt32();
						}
					}
					else
					{
						this.ScriptId = input.ReadUInt32();
					}
				}
				else
				{
					this.DialogueId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040018E8 RID: 6376
		private static readonly MessageParser<FinishEmotionDialoguePerformanceCsReq> _parser = new MessageParser<FinishEmotionDialoguePerformanceCsReq>(() => new FinishEmotionDialoguePerformanceCsReq());

		// Token: 0x040018E9 RID: 6377
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018EA RID: 6378
		public const int DialogueIdFieldNumber = 2;

		// Token: 0x040018EB RID: 6379
		private uint dialogueId_;

		// Token: 0x040018EC RID: 6380
		public const int ScriptIdFieldNumber = 3;

		// Token: 0x040018ED RID: 6381
		private uint scriptId_;

		// Token: 0x040018EE RID: 6382
		public const int FPPEFBKBFDDFieldNumber = 10;

		// Token: 0x040018EF RID: 6383
		private uint fPPEFBKBFDD_;
	}
}
