using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200059B RID: 1435
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishTalkMissionCsReq : IMessage<FinishTalkMissionCsReq>, IMessage, IEquatable<FinishTalkMissionCsReq>, IDeepCloneable<FinishTalkMissionCsReq>, IBufferMessage
	{
		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x000AE737 File Offset: 0x000AC937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishTalkMissionCsReq> Parser
		{
			get
			{
				return FinishTalkMissionCsReq._parser;
			}
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x0600400A RID: 16394 RVA: 0x000AE73E File Offset: 0x000AC93E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishTalkMissionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x000AE750 File Offset: 0x000AC950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishTalkMissionCsReq.Descriptor;
			}
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x000AE757 File Offset: 0x000AC957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTalkMissionCsReq()
		{
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x000AE778 File Offset: 0x000AC978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTalkMissionCsReq(FinishTalkMissionCsReq other) : this()
		{
			this.talkStr_ = other.talkStr_;
			this.customValueList_ = other.customValueList_.Clone();
			this.subMissionId_ = other.subMissionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x000AE7C5 File Offset: 0x000AC9C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishTalkMissionCsReq Clone()
		{
			return new FinishTalkMissionCsReq(this);
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x0600400F RID: 16399 RVA: 0x000AE7CD File Offset: 0x000AC9CD
		// (set) Token: 0x06004010 RID: 16400 RVA: 0x000AE7D5 File Offset: 0x000AC9D5
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

		// Token: 0x17001237 RID: 4663
		// (get) Token: 0x06004011 RID: 16401 RVA: 0x000AE7E8 File Offset: 0x000AC9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MissionCustomValue> CustomValueList
		{
			get
			{
				return this.customValueList_;
			}
		}

		// Token: 0x17001238 RID: 4664
		// (get) Token: 0x06004012 RID: 16402 RVA: 0x000AE7F0 File Offset: 0x000AC9F0
		// (set) Token: 0x06004013 RID: 16403 RVA: 0x000AE7F8 File Offset: 0x000AC9F8
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

		// Token: 0x06004014 RID: 16404 RVA: 0x000AE801 File Offset: 0x000ACA01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishTalkMissionCsReq);
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x000AE810 File Offset: 0x000ACA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishTalkMissionCsReq other)
		{
			return other != null && (other == this || (!(this.TalkStr != other.TalkStr) && this.customValueList_.Equals(other.customValueList_) && this.SubMissionId == other.SubMissionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004016 RID: 16406 RVA: 0x000AE874 File Offset: 0x000ACA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalkStr.Length != 0)
			{
				num ^= this.TalkStr.GetHashCode();
			}
			num ^= this.customValueList_.GetHashCode();
			if (this.SubMissionId != 0U)
			{
				num ^= this.SubMissionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004017 RID: 16407 RVA: 0x000AE8DC File Offset: 0x000ACADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004018 RID: 16408 RVA: 0x000AE8E4 File Offset: 0x000ACAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004019 RID: 16409 RVA: 0x000AE8F0 File Offset: 0x000ACAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.customValueList_.WriteTo(ref output, FinishTalkMissionCsReq._repeated_customValueList_codec);
			if (this.TalkStr.Length != 0)
			{
				output.WriteRawTag(66);
				output.WriteString(this.TalkStr);
			}
			if (this.SubMissionId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600401A RID: 16410 RVA: 0x000AE960 File Offset: 0x000ACB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalkStr.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TalkStr);
			}
			num += this.customValueList_.CalculateSize(FinishTalkMissionCsReq._repeated_customValueList_codec);
			if (this.SubMissionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SubMissionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600401B RID: 16411 RVA: 0x000AE9D0 File Offset: 0x000ACBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishTalkMissionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalkStr.Length != 0)
			{
				this.TalkStr = other.TalkStr;
			}
			this.customValueList_.Add(other.customValueList_);
			if (other.SubMissionId != 0U)
			{
				this.SubMissionId = other.SubMissionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600401C RID: 16412 RVA: 0x000AEA36 File Offset: 0x000ACC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600401D RID: 16413 RVA: 0x000AEA40 File Offset: 0x000ACC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 66U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SubMissionId = input.ReadUInt32();
						}
					}
					else
					{
						this.TalkStr = input.ReadString();
					}
				}
				else
				{
					this.customValueList_.AddEntriesFrom(ref input, FinishTalkMissionCsReq._repeated_customValueList_codec);
				}
			}
		}

		// Token: 0x0400196E RID: 6510
		private static readonly MessageParser<FinishTalkMissionCsReq> _parser = new MessageParser<FinishTalkMissionCsReq>(() => new FinishTalkMissionCsReq());

		// Token: 0x0400196F RID: 6511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001970 RID: 6512
		public const int TalkStrFieldNumber = 8;

		// Token: 0x04001971 RID: 6513
		private string talkStr_ = "";

		// Token: 0x04001972 RID: 6514
		public const int CustomValueListFieldNumber = 2;

		// Token: 0x04001973 RID: 6515
		private static readonly FieldCodec<MissionCustomValue> _repeated_customValueList_codec = FieldCodec.ForMessage<MissionCustomValue>(18U, MissionCustomValue.Parser);

		// Token: 0x04001974 RID: 6516
		private readonly RepeatedField<MissionCustomValue> customValueList_ = new RepeatedField<MissionCustomValue>();

		// Token: 0x04001975 RID: 6517
		public const int SubMissionIdFieldNumber = 13;

		// Token: 0x04001976 RID: 6518
		private uint subMissionId_;
	}
}
