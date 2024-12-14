using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A9 RID: 4777
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncTurnFoodNotify : IMessage<SyncTurnFoodNotify>, IMessage, IEquatable<SyncTurnFoodNotify>, IDeepCloneable<SyncTurnFoodNotify>, IBufferMessage
	{
		// Token: 0x17003BEE RID: 15342
		// (get) Token: 0x0600D516 RID: 54550 RVA: 0x00238C71 File Offset: 0x00236E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncTurnFoodNotify> Parser
		{
			get
			{
				return SyncTurnFoodNotify._parser;
			}
		}

		// Token: 0x17003BEF RID: 15343
		// (get) Token: 0x0600D517 RID: 54551 RVA: 0x00238C78 File Offset: 0x00236E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncTurnFoodNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BF0 RID: 15344
		// (get) Token: 0x0600D518 RID: 54552 RVA: 0x00238C8A File Offset: 0x00236E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncTurnFoodNotify.Descriptor;
			}
		}

		// Token: 0x0600D519 RID: 54553 RVA: 0x00238C91 File Offset: 0x00236E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTurnFoodNotify()
		{
		}

		// Token: 0x0600D51A RID: 54554 RVA: 0x00238CAF File Offset: 0x00236EAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTurnFoodNotify(SyncTurnFoodNotify other) : this()
		{
			this.iBLPHOPOEOK_ = other.iBLPHOPOEOK_.Clone();
			this.dHDJIIOIPKH_ = other.dHDJIIOIPKH_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D51B RID: 54555 RVA: 0x00238CEA File Offset: 0x00236EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncTurnFoodNotify Clone()
		{
			return new SyncTurnFoodNotify(this);
		}

		// Token: 0x17003BF1 RID: 15345
		// (get) Token: 0x0600D51C RID: 54556 RVA: 0x00238CF2 File Offset: 0x00236EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TurnFoodSwitch> IBLPHOPOEOK
		{
			get
			{
				return this.iBLPHOPOEOK_;
			}
		}

		// Token: 0x17003BF2 RID: 15346
		// (get) Token: 0x0600D51D RID: 54557 RVA: 0x00238CFA File Offset: 0x00236EFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DHDJIIOIPKH
		{
			get
			{
				return this.dHDJIIOIPKH_;
			}
		}

		// Token: 0x0600D51E RID: 54558 RVA: 0x00238D02 File Offset: 0x00236F02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncTurnFoodNotify);
		}

		// Token: 0x0600D51F RID: 54559 RVA: 0x00238D10 File Offset: 0x00236F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncTurnFoodNotify other)
		{
			return other != null && (other == this || (this.iBLPHOPOEOK_.Equals(other.iBLPHOPOEOK_) && this.dHDJIIOIPKH_.Equals(other.dHDJIIOIPKH_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D520 RID: 54560 RVA: 0x00238D64 File Offset: 0x00236F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.iBLPHOPOEOK_.GetHashCode();
			num ^= this.dHDJIIOIPKH_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D521 RID: 54561 RVA: 0x00238DA6 File Offset: 0x00236FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D522 RID: 54562 RVA: 0x00238DAE File Offset: 0x00236FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D523 RID: 54563 RVA: 0x00238DB7 File Offset: 0x00236FB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.iBLPHOPOEOK_.WriteTo(ref output, SyncTurnFoodNotify._repeated_iBLPHOPOEOK_codec);
			this.dHDJIIOIPKH_.WriteTo(ref output, SyncTurnFoodNotify._repeated_dHDJIIOIPKH_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D524 RID: 54564 RVA: 0x00238DF0 File Offset: 0x00236FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.iBLPHOPOEOK_.CalculateSize(SyncTurnFoodNotify._repeated_iBLPHOPOEOK_codec);
			num += this.dHDJIIOIPKH_.CalculateSize(SyncTurnFoodNotify._repeated_dHDJIIOIPKH_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D525 RID: 54565 RVA: 0x00238E3C File Offset: 0x0023703C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncTurnFoodNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.iBLPHOPOEOK_.Add(other.iBLPHOPOEOK_);
			this.dHDJIIOIPKH_.Add(other.dHDJIIOIPKH_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D526 RID: 54566 RVA: 0x00238E7B File Offset: 0x0023707B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D527 RID: 54567 RVA: 0x00238E84 File Offset: 0x00237084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 42U)
				{
					if (num == 40U || num == 42U)
					{
						this.iBLPHOPOEOK_.AddEntriesFrom(ref input, SyncTurnFoodNotify._repeated_iBLPHOPOEOK_codec);
						continue;
					}
				}
				else if (num == 80U || num == 82U)
				{
					this.dHDJIIOIPKH_.AddEntriesFrom(ref input, SyncTurnFoodNotify._repeated_dHDJIIOIPKH_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005532 RID: 21810
		private static readonly MessageParser<SyncTurnFoodNotify> _parser = new MessageParser<SyncTurnFoodNotify>(() => new SyncTurnFoodNotify());

		// Token: 0x04005533 RID: 21811
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005534 RID: 21812
		public const int IBLPHOPOEOKFieldNumber = 5;

		// Token: 0x04005535 RID: 21813
		private static readonly FieldCodec<TurnFoodSwitch> _repeated_iBLPHOPOEOK_codec = FieldCodec.ForEnum<TurnFoodSwitch>(42U, (TurnFoodSwitch x) => (int)x, (int x) => (TurnFoodSwitch)x);

		// Token: 0x04005536 RID: 21814
		private readonly RepeatedField<TurnFoodSwitch> iBLPHOPOEOK_ = new RepeatedField<TurnFoodSwitch>();

		// Token: 0x04005537 RID: 21815
		public const int DHDJIIOIPKHFieldNumber = 10;

		// Token: 0x04005538 RID: 21816
		private static readonly FieldCodec<uint> _repeated_dHDJIIOIPKH_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04005539 RID: 21817
		private readonly RepeatedField<uint> dHDJIIOIPKH_ = new RepeatedField<uint>();
	}
}
