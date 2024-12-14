using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200125B RID: 4699
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingTurnActionScRsp : IMessage<SwordTrainingTurnActionScRsp>, IMessage, IEquatable<SwordTrainingTurnActionScRsp>, IDeepCloneable<SwordTrainingTurnActionScRsp>, IBufferMessage
	{
		// Token: 0x17003B13 RID: 15123
		// (get) Token: 0x0600D1CE RID: 53710 RVA: 0x00230FD9 File Offset: 0x0022F1D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingTurnActionScRsp> Parser
		{
			get
			{
				return SwordTrainingTurnActionScRsp._parser;
			}
		}

		// Token: 0x17003B14 RID: 15124
		// (get) Token: 0x0600D1CF RID: 53711 RVA: 0x00230FE0 File Offset: 0x0022F1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingTurnActionScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B15 RID: 15125
		// (get) Token: 0x0600D1D0 RID: 53712 RVA: 0x00230FF2 File Offset: 0x0022F1F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingTurnActionScRsp.Descriptor;
			}
		}

		// Token: 0x0600D1D1 RID: 53713 RVA: 0x00230FF9 File Offset: 0x0022F1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingTurnActionScRsp()
		{
		}

		// Token: 0x0600D1D2 RID: 53714 RVA: 0x0023100C File Offset: 0x0022F20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingTurnActionScRsp(SwordTrainingTurnActionScRsp other) : this()
		{
			this.pMIIDGMPMFN_ = other.pMIIDGMPMFN_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D1D3 RID: 53715 RVA: 0x00231042 File Offset: 0x0022F242
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingTurnActionScRsp Clone()
		{
			return new SwordTrainingTurnActionScRsp(this);
		}

		// Token: 0x17003B16 RID: 15126
		// (get) Token: 0x0600D1D4 RID: 53716 RVA: 0x0023104A File Offset: 0x0022F24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> PMIIDGMPMFN
		{
			get
			{
				return this.pMIIDGMPMFN_;
			}
		}

		// Token: 0x17003B17 RID: 15127
		// (get) Token: 0x0600D1D5 RID: 53717 RVA: 0x00231052 File Offset: 0x0022F252
		// (set) Token: 0x0600D1D6 RID: 53718 RVA: 0x0023105A File Offset: 0x0022F25A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600D1D7 RID: 53719 RVA: 0x00231063 File Offset: 0x0022F263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingTurnActionScRsp);
		}

		// Token: 0x0600D1D8 RID: 53720 RVA: 0x00231074 File Offset: 0x0022F274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingTurnActionScRsp other)
		{
			return other != null && (other == this || (this.pMIIDGMPMFN_.Equals(other.pMIIDGMPMFN_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x002310C4 File Offset: 0x0022F2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.pMIIDGMPMFN_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x00231111 File Offset: 0x0022F311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x00231119 File Offset: 0x0022F319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x00231124 File Offset: 0x0022F324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.pMIIDGMPMFN_.WriteTo(ref output, SwordTrainingTurnActionScRsp._repeated_pMIIDGMPMFN_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x00231174 File Offset: 0x0022F374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.pMIIDGMPMFN_.CalculateSize(SwordTrainingTurnActionScRsp._repeated_pMIIDGMPMFN_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x002311C8 File Offset: 0x0022F3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingTurnActionScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.pMIIDGMPMFN_.Add(other.pMIIDGMPMFN_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x00231215 File Offset: 0x0022F415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x00231220 File Offset: 0x0022F420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U && num != 74U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.pMIIDGMPMFN_.AddEntriesFrom(ref input, SwordTrainingTurnActionScRsp._repeated_pMIIDGMPMFN_codec);
				}
			}
		}

		// Token: 0x04005425 RID: 21541
		private static readonly MessageParser<SwordTrainingTurnActionScRsp> _parser = new MessageParser<SwordTrainingTurnActionScRsp>(() => new SwordTrainingTurnActionScRsp());

		// Token: 0x04005426 RID: 21542
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005427 RID: 21543
		public const int PMIIDGMPMFNFieldNumber = 9;

		// Token: 0x04005428 RID: 21544
		private static readonly FieldCodec<uint> _repeated_pMIIDGMPMFN_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x04005429 RID: 21545
		private readonly RepeatedField<uint> pMIIDGMPMFN_ = new RepeatedField<uint>();

		// Token: 0x0400542A RID: 21546
		public const int RetcodeFieldNumber = 13;

		// Token: 0x0400542B RID: 21547
		private uint retcode_;
	}
}
