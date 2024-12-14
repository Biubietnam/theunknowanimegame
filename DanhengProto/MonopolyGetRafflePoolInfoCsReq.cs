using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B41 RID: 2881
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGetRafflePoolInfoCsReq : IMessage<MonopolyGetRafflePoolInfoCsReq>, IMessage, IEquatable<MonopolyGetRafflePoolInfoCsReq>, IDeepCloneable<MonopolyGetRafflePoolInfoCsReq>, IBufferMessage
	{
		// Token: 0x170023C6 RID: 9158
		// (get) Token: 0x06007F8D RID: 32653 RVA: 0x00151093 File Offset: 0x0014F293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGetRafflePoolInfoCsReq> Parser
		{
			get
			{
				return MonopolyGetRafflePoolInfoCsReq._parser;
			}
		}

		// Token: 0x170023C7 RID: 9159
		// (get) Token: 0x06007F8E RID: 32654 RVA: 0x0015109A File Offset: 0x0014F29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGetRafflePoolInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x06007F8F RID: 32655 RVA: 0x001510AC File Offset: 0x0014F2AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGetRafflePoolInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06007F90 RID: 32656 RVA: 0x001510B3 File Offset: 0x0014F2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRafflePoolInfoCsReq()
		{
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x001510BB File Offset: 0x0014F2BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRafflePoolInfoCsReq(MonopolyGetRafflePoolInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x001510D4 File Offset: 0x0014F2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGetRafflePoolInfoCsReq Clone()
		{
			return new MonopolyGetRafflePoolInfoCsReq(this);
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x001510DC File Offset: 0x0014F2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGetRafflePoolInfoCsReq);
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x001510EA File Offset: 0x0014F2EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGetRafflePoolInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007F95 RID: 32661 RVA: 0x00151108 File Offset: 0x0014F308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x0015112E File Offset: 0x0014F32E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x00151136 File Offset: 0x0014F336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x0015113F File Offset: 0x0014F33F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x00151158 File Offset: 0x0014F358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x0015117E File Offset: 0x0014F37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGetRafflePoolInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x0015119B File Offset: 0x0014F39B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F9C RID: 32668 RVA: 0x001511A4 File Offset: 0x0014F3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040030DC RID: 12508
		private static readonly MessageParser<MonopolyGetRafflePoolInfoCsReq> _parser = new MessageParser<MonopolyGetRafflePoolInfoCsReq>(() => new MonopolyGetRafflePoolInfoCsReq());

		// Token: 0x040030DD RID: 12509
		private UnknownFieldSet _unknownFields;
	}
}
