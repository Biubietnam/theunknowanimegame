using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200078B RID: 1931
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetQuestRecordScRsp : IMessage<GetQuestRecordScRsp>, IMessage, IEquatable<GetQuestRecordScRsp>, IDeepCloneable<GetQuestRecordScRsp>, IBufferMessage
	{
		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06005640 RID: 22080 RVA: 0x000E7669 File Offset: 0x000E5869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetQuestRecordScRsp> Parser
		{
			get
			{
				return GetQuestRecordScRsp._parser;
			}
		}

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06005641 RID: 22081 RVA: 0x000E7670 File Offset: 0x000E5870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetQuestRecordScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001867 RID: 6247
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x000E7682 File Offset: 0x000E5882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetQuestRecordScRsp.Descriptor;
			}
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x000E7689 File Offset: 0x000E5889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestRecordScRsp()
		{
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x000E769C File Offset: 0x000E589C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestRecordScRsp(GetQuestRecordScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.lKJPHNHLFIF_ = other.lKJPHNHLFIF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x000E76D2 File Offset: 0x000E58D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetQuestRecordScRsp Clone()
		{
			return new GetQuestRecordScRsp(this);
		}

		// Token: 0x17001868 RID: 6248
		// (get) Token: 0x06005646 RID: 22086 RVA: 0x000E76DA File Offset: 0x000E58DA
		// (set) Token: 0x06005647 RID: 22087 RVA: 0x000E76E2 File Offset: 0x000E58E2
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

		// Token: 0x17001869 RID: 6249
		// (get) Token: 0x06005648 RID: 22088 RVA: 0x000E76EB File Offset: 0x000E58EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<QuestRecord> LKJPHNHLFIF
		{
			get
			{
				return this.lKJPHNHLFIF_;
			}
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x000E76F3 File Offset: 0x000E58F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetQuestRecordScRsp);
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x000E7704 File Offset: 0x000E5904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetQuestRecordScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.lKJPHNHLFIF_.Equals(other.lKJPHNHLFIF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x000E7754 File Offset: 0x000E5954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.lKJPHNHLFIF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x000E77A1 File Offset: 0x000E59A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x000E77A9 File Offset: 0x000E59A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x000E77B4 File Offset: 0x000E59B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			this.lKJPHNHLFIF_.WriteTo(ref output, GetQuestRecordScRsp._repeated_lKJPHNHLFIF_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x000E7804 File Offset: 0x000E5A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.lKJPHNHLFIF_.CalculateSize(GetQuestRecordScRsp._repeated_lKJPHNHLFIF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x000E7858 File Offset: 0x000E5A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetQuestRecordScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.lKJPHNHLFIF_.Add(other.lKJPHNHLFIF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005651 RID: 22097 RVA: 0x000E78A5 File Offset: 0x000E5AA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005652 RID: 22098 RVA: 0x000E78B0 File Offset: 0x000E5AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.lKJPHNHLFIF_.AddEntriesFrom(ref input, GetQuestRecordScRsp._repeated_lKJPHNHLFIF_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040021C4 RID: 8644
		private static readonly MessageParser<GetQuestRecordScRsp> _parser = new MessageParser<GetQuestRecordScRsp>(() => new GetQuestRecordScRsp());

		// Token: 0x040021C5 RID: 8645
		private UnknownFieldSet _unknownFields;

		// Token: 0x040021C6 RID: 8646
		public const int RetcodeFieldNumber = 9;

		// Token: 0x040021C7 RID: 8647
		private uint retcode_;

		// Token: 0x040021C8 RID: 8648
		public const int LKJPHNHLFIFFieldNumber = 14;

		// Token: 0x040021C9 RID: 8649
		private static readonly FieldCodec<QuestRecord> _repeated_lKJPHNHLFIF_codec = FieldCodec.ForMessage<QuestRecord>(114U, QuestRecord.Parser);

		// Token: 0x040021CA RID: 8650
		private readonly RepeatedField<QuestRecord> lKJPHNHLFIF_ = new RepeatedField<QuestRecord>();
	}
}
