using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020007B3 RID: 1971
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetRogueCommonDialogueDataScRsp : IMessage<GetRogueCommonDialogueDataScRsp>, IMessage, IEquatable<GetRogueCommonDialogueDataScRsp>, IDeepCloneable<GetRogueCommonDialogueDataScRsp>, IBufferMessage
	{
		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060057F5 RID: 22517 RVA: 0x000EB4C7 File Offset: 0x000E96C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetRogueCommonDialogueDataScRsp> Parser
		{
			get
			{
				return GetRogueCommonDialogueDataScRsp._parser;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x000EB4CE File Offset: 0x000E96CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetRogueCommonDialogueDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x060057F7 RID: 22519 RVA: 0x000EB4E0 File Offset: 0x000E96E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRogueCommonDialogueDataScRsp.Descriptor;
			}
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x000EB4E7 File Offset: 0x000E96E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCommonDialogueDataScRsp()
		{
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x000EB4FA File Offset: 0x000E96FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCommonDialogueDataScRsp(GetRogueCommonDialogueDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.dialogueDataList_ = other.dialogueDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060057FA RID: 22522 RVA: 0x000EB530 File Offset: 0x000E9730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetRogueCommonDialogueDataScRsp Clone()
		{
			return new GetRogueCommonDialogueDataScRsp(this);
		}

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x060057FB RID: 22523 RVA: 0x000EB538 File Offset: 0x000E9738
		// (set) Token: 0x060057FC RID: 22524 RVA: 0x000EB540 File Offset: 0x000E9740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x060057FD RID: 22525 RVA: 0x000EB549 File Offset: 0x000E9749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonDialogueDataInfo> DialogueDataList
		{
			get
			{
				return this.dialogueDataList_;
			}
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x000EB551 File Offset: 0x000E9751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRogueCommonDialogueDataScRsp);
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x000EB560 File Offset: 0x000E9760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetRogueCommonDialogueDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.dialogueDataList_.Equals(other.dialogueDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x000EB5B0 File Offset: 0x000E97B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.dialogueDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x000EB5FD File Offset: 0x000E97FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x000EB605 File Offset: 0x000E9805
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x000EB610 File Offset: 0x000E9810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			this.dialogueDataList_.WriteTo(ref output, GetRogueCommonDialogueDataScRsp._repeated_dialogueDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x000EB660 File Offset: 0x000E9860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.dialogueDataList_.CalculateSize(GetRogueCommonDialogueDataScRsp._repeated_dialogueDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x000EB6B4 File Offset: 0x000E98B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetRogueCommonDialogueDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.dialogueDataList_.Add(other.dialogueDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x000EB701 File Offset: 0x000E9901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005807 RID: 22535 RVA: 0x000EB70C File Offset: 0x000E990C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.dialogueDataList_.AddEntriesFrom(ref input, GetRogueCommonDialogueDataScRsp._repeated_dialogueDataList_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400224F RID: 8783
		private static readonly MessageParser<GetRogueCommonDialogueDataScRsp> _parser = new MessageParser<GetRogueCommonDialogueDataScRsp>(() => new GetRogueCommonDialogueDataScRsp());

		// Token: 0x04002250 RID: 8784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002251 RID: 8785
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04002252 RID: 8786
		private uint retcode_;

		// Token: 0x04002253 RID: 8787
		public const int DialogueDataListFieldNumber = 7;

		// Token: 0x04002254 RID: 8788
		private static readonly FieldCodec<RogueCommonDialogueDataInfo> _repeated_dialogueDataList_codec = FieldCodec.ForMessage<RogueCommonDialogueDataInfo>(58U, RogueCommonDialogueDataInfo.Parser);

		// Token: 0x04002255 RID: 8789
		private readonly RepeatedField<RogueCommonDialogueDataInfo> dialogueDataList_ = new RepeatedField<RogueCommonDialogueDataInfo>();
	}
}
