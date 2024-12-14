using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004CF RID: 1231
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildTakeExpRewardScRsp : IMessage<EvolveBuildTakeExpRewardScRsp>, IMessage, IEquatable<EvolveBuildTakeExpRewardScRsp>, IDeepCloneable<EvolveBuildTakeExpRewardScRsp>, IBufferMessage
	{
		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x06003706 RID: 14086 RVA: 0x000971A7 File Offset: 0x000953A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildTakeExpRewardScRsp> Parser
		{
			get
			{
				return EvolveBuildTakeExpRewardScRsp._parser;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x000971AE File Offset: 0x000953AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildTakeExpRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06003708 RID: 14088 RVA: 0x000971C0 File Offset: 0x000953C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildTakeExpRewardScRsp.Descriptor;
			}
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x000971C7 File Offset: 0x000953C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildTakeExpRewardScRsp()
		{
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x000971D0 File Offset: 0x000953D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildTakeExpRewardScRsp(EvolveBuildTakeExpRewardScRsp other) : this()
		{
			this.dOIDHIJIKLH_ = other.dOIDHIJIKLH_;
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00097228 File Offset: 0x00095428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildTakeExpRewardScRsp Clone()
		{
			return new EvolveBuildTakeExpRewardScRsp(this);
		}

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x0600370C RID: 14092 RVA: 0x00097230 File Offset: 0x00095430
		// (set) Token: 0x0600370D RID: 14093 RVA: 0x00097238 File Offset: 0x00095438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint DOIDHIJIKLH
		{
			get
			{
				return this.dOIDHIJIKLH_;
			}
			set
			{
				this.dOIDHIJIKLH_ = value;
			}
		}

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x0600370E RID: 14094 RVA: 0x00097241 File Offset: 0x00095441
		// (set) Token: 0x0600370F RID: 14095 RVA: 0x00097249 File Offset: 0x00095449
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

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x00097252 File Offset: 0x00095452
		// (set) Token: 0x06003711 RID: 14097 RVA: 0x0009725A File Offset: 0x0009545A
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

		// Token: 0x06003712 RID: 14098 RVA: 0x00097263 File Offset: 0x00095463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildTakeExpRewardScRsp);
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00097274 File Offset: 0x00095474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildTakeExpRewardScRsp other)
		{
			return other != null && (other == this || (this.DOIDHIJIKLH == other.DOIDHIJIKLH && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x000972D4 File Offset: 0x000954D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DOIDHIJIKLH != 0U)
			{
				num ^= this.DOIDHIJIKLH.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
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

		// Token: 0x06003715 RID: 14101 RVA: 0x00097342 File Offset: 0x00095542
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x0009734A File Offset: 0x0009554A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00097354 File Offset: 0x00095554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Reward);
			}
			if (this.DOIDHIJIKLH != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.DOIDHIJIKLH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x000973CC File Offset: 0x000955CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DOIDHIJIKLH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.DOIDHIJIKLH);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
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

		// Token: 0x06003719 RID: 14105 RVA: 0x0009743C File Offset: 0x0009563C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildTakeExpRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DOIDHIJIKLH != 0U)
			{
				this.DOIDHIJIKLH = other.DOIDHIJIKLH;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
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

		// Token: 0x0600371A RID: 14106 RVA: 0x000974B8 File Offset: 0x000956B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x000974C4 File Offset: 0x000956C4
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
						if (num != 64U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.DOIDHIJIKLH = input.ReadUInt32();
						}
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
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015D5 RID: 5589
		private static readonly MessageParser<EvolveBuildTakeExpRewardScRsp> _parser = new MessageParser<EvolveBuildTakeExpRewardScRsp>(() => new EvolveBuildTakeExpRewardScRsp());

		// Token: 0x040015D6 RID: 5590
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015D7 RID: 5591
		public const int DOIDHIJIKLHFieldNumber = 8;

		// Token: 0x040015D8 RID: 5592
		private uint dOIDHIJIKLH_;

		// Token: 0x040015D9 RID: 5593
		public const int RetcodeFieldNumber = 4;

		// Token: 0x040015DA RID: 5594
		private uint retcode_;

		// Token: 0x040015DB RID: 5595
		public const int RewardFieldNumber = 5;

		// Token: 0x040015DC RID: 5596
		private ItemList reward_;
	}
}
