using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200031D RID: 797
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ComposeLimitNumCompleteNotify : IMessage<ComposeLimitNumCompleteNotify>, IMessage, IEquatable<ComposeLimitNumCompleteNotify>, IDeepCloneable<ComposeLimitNumCompleteNotify>, IBufferMessage
	{
		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x060023BC RID: 9148 RVA: 0x00065851 File Offset: 0x00063A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ComposeLimitNumCompleteNotify> Parser
		{
			get
			{
				return ComposeLimitNumCompleteNotify._parser;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x060023BD RID: 9149 RVA: 0x00065858 File Offset: 0x00063A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ComposeLimitNumCompleteNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x060023BE RID: 9150 RVA: 0x0006586A File Offset: 0x00063A6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ComposeLimitNumCompleteNotify.Descriptor;
			}
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00065871 File Offset: 0x00063A71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeLimitNumCompleteNotify()
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00065884 File Offset: 0x00063A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeLimitNumCompleteNotify(ComposeLimitNumCompleteNotify other) : this()
		{
			this.aAEILANAMHE_ = other.aAEILANAMHE_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x000658AE File Offset: 0x00063AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ComposeLimitNumCompleteNotify Clone()
		{
			return new ComposeLimitNumCompleteNotify(this);
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x060023C2 RID: 9154 RVA: 0x000658B6 File Offset: 0x00063AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KCEAJGBFCGL> AAEILANAMHE
		{
			get
			{
				return this.aAEILANAMHE_;
			}
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x000658BE File Offset: 0x00063ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ComposeLimitNumCompleteNotify);
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x000658CC File Offset: 0x00063ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ComposeLimitNumCompleteNotify other)
		{
			return other != null && (other == this || (this.aAEILANAMHE_.Equals(other.aAEILANAMHE_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00065900 File Offset: 0x00063B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.aAEILANAMHE_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00065934 File Offset: 0x00063B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0006593C File Offset: 0x00063B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00065945 File Offset: 0x00063B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.aAEILANAMHE_.WriteTo(ref output, ComposeLimitNumCompleteNotify._repeated_aAEILANAMHE_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0006596C File Offset: 0x00063B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.aAEILANAMHE_.CalculateSize(ComposeLimitNumCompleteNotify._repeated_aAEILANAMHE_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x000659A5 File Offset: 0x00063BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ComposeLimitNumCompleteNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.aAEILANAMHE_.Add(other.aAEILANAMHE_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x000659D3 File Offset: 0x00063BD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000659DC File Offset: 0x00063BDC
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
					this.aAEILANAMHE_.AddEntriesFrom(ref input, ComposeLimitNumCompleteNotify._repeated_aAEILANAMHE_codec);
				}
			}
		}

		// Token: 0x04000EAB RID: 3755
		private static readonly MessageParser<ComposeLimitNumCompleteNotify> _parser = new MessageParser<ComposeLimitNumCompleteNotify>(() => new ComposeLimitNumCompleteNotify());

		// Token: 0x04000EAC RID: 3756
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EAD RID: 3757
		public const int AAEILANAMHEFieldNumber = 10;

		// Token: 0x04000EAE RID: 3758
		private static readonly FieldCodec<KCEAJGBFCGL> _repeated_aAEILANAMHE_codec = FieldCodec.ForMessage<KCEAJGBFCGL>(82U, KCEAJGBFCGL.Parser);

		// Token: 0x04000EAF RID: 3759
		private readonly RepeatedField<KCEAJGBFCGL> aAEILANAMHE_ = new RepeatedField<KCEAJGBFCGL>();
	}
}
