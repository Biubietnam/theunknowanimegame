using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012ED RID: 4845
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMultipleActivityExpeditionRewardScRsp : IMessage<TakeMultipleActivityExpeditionRewardScRsp>, IMessage, IEquatable<TakeMultipleActivityExpeditionRewardScRsp>, IDeepCloneable<TakeMultipleActivityExpeditionRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003CC5 RID: 15557
		// (get) Token: 0x0600D82F RID: 55343 RVA: 0x002407FB File Offset: 0x0023E9FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMultipleActivityExpeditionRewardScRsp> Parser
		{
			get
			{
				return TakeMultipleActivityExpeditionRewardScRsp._parser;
			}
		}

		// Token: 0x17003CC6 RID: 15558
		// (get) Token: 0x0600D830 RID: 55344 RVA: 0x00240802 File Offset: 0x0023EA02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMultipleActivityExpeditionRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CC7 RID: 15559
		// (get) Token: 0x0600D831 RID: 55345 RVA: 0x00240814 File Offset: 0x0023EA14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMultipleActivityExpeditionRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D832 RID: 55346 RVA: 0x0024081B File Offset: 0x0023EA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleActivityExpeditionRewardScRsp()
		{
		}

		// Token: 0x0600D833 RID: 55347 RVA: 0x0024082E File Offset: 0x0023EA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleActivityExpeditionRewardScRsp(TakeMultipleActivityExpeditionRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.ePOFPDIKDOF_ = other.ePOFPDIKDOF_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D834 RID: 55348 RVA: 0x00240864 File Offset: 0x0023EA64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleActivityExpeditionRewardScRsp Clone()
		{
			return new TakeMultipleActivityExpeditionRewardScRsp(this);
		}

		// Token: 0x17003CC8 RID: 15560
		// (get) Token: 0x0600D835 RID: 55349 RVA: 0x0024086C File Offset: 0x0023EA6C
		// (set) Token: 0x0600D836 RID: 55350 RVA: 0x00240874 File Offset: 0x0023EA74
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

		// Token: 0x17003CC9 RID: 15561
		// (get) Token: 0x0600D837 RID: 55351 RVA: 0x0024087D File Offset: 0x0023EA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IJNLPBIHKIF> EPOFPDIKDOF
		{
			get
			{
				return this.ePOFPDIKDOF_;
			}
		}

		// Token: 0x0600D838 RID: 55352 RVA: 0x00240885 File Offset: 0x0023EA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMultipleActivityExpeditionRewardScRsp);
		}

		// Token: 0x0600D839 RID: 55353 RVA: 0x00240894 File Offset: 0x0023EA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMultipleActivityExpeditionRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && this.ePOFPDIKDOF_.Equals(other.ePOFPDIKDOF_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D83A RID: 55354 RVA: 0x002408E4 File Offset: 0x0023EAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			num ^= this.ePOFPDIKDOF_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D83B RID: 55355 RVA: 0x00240931 File Offset: 0x0023EB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D83C RID: 55356 RVA: 0x00240939 File Offset: 0x0023EB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D83D RID: 55357 RVA: 0x00240944 File Offset: 0x0023EB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ePOFPDIKDOF_.WriteTo(ref output, TakeMultipleActivityExpeditionRewardScRsp._repeated_ePOFPDIKDOF_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D83E RID: 55358 RVA: 0x00240994 File Offset: 0x0023EB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			num += this.ePOFPDIKDOF_.CalculateSize(TakeMultipleActivityExpeditionRewardScRsp._repeated_ePOFPDIKDOF_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D83F RID: 55359 RVA: 0x002409E8 File Offset: 0x0023EBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMultipleActivityExpeditionRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this.ePOFPDIKDOF_.Add(other.ePOFPDIKDOF_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D840 RID: 55360 RVA: 0x00240A35 File Offset: 0x0023EC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D841 RID: 55361 RVA: 0x00240A40 File Offset: 0x0023EC40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 26U)
				{
					if (num != 72U)
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
					this.ePOFPDIKDOF_.AddEntriesFrom(ref input, TakeMultipleActivityExpeditionRewardScRsp._repeated_ePOFPDIKDOF_codec);
				}
			}
		}

		// Token: 0x04005641 RID: 22081
		private static readonly MessageParser<TakeMultipleActivityExpeditionRewardScRsp> _parser = new MessageParser<TakeMultipleActivityExpeditionRewardScRsp>(() => new TakeMultipleActivityExpeditionRewardScRsp());

		// Token: 0x04005642 RID: 22082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005643 RID: 22083
		public const int RetcodeFieldNumber = 9;

		// Token: 0x04005644 RID: 22084
		private uint retcode_;

		// Token: 0x04005645 RID: 22085
		public const int EPOFPDIKDOFFieldNumber = 3;

		// Token: 0x04005646 RID: 22086
		private static readonly FieldCodec<IJNLPBIHKIF> _repeated_ePOFPDIKDOF_codec = FieldCodec.ForMessage<IJNLPBIHKIF>(26U, IJNLPBIHKIF.Parser);

		// Token: 0x04005647 RID: 22087
		private readonly RepeatedField<IJNLPBIHKIF> ePOFPDIKDOF_ = new RepeatedField<IJNLPBIHKIF>();
	}
}
