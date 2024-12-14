using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C5F RID: 3167
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class OKIOOBNBDEB : IMessage<OKIOOBNBDEB>, IMessage, IEquatable<OKIOOBNBDEB>, IDeepCloneable<OKIOOBNBDEB>, IBufferMessage
	{
		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x06008CB0 RID: 36016 RVA: 0x00173F90 File Offset: 0x00172190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OKIOOBNBDEB> Parser
		{
			get
			{
				return OKIOOBNBDEB._parser;
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x00173F97 File Offset: 0x00172197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OKIOOBNBDEBReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x06008CB2 RID: 36018 RVA: 0x00173FA9 File Offset: 0x001721A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OKIOOBNBDEB.Descriptor;
			}
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x00173FB0 File Offset: 0x001721B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKIOOBNBDEB()
		{
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x00173FC3 File Offset: 0x001721C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKIOOBNBDEB(OKIOOBNBDEB other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00173FED File Offset: 0x001721ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OKIOOBNBDEB Clone()
		{
			return new OKIOOBNBDEB(this);
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x06008CB6 RID: 36022 RVA: 0x00173FF5 File Offset: 0x001721F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KPBGPCMAAJA> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x00173FFD File Offset: 0x001721FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OKIOOBNBDEB);
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x0017400B File Offset: 0x0017220B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OKIOOBNBDEB other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x00174040 File Offset: 0x00172240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.buffList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x00174074 File Offset: 0x00172274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x0017407C File Offset: 0x0017227C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x00174085 File Offset: 0x00172285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, OKIOOBNBDEB._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CBD RID: 36029 RVA: 0x001740AC File Offset: 0x001722AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(OKIOOBNBDEB._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x001740E5 File Offset: 0x001722E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OKIOOBNBDEB other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x00174113 File Offset: 0x00172313
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x0017411C File Offset: 0x0017231C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buffList_.AddEntriesFrom(ref input, OKIOOBNBDEB._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x0400360C RID: 13836
		private static readonly MessageParser<OKIOOBNBDEB> _parser = new MessageParser<OKIOOBNBDEB>(() => new OKIOOBNBDEB());

		// Token: 0x0400360D RID: 13837
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400360E RID: 13838
		public const int BuffListFieldNumber = 3;

		// Token: 0x0400360F RID: 13839
		private static readonly FieldCodec<KPBGPCMAAJA> _repeated_buffList_codec = FieldCodec.ForMessage<KPBGPCMAAJA>(26U, KPBGPCMAAJA.Parser);

		// Token: 0x04003610 RID: 13840
		private readonly RepeatedField<KPBGPCMAAJA> buffList_ = new RepeatedField<KPBGPCMAAJA>();
	}
}
