using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012BD RID: 4797
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeAssistRewardScRsp : IMessage<TakeAssistRewardScRsp>, IMessage, IEquatable<TakeAssistRewardScRsp>, IDeepCloneable<TakeAssistRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C28 RID: 15400
		// (get) Token: 0x0600D5F4 RID: 54772 RVA: 0x0023ACE7 File Offset: 0x00238EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeAssistRewardScRsp> Parser
		{
			get
			{
				return TakeAssistRewardScRsp._parser;
			}
		}

		// Token: 0x17003C29 RID: 15401
		// (get) Token: 0x0600D5F5 RID: 54773 RVA: 0x0023ACEE File Offset: 0x00238EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeAssistRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C2A RID: 15402
		// (get) Token: 0x0600D5F6 RID: 54774 RVA: 0x0023AD00 File Offset: 0x00238F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeAssistRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x0023AD07 File Offset: 0x00238F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAssistRewardScRsp()
		{
		}

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x0023AD1C File Offset: 0x00238F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAssistRewardScRsp(TakeAssistRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.nCKPJDHENMJ_ = other.nCKPJDHENMJ_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x0023AD79 File Offset: 0x00238F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAssistRewardScRsp Clone()
		{
			return new TakeAssistRewardScRsp(this);
		}

		// Token: 0x17003C2B RID: 15403
		// (get) Token: 0x0600D5FA RID: 54778 RVA: 0x0023AD81 File Offset: 0x00238F81
		// (set) Token: 0x0600D5FB RID: 54779 RVA: 0x0023AD89 File Offset: 0x00238F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList Reward
		{
			get
			{
				return this.reward_;
			}
			set
			{
				this.reward_ = value;
			}
		}

		// Token: 0x17003C2C RID: 15404
		// (get) Token: 0x0600D5FC RID: 54780 RVA: 0x0023AD92 File Offset: 0x00238F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ACPDAGMPCPC> NCKPJDHENMJ
		{
			get
			{
				return this.nCKPJDHENMJ_;
			}
		}

		// Token: 0x17003C2D RID: 15405
		// (get) Token: 0x0600D5FD RID: 54781 RVA: 0x0023AD9A File Offset: 0x00238F9A
		// (set) Token: 0x0600D5FE RID: 54782 RVA: 0x0023ADA2 File Offset: 0x00238FA2
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

		// Token: 0x0600D5FF RID: 54783 RVA: 0x0023ADAB File Offset: 0x00238FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeAssistRewardScRsp);
		}

		// Token: 0x0600D600 RID: 54784 RVA: 0x0023ADBC File Offset: 0x00238FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeAssistRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.nCKPJDHENMJ_.Equals(other.nCKPJDHENMJ_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D601 RID: 54785 RVA: 0x0023AE20 File Offset: 0x00239020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			num ^= this.nCKPJDHENMJ_.GetHashCode();
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

		// Token: 0x0600D602 RID: 54786 RVA: 0x0023AE83 File Offset: 0x00239083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D603 RID: 54787 RVA: 0x0023AE8B File Offset: 0x0023908B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D604 RID: 54788 RVA: 0x0023AE94 File Offset: 0x00239094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			this.nCKPJDHENMJ_.WriteTo(ref output, TakeAssistRewardScRsp._repeated_nCKPJDHENMJ_codec);
			if (this.reward_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D605 RID: 54789 RVA: 0x0023AF00 File Offset: 0x00239100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			num += this.nCKPJDHENMJ_.CalculateSize(TakeAssistRewardScRsp._repeated_nCKPJDHENMJ_codec);
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

		// Token: 0x0600D606 RID: 54790 RVA: 0x0023AF6C File Offset: 0x0023916C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeAssistRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this.nCKPJDHENMJ_.Add(other.nCKPJDHENMJ_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D607 RID: 54791 RVA: 0x0023AFE5 File Offset: 0x002391E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D608 RID: 54792 RVA: 0x0023AFF0 File Offset: 0x002391F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 42U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.reward_ == null)
							{
								this.Reward = new ItemList();
							}
							input.ReadMessage(this.Reward);
						}
					}
					else
					{
						this.nCKPJDHENMJ_.AddEntriesFrom(ref input, TakeAssistRewardScRsp._repeated_nCKPJDHENMJ_codec);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005578 RID: 21880
		private static readonly MessageParser<TakeAssistRewardScRsp> _parser = new MessageParser<TakeAssistRewardScRsp>(() => new TakeAssistRewardScRsp());

		// Token: 0x04005579 RID: 21881
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400557A RID: 21882
		public const int RewardFieldNumber = 14;

		// Token: 0x0400557B RID: 21883
		private ItemList reward_;

		// Token: 0x0400557C RID: 21884
		public const int NCKPJDHENMJFieldNumber = 5;

		// Token: 0x0400557D RID: 21885
		private static readonly FieldCodec<ACPDAGMPCPC> _repeated_nCKPJDHENMJ_codec = FieldCodec.ForMessage<ACPDAGMPCPC>(42U, ACPDAGMPCPC.Parser);

		// Token: 0x0400557E RID: 21886
		private readonly RepeatedField<ACPDAGMPCPC> nCKPJDHENMJ_ = new RepeatedField<ACPDAGMPCPC>();

		// Token: 0x0400557F RID: 21887
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04005580 RID: 21888
		private uint retcode_;
	}
}
