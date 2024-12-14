using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002EB RID: 747
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClockParkGetInfoCsReq : IMessage<ClockParkGetInfoCsReq>, IMessage, IEquatable<ClockParkGetInfoCsReq>, IDeepCloneable<ClockParkGetInfoCsReq>, IBufferMessage
	{
		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002152 RID: 8530 RVA: 0x0005E90F File Offset: 0x0005CB0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClockParkGetInfoCsReq> Parser
		{
			get
			{
				return ClockParkGetInfoCsReq._parser;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06002153 RID: 8531 RVA: 0x0005E916 File Offset: 0x0005CB16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClockParkGetInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06002154 RID: 8532 RVA: 0x0005E928 File Offset: 0x0005CB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClockParkGetInfoCsReq.Descriptor;
			}
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0005E92F File Offset: 0x0005CB2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetInfoCsReq()
		{
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0005E937 File Offset: 0x0005CB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetInfoCsReq(ClockParkGetInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0005E950 File Offset: 0x0005CB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClockParkGetInfoCsReq Clone()
		{
			return new ClockParkGetInfoCsReq(this);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0005E958 File Offset: 0x0005CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClockParkGetInfoCsReq);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0005E966 File Offset: 0x0005CB66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClockParkGetInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0005E984 File Offset: 0x0005CB84
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

		// Token: 0x0600215B RID: 8539 RVA: 0x0005E9AA File Offset: 0x0005CBAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0005E9B2 File Offset: 0x0005CBB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0005E9BB File Offset: 0x0005CBBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x0005E9D4 File Offset: 0x0005CBD4
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

		// Token: 0x0600215F RID: 8543 RVA: 0x0005E9FA File Offset: 0x0005CBFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClockParkGetInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0005EA17 File Offset: 0x0005CC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0005EA20 File Offset: 0x0005CC20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000DB5 RID: 3509
		private static readonly MessageParser<ClockParkGetInfoCsReq> _parser = new MessageParser<ClockParkGetInfoCsReq>(() => new ClockParkGetInfoCsReq());

		// Token: 0x04000DB6 RID: 3510
		private UnknownFieldSet _unknownFields;
	}
}
