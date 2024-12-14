using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012B1 RID: 4785
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeAllApRewardScRsp : IMessage<TakeAllApRewardScRsp>, IMessage, IEquatable<TakeAllApRewardScRsp>, IDeepCloneable<TakeAllApRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0600D570 RID: 54640 RVA: 0x00239A01 File Offset: 0x00237C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeAllApRewardScRsp> Parser
		{
			get
			{
				return TakeAllApRewardScRsp._parser;
			}
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0600D571 RID: 54641 RVA: 0x00239A08 File Offset: 0x00237C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeAllApRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0600D572 RID: 54642 RVA: 0x00239A1A File Offset: 0x00237C1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeAllApRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D573 RID: 54643 RVA: 0x00239A21 File Offset: 0x00237C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllApRewardScRsp()
		{
		}

		// Token: 0x0600D574 RID: 54644 RVA: 0x00239A34 File Offset: 0x00237C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllApRewardScRsp(TakeAllApRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.kMIPGFOKNMM_ = other.kMIPGFOKNMM_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D575 RID: 54645 RVA: 0x00239A91 File Offset: 0x00237C91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllApRewardScRsp Clone()
		{
			return new TakeAllApRewardScRsp(this);
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0600D576 RID: 54646 RVA: 0x00239A99 File Offset: 0x00237C99
		// (set) Token: 0x0600D577 RID: 54647 RVA: 0x00239AA1 File Offset: 0x00237CA1
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

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x0600D578 RID: 54648 RVA: 0x00239AAA File Offset: 0x00237CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> KMIPGFOKNMM
		{
			get
			{
				return this.kMIPGFOKNMM_;
			}
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x0600D579 RID: 54649 RVA: 0x00239AB2 File Offset: 0x00237CB2
		// (set) Token: 0x0600D57A RID: 54650 RVA: 0x00239ABA File Offset: 0x00237CBA
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

		// Token: 0x0600D57B RID: 54651 RVA: 0x00239AC3 File Offset: 0x00237CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeAllApRewardScRsp);
		}

		// Token: 0x0600D57C RID: 54652 RVA: 0x00239AD4 File Offset: 0x00237CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeAllApRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.kMIPGFOKNMM_.Equals(other.kMIPGFOKNMM_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D57D RID: 54653 RVA: 0x00239B38 File Offset: 0x00237D38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			num ^= this.kMIPGFOKNMM_.GetHashCode();
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

		// Token: 0x0600D57E RID: 54654 RVA: 0x00239B9B File Offset: 0x00237D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x00239BA3 File Offset: 0x00237DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x00239BAC File Offset: 0x00237DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Reward);
			}
			this.kMIPGFOKNMM_.WriteTo(ref output, TakeAllApRewardScRsp._repeated_kMIPGFOKNMM_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D581 RID: 54657 RVA: 0x00239C18 File Offset: 0x00237E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			num += this.kMIPGFOKNMM_.CalculateSize(TakeAllApRewardScRsp._repeated_kMIPGFOKNMM_codec);
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

		// Token: 0x0600D582 RID: 54658 RVA: 0x00239C84 File Offset: 0x00237E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeAllApRewardScRsp other)
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
			this.kMIPGFOKNMM_.Add(other.kMIPGFOKNMM_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D583 RID: 54659 RVA: 0x00239CFD File Offset: 0x00237EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D584 RID: 54660 RVA: 0x00239D08 File Offset: 0x00237F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 56U)
				{
					if (num == 26U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 56U)
					{
						goto IL_52;
					}
				}
				else
				{
					if (num == 58U)
					{
						goto IL_52;
					}
					if (num == 96U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_52:
				this.kMIPGFOKNMM_.AddEntriesFrom(ref input, TakeAllApRewardScRsp._repeated_kMIPGFOKNMM_codec);
			}
		}

		// Token: 0x04005550 RID: 21840
		private static readonly MessageParser<TakeAllApRewardScRsp> _parser = new MessageParser<TakeAllApRewardScRsp>(() => new TakeAllApRewardScRsp());

		// Token: 0x04005551 RID: 21841
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005552 RID: 21842
		public const int RewardFieldNumber = 3;

		// Token: 0x04005553 RID: 21843
		private ItemList reward_;

		// Token: 0x04005554 RID: 21844
		public const int KMIPGFOKNMMFieldNumber = 7;

		// Token: 0x04005555 RID: 21845
		private static readonly FieldCodec<uint> _repeated_kMIPGFOKNMM_codec = FieldCodec.ForUInt32(58U);

		// Token: 0x04005556 RID: 21846
		private readonly RepeatedField<uint> kMIPGFOKNMM_ = new RepeatedField<uint>();

		// Token: 0x04005557 RID: 21847
		public const int RetcodeFieldNumber = 12;

		// Token: 0x04005558 RID: 21848
		private uint retcode_;
	}
}
