using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B31 RID: 2865
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGameCreateScNotify : IMessage<MonopolyGameCreateScNotify>, IMessage, IEquatable<MonopolyGameCreateScNotify>, IDeepCloneable<MonopolyGameCreateScNotify>, IBufferMessage
	{
		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x06007ED2 RID: 32466 RVA: 0x0014F41B File Offset: 0x0014D61B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGameCreateScNotify> Parser
		{
			get
			{
				return MonopolyGameCreateScNotify._parser;
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x06007ED3 RID: 32467 RVA: 0x0014F422 File Offset: 0x0014D622
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGameCreateScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x06007ED4 RID: 32468 RVA: 0x0014F434 File Offset: 0x0014D634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGameCreateScNotify.Descriptor;
			}
		}

		// Token: 0x06007ED5 RID: 32469 RVA: 0x0014F43B File Offset: 0x0014D63B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameCreateScNotify()
		{
		}

		// Token: 0x06007ED6 RID: 32470 RVA: 0x0014F444 File Offset: 0x0014D644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameCreateScNotify(MonopolyGameCreateScNotify other) : this()
		{
			this.bEDINILDMEB_ = ((other.bEDINILDMEB_ != null) ? other.bEDINILDMEB_.Clone() : null);
			this.eKIGFGDLMPE_ = ((other.eKIGFGDLMPE_ != null) ? other.eKIGFGDLMPE_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007ED7 RID: 32471 RVA: 0x0014F4A0 File Offset: 0x0014D6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGameCreateScNotify Clone()
		{
			return new MonopolyGameCreateScNotify(this);
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x06007ED8 RID: 32472 RVA: 0x0014F4A8 File Offset: 0x0014D6A8
		// (set) Token: 0x06007ED9 RID: 32473 RVA: 0x0014F4B0 File Offset: 0x0014D6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FIPNNGPAFCA BEDINILDMEB
		{
			get
			{
				return this.bEDINILDMEB_;
			}
			set
			{
				this.bEDINILDMEB_ = value;
			}
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x06007EDA RID: 32474 RVA: 0x0014F4B9 File Offset: 0x0014D6B9
		// (set) Token: 0x06007EDB RID: 32475 RVA: 0x0014F4C1 File Offset: 0x0014D6C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GJNPFNDEHGL EKIGFGDLMPE
		{
			get
			{
				return this.eKIGFGDLMPE_;
			}
			set
			{
				this.eKIGFGDLMPE_ = value;
			}
		}

		// Token: 0x06007EDC RID: 32476 RVA: 0x0014F4CA File Offset: 0x0014D6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGameCreateScNotify);
		}

		// Token: 0x06007EDD RID: 32477 RVA: 0x0014F4D8 File Offset: 0x0014D6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGameCreateScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.BEDINILDMEB, other.BEDINILDMEB) && object.Equals(this.EKIGFGDLMPE, other.EKIGFGDLMPE) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EDE RID: 32478 RVA: 0x0014F52C File Offset: 0x0014D72C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bEDINILDMEB_ != null)
			{
				num ^= this.BEDINILDMEB.GetHashCode();
			}
			if (this.eKIGFGDLMPE_ != null)
			{
				num ^= this.EKIGFGDLMPE.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007EDF RID: 32479 RVA: 0x0014F57E File Offset: 0x0014D77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007EE0 RID: 32480 RVA: 0x0014F586 File Offset: 0x0014D786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EE1 RID: 32481 RVA: 0x0014F590 File Offset: 0x0014D790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.eKIGFGDLMPE_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.EKIGFGDLMPE);
			}
			if (this.bEDINILDMEB_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.BEDINILDMEB);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007EE2 RID: 32482 RVA: 0x0014F5EC File Offset: 0x0014D7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bEDINILDMEB_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BEDINILDMEB);
			}
			if (this.eKIGFGDLMPE_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EKIGFGDLMPE);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007EE3 RID: 32483 RVA: 0x0014F644 File Offset: 0x0014D844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGameCreateScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bEDINILDMEB_ != null)
			{
				if (this.bEDINILDMEB_ == null)
				{
					this.BEDINILDMEB = new FIPNNGPAFCA();
				}
				this.BEDINILDMEB.MergeFrom(other.BEDINILDMEB);
			}
			if (other.eKIGFGDLMPE_ != null)
			{
				if (this.eKIGFGDLMPE_ == null)
				{
					this.EKIGFGDLMPE = new GJNPFNDEHGL();
				}
				this.EKIGFGDLMPE.MergeFrom(other.EKIGFGDLMPE);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007EE4 RID: 32484 RVA: 0x0014F6C4 File Offset: 0x0014D8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EE5 RID: 32485 RVA: 0x0014F6D0 File Offset: 0x0014D8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.bEDINILDMEB_ == null)
						{
							this.BEDINILDMEB = new FIPNNGPAFCA();
						}
						input.ReadMessage(this.BEDINILDMEB);
					}
				}
				else
				{
					if (this.eKIGFGDLMPE_ == null)
					{
						this.EKIGFGDLMPE = new GJNPFNDEHGL();
					}
					input.ReadMessage(this.EKIGFGDLMPE);
				}
			}
		}

		// Token: 0x0400309F RID: 12447
		private static readonly MessageParser<MonopolyGameCreateScNotify> _parser = new MessageParser<MonopolyGameCreateScNotify>(() => new MonopolyGameCreateScNotify());

		// Token: 0x040030A0 RID: 12448
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030A1 RID: 12449
		public const int BEDINILDMEBFieldNumber = 12;

		// Token: 0x040030A2 RID: 12450
		private FIPNNGPAFCA bEDINILDMEB_;

		// Token: 0x040030A3 RID: 12451
		public const int EKIGFGDLMPEFieldNumber = 10;

		// Token: 0x040030A4 RID: 12452
		private GJNPFNDEHGL eKIGFGDLMPE_;
	}
}
