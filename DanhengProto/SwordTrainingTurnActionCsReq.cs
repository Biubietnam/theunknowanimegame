using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001259 RID: 4697
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingTurnActionCsReq : IMessage<SwordTrainingTurnActionCsReq>, IMessage, IEquatable<SwordTrainingTurnActionCsReq>, IDeepCloneable<SwordTrainingTurnActionCsReq>, IBufferMessage
	{
		// Token: 0x17003B0D RID: 15117
		// (get) Token: 0x0600D1B9 RID: 53689 RVA: 0x00230CA5 File Offset: 0x0022EEA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingTurnActionCsReq> Parser
		{
			get
			{
				return SwordTrainingTurnActionCsReq._parser;
			}
		}

		// Token: 0x17003B0E RID: 15118
		// (get) Token: 0x0600D1BA RID: 53690 RVA: 0x00230CAC File Offset: 0x0022EEAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingTurnActionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B0F RID: 15119
		// (get) Token: 0x0600D1BB RID: 53691 RVA: 0x00230CBE File Offset: 0x0022EEBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingTurnActionCsReq.Descriptor;
			}
		}

		// Token: 0x0600D1BC RID: 53692 RVA: 0x00230CC5 File Offset: 0x0022EEC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingTurnActionCsReq()
		{
		}

		// Token: 0x0600D1BD RID: 53693 RVA: 0x00230CE3 File Offset: 0x0022EEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingTurnActionCsReq(SwordTrainingTurnActionCsReq other) : this()
		{
			this.mNDOHJNFNFB_ = other.mNDOHJNFNFB_.Clone();
			this.pMIIDGMPMFN_ = other.pMIIDGMPMFN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1BE RID: 53694 RVA: 0x00230D1E File Offset: 0x0022EF1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingTurnActionCsReq Clone()
		{
			return new SwordTrainingTurnActionCsReq(this);
		}

		// Token: 0x17003B10 RID: 15120
		// (get) Token: 0x0600D1BF RID: 53695 RVA: 0x00230D26 File Offset: 0x0022EF26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> MNDOHJNFNFB
		{
			get
			{
				return this.mNDOHJNFNFB_;
			}
		}

		// Token: 0x17003B11 RID: 15121
		// (get) Token: 0x0600D1C0 RID: 53696 RVA: 0x00230D2E File Offset: 0x0022EF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PMIIDGMPMFN
		{
			get
			{
				return this.pMIIDGMPMFN_;
			}
		}

		// Token: 0x0600D1C1 RID: 53697 RVA: 0x00230D36 File Offset: 0x0022EF36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingTurnActionCsReq);
		}

		// Token: 0x0600D1C2 RID: 53698 RVA: 0x00230D44 File Offset: 0x0022EF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingTurnActionCsReq other)
		{
			return other != null && (other == this || (this.mNDOHJNFNFB_.Equals(other.mNDOHJNFNFB_) && this.pMIIDGMPMFN_.Equals(other.pMIIDGMPMFN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1C3 RID: 53699 RVA: 0x00230D98 File Offset: 0x0022EF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.mNDOHJNFNFB_.GetHashCode();
			num ^= this.pMIIDGMPMFN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1C4 RID: 53700 RVA: 0x00230DDA File Offset: 0x0022EFDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D1C5 RID: 53701 RVA: 0x00230DE2 File Offset: 0x0022EFE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1C6 RID: 53702 RVA: 0x00230DEB File Offset: 0x0022EFEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pMIIDGMPMFN_.WriteTo(ref output, SwordTrainingTurnActionCsReq._repeated_pMIIDGMPMFN_codec);
			this.mNDOHJNFNFB_.WriteTo(ref output, SwordTrainingTurnActionCsReq._repeated_mNDOHJNFNFB_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1C7 RID: 53703 RVA: 0x00230E24 File Offset: 0x0022F024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.mNDOHJNFNFB_.CalculateSize(SwordTrainingTurnActionCsReq._repeated_mNDOHJNFNFB_codec);
			num += this.pMIIDGMPMFN_.CalculateSize(SwordTrainingTurnActionCsReq._repeated_pMIIDGMPMFN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1C8 RID: 53704 RVA: 0x00230E70 File Offset: 0x0022F070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingTurnActionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.mNDOHJNFNFB_.Add(other.mNDOHJNFNFB_);
			this.pMIIDGMPMFN_.Add(other.pMIIDGMPMFN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1C9 RID: 53705 RVA: 0x00230EAF File Offset: 0x0022F0AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1CA RID: 53706 RVA: 0x00230EB8 File Offset: 0x0022F0B8
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
						this.pMIIDGMPMFN_.AddEntriesFrom(ref input, SwordTrainingTurnActionCsReq._repeated_pMIIDGMPMFN_codec);
						continue;
					}
				}
				else if (num == 40U || num == 42U)
				{
					this.mNDOHJNFNFB_.AddEntriesFrom(ref input, SwordTrainingTurnActionCsReq._repeated_mNDOHJNFNFB_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400541C RID: 21532
		private static readonly MessageParser<SwordTrainingTurnActionCsReq> _parser = new MessageParser<SwordTrainingTurnActionCsReq>(() => new SwordTrainingTurnActionCsReq());

		// Token: 0x0400541D RID: 21533
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400541E RID: 21534
		public const int MNDOHJNFNFBFieldNumber = 5;

		// Token: 0x0400541F RID: 21535
		private static readonly FieldCodec<uint> _repeated_mNDOHJNFNFB_codec = FieldCodec.ForUInt32(42U);

		// Token: 0x04005420 RID: 21536
		private readonly RepeatedField<uint> mNDOHJNFNFB_ = new RepeatedField<uint>();

		// Token: 0x04005421 RID: 21537
		public const int PMIIDGMPMFNFieldNumber = 2;

		// Token: 0x04005422 RID: 21538
		private static readonly FieldCodec<uint> _repeated_pMIIDGMPMFN_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04005423 RID: 21539
		private readonly RepeatedField<uint> pMIIDGMPMFN_ = new RepeatedField<uint>();
	}
}
