using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C37 RID: 3127
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcRogueGameInfo : IMessage<NpcRogueGameInfo>, IMessage, IEquatable<NpcRogueGameInfo>, IDeepCloneable<NpcRogueGameInfo>, IBufferMessage
	{
		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x06008A96 RID: 35478 RVA: 0x0016DF83 File Offset: 0x0016C183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcRogueGameInfo> Parser
		{
			get
			{
				return NpcRogueGameInfo._parser;
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x06008A97 RID: 35479 RVA: 0x0016DF8A File Offset: 0x0016C18A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NpcRogueGameInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x06008A98 RID: 35480 RVA: 0x0016DF9C File Offset: 0x0016C19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcRogueGameInfo.Descriptor;
			}
		}

		// Token: 0x06008A99 RID: 35481 RVA: 0x0016DFA3 File Offset: 0x0016C1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcRogueGameInfo()
		{
		}

		// Token: 0x06008A9A RID: 35482 RVA: 0x0016DFC4 File Offset: 0x0016C1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcRogueGameInfo(NpcRogueGameInfo other) : this()
		{
			this.lFEPBAJOCPE_ = other.lFEPBAJOCPE_.Clone();
			this.aeonTalkId_ = other.aeonTalkId_;
			this.finishDialogue_ = other.finishDialogue_;
			this.lCPMPOKHAEJ_ = other.lCPMPOKHAEJ_;
			this.nHJJKLBKCOJ_ = other.nHJJKLBKCOJ_;
			this.dialogueEventParamList_ = other.dialogueEventParamList_.Clone();
			this.jEJCAFHFJFJ_ = other.jEJCAFHFJFJ_;
			this.talkDialogueId_ = other.talkDialogueId_;
			this.eventUniqueId_ = other.eventUniqueId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A9B RID: 35483 RVA: 0x0016E05E File Offset: 0x0016C25E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcRogueGameInfo Clone()
		{
			return new NpcRogueGameInfo(this);
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x06008A9C RID: 35484 RVA: 0x0016E066 File Offset: 0x0016C266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<uint, uint> LFEPBAJOCPE
		{
			get
			{
				return this.lFEPBAJOCPE_;
			}
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x06008A9D RID: 35485 RVA: 0x0016E06E File Offset: 0x0016C26E
		// (set) Token: 0x06008A9E RID: 35486 RVA: 0x0016E076 File Offset: 0x0016C276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonTalkId
		{
			get
			{
				return this.aeonTalkId_;
			}
			set
			{
				this.aeonTalkId_ = value;
			}
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x06008A9F RID: 35487 RVA: 0x0016E07F File Offset: 0x0016C27F
		// (set) Token: 0x06008AA0 RID: 35488 RVA: 0x0016E087 File Offset: 0x0016C287
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FinishDialogue
		{
			get
			{
				return this.finishDialogue_;
			}
			set
			{
				this.finishDialogue_ = value;
			}
		}

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x06008AA1 RID: 35489 RVA: 0x0016E090 File Offset: 0x0016C290
		// (set) Token: 0x06008AA2 RID: 35490 RVA: 0x0016E098 File Offset: 0x0016C298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LCPMPOKHAEJ
		{
			get
			{
				return this.lCPMPOKHAEJ_;
			}
			set
			{
				this.lCPMPOKHAEJ_ = value;
			}
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x06008AA3 RID: 35491 RVA: 0x0016E0A1 File Offset: 0x0016C2A1
		// (set) Token: 0x06008AA4 RID: 35492 RVA: 0x0016E0A9 File Offset: 0x0016C2A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NHJJKLBKCOJ
		{
			get
			{
				return this.nHJJKLBKCOJ_;
			}
			set
			{
				this.nHJJKLBKCOJ_ = value;
			}
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x06008AA5 RID: 35493 RVA: 0x0016E0B2 File Offset: 0x0016C2B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NpcDialogueEventParam> DialogueEventParamList
		{
			get
			{
				return this.dialogueEventParamList_;
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x06008AA6 RID: 35494 RVA: 0x0016E0BA File Offset: 0x0016C2BA
		// (set) Token: 0x06008AA7 RID: 35495 RVA: 0x0016E0C2 File Offset: 0x0016C2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool JEJCAFHFJFJ
		{
			get
			{
				return this.jEJCAFHFJFJ_;
			}
			set
			{
				this.jEJCAFHFJFJ_ = value;
			}
		}

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x06008AA8 RID: 35496 RVA: 0x0016E0CB File Offset: 0x0016C2CB
		// (set) Token: 0x06008AA9 RID: 35497 RVA: 0x0016E0D3 File Offset: 0x0016C2D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalkDialogueId
		{
			get
			{
				return this.talkDialogueId_;
			}
			set
			{
				this.talkDialogueId_ = value;
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x06008AAA RID: 35498 RVA: 0x0016E0DC File Offset: 0x0016C2DC
		// (set) Token: 0x06008AAB RID: 35499 RVA: 0x0016E0E4 File Offset: 0x0016C2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventUniqueId
		{
			get
			{
				return this.eventUniqueId_;
			}
			set
			{
				this.eventUniqueId_ = value;
			}
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x0016E0ED File Offset: 0x0016C2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcRogueGameInfo);
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x0016E0FC File Offset: 0x0016C2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcRogueGameInfo other)
		{
			return other != null && (other == this || (this.LFEPBAJOCPE.Equals(other.LFEPBAJOCPE) && this.AeonTalkId == other.AeonTalkId && this.FinishDialogue == other.FinishDialogue && this.LCPMPOKHAEJ == other.LCPMPOKHAEJ && this.NHJJKLBKCOJ == other.NHJJKLBKCOJ && this.dialogueEventParamList_.Equals(other.dialogueEventParamList_) && this.JEJCAFHFJFJ == other.JEJCAFHFJFJ && this.TalkDialogueId == other.TalkDialogueId && this.EventUniqueId == other.EventUniqueId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x0016E1C0 File Offset: 0x0016C3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.LFEPBAJOCPE.GetHashCode();
			if (this.AeonTalkId != 0U)
			{
				num ^= this.AeonTalkId.GetHashCode();
			}
			if (this.FinishDialogue)
			{
				num ^= this.FinishDialogue.GetHashCode();
			}
			if (this.LCPMPOKHAEJ != 0U)
			{
				num ^= this.LCPMPOKHAEJ.GetHashCode();
			}
			if (this.NHJJKLBKCOJ)
			{
				num ^= this.NHJJKLBKCOJ.GetHashCode();
			}
			num ^= this.dialogueEventParamList_.GetHashCode();
			if (this.JEJCAFHFJFJ)
			{
				num ^= this.JEJCAFHFJFJ.GetHashCode();
			}
			if (this.TalkDialogueId != 0U)
			{
				num ^= this.TalkDialogueId.GetHashCode();
			}
			if (this.EventUniqueId != 0U)
			{
				num ^= this.EventUniqueId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x0016E2B1 File Offset: 0x0016C4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x0016E2B9 File Offset: 0x0016C4B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x0016E2C4 File Offset: 0x0016C4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.lFEPBAJOCPE_.WriteTo(ref output, NpcRogueGameInfo._map_lFEPBAJOCPE_codec);
			if (this.FinishDialogue)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FinishDialogue);
			}
			if (this.AeonTalkId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.AeonTalkId);
			}
			this.dialogueEventParamList_.WriteTo(ref output, NpcRogueGameInfo._repeated_dialogueEventParamList_codec);
			if (this.TalkDialogueId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TalkDialogueId);
			}
			if (this.NHJJKLBKCOJ)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.NHJJKLBKCOJ);
			}
			if (this.EventUniqueId != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.EventUniqueId);
			}
			if (this.LCPMPOKHAEJ != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.LCPMPOKHAEJ);
			}
			if (this.JEJCAFHFJFJ)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.JEJCAFHFJFJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x0016E3CC File Offset: 0x0016C5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.lFEPBAJOCPE_.CalculateSize(NpcRogueGameInfo._map_lFEPBAJOCPE_codec);
			if (this.AeonTalkId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonTalkId);
			}
			if (this.FinishDialogue)
			{
				num += 2;
			}
			if (this.LCPMPOKHAEJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LCPMPOKHAEJ);
			}
			if (this.NHJJKLBKCOJ)
			{
				num += 2;
			}
			num += this.dialogueEventParamList_.CalculateSize(NpcRogueGameInfo._repeated_dialogueEventParamList_codec);
			if (this.JEJCAFHFJFJ)
			{
				num += 2;
			}
			if (this.TalkDialogueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalkDialogueId);
			}
			if (this.EventUniqueId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventUniqueId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x0016E49C File Offset: 0x0016C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcRogueGameInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.lFEPBAJOCPE_.MergeFrom(other.lFEPBAJOCPE_);
			if (other.AeonTalkId != 0U)
			{
				this.AeonTalkId = other.AeonTalkId;
			}
			if (other.FinishDialogue)
			{
				this.FinishDialogue = other.FinishDialogue;
			}
			if (other.LCPMPOKHAEJ != 0U)
			{
				this.LCPMPOKHAEJ = other.LCPMPOKHAEJ;
			}
			if (other.NHJJKLBKCOJ)
			{
				this.NHJJKLBKCOJ = other.NHJJKLBKCOJ;
			}
			this.dialogueEventParamList_.Add(other.dialogueEventParamList_);
			if (other.JEJCAFHFJFJ)
			{
				this.JEJCAFHFJFJ = other.JEJCAFHFJFJ;
			}
			if (other.TalkDialogueId != 0U)
			{
				this.TalkDialogueId = other.TalkDialogueId;
			}
			if (other.EventUniqueId != 0U)
			{
				this.EventUniqueId = other.EventUniqueId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x0016E572 File Offset: 0x0016C772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x0016E57C File Offset: 0x0016C77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num <= 24U)
					{
						if (num == 18U)
						{
							this.lFEPBAJOCPE_.AddEntriesFrom(ref input, NpcRogueGameInfo._map_lFEPBAJOCPE_codec);
							continue;
						}
						if (num == 24U)
						{
							this.FinishDialogue = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 32U)
						{
							this.AeonTalkId = input.ReadUInt32();
							continue;
						}
						if (num == 42U)
						{
							this.dialogueEventParamList_.AddEntriesFrom(ref input, NpcRogueGameInfo._repeated_dialogueEventParamList_codec);
							continue;
						}
					}
				}
				else if (num <= 72U)
				{
					if (num == 48U)
					{
						this.TalkDialogueId = input.ReadUInt32();
						continue;
					}
					if (num == 72U)
					{
						this.NHJJKLBKCOJ = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EventUniqueId = input.ReadUInt32();
						continue;
					}
					if (num == 112U)
					{
						this.LCPMPOKHAEJ = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.JEJCAFHFJFJ = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003522 RID: 13602
		private static readonly MessageParser<NpcRogueGameInfo> _parser = new MessageParser<NpcRogueGameInfo>(() => new NpcRogueGameInfo());

		// Token: 0x04003523 RID: 13603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003524 RID: 13604
		public const int LFEPBAJOCPEFieldNumber = 2;

		// Token: 0x04003525 RID: 13605
		private static readonly MapField<uint, uint>.Codec _map_lFEPBAJOCPE_codec = new MapField<uint, uint>.Codec(FieldCodec.ForUInt32(8U, 0U), FieldCodec.ForUInt32(16U, 0U), 18U);

		// Token: 0x04003526 RID: 13606
		private readonly MapField<uint, uint> lFEPBAJOCPE_ = new MapField<uint, uint>();

		// Token: 0x04003527 RID: 13607
		public const int AeonTalkIdFieldNumber = 4;

		// Token: 0x04003528 RID: 13608
		private uint aeonTalkId_;

		// Token: 0x04003529 RID: 13609
		public const int FinishDialogueFieldNumber = 3;

		// Token: 0x0400352A RID: 13610
		private bool finishDialogue_;

		// Token: 0x0400352B RID: 13611
		public const int LCPMPOKHAEJFieldNumber = 14;

		// Token: 0x0400352C RID: 13612
		private uint lCPMPOKHAEJ_;

		// Token: 0x0400352D RID: 13613
		public const int NHJJKLBKCOJFieldNumber = 9;

		// Token: 0x0400352E RID: 13614
		private bool nHJJKLBKCOJ_;

		// Token: 0x0400352F RID: 13615
		public const int DialogueEventParamListFieldNumber = 5;

		// Token: 0x04003530 RID: 13616
		private static readonly FieldCodec<NpcDialogueEventParam> _repeated_dialogueEventParamList_codec = FieldCodec.ForMessage<NpcDialogueEventParam>(42U, NpcDialogueEventParam.Parser);

		// Token: 0x04003531 RID: 13617
		private readonly RepeatedField<NpcDialogueEventParam> dialogueEventParamList_ = new RepeatedField<NpcDialogueEventParam>();

		// Token: 0x04003532 RID: 13618
		public const int JEJCAFHFJFJFieldNumber = 15;

		// Token: 0x04003533 RID: 13619
		private bool jEJCAFHFJFJ_;

		// Token: 0x04003534 RID: 13620
		public const int TalkDialogueIdFieldNumber = 6;

		// Token: 0x04003535 RID: 13621
		private uint talkDialogueId_;

		// Token: 0x04003536 RID: 13622
		public const int EventUniqueIdFieldNumber = 12;

		// Token: 0x04003537 RID: 13623
		private uint eventUniqueId_;
	}
}
