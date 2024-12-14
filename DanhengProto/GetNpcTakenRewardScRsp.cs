using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000753 RID: 1875
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetNpcTakenRewardScRsp : IMessage<GetNpcTakenRewardScRsp>, IMessage, IEquatable<GetNpcTakenRewardScRsp>, IDeepCloneable<GetNpcTakenRewardScRsp>, IBufferMessage
	{
		// Token: 0x170017BD RID: 6077
		// (get) Token: 0x060053CE RID: 21454 RVA: 0x000E1991 File Offset: 0x000DFB91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetNpcTakenRewardScRsp> Parser
		{
			get
			{
				return GetNpcTakenRewardScRsp._parser;
			}
		}

		// Token: 0x170017BE RID: 6078
		// (get) Token: 0x060053CF RID: 21455 RVA: 0x000E1998 File Offset: 0x000DFB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetNpcTakenRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017BF RID: 6079
		// (get) Token: 0x060053D0 RID: 21456 RVA: 0x000E19AA File Offset: 0x000DFBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetNpcTakenRewardScRsp.Descriptor;
			}
		}

		// Token: 0x060053D1 RID: 21457 RVA: 0x000E19B1 File Offset: 0x000DFBB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcTakenRewardScRsp()
		{
		}

		// Token: 0x060053D2 RID: 21458 RVA: 0x000E19C4 File Offset: 0x000DFBC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcTakenRewardScRsp(GetNpcTakenRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.npcId_ = other.npcId_;
			this.talkEventList_ = other.talkEventList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053D3 RID: 21459 RVA: 0x000E1A11 File Offset: 0x000DFC11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetNpcTakenRewardScRsp Clone()
		{
			return new GetNpcTakenRewardScRsp(this);
		}

		// Token: 0x170017C0 RID: 6080
		// (get) Token: 0x060053D4 RID: 21460 RVA: 0x000E1A19 File Offset: 0x000DFC19
		// (set) Token: 0x060053D5 RID: 21461 RVA: 0x000E1A21 File Offset: 0x000DFC21
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

		// Token: 0x170017C1 RID: 6081
		// (get) Token: 0x060053D6 RID: 21462 RVA: 0x000E1A2A File Offset: 0x000DFC2A
		// (set) Token: 0x060053D7 RID: 21463 RVA: 0x000E1A32 File Offset: 0x000DFC32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NpcId
		{
			get
			{
				return this.npcId_;
			}
			set
			{
				this.npcId_ = value;
			}
		}

		// Token: 0x170017C2 RID: 6082
		// (get) Token: 0x060053D8 RID: 21464 RVA: 0x000E1A3B File Offset: 0x000DFC3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TalkEventList
		{
			get
			{
				return this.talkEventList_;
			}
		}

		// Token: 0x060053D9 RID: 21465 RVA: 0x000E1A43 File Offset: 0x000DFC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetNpcTakenRewardScRsp);
		}

		// Token: 0x060053DA RID: 21466 RVA: 0x000E1A54 File Offset: 0x000DFC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetNpcTakenRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.NpcId == other.NpcId && this.talkEventList_.Equals(other.talkEventList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x000E1AB4 File Offset: 0x000DFCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.NpcId != 0U)
			{
				num ^= this.NpcId.GetHashCode();
			}
			num ^= this.talkEventList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x000E1B1A File Offset: 0x000DFD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x000E1B22 File Offset: 0x000DFD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x000E1B2C File Offset: 0x000DFD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.NpcId);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.Retcode);
			}
			this.talkEventList_.WriteTo(ref output, GetNpcTakenRewardScRsp._repeated_talkEventList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x000E1B98 File Offset: 0x000DFD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.NpcId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NpcId);
			}
			num += this.talkEventList_.CalculateSize(GetNpcTakenRewardScRsp._repeated_talkEventList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060053E0 RID: 21472 RVA: 0x000E1C04 File Offset: 0x000DFE04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetNpcTakenRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.NpcId != 0U)
			{
				this.NpcId = other.NpcId;
			}
			this.talkEventList_.Add(other.talkEventList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060053E1 RID: 21473 RVA: 0x000E1C65 File Offset: 0x000DFE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053E2 RID: 21474 RVA: 0x000E1C70 File Offset: 0x000DFE70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 48U)
				{
					if (num == 24U)
					{
						this.NpcId = input.ReadUInt32();
						continue;
					}
					if (num == 48U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 88U || num == 90U)
				{
					this.talkEventList_.AddEntriesFrom(ref input, GetNpcTakenRewardScRsp._repeated_talkEventList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040020EE RID: 8430
		private static readonly MessageParser<GetNpcTakenRewardScRsp> _parser = new MessageParser<GetNpcTakenRewardScRsp>(() => new GetNpcTakenRewardScRsp());

		// Token: 0x040020EF RID: 8431
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020F0 RID: 8432
		public const int RetcodeFieldNumber = 6;

		// Token: 0x040020F1 RID: 8433
		private uint retcode_;

		// Token: 0x040020F2 RID: 8434
		public const int NpcIdFieldNumber = 3;

		// Token: 0x040020F3 RID: 8435
		private uint npcId_;

		// Token: 0x040020F4 RID: 8436
		public const int TalkEventListFieldNumber = 11;

		// Token: 0x040020F5 RID: 8437
		private static readonly FieldCodec<uint> _repeated_talkEventList_codec = FieldCodec.ForUInt32(90U);

		// Token: 0x040020F6 RID: 8438
		private readonly RepeatedField<uint> talkEventList_ = new RepeatedField<uint>();
	}
}
