using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EC3 RID: 3779
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnterCsReq : IMessage<RogueMagicEnterCsReq>, IMessage, IEquatable<RogueMagicEnterCsReq>, IDeepCloneable<RogueMagicEnterCsReq>, IBufferMessage
	{
		// Token: 0x17002FB4 RID: 12212
		// (get) Token: 0x0600A8E3 RID: 43235 RVA: 0x001C6F47 File Offset: 0x001C5147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnterCsReq> Parser
		{
			get
			{
				return RogueMagicEnterCsReq._parser;
			}
		}

		// Token: 0x17002FB5 RID: 12213
		// (get) Token: 0x0600A8E4 RID: 43236 RVA: 0x001C6F4E File Offset: 0x001C514E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnterCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FB6 RID: 12214
		// (get) Token: 0x0600A8E5 RID: 43237 RVA: 0x001C6F60 File Offset: 0x001C5160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnterCsReq.Descriptor;
			}
		}

		// Token: 0x0600A8E6 RID: 43238 RVA: 0x001C6F67 File Offset: 0x001C5167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterCsReq()
		{
		}

		// Token: 0x0600A8E7 RID: 43239 RVA: 0x001C6F6F File Offset: 0x001C516F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterCsReq(RogueMagicEnterCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8E8 RID: 43240 RVA: 0x001C6F88 File Offset: 0x001C5188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnterCsReq Clone()
		{
			return new RogueMagicEnterCsReq(this);
		}

		// Token: 0x0600A8E9 RID: 43241 RVA: 0x001C6F90 File Offset: 0x001C5190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnterCsReq);
		}

		// Token: 0x0600A8EA RID: 43242 RVA: 0x001C6F9E File Offset: 0x001C519E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnterCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600A8EB RID: 43243 RVA: 0x001C6FBC File Offset: 0x001C51BC
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

		// Token: 0x0600A8EC RID: 43244 RVA: 0x001C6FE2 File Offset: 0x001C51E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8ED RID: 43245 RVA: 0x001C6FEA File Offset: 0x001C51EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8EE RID: 43246 RVA: 0x001C6FF3 File Offset: 0x001C51F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8EF RID: 43247 RVA: 0x001C700C File Offset: 0x001C520C
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

		// Token: 0x0600A8F0 RID: 43248 RVA: 0x001C7032 File Offset: 0x001C5232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnterCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8F1 RID: 43249 RVA: 0x001C704F File Offset: 0x001C524F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8F2 RID: 43250 RVA: 0x001C7058 File Offset: 0x001C5258
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040044FE RID: 17662
		private static readonly MessageParser<RogueMagicEnterCsReq> _parser = new MessageParser<RogueMagicEnterCsReq>(() => new RogueMagicEnterCsReq());

		// Token: 0x040044FF RID: 17663
		private UnknownFieldSet _unknownFields;
	}
}
