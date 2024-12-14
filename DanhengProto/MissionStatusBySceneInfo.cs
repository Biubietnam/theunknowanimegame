using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AE9 RID: 2793
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionStatusBySceneInfo : IMessage<MissionStatusBySceneInfo>, IMessage, IEquatable<MissionStatusBySceneInfo>, IDeepCloneable<MissionStatusBySceneInfo>, IBufferMessage
	{
		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x06007BA2 RID: 31650 RVA: 0x0014730C File Offset: 0x0014550C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionStatusBySceneInfo> Parser
		{
			get
			{
				return MissionStatusBySceneInfo._parser;
			}
		}

		// Token: 0x170022B4 RID: 8884
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x00147313 File Offset: 0x00145513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionStatusBySceneInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022B5 RID: 8885
		// (get) Token: 0x06007BA4 RID: 31652 RVA: 0x00147325 File Offset: 0x00145525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionStatusBySceneInfo.Descriptor;
			}
		}

		// Token: 0x06007BA5 RID: 31653 RVA: 0x0014732C File Offset: 0x0014552C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionStatusBySceneInfo()
		{
		}

		// Token: 0x06007BA6 RID: 31654 RVA: 0x0014736C File Offset: 0x0014556C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionStatusBySceneInfo(MissionStatusBySceneInfo other) : this()
		{
			this.unfinishedMainMissionIdList_ = other.unfinishedMainMissionIdList_.Clone();
			this.disabledMainMissionIdList_ = other.disabledMainMissionIdList_.Clone();
			this.mainMissionMcvList_ = other.mainMissionMcvList_.Clone();
			this.finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
			this.subMissionStatusList_ = other.subMissionStatusList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BA7 RID: 31655 RVA: 0x001473E5 File Offset: 0x001455E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionStatusBySceneInfo Clone()
		{
			return new MissionStatusBySceneInfo(this);
		}

		// Token: 0x170022B6 RID: 8886
		// (get) Token: 0x06007BA8 RID: 31656 RVA: 0x001473ED File Offset: 0x001455ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> UnfinishedMainMissionIdList
		{
			get
			{
				return this.unfinishedMainMissionIdList_;
			}
		}

		// Token: 0x170022B7 RID: 8887
		// (get) Token: 0x06007BA9 RID: 31657 RVA: 0x001473F5 File Offset: 0x001455F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DisabledMainMissionIdList
		{
			get
			{
				return this.disabledMainMissionIdList_;
			}
		}

		// Token: 0x170022B8 RID: 8888
		// (get) Token: 0x06007BAA RID: 31658 RVA: 0x001473FD File Offset: 0x001455FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MainMissionCustomValue> MainMissionMcvList
		{
			get
			{
				return this.mainMissionMcvList_;
			}
		}

		// Token: 0x170022B9 RID: 8889
		// (get) Token: 0x06007BAB RID: 31659 RVA: 0x00147405 File Offset: 0x00145605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FinishedMainMissionIdList
		{
			get
			{
				return this.finishedMainMissionIdList_;
			}
		}

		// Token: 0x170022BA RID: 8890
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x0014740D File Offset: 0x0014560D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mission> SubMissionStatusList
		{
			get
			{
				return this.subMissionStatusList_;
			}
		}

		// Token: 0x06007BAD RID: 31661 RVA: 0x00147415 File Offset: 0x00145615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionStatusBySceneInfo);
		}

		// Token: 0x06007BAE RID: 31662 RVA: 0x00147424 File Offset: 0x00145624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionStatusBySceneInfo other)
		{
			return other != null && (other == this || (this.unfinishedMainMissionIdList_.Equals(other.unfinishedMainMissionIdList_) && this.disabledMainMissionIdList_.Equals(other.disabledMainMissionIdList_) && this.mainMissionMcvList_.Equals(other.mainMissionMcvList_) && this.finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_) && this.subMissionStatusList_.Equals(other.subMissionStatusList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BAF RID: 31663 RVA: 0x001474B8 File Offset: 0x001456B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unfinishedMainMissionIdList_.GetHashCode();
			num ^= this.disabledMainMissionIdList_.GetHashCode();
			num ^= this.mainMissionMcvList_.GetHashCode();
			num ^= this.finishedMainMissionIdList_.GetHashCode();
			num ^= this.subMissionStatusList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BB0 RID: 31664 RVA: 0x00147524 File Offset: 0x00145724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BB1 RID: 31665 RVA: 0x0014752C File Offset: 0x0014572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BB2 RID: 31666 RVA: 0x00147538 File Offset: 0x00145738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mainMissionMcvList_.WriteTo(ref output, MissionStatusBySceneInfo._repeated_mainMissionMcvList_codec);
			this.finishedMainMissionIdList_.WriteTo(ref output, MissionStatusBySceneInfo._repeated_finishedMainMissionIdList_codec);
			this.disabledMainMissionIdList_.WriteTo(ref output, MissionStatusBySceneInfo._repeated_disabledMainMissionIdList_codec);
			this.unfinishedMainMissionIdList_.WriteTo(ref output, MissionStatusBySceneInfo._repeated_unfinishedMainMissionIdList_codec);
			this.subMissionStatusList_.WriteTo(ref output, MissionStatusBySceneInfo._repeated_subMissionStatusList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BB3 RID: 31667 RVA: 0x001475B0 File Offset: 0x001457B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unfinishedMainMissionIdList_.CalculateSize(MissionStatusBySceneInfo._repeated_unfinishedMainMissionIdList_codec);
			num += this.disabledMainMissionIdList_.CalculateSize(MissionStatusBySceneInfo._repeated_disabledMainMissionIdList_codec);
			num += this.mainMissionMcvList_.CalculateSize(MissionStatusBySceneInfo._repeated_mainMissionMcvList_codec);
			num += this.finishedMainMissionIdList_.CalculateSize(MissionStatusBySceneInfo._repeated_finishedMainMissionIdList_codec);
			num += this.subMissionStatusList_.CalculateSize(MissionStatusBySceneInfo._repeated_subMissionStatusList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BB4 RID: 31668 RVA: 0x00147638 File Offset: 0x00145838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionStatusBySceneInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.unfinishedMainMissionIdList_.Add(other.unfinishedMainMissionIdList_);
			this.disabledMainMissionIdList_.Add(other.disabledMainMissionIdList_);
			this.mainMissionMcvList_.Add(other.mainMissionMcvList_);
			this.finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
			this.subMissionStatusList_.Add(other.subMissionStatusList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BB5 RID: 31669 RVA: 0x001476B5 File Offset: 0x001458B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BB6 RID: 31670 RVA: 0x001476C0 File Offset: 0x001458C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 72U)
				{
					if (num <= 56U)
					{
						if (num == 18U)
						{
							this.mainMissionMcvList_.AddEntriesFrom(ref input, MissionStatusBySceneInfo._repeated_mainMissionMcvList_codec);
							continue;
						}
						if (num != 56U)
						{
							goto IL_42;
						}
					}
					else if (num != 58U)
					{
						if (num != 72U)
						{
							goto IL_42;
						}
						goto IL_7C;
					}
					this.finishedMainMissionIdList_.AddEntriesFrom(ref input, MissionStatusBySceneInfo._repeated_finishedMainMissionIdList_codec);
					continue;
				}
				if (num <= 80U)
				{
					if (num == 74U)
					{
						goto IL_7C;
					}
					if (num != 80U)
					{
						goto IL_42;
					}
				}
				else if (num != 82U)
				{
					if (num != 106U)
					{
						goto IL_42;
					}
					this.subMissionStatusList_.AddEntriesFrom(ref input, MissionStatusBySceneInfo._repeated_subMissionStatusList_codec);
					continue;
				}
				this.unfinishedMainMissionIdList_.AddEntriesFrom(ref input, MissionStatusBySceneInfo._repeated_unfinishedMainMissionIdList_codec);
				continue;
				IL_42:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_7C:
				this.disabledMainMissionIdList_.AddEntriesFrom(ref input, MissionStatusBySceneInfo._repeated_disabledMainMissionIdList_codec);
			}
		}

		// Token: 0x04002F6F RID: 12143
		private static readonly MessageParser<MissionStatusBySceneInfo> _parser = new MessageParser<MissionStatusBySceneInfo>(() => new MissionStatusBySceneInfo());

		// Token: 0x04002F70 RID: 12144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F71 RID: 12145
		public const int UnfinishedMainMissionIdListFieldNumber = 10;

		// Token: 0x04002F72 RID: 12146
		private static readonly FieldCodec<uint> _repeated_unfinishedMainMissionIdList_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04002F73 RID: 12147
		private readonly RepeatedField<uint> unfinishedMainMissionIdList_ = new RepeatedField<uint>();

		// Token: 0x04002F74 RID: 12148
		public const int DisabledMainMissionIdListFieldNumber = 9;

		// Token: 0x04002F75 RID: 12149
		private static readonly FieldCodec<uint> _repeated_disabledMainMissionIdList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04002F76 RID: 12150
		private readonly RepeatedField<uint> disabledMainMissionIdList_ = new RepeatedField<uint>();

		// Token: 0x04002F77 RID: 12151
		public const int MainMissionMcvListFieldNumber = 2;

		// Token: 0x04002F78 RID: 12152
		private static readonly FieldCodec<MainMissionCustomValue> _repeated_mainMissionMcvList_codec = FieldCodec.ForMessage<MainMissionCustomValue>(18U, MainMissionCustomValue.Parser);

		// Token: 0x04002F79 RID: 12153
		private readonly RepeatedField<MainMissionCustomValue> mainMissionMcvList_ = new RepeatedField<MainMissionCustomValue>();

		// Token: 0x04002F7A RID: 12154
		public const int FinishedMainMissionIdListFieldNumber = 7;

		// Token: 0x04002F7B RID: 12155
		private static readonly FieldCodec<uint> _repeated_finishedMainMissionIdList_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04002F7C RID: 12156
		private readonly RepeatedField<uint> finishedMainMissionIdList_ = new RepeatedField<uint>();

		// Token: 0x04002F7D RID: 12157
		public const int SubMissionStatusListFieldNumber = 13;

		// Token: 0x04002F7E RID: 12158
		private static readonly FieldCodec<Mission> _repeated_subMissionStatusList_codec = FieldCodec.ForMessage<Mission>(106U, Mission.Parser);

		// Token: 0x04002F7F RID: 12159
		private readonly RepeatedField<Mission> subMissionStatusList_ = new RepeatedField<Mission>();
	}
}
