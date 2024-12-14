using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020013AB RID: 5035
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TriggerVoiceCsReq : IMessage<TriggerVoiceCsReq>, IMessage, IEquatable<TriggerVoiceCsReq>, IDeepCloneable<TriggerVoiceCsReq>, IBufferMessage
	{
		// Token: 0x17003F1E RID: 16158
		// (get) Token: 0x0600E0A7 RID: 57511 RVA: 0x00256341 File Offset: 0x00254541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TriggerVoiceCsReq> Parser
		{
			get
			{
				return TriggerVoiceCsReq._parser;
			}
		}

		// Token: 0x17003F1F RID: 16159
		// (get) Token: 0x0600E0A8 RID: 57512 RVA: 0x00256348 File Offset: 0x00254548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TriggerVoiceCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003F20 RID: 16160
		// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x0025635A File Offset: 0x0025455A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TriggerVoiceCsReq.Descriptor;
			}
		}

		// Token: 0x0600E0AA RID: 57514 RVA: 0x00256361 File Offset: 0x00254561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerVoiceCsReq()
		{
		}

		// Token: 0x0600E0AB RID: 57515 RVA: 0x00256374 File Offset: 0x00254574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerVoiceCsReq(TriggerVoiceCsReq other) : this()
		{
			this.gNACMEEJKLI_ = other.gNACMEEJKLI_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0AC RID: 57516 RVA: 0x0025639E File Offset: 0x0025459E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TriggerVoiceCsReq Clone()
		{
			return new TriggerVoiceCsReq(this);
		}

		// Token: 0x17003F21 RID: 16161
		// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x002563A6 File Offset: 0x002545A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PFFIAODDKJH> GNACMEEJKLI
		{
			get
			{
				return this.gNACMEEJKLI_;
			}
		}

		// Token: 0x0600E0AE RID: 57518 RVA: 0x002563AE File Offset: 0x002545AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TriggerVoiceCsReq);
		}

		// Token: 0x0600E0AF RID: 57519 RVA: 0x002563BC File Offset: 0x002545BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TriggerVoiceCsReq other)
		{
			return other != null && (other == this || (this.gNACMEEJKLI_.Equals(other.gNACMEEJKLI_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0B0 RID: 57520 RVA: 0x002563F0 File Offset: 0x002545F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gNACMEEJKLI_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0B1 RID: 57521 RVA: 0x00256424 File Offset: 0x00254624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600E0B2 RID: 57522 RVA: 0x0025642C File Offset: 0x0025462C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x00256435 File Offset: 0x00254635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gNACMEEJKLI_.WriteTo(ref output, TriggerVoiceCsReq._repeated_gNACMEEJKLI_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x0025645C File Offset: 0x0025465C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gNACMEEJKLI_.CalculateSize(TriggerVoiceCsReq._repeated_gNACMEEJKLI_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0B5 RID: 57525 RVA: 0x00256495 File Offset: 0x00254695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TriggerVoiceCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.gNACMEEJKLI_.Add(other.gNACMEEJKLI_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0B6 RID: 57526 RVA: 0x002564C3 File Offset: 0x002546C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0B7 RID: 57527 RVA: 0x002564CC File Offset: 0x002546CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gNACMEEJKLI_.AddEntriesFrom(ref input, TriggerVoiceCsReq._repeated_gNACMEEJKLI_codec);
				}
			}
		}

		// Token: 0x04005975 RID: 22901
		private static readonly MessageParser<TriggerVoiceCsReq> _parser = new MessageParser<TriggerVoiceCsReq>(() => new TriggerVoiceCsReq());

		// Token: 0x04005976 RID: 22902
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005977 RID: 22903
		public const int GNACMEEJKLIFieldNumber = 7;

		// Token: 0x04005978 RID: 22904
		private static readonly FieldCodec<PFFIAODDKJH> _repeated_gNACMEEJKLI_codec = FieldCodec.ForMessage<PFFIAODDKJH>(58U, PFFIAODDKJH.Parser);

		// Token: 0x04005979 RID: 22905
		private readonly RepeatedField<PFFIAODDKJH> gNACMEEJKLI_ = new RepeatedField<PFFIAODDKJH>();
	}
}
