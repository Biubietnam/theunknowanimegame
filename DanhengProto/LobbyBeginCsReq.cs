using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A2B RID: 2603
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyBeginCsReq : IMessage<LobbyBeginCsReq>, IMessage, IEquatable<LobbyBeginCsReq>, IDeepCloneable<LobbyBeginCsReq>, IBufferMessage
	{
		// Token: 0x17002086 RID: 8326
		// (get) Token: 0x060073AB RID: 29611 RVA: 0x00133B92 File Offset: 0x00131D92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyBeginCsReq> Parser
		{
			get
			{
				return LobbyBeginCsReq._parser;
			}
		}

		// Token: 0x17002087 RID: 8327
		// (get) Token: 0x060073AC RID: 29612 RVA: 0x00133B99 File Offset: 0x00131D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyBeginCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002088 RID: 8328
		// (get) Token: 0x060073AD RID: 29613 RVA: 0x00133BAB File Offset: 0x00131DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyBeginCsReq.Descriptor;
			}
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00133BB2 File Offset: 0x00131DB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyBeginCsReq()
		{
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x00133BBA File Offset: 0x00131DBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyBeginCsReq(LobbyBeginCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00133BD3 File Offset: 0x00131DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyBeginCsReq Clone()
		{
			return new LobbyBeginCsReq(this);
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x00133BDB File Offset: 0x00131DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyBeginCsReq);
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x00133BE9 File Offset: 0x00131DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyBeginCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x00133C08 File Offset: 0x00131E08
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

		// Token: 0x060073B4 RID: 29620 RVA: 0x00133C2E File Offset: 0x00131E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x00133C36 File Offset: 0x00131E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x00133C3F File Offset: 0x00131E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x00133C58 File Offset: 0x00131E58
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

		// Token: 0x060073B8 RID: 29624 RVA: 0x00133C7E File Offset: 0x00131E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyBeginCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00133C9B File Offset: 0x00131E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x00133CA4 File Offset: 0x00131EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002C7A RID: 11386
		private static readonly MessageParser<LobbyBeginCsReq> _parser = new MessageParser<LobbyBeginCsReq>(() => new LobbyBeginCsReq());

		// Token: 0x04002C7B RID: 11387
		private UnknownFieldSet _unknownFields;
	}
}
