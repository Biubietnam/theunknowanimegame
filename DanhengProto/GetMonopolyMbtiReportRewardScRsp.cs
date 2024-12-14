using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000737 RID: 1847
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetMonopolyMbtiReportRewardScRsp : IMessage<GetMonopolyMbtiReportRewardScRsp>, IMessage, IEquatable<GetMonopolyMbtiReportRewardScRsp>, IDeepCloneable<GetMonopolyMbtiReportRewardScRsp>, IBufferMessage
	{
		// Token: 0x17001766 RID: 5990
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x000DE86B File Offset: 0x000DCA6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetMonopolyMbtiReportRewardScRsp> Parser
		{
			get
			{
				return GetMonopolyMbtiReportRewardScRsp._parser;
			}
		}

		// Token: 0x17001767 RID: 5991
		// (get) Token: 0x06005294 RID: 21140 RVA: 0x000DE872 File Offset: 0x000DCA72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetMonopolyMbtiReportRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001768 RID: 5992
		// (get) Token: 0x06005295 RID: 21141 RVA: 0x000DE884 File Offset: 0x000DCA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetMonopolyMbtiReportRewardScRsp.Descriptor;
			}
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x000DE88B File Offset: 0x000DCA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyMbtiReportRewardScRsp()
		{
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x000DE894 File Offset: 0x000DCA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyMbtiReportRewardScRsp(GetMonopolyMbtiReportRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rewardList_ = ((other.rewardList_ != null) ? other.rewardList_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x000DE8E0 File Offset: 0x000DCAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetMonopolyMbtiReportRewardScRsp Clone()
		{
			return new GetMonopolyMbtiReportRewardScRsp(this);
		}

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06005299 RID: 21145 RVA: 0x000DE8E8 File Offset: 0x000DCAE8
		// (set) Token: 0x0600529A RID: 21146 RVA: 0x000DE8F0 File Offset: 0x000DCAF0
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

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x0600529B RID: 21147 RVA: 0x000DE8F9 File Offset: 0x000DCAF9
		// (set) Token: 0x0600529C RID: 21148 RVA: 0x000DE901 File Offset: 0x000DCB01
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

		// Token: 0x0600529D RID: 21149 RVA: 0x000DE90A File Offset: 0x000DCB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetMonopolyMbtiReportRewardScRsp);
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x000DE918 File Offset: 0x000DCB18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetMonopolyMbtiReportRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RewardList, other.RewardList) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x000DE968 File Offset: 0x000DCB68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rewardList_ != null)
			{
				num ^= this.RewardList.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x000DE9BD File Offset: 0x000DCBBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x000DE9C5 File Offset: 0x000DCBC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x000DE9D0 File Offset: 0x000DCBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardList_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RewardList);
			}
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

		// Token: 0x060052A3 RID: 21155 RVA: 0x000DEA2C File Offset: 0x000DCC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rewardList_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardList);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x000DEA84 File Offset: 0x000DCC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetMonopolyMbtiReportRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rewardList_ != null)
			{
				if (this.rewardList_ == null)
				{
					this.RewardList = new ItemList();
				}
				this.RewardList.MergeFrom(other.RewardList);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x000DEAEC File Offset: 0x000DCCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x000DEAF8 File Offset: 0x000DCCF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
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
					if (this.rewardList_ == null)
					{
						this.RewardList = new ItemList();
					}
					input.ReadMessage(this.RewardList);
				}
			}
		}

		// Token: 0x04002079 RID: 8313
		private static readonly MessageParser<GetMonopolyMbtiReportRewardScRsp> _parser = new MessageParser<GetMonopolyMbtiReportRewardScRsp>(() => new GetMonopolyMbtiReportRewardScRsp());

		// Token: 0x0400207A RID: 8314
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400207B RID: 8315
		public const int RetcodeFieldNumber = 9;

		// Token: 0x0400207C RID: 8316
		private uint retcode_;

		// Token: 0x0400207D RID: 8317
		public const int RewardListFieldNumber = 8;

		// Token: 0x0400207E RID: 8318
		private ItemList rewardList_;
	}
}
