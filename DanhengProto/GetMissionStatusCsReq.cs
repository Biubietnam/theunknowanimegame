using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000725 RID: 1829
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMissionStatusCsReq : IMessage<GetMissionStatusCsReq>, IMessage, IEquatable<GetMissionStatusCsReq>, IDeepCloneable<GetMissionStatusCsReq>, IBufferMessage
	{
		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x060051BB RID: 20923 RVA: 0x000DBFD3 File Offset: 0x000DA1D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMissionStatusCsReq> Parser
		{
			get
			{
				return GetMissionStatusCsReq._parser;
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x000DBFDA File Offset: 0x000DA1DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMissionStatusCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001728 RID: 5928
		// (get) Token: 0x060051BD RID: 20925 RVA: 0x000DBFEC File Offset: 0x000DA1EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMissionStatusCsReq.Descriptor;
			}
		}

		// Token: 0x060051BE RID: 20926 RVA: 0x000DBFF3 File Offset: 0x000DA1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionStatusCsReq()
		{
		}

		// Token: 0x060051BF RID: 20927 RVA: 0x000DC01C File Offset: 0x000DA21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionStatusCsReq(GetMissionStatusCsReq other) : this()
		{
			this.missionEventIdList_ = other.missionEventIdList_.Clone();
			this.mainMissionIdList_ = other.mainMissionIdList_.Clone();
			this.subMissionIdList_ = other.subMissionIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060051C0 RID: 20928 RVA: 0x000DC073 File Offset: 0x000DA273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMissionStatusCsReq Clone()
		{
			return new GetMissionStatusCsReq(this);
		}

		// Token: 0x17001729 RID: 5929
		// (get) Token: 0x060051C1 RID: 20929 RVA: 0x000DC07B File Offset: 0x000DA27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MissionEventIdList
		{
			get
			{
				return this.missionEventIdList_;
			}
		}

		// Token: 0x1700172A RID: 5930
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x000DC083 File Offset: 0x000DA283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MainMissionIdList
		{
			get
			{
				return this.mainMissionIdList_;
			}
		}

		// Token: 0x1700172B RID: 5931
		// (get) Token: 0x060051C3 RID: 20931 RVA: 0x000DC08B File Offset: 0x000DA28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SubMissionIdList
		{
			get
			{
				return this.subMissionIdList_;
			}
		}

		// Token: 0x060051C4 RID: 20932 RVA: 0x000DC093 File Offset: 0x000DA293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMissionStatusCsReq);
		}

		// Token: 0x060051C5 RID: 20933 RVA: 0x000DC0A4 File Offset: 0x000DA2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMissionStatusCsReq other)
		{
			return other != null && (other == this || (this.missionEventIdList_.Equals(other.missionEventIdList_) && this.mainMissionIdList_.Equals(other.mainMissionIdList_) && this.subMissionIdList_.Equals(other.subMissionIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060051C6 RID: 20934 RVA: 0x000DC10C File Offset: 0x000DA30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.missionEventIdList_.GetHashCode();
			num ^= this.mainMissionIdList_.GetHashCode();
			num ^= this.subMissionIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060051C7 RID: 20935 RVA: 0x000DC15C File Offset: 0x000DA35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060051C8 RID: 20936 RVA: 0x000DC164 File Offset: 0x000DA364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060051C9 RID: 20937 RVA: 0x000DC170 File Offset: 0x000DA370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.mainMissionIdList_.WriteTo(ref output, GetMissionStatusCsReq._repeated_mainMissionIdList_codec);
			this.missionEventIdList_.WriteTo(ref output, GetMissionStatusCsReq._repeated_missionEventIdList_codec);
			this.subMissionIdList_.WriteTo(ref output, GetMissionStatusCsReq._repeated_subMissionIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060051CA RID: 20938 RVA: 0x000DC1C4 File Offset: 0x000DA3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.missionEventIdList_.CalculateSize(GetMissionStatusCsReq._repeated_missionEventIdList_codec);
			num += this.mainMissionIdList_.CalculateSize(GetMissionStatusCsReq._repeated_mainMissionIdList_codec);
			num += this.subMissionIdList_.CalculateSize(GetMissionStatusCsReq._repeated_subMissionIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060051CB RID: 20939 RVA: 0x000DC224 File Offset: 0x000DA424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMissionStatusCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.missionEventIdList_.Add(other.missionEventIdList_);
			this.mainMissionIdList_.Add(other.mainMissionIdList_);
			this.subMissionIdList_.Add(other.subMissionIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060051CC RID: 20940 RVA: 0x000DC27F File Offset: 0x000DA47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060051CD RID: 20941 RVA: 0x000DC288 File Offset: 0x000DA488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 40U || num == 42U)
					{
						this.mainMissionIdList_.AddEntriesFrom(ref input, GetMissionStatusCsReq._repeated_mainMissionIdList_codec);
						continue;
					}
					if (num == 64U)
					{
						goto IL_4E;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_4E;
					}
					if (num == 104U || num == 106U)
					{
						this.subMissionIdList_.AddEntriesFrom(ref input, GetMissionStatusCsReq._repeated_subMissionIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4E:
				this.missionEventIdList_.AddEntriesFrom(ref input, GetMissionStatusCsReq._repeated_missionEventIdList_codec);
			}
		}

		// Token: 0x0400201B RID: 8219
		private static readonly MessageParser<GetMissionStatusCsReq> _parser = new MessageParser<GetMissionStatusCsReq>(() => new GetMissionStatusCsReq());

		// Token: 0x0400201C RID: 8220
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400201D RID: 8221
		public const int MissionEventIdListFieldNumber = 8;

		// Token: 0x0400201E RID: 8222
		private static readonly FieldCodec<uint> _repeated_missionEventIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x0400201F RID: 8223
		private readonly RepeatedField<uint> missionEventIdList_ = new RepeatedField<uint>();

		// Token: 0x04002020 RID: 8224
		public const int MainMissionIdListFieldNumber = 5;

		// Token: 0x04002021 RID: 8225
		private static readonly FieldCodec<uint> _repeated_mainMissionIdList_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04002022 RID: 8226
		private readonly RepeatedField<uint> mainMissionIdList_ = new RepeatedField<uint>();

		// Token: 0x04002023 RID: 8227
		public const int SubMissionIdListFieldNumber = 13;

		// Token: 0x04002024 RID: 8228
		private static readonly FieldCodec<uint> _repeated_subMissionIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04002025 RID: 8229
		private readonly RepeatedField<uint> subMissionIdList_ = new RepeatedField<uint>();
	}
}
