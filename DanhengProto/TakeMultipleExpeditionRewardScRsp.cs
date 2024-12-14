using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012F1 RID: 4849
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeMultipleExpeditionRewardScRsp : IMessage<TakeMultipleExpeditionRewardScRsp>, IMessage, IEquatable<TakeMultipleExpeditionRewardScRsp>, IDeepCloneable<TakeMultipleExpeditionRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003CD0 RID: 15568
		// (get) Token: 0x0600D859 RID: 55385 RVA: 0x00240E0B File Offset: 0x0023F00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeMultipleExpeditionRewardScRsp> Parser
		{
			get
			{
				return TakeMultipleExpeditionRewardScRsp._parser;
			}
		}

		// Token: 0x17003CD1 RID: 15569
		// (get) Token: 0x0600D85A RID: 55386 RVA: 0x00240E12 File Offset: 0x0023F012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeMultipleExpeditionRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CD2 RID: 15570
		// (get) Token: 0x0600D85B RID: 55387 RVA: 0x00240E24 File Offset: 0x0023F024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeMultipleExpeditionRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D85C RID: 55388 RVA: 0x00240E2B File Offset: 0x0023F02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleExpeditionRewardScRsp()
		{
		}

		// Token: 0x0600D85D RID: 55389 RVA: 0x00240E54 File Offset: 0x0023F054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleExpeditionRewardScRsp(TakeMultipleExpeditionRewardScRsp other) : this()
		{
			this.eCLNNACMIJB_ = other.eCLNNACMIJB_.Clone();
			this.retcode_ = other.retcode_;
			this.kCGOBOKNMFH_ = ((other.kCGOBOKNMFH_ != null) ? other.kCGOBOKNMFH_.Clone() : null);
			this.pODBCPNBINN_ = other.pODBCPNBINN_.Clone();
			this.oIEMDIDMAEK_ = other.oIEMDIDMAEK_.Clone();
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D85E RID: 55390 RVA: 0x00240EEF File Offset: 0x0023F0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeMultipleExpeditionRewardScRsp Clone()
		{
			return new TakeMultipleExpeditionRewardScRsp(this);
		}

		// Token: 0x17003CD3 RID: 15571
		// (get) Token: 0x0600D85F RID: 55391 RVA: 0x00240EF7 File Offset: 0x0023F0F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> ECLNNACMIJB
		{
			get
			{
				return this.eCLNNACMIJB_;
			}
		}

		// Token: 0x17003CD4 RID: 15572
		// (get) Token: 0x0600D860 RID: 55392 RVA: 0x00240EFF File Offset: 0x0023F0FF
		// (set) Token: 0x0600D861 RID: 55393 RVA: 0x00240F07 File Offset: 0x0023F107
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

		// Token: 0x17003CD5 RID: 15573
		// (get) Token: 0x0600D862 RID: 55394 RVA: 0x00240F10 File Offset: 0x0023F110
		// (set) Token: 0x0600D863 RID: 55395 RVA: 0x00240F18 File Offset: 0x0023F118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemList KCGOBOKNMFH
		{
			get
			{
				return this.kCGOBOKNMFH_;
			}
			set
			{
				this.kCGOBOKNMFH_ = value;
			}
		}

		// Token: 0x17003CD6 RID: 15574
		// (get) Token: 0x0600D864 RID: 55396 RVA: 0x00240F21 File Offset: 0x0023F121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemList> PODBCPNBINN
		{
			get
			{
				return this.pODBCPNBINN_;
			}
		}

		// Token: 0x17003CD7 RID: 15575
		// (get) Token: 0x0600D865 RID: 55397 RVA: 0x00240F29 File Offset: 0x0023F129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemList> OIEMDIDMAEK
		{
			get
			{
				return this.oIEMDIDMAEK_;
			}
		}

		// Token: 0x17003CD8 RID: 15576
		// (get) Token: 0x0600D866 RID: 55398 RVA: 0x00240F31 File Offset: 0x0023F131
		// (set) Token: 0x0600D867 RID: 55399 RVA: 0x00240F39 File Offset: 0x0023F139
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

		// Token: 0x0600D868 RID: 55400 RVA: 0x00240F42 File Offset: 0x0023F142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeMultipleExpeditionRewardScRsp);
		}

		// Token: 0x0600D869 RID: 55401 RVA: 0x00240F50 File Offset: 0x0023F150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeMultipleExpeditionRewardScRsp other)
		{
			return other != null && (other == this || (this.eCLNNACMIJB_.Equals(other.eCLNNACMIJB_) && this.Retcode == other.Retcode && object.Equals(this.KCGOBOKNMFH, other.KCGOBOKNMFH) && this.pODBCPNBINN_.Equals(other.pODBCPNBINN_) && this.oIEMDIDMAEK_.Equals(other.oIEMDIDMAEK_) && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D86A RID: 55402 RVA: 0x00240FF4 File Offset: 0x0023F1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.eCLNNACMIJB_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.kCGOBOKNMFH_ != null)
			{
				num ^= this.KCGOBOKNMFH.GetHashCode();
			}
			num ^= this.pODBCPNBINN_.GetHashCode();
			num ^= this.oIEMDIDMAEK_.GetHashCode();
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D86B RID: 55403 RVA: 0x00241089 File Offset: 0x0023F289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D86C RID: 55404 RVA: 0x00241091 File Offset: 0x0023F291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x0024109C File Offset: 0x0023F29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.kCGOBOKNMFH_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.KCGOBOKNMFH);
			}
			this.oIEMDIDMAEK_.WriteTo(ref output, TakeMultipleExpeditionRewardScRsp._repeated_oIEMDIDMAEK_codec);
			if (this.reward_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Reward);
			}
			this.pODBCPNBINN_.WriteTo(ref output, TakeMultipleExpeditionRewardScRsp._repeated_pODBCPNBINN_codec);
			this.eCLNNACMIJB_.WriteTo(ref output, TakeMultipleExpeditionRewardScRsp._repeated_eCLNNACMIJB_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D86E RID: 55406 RVA: 0x00241144 File Offset: 0x0023F344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.eCLNNACMIJB_.CalculateSize(TakeMultipleExpeditionRewardScRsp._repeated_eCLNNACMIJB_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.kCGOBOKNMFH_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.KCGOBOKNMFH);
			}
			num += this.pODBCPNBINN_.CalculateSize(TakeMultipleExpeditionRewardScRsp._repeated_pODBCPNBINN_codec);
			num += this.oIEMDIDMAEK_.CalculateSize(TakeMultipleExpeditionRewardScRsp._repeated_oIEMDIDMAEK_codec);
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D86F RID: 55407 RVA: 0x002411EC File Offset: 0x0023F3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeMultipleExpeditionRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.eCLNNACMIJB_.Add(other.eCLNNACMIJB_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.kCGOBOKNMFH_ != null)
			{
				if (this.kCGOBOKNMFH_ == null)
				{
					this.KCGOBOKNMFH = new ItemList();
				}
				this.KCGOBOKNMFH.MergeFrom(other.KCGOBOKNMFH);
			}
			this.pODBCPNBINN_.Add(other.pODBCPNBINN_);
			this.oIEMDIDMAEK_.Add(other.oIEMDIDMAEK_);
			if (other.reward_ != null)
			{
				if (this.reward_ == null)
				{
					this.Reward = new ItemList();
				}
				this.Reward.MergeFrom(other.Reward);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D870 RID: 55408 RVA: 0x002412B3 File Offset: 0x0023F4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D871 RID: 55409 RVA: 0x002412BC File Offset: 0x0023F4BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num > 42U)
				{
					if (num <= 80U)
					{
						if (num == 58U)
						{
							this.pODBCPNBINN_.AddEntriesFrom(ref input, TakeMultipleExpeditionRewardScRsp._repeated_pODBCPNBINN_codec);
							continue;
						}
						if (num != 80U)
						{
							goto IL_42;
						}
					}
					else if (num != 82U)
					{
						if (num != 112U)
						{
							goto IL_42;
						}
						this.Retcode = input.ReadUInt32();
						continue;
					}
					this.eCLNNACMIJB_.AddEntriesFrom(ref input, TakeMultipleExpeditionRewardScRsp._repeated_eCLNNACMIJB_codec);
					continue;
				}
				if (num == 18U)
				{
					if (this.kCGOBOKNMFH_ == null)
					{
						this.KCGOBOKNMFH = new ItemList();
					}
					input.ReadMessage(this.KCGOBOKNMFH);
					continue;
				}
				if (num == 34U)
				{
					this.oIEMDIDMAEK_.AddEntriesFrom(ref input, TakeMultipleExpeditionRewardScRsp._repeated_oIEMDIDMAEK_codec);
					continue;
				}
				if (num == 42U)
				{
					if (this.reward_ == null)
					{
						this.Reward = new ItemList();
					}
					input.ReadMessage(this.Reward);
					continue;
				}
				IL_42:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400564F RID: 22095
		private static readonly MessageParser<TakeMultipleExpeditionRewardScRsp> _parser = new MessageParser<TakeMultipleExpeditionRewardScRsp>(() => new TakeMultipleExpeditionRewardScRsp());

		// Token: 0x04005650 RID: 22096
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005651 RID: 22097
		public const int ECLNNACMIJBFieldNumber = 10;

		// Token: 0x04005652 RID: 22098
		private static readonly FieldCodec<uint> _repeated_eCLNNACMIJB_codec = FieldCodec.ForUInt32(82U);

		// Token: 0x04005653 RID: 22099
		private readonly RepeatedField<uint> eCLNNACMIJB_ = new RepeatedField<uint>();

		// Token: 0x04005654 RID: 22100
		public const int RetcodeFieldNumber = 14;

		// Token: 0x04005655 RID: 22101
		private uint retcode_;

		// Token: 0x04005656 RID: 22102
		public const int KCGOBOKNMFHFieldNumber = 2;

		// Token: 0x04005657 RID: 22103
		private ItemList kCGOBOKNMFH_;

		// Token: 0x04005658 RID: 22104
		public const int PODBCPNBINNFieldNumber = 7;

		// Token: 0x04005659 RID: 22105
		private static readonly FieldCodec<ItemList> _repeated_pODBCPNBINN_codec = FieldCodec.ForMessage<ItemList>(58U, ItemList.Parser);

		// Token: 0x0400565A RID: 22106
		private readonly RepeatedField<ItemList> pODBCPNBINN_ = new RepeatedField<ItemList>();

		// Token: 0x0400565B RID: 22107
		public const int OIEMDIDMAEKFieldNumber = 4;

		// Token: 0x0400565C RID: 22108
		private static readonly FieldCodec<ItemList> _repeated_oIEMDIDMAEK_codec = FieldCodec.ForMessage<ItemList>(34U, ItemList.Parser);

		// Token: 0x0400565D RID: 22109
		private readonly RepeatedField<ItemList> oIEMDIDMAEK_ = new RepeatedField<ItemList>();

		// Token: 0x0400565E RID: 22110
		public const int RewardFieldNumber = 5;

		// Token: 0x0400565F RID: 22111
		private ItemList reward_;
	}
}
