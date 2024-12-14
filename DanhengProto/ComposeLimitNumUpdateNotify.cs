using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200031F RID: 799
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ComposeLimitNumUpdateNotify : IMessage<ComposeLimitNumUpdateNotify>, IMessage, IEquatable<ComposeLimitNumUpdateNotify>, IDeepCloneable<ComposeLimitNumUpdateNotify>, IBufferMessage
	{
		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x00065ACD File Offset: 0x00063CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComposeLimitNumUpdateNotify> Parser
		{
			get
			{
				return ComposeLimitNumUpdateNotify._parser;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00065AD4 File Offset: 0x00063CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ComposeLimitNumUpdateNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x060023D2 RID: 9170 RVA: 0x00065AE6 File Offset: 0x00063CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComposeLimitNumUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00065AED File Offset: 0x00063CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeLimitNumUpdateNotify()
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00065AF5 File Offset: 0x00063CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeLimitNumUpdateNotify(ComposeLimitNumUpdateNotify other) : this()
		{
			this.aLONOHKNCHC_ = ((other.aLONOHKNCHC_ != null) ? other.aLONOHKNCHC_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00065B2A File Offset: 0x00063D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeLimitNumUpdateNotify Clone()
		{
			return new ComposeLimitNumUpdateNotify(this);
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x00065B32 File Offset: 0x00063D32
		// (set) Token: 0x060023D7 RID: 9175 RVA: 0x00065B3A File Offset: 0x00063D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KCEAJGBFCGL ALONOHKNCHC
		{
			get
			{
				return this.aLONOHKNCHC_;
			}
			set
			{
				this.aLONOHKNCHC_ = value;
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00065B43 File Offset: 0x00063D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComposeLimitNumUpdateNotify);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00065B51 File Offset: 0x00063D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComposeLimitNumUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ALONOHKNCHC, other.ALONOHKNCHC) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00065B84 File Offset: 0x00063D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.aLONOHKNCHC_ != null)
			{
				num ^= this.ALONOHKNCHC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00065BC0 File Offset: 0x00063DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00065BC8 File Offset: 0x00063DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00065BD1 File Offset: 0x00063DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.aLONOHKNCHC_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.ALONOHKNCHC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00065C04 File Offset: 0x00063E04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.aLONOHKNCHC_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ALONOHKNCHC);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00065C44 File Offset: 0x00063E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComposeLimitNumUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.aLONOHKNCHC_ != null)
			{
				if (this.aLONOHKNCHC_ == null)
				{
					this.ALONOHKNCHC = new KCEAJGBFCGL();
				}
				this.ALONOHKNCHC.MergeFrom(other.ALONOHKNCHC);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00065C98 File Offset: 0x00063E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00065CA4 File Offset: 0x00063EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.aLONOHKNCHC_ == null)
					{
						this.ALONOHKNCHC = new KCEAJGBFCGL();
					}
					input.ReadMessage(this.ALONOHKNCHC);
				}
			}
		}

		// Token: 0x04000EB1 RID: 3761
		private static readonly MessageParser<ComposeLimitNumUpdateNotify> _parser = new MessageParser<ComposeLimitNumUpdateNotify>(() => new ComposeLimitNumUpdateNotify());

		// Token: 0x04000EB2 RID: 3762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EB3 RID: 3763
		public const int ALONOHKNCHCFieldNumber = 4;

		// Token: 0x04000EB4 RID: 3764
		private KCEAJGBFCGL aLONOHKNCHC_;
	}
}
