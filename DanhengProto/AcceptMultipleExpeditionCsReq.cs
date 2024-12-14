using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000021 RID: 33
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AcceptMultipleExpeditionCsReq : IMessage<AcceptMultipleExpeditionCsReq>, IMessage, IEquatable<AcceptMultipleExpeditionCsReq>, IDeepCloneable<AcceptMultipleExpeditionCsReq>, IBufferMessage
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00004A9D File Offset: 0x00002C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AcceptMultipleExpeditionCsReq> Parser
		{
			get
			{
				return AcceptMultipleExpeditionCsReq._parser;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00004AA4 File Offset: 0x00002CA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AcceptMultipleExpeditionCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00004AB6 File Offset: 0x00002CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AcceptMultipleExpeditionCsReq.Descriptor;
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004ABD File Offset: 0x00002CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMultipleExpeditionCsReq()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMultipleExpeditionCsReq(AcceptMultipleExpeditionCsReq other) : this()
		{
			this.iBCOIFFNIJN_ = other.iBCOIFFNIJN_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004AFA File Offset: 0x00002CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AcceptMultipleExpeditionCsReq Clone()
		{
			return new AcceptMultipleExpeditionCsReq(this);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00004B02 File Offset: 0x00002D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JLHHCIJPOPD> IBCOIFFNIJN
		{
			get
			{
				return this.iBCOIFFNIJN_;
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004B0A File Offset: 0x00002D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AcceptMultipleExpeditionCsReq);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004B18 File Offset: 0x00002D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AcceptMultipleExpeditionCsReq other)
		{
			return other != null && (other == this || (this.iBCOIFFNIJN_.Equals(other.iBCOIFFNIJN_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004B4C File Offset: 0x00002D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.iBCOIFFNIJN_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00004B80 File Offset: 0x00002D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00004B88 File Offset: 0x00002D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00004B91 File Offset: 0x00002D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.iBCOIFFNIJN_.WriteTo(ref output, AcceptMultipleExpeditionCsReq._repeated_iBCOIFFNIJN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00004BB8 File Offset: 0x00002DB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.iBCOIFFNIJN_.CalculateSize(AcceptMultipleExpeditionCsReq._repeated_iBCOIFFNIJN_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00004BF1 File Offset: 0x00002DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AcceptMultipleExpeditionCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.iBCOIFFNIJN_.Add(other.iBCOIFFNIJN_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004C1F File Offset: 0x00002E1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004C28 File Offset: 0x00002E28
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
					this.iBCOIFFNIJN_.AddEntriesFrom(ref input, AcceptMultipleExpeditionCsReq._repeated_iBCOIFFNIJN_codec);
				}
			}
		}

		// Token: 0x04000063 RID: 99
		private static readonly MessageParser<AcceptMultipleExpeditionCsReq> _parser = new MessageParser<AcceptMultipleExpeditionCsReq>(() => new AcceptMultipleExpeditionCsReq());

		// Token: 0x04000064 RID: 100
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000065 RID: 101
		public const int IBCOIFFNIJNFieldNumber = 13;

		// Token: 0x04000066 RID: 102
		private static readonly FieldCodec<JLHHCIJPOPD> _repeated_iBCOIFFNIJN_codec = FieldCodec.ForMessage<JLHHCIJPOPD>(106U, JLHHCIJPOPD.Parser);

		// Token: 0x04000067 RID: 103
		private readonly RepeatedField<JLHHCIJPOPD> iBCOIFFNIJN_ = new RepeatedField<JLHHCIJPOPD>();
	}
}
