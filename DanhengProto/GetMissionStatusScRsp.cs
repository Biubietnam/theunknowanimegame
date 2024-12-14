using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000727 RID: 1831
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMissionStatusScRsp : IMessage<GetMissionStatusScRsp>, IMessage, IEquatable<GetMissionStatusScRsp>, IDeepCloneable<GetMissionStatusScRsp>, IBufferMessage
	{
		// Token: 0x1700172D RID: 5933
		// (get) Token: 0x060051D1 RID: 20945 RVA: 0x000DC444 File Offset: 0x000DA644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMissionStatusScRsp> Parser
		{
			get
			{
				return GetMissionStatusScRsp._parser;
			}
		}

		// Token: 0x1700172E RID: 5934
		// (get) Token: 0x060051D2 RID: 20946 RVA: 0x000DC44B File Offset: 0x000DA64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMissionStatusScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700172F RID: 5935
		// (get) Token: 0x060051D3 RID: 20947 RVA: 0x000DC45D File Offset: 0x000DA65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMissionStatusScRsp.Descriptor;
			}
		}

		// Token: 0x060051D4 RID: 20948 RVA: 0x000DC464 File Offset: 0x000DA664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionStatusScRsp()
		{
		}

		// Token: 0x060051D5 RID: 20949 RVA: 0x000DC4BC File Offset: 0x000DA6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionStatusScRsp(GetMissionStatusScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.mainMissionMcvList_ = other.mainMissionMcvList_.Clone();
			this.finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
			this.subMissionStatusList_ = other.subMissionStatusList_.Clone();
			this.missionEventStatusList_ = other.missionEventStatusList_.Clone();
			this.unfinishedMainMissionIdList_ = other.unfinishedMainMissionIdList_.Clone();
			this.disabledMainMissionIdList_ = other.disabledMainMissionIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051D6 RID: 20950 RVA: 0x000DC552 File Offset: 0x000DA752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionStatusScRsp Clone()
		{
			return new GetMissionStatusScRsp(this);
		}

		// Token: 0x17001730 RID: 5936
		// (get) Token: 0x060051D7 RID: 20951 RVA: 0x000DC55A File Offset: 0x000DA75A
		// (set) Token: 0x060051D8 RID: 20952 RVA: 0x000DC562 File Offset: 0x000DA762
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

		// Token: 0x17001731 RID: 5937
		// (get) Token: 0x060051D9 RID: 20953 RVA: 0x000DC56B File Offset: 0x000DA76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainMissionCustomValue> MainMissionMcvList
		{
			get
			{
				return this.mainMissionMcvList_;
			}
		}

		// Token: 0x17001732 RID: 5938
		// (get) Token: 0x060051DA RID: 20954 RVA: 0x000DC573 File Offset: 0x000DA773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FinishedMainMissionIdList
		{
			get
			{
				return this.finishedMainMissionIdList_;
			}
		}

		// Token: 0x17001733 RID: 5939
		// (get) Token: 0x060051DB RID: 20955 RVA: 0x000DC57B File Offset: 0x000DA77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mission> SubMissionStatusList
		{
			get
			{
				return this.subMissionStatusList_;
			}
		}

		// Token: 0x17001734 RID: 5940
		// (get) Token: 0x060051DC RID: 20956 RVA: 0x000DC583 File Offset: 0x000DA783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mission> MissionEventStatusList
		{
			get
			{
				return this.missionEventStatusList_;
			}
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x060051DD RID: 20957 RVA: 0x000DC58B File Offset: 0x000DA78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnfinishedMainMissionIdList
		{
			get
			{
				return this.unfinishedMainMissionIdList_;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x060051DE RID: 20958 RVA: 0x000DC593 File Offset: 0x000DA793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DisabledMainMissionIdList
		{
			get
			{
				return this.disabledMainMissionIdList_;
			}
		}

		// Token: 0x060051DF RID: 20959 RVA: 0x000DC59B File Offset: 0x000DA79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMissionStatusScRsp);
		}

		// Token: 0x060051E0 RID: 20960 RVA: 0x000DC5AC File Offset: 0x000DA7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMissionStatusScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.mainMissionMcvList_.Equals(other.mainMissionMcvList_) && this.finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_) && this.subMissionStatusList_.Equals(other.subMissionStatusList_) && this.missionEventStatusList_.Equals(other.missionEventStatusList_) && this.unfinishedMainMissionIdList_.Equals(other.unfinishedMainMissionIdList_) && this.disabledMainMissionIdList_.Equals(other.disabledMainMissionIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051E1 RID: 20961 RVA: 0x000DC664 File Offset: 0x000DA864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.mainMissionMcvList_.GetHashCode();
			num ^= this.finishedMainMissionIdList_.GetHashCode();
			num ^= this.subMissionStatusList_.GetHashCode();
			num ^= this.missionEventStatusList_.GetHashCode();
			num ^= this.unfinishedMainMissionIdList_.GetHashCode();
			num ^= this.disabledMainMissionIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051E2 RID: 20962 RVA: 0x000DC6F7 File Offset: 0x000DA8F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060051E3 RID: 20963 RVA: 0x000DC6FF File Offset: 0x000DA8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051E4 RID: 20964 RVA: 0x000DC708 File Offset: 0x000DA908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.disabledMainMissionIdList_.WriteTo(ref output, GetMissionStatusScRsp._repeated_disabledMainMissionIdList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			this.subMissionStatusList_.WriteTo(ref output, GetMissionStatusScRsp._repeated_subMissionStatusList_codec);
			this.mainMissionMcvList_.WriteTo(ref output, GetMissionStatusScRsp._repeated_mainMissionMcvList_codec);
			this.finishedMainMissionIdList_.WriteTo(ref output, GetMissionStatusScRsp._repeated_finishedMainMissionIdList_codec);
			this.unfinishedMainMissionIdList_.WriteTo(ref output, GetMissionStatusScRsp._repeated_unfinishedMainMissionIdList_codec);
			this.missionEventStatusList_.WriteTo(ref output, GetMissionStatusScRsp._repeated_missionEventStatusList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051E5 RID: 20965 RVA: 0x000DC7AC File Offset: 0x000DA9AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.mainMissionMcvList_.CalculateSize(GetMissionStatusScRsp._repeated_mainMissionMcvList_codec);
			num += this.finishedMainMissionIdList_.CalculateSize(GetMissionStatusScRsp._repeated_finishedMainMissionIdList_codec);
			num += this.subMissionStatusList_.CalculateSize(GetMissionStatusScRsp._repeated_subMissionStatusList_codec);
			num += this.missionEventStatusList_.CalculateSize(GetMissionStatusScRsp._repeated_missionEventStatusList_codec);
			num += this.unfinishedMainMissionIdList_.CalculateSize(GetMissionStatusScRsp._repeated_unfinishedMainMissionIdList_codec);
			num += this.disabledMainMissionIdList_.CalculateSize(GetMissionStatusScRsp._repeated_disabledMainMissionIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051E6 RID: 20966 RVA: 0x000DC85C File Offset: 0x000DAA5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMissionStatusScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.mainMissionMcvList_.Add(other.mainMissionMcvList_);
			this.finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
			this.subMissionStatusList_.Add(other.subMissionStatusList_);
			this.missionEventStatusList_.Add(other.missionEventStatusList_);
			this.unfinishedMainMissionIdList_.Add(other.unfinishedMainMissionIdList_);
			this.disabledMainMissionIdList_.Add(other.disabledMainMissionIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051E7 RID: 20967 RVA: 0x000DC8FE File Offset: 0x000DAAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051E8 RID: 20968 RVA: 0x000DC908 File Offset: 0x000DAB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 50U)
				{
					if (num <= 10U)
					{
						if (num == 8U || num == 10U)
						{
							this.disabledMainMissionIdList_.AddEntriesFrom(ref input, GetMissionStatusScRsp._repeated_disabledMainMissionIdList_codec);
							continue;
						}
					}
					else
					{
						if (num == 24U)
						{
							this.Retcode = input.ReadUInt32();
							continue;
						}
						if (num == 34U)
						{
							this.subMissionStatusList_.AddEntriesFrom(ref input, GetMissionStatusScRsp._repeated_subMissionStatusList_codec);
							continue;
						}
						if (num == 50U)
						{
							this.mainMissionMcvList_.AddEntriesFrom(ref input, GetMissionStatusScRsp._repeated_mainMissionMcvList_codec);
							continue;
						}
					}
				}
				else if (num <= 58U)
				{
					if (num == 56U || num == 58U)
					{
						this.finishedMainMissionIdList_.AddEntriesFrom(ref input, GetMissionStatusScRsp._repeated_finishedMainMissionIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U || num == 90U)
					{
						this.unfinishedMainMissionIdList_.AddEntriesFrom(ref input, GetMissionStatusScRsp._repeated_unfinishedMainMissionIdList_codec);
						continue;
					}
					if (num == 98U)
					{
						this.missionEventStatusList_.AddEntriesFrom(ref input, GetMissionStatusScRsp._repeated_missionEventStatusList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002027 RID: 8231
		private static readonly MessageParser<GetMissionStatusScRsp> _parser = new MessageParser<GetMissionStatusScRsp>(() => new GetMissionStatusScRsp());

		// Token: 0x04002028 RID: 8232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002029 RID: 8233
		public const int RetcodeFieldNumber = 3;

		// Token: 0x0400202A RID: 8234
		private uint retcode_;

		// Token: 0x0400202B RID: 8235
		public const int MainMissionMcvListFieldNumber = 6;

		// Token: 0x0400202C RID: 8236
		private static readonly FieldCodec<MainMissionCustomValue> _repeated_mainMissionMcvList_codec = FieldCodec.ForMessage<MainMissionCustomValue>(50U, MainMissionCustomValue.Parser);

		// Token: 0x0400202D RID: 8237
		private readonly RepeatedField<MainMissionCustomValue> mainMissionMcvList_ = new RepeatedField<MainMissionCustomValue>();

		// Token: 0x0400202E RID: 8238
		public const int FinishedMainMissionIdListFieldNumber = 7;

		// Token: 0x0400202F RID: 8239
		private static readonly FieldCodec<uint> _repeated_finishedMainMissionIdList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04002030 RID: 8240
		private readonly RepeatedField<uint> finishedMainMissionIdList_ = new RepeatedField<uint>();

		// Token: 0x04002031 RID: 8241
		public const int SubMissionStatusListFieldNumber = 4;

		// Token: 0x04002032 RID: 8242
		private static readonly FieldCodec<Mission> _repeated_subMissionStatusList_codec = FieldCodec.ForMessage<Mission>(34U, Mission.Parser);

		// Token: 0x04002033 RID: 8243
		private readonly RepeatedField<Mission> subMissionStatusList_ = new RepeatedField<Mission>();

		// Token: 0x04002034 RID: 8244
		public const int MissionEventStatusListFieldNumber = 12;

		// Token: 0x04002035 RID: 8245
		private static readonly FieldCodec<Mission> _repeated_missionEventStatusList_codec = FieldCodec.ForMessage<Mission>(98U, Mission.Parser);

		// Token: 0x04002036 RID: 8246
		private readonly RepeatedField<Mission> missionEventStatusList_ = new RepeatedField<Mission>();

		// Token: 0x04002037 RID: 8247
		public const int UnfinishedMainMissionIdListFieldNumber = 11;

		// Token: 0x04002038 RID: 8248
		private static readonly FieldCodec<uint> _repeated_unfinishedMainMissionIdList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04002039 RID: 8249
		private readonly RepeatedField<uint> unfinishedMainMissionIdList_ = new RepeatedField<uint>();

		// Token: 0x0400203A RID: 8250
		public const int DisabledMainMissionIdListFieldNumber = 1;

		// Token: 0x0400203B RID: 8251
		private static readonly FieldCodec<uint> _repeated_disabledMainMissionIdList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x0400203C RID: 8252
		private readonly RepeatedField<uint> disabledMainMissionIdList_ = new RepeatedField<uint>();
	}
}
