using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008FD RID: 2301
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HMDAGOFFLED : IMessage<HMDAGOFFLED>, IMessage, IEquatable<HMDAGOFFLED>, IDeepCloneable<HMDAGOFFLED>, IBufferMessage
	{
		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x060066A7 RID: 26279 RVA: 0x00112509 File Offset: 0x00110709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HMDAGOFFLED> Parser
		{
			get
			{
				return HMDAGOFFLED._parser;
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x00112510 File Offset: 0x00110710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HMDAGOFFLEDReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x060066A9 RID: 26281 RVA: 0x00112522 File Offset: 0x00110722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HMDAGOFFLED.Descriptor;
			}
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x00112529 File Offset: 0x00110729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMDAGOFFLED()
		{
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x00112534 File Offset: 0x00110734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMDAGOFFLED(HMDAGOFFLED other) : this()
		{
			this.fPJPOJEDBDK_ = other.fPJPOJEDBDK_;
			this.durability_ = other.durability_;
			this.panelId_ = other.panelId_;
			this.hNDEHFJLPKP_ = other.hNDEHFJLPKP_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x00112588 File Offset: 0x00110788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HMDAGOFFLED Clone()
		{
			return new HMDAGOFFLED(this);
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x060066AD RID: 26285 RVA: 0x00112590 File Offset: 0x00110790
		// (set) Token: 0x060066AE RID: 26286 RVA: 0x00112598 File Offset: 0x00110798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint FPJPOJEDBDK
		{
			get
			{
				return this.fPJPOJEDBDK_;
			}
			set
			{
				this.fPJPOJEDBDK_ = value;
			}
		}

		// Token: 0x17001CE8 RID: 7400
		// (get) Token: 0x060066AF RID: 26287 RVA: 0x001125A1 File Offset: 0x001107A1
		// (set) Token: 0x060066B0 RID: 26288 RVA: 0x001125A9 File Offset: 0x001107A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Durability
		{
			get
			{
				return this.durability_;
			}
			set
			{
				this.durability_ = value;
			}
		}

		// Token: 0x17001CE9 RID: 7401
		// (get) Token: 0x060066B1 RID: 26289 RVA: 0x001125B2 File Offset: 0x001107B2
		// (set) Token: 0x060066B2 RID: 26290 RVA: 0x001125BA File Offset: 0x001107BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PanelId
		{
			get
			{
				return this.panelId_;
			}
			set
			{
				this.panelId_ = value;
			}
		}

		// Token: 0x17001CEA RID: 7402
		// (get) Token: 0x060066B3 RID: 26291 RVA: 0x001125C3 File Offset: 0x001107C3
		// (set) Token: 0x060066B4 RID: 26292 RVA: 0x001125CB File Offset: 0x001107CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HNDEHFJLPKP
		{
			get
			{
				return this.hNDEHFJLPKP_;
			}
			set
			{
				this.hNDEHFJLPKP_ = value;
			}
		}

		// Token: 0x060066B5 RID: 26293 RVA: 0x001125D4 File Offset: 0x001107D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HMDAGOFFLED);
		}

		// Token: 0x060066B6 RID: 26294 RVA: 0x001125E4 File Offset: 0x001107E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HMDAGOFFLED other)
		{
			return other != null && (other == this || (this.FPJPOJEDBDK == other.FPJPOJEDBDK && this.Durability == other.Durability && this.PanelId == other.PanelId && this.HNDEHFJLPKP == other.HNDEHFJLPKP && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060066B7 RID: 26295 RVA: 0x00112650 File Offset: 0x00110850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FPJPOJEDBDK != 0U)
			{
				num ^= this.FPJPOJEDBDK.GetHashCode();
			}
			if (this.Durability != 0U)
			{
				num ^= this.Durability.GetHashCode();
			}
			if (this.PanelId != 0U)
			{
				num ^= this.PanelId.GetHashCode();
			}
			if (this.HNDEHFJLPKP != 0U)
			{
				num ^= this.HNDEHFJLPKP.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060066B8 RID: 26296 RVA: 0x001126DA File Offset: 0x001108DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x001126E2 File Offset: 0x001108E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x001126EC File Offset: 0x001108EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HNDEHFJLPKP != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.HNDEHFJLPKP);
			}
			if (this.PanelId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.PanelId);
			}
			if (this.FPJPOJEDBDK != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.FPJPOJEDBDK);
			}
			if (this.Durability != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Durability);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x0011277C File Offset: 0x0011097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FPJPOJEDBDK != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.FPJPOJEDBDK);
			}
			if (this.Durability != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Durability);
			}
			if (this.PanelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PanelId);
			}
			if (this.HNDEHFJLPKP != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HNDEHFJLPKP);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x00112804 File Offset: 0x00110A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HMDAGOFFLED other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FPJPOJEDBDK != 0U)
			{
				this.FPJPOJEDBDK = other.FPJPOJEDBDK;
			}
			if (other.Durability != 0U)
			{
				this.Durability = other.Durability;
			}
			if (other.PanelId != 0U)
			{
				this.PanelId = other.PanelId;
			}
			if (other.HNDEHFJLPKP != 0U)
			{
				this.HNDEHFJLPKP = other.HNDEHFJLPKP;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x0011287C File Offset: 0x00110A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00112888 File Offset: 0x00110A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.HNDEHFJLPKP = input.ReadUInt32();
						continue;
					}
					if (num == 24U)
					{
						this.PanelId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.FPJPOJEDBDK = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Durability = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002772 RID: 10098
		private static readonly MessageParser<HMDAGOFFLED> _parser = new MessageParser<HMDAGOFFLED>(() => new HMDAGOFFLED());

		// Token: 0x04002773 RID: 10099
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002774 RID: 10100
		public const int FPJPOJEDBDKFieldNumber = 11;

		// Token: 0x04002775 RID: 10101
		private uint fPJPOJEDBDK_;

		// Token: 0x04002776 RID: 10102
		public const int DurabilityFieldNumber = 12;

		// Token: 0x04002777 RID: 10103
		private uint durability_;

		// Token: 0x04002778 RID: 10104
		public const int PanelIdFieldNumber = 3;

		// Token: 0x04002779 RID: 10105
		private uint panelId_;

		// Token: 0x0400277A RID: 10106
		public const int HNDEHFJLPKPFieldNumber = 1;

		// Token: 0x0400277B RID: 10107
		private uint hNDEHFJLPKP_;
	}
}
