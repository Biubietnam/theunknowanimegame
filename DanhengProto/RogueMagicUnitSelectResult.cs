using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F37 RID: 3895
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitSelectResult : IMessage<RogueMagicUnitSelectResult>, IMessage, IEquatable<RogueMagicUnitSelectResult>, IDeepCloneable<RogueMagicUnitSelectResult>, IBufferMessage
	{
		// Token: 0x17003105 RID: 12549
		// (get) Token: 0x0600ADC1 RID: 44481 RVA: 0x001D3265 File Offset: 0x001D1465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitSelectResult> Parser
		{
			get
			{
				return RogueMagicUnitSelectResult._parser;
			}
		}

		// Token: 0x17003106 RID: 12550
		// (get) Token: 0x0600ADC2 RID: 44482 RVA: 0x001D326C File Offset: 0x001D146C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitSelectResultReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003107 RID: 12551
		// (get) Token: 0x0600ADC3 RID: 44483 RVA: 0x001D327E File Offset: 0x001D147E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitSelectResult.Descriptor;
			}
		}

		// Token: 0x0600ADC4 RID: 44484 RVA: 0x001D3285 File Offset: 0x001D1485
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectResult()
		{
		}

		// Token: 0x0600ADC5 RID: 44485 RVA: 0x001D328D File Offset: 0x001D148D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectResult(RogueMagicUnitSelectResult other) : this()
		{
			this.selectMagicUnit_ = ((other.selectMagicUnit_ != null) ? other.selectMagicUnit_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ADC6 RID: 44486 RVA: 0x001D32C2 File Offset: 0x001D14C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectResult Clone()
		{
			return new RogueMagicUnitSelectResult(this);
		}

		// Token: 0x17003108 RID: 12552
		// (get) Token: 0x0600ADC7 RID: 44487 RVA: 0x001D32CA File Offset: 0x001D14CA
		// (set) Token: 0x0600ADC8 RID: 44488 RVA: 0x001D32D2 File Offset: 0x001D14D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnit SelectMagicUnit
		{
			get
			{
				return this.selectMagicUnit_;
			}
			set
			{
				this.selectMagicUnit_ = value;
			}
		}

		// Token: 0x0600ADC9 RID: 44489 RVA: 0x001D32DB File Offset: 0x001D14DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitSelectResult);
		}

		// Token: 0x0600ADCA RID: 44490 RVA: 0x001D32E9 File Offset: 0x001D14E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitSelectResult other)
		{
			return other != null && (other == this || (object.Equals(this.SelectMagicUnit, other.SelectMagicUnit) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ADCB RID: 44491 RVA: 0x001D331C File Offset: 0x001D151C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.selectMagicUnit_ != null)
			{
				num ^= this.SelectMagicUnit.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ADCC RID: 44492 RVA: 0x001D3358 File Offset: 0x001D1558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ADCD RID: 44493 RVA: 0x001D3360 File Offset: 0x001D1560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ADCE RID: 44494 RVA: 0x001D3369 File Offset: 0x001D1569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selectMagicUnit_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.SelectMagicUnit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ADCF RID: 44495 RVA: 0x001D339C File Offset: 0x001D159C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.selectMagicUnit_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelectMagicUnit);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ADD0 RID: 44496 RVA: 0x001D33DC File Offset: 0x001D15DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitSelectResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.selectMagicUnit_ != null)
			{
				if (this.selectMagicUnit_ == null)
				{
					this.SelectMagicUnit = new RogueMagicGameUnit();
				}
				this.SelectMagicUnit.MergeFrom(other.SelectMagicUnit);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADD1 RID: 44497 RVA: 0x001D3430 File Offset: 0x001D1630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADD2 RID: 44498 RVA: 0x001D343C File Offset: 0x001D163C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.selectMagicUnit_ == null)
					{
						this.SelectMagicUnit = new RogueMagicGameUnit();
					}
					input.ReadMessage(this.SelectMagicUnit);
				}
			}
		}

		// Token: 0x040046B7 RID: 18103
		private static readonly MessageParser<RogueMagicUnitSelectResult> _parser = new MessageParser<RogueMagicUnitSelectResult>(() => new RogueMagicUnitSelectResult());

		// Token: 0x040046B8 RID: 18104
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046B9 RID: 18105
		public const int SelectMagicUnitFieldNumber = 13;

		// Token: 0x040046BA RID: 18106
		private RogueMagicGameUnit selectMagicUnit_;
	}
}
