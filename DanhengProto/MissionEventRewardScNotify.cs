using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000ADF RID: 2783
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MissionEventRewardScNotify : IMessage<MissionEventRewardScNotify>, IMessage, IEquatable<MissionEventRewardScNotify>, IDeepCloneable<MissionEventRewardScNotify>, IBufferMessage
	{
		// Token: 0x17002299 RID: 8857
		// (get) Token: 0x06007B46 RID: 31558 RVA: 0x001463D5 File Offset: 0x001445D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MissionEventRewardScNotify> Parser
		{
			get
			{
				return MissionEventRewardScNotify._parser;
			}
		}

		// Token: 0x1700229A RID: 8858
		// (get) Token: 0x06007B47 RID: 31559 RVA: 0x001463DC File Offset: 0x001445DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MissionEventRewardScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700229B RID: 8859
		// (get) Token: 0x06007B48 RID: 31560 RVA: 0x001463EE File Offset: 0x001445EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MissionEventRewardScNotify.Descriptor;
			}
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x001463F5 File Offset: 0x001445F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionEventRewardScNotify()
		{
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x00146400 File Offset: 0x00144600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionEventRewardScNotify(MissionEventRewardScNotify other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.missionEventId_ = other.missionEventId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B4B RID: 31563 RVA: 0x0014644C File Offset: 0x0014464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MissionEventRewardScNotify Clone()
		{
			return new MissionEventRewardScNotify(this);
		}

		// Token: 0x1700229C RID: 8860
		// (get) Token: 0x06007B4C RID: 31564 RVA: 0x00146454 File Offset: 0x00144654
		// (set) Token: 0x06007B4D RID: 31565 RVA: 0x0014645C File Offset: 0x0014465C
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

		// Token: 0x1700229D RID: 8861
		// (get) Token: 0x06007B4E RID: 31566 RVA: 0x00146465 File Offset: 0x00144665
		// (set) Token: 0x06007B4F RID: 31567 RVA: 0x0014646D File Offset: 0x0014466D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint MissionEventId
		{
			get
			{
				return this.missionEventId_;
			}
			set
			{
				this.missionEventId_ = value;
			}
		}

		// Token: 0x06007B50 RID: 31568 RVA: 0x00146476 File Offset: 0x00144676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MissionEventRewardScNotify);
		}

		// Token: 0x06007B51 RID: 31569 RVA: 0x00146484 File Offset: 0x00144684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MissionEventRewardScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.MissionEventId == other.MissionEventId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x001464D4 File Offset: 0x001446D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.MissionEventId != 0U)
			{
				num ^= this.MissionEventId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x00146529 File Offset: 0x00144729
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007B54 RID: 31572 RVA: 0x00146531 File Offset: 0x00144731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B55 RID: 31573 RVA: 0x0014653C File Offset: 0x0014473C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MissionEventId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.MissionEventId);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Reward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x00146598 File Offset: 0x00144798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.MissionEventId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MissionEventId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x001465F0 File Offset: 0x001447F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MissionEventRewardScNotify other)
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
			if (other.MissionEventId != 0U)
			{
				this.MissionEventId = other.MissionEventId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007B58 RID: 31576 RVA: 0x00146658 File Offset: 0x00144858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x00146664 File Offset: 0x00144864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					if (num != 122U)
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
					this.MissionEventId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002F47 RID: 12103
		private static readonly MessageParser<MissionEventRewardScNotify> _parser = new MessageParser<MissionEventRewardScNotify>(() => new MissionEventRewardScNotify());

		// Token: 0x04002F48 RID: 12104
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F49 RID: 12105
		public const int RewardFieldNumber = 15;

		// Token: 0x04002F4A RID: 12106
		private ItemList reward_;

		// Token: 0x04002F4B RID: 12107
		public const int MissionEventIdFieldNumber = 14;

		// Token: 0x04002F4C RID: 12108
		private uint missionEventId_;
	}
}
