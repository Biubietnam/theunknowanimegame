using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012FD RID: 4861
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeOfferingRewardCsReq : IMessage<TakeOfferingRewardCsReq>, IMessage, IEquatable<TakeOfferingRewardCsReq>, IDeepCloneable<TakeOfferingRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003CF4 RID: 15604
		// (get) Token: 0x0600D8E0 RID: 55520 RVA: 0x002421ED File Offset: 0x002403ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeOfferingRewardCsReq> Parser
		{
			get
			{
				return TakeOfferingRewardCsReq._parser;
			}
		}

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x0600D8E1 RID: 55521 RVA: 0x002421F4 File Offset: 0x002403F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeOfferingRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x0600D8E2 RID: 55522 RVA: 0x00242206 File Offset: 0x00240406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeOfferingRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x0024220D File Offset: 0x0024040D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOfferingRewardCsReq()
		{
		}

		// Token: 0x0600D8E4 RID: 55524 RVA: 0x00242220 File Offset: 0x00240420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOfferingRewardCsReq(TakeOfferingRewardCsReq other) : this()
		{
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this.kMIPGFOKNMM_ = other.kMIPGFOKNMM_.Clone();
			this.bGKKLJMJGOF_ = other.bGKKLJMJGOF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D8E5 RID: 55525 RVA: 0x0024226D File Offset: 0x0024046D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeOfferingRewardCsReq Clone()
		{
			return new TakeOfferingRewardCsReq(this);
		}

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x0600D8E6 RID: 55526 RVA: 0x00242275 File Offset: 0x00240475
		// (set) Token: 0x0600D8E7 RID: 55527 RVA: 0x0024227D File Offset: 0x0024047D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x17003CF8 RID: 15608
		// (get) Token: 0x0600D8E8 RID: 55528 RVA: 0x00242286 File Offset: 0x00240486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KMIPGFOKNMM
		{
			get
			{
				return this.kMIPGFOKNMM_;
			}
		}

		// Token: 0x17003CF9 RID: 15609
		// (get) Token: 0x0600D8E9 RID: 55529 RVA: 0x0024228E File Offset: 0x0024048E
		// (set) Token: 0x0600D8EA RID: 55530 RVA: 0x00242296 File Offset: 0x00240496
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BGKKLJMJGOF
		{
			get
			{
				return this.bGKKLJMJGOF_;
			}
			set
			{
				this.bGKKLJMJGOF_ = value;
			}
		}

		// Token: 0x0600D8EB RID: 55531 RVA: 0x0024229F File Offset: 0x0024049F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeOfferingRewardCsReq);
		}

		// Token: 0x0600D8EC RID: 55532 RVA: 0x002422B0 File Offset: 0x002404B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeOfferingRewardCsReq other)
		{
			return other != null && (other == this || (this.InteractedPropEntityId == other.InteractedPropEntityId && this.kMIPGFOKNMM_.Equals(other.kMIPGFOKNMM_) && this.BGKKLJMJGOF == other.BGKKLJMJGOF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D8ED RID: 55533 RVA: 0x00242310 File Offset: 0x00240510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			num ^= this.kMIPGFOKNMM_.GetHashCode();
			if (this.BGKKLJMJGOF != 0U)
			{
				num ^= this.BGKKLJMJGOF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x00242376 File Offset: 0x00240576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D8EF RID: 55535 RVA: 0x0024237E File Offset: 0x0024057E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D8F0 RID: 55536 RVA: 0x00242388 File Offset: 0x00240588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			if (this.BGKKLJMJGOF != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.BGKKLJMJGOF);
			}
			this.kMIPGFOKNMM_.WriteTo(ref output, TakeOfferingRewardCsReq._repeated_kMIPGFOKNMM_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D8F1 RID: 55537 RVA: 0x002423F4 File Offset: 0x002405F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			num += this.kMIPGFOKNMM_.CalculateSize(TakeOfferingRewardCsReq._repeated_kMIPGFOKNMM_codec);
			if (this.BGKKLJMJGOF != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BGKKLJMJGOF);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D8F2 RID: 55538 RVA: 0x00242460 File Offset: 0x00240660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeOfferingRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this.kMIPGFOKNMM_.Add(other.kMIPGFOKNMM_);
			if (other.BGKKLJMJGOF != 0U)
			{
				this.BGKKLJMJGOF = other.BGKKLJMJGOF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D8F3 RID: 55539 RVA: 0x002424C1 File Offset: 0x002406C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D8F4 RID: 55540 RVA: 0x002424CC File Offset: 0x002406CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 96U)
				{
					if (num == 16U)
					{
						this.InteractedPropEntityId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.BGKKLJMJGOF = input.ReadUInt32();
						continue;
					}
				}
				else if (num == 112U || num == 114U)
				{
					this.kMIPGFOKNMM_.AddEntriesFrom(ref input, TakeOfferingRewardCsReq._repeated_kMIPGFOKNMM_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400567C RID: 22140
		private static readonly MessageParser<TakeOfferingRewardCsReq> _parser = new MessageParser<TakeOfferingRewardCsReq>(() => new TakeOfferingRewardCsReq());

		// Token: 0x0400567D RID: 22141
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400567E RID: 22142
		public const int InteractedPropEntityIdFieldNumber = 2;

		// Token: 0x0400567F RID: 22143
		private uint interactedPropEntityId_;

		// Token: 0x04005680 RID: 22144
		public const int KMIPGFOKNMMFieldNumber = 14;

		// Token: 0x04005681 RID: 22145
		private static readonly FieldCodec<uint> _repeated_kMIPGFOKNMM_codec = FieldCodec.ForUInt32(114U);

		// Token: 0x04005682 RID: 22146
		private readonly RepeatedField<uint> kMIPGFOKNMM_ = new RepeatedField<uint>();

		// Token: 0x04005683 RID: 22147
		public const int BGKKLJMJGOFFieldNumber = 12;

		// Token: 0x04005684 RID: 22148
		private uint bGKKLJMJGOF_;
	}
}
