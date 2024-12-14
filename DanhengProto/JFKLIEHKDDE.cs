using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000963 RID: 2403
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class JFKLIEHKDDE : IMessage<JFKLIEHKDDE>, IMessage, IEquatable<JFKLIEHKDDE>, IDeepCloneable<JFKLIEHKDDE>, IBufferMessage
	{
		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x06006B55 RID: 27477 RVA: 0x0011E4D0 File Offset: 0x0011C6D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<JFKLIEHKDDE> Parser
		{
			get
			{
				return JFKLIEHKDDE._parser;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x06006B56 RID: 27478 RVA: 0x0011E4D7 File Offset: 0x0011C6D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return JFKLIEHKDDEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06006B57 RID: 27479 RVA: 0x0011E4E9 File Offset: 0x0011C6E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JFKLIEHKDDE.Descriptor;
			}
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x0011E4F0 File Offset: 0x0011C6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JFKLIEHKDDE()
		{
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x0011E503 File Offset: 0x0011C703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JFKLIEHKDDE(JFKLIEHKDDE other) : this()
		{
			this.buffList_ = other.buffList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B5A RID: 27482 RVA: 0x0011E52D File Offset: 0x0011C72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JFKLIEHKDDE Clone()
		{
			return new JFKLIEHKDDE(this);
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x06006B5B RID: 27483 RVA: 0x0011E535 File Offset: 0x0011C735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ELGEEHOFEKF> BuffList
		{
			get
			{
				return this.buffList_;
			}
		}

		// Token: 0x06006B5C RID: 27484 RVA: 0x0011E53D File Offset: 0x0011C73D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JFKLIEHKDDE);
		}

		// Token: 0x06006B5D RID: 27485 RVA: 0x0011E54B File Offset: 0x0011C74B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JFKLIEHKDDE other)
		{
			return other != null && (other == this || (this.buffList_.Equals(other.buffList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B5E RID: 27486 RVA: 0x0011E580 File Offset: 0x0011C780
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

		// Token: 0x06006B5F RID: 27487 RVA: 0x0011E5B4 File Offset: 0x0011C7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006B60 RID: 27488 RVA: 0x0011E5BC File Offset: 0x0011C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B61 RID: 27489 RVA: 0x0011E5C5 File Offset: 0x0011C7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffList_.WriteTo(ref output, JFKLIEHKDDE._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B62 RID: 27490 RVA: 0x0011E5EC File Offset: 0x0011C7EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.buffList_.CalculateSize(JFKLIEHKDDE._repeated_buffList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B63 RID: 27491 RVA: 0x0011E625 File Offset: 0x0011C825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JFKLIEHKDDE other)
		{
			if (other == null)
			{
				return;
			}
			this.buffList_.Add(other.buffList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B64 RID: 27492 RVA: 0x0011E653 File Offset: 0x0011C853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B65 RID: 27493 RVA: 0x0011E65C File Offset: 0x0011C85C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.buffList_.AddEntriesFrom(ref input, JFKLIEHKDDE._repeated_buffList_codec);
				}
			}
		}

		// Token: 0x0400291B RID: 10523
		private static readonly MessageParser<JFKLIEHKDDE> _parser = new MessageParser<JFKLIEHKDDE>(() => new JFKLIEHKDDE());

		// Token: 0x0400291C RID: 10524
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400291D RID: 10525
		public const int BuffListFieldNumber = 10;

		// Token: 0x0400291E RID: 10526
		private static readonly FieldCodec<ELGEEHOFEKF> _repeated_buffList_codec = FieldCodec.ForMessage<ELGEEHOFEKF>(82U, ELGEEHOFEKF.Parser);

		// Token: 0x0400291F RID: 10527
		private readonly RepeatedField<ELGEEHOFEKF> buffList_ = new RepeatedField<ELGEEHOFEKF>();
	}
}
