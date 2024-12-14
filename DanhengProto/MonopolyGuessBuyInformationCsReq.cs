using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B51 RID: 2897
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyGuessBuyInformationCsReq : IMessage<MonopolyGuessBuyInformationCsReq>, IMessage, IEquatable<MonopolyGuessBuyInformationCsReq>, IDeepCloneable<MonopolyGuessBuyInformationCsReq>, IBufferMessage
	{
		// Token: 0x170023F2 RID: 9202
		// (get) Token: 0x0600803C RID: 32828 RVA: 0x001527D3 File Offset: 0x001509D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyGuessBuyInformationCsReq> Parser
		{
			get
			{
				return MonopolyGuessBuyInformationCsReq._parser;
			}
		}

		// Token: 0x170023F3 RID: 9203
		// (get) Token: 0x0600803D RID: 32829 RVA: 0x001527DA File Offset: 0x001509DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyGuessBuyInformationCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170023F4 RID: 9204
		// (get) Token: 0x0600803E RID: 32830 RVA: 0x001527EC File Offset: 0x001509EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyGuessBuyInformationCsReq.Descriptor;
			}
		}

		// Token: 0x0600803F RID: 32831 RVA: 0x001527F3 File Offset: 0x001509F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessBuyInformationCsReq()
		{
		}

		// Token: 0x06008040 RID: 32832 RVA: 0x001527FB File Offset: 0x001509FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessBuyInformationCsReq(MonopolyGuessBuyInformationCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008041 RID: 32833 RVA: 0x00152814 File Offset: 0x00150A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyGuessBuyInformationCsReq Clone()
		{
			return new MonopolyGuessBuyInformationCsReq(this);
		}

		// Token: 0x06008042 RID: 32834 RVA: 0x0015281C File Offset: 0x00150A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyGuessBuyInformationCsReq);
		}

		// Token: 0x06008043 RID: 32835 RVA: 0x0015282A File Offset: 0x00150A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyGuessBuyInformationCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008044 RID: 32836 RVA: 0x00152848 File Offset: 0x00150A48
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

		// Token: 0x06008045 RID: 32837 RVA: 0x0015286E File Offset: 0x00150A6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008046 RID: 32838 RVA: 0x00152876 File Offset: 0x00150A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008047 RID: 32839 RVA: 0x0015287F File Offset: 0x00150A7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008048 RID: 32840 RVA: 0x00152898 File Offset: 0x00150A98
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

		// Token: 0x06008049 RID: 32841 RVA: 0x001528BE File Offset: 0x00150ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyGuessBuyInformationCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600804A RID: 32842 RVA: 0x001528DB File Offset: 0x00150ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600804B RID: 32843 RVA: 0x001528E4 File Offset: 0x00150AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400310D RID: 12557
		private static readonly MessageParser<MonopolyGuessBuyInformationCsReq> _parser = new MessageParser<MonopolyGuessBuyInformationCsReq>(() => new MonopolyGuessBuyInformationCsReq());

		// Token: 0x0400310E RID: 12558
		private UnknownFieldSet _unknownFields;
	}
}
