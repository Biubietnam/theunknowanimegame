using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000837 RID: 2103
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrialActivityDataScRsp : IMessage<GetTrialActivityDataScRsp>, IMessage, IEquatable<GetTrialActivityDataScRsp>, IDeepCloneable<GetTrialActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06005D91 RID: 23953 RVA: 0x000F8293 File Offset: 0x000F6493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrialActivityDataScRsp> Parser
		{
			get
			{
				return GetTrialActivityDataScRsp._parser;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06005D92 RID: 23954 RVA: 0x000F829A File Offset: 0x000F649A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrialActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06005D93 RID: 23955 RVA: 0x000F82AC File Offset: 0x000F64AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrialActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005D94 RID: 23956 RVA: 0x000F82B3 File Offset: 0x000F64B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrialActivityDataScRsp()
		{
		}

		// Token: 0x06005D95 RID: 23957 RVA: 0x000F82C8 File Offset: 0x000F64C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrialActivityDataScRsp(GetTrialActivityDataScRsp other) : this()
		{
			this.trialActivityInfoList_ = other.trialActivityInfoList_.Clone();
			this.retcode_ = other.retcode_;
			this.activityStageId_ = other.activityStageId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D96 RID: 23958 RVA: 0x000F8315 File Offset: 0x000F6515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrialActivityDataScRsp Clone()
		{
			return new GetTrialActivityDataScRsp(this);
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06005D97 RID: 23959 RVA: 0x000F831D File Offset: 0x000F651D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrialActivityInfo> TrialActivityInfoList
		{
			get
			{
				return this.trialActivityInfoList_;
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06005D98 RID: 23960 RVA: 0x000F8325 File Offset: 0x000F6525
		// (set) Token: 0x06005D99 RID: 23961 RVA: 0x000F832D File Offset: 0x000F652D
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

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06005D9A RID: 23962 RVA: 0x000F8336 File Offset: 0x000F6536
		// (set) Token: 0x06005D9B RID: 23963 RVA: 0x000F833E File Offset: 0x000F653E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ActivityStageId
		{
			get
			{
				return this.activityStageId_;
			}
			set
			{
				this.activityStageId_ = value;
			}
		}

		// Token: 0x06005D9C RID: 23964 RVA: 0x000F8347 File Offset: 0x000F6547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrialActivityDataScRsp);
		}

		// Token: 0x06005D9D RID: 23965 RVA: 0x000F8358 File Offset: 0x000F6558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrialActivityDataScRsp other)
		{
			return other != null && (other == this || (this.trialActivityInfoList_.Equals(other.trialActivityInfoList_) && this.Retcode == other.Retcode && this.ActivityStageId == other.ActivityStageId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D9E RID: 23966 RVA: 0x000F83B8 File Offset: 0x000F65B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialActivityInfoList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.ActivityStageId != 0U)
			{
				num ^= this.ActivityStageId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D9F RID: 23967 RVA: 0x000F841E File Offset: 0x000F661E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005DA0 RID: 23968 RVA: 0x000F8426 File Offset: 0x000F6626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005DA1 RID: 23969 RVA: 0x000F8430 File Offset: 0x000F6630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.ActivityStageId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.ActivityStageId);
			}
			this.trialActivityInfoList_.WriteTo(ref output, GetTrialActivityDataScRsp._repeated_trialActivityInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005DA2 RID: 23970 RVA: 0x000F849C File Offset: 0x000F669C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialActivityInfoList_.CalculateSize(GetTrialActivityDataScRsp._repeated_trialActivityInfoList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.ActivityStageId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ActivityStageId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005DA3 RID: 23971 RVA: 0x000F8508 File Offset: 0x000F6708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrialActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.trialActivityInfoList_.Add(other.trialActivityInfoList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.ActivityStageId != 0U)
			{
				this.ActivityStageId = other.ActivityStageId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005DA4 RID: 23972 RVA: 0x000F8569 File Offset: 0x000F6769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005DA5 RID: 23973 RVA: 0x000F8574 File Offset: 0x000F6774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 98U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.trialActivityInfoList_.AddEntriesFrom(ref input, GetTrialActivityDataScRsp._repeated_trialActivityInfoList_codec);
						}
					}
					else
					{
						this.ActivityStageId = input.ReadUInt32();
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400241C RID: 9244
		private static readonly MessageParser<GetTrialActivityDataScRsp> _parser = new MessageParser<GetTrialActivityDataScRsp>(() => new GetTrialActivityDataScRsp());

		// Token: 0x0400241D RID: 9245
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400241E RID: 9246
		public const int TrialActivityInfoListFieldNumber = 12;

		// Token: 0x0400241F RID: 9247
		private static readonly FieldCodec<TrialActivityInfo> _repeated_trialActivityInfoList_codec = FieldCodec.ForMessage<TrialActivityInfo>(98U, TrialActivityInfo.Parser);

		// Token: 0x04002420 RID: 9248
		private readonly RepeatedField<TrialActivityInfo> trialActivityInfoList_ = new RepeatedField<TrialActivityInfo>();

		// Token: 0x04002421 RID: 9249
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04002422 RID: 9250
		private uint retcode_;

		// Token: 0x04002423 RID: 9251
		public const int ActivityStageIdFieldNumber = 10;

		// Token: 0x04002424 RID: 9252
		private uint activityStageId_;
	}
}
