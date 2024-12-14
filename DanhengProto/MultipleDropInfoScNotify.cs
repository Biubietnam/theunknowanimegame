using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BB9 RID: 3001
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MultipleDropInfoScNotify : IMessage<MultipleDropInfoScNotify>, IMessage, IEquatable<MultipleDropInfoScNotify>, IDeepCloneable<MultipleDropInfoScNotify>, IBufferMessage
	{
		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x060084C8 RID: 33992 RVA: 0x0015E7F1 File Offset: 0x0015C9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MultipleDropInfoScNotify> Parser
		{
			get
			{
				return MultipleDropInfoScNotify._parser;
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x060084C9 RID: 33993 RVA: 0x0015E7F8 File Offset: 0x0015C9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MultipleDropInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x060084CA RID: 33994 RVA: 0x0015E80A File Offset: 0x0015CA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MultipleDropInfoScNotify.Descriptor;
			}
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x0015E811 File Offset: 0x0015CA11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultipleDropInfoScNotify()
		{
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x0015E824 File Offset: 0x0015CA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultipleDropInfoScNotify(MultipleDropInfoScNotify other) : this()
		{
			this.nEFAKDOLPED_ = other.nEFAKDOLPED_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084CD RID: 33997 RVA: 0x0015E84E File Offset: 0x0015CA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MultipleDropInfoScNotify Clone()
		{
			return new MultipleDropInfoScNotify(this);
		}

		// Token: 0x1700253D RID: 9533
		// (get) Token: 0x060084CE RID: 33998 RVA: 0x0015E856 File Offset: 0x0015CA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KNOAKLPPLOM> NEFAKDOLPED
		{
			get
			{
				return this.nEFAKDOLPED_;
			}
		}

		// Token: 0x060084CF RID: 33999 RVA: 0x0015E85E File Offset: 0x0015CA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MultipleDropInfoScNotify);
		}

		// Token: 0x060084D0 RID: 34000 RVA: 0x0015E86C File Offset: 0x0015CA6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MultipleDropInfoScNotify other)
		{
			return other != null && (other == this || (this.nEFAKDOLPED_.Equals(other.nEFAKDOLPED_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x0015E8A0 File Offset: 0x0015CAA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.nEFAKDOLPED_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084D2 RID: 34002 RVA: 0x0015E8D4 File Offset: 0x0015CAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084D3 RID: 34003 RVA: 0x0015E8DC File Offset: 0x0015CADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084D4 RID: 34004 RVA: 0x0015E8E5 File Offset: 0x0015CAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.nEFAKDOLPED_.WriteTo(ref output, MultipleDropInfoScNotify._repeated_nEFAKDOLPED_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x0015E90C File Offset: 0x0015CB0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.nEFAKDOLPED_.CalculateSize(MultipleDropInfoScNotify._repeated_nEFAKDOLPED_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x0015E945 File Offset: 0x0015CB45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MultipleDropInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.nEFAKDOLPED_.Add(other.nEFAKDOLPED_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x0015E973 File Offset: 0x0015CB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084D8 RID: 34008 RVA: 0x0015E97C File Offset: 0x0015CB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.nEFAKDOLPED_.AddEntriesFrom(ref input, MultipleDropInfoScNotify._repeated_nEFAKDOLPED_codec);
				}
			}
		}

		// Token: 0x040032D7 RID: 13015
		private static readonly MessageParser<MultipleDropInfoScNotify> _parser = new MessageParser<MultipleDropInfoScNotify>(() => new MultipleDropInfoScNotify());

		// Token: 0x040032D8 RID: 13016
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032D9 RID: 13017
		public const int NEFAKDOLPEDFieldNumber = 9;

		// Token: 0x040032DA RID: 13018
		private static readonly FieldCodec<KNOAKLPPLOM> _repeated_nEFAKDOLPED_codec = FieldCodec.ForMessage<KNOAKLPPLOM>(74U, KNOAKLPPLOM.Parser);

		// Token: 0x040032DB RID: 13019
		private readonly RepeatedField<KNOAKLPPLOM> nEFAKDOLPED_ = new RepeatedField<KNOAKLPPLOM>();
	}
}
