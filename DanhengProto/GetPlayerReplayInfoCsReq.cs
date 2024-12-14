using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200076D RID: 1901
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerReplayInfoCsReq : IMessage<GetPlayerReplayInfoCsReq>, IMessage, IEquatable<GetPlayerReplayInfoCsReq>, IDeepCloneable<GetPlayerReplayInfoCsReq>, IBufferMessage
	{
		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x000E4563 File Offset: 0x000E2763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerReplayInfoCsReq> Parser
		{
			get
			{
				return GetPlayerReplayInfoCsReq._parser;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x060054F2 RID: 21746 RVA: 0x000E456A File Offset: 0x000E276A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerReplayInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x060054F3 RID: 21747 RVA: 0x000E457C File Offset: 0x000E277C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerReplayInfoCsReq.Descriptor;
			}
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x000E4583 File Offset: 0x000E2783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReplayInfoCsReq()
		{
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x000E458B File Offset: 0x000E278B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReplayInfoCsReq(GetPlayerReplayInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x000E45A4 File Offset: 0x000E27A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerReplayInfoCsReq Clone()
		{
			return new GetPlayerReplayInfoCsReq(this);
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x000E45AC File Offset: 0x000E27AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerReplayInfoCsReq);
		}

		// Token: 0x060054F8 RID: 21752 RVA: 0x000E45BA File Offset: 0x000E27BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerReplayInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x000E45D8 File Offset: 0x000E27D8
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

		// Token: 0x060054FA RID: 21754 RVA: 0x000E45FE File Offset: 0x000E27FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x000E4606 File Offset: 0x000E2806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x000E460F File Offset: 0x000E280F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x000E4628 File Offset: 0x000E2828
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

		// Token: 0x060054FE RID: 21758 RVA: 0x000E464E File Offset: 0x000E284E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerReplayInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x000E466B File Offset: 0x000E286B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x000E4674 File Offset: 0x000E2874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002155 RID: 8533
		private static readonly MessageParser<GetPlayerReplayInfoCsReq> _parser = new MessageParser<GetPlayerReplayInfoCsReq>(() => new GetPlayerReplayInfoCsReq());

		// Token: 0x04002156 RID: 8534
		private UnknownFieldSet _unknownFields;
	}
}
