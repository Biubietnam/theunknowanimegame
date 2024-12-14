using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200044B RID: 1099
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterFightActivityStageCsReq : IMessage<EnterFightActivityStageCsReq>, IMessage, IEquatable<EnterFightActivityStageCsReq>, IDeepCloneable<EnterFightActivityStageCsReq>, IBufferMessage
	{
		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x060030D6 RID: 12502 RVA: 0x0008625F File Offset: 0x0008445F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterFightActivityStageCsReq> Parser
		{
			get
			{
				return EnterFightActivityStageCsReq._parser;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x060030D7 RID: 12503 RVA: 0x00086266 File Offset: 0x00084466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterFightActivityStageCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x060030D8 RID: 12504 RVA: 0x00086278 File Offset: 0x00084478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterFightActivityStageCsReq.Descriptor;
			}
		}

		// Token: 0x060030D9 RID: 12505 RVA: 0x0008627F File Offset: 0x0008447F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFightActivityStageCsReq()
		{
		}

		// Token: 0x060030DA RID: 12506 RVA: 0x000862A8 File Offset: 0x000844A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFightActivityStageCsReq(EnterFightActivityStageCsReq other) : this()
		{
			this.itemList_ = other.itemList_.Clone();
			this.iPMEKIEMFPD_ = other.iPMEKIEMFPD_.Clone();
			this.avatarList_ = other.avatarList_.Clone();
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x00086317 File Offset: 0x00084517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterFightActivityStageCsReq Clone()
		{
			return new EnterFightActivityStageCsReq(this);
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x060030DC RID: 12508 RVA: 0x0008631F File Offset: 0x0008451F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ItemList
		{
			get
			{
				return this.itemList_;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x060030DD RID: 12509 RVA: 0x00086327 File Offset: 0x00084527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IIFKDONLDMA> IPMEKIEMFPD
		{
			get
			{
				return this.iPMEKIEMFPD_;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x060030DE RID: 12510 RVA: 0x0008632F File Offset: 0x0008452F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x060030DF RID: 12511 RVA: 0x00086337 File Offset: 0x00084537
		// (set) Token: 0x060030E0 RID: 12512 RVA: 0x0008633F File Offset: 0x0008453F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x060030E1 RID: 12513 RVA: 0x00086348 File Offset: 0x00084548
		// (set) Token: 0x060030E2 RID: 12514 RVA: 0x00086350 File Offset: 0x00084550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x00086359 File Offset: 0x00084559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterFightActivityStageCsReq);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x00086368 File Offset: 0x00084568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterFightActivityStageCsReq other)
		{
			return other != null && (other == this || (this.itemList_.Equals(other.itemList_) && this.iPMEKIEMFPD_.Equals(other.iPMEKIEMFPD_) && this.avatarList_.Equals(other.avatarList_) && this.AHFNGPLDAII == other.AHFNGPLDAII && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000863F0 File Offset: 0x000845F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.itemList_.GetHashCode();
			num ^= this.iPMEKIEMFPD_.GetHashCode();
			num ^= this.avatarList_.GetHashCode();
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x00086472 File Offset: 0x00084672
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x0008647A File Offset: 0x0008467A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x00086484 File Offset: 0x00084684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemList_.WriteTo(ref output, EnterFightActivityStageCsReq._repeated_itemList_codec);
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			this.iPMEKIEMFPD_.WriteTo(ref output, EnterFightActivityStageCsReq._repeated_iPMEKIEMFPD_codec);
			this.avatarList_.WriteTo(ref output, EnterFightActivityStageCsReq._repeated_avatarList_codec);
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x00086510 File Offset: 0x00084710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemList_.CalculateSize(EnterFightActivityStageCsReq._repeated_itemList_codec);
			num += this.iPMEKIEMFPD_.CalculateSize(EnterFightActivityStageCsReq._repeated_iPMEKIEMFPD_codec);
			num += this.avatarList_.CalculateSize(EnterFightActivityStageCsReq._repeated_avatarList_codec);
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000865A0 File Offset: 0x000847A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterFightActivityStageCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.itemList_.Add(other.itemList_);
			this.iPMEKIEMFPD_.Add(other.iPMEKIEMFPD_);
			this.avatarList_.Add(other.avatarList_);
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x00086623 File Offset: 0x00084823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x0008662C File Offset: 0x0008482C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 16U)
				{
					if (num <= 64U)
					{
						if (num == 26U)
						{
							this.iPMEKIEMFPD_.AddEntriesFrom(ref input, EnterFightActivityStageCsReq._repeated_iPMEKIEMFPD_codec);
							continue;
						}
						if (num != 64U)
						{
							goto IL_35;
						}
					}
					else if (num != 66U)
					{
						if (num != 120U)
						{
							goto IL_35;
						}
						this.GroupId = input.ReadUInt32();
						continue;
					}
					this.avatarList_.AddEntriesFrom(ref input, EnterFightActivityStageCsReq._repeated_avatarList_codec);
					continue;
				}
				if (num == 8U || num == 10U)
				{
					this.itemList_.AddEntriesFrom(ref input, EnterFightActivityStageCsReq._repeated_itemList_codec);
					continue;
				}
				if (num == 16U)
				{
					this.AHFNGPLDAII = input.ReadUInt32();
					continue;
				}
				IL_35:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400136D RID: 4973
		private static readonly MessageParser<EnterFightActivityStageCsReq> _parser = new MessageParser<EnterFightActivityStageCsReq>(() => new EnterFightActivityStageCsReq());

		// Token: 0x0400136E RID: 4974
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400136F RID: 4975
		public const int ItemListFieldNumber = 1;

		// Token: 0x04001370 RID: 4976
		private static readonly FieldCodec<uint> _repeated_itemList_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04001371 RID: 4977
		private readonly RepeatedField<uint> itemList_ = new RepeatedField<uint>();

		// Token: 0x04001372 RID: 4978
		public const int IPMEKIEMFPDFieldNumber = 3;

		// Token: 0x04001373 RID: 4979
		private static readonly FieldCodec<IIFKDONLDMA> _repeated_iPMEKIEMFPD_codec = FieldCodec.ForMessage<IIFKDONLDMA>(26U, IIFKDONLDMA.Parser);

		// Token: 0x04001374 RID: 4980
		private readonly RepeatedField<IIFKDONLDMA> iPMEKIEMFPD_ = new RepeatedField<IIFKDONLDMA>();

		// Token: 0x04001375 RID: 4981
		public const int AvatarListFieldNumber = 8;

		// Token: 0x04001376 RID: 4982
		private static readonly FieldCodec<uint> _repeated_avatarList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04001377 RID: 4983
		private readonly RepeatedField<uint> avatarList_ = new RepeatedField<uint>();

		// Token: 0x04001378 RID: 4984
		public const int AHFNGPLDAIIFieldNumber = 2;

		// Token: 0x04001379 RID: 4985
		private uint aHFNGPLDAII_;

		// Token: 0x0400137A RID: 4986
		public const int GroupIdFieldNumber = 15;

		// Token: 0x0400137B RID: 4987
		private uint groupId_;
	}
}
