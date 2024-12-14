using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000571 RID: 1393
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishCurTurnCsReq : IMessage<FinishCurTurnCsReq>, IMessage, IEquatable<FinishCurTurnCsReq>, IDeepCloneable<FinishCurTurnCsReq>, IBufferMessage
	{
		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06003E23 RID: 15907 RVA: 0x000A9FC8 File Offset: 0x000A81C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishCurTurnCsReq> Parser
		{
			get
			{
				return FinishCurTurnCsReq._parser;
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06003E24 RID: 15908 RVA: 0x000A9FCF File Offset: 0x000A81CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishCurTurnCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06003E25 RID: 15909 RVA: 0x000A9FE1 File Offset: 0x000A81E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishCurTurnCsReq.Descriptor;
			}
		}

		// Token: 0x06003E26 RID: 15910 RVA: 0x000A9FE8 File Offset: 0x000A81E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCurTurnCsReq()
		{
		}

		// Token: 0x06003E27 RID: 15911 RVA: 0x000A9FF0 File Offset: 0x000A81F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCurTurnCsReq(FinishCurTurnCsReq other) : this()
		{
			this.dCAEBNKOBIH_ = other.dCAEBNKOBIH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003E28 RID: 15912 RVA: 0x000AA015 File Offset: 0x000A8215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishCurTurnCsReq Clone()
		{
			return new FinishCurTurnCsReq(this);
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06003E29 RID: 15913 RVA: 0x000AA01D File Offset: 0x000A821D
		// (set) Token: 0x06003E2A RID: 15914 RVA: 0x000AA025 File Offset: 0x000A8225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DCAEBNKOBIH
		{
			get
			{
				return this.dCAEBNKOBIH_;
			}
			set
			{
				this.dCAEBNKOBIH_ = value;
			}
		}

		// Token: 0x06003E2B RID: 15915 RVA: 0x000AA02E File Offset: 0x000A822E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishCurTurnCsReq);
		}

		// Token: 0x06003E2C RID: 15916 RVA: 0x000AA03C File Offset: 0x000A823C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishCurTurnCsReq other)
		{
			return other != null && (other == this || (this.DCAEBNKOBIH == other.DCAEBNKOBIH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003E2D RID: 15917 RVA: 0x000AA06C File Offset: 0x000A826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DCAEBNKOBIH != 0U)
			{
				num ^= this.DCAEBNKOBIH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003E2E RID: 15918 RVA: 0x000AA0AB File Offset: 0x000A82AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003E2F RID: 15919 RVA: 0x000AA0B3 File Offset: 0x000A82B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003E30 RID: 15920 RVA: 0x000AA0BC File Offset: 0x000A82BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DCAEBNKOBIH != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.DCAEBNKOBIH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003E31 RID: 15921 RVA: 0x000AA0F0 File Offset: 0x000A82F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DCAEBNKOBIH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DCAEBNKOBIH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003E32 RID: 15922 RVA: 0x000AA12E File Offset: 0x000A832E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishCurTurnCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DCAEBNKOBIH != 0U)
			{
				this.DCAEBNKOBIH = other.DCAEBNKOBIH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003E33 RID: 15923 RVA: 0x000AA15F File Offset: 0x000A835F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003E34 RID: 15924 RVA: 0x000AA168 File Offset: 0x000A8368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.DCAEBNKOBIH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040018D2 RID: 6354
		private static readonly MessageParser<FinishCurTurnCsReq> _parser = new MessageParser<FinishCurTurnCsReq>(() => new FinishCurTurnCsReq());

		// Token: 0x040018D3 RID: 6355
		private UnknownFieldSet _unknownFields;

		// Token: 0x040018D4 RID: 6356
		public const int DCAEBNKOBIHFieldNumber = 5;

		// Token: 0x040018D5 RID: 6357
		private uint dCAEBNKOBIH_;
	}
}
