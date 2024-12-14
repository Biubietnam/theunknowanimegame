using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A8D RID: 2701
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MarkReadMailCsReq : IMessage<MarkReadMailCsReq>, IMessage, IEquatable<MarkReadMailCsReq>, IDeepCloneable<MarkReadMailCsReq>, IBufferMessage
	{
		// Token: 0x170021A0 RID: 8608
		// (get) Token: 0x060077C0 RID: 30656 RVA: 0x0013D8A0 File Offset: 0x0013BAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkReadMailCsReq> Parser
		{
			get
			{
				return MarkReadMailCsReq._parser;
			}
		}

		// Token: 0x170021A1 RID: 8609
		// (get) Token: 0x060077C1 RID: 30657 RVA: 0x0013D8A7 File Offset: 0x0013BAA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MarkReadMailCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170021A2 RID: 8610
		// (get) Token: 0x060077C2 RID: 30658 RVA: 0x0013D8B9 File Offset: 0x0013BAB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkReadMailCsReq.Descriptor;
			}
		}

		// Token: 0x060077C3 RID: 30659 RVA: 0x0013D8C0 File Offset: 0x0013BAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkReadMailCsReq()
		{
		}

		// Token: 0x060077C4 RID: 30660 RVA: 0x0013D8C8 File Offset: 0x0013BAC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkReadMailCsReq(MarkReadMailCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077C5 RID: 30661 RVA: 0x0013D8ED File Offset: 0x0013BAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkReadMailCsReq Clone()
		{
			return new MarkReadMailCsReq(this);
		}

		// Token: 0x170021A3 RID: 8611
		// (get) Token: 0x060077C6 RID: 30662 RVA: 0x0013D8F5 File Offset: 0x0013BAF5
		// (set) Token: 0x060077C7 RID: 30663 RVA: 0x0013D8FD File Offset: 0x0013BAFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x0013D906 File Offset: 0x0013BB06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkReadMailCsReq);
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x0013D914 File Offset: 0x0013BB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkReadMailCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x0013D944 File Offset: 0x0013BB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x0013D983 File Offset: 0x0013BB83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060077CC RID: 30668 RVA: 0x0013D98B File Offset: 0x0013BB8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077CD RID: 30669 RVA: 0x0013D994 File Offset: 0x0013BB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x0013D9C8 File Offset: 0x0013BBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x0013DA06 File Offset: 0x0013BC06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkReadMailCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x0013DA37 File Offset: 0x0013BC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060077D1 RID: 30673 RVA: 0x0013DA40 File Offset: 0x0013BC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002DF8 RID: 11768
		private static readonly MessageParser<MarkReadMailCsReq> _parser = new MessageParser<MarkReadMailCsReq>(() => new MarkReadMailCsReq());

		// Token: 0x04002DF9 RID: 11769
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DFA RID: 11770
		public const int IdFieldNumber = 3;

		// Token: 0x04002DFB RID: 11771
		private uint id_;
	}
}
