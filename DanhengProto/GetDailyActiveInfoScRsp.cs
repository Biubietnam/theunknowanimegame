using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000681 RID: 1665
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetDailyActiveInfoScRsp : IMessage<GetDailyActiveInfoScRsp>, IMessage, IEquatable<GetDailyActiveInfoScRsp>, IDeepCloneable<GetDailyActiveInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06004A8F RID: 19087 RVA: 0x000CAC8F File Offset: 0x000C8E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetDailyActiveInfoScRsp> Parser
		{
			get
			{
				return GetDailyActiveInfoScRsp._parser;
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x000CAC96 File Offset: 0x000C8E96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetDailyActiveInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06004A91 RID: 19089 RVA: 0x000CACA8 File Offset: 0x000C8EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDailyActiveInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004A92 RID: 19090 RVA: 0x000CACAF File Offset: 0x000C8EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDailyActiveInfoScRsp()
		{
		}

		// Token: 0x06004A93 RID: 19091 RVA: 0x000CACD0 File Offset: 0x000C8ED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDailyActiveInfoScRsp(GetDailyActiveInfoScRsp other) : this()
		{
			this.dailyActivePoint_ = other.dailyActivePoint_;
			this.dailyActiveQuestIdList_ = other.dailyActiveQuestIdList_.Clone();
			this.retcode_ = other.retcode_;
			this.dailyActiveLevelList_ = other.dailyActiveLevelList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x000CAD2E File Offset: 0x000C8F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDailyActiveInfoScRsp Clone()
		{
			return new GetDailyActiveInfoScRsp(this);
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06004A95 RID: 19093 RVA: 0x000CAD36 File Offset: 0x000C8F36
		// (set) Token: 0x06004A96 RID: 19094 RVA: 0x000CAD3E File Offset: 0x000C8F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DailyActivePoint
		{
			get
			{
				return this.dailyActivePoint_;
			}
			set
			{
				this.dailyActivePoint_ = value;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06004A97 RID: 19095 RVA: 0x000CAD47 File Offset: 0x000C8F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DailyActiveQuestIdList
		{
			get
			{
				return this.dailyActiveQuestIdList_;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x000CAD4F File Offset: 0x000C8F4F
		// (set) Token: 0x06004A99 RID: 19097 RVA: 0x000CAD57 File Offset: 0x000C8F57
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

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x000CAD60 File Offset: 0x000C8F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DailyActivityInfo> DailyActiveLevelList
		{
			get
			{
				return this.dailyActiveLevelList_;
			}
		}

		// Token: 0x06004A9B RID: 19099 RVA: 0x000CAD68 File Offset: 0x000C8F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDailyActiveInfoScRsp);
		}

		// Token: 0x06004A9C RID: 19100 RVA: 0x000CAD78 File Offset: 0x000C8F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDailyActiveInfoScRsp other)
		{
			return other != null && (other == this || (this.DailyActivePoint == other.DailyActivePoint && this.dailyActiveQuestIdList_.Equals(other.dailyActiveQuestIdList_) && this.Retcode == other.Retcode && this.dailyActiveLevelList_.Equals(other.dailyActiveLevelList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A9D RID: 19101 RVA: 0x000CADEC File Offset: 0x000C8FEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DailyActivePoint != 0U)
			{
				num ^= this.DailyActivePoint.GetHashCode();
			}
			num ^= this.dailyActiveQuestIdList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.dailyActiveLevelList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A9E RID: 19102 RVA: 0x000CAE60 File Offset: 0x000C9060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004A9F RID: 19103 RVA: 0x000CAE68 File Offset: 0x000C9068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AA0 RID: 19104 RVA: 0x000CAE74 File Offset: 0x000C9074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dailyActiveLevelList_.WriteTo(ref output, GetDailyActiveInfoScRsp._repeated_dailyActiveLevelList_codec);
			if (this.DailyActivePoint != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.DailyActivePoint);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Retcode);
			}
			this.dailyActiveQuestIdList_.WriteTo(ref output, GetDailyActiveInfoScRsp._repeated_dailyActiveQuestIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AA1 RID: 19105 RVA: 0x000CAEF0 File Offset: 0x000C90F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DailyActivePoint != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DailyActivePoint);
			}
			num += this.dailyActiveQuestIdList_.CalculateSize(GetDailyActiveInfoScRsp._repeated_dailyActiveQuestIdList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.dailyActiveLevelList_.CalculateSize(GetDailyActiveInfoScRsp._repeated_dailyActiveLevelList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004AA2 RID: 19106 RVA: 0x000CAF6C File Offset: 0x000C916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDailyActiveInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DailyActivePoint != 0U)
			{
				this.DailyActivePoint = other.DailyActivePoint;
			}
			this.dailyActiveQuestIdList_.Add(other.dailyActiveQuestIdList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.dailyActiveLevelList_.Add(other.dailyActiveLevelList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004AA3 RID: 19107 RVA: 0x000CAFDE File Offset: 0x000C91DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AA4 RID: 19108 RVA: 0x000CAFE8 File Offset: 0x000C91E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 10U)
					{
						this.dailyActiveLevelList_.AddEntriesFrom(ref input, GetDailyActiveInfoScRsp._repeated_dailyActiveLevelList_codec);
						continue;
					}
					if (num == 48U)
					{
						this.DailyActivePoint = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 64U || num == 66U)
					{
						this.dailyActiveQuestIdList_.AddEntriesFrom(ref input, GetDailyActiveInfoScRsp._repeated_dailyActiveQuestIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D8F RID: 7567
		private static readonly MessageParser<GetDailyActiveInfoScRsp> _parser = new MessageParser<GetDailyActiveInfoScRsp>(() => new GetDailyActiveInfoScRsp());

		// Token: 0x04001D90 RID: 7568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001D91 RID: 7569
		public const int DailyActivePointFieldNumber = 6;

		// Token: 0x04001D92 RID: 7570
		private uint dailyActivePoint_;

		// Token: 0x04001D93 RID: 7571
		public const int DailyActiveQuestIdListFieldNumber = 8;

		// Token: 0x04001D94 RID: 7572
		private static readonly FieldCodec<uint> _repeated_dailyActiveQuestIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04001D95 RID: 7573
		private readonly RepeatedField<uint> dailyActiveQuestIdList_ = new RepeatedField<uint>();

		// Token: 0x04001D96 RID: 7574
		public const int RetcodeFieldNumber = 7;

		// Token: 0x04001D97 RID: 7575
		private uint retcode_;

		// Token: 0x04001D98 RID: 7576
		public const int DailyActiveLevelListFieldNumber = 1;

		// Token: 0x04001D99 RID: 7577
		private static readonly FieldCodec<DailyActivityInfo> _repeated_dailyActiveLevelList_codec = FieldCodec.ForMessage<DailyActivityInfo>(10U, DailyActivityInfo.Parser);

		// Token: 0x04001D9A RID: 7578
		private readonly RepeatedField<DailyActivityInfo> dailyActiveLevelList_ = new RepeatedField<DailyActivityInfo>();
	}
}
