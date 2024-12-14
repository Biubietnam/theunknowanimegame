using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008E9 RID: 2281
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HHPGOCKNJCN : IMessage<HHPGOCKNJCN>, IMessage, IEquatable<HHPGOCKNJCN>, IDeepCloneable<HHPGOCKNJCN>, IBufferMessage
	{
		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x060065BC RID: 26044 RVA: 0x0011002C File Offset: 0x0010E22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HHPGOCKNJCN> Parser
		{
			get
			{
				return HHPGOCKNJCN._parser;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x060065BD RID: 26045 RVA: 0x00110033 File Offset: 0x0010E233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HHPGOCKNJCNReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x060065BE RID: 26046 RVA: 0x00110045 File Offset: 0x0010E245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HHPGOCKNJCN.Descriptor;
			}
		}

		// Token: 0x060065BF RID: 26047 RVA: 0x0011004C File Offset: 0x0010E24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HHPGOCKNJCN()
		{
		}

		// Token: 0x060065C0 RID: 26048 RVA: 0x0011005F File Offset: 0x0010E25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HHPGOCKNJCN(HHPGOCKNJCN other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060065C1 RID: 26049 RVA: 0x00110089 File Offset: 0x0010E289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HHPGOCKNJCN Clone()
		{
			return new HHPGOCKNJCN(this);
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x060065C2 RID: 26050 RVA: 0x00110091 File Offset: 0x0010E291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EAHJNKMLDHG> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x060065C3 RID: 26051 RVA: 0x00110099 File Offset: 0x0010E299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HHPGOCKNJCN);
		}

		// Token: 0x060065C4 RID: 26052 RVA: 0x001100A7 File Offset: 0x0010E2A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HHPGOCKNJCN other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060065C5 RID: 26053 RVA: 0x001100DC File Offset: 0x0010E2DC
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

		// Token: 0x060065C6 RID: 26054 RVA: 0x00110110 File Offset: 0x0010E310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060065C7 RID: 26055 RVA: 0x00110118 File Offset: 0x0010E318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060065C8 RID: 26056 RVA: 0x00110121 File Offset: 0x0010E321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, HHPGOCKNJCN._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060065C9 RID: 26057 RVA: 0x00110148 File Offset: 0x0010E348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(HHPGOCKNJCN._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060065CA RID: 26058 RVA: 0x00110181 File Offset: 0x0010E381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HHPGOCKNJCN other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060065CB RID: 26059 RVA: 0x001101AF File Offset: 0x0010E3AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060065CC RID: 26060 RVA: 0x001101B8 File Offset: 0x0010E3B8
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
					this.buffList_.AddEntriesFrom(ref input, HHPGOCKNJCN._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x04002721 RID: 10017
		private static readonly MessageParser<HHPGOCKNJCN> _parser = new MessageParser<HHPGOCKNJCN>(() => new HHPGOCKNJCN());

		// Token: 0x04002722 RID: 10018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002723 RID: 10019
		public const int BuffListFieldNumber = 13;

		// Token: 0x04002724 RID: 10020
		private static readonly FieldCodec<EAHJNKMLDHG> _repeated_buffList_codec = FieldCodec.ForMessage<EAHJNKMLDHG>(106U, EAHJNKMLDHG.Parser);

		// Token: 0x04002725 RID: 10021
		private readonly RepeatedField<EAHJNKMLDHG> buffList_ = new RepeatedField<EAHJNKMLDHG>();
	}
}
