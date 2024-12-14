using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001189 RID: 4489
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StaminaInfoScNotify : IMessage<StaminaInfoScNotify>, IMessage, IEquatable<StaminaInfoScNotify>, IDeepCloneable<StaminaInfoScNotify>, IBufferMessage
	{
		// Token: 0x17003882 RID: 14466
		// (get) Token: 0x0600C85A RID: 51290 RVA: 0x002198B5 File Offset: 0x00217AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StaminaInfoScNotify> Parser
		{
			get
			{
				return StaminaInfoScNotify._parser;
			}
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600C85B RID: 51291 RVA: 0x002198BC File Offset: 0x00217ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StaminaInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600C85C RID: 51292 RVA: 0x002198CE File Offset: 0x00217ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StaminaInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600C85D RID: 51293 RVA: 0x002198D5 File Offset: 0x00217AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StaminaInfoScNotify()
		{
		}

		// Token: 0x0600C85E RID: 51294 RVA: 0x002198E0 File Offset: 0x00217AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StaminaInfoScNotify(StaminaInfoScNotify other) : this()
		{
			this.lNBLCOHNANF_ = other.lNBLCOHNANF_;
			this.nextRecoverTime_ = other.nextRecoverTime_;
			this.stamina_ = other.stamina_;
			this.reserveStamina_ = other.reserveStamina_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C85F RID: 51295 RVA: 0x00219934 File Offset: 0x00217B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StaminaInfoScNotify Clone()
		{
			return new StaminaInfoScNotify(this);
		}

		// Token: 0x17003885 RID: 14469
		// (get) Token: 0x0600C860 RID: 51296 RVA: 0x0021993C File Offset: 0x00217B3C
		// (set) Token: 0x0600C861 RID: 51297 RVA: 0x00219944 File Offset: 0x00217B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LNBLCOHNANF
		{
			get
			{
				return this.lNBLCOHNANF_;
			}
			set
			{
				this.lNBLCOHNANF_ = value;
			}
		}

		// Token: 0x17003886 RID: 14470
		// (get) Token: 0x0600C862 RID: 51298 RVA: 0x0021994D File Offset: 0x00217B4D
		// (set) Token: 0x0600C863 RID: 51299 RVA: 0x00219955 File Offset: 0x00217B55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NextRecoverTime
		{
			get
			{
				return this.nextRecoverTime_;
			}
			set
			{
				this.nextRecoverTime_ = value;
			}
		}

		// Token: 0x17003887 RID: 14471
		// (get) Token: 0x0600C864 RID: 51300 RVA: 0x0021995E File Offset: 0x00217B5E
		// (set) Token: 0x0600C865 RID: 51301 RVA: 0x00219966 File Offset: 0x00217B66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Stamina
		{
			get
			{
				return this.stamina_;
			}
			set
			{
				this.stamina_ = value;
			}
		}

		// Token: 0x17003888 RID: 14472
		// (get) Token: 0x0600C866 RID: 51302 RVA: 0x0021996F File Offset: 0x00217B6F
		// (set) Token: 0x0600C867 RID: 51303 RVA: 0x00219977 File Offset: 0x00217B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ReserveStamina
		{
			get
			{
				return this.reserveStamina_;
			}
			set
			{
				this.reserveStamina_ = value;
			}
		}

		// Token: 0x0600C868 RID: 51304 RVA: 0x00219980 File Offset: 0x00217B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StaminaInfoScNotify);
		}

		// Token: 0x0600C869 RID: 51305 RVA: 0x00219990 File Offset: 0x00217B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StaminaInfoScNotify other)
		{
			return other != null && (other == this || (this.LNBLCOHNANF == other.LNBLCOHNANF && this.NextRecoverTime == other.NextRecoverTime && this.Stamina == other.Stamina && this.ReserveStamina == other.ReserveStamina && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C86A RID: 51306 RVA: 0x002199FC File Offset: 0x00217BFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LNBLCOHNANF != 0L)
			{
				num ^= this.LNBLCOHNANF.GetHashCode();
			}
			if (this.NextRecoverTime != 0L)
			{
				num ^= this.NextRecoverTime.GetHashCode();
			}
			if (this.Stamina != 0U)
			{
				num ^= this.Stamina.GetHashCode();
			}
			if (this.ReserveStamina != 0U)
			{
				num ^= this.ReserveStamina.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C86B RID: 51307 RVA: 0x00219A86 File Offset: 0x00217C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C86C RID: 51308 RVA: 0x00219A8E File Offset: 0x00217C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C86D RID: 51309 RVA: 0x00219A98 File Offset: 0x00217C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NextRecoverTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.NextRecoverTime);
			}
			if (this.LNBLCOHNANF != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.LNBLCOHNANF);
			}
			if (this.ReserveStamina != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.ReserveStamina);
			}
			if (this.Stamina != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Stamina);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C86E RID: 51310 RVA: 0x00219B2C File Offset: 0x00217D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LNBLCOHNANF != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LNBLCOHNANF);
			}
			if (this.NextRecoverTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NextRecoverTime);
			}
			if (this.Stamina != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Stamina);
			}
			if (this.ReserveStamina != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ReserveStamina);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C86F RID: 51311 RVA: 0x00219BB4 File Offset: 0x00217DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StaminaInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LNBLCOHNANF != 0L)
			{
				this.LNBLCOHNANF = other.LNBLCOHNANF;
			}
			if (other.NextRecoverTime != 0L)
			{
				this.NextRecoverTime = other.NextRecoverTime;
			}
			if (other.Stamina != 0U)
			{
				this.Stamina = other.Stamina;
			}
			if (other.ReserveStamina != 0U)
			{
				this.ReserveStamina = other.ReserveStamina;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C870 RID: 51312 RVA: 0x00219C2C File Offset: 0x00217E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C871 RID: 51313 RVA: 0x00219C38 File Offset: 0x00217E38
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
						this.NextRecoverTime = input.ReadInt64();
						continue;
					}
					if (num == 48U)
					{
						this.LNBLCOHNANF = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.ReserveStamina = input.ReadUInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Stamina = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040050E2 RID: 20706
		private static readonly MessageParser<StaminaInfoScNotify> _parser = new MessageParser<StaminaInfoScNotify>(() => new StaminaInfoScNotify());

		// Token: 0x040050E3 RID: 20707
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050E4 RID: 20708
		public const int LNBLCOHNANFFieldNumber = 6;

		// Token: 0x040050E5 RID: 20709
		private long lNBLCOHNANF_;

		// Token: 0x040050E6 RID: 20710
		public const int NextRecoverTimeFieldNumber = 3;

		// Token: 0x040050E7 RID: 20711
		private long nextRecoverTime_;

		// Token: 0x040050E8 RID: 20712
		public const int StaminaFieldNumber = 15;

		// Token: 0x040050E9 RID: 20713
		private uint stamina_;

		// Token: 0x040050EA RID: 20714
		public const int ReserveStaminaFieldNumber = 8;

		// Token: 0x040050EB RID: 20715
		private uint reserveStamina_;
	}
}
