using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200115D RID: 4445
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SpaceZooCatUpdateNotify : IMessage<SpaceZooCatUpdateNotify>, IMessage, IEquatable<SpaceZooCatUpdateNotify>, IDeepCloneable<SpaceZooCatUpdateNotify>, IBufferMessage
	{
		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600C64F RID: 50767 RVA: 0x0021454B File Offset: 0x0021274B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SpaceZooCatUpdateNotify> Parser
		{
			get
			{
				return SpaceZooCatUpdateNotify._parser;
			}
		}

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600C650 RID: 50768 RVA: 0x00214552 File Offset: 0x00212752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SpaceZooCatUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600C651 RID: 50769 RVA: 0x00214564 File Offset: 0x00212764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpaceZooCatUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600C652 RID: 50770 RVA: 0x0021456B File Offset: 0x0021276B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooCatUpdateNotify()
		{
		}

		// Token: 0x0600C653 RID: 50771 RVA: 0x00214580 File Offset: 0x00212780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooCatUpdateNotify(SpaceZooCatUpdateNotify other) : this()
		{
			this.pCOJPHIDLOF_ = other.pCOJPHIDLOF_;
			this.dEMPNBCBLIA_ = other.dEMPNBCBLIA_.Clone();
			this.iFCOOAAPLDF_ = other.iFCOOAAPLDF_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C654 RID: 50772 RVA: 0x002145CD File Offset: 0x002127CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpaceZooCatUpdateNotify Clone()
		{
			return new SpaceZooCatUpdateNotify(this);
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600C655 RID: 50773 RVA: 0x002145D5 File Offset: 0x002127D5
		// (set) Token: 0x0600C656 RID: 50774 RVA: 0x002145DD File Offset: 0x002127DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool PCOJPHIDLOF
		{
			get
			{
				return this.pCOJPHIDLOF_;
			}
			set
			{
				this.pCOJPHIDLOF_ = value;
			}
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600C657 RID: 50775 RVA: 0x002145E6 File Offset: 0x002127E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CHBBGEIDOGB> DEMPNBCBLIA
		{
			get
			{
				return this.dEMPNBCBLIA_;
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600C658 RID: 50776 RVA: 0x002145EE File Offset: 0x002127EE
		// (set) Token: 0x0600C659 RID: 50777 RVA: 0x002145F6 File Offset: 0x002127F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IFCOOAAPLDF
		{
			get
			{
				return this.iFCOOAAPLDF_;
			}
			set
			{
				this.iFCOOAAPLDF_ = value;
			}
		}

		// Token: 0x0600C65A RID: 50778 RVA: 0x002145FF File Offset: 0x002127FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpaceZooCatUpdateNotify);
		}

		// Token: 0x0600C65B RID: 50779 RVA: 0x00214610 File Offset: 0x00212810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpaceZooCatUpdateNotify other)
		{
			return other != null && (other == this || (this.PCOJPHIDLOF == other.PCOJPHIDLOF && this.dEMPNBCBLIA_.Equals(other.dEMPNBCBLIA_) && this.IFCOOAAPLDF == other.IFCOOAAPLDF && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C65C RID: 50780 RVA: 0x00214670 File Offset: 0x00212870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PCOJPHIDLOF)
			{
				num ^= this.PCOJPHIDLOF.GetHashCode();
			}
			num ^= this.dEMPNBCBLIA_.GetHashCode();
			if (this.IFCOOAAPLDF)
			{
				num ^= this.IFCOOAAPLDF.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C65D RID: 50781 RVA: 0x002146D6 File Offset: 0x002128D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C65E RID: 50782 RVA: 0x002146DE File Offset: 0x002128DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C65F RID: 50783 RVA: 0x002146E8 File Offset: 0x002128E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PCOJPHIDLOF)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.PCOJPHIDLOF);
			}
			this.dEMPNBCBLIA_.WriteTo(ref output, SpaceZooCatUpdateNotify._repeated_dEMPNBCBLIA_codec);
			if (this.IFCOOAAPLDF)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IFCOOAAPLDF);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C660 RID: 50784 RVA: 0x00214754 File Offset: 0x00212954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PCOJPHIDLOF)
			{
				num += 2;
			}
			num += this.dEMPNBCBLIA_.CalculateSize(SpaceZooCatUpdateNotify._repeated_dEMPNBCBLIA_codec);
			if (this.IFCOOAAPLDF)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C661 RID: 50785 RVA: 0x002147A8 File Offset: 0x002129A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpaceZooCatUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PCOJPHIDLOF)
			{
				this.PCOJPHIDLOF = other.PCOJPHIDLOF;
			}
			this.dEMPNBCBLIA_.Add(other.dEMPNBCBLIA_);
			if (other.IFCOOAAPLDF)
			{
				this.IFCOOAAPLDF = other.IFCOOAAPLDF;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x00214809 File Offset: 0x00212A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C663 RID: 50787 RVA: 0x00214814 File Offset: 0x00212A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 58U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IFCOOAAPLDF = input.ReadBool();
						}
					}
					else
					{
						this.dEMPNBCBLIA_.AddEntriesFrom(ref input, SpaceZooCatUpdateNotify._repeated_dEMPNBCBLIA_codec);
					}
				}
				else
				{
					this.PCOJPHIDLOF = input.ReadBool();
				}
			}
		}

		// Token: 0x0400501D RID: 20509
		private static readonly MessageParser<SpaceZooCatUpdateNotify> _parser = new MessageParser<SpaceZooCatUpdateNotify>(() => new SpaceZooCatUpdateNotify());

		// Token: 0x0400501E RID: 20510
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400501F RID: 20511
		public const int PCOJPHIDLOFFieldNumber = 1;

		// Token: 0x04005020 RID: 20512
		private bool pCOJPHIDLOF_;

		// Token: 0x04005021 RID: 20513
		public const int DEMPNBCBLIAFieldNumber = 7;

		// Token: 0x04005022 RID: 20514
		private static readonly FieldCodec<CHBBGEIDOGB> _repeated_dEMPNBCBLIA_codec = FieldCodec.ForMessage<CHBBGEIDOGB>(58U, CHBBGEIDOGB.Parser);

		// Token: 0x04005023 RID: 20515
		private readonly RepeatedField<CHBBGEIDOGB> dEMPNBCBLIA_ = new RepeatedField<CHBBGEIDOGB>();

		// Token: 0x04005024 RID: 20516
		public const int IFCOOAAPLDFFieldNumber = 10;

		// Token: 0x04005025 RID: 20517
		private bool iFCOOAAPLDF_;
	}
}
