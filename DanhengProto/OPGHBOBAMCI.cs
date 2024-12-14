using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C73 RID: 3187
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OPGHBOBAMCI : IMessage<OPGHBOBAMCI>, IMessage, IEquatable<OPGHBOBAMCI>, IDeepCloneable<OPGHBOBAMCI>, IBufferMessage
	{
		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x06008DA4 RID: 36260 RVA: 0x0017666C File Offset: 0x0017486C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OPGHBOBAMCI> Parser
		{
			get
			{
				return OPGHBOBAMCI._parser;
			}
		}

		// Token: 0x170027CB RID: 10187
		// (get) Token: 0x06008DA5 RID: 36261 RVA: 0x00176673 File Offset: 0x00174873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OPGHBOBAMCIReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170027CC RID: 10188
		// (get) Token: 0x06008DA6 RID: 36262 RVA: 0x00176685 File Offset: 0x00174885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OPGHBOBAMCI.Descriptor;
			}
		}

		// Token: 0x06008DA7 RID: 36263 RVA: 0x0017668C File Offset: 0x0017488C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPGHBOBAMCI()
		{
		}

		// Token: 0x06008DA8 RID: 36264 RVA: 0x0017669F File Offset: 0x0017489F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPGHBOBAMCI(OPGHBOBAMCI other) : this()
		{
			this.jAMBHPJEHAK_ = other.jAMBHPJEHAK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DA9 RID: 36265 RVA: 0x001766C9 File Offset: 0x001748C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OPGHBOBAMCI Clone()
		{
			return new OPGHBOBAMCI(this);
		}

		// Token: 0x170027CD RID: 10189
		// (get) Token: 0x06008DAA RID: 36266 RVA: 0x001766D1 File Offset: 0x001748D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> JAMBHPJEHAK
		{
			get
			{
				return this.jAMBHPJEHAK_;
			}
		}

		// Token: 0x06008DAB RID: 36267 RVA: 0x001766D9 File Offset: 0x001748D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OPGHBOBAMCI);
		}

		// Token: 0x06008DAC RID: 36268 RVA: 0x001766E7 File Offset: 0x001748E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OPGHBOBAMCI other)
		{
			return other != null && (other == this || (this.jAMBHPJEHAK_.Equals(other.jAMBHPJEHAK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008DAD RID: 36269 RVA: 0x0017671C File Offset: 0x0017491C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.jAMBHPJEHAK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DAE RID: 36270 RVA: 0x00176750 File Offset: 0x00174950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x00176758 File Offset: 0x00174958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00176761 File Offset: 0x00174961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.jAMBHPJEHAK_.WriteTo(ref output, OPGHBOBAMCI._repeated_jAMBHPJEHAK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DB1 RID: 36273 RVA: 0x00176788 File Offset: 0x00174988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.jAMBHPJEHAK_.CalculateSize(OPGHBOBAMCI._repeated_jAMBHPJEHAK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DB2 RID: 36274 RVA: 0x001767C1 File Offset: 0x001749C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OPGHBOBAMCI other)
		{
			if (other == null)
			{
				return;
			}
			this.jAMBHPJEHAK_.Add(other.jAMBHPJEHAK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008DB3 RID: 36275 RVA: 0x001767EF File Offset: 0x001749EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DB4 RID: 36276 RVA: 0x001767F8 File Offset: 0x001749F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.jAMBHPJEHAK_.AddEntriesFrom(ref input, OPGHBOBAMCI._repeated_jAMBHPJEHAK_codec);
				}
			}
		}

		// Token: 0x04003664 RID: 13924
		private static readonly MessageParser<OPGHBOBAMCI> _parser = new MessageParser<OPGHBOBAMCI>(() => new OPGHBOBAMCI());

		// Token: 0x04003665 RID: 13925
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003666 RID: 13926
		public const int JAMBHPJEHAKFieldNumber = 1;

		// Token: 0x04003667 RID: 13927
		private static readonly FieldCodec<uint> _repeated_jAMBHPJEHAK_codec = FieldCodec.ForUInt32(10U);

		// Token: 0x04003668 RID: 13928
		private readonly RepeatedField<uint> jAMBHPJEHAK_ = new RepeatedField<uint>();
	}
}
