using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B81 RID: 2945
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MonopolyTakePhaseRewardScRsp : IMessage<MonopolyTakePhaseRewardScRsp>, IMessage, IEquatable<MonopolyTakePhaseRewardScRsp>, IDeepCloneable<MonopolyTakePhaseRewardScRsp>, IBufferMessage
	{
		// Token: 0x1700247C RID: 9340
		// (get) Token: 0x06008251 RID: 33361 RVA: 0x001572DB File Offset: 0x001554DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MonopolyTakePhaseRewardScRsp> Parser
		{
			get
			{
				return MonopolyTakePhaseRewardScRsp._parser;
			}
		}

		// Token: 0x1700247D RID: 9341
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x001572E2 File Offset: 0x001554E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MonopolyTakePhaseRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700247E RID: 9342
		// (get) Token: 0x06008253 RID: 33363 RVA: 0x001572F4 File Offset: 0x001554F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonopolyTakePhaseRewardScRsp.Descriptor;
			}
		}

		// Token: 0x06008254 RID: 33364 RVA: 0x001572FB File Offset: 0x001554FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakePhaseRewardScRsp()
		{
		}

		// Token: 0x06008255 RID: 33365 RVA: 0x00157310 File Offset: 0x00155510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakePhaseRewardScRsp(MonopolyTakePhaseRewardScRsp other) : this()
		{
			this.rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
			this.hAHPDCCHMHB_ = other.hAHPDCCHMHB_.Clone();
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x0015736D File Offset: 0x0015556D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonopolyTakePhaseRewardScRsp Clone()
		{
			return new MonopolyTakePhaseRewardScRsp(this);
		}

		// Token: 0x1700247F RID: 9343
		// (get) Token: 0x06008257 RID: 33367 RVA: 0x00157375 File Offset: 0x00155575
		// (set) Token: 0x06008258 RID: 33368 RVA: 0x0015737D File Offset: 0x0015557D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList RewardList
		{
			get
			{
				return this.rewardList_;
			}
			set
			{
				this.rewardList_ = value;
			}
		}

		// Token: 0x17002480 RID: 9344
		// (get) Token: 0x06008259 RID: 33369 RVA: 0x00157386 File Offset: 0x00155586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> HAHPDCCHMHB
		{
			get
			{
				return this.hAHPDCCHMHB_;
			}
		}

		// Token: 0x17002481 RID: 9345
		// (get) Token: 0x0600825A RID: 33370 RVA: 0x0015738E File Offset: 0x0015558E
		// (set) Token: 0x0600825B RID: 33371 RVA: 0x00157396 File Offset: 0x00155596
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

		// Token: 0x0600825C RID: 33372 RVA: 0x0015739F File Offset: 0x0015559F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonopolyTakePhaseRewardScRsp);
		}

		// Token: 0x0600825D RID: 33373 RVA: 0x001573B0 File Offset: 0x001555B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonopolyTakePhaseRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RewardList, other.RewardList) && this.hAHPDCCHMHB_.Equals(other.hAHPDCCHMHB_) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600825E RID: 33374 RVA: 0x00157414 File Offset: 0x00155614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardList_ != null)
			{
				num ^= this.RewardList.GetHashCode();
			}
			num ^= this.hAHPDCCHMHB_.GetHashCode();
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

		// Token: 0x0600825F RID: 33375 RVA: 0x00157477 File Offset: 0x00155677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008260 RID: 33376 RVA: 0x0015747F File Offset: 0x0015567F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008261 RID: 33377 RVA: 0x00157488 File Offset: 0x00155688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.hAHPDCCHMHB_.WriteTo(ref output, MonopolyTakePhaseRewardScRsp._repeated_hAHPDCCHMHB_codec);
			if (this.rewardList_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RewardList);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x001574F4 File Offset: 0x001556F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardList);
			}
			num += this.hAHPDCCHMHB_.CalculateSize(MonopolyTakePhaseRewardScRsp._repeated_hAHPDCCHMHB_codec);
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

		// Token: 0x06008263 RID: 33379 RVA: 0x00157560 File Offset: 0x00155760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonopolyTakePhaseRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardList_ != null)
			{
				if (this.rewardList_ == null)
				{
					this.RewardList = new ItemList();
				}
				this.RewardList.MergeFrom(other.RewardList);
			}
			this.hAHPDCCHMHB_.Add(other.hAHPDCCHMHB_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x001575D9 File Offset: 0x001557D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x001575E4 File Offset: 0x001557E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.hAHPDCCHMHB_.AddEntriesFrom(ref input, MonopolyTakePhaseRewardScRsp._repeated_hAHPDCCHMHB_codec);
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						if (this.rewardList_ == null)
						{
							this.RewardList = new ItemList();
						}
						input.ReadMessage(this.RewardList);
						continue;
					}
					if (num == 120U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040031B0 RID: 12720
		private static readonly MessageParser<MonopolyTakePhaseRewardScRsp> _parser = new MessageParser<MonopolyTakePhaseRewardScRsp>(() => new MonopolyTakePhaseRewardScRsp());

		// Token: 0x040031B1 RID: 12721
		private UnknownFieldSet _unknownFields;

		// Token: 0x040031B2 RID: 12722
		public const int RewardListFieldNumber = 5;

		// Token: 0x040031B3 RID: 12723
		private ItemList rewardList_;

		// Token: 0x040031B4 RID: 12724
		public const int HAHPDCCHMHBFieldNumber = 2;

		// Token: 0x040031B5 RID: 12725
		private static readonly FieldCodec<uint> _repeated_hAHPDCCHMHB_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x040031B6 RID: 12726
		private readonly RepeatedField<uint> hAHPDCCHMHB_ = new RepeatedField<uint>();

		// Token: 0x040031B7 RID: 12727
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040031B8 RID: 12728
		private uint retcode_;
	}
}
