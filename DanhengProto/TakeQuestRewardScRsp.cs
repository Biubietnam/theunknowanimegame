using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200131B RID: 4891
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeQuestRewardScRsp : IMessage<TakeQuestRewardScRsp>, IMessage, IEquatable<TakeQuestRewardScRsp>, IDeepCloneable<TakeQuestRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x0600DA36 RID: 55862 RVA: 0x00245415 File Offset: 0x00243615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeQuestRewardScRsp> Parser
		{
			get
			{
				return TakeQuestRewardScRsp._parser;
			}
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x0600DA37 RID: 55863 RVA: 0x0024541C File Offset: 0x0024361C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeQuestRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x0600DA38 RID: 55864 RVA: 0x0024542E File Offset: 0x0024362E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeQuestRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DA39 RID: 55865 RVA: 0x00245435 File Offset: 0x00243635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestRewardScRsp()
		{
		}

		// Token: 0x0600DA3A RID: 55866 RVA: 0x00245448 File Offset: 0x00243648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestRewardScRsp(TakeQuestRewardScRsp other) : this()
		{
			this.succQuestIdList_ = other.succQuestIdList_.Clone();
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA3B RID: 55867 RVA: 0x002454A5 File Offset: 0x002436A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeQuestRewardScRsp Clone()
		{
			return new TakeQuestRewardScRsp(this);
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x0600DA3C RID: 55868 RVA: 0x002454AD File Offset: 0x002436AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> SuccQuestIdList
		{
			get
			{
				return this.succQuestIdList_;
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600DA3D RID: 55869 RVA: 0x002454B5 File Offset: 0x002436B5
		// (set) Token: 0x0600DA3E RID: 55870 RVA: 0x002454BD File Offset: 0x002436BD
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

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600DA3F RID: 55871 RVA: 0x002454C6 File Offset: 0x002436C6
		// (set) Token: 0x0600DA40 RID: 55872 RVA: 0x002454CE File Offset: 0x002436CE
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

		// Token: 0x0600DA41 RID: 55873 RVA: 0x002454D7 File Offset: 0x002436D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeQuestRewardScRsp);
		}

		// Token: 0x0600DA42 RID: 55874 RVA: 0x002454E8 File Offset: 0x002436E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeQuestRewardScRsp other)
		{
			return other != null && (other == this || (this.succQuestIdList_.Equals(other.succQuestIdList_) && object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA43 RID: 55875 RVA: 0x0024554C File Offset: 0x0024374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.succQuestIdList_.GetHashCode();
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
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

		// Token: 0x0600DA44 RID: 55876 RVA: 0x002455AF File Offset: 0x002437AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DA45 RID: 55877 RVA: 0x002455B7 File Offset: 0x002437B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA46 RID: 55878 RVA: 0x002455C0 File Offset: 0x002437C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.succQuestIdList_.WriteTo(ref output, TakeQuestRewardScRsp._repeated_succQuestIdList_codec);
			if (this.reward_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Reward);
			}
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

		// Token: 0x0600DA47 RID: 55879 RVA: 0x0024562C File Offset: 0x0024382C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.succQuestIdList_.CalculateSize(TakeQuestRewardScRsp._repeated_succQuestIdList_codec);
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
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

		// Token: 0x0600DA48 RID: 55880 RVA: 0x00245698 File Offset: 0x00243898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeQuestRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.succQuestIdList_.Add(other.succQuestIdList_);
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x00245711 File Offset: 0x00243911
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x0024571C File Offset: 0x0024391C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 74U)
				{
					if (num == 72U || num == 74U)
					{
						this.succQuestIdList_.AddEntriesFrom(ref input, TakeQuestRewardScRsp._repeated_succQuestIdList_codec);
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040056E8 RID: 22248
		private static readonly MessageParser<TakeQuestRewardScRsp> _parser = new MessageParser<TakeQuestRewardScRsp>(() => new TakeQuestRewardScRsp());

		// Token: 0x040056E9 RID: 22249
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056EA RID: 22250
		public const int SuccQuestIdListFieldNumber = 9;

		// Token: 0x040056EB RID: 22251
		private static readonly FieldCodec<uint> _repeated_succQuestIdList_codec = FieldCodec.ForUInt32(74U);

		// Token: 0x040056EC RID: 22252
		private readonly RepeatedField<uint> succQuestIdList_ = new RepeatedField<uint>();

		// Token: 0x040056ED RID: 22253
		public const int RewardFieldNumber = 11;

		// Token: 0x040056EE RID: 22254
		private ItemList reward_;

		// Token: 0x040056EF RID: 22255
		public const int RetcodeFieldNumber = 13;

		// Token: 0x040056F0 RID: 22256
		private uint retcode_;
	}
}
