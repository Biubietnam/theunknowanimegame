using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200122F RID: 4655
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingGameSyncChangeScNotify : IMessage<SwordTrainingGameSyncChangeScNotify>, IMessage, IEquatable<SwordTrainingGameSyncChangeScNotify>, IDeepCloneable<SwordTrainingGameSyncChangeScNotify>, IBufferMessage
	{
		// Token: 0x17003AA0 RID: 15008
		// (get) Token: 0x0600CFF9 RID: 53241 RVA: 0x0022D469 File Offset: 0x0022B669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingGameSyncChangeScNotify> Parser
		{
			get
			{
				return SwordTrainingGameSyncChangeScNotify._parser;
			}
		}

		// Token: 0x17003AA1 RID: 15009
		// (get) Token: 0x0600CFFA RID: 53242 RVA: 0x0022D470 File Offset: 0x0022B670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingGameSyncChangeScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AA2 RID: 15010
		// (get) Token: 0x0600CFFB RID: 53243 RVA: 0x0022D482 File Offset: 0x0022B682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingGameSyncChangeScNotify.Descriptor;
			}
		}

		// Token: 0x0600CFFC RID: 53244 RVA: 0x0022D489 File Offset: 0x0022B689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGameSyncChangeScNotify()
		{
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x0022D49C File Offset: 0x0022B69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGameSyncChangeScNotify(SwordTrainingGameSyncChangeScNotify other) : this()
		{
			this.hNLFBMPHEIL_ = other.hNLFBMPHEIL_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CFFE RID: 53246 RVA: 0x0022D4C6 File Offset: 0x0022B6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingGameSyncChangeScNotify Clone()
		{
			return new SwordTrainingGameSyncChangeScNotify(this);
		}

		// Token: 0x17003AA3 RID: 15011
		// (get) Token: 0x0600CFFF RID: 53247 RVA: 0x0022D4CE File Offset: 0x0022B6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PNPLHHNBADF> HNLFBMPHEIL
		{
			get
			{
				return this.hNLFBMPHEIL_;
			}
		}

		// Token: 0x0600D000 RID: 53248 RVA: 0x0022D4D6 File Offset: 0x0022B6D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingGameSyncChangeScNotify);
		}

		// Token: 0x0600D001 RID: 53249 RVA: 0x0022D4E4 File Offset: 0x0022B6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingGameSyncChangeScNotify other)
		{
			return other != null && (other == this || (this.hNLFBMPHEIL_.Equals(other.hNLFBMPHEIL_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D002 RID: 53250 RVA: 0x0022D518 File Offset: 0x0022B718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.hNLFBMPHEIL_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D003 RID: 53251 RVA: 0x0022D54C File Offset: 0x0022B74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D004 RID: 53252 RVA: 0x0022D554 File Offset: 0x0022B754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D005 RID: 53253 RVA: 0x0022D55D File Offset: 0x0022B75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hNLFBMPHEIL_.WriteTo(ref output, SwordTrainingGameSyncChangeScNotify._repeated_hNLFBMPHEIL_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D006 RID: 53254 RVA: 0x0022D584 File Offset: 0x0022B784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.hNLFBMPHEIL_.CalculateSize(SwordTrainingGameSyncChangeScNotify._repeated_hNLFBMPHEIL_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D007 RID: 53255 RVA: 0x0022D5BD File Offset: 0x0022B7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingGameSyncChangeScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.hNLFBMPHEIL_.Add(other.hNLFBMPHEIL_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D008 RID: 53256 RVA: 0x0022D5EB File Offset: 0x0022B7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D009 RID: 53257 RVA: 0x0022D5F4 File Offset: 0x0022B7F4
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
					this.hNLFBMPHEIL_.AddEntriesFrom(ref input, SwordTrainingGameSyncChangeScNotify._repeated_hNLFBMPHEIL_codec);
				}
			}
		}

		// Token: 0x040053AA RID: 21418
		private static readonly MessageParser<SwordTrainingGameSyncChangeScNotify> _parser = new MessageParser<SwordTrainingGameSyncChangeScNotify>(() => new SwordTrainingGameSyncChangeScNotify());

		// Token: 0x040053AB RID: 21419
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053AC RID: 21420
		public const int HNLFBMPHEILFieldNumber = 4;

		// Token: 0x040053AD RID: 21421
		private static readonly FieldCodec<PNPLHHNBADF> _repeated_hNLFBMPHEIL_codec = FieldCodec.ForMessage<PNPLHHNBADF>(34U, PNPLHHNBADF.Parser);

		// Token: 0x040053AE RID: 21422
		private readonly RepeatedField<PNPLHHNBADF> hNLFBMPHEIL_ = new RepeatedField<PNPLHHNBADF>();
	}
}
