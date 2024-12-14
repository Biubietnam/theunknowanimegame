using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009BB RID: 2491
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KKCABEAAPJC : IMessage<KKCABEAAPJC>, IMessage, IEquatable<KKCABEAAPJC>, IDeepCloneable<KKCABEAAPJC>, IBufferMessage
	{
		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06006F40 RID: 28480 RVA: 0x00129144 File Offset: 0x00127344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KKCABEAAPJC> Parser
		{
			get
			{
				return KKCABEAAPJC._parser;
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06006F41 RID: 28481 RVA: 0x0012914B File Offset: 0x0012734B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KKCABEAAPJCReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06006F42 RID: 28482 RVA: 0x0012915D File Offset: 0x0012735D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KKCABEAAPJC.Descriptor;
			}
		}

		// Token: 0x06006F43 RID: 28483 RVA: 0x00129164 File Offset: 0x00127364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKCABEAAPJC()
		{
		}

		// Token: 0x06006F44 RID: 28484 RVA: 0x00129177 File Offset: 0x00127377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKCABEAAPJC(KKCABEAAPJC other) : this()
		{
			this.dMPAGJBCEHE_ = other.dMPAGJBCEHE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F45 RID: 28485 RVA: 0x001291A1 File Offset: 0x001273A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KKCABEAAPJC Clone()
		{
			return new KKCABEAAPJC(this);
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06006F46 RID: 28486 RVA: 0x001291A9 File Offset: 0x001273A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> DMPAGJBCEHE
		{
			get
			{
				return this.dMPAGJBCEHE_;
			}
		}

		// Token: 0x06006F47 RID: 28487 RVA: 0x001291B1 File Offset: 0x001273B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KKCABEAAPJC);
		}

		// Token: 0x06006F48 RID: 28488 RVA: 0x001291BF File Offset: 0x001273BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KKCABEAAPJC other)
		{
			return other != null && (other == this || (this.dMPAGJBCEHE_.Equals(other.dMPAGJBCEHE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F49 RID: 28489 RVA: 0x001291F4 File Offset: 0x001273F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dMPAGJBCEHE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F4A RID: 28490 RVA: 0x00129228 File Offset: 0x00127428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F4B RID: 28491 RVA: 0x00129230 File Offset: 0x00127430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F4C RID: 28492 RVA: 0x00129239 File Offset: 0x00127439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dMPAGJBCEHE_.WriteTo(ref output, KKCABEAAPJC._repeated_dMPAGJBCEHE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F4D RID: 28493 RVA: 0x00129260 File Offset: 0x00127460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dMPAGJBCEHE_.CalculateSize(KKCABEAAPJC._repeated_dMPAGJBCEHE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F4E RID: 28494 RVA: 0x00129299 File Offset: 0x00127499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KKCABEAAPJC other)
		{
			if (other == null)
			{
				return;
			}
			this.dMPAGJBCEHE_.Add(other.dMPAGJBCEHE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F4F RID: 28495 RVA: 0x001292C7 File Offset: 0x001274C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F50 RID: 28496 RVA: 0x001292D0 File Offset: 0x001274D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dMPAGJBCEHE_.AddEntriesFrom(ref input, KKCABEAAPJC._repeated_dMPAGJBCEHE_codec);
				}
			}
		}

		// Token: 0x04002AC3 RID: 10947
		private static readonly MessageParser<KKCABEAAPJC> _parser = new MessageParser<KKCABEAAPJC>(() => new KKCABEAAPJC());

		// Token: 0x04002AC4 RID: 10948
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AC5 RID: 10949
		public const int DMPAGJBCEHEFieldNumber = 7;

		// Token: 0x04002AC6 RID: 10950
		private static readonly FieldCodec<uint> _repeated_dMPAGJBCEHE_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04002AC7 RID: 10951
		private readonly RepeatedField<uint> dMPAGJBCEHE_ = new RepeatedField<uint>();
	}
}
