using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BA9 RID: 2985
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultiplayerFightGameStateCsReq : IMessage<MultiplayerFightGameStateCsReq>, IMessage, IEquatable<MultiplayerFightGameStateCsReq>, IDeepCloneable<MultiplayerFightGameStateCsReq>, IBufferMessage
	{
		// Token: 0x17002508 RID: 9480
		// (get) Token: 0x06008410 RID: 33808 RVA: 0x0015CB37 File Offset: 0x0015AD37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultiplayerFightGameStateCsReq> Parser
		{
			get
			{
				return MultiplayerFightGameStateCsReq._parser;
			}
		}

		// Token: 0x17002509 RID: 9481
		// (get) Token: 0x06008411 RID: 33809 RVA: 0x0015CB3E File Offset: 0x0015AD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultiplayerFightGameStateCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700250A RID: 9482
		// (get) Token: 0x06008412 RID: 33810 RVA: 0x0015CB50 File Offset: 0x0015AD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultiplayerFightGameStateCsReq.Descriptor;
			}
		}

		// Token: 0x06008413 RID: 33811 RVA: 0x0015CB57 File Offset: 0x0015AD57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStateCsReq()
		{
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x0015CB5F File Offset: 0x0015AD5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStateCsReq(MultiplayerFightGameStateCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x0015CB78 File Offset: 0x0015AD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultiplayerFightGameStateCsReq Clone()
		{
			return new MultiplayerFightGameStateCsReq(this);
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x0015CB80 File Offset: 0x0015AD80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultiplayerFightGameStateCsReq);
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x0015CB8E File Offset: 0x0015AD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultiplayerFightGameStateCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x0015CBAC File Offset: 0x0015ADAC
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

		// Token: 0x06008419 RID: 33817 RVA: 0x0015CBD2 File Offset: 0x0015ADD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x0015CBDA File Offset: 0x0015ADDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x0015CBE3 File Offset: 0x0015ADE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x0015CBFC File Offset: 0x0015ADFC
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

		// Token: 0x0600841D RID: 33821 RVA: 0x0015CC22 File Offset: 0x0015AE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultiplayerFightGameStateCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x0015CC3F File Offset: 0x0015AE3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x0015CC48 File Offset: 0x0015AE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003297 RID: 12951
		private static readonly MessageParser<MultiplayerFightGameStateCsReq> _parser = new MessageParser<MultiplayerFightGameStateCsReq>(() => new MultiplayerFightGameStateCsReq());

		// Token: 0x04003298 RID: 12952
		private UnknownFieldSet _unknownFields;
	}
}
