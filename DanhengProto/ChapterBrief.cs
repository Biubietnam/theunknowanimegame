using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001D5 RID: 469
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChapterBrief : IMessage<ChapterBrief>, IMessage, IEquatable<ChapterBrief>, IDeepCloneable<ChapterBrief>, IBufferMessage
	{
		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0003C3E1 File Offset: 0x0003A5E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChapterBrief> Parser
		{
			get
			{
				return ChapterBrief._parser;
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0003C3E8 File Offset: 0x0003A5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChapterBriefReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0003C3FA File Offset: 0x0003A5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChapterBrief.Descriptor;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0003C401 File Offset: 0x0003A601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterBrief()
		{
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0003C414 File Offset: 0x0003A614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterBrief(ChapterBrief other) : this()
		{
			this.id_ = other.id_;
			this.jJGNOMGPCKM_ = other.jJGNOMGPCKM_;
			this.takenRewardIdList_ = other.takenRewardIdList_.Clone();
			this.isNew_ = other.isNew_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0003C46D File Offset: 0x0003A66D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChapterBrief Clone()
		{
			return new ChapterBrief(this);
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0003C475 File Offset: 0x0003A675
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x0003C47D File Offset: 0x0003A67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0003C486 File Offset: 0x0003A686
		// (set) Token: 0x0600150F RID: 5391 RVA: 0x0003C48E File Offset: 0x0003A68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint JJGNOMGPCKM
		{
			get
			{
				return this.jJGNOMGPCKM_;
			}
			set
			{
				this.jJGNOMGPCKM_ = value;
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0003C497 File Offset: 0x0003A697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TakenRewardIdList
		{
			get
			{
				return this.takenRewardIdList_;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0003C49F File Offset: 0x0003A69F
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x0003C4A7 File Offset: 0x0003A6A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0003C4B0 File Offset: 0x0003A6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChapterBrief);
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0003C4C0 File Offset: 0x0003A6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChapterBrief other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.JJGNOMGPCKM == other.JJGNOMGPCKM && this.takenRewardIdList_.Equals(other.takenRewardIdList_) && this.IsNew == other.IsNew && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0003C530 File Offset: 0x0003A730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.JJGNOMGPCKM != 0U)
			{
				num ^= this.JJGNOMGPCKM.GetHashCode();
			}
			num ^= this.takenRewardIdList_.GetHashCode();
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0003C5AF File Offset: 0x0003A7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0003C5B7 File Offset: 0x0003A7B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0003C5C0 File Offset: 0x0003A7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsNew)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsNew);
			}
			this.takenRewardIdList_.WriteTo(ref output, ChapterBrief._repeated_takenRewardIdList_codec);
			if (this.Id != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Id);
			}
			if (this.JJGNOMGPCKM != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.JJGNOMGPCKM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0003C648 File Offset: 0x0003A848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.JJGNOMGPCKM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.JJGNOMGPCKM);
			}
			num += this.takenRewardIdList_.CalculateSize(ChapterBrief._repeated_takenRewardIdList_codec);
			if (this.IsNew)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0003C6C0 File Offset: 0x0003A8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChapterBrief other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.JJGNOMGPCKM != 0U)
			{
				this.JJGNOMGPCKM = other.JJGNOMGPCKM;
			}
			this.takenRewardIdList_.Add(other.takenRewardIdList_);
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0003C735 File Offset: 0x0003A935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600151C RID: 5404 RVA: 0x0003C740 File Offset: 0x0003A940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 32U)
				{
					if (num == 8U)
					{
						this.IsNew = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						goto IL_43;
					}
				}
				else
				{
					if (num == 34U)
					{
						goto IL_43;
					}
					if (num == 64U)
					{
						this.Id = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.JJGNOMGPCKM = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_43:
				this.takenRewardIdList_.AddEntriesFrom(ref input, ChapterBrief._repeated_takenRewardIdList_codec);
			}
		}

		// Token: 0x040008CD RID: 2253
		private static readonly MessageParser<ChapterBrief> _parser = new MessageParser<ChapterBrief>(() => new ChapterBrief());

		// Token: 0x040008CE RID: 2254
		private UnknownFieldSet _unknownFields;

		// Token: 0x040008CF RID: 2255
		public const int IdFieldNumber = 8;

		// Token: 0x040008D0 RID: 2256
		private uint id_;

		// Token: 0x040008D1 RID: 2257
		public const int JJGNOMGPCKMFieldNumber = 14;

		// Token: 0x040008D2 RID: 2258
		private uint jJGNOMGPCKM_;

		// Token: 0x040008D3 RID: 2259
		public const int TakenRewardIdListFieldNumber = 4;

		// Token: 0x040008D4 RID: 2260
		private static readonly FieldCodec<uint> _repeated_takenRewardIdList_codec = FieldCodec.ForUInt32(34U);

		// Token: 0x040008D5 RID: 2261
		private readonly RepeatedField<uint> takenRewardIdList_ = new RepeatedField<uint>();

		// Token: 0x040008D6 RID: 2262
		public const int IsNewFieldNumber = 1;

		// Token: 0x040008D7 RID: 2263
		private bool isNew_;
	}
}
