using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001285 RID: 4741
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncRogueCommonDialogueDataScNotify : IMessage<SyncRogueCommonDialogueDataScNotify>, IMessage, IEquatable<SyncRogueCommonDialogueDataScNotify>, IDeepCloneable<SyncRogueCommonDialogueDataScNotify>, IBufferMessage
	{
		// Token: 0x17003B84 RID: 15236
		// (get) Token: 0x0600D385 RID: 54149 RVA: 0x00234E53 File Offset: 0x00233053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncRogueCommonDialogueDataScNotify> Parser
		{
			get
			{
				return SyncRogueCommonDialogueDataScNotify._parser;
			}
		}

		// Token: 0x17003B85 RID: 15237
		// (get) Token: 0x0600D386 RID: 54150 RVA: 0x00234E5A File Offset: 0x0023305A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncRogueCommonDialogueDataScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B86 RID: 15238
		// (get) Token: 0x0600D387 RID: 54151 RVA: 0x00234E6C File Offset: 0x0023306C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncRogueCommonDialogueDataScNotify.Descriptor;
			}
		}

		// Token: 0x0600D388 RID: 54152 RVA: 0x00234E73 File Offset: 0x00233073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonDialogueDataScNotify()
		{
		}

		// Token: 0x0600D389 RID: 54153 RVA: 0x00234E86 File Offset: 0x00233086
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonDialogueDataScNotify(SyncRogueCommonDialogueDataScNotify other) : this()
		{
			this.dialogueDataList_ = other.dialogueDataList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D38A RID: 54154 RVA: 0x00234EB0 File Offset: 0x002330B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncRogueCommonDialogueDataScNotify Clone()
		{
			return new SyncRogueCommonDialogueDataScNotify(this);
		}

		// Token: 0x17003B87 RID: 15239
		// (get) Token: 0x0600D38B RID: 54155 RVA: 0x00234EB8 File Offset: 0x002330B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueCommonDialogueDataInfo> DialogueDataList
		{
			get
			{
				return this.dialogueDataList_;
			}
		}

		// Token: 0x0600D38C RID: 54156 RVA: 0x00234EC0 File Offset: 0x002330C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncRogueCommonDialogueDataScNotify);
		}

		// Token: 0x0600D38D RID: 54157 RVA: 0x00234ECE File Offset: 0x002330CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncRogueCommonDialogueDataScNotify other)
		{
			return other != null && (other == this || (this.dialogueDataList_.Equals(other.dialogueDataList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D38E RID: 54158 RVA: 0x00234F04 File Offset: 0x00233104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dialogueDataList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x00234F38 File Offset: 0x00233138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D390 RID: 54160 RVA: 0x00234F40 File Offset: 0x00233140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D391 RID: 54161 RVA: 0x00234F49 File Offset: 0x00233149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dialogueDataList_.WriteTo(ref output, SyncRogueCommonDialogueDataScNotify._repeated_dialogueDataList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D392 RID: 54162 RVA: 0x00234F70 File Offset: 0x00233170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dialogueDataList_.CalculateSize(SyncRogueCommonDialogueDataScNotify._repeated_dialogueDataList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D393 RID: 54163 RVA: 0x00234FA9 File Offset: 0x002331A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncRogueCommonDialogueDataScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dialogueDataList_.Add(other.dialogueDataList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D394 RID: 54164 RVA: 0x00234FD7 File Offset: 0x002331D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D395 RID: 54165 RVA: 0x00234FE0 File Offset: 0x002331E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dialogueDataList_.AddEntriesFrom(ref input, SyncRogueCommonDialogueDataScNotify._repeated_dialogueDataList_codec);
				}
			}
		}

		// Token: 0x040054AF RID: 21679
		private static readonly MessageParser<SyncRogueCommonDialogueDataScNotify> _parser = new MessageParser<SyncRogueCommonDialogueDataScNotify>(() => new SyncRogueCommonDialogueDataScNotify());

		// Token: 0x040054B0 RID: 21680
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054B1 RID: 21681
		public const int DialogueDataListFieldNumber = 6;

		// Token: 0x040054B2 RID: 21682
		private static readonly FieldCodec<RogueCommonDialogueDataInfo> _repeated_dialogueDataList_codec = FieldCodec.ForMessage<RogueCommonDialogueDataInfo>(50U, RogueCommonDialogueDataInfo.Parser);

		// Token: 0x040054B3 RID: 21683
		private readonly RepeatedField<RogueCommonDialogueDataInfo> dialogueDataList_ = new RepeatedField<RogueCommonDialogueDataInfo>();
	}
}
