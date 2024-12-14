using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AEB RID: 2795
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionSync : IMessage<MissionSync>, IMessage, IEquatable<MissionSync>, IDeepCloneable<MissionSync>, IBufferMessage
	{
		// Token: 0x170022BC RID: 8892
		// (get) Token: 0x06007BBA RID: 31674 RVA: 0x001478EF File Offset: 0x00145AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionSync> Parser
		{
			get
			{
				return MissionSync._parser;
			}
		}

		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x001478F6 File Offset: 0x00145AF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionSyncReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x06007BBC RID: 31676 RVA: 0x00147908 File Offset: 0x00145B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionSync.Descriptor;
			}
		}

		// Token: 0x06007BBD RID: 31677 RVA: 0x00147910 File Offset: 0x00145B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionSync()
		{
		}

		// Token: 0x06007BBE RID: 31678 RVA: 0x00147970 File Offset: 0x00145B70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionSync(MissionSync other) : this()
		{
			this.missionList_ = other.missionList_.Clone();
			this.eGKMFDANDLN_ = other.eGKMFDANDLN_.Clone();
			this.lGGFKNGGBJD_ = other.lGGFKNGGBJD_.Clone();
			this.dJOBGKDFLBI_ = other.dJOBGKDFLBI_.Clone();
			this.eKOKENIBLND_ = other.eKOKENIBLND_.Clone();
			this.finishedMainMissionIdList_ = other.finishedMainMissionIdList_.Clone();
			this.fHJPGKOKIMP_ = other.fHJPGKOKIMP_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BBF RID: 31679 RVA: 0x00147A0B File Offset: 0x00145C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionSync Clone()
		{
			return new MissionSync(this);
		}

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x00147A13 File Offset: 0x00145C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Mission> MissionList
		{
			get
			{
				return this.missionList_;
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x06007BC1 RID: 31681 RVA: 0x00147A1B File Offset: 0x00145C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LFNIHOHMNPN> EGKMFDANDLN
		{
			get
			{
				return this.eGKMFDANDLN_;
			}
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x00147A23 File Offset: 0x00145C23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OBEPIHAHMDF> LGGFKNGGBJD
		{
			get
			{
				return this.lGGFKNGGBJD_;
			}
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x06007BC3 RID: 31683 RVA: 0x00147A2B File Offset: 0x00145C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DJOBGKDFLBI
		{
			get
			{
				return this.dJOBGKDFLBI_;
			}
		}

		// Token: 0x170022C3 RID: 8899
		// (get) Token: 0x06007BC4 RID: 31684 RVA: 0x00147A33 File Offset: 0x00145C33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EKOKENIBLND
		{
			get
			{
				return this.eKOKENIBLND_;
			}
		}

		// Token: 0x170022C4 RID: 8900
		// (get) Token: 0x06007BC5 RID: 31685 RVA: 0x00147A3B File Offset: 0x00145C3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FinishedMainMissionIdList
		{
			get
			{
				return this.finishedMainMissionIdList_;
			}
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x06007BC6 RID: 31686 RVA: 0x00147A43 File Offset: 0x00145C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> FHJPGKOKIMP
		{
			get
			{
				return this.fHJPGKOKIMP_;
			}
		}

		// Token: 0x06007BC7 RID: 31687 RVA: 0x00147A4B File Offset: 0x00145C4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionSync);
		}

		// Token: 0x06007BC8 RID: 31688 RVA: 0x00147A5C File Offset: 0x00145C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionSync other)
		{
			return other != null && (other == this || (this.missionList_.Equals(other.missionList_) && this.eGKMFDANDLN_.Equals(other.eGKMFDANDLN_) && this.lGGFKNGGBJD_.Equals(other.lGGFKNGGBJD_) && this.dJOBGKDFLBI_.Equals(other.dJOBGKDFLBI_) && this.eKOKENIBLND_.Equals(other.eKOKENIBLND_) && this.finishedMainMissionIdList_.Equals(other.finishedMainMissionIdList_) && this.fHJPGKOKIMP_.Equals(other.fHJPGKOKIMP_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007BC9 RID: 31689 RVA: 0x00147B18 File Offset: 0x00145D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.missionList_.GetHashCode();
			num ^= this.eGKMFDANDLN_.GetHashCode();
			num ^= this.lGGFKNGGBJD_.GetHashCode();
			num ^= this.dJOBGKDFLBI_.GetHashCode();
			num ^= this.eKOKENIBLND_.GetHashCode();
			num ^= this.finishedMainMissionIdList_.GetHashCode();
			num ^= this.fHJPGKOKIMP_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007BCA RID: 31690 RVA: 0x00147BA0 File Offset: 0x00145DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007BCB RID: 31691 RVA: 0x00147BA8 File Offset: 0x00145DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007BCC RID: 31692 RVA: 0x00147BB4 File Offset: 0x00145DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.eKOKENIBLND_.WriteTo(ref output, MissionSync._repeated_eKOKENIBLND_codec);
			this.eGKMFDANDLN_.WriteTo(ref output, MissionSync._repeated_eGKMFDANDLN_codec);
			this.finishedMainMissionIdList_.WriteTo(ref output, MissionSync._repeated_finishedMainMissionIdList_codec);
			this.missionList_.WriteTo(ref output, MissionSync._repeated_missionList_codec);
			this.lGGFKNGGBJD_.WriteTo(ref output, MissionSync._repeated_lGGFKNGGBJD_codec);
			this.fHJPGKOKIMP_.WriteTo(ref output, MissionSync._repeated_fHJPGKOKIMP_codec);
			this.dJOBGKDFLBI_.WriteTo(ref output, MissionSync._repeated_dJOBGKDFLBI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007BCD RID: 31693 RVA: 0x00147C4C File Offset: 0x00145E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.missionList_.CalculateSize(MissionSync._repeated_missionList_codec);
			num += this.eGKMFDANDLN_.CalculateSize(MissionSync._repeated_eGKMFDANDLN_codec);
			num += this.lGGFKNGGBJD_.CalculateSize(MissionSync._repeated_lGGFKNGGBJD_codec);
			num += this.dJOBGKDFLBI_.CalculateSize(MissionSync._repeated_dJOBGKDFLBI_codec);
			num += this.eKOKENIBLND_.CalculateSize(MissionSync._repeated_eKOKENIBLND_codec);
			num += this.finishedMainMissionIdList_.CalculateSize(MissionSync._repeated_finishedMainMissionIdList_codec);
			num += this.fHJPGKOKIMP_.CalculateSize(MissionSync._repeated_fHJPGKOKIMP_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007BCE RID: 31694 RVA: 0x00147CF8 File Offset: 0x00145EF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionSync other)
		{
			if (other == null)
			{
				return;
			}
			this.missionList_.Add(other.missionList_);
			this.eGKMFDANDLN_.Add(other.eGKMFDANDLN_);
			this.lGGFKNGGBJD_.Add(other.lGGFKNGGBJD_);
			this.dJOBGKDFLBI_.Add(other.dJOBGKDFLBI_);
			this.eKOKENIBLND_.Add(other.eKOKENIBLND_);
			this.finishedMainMissionIdList_.Add(other.finishedMainMissionIdList_);
			this.fHJPGKOKIMP_.Add(other.fHJPGKOKIMP_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007BCF RID: 31695 RVA: 0x00147D97 File Offset: 0x00145F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007BD0 RID: 31696 RVA: 0x00147DA0 File Offset: 0x00145FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 42U)
				{
					if (num <= 88U)
					{
						if (num == 58U)
						{
							this.missionList_.AddEntriesFrom(ref input, MissionSync._repeated_missionList_codec);
							continue;
						}
						if (num == 82U)
						{
							this.lGGFKNGGBJD_.AddEntriesFrom(ref input, MissionSync._repeated_lGGFKNGGBJD_codec);
							continue;
						}
						if (num != 88U)
						{
							goto IL_60;
						}
					}
					else if (num != 90U)
					{
						if (num != 96U && num != 98U)
						{
							goto IL_60;
						}
						this.dJOBGKDFLBI_.AddEntriesFrom(ref input, MissionSync._repeated_dJOBGKDFLBI_codec);
						continue;
					}
					this.fHJPGKOKIMP_.AddEntriesFrom(ref input, MissionSync._repeated_fHJPGKOKIMP_codec);
					continue;
				}
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.eKOKENIBLND_.AddEntriesFrom(ref input, MissionSync._repeated_eKOKENIBLND_codec);
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						this.eGKMFDANDLN_.AddEntriesFrom(ref input, MissionSync._repeated_eGKMFDANDLN_codec);
						continue;
					}
					if (num == 40U || num == 42U)
					{
						this.finishedMainMissionIdList_.AddEntriesFrom(ref input, MissionSync._repeated_finishedMainMissionIdList_codec);
						continue;
					}
				}
				IL_60:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002F81 RID: 12161
		private static readonly MessageParser<MissionSync> _parser = new MessageParser<MissionSync>(() => new MissionSync());

		// Token: 0x04002F82 RID: 12162
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F83 RID: 12163
		public const int MissionListFieldNumber = 7;

		// Token: 0x04002F84 RID: 12164
		private static readonly FieldCodec<Mission> _repeated_missionList_codec = FieldCodec.ForMessage<Mission>(58U, Mission.Parser);

		// Token: 0x04002F85 RID: 12165
		private readonly RepeatedField<Mission> missionList_ = new RepeatedField<Mission>();

		// Token: 0x04002F86 RID: 12166
		public const int EGKMFDANDLNFieldNumber = 4;

		// Token: 0x04002F87 RID: 12167
		private static readonly FieldCodec<LFNIHOHMNPN> _repeated_eGKMFDANDLN_codec = FieldCodec.ForMessage<LFNIHOHMNPN>(34U, LFNIHOHMNPN.Parser);

		// Token: 0x04002F88 RID: 12168
		private readonly RepeatedField<LFNIHOHMNPN> eGKMFDANDLN_ = new RepeatedField<LFNIHOHMNPN>();

		// Token: 0x04002F89 RID: 12169
		public const int LGGFKNGGBJDFieldNumber = 10;

		// Token: 0x04002F8A RID: 12170
		private static readonly FieldCodec<OBEPIHAHMDF> _repeated_lGGFKNGGBJD_codec = FieldCodec.ForMessage<OBEPIHAHMDF>(82U, OBEPIHAHMDF.Parser);

		// Token: 0x04002F8B RID: 12171
		private readonly RepeatedField<OBEPIHAHMDF> lGGFKNGGBJD_ = new RepeatedField<OBEPIHAHMDF>();

		// Token: 0x04002F8C RID: 12172
		public const int DJOBGKDFLBIFieldNumber = 12;

		// Token: 0x04002F8D RID: 12173
		private static readonly FieldCodec<uint> _repeated_dJOBGKDFLBI_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x04002F8E RID: 12174
		private readonly RepeatedField<uint> dJOBGKDFLBI_ = new RepeatedField<uint>();

		// Token: 0x04002F8F RID: 12175
		public const int EKOKENIBLNDFieldNumber = 3;

		// Token: 0x04002F90 RID: 12176
		private static readonly FieldCodec<uint> _repeated_eKOKENIBLND_codec = FieldCodec.ForUInt32(26U);

		// Token: 0x04002F91 RID: 12177
		private readonly RepeatedField<uint> eKOKENIBLND_ = new RepeatedField<uint>();

		// Token: 0x04002F92 RID: 12178
		public const int FinishedMainMissionIdListFieldNumber = 5;

		// Token: 0x04002F93 RID: 12179
		private static readonly FieldCodec<uint> _repeated_finishedMainMissionIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04002F94 RID: 12180
		private readonly RepeatedField<uint> finishedMainMissionIdList_ = new RepeatedField<uint>();

		// Token: 0x04002F95 RID: 12181
		public const int FHJPGKOKIMPFieldNumber = 11;

		// Token: 0x04002F96 RID: 12182
		private static readonly FieldCodec<uint> _repeated_fHJPGKOKIMP_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x04002F97 RID: 12183
		private readonly RepeatedField<uint> fHJPGKOKIMP_ = new RepeatedField<uint>();
	}
}
