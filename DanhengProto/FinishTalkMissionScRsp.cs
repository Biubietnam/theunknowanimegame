using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200059D RID: 1437
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishTalkMissionScRsp : IMessage<FinishTalkMissionScRsp>, IMessage, IEquatable<FinishTalkMissionScRsp>, IDeepCloneable<FinishTalkMissionScRsp>, IBufferMessage
	{
		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x06004021 RID: 16417 RVA: 0x000AEB93 File Offset: 0x000ACD93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishTalkMissionScRsp> Parser
		{
			get
			{
				return FinishTalkMissionScRsp._parser;
			}
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x000AEB9A File Offset: 0x000ACD9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishTalkMissionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700123C RID: 4668
		// (get) Token: 0x06004023 RID: 16419 RVA: 0x000AEBAC File Offset: 0x000ACDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishTalkMissionScRsp.Descriptor;
			}
		}

		// Token: 0x06004024 RID: 16420 RVA: 0x000AEBB3 File Offset: 0x000ACDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTalkMissionScRsp()
		{
		}

		// Token: 0x06004025 RID: 16421 RVA: 0x000AEBD4 File Offset: 0x000ACDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTalkMissionScRsp(FinishTalkMissionScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.subMissionId_ = other.subMissionId_;
			this.talkStr_ = other.talkStr_;
			this.customValueList_ = other.customValueList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004026 RID: 16422 RVA: 0x000AEC2D File Offset: 0x000ACE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTalkMissionScRsp Clone()
		{
			return new FinishTalkMissionScRsp(this);
		}

		// Token: 0x1700123D RID: 4669
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x000AEC35 File Offset: 0x000ACE35
		// (set) Token: 0x06004028 RID: 16424 RVA: 0x000AEC3D File Offset: 0x000ACE3D
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

		// Token: 0x1700123E RID: 4670
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x000AEC46 File Offset: 0x000ACE46
		// (set) Token: 0x0600402A RID: 16426 RVA: 0x000AEC4E File Offset: 0x000ACE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SubMissionId
		{
			get
			{
				return this.subMissionId_;
			}
			set
			{
				this.subMissionId_ = value;
			}
		}

		// Token: 0x1700123F RID: 4671
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x000AEC57 File Offset: 0x000ACE57
		// (set) Token: 0x0600402C RID: 16428 RVA: 0x000AEC5F File Offset: 0x000ACE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TalkStr
		{
			get
			{
				return this.talkStr_;
			}
			set
			{
				this.talkStr_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001240 RID: 4672
		// (get) Token: 0x0600402D RID: 16429 RVA: 0x000AEC72 File Offset: 0x000ACE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MissionCustomValue> CustomValueList
		{
			get
			{
				return this.customValueList_;
			}
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x000AEC7A File Offset: 0x000ACE7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishTalkMissionScRsp);
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x000AEC88 File Offset: 0x000ACE88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishTalkMissionScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.SubMissionId == other.SubMissionId && !(this.TalkStr != other.TalkStr) && this.customValueList_.Equals(other.customValueList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x000AECFC File Offset: 0x000ACEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.SubMissionId != 0U)
			{
				num ^= this.SubMissionId.GetHashCode();
			}
			if (this.TalkStr.Length != 0)
			{
				num ^= this.TalkStr.GetHashCode();
			}
			num ^= this.customValueList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x000AED7D File Offset: 0x000ACF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x000AED85 File Offset: 0x000ACF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x000AED90 File Offset: 0x000ACF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.customValueList_.WriteTo(ref output, FinishTalkMissionScRsp._repeated_customValueList_codec);
			if (this.TalkStr.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(this.TalkStr);
			}
			if (this.SubMissionId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x000AEE1C File Offset: 0x000AD01C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.SubMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubMissionId);
			}
			if (this.TalkStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TalkStr);
			}
			num += this.customValueList_.CalculateSize(FinishTalkMissionScRsp._repeated_customValueList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x000AEEA4 File Offset: 0x000AD0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishTalkMissionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.SubMissionId != 0U)
			{
				this.SubMissionId = other.SubMissionId;
			}
			if (other.TalkStr.Length != 0)
			{
				this.TalkStr = other.TalkStr;
			}
			this.customValueList_.Add(other.customValueList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x000AEF1E File Offset: 0x000AD11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x000AEF28 File Offset: 0x000AD128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						this.customValueList_.AddEntriesFrom(ref input, FinishTalkMissionScRsp._repeated_customValueList_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.TalkStr = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.SubMissionId = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001978 RID: 6520
		private static readonly MessageParser<FinishTalkMissionScRsp> _parser = new MessageParser<FinishTalkMissionScRsp>(() => new FinishTalkMissionScRsp());

		// Token: 0x04001979 RID: 6521
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400197A RID: 6522
		public const int RetcodeFieldNumber = 1;

		// Token: 0x0400197B RID: 6523
		private uint retcode_;

		// Token: 0x0400197C RID: 6524
		public const int SubMissionIdFieldNumber = 10;

		// Token: 0x0400197D RID: 6525
		private uint subMissionId_;

		// Token: 0x0400197E RID: 6526
		public const int TalkStrFieldNumber = 6;

		// Token: 0x0400197F RID: 6527
		private string talkStr_ = "";

		// Token: 0x04001980 RID: 6528
		public const int CustomValueListFieldNumber = 3;

		// Token: 0x04001981 RID: 6529
		private static readonly FieldCodec<MissionCustomValue> _repeated_customValueList_codec = FieldCodec.ForMessage<MissionCustomValue>(26U, MissionCustomValue.Parser);

		// Token: 0x04001982 RID: 6530
		private readonly RepeatedField<MissionCustomValue> customValueList_ = new RepeatedField<MissionCustomValue>();
	}
}
