using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B79 RID: 2937
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolySelectOptionScRsp : IMessage<MonopolySelectOptionScRsp>, IMessage, IEquatable<MonopolySelectOptionScRsp>, IDeepCloneable<MonopolySelectOptionScRsp>, IBufferMessage
	{
		// Token: 0x17002464 RID: 9316
		// (get) Token: 0x060081F8 RID: 33272 RVA: 0x00156563 File Offset: 0x00154763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolySelectOptionScRsp> Parser
		{
			get
			{
				return MonopolySelectOptionScRsp._parser;
			}
		}

		// Token: 0x17002465 RID: 9317
		// (get) Token: 0x060081F9 RID: 33273 RVA: 0x0015656A File Offset: 0x0015476A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolySelectOptionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002466 RID: 9318
		// (get) Token: 0x060081FA RID: 33274 RVA: 0x0015657C File Offset: 0x0015477C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolySelectOptionScRsp.Descriptor;
			}
		}

		// Token: 0x060081FB RID: 33275 RVA: 0x00156583 File Offset: 0x00154783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySelectOptionScRsp()
		{
		}

		// Token: 0x060081FC RID: 33276 RVA: 0x00156598 File Offset: 0x00154798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySelectOptionScRsp(MonopolySelectOptionScRsp other) : this()
		{
			this.optionId_ = other.optionId_;
			this.kLNPKPIMKHJ_ = ((other.kLNPKPIMKHJ_ != null) ? other.kLNPKPIMKHJ_.Clone() : null);
			this.pHAKIBBELNK_ = other.pHAKIBBELNK_.Clone();
			this.retcode_ = other.retcode_;
			this.eventId_ = other.eventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x0015660D File Offset: 0x0015480D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolySelectOptionScRsp Clone()
		{
			return new MonopolySelectOptionScRsp(this);
		}

		// Token: 0x17002467 RID: 9319
		// (get) Token: 0x060081FE RID: 33278 RVA: 0x00156615 File Offset: 0x00154815
		// (set) Token: 0x060081FF RID: 33279 RVA: 0x0015661D File Offset: 0x0015481D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint OptionId
		{
			get
			{
				return this.optionId_;
			}
			set
			{
				this.optionId_ = value;
			}
		}

		// Token: 0x17002468 RID: 9320
		// (get) Token: 0x06008200 RID: 33280 RVA: 0x00156626 File Offset: 0x00154826
		// (set) Token: 0x06008201 RID: 33281 RVA: 0x0015662E File Offset: 0x0015482E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NFOGHDHIDNH KLNPKPIMKHJ
		{
			get
			{
				return this.kLNPKPIMKHJ_;
			}
			set
			{
				this.kLNPKPIMKHJ_ = value;
			}
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x06008202 RID: 33282 RVA: 0x00156637 File Offset: 0x00154837
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GODFNMFIENL> PHAKIBBELNK
		{
			get
			{
				return this.pHAKIBBELNK_;
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x06008203 RID: 33283 RVA: 0x0015663F File Offset: 0x0015483F
		// (set) Token: 0x06008204 RID: 33284 RVA: 0x00156647 File Offset: 0x00154847
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

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x06008205 RID: 33285 RVA: 0x00156650 File Offset: 0x00154850
		// (set) Token: 0x06008206 RID: 33286 RVA: 0x00156658 File Offset: 0x00154858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EventId
		{
			get
			{
				return this.eventId_;
			}
			set
			{
				this.eventId_ = value;
			}
		}

		// Token: 0x06008207 RID: 33287 RVA: 0x00156661 File Offset: 0x00154861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolySelectOptionScRsp);
		}

		// Token: 0x06008208 RID: 33288 RVA: 0x00156670 File Offset: 0x00154870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolySelectOptionScRsp other)
		{
			return other != null && (other == this || (this.OptionId == other.OptionId && object.Equals(this.KLNPKPIMKHJ, other.KLNPKPIMKHJ) && this.pHAKIBBELNK_.Equals(other.pHAKIBBELNK_) && this.Retcode == other.Retcode && this.EventId == other.EventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008209 RID: 33289 RVA: 0x001566F4 File Offset: 0x001548F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OptionId != 0U)
			{
				num ^= this.OptionId.GetHashCode();
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num ^= this.KLNPKPIMKHJ.GetHashCode();
			}
			num ^= this.pHAKIBBELNK_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.EventId != 0U)
			{
				num ^= this.EventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600820A RID: 33290 RVA: 0x00156789 File Offset: 0x00154989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600820B RID: 33291 RVA: 0x00156791 File Offset: 0x00154991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600820C RID: 33292 RVA: 0x0015679C File Offset: 0x0015499C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pHAKIBBELNK_.WriteTo(ref output, MonopolySelectOptionScRsp._repeated_pHAKIBBELNK_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.EventId);
			}
			if (this.OptionId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.OptionId);
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.KLNPKPIMKHJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600820D RID: 33293 RVA: 0x00156840 File Offset: 0x00154A40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OptionId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.OptionId);
			}
			if (this.kLNPKPIMKHJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KLNPKPIMKHJ);
			}
			num += this.pHAKIBBELNK_.CalculateSize(MonopolySelectOptionScRsp._repeated_pHAKIBBELNK_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.EventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600820E RID: 33294 RVA: 0x001568DC File Offset: 0x00154ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolySelectOptionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OptionId != 0U)
			{
				this.OptionId = other.OptionId;
			}
			if (other.kLNPKPIMKHJ_ != null)
			{
				if (this.kLNPKPIMKHJ_ == null)
				{
					this.KLNPKPIMKHJ = new NFOGHDHIDNH();
				}
				this.KLNPKPIMKHJ.MergeFrom(other.KLNPKPIMKHJ);
			}
			this.pHAKIBBELNK_.Add(other.pHAKIBBELNK_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.EventId != 0U)
			{
				this.EventId = other.EventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x0015697D File Offset: 0x00154B7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x00156988 File Offset: 0x00154B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 10U)
					{
						this.pHAKIBBELNK_.AddEntriesFrom(ref input, MonopolySelectOptionScRsp._repeated_pHAKIBBELNK_codec);
						continue;
					}
					if (num == 40U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.EventId = input.ReadUInt32();
						continue;
					}
					if (num == 80U)
					{
						this.OptionId = input.ReadUInt32();
						continue;
					}
					if (num == 90U)
					{
						if (this.kLNPKPIMKHJ_ == null)
						{
							this.KLNPKPIMKHJ = new NFOGHDHIDNH();
						}
						input.ReadMessage(this.KLNPKPIMKHJ);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003191 RID: 12689
		private static readonly MessageParser<MonopolySelectOptionScRsp> _parser = new MessageParser<MonopolySelectOptionScRsp>(() => new MonopolySelectOptionScRsp());

		// Token: 0x04003192 RID: 12690
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003193 RID: 12691
		public const int OptionIdFieldNumber = 10;

		// Token: 0x04003194 RID: 12692
		private uint optionId_;

		// Token: 0x04003195 RID: 12693
		public const int KLNPKPIMKHJFieldNumber = 11;

		// Token: 0x04003196 RID: 12694
		private NFOGHDHIDNH kLNPKPIMKHJ_;

		// Token: 0x04003197 RID: 12695
		public const int PHAKIBBELNKFieldNumber = 1;

		// Token: 0x04003198 RID: 12696
		private static readonly FieldCodec<GODFNMFIENL> _repeated_pHAKIBBELNK_codec = FieldCodec.ForMessage<GODFNMFIENL>(10U, GODFNMFIENL.Parser);

		// Token: 0x04003199 RID: 12697
		private readonly RepeatedField<GODFNMFIENL> pHAKIBBELNK_ = new RepeatedField<GODFNMFIENL>();

		// Token: 0x0400319A RID: 12698
		public const int RetcodeFieldNumber = 5;

		// Token: 0x0400319B RID: 12699
		private uint retcode_;

		// Token: 0x0400319C RID: 12700
		public const int EventIdFieldNumber = 6;

		// Token: 0x0400319D RID: 12701
		private uint eventId_;
	}
}
