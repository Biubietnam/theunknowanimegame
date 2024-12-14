using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200101D RID: 4125
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournStartCsReq : IMessage<RogueTournStartCsReq>, IMessage, IEquatable<RogueTournStartCsReq>, IDeepCloneable<RogueTournStartCsReq>, IBufferMessage
	{
		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600B769 RID: 46953 RVA: 0x001EC10B File Offset: 0x001EA30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournStartCsReq> Parser
		{
			get
			{
				return RogueTournStartCsReq._parser;
			}
		}

		// Token: 0x170033AC RID: 13228
		// (get) Token: 0x0600B76A RID: 46954 RVA: 0x001EC112 File Offset: 0x001EA312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournStartCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600B76B RID: 46955 RVA: 0x001EC124 File Offset: 0x001EA324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournStartCsReq.Descriptor;
			}
		}

		// Token: 0x0600B76C RID: 46956 RVA: 0x001EC12B File Offset: 0x001EA32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournStartCsReq()
		{
		}

		// Token: 0x0600B76D RID: 46957 RVA: 0x001EC14C File Offset: 0x001EA34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournStartCsReq(RogueTournStartCsReq other) : this()
		{
			this.areaId_ = other.areaId_;
			this.startDifficultyIdList_ = other.startDifficultyIdList_.Clone();
			this.week_ = other.week_;
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B76E RID: 46958 RVA: 0x001EC1AA File Offset: 0x001EA3AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournStartCsReq Clone()
		{
			return new RogueTournStartCsReq(this);
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600B76F RID: 46959 RVA: 0x001EC1B2 File Offset: 0x001EA3B2
		// (set) Token: 0x0600B770 RID: 46960 RVA: 0x001EC1BA File Offset: 0x001EA3BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AreaId
		{
			get
			{
				return this.areaId_;
			}
			set
			{
				this.areaId_ = value;
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600B771 RID: 46961 RVA: 0x001EC1C3 File Offset: 0x001EA3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> StartDifficultyIdList
		{
			get
			{
				return this.startDifficultyIdList_;
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600B772 RID: 46962 RVA: 0x001EC1CB File Offset: 0x001EA3CB
		// (set) Token: 0x0600B773 RID: 46963 RVA: 0x001EC1D3 File Offset: 0x001EA3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Week
		{
			get
			{
				return this.week_;
			}
			set
			{
				this.week_ = value;
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600B774 RID: 46964 RVA: 0x001EC1DC File Offset: 0x001EA3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x0600B775 RID: 46965 RVA: 0x001EC1E4 File Offset: 0x001EA3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournStartCsReq);
		}

		// Token: 0x0600B776 RID: 46966 RVA: 0x001EC1F4 File Offset: 0x001EA3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournStartCsReq other)
		{
			return other != null && (other == this || (this.AreaId == other.AreaId && this.startDifficultyIdList_.Equals(other.startDifficultyIdList_) && this.Week == other.Week && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B777 RID: 46967 RVA: 0x001EC268 File Offset: 0x001EA468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AreaId != 0U)
			{
				num ^= this.AreaId.GetHashCode();
			}
			num ^= this.startDifficultyIdList_.GetHashCode();
			if (this.Week != 0U)
			{
				num ^= this.Week.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B778 RID: 46968 RVA: 0x001EC2DC File Offset: 0x001EA4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B779 RID: 46969 RVA: 0x001EC2E4 File Offset: 0x001EA4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B77A RID: 46970 RVA: 0x001EC2F0 File Offset: 0x001EA4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, RogueTournStartCsReq._repeated_baseAvatarIdList_codec);
			this.startDifficultyIdList_.WriteTo(ref output, RogueTournStartCsReq._repeated_startDifficultyIdList_codec);
			if (this.AreaId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.AreaId);
			}
			if (this.Week != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Week);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B77B RID: 46971 RVA: 0x001EC36C File Offset: 0x001EA56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AreaId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AreaId);
			}
			num += this.startDifficultyIdList_.CalculateSize(RogueTournStartCsReq._repeated_startDifficultyIdList_codec);
			if (this.Week != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Week);
			}
			num += this.baseAvatarIdList_.CalculateSize(RogueTournStartCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B77C RID: 46972 RVA: 0x001EC3E8 File Offset: 0x001EA5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournStartCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AreaId != 0U)
			{
				this.AreaId = other.AreaId;
			}
			this.startDifficultyIdList_.Add(other.startDifficultyIdList_);
			if (other.Week != 0U)
			{
				this.Week = other.Week;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B77D RID: 46973 RVA: 0x001EC45A File Offset: 0x001EA65A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B77E RID: 46974 RVA: 0x001EC464 File Offset: 0x001EA664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 16U || num == 18U)
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, RogueTournStartCsReq._repeated_baseAvatarIdList_codec);
						continue;
					}
					if (num == 32U)
					{
						goto IL_4E;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_4E;
					}
					if (num == 40U)
					{
						this.AreaId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.Week = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4E:
				this.startDifficultyIdList_.AddEntriesFrom(ref input, RogueTournStartCsReq._repeated_startDifficultyIdList_codec);
			}
		}

		// Token: 0x04004A4B RID: 19019
		private static readonly MessageParser<RogueTournStartCsReq> _parser = new MessageParser<RogueTournStartCsReq>(() => new RogueTournStartCsReq());

		// Token: 0x04004A4C RID: 19020
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A4D RID: 19021
		public const int AreaIdFieldNumber = 5;

		// Token: 0x04004A4E RID: 19022
		private uint areaId_;

		// Token: 0x04004A4F RID: 19023
		public const int StartDifficultyIdListFieldNumber = 4;

		// Token: 0x04004A50 RID: 19024
		private static readonly FieldCodec<uint> _repeated_startDifficultyIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x04004A51 RID: 19025
		private readonly RepeatedField<uint> startDifficultyIdList_ = new RepeatedField<uint>();

		// Token: 0x04004A52 RID: 19026
		public const int WeekFieldNumber = 14;

		// Token: 0x04004A53 RID: 19027
		private uint week_;

		// Token: 0x04004A54 RID: 19028
		public const int BaseAvatarIdListFieldNumber = 2;

		// Token: 0x04004A55 RID: 19029
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04004A56 RID: 19030
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();
	}
}
