using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D01 RID: 3329
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PrivacySettings : IMessage<PrivacySettings>, IMessage, IEquatable<PrivacySettings>, IDeepCloneable<PrivacySettings>, IBufferMessage
	{
		// Token: 0x170029EB RID: 10731
		// (get) Token: 0x060094B2 RID: 38066 RVA: 0x0018B463 File Offset: 0x00189663
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PrivacySettings> Parser
		{
			get
			{
				return PrivacySettings._parser;
			}
		}

		// Token: 0x170029EC RID: 10732
		// (get) Token: 0x060094B3 RID: 38067 RVA: 0x0018B46A File Offset: 0x0018966A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PrivacySettingsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170029ED RID: 10733
		// (get) Token: 0x060094B4 RID: 38068 RVA: 0x0018B47C File Offset: 0x0018967C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PrivacySettings.Descriptor;
			}
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x0018B483 File Offset: 0x00189683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivacySettings()
		{
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x0018B48C File Offset: 0x0018968C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivacySettings(PrivacySettings other) : this()
		{
			this.pJILEMMBLFG_ = other.pJILEMMBLFG_;
			this.nMJDBOIPFIC_ = other.nMJDBOIPFIC_;
			this.nENGEIIJJCB_ = other.nENGEIIJJCB_;
			this.cPEEEPDBBPH_ = other.cPEEEPDBBPH_;
			this.gNOHNPJBFJC_ = other.gNOHNPJBFJC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x0018B4EC File Offset: 0x001896EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PrivacySettings Clone()
		{
			return new PrivacySettings(this);
		}

		// Token: 0x170029EE RID: 10734
		// (get) Token: 0x060094B8 RID: 38072 RVA: 0x0018B4F4 File Offset: 0x001896F4
		// (set) Token: 0x060094B9 RID: 38073 RVA: 0x0018B4FC File Offset: 0x001896FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PJILEMMBLFG
		{
			get
			{
				return this.pJILEMMBLFG_;
			}
			set
			{
				this.pJILEMMBLFG_ = value;
			}
		}

		// Token: 0x170029EF RID: 10735
		// (get) Token: 0x060094BA RID: 38074 RVA: 0x0018B505 File Offset: 0x00189705
		// (set) Token: 0x060094BB RID: 38075 RVA: 0x0018B50D File Offset: 0x0018970D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NMJDBOIPFIC
		{
			get
			{
				return this.nMJDBOIPFIC_;
			}
			set
			{
				this.nMJDBOIPFIC_ = value;
			}
		}

		// Token: 0x170029F0 RID: 10736
		// (get) Token: 0x060094BC RID: 38076 RVA: 0x0018B516 File Offset: 0x00189716
		// (set) Token: 0x060094BD RID: 38077 RVA: 0x0018B51E File Offset: 0x0018971E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NENGEIIJJCB
		{
			get
			{
				return this.nENGEIIJJCB_;
			}
			set
			{
				this.nENGEIIJJCB_ = value;
			}
		}

		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x060094BE RID: 38078 RVA: 0x0018B527 File Offset: 0x00189727
		// (set) Token: 0x060094BF RID: 38079 RVA: 0x0018B52F File Offset: 0x0018972F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool CPEEEPDBBPH
		{
			get
			{
				return this.cPEEEPDBBPH_;
			}
			set
			{
				this.cPEEEPDBBPH_ = value;
			}
		}

		// Token: 0x170029F2 RID: 10738
		// (get) Token: 0x060094C0 RID: 38080 RVA: 0x0018B538 File Offset: 0x00189738
		// (set) Token: 0x060094C1 RID: 38081 RVA: 0x0018B540 File Offset: 0x00189740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GNOHNPJBFJC
		{
			get
			{
				return this.gNOHNPJBFJC_;
			}
			set
			{
				this.gNOHNPJBFJC_ = value;
			}
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x0018B549 File Offset: 0x00189749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PrivacySettings);
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x0018B558 File Offset: 0x00189758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PrivacySettings other)
		{
			return other != null && (other == this || (this.PJILEMMBLFG == other.PJILEMMBLFG && this.NMJDBOIPFIC == other.NMJDBOIPFIC && this.NENGEIIJJCB == other.NENGEIIJJCB && this.CPEEEPDBBPH == other.CPEEEPDBBPH && this.GNOHNPJBFJC == other.GNOHNPJBFJC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094C4 RID: 38084 RVA: 0x0018B5D4 File Offset: 0x001897D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PJILEMMBLFG)
			{
				num ^= this.PJILEMMBLFG.GetHashCode();
			}
			if (this.NMJDBOIPFIC)
			{
				num ^= this.NMJDBOIPFIC.GetHashCode();
			}
			if (this.NENGEIIJJCB)
			{
				num ^= this.NENGEIIJJCB.GetHashCode();
			}
			if (this.CPEEEPDBBPH)
			{
				num ^= this.CPEEEPDBBPH.GetHashCode();
			}
			if (this.GNOHNPJBFJC)
			{
				num ^= this.GNOHNPJBFJC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094C5 RID: 38085 RVA: 0x0018B677 File Offset: 0x00189877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094C6 RID: 38086 RVA: 0x0018B67F File Offset: 0x0018987F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094C7 RID: 38087 RVA: 0x0018B688 File Offset: 0x00189888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PJILEMMBLFG)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.PJILEMMBLFG);
			}
			if (this.GNOHNPJBFJC)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.GNOHNPJBFJC);
			}
			if (this.NENGEIIJJCB)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.NENGEIIJJCB);
			}
			if (this.CPEEEPDBBPH)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.CPEEEPDBBPH);
			}
			if (this.NMJDBOIPFIC)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.NMJDBOIPFIC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094C8 RID: 38088 RVA: 0x0018B738 File Offset: 0x00189938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PJILEMMBLFG)
			{
				num += 2;
			}
			if (this.NMJDBOIPFIC)
			{
				num += 2;
			}
			if (this.NENGEIIJJCB)
			{
				num += 2;
			}
			if (this.CPEEEPDBBPH)
			{
				num += 2;
			}
			if (this.GNOHNPJBFJC)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094C9 RID: 38089 RVA: 0x0018B79C File Offset: 0x0018999C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PrivacySettings other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PJILEMMBLFG)
			{
				this.PJILEMMBLFG = other.PJILEMMBLFG;
			}
			if (other.NMJDBOIPFIC)
			{
				this.NMJDBOIPFIC = other.NMJDBOIPFIC;
			}
			if (other.NENGEIIJJCB)
			{
				this.NENGEIIJJCB = other.NENGEIIJJCB;
			}
			if (other.CPEEEPDBBPH)
			{
				this.CPEEEPDBBPH = other.CPEEEPDBBPH;
			}
			if (other.GNOHNPJBFJC)
			{
				this.GNOHNPJBFJC = other.GNOHNPJBFJC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094CA RID: 38090 RVA: 0x0018B828 File Offset: 0x00189A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x0018B834 File Offset: 0x00189A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.PJILEMMBLFG = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.GNOHNPJBFJC = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.NENGEIIJJCB = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.CPEEEPDBBPH = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.NMJDBOIPFIC = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003995 RID: 14741
		private static readonly MessageParser<PrivacySettings> _parser = new MessageParser<PrivacySettings>(() => new PrivacySettings());

		// Token: 0x04003996 RID: 14742
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003997 RID: 14743
		public const int PJILEMMBLFGFieldNumber = 2;

		// Token: 0x04003998 RID: 14744
		private bool pJILEMMBLFG_;

		// Token: 0x04003999 RID: 14745
		public const int NMJDBOIPFICFieldNumber = 14;

		// Token: 0x0400399A RID: 14746
		private bool nMJDBOIPFIC_;

		// Token: 0x0400399B RID: 14747
		public const int NENGEIIJJCBFieldNumber = 8;

		// Token: 0x0400399C RID: 14748
		private bool nENGEIIJJCB_;

		// Token: 0x0400399D RID: 14749
		public const int CPEEEPDBBPHFieldNumber = 12;

		// Token: 0x0400399E RID: 14750
		private bool cPEEEPDBBPH_;

		// Token: 0x0400399F RID: 14751
		public const int GNOHNPJBFJCFieldNumber = 5;

		// Token: 0x040039A0 RID: 14752
		private bool gNOHNPJBFJC_;
	}
}
