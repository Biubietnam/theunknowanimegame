using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000991 RID: 2449
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KDIEOAKOFOP : IMessage<KDIEOAKOFOP>, IMessage, IEquatable<KDIEOAKOFOP>, IDeepCloneable<KDIEOAKOFOP>, IBufferMessage
	{
		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06006D97 RID: 28055 RVA: 0x001250B5 File Offset: 0x001232B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KDIEOAKOFOP> Parser
		{
			get
			{
				return KDIEOAKOFOP._parser;
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x06006D98 RID: 28056 RVA: 0x001250BC File Offset: 0x001232BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KDIEOAKOFOPReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x06006D99 RID: 28057 RVA: 0x001250CE File Offset: 0x001232CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KDIEOAKOFOP.Descriptor;
			}
		}

		// Token: 0x06006D9A RID: 28058 RVA: 0x001250D5 File Offset: 0x001232D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDIEOAKOFOP()
		{
		}

		// Token: 0x06006D9B RID: 28059 RVA: 0x001250DD File Offset: 0x001232DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDIEOAKOFOP(KDIEOAKOFOP other) : this()
		{
			this.selectMagicUnit_ = ((other.selectMagicUnit_ != null) ? other.selectMagicUnit_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D9C RID: 28060 RVA: 0x00125112 File Offset: 0x00123312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KDIEOAKOFOP Clone()
		{
			return new KDIEOAKOFOP(this);
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06006D9D RID: 28061 RVA: 0x0012511A File Offset: 0x0012331A
		// (set) Token: 0x06006D9E RID: 28062 RVA: 0x00125122 File Offset: 0x00123322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicGameUnitInfo SelectMagicUnit
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

		// Token: 0x06006D9F RID: 28063 RVA: 0x0012512B File Offset: 0x0012332B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KDIEOAKOFOP);
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00125139 File Offset: 0x00123339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KDIEOAKOFOP other)
		{
			return other != null && (other == this || (object.Equals(this.SelectMagicUnit, other.SelectMagicUnit) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x0012516C File Offset: 0x0012336C
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

		// Token: 0x06006DA2 RID: 28066 RVA: 0x001251A8 File Offset: 0x001233A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006DA3 RID: 28067 RVA: 0x001251B0 File Offset: 0x001233B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006DA4 RID: 28068 RVA: 0x001251B9 File Offset: 0x001233B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.selectMagicUnit_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.SelectMagicUnit);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006DA5 RID: 28069 RVA: 0x001251EC File Offset: 0x001233EC
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

		// Token: 0x06006DA6 RID: 28070 RVA: 0x0012522C File Offset: 0x0012342C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KDIEOAKOFOP other)
		{
			if (other == null)
			{
				return;
			}
			if (other.selectMagicUnit_ != null)
			{
				if (this.selectMagicUnit_ == null)
				{
					this.SelectMagicUnit = new RogueMagicGameUnitInfo();
				}
				this.SelectMagicUnit.MergeFrom(other.SelectMagicUnit);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006DA7 RID: 28071 RVA: 0x00125280 File Offset: 0x00123480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006DA8 RID: 28072 RVA: 0x0012528C File Offset: 0x0012348C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.selectMagicUnit_ == null)
					{
						this.SelectMagicUnit = new RogueMagicGameUnitInfo();
					}
					input.ReadMessage(this.SelectMagicUnit);
				}
			}
		}

		// Token: 0x04002A1F RID: 10783
		private static readonly MessageParser<KDIEOAKOFOP> _parser = new MessageParser<KDIEOAKOFOP>(() => new KDIEOAKOFOP());

		// Token: 0x04002A20 RID: 10784
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A21 RID: 10785
		public const int SelectMagicUnitFieldNumber = 14;

		// Token: 0x04002A22 RID: 10786
		private RogueMagicGameUnitInfo selectMagicUnit_;
	}
}
