using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C97 RID: 3223
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PickRogueAvatarCsReq : IMessage<PickRogueAvatarCsReq>, IMessage, IEquatable<PickRogueAvatarCsReq>, IDeepCloneable<PickRogueAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17002844 RID: 10308
		// (get) Token: 0x06008F51 RID: 36689 RVA: 0x0017AC21 File Offset: 0x00178E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PickRogueAvatarCsReq> Parser
		{
			get
			{
				return PickRogueAvatarCsReq._parser;
			}
		}

		// Token: 0x17002845 RID: 10309
		// (get) Token: 0x06008F52 RID: 36690 RVA: 0x0017AC28 File Offset: 0x00178E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PickRogueAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002846 RID: 10310
		// (get) Token: 0x06008F53 RID: 36691 RVA: 0x0017AC3A File Offset: 0x00178E3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PickRogueAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06008F54 RID: 36692 RVA: 0x0017AC41 File Offset: 0x00178E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickRogueAvatarCsReq()
		{
		}

		// Token: 0x06008F55 RID: 36693 RVA: 0x0017AC60 File Offset: 0x00178E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickRogueAvatarCsReq(PickRogueAvatarCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this.trialAvatarIdList_ = other.trialAvatarIdList_.Clone();
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F56 RID: 36694 RVA: 0x0017ACB2 File Offset: 0x00178EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PickRogueAvatarCsReq Clone()
		{
			return new PickRogueAvatarCsReq(this);
		}

		// Token: 0x17002847 RID: 10311
		// (get) Token: 0x06008F57 RID: 36695 RVA: 0x0017ACBA File Offset: 0x00178EBA
		// (set) Token: 0x06008F58 RID: 36696 RVA: 0x0017ACC2 File Offset: 0x00178EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x17002848 RID: 10312
		// (get) Token: 0x06008F59 RID: 36697 RVA: 0x0017ACCB File Offset: 0x00178ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> TrialAvatarIdList
		{
			get
			{
				return this.trialAvatarIdList_;
			}
		}

		// Token: 0x17002849 RID: 10313
		// (get) Token: 0x06008F5A RID: 36698 RVA: 0x0017ACD3 File Offset: 0x00178ED3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x0017ACDB File Offset: 0x00178EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PickRogueAvatarCsReq);
		}

		// Token: 0x06008F5C RID: 36700 RVA: 0x0017ACEC File Offset: 0x00178EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PickRogueAvatarCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && this.trialAvatarIdList_.Equals(other.trialAvatarIdList_) && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x0017AD50 File Offset: 0x00178F50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			num ^= this.trialAvatarIdList_.GetHashCode();
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x0017ADAB File Offset: 0x00178FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x0017ADB3 File Offset: 0x00178FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x0017ADBC File Offset: 0x00178FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialAvatarIdList_.WriteTo(ref output, PickRogueAvatarCsReq._repeated_trialAvatarIdList_codec);
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PropEntityId);
			}
			this.baseAvatarIdList_.WriteTo(ref output, PickRogueAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x0017AE1C File Offset: 0x0017901C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			num += this.trialAvatarIdList_.CalculateSize(PickRogueAvatarCsReq._repeated_trialAvatarIdList_codec);
			num += this.baseAvatarIdList_.CalculateSize(PickRogueAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x0017AE80 File Offset: 0x00179080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PickRogueAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this.trialAvatarIdList_.Add(other.trialAvatarIdList_);
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x0017AEDE File Offset: 0x001790DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x0017AEE8 File Offset: 0x001790E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.trialAvatarIdList_.AddEntriesFrom(ref input, PickRogueAvatarCsReq._repeated_trialAvatarIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PropEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 64U || num == 66U)
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, PickRogueAvatarCsReq._repeated_baseAvatarIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400370B RID: 14091
		private static readonly MessageParser<PickRogueAvatarCsReq> _parser = new MessageParser<PickRogueAvatarCsReq>(() => new PickRogueAvatarCsReq());

		// Token: 0x0400370C RID: 14092
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400370D RID: 14093
		public const int PropEntityIdFieldNumber = 3;

		// Token: 0x0400370E RID: 14094
		private uint propEntityId_;

		// Token: 0x0400370F RID: 14095
		public const int TrialAvatarIdListFieldNumber = 2;

		// Token: 0x04003710 RID: 14096
		private static readonly FieldCodec<uint> _repeated_trialAvatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04003711 RID: 14097
		private readonly RepeatedField<uint> trialAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04003712 RID: 14098
		public const int BaseAvatarIdListFieldNumber = 8;

		// Token: 0x04003713 RID: 14099
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04003714 RID: 14100
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();
	}
}
