using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200130B RID: 4875
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePrestigeRewardScRsp : IMessage<TakePrestigeRewardScRsp>, IMessage, IEquatable<TakePrestigeRewardScRsp>, IDeepCloneable<TakePrestigeRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D1B RID: 15643
		// (get) Token: 0x0600D979 RID: 55673 RVA: 0x002436D9 File Offset: 0x002418D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePrestigeRewardScRsp> Parser
		{
			get
			{
				return TakePrestigeRewardScRsp._parser;
			}
		}

		// Token: 0x17003D1C RID: 15644
		// (get) Token: 0x0600D97A RID: 55674 RVA: 0x002436E0 File Offset: 0x002418E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePrestigeRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D1D RID: 15645
		// (get) Token: 0x0600D97B RID: 55675 RVA: 0x002436F2 File Offset: 0x002418F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePrestigeRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D97C RID: 55676 RVA: 0x002436F9 File Offset: 0x002418F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePrestigeRewardScRsp()
		{
		}

		// Token: 0x0600D97D RID: 55677 RVA: 0x00243704 File Offset: 0x00241904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePrestigeRewardScRsp(TakePrestigeRewardScRsp other) : this()
		{
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D97E RID: 55678 RVA: 0x0024375C File Offset: 0x0024195C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePrestigeRewardScRsp Clone()
		{
			return new TakePrestigeRewardScRsp(this);
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0600D97F RID: 55679 RVA: 0x00243764 File Offset: 0x00241964
		// (set) Token: 0x0600D980 RID: 55680 RVA: 0x0024376C File Offset: 0x0024196C
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

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0600D981 RID: 55681 RVA: 0x00243775 File Offset: 0x00241975
		// (set) Token: 0x0600D982 RID: 55682 RVA: 0x0024377D File Offset: 0x0024197D
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

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0600D983 RID: 55683 RVA: 0x00243786 File Offset: 0x00241986
		// (set) Token: 0x0600D984 RID: 55684 RVA: 0x0024378E File Offset: 0x0024198E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x0600D985 RID: 55685 RVA: 0x00243797 File Offset: 0x00241997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePrestigeRewardScRsp);
		}

		// Token: 0x0600D986 RID: 55686 RVA: 0x002437A8 File Offset: 0x002419A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePrestigeRewardScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D987 RID: 55687 RVA: 0x00243808 File Offset: 0x00241A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D988 RID: 55688 RVA: 0x00243876 File Offset: 0x00241A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D989 RID: 55689 RVA: 0x0024387E File Offset: 0x00241A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D98A RID: 55690 RVA: 0x00243888 File Offset: 0x00241A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Level);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D98B RID: 55691 RVA: 0x002438FC File Offset: 0x00241AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D98C RID: 55692 RVA: 0x0024396C File Offset: 0x00241B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePrestigeRewardScRsp other)
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
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D98D RID: 55693 RVA: 0x002439E8 File Offset: 0x00241BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D98E RID: 55694 RVA: 0x002439F4 File Offset: 0x00241BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					if (num != 34U)
					{
						if (num != 88U)
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
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040056A9 RID: 22185
		private static readonly MessageParser<TakePrestigeRewardScRsp> _parser = new MessageParser<TakePrestigeRewardScRsp>(() => new TakePrestigeRewardScRsp());

		// Token: 0x040056AA RID: 22186
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056AB RID: 22187
		public const int RewardFieldNumber = 4;

		// Token: 0x040056AC RID: 22188
		private ItemList reward_;

		// Token: 0x040056AD RID: 22189
		public const int RetcodeFieldNumber = 11;

		// Token: 0x040056AE RID: 22190
		private uint retcode_;

		// Token: 0x040056AF RID: 22191
		public const int LevelFieldNumber = 1;

		// Token: 0x040056B0 RID: 22192
		private uint level_;
	}
}
