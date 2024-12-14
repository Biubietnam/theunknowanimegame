using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B09 RID: 2825
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyActionResultScNotify : IMessage<MonopolyActionResultScNotify>, IMessage, IEquatable<MonopolyActionResultScNotify>, IDeepCloneable<MonopolyActionResultScNotify>, IBufferMessage
	{
		// Token: 0x1700231F RID: 8991
		// (get) Token: 0x06007D10 RID: 32016 RVA: 0x0014B3E5 File Offset: 0x001495E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyActionResultScNotify> Parser
		{
			get
			{
				return MonopolyActionResultScNotify._parser;
			}
		}

		// Token: 0x17002320 RID: 8992
		// (get) Token: 0x06007D11 RID: 32017 RVA: 0x0014B3EC File Offset: 0x001495EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyActionResultScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002321 RID: 8993
		// (get) Token: 0x06007D12 RID: 32018 RVA: 0x0014B3FE File Offset: 0x001495FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyActionResultScNotify.Descriptor;
			}
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x0014B405 File Offset: 0x00149605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyActionResultScNotify()
		{
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x0014B418 File Offset: 0x00149618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyActionResultScNotify(MonopolyActionResultScNotify other) : this()
		{
			this.pJGKCBMEKIK_ = other.pJGKCBMEKIK_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D15 RID: 32021 RVA: 0x0014B442 File Offset: 0x00149642
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyActionResultScNotify Clone()
		{
			return new MonopolyActionResultScNotify(this);
		}

		// Token: 0x17002322 RID: 8994
		// (get) Token: 0x06007D16 RID: 32022 RVA: 0x0014B44A File Offset: 0x0014964A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MonopolyActionResult> PJGKCBMEKIK
		{
			get
			{
				return this.pJGKCBMEKIK_;
			}
		}

		// Token: 0x06007D17 RID: 32023 RVA: 0x0014B452 File Offset: 0x00149652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyActionResultScNotify);
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x0014B460 File Offset: 0x00149660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyActionResultScNotify other)
		{
			return other != null && (other == this || (this.pJGKCBMEKIK_.Equals(other.pJGKCBMEKIK_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x0014B494 File Offset: 0x00149694
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pJGKCBMEKIK_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x0014B4C8 File Offset: 0x001496C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007D1B RID: 32027 RVA: 0x0014B4D0 File Offset: 0x001496D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x0014B4D9 File Offset: 0x001496D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pJGKCBMEKIK_.WriteTo(ref output, MonopolyActionResultScNotify._repeated_pJGKCBMEKIK_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x0014B500 File Offset: 0x00149700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pJGKCBMEKIK_.CalculateSize(MonopolyActionResultScNotify._repeated_pJGKCBMEKIK_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x0014B539 File Offset: 0x00149739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyActionResultScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.pJGKCBMEKIK_.Add(other.pJGKCBMEKIK_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x0014B567 File Offset: 0x00149767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x0014B570 File Offset: 0x00149770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.pJGKCBMEKIK_.AddEntriesFrom(ref input, MonopolyActionResultScNotify._repeated_pJGKCBMEKIK_codec);
				}
			}
		}

		// Token: 0x04003015 RID: 12309
		private static readonly MessageParser<MonopolyActionResultScNotify> _parser = new MessageParser<MonopolyActionResultScNotify>(() => new MonopolyActionResultScNotify());

		// Token: 0x04003016 RID: 12310
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003017 RID: 12311
		public const int PJGKCBMEKIKFieldNumber = 2;

		// Token: 0x04003018 RID: 12312
		private static readonly FieldCodec<MonopolyActionResult> _repeated_pJGKCBMEKIK_codec = FieldCodec.ForMessage<MonopolyActionResult>(18U, MonopolyActionResult.Parser);

		// Token: 0x04003019 RID: 12313
		private readonly RepeatedField<MonopolyActionResult> pJGKCBMEKIK_ = new RepeatedField<MonopolyActionResult>();
	}
}
