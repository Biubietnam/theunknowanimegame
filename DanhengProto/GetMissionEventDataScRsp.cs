using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000723 RID: 1827
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMissionEventDataScRsp : IMessage<GetMissionEventDataScRsp>, IMessage, IEquatable<GetMissionEventDataScRsp>, IDeepCloneable<GetMissionEventDataScRsp>, IBufferMessage
	{
		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x060051A3 RID: 20899 RVA: 0x000DBBB7 File Offset: 0x000D9DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMissionEventDataScRsp> Parser
		{
			get
			{
				return GetMissionEventDataScRsp._parser;
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060051A4 RID: 20900 RVA: 0x000DBBBE File Offset: 0x000D9DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMissionEventDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060051A5 RID: 20901 RVA: 0x000DBBD0 File Offset: 0x000D9DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMissionEventDataScRsp.Descriptor;
			}
		}

		// Token: 0x060051A6 RID: 20902 RVA: 0x000DBBD7 File Offset: 0x000D9DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionEventDataScRsp()
		{
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x000DBBEC File Offset: 0x000D9DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionEventDataScRsp(GetMissionEventDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.missionEventList_ = other.missionEventList_.Clone();
			this.challengeEventId_ = other.challengeEventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x000DBC39 File Offset: 0x000D9E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionEventDataScRsp Clone()
		{
			return new GetMissionEventDataScRsp(this);
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060051A9 RID: 20905 RVA: 0x000DBC41 File Offset: 0x000D9E41
		// (set) Token: 0x060051AA RID: 20906 RVA: 0x000DBC49 File Offset: 0x000D9E49
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

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060051AB RID: 20907 RVA: 0x000DBC52 File Offset: 0x000D9E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mission> MissionEventList
		{
			get
			{
				return this.missionEventList_;
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x000DBC5A File Offset: 0x000D9E5A
		// (set) Token: 0x060051AD RID: 20909 RVA: 0x000DBC62 File Offset: 0x000D9E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChallengeEventId
		{
			get
			{
				return this.challengeEventId_;
			}
			set
			{
				this.challengeEventId_ = value;
			}
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x000DBC6B File Offset: 0x000D9E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMissionEventDataScRsp);
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x000DBC7C File Offset: 0x000D9E7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMissionEventDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.missionEventList_.Equals(other.missionEventList_) && this.ChallengeEventId == other.ChallengeEventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051B0 RID: 20912 RVA: 0x000DBCDC File Offset: 0x000D9EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.missionEventList_.GetHashCode();
			if (this.ChallengeEventId != 0U)
			{
				num ^= this.ChallengeEventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051B1 RID: 20913 RVA: 0x000DBD42 File Offset: 0x000D9F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060051B2 RID: 20914 RVA: 0x000DBD4A File Offset: 0x000D9F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051B3 RID: 20915 RVA: 0x000DBD54 File Offset: 0x000D9F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.missionEventList_.WriteTo(ref output, GetMissionEventDataScRsp._repeated_missionEventList_codec);
			if (this.ChallengeEventId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ChallengeEventId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051B4 RID: 20916 RVA: 0x000DBDC0 File Offset: 0x000D9FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.missionEventList_.CalculateSize(GetMissionEventDataScRsp._repeated_missionEventList_codec);
			if (this.ChallengeEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChallengeEventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051B5 RID: 20917 RVA: 0x000DBE2C File Offset: 0x000DA02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMissionEventDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.missionEventList_.Add(other.missionEventList_);
			if (other.ChallengeEventId != 0U)
			{
				this.ChallengeEventId = other.ChallengeEventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051B6 RID: 20918 RVA: 0x000DBE8D File Offset: 0x000DA08D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051B7 RID: 20919 RVA: 0x000DBE98 File Offset: 0x000DA098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 48U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Retcode = input.ReadUInt32();
						}
					}
					else
					{
						this.ChallengeEventId = input.ReadUInt32();
					}
				}
				else
				{
					this.missionEventList_.AddEntriesFrom(ref input, GetMissionEventDataScRsp._repeated_missionEventList_codec);
				}
			}
		}

		// Token: 0x04002011 RID: 8209
		private static readonly MessageParser<GetMissionEventDataScRsp> _parser = new MessageParser<GetMissionEventDataScRsp>(() => new GetMissionEventDataScRsp());

		// Token: 0x04002012 RID: 8210
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002013 RID: 8211
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04002014 RID: 8212
		private uint retcode_;

		// Token: 0x04002015 RID: 8213
		public const int MissionEventListFieldNumber = 4;

		// Token: 0x04002016 RID: 8214
		private static readonly FieldCodec<Mission> _repeated_missionEventList_codec = FieldCodec.ForMessage<Mission>(34U, Mission.Parser);

		// Token: 0x04002017 RID: 8215
		private readonly RepeatedField<Mission> missionEventList_ = new RepeatedField<Mission>();

		// Token: 0x04002018 RID: 8216
		public const int ChallengeEventIdFieldNumber = 6;

		// Token: 0x04002019 RID: 8217
		private uint challengeEventId_;
	}
}
