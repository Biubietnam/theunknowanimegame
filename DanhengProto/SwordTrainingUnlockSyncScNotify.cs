using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200125D RID: 4701
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingUnlockSyncScNotify : IMessage<SwordTrainingUnlockSyncScNotify>, IMessage, IEquatable<SwordTrainingUnlockSyncScNotify>, IDeepCloneable<SwordTrainingUnlockSyncScNotify>, IBufferMessage
	{
		// Token: 0x17003B19 RID: 15129
		// (get) Token: 0x0600D1E4 RID: 53732 RVA: 0x00231347 File Offset: 0x0022F547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingUnlockSyncScNotify> Parser
		{
			get
			{
				return SwordTrainingUnlockSyncScNotify._parser;
			}
		}

		// Token: 0x17003B1A RID: 15130
		// (get) Token: 0x0600D1E5 RID: 53733 RVA: 0x0023134E File Offset: 0x0022F54E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingUnlockSyncScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B1B RID: 15131
		// (get) Token: 0x0600D1E6 RID: 53734 RVA: 0x00231360 File Offset: 0x0022F560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingUnlockSyncScNotify.Descriptor;
			}
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x00231367 File Offset: 0x0022F567
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingUnlockSyncScNotify()
		{
		}

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x00231385 File Offset: 0x0022F585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingUnlockSyncScNotify(SwordTrainingUnlockSyncScNotify other) : this()
		{
			this.jKOFJPMDELK_ = other.jKOFJPMDELK_.Clone();
			this.nFIBKMMKNEE_ = other.nFIBKMMKNEE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x002313C0 File Offset: 0x0022F5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingUnlockSyncScNotify Clone()
		{
			return new SwordTrainingUnlockSyncScNotify(this);
		}

		// Token: 0x17003B1C RID: 15132
		// (get) Token: 0x0600D1EA RID: 53738 RVA: 0x002313C8 File Offset: 0x0022F5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HCMJAJFPCKO> JKOFJPMDELK
		{
			get
			{
				return this.jKOFJPMDELK_;
			}
		}

		// Token: 0x17003B1D RID: 15133
		// (get) Token: 0x0600D1EB RID: 53739 RVA: 0x002313D0 File Offset: 0x0022F5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> NFIBKMMKNEE
		{
			get
			{
				return this.nFIBKMMKNEE_;
			}
		}

		// Token: 0x0600D1EC RID: 53740 RVA: 0x002313D8 File Offset: 0x0022F5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingUnlockSyncScNotify);
		}

		// Token: 0x0600D1ED RID: 53741 RVA: 0x002313E8 File Offset: 0x0022F5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingUnlockSyncScNotify other)
		{
			return other != null && (other == this || (this.jKOFJPMDELK_.Equals(other.jKOFJPMDELK_) && this.nFIBKMMKNEE_.Equals(other.nFIBKMMKNEE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1EE RID: 53742 RVA: 0x0023143C File Offset: 0x0022F63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jKOFJPMDELK_.GetHashCode();
			num ^= this.nFIBKMMKNEE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x0023147E File Offset: 0x0022F67E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x00231486 File Offset: 0x0022F686
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1F1 RID: 53745 RVA: 0x0023148F File Offset: 0x0022F68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jKOFJPMDELK_.WriteTo(ref output, SwordTrainingUnlockSyncScNotify._repeated_jKOFJPMDELK_codec);
			this.nFIBKMMKNEE_.WriteTo(ref output, SwordTrainingUnlockSyncScNotify._repeated_nFIBKMMKNEE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x002314C8 File Offset: 0x0022F6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jKOFJPMDELK_.CalculateSize(SwordTrainingUnlockSyncScNotify._repeated_jKOFJPMDELK_codec);
			num += this.nFIBKMMKNEE_.CalculateSize(SwordTrainingUnlockSyncScNotify._repeated_nFIBKMMKNEE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1F3 RID: 53747 RVA: 0x00231514 File Offset: 0x0022F714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingUnlockSyncScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.jKOFJPMDELK_.Add(other.jKOFJPMDELK_);
			this.nFIBKMMKNEE_.Add(other.nFIBKMMKNEE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1F4 RID: 53748 RVA: 0x00231553 File Offset: 0x0022F753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1F5 RID: 53749 RVA: 0x0023155C File Offset: 0x0022F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.nFIBKMMKNEE_.AddEntriesFrom(ref input, SwordTrainingUnlockSyncScNotify._repeated_nFIBKMMKNEE_codec);
					}
				}
				else
				{
					this.jKOFJPMDELK_.AddEntriesFrom(ref input, SwordTrainingUnlockSyncScNotify._repeated_jKOFJPMDELK_codec);
				}
			}
		}

		// Token: 0x0400542D RID: 21549
		private static readonly MessageParser<SwordTrainingUnlockSyncScNotify> _parser = new MessageParser<SwordTrainingUnlockSyncScNotify>(() => new SwordTrainingUnlockSyncScNotify());

		// Token: 0x0400542E RID: 21550
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400542F RID: 21551
		public const int JKOFJPMDELKFieldNumber = 10;

		// Token: 0x04005430 RID: 21552
		private static readonly FieldCodec<HCMJAJFPCKO> _repeated_jKOFJPMDELK_codec = FieldCodec.ForMessage<HCMJAJFPCKO>(82U, HCMJAJFPCKO.Parser);

		// Token: 0x04005431 RID: 21553
		private readonly RepeatedField<HCMJAJFPCKO> jKOFJPMDELK_ = new RepeatedField<HCMJAJFPCKO>();

		// Token: 0x04005432 RID: 21554
		public const int NFIBKMMKNEEFieldNumber = 15;

		// Token: 0x04005433 RID: 21555
		private static readonly FieldCodec<uint> _repeated_nFIBKMMKNEE_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04005434 RID: 21556
		private readonly RepeatedField<uint> nFIBKMMKNEE_ = new RepeatedField<uint>();
	}
}
