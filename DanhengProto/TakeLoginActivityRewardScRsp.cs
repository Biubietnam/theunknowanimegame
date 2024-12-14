using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012E1 RID: 4833
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeLoginActivityRewardScRsp : IMessage<TakeLoginActivityRewardScRsp>, IMessage, IEquatable<TakeLoginActivityRewardScRsp>, IDeepCloneable<TakeLoginActivityRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003C9E RID: 15518
		// (get) Token: 0x0600D7A3 RID: 55203 RVA: 0x0023F14B File Offset: 0x0023D34B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeLoginActivityRewardScRsp> Parser
		{
			get
			{
				return TakeLoginActivityRewardScRsp._parser;
			}
		}

		// Token: 0x17003C9F RID: 15519
		// (get) Token: 0x0600D7A4 RID: 55204 RVA: 0x0023F152 File Offset: 0x0023D352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeLoginActivityRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003CA0 RID: 15520
		// (get) Token: 0x0600D7A5 RID: 55205 RVA: 0x0023F164 File Offset: 0x0023D364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeLoginActivityRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D7A6 RID: 55206 RVA: 0x0023F16B File Offset: 0x0023D36B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeLoginActivityRewardScRsp()
		{
		}

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x0023F174 File Offset: 0x0023D374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeLoginActivityRewardScRsp(TakeLoginActivityRewardScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.id_ = other.id_;
			this.takeDays_ = other.takeDays_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D7A8 RID: 55208 RVA: 0x0023F1D8 File Offset: 0x0023D3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeLoginActivityRewardScRsp Clone()
		{
			return new TakeLoginActivityRewardScRsp(this);
		}

		// Token: 0x17003CA1 RID: 15521
		// (get) Token: 0x0600D7A9 RID: 55209 RVA: 0x0023F1E0 File Offset: 0x0023D3E0
		// (set) Token: 0x0600D7AA RID: 55210 RVA: 0x0023F1E8 File Offset: 0x0023D3E8
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

		// Token: 0x17003CA2 RID: 15522
		// (get) Token: 0x0600D7AB RID: 55211 RVA: 0x0023F1F1 File Offset: 0x0023D3F1
		// (set) Token: 0x0600D7AC RID: 55212 RVA: 0x0023F1F9 File Offset: 0x0023D3F9
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

		// Token: 0x17003CA3 RID: 15523
		// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x0023F202 File Offset: 0x0023D402
		// (set) Token: 0x0600D7AE RID: 55214 RVA: 0x0023F20A File Offset: 0x0023D40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x0600D7AF RID: 55215 RVA: 0x0023F213 File Offset: 0x0023D413
		// (set) Token: 0x0600D7B0 RID: 55216 RVA: 0x0023F21B File Offset: 0x0023D41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TakeDays
		{
			get
			{
				return this.takeDays_;
			}
			set
			{
				this.takeDays_ = value;
			}
		}

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x0023F224 File Offset: 0x0023D424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeLoginActivityRewardScRsp);
		}

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x0023F234 File Offset: 0x0023D434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeLoginActivityRewardScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && this.Id == other.Id && this.TakeDays == other.TakeDays && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D7B3 RID: 55219 RVA: 0x0023F2A4 File Offset: 0x0023D4A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.TakeDays != 0U)
			{
				num ^= this.TakeDays.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x0023F32B File Offset: 0x0023D52B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x0023F333 File Offset: 0x0023D533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x0023F33C File Offset: 0x0023D53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TakeDays != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.TakeDays);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.Id != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.Id);
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

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x0023F3D0 File Offset: 0x0023D5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this.TakeDays != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TakeDays);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x0023F458 File Offset: 0x0023D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeLoginActivityRewardScRsp other)
		{
			if (other == null)
			{
				return;
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
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			if (other.TakeDays != 0U)
			{
				this.TakeDays = other.TakeDays;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x0023F4E8 File Offset: 0x0023D6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D7BA RID: 55226 RVA: 0x0023F4F4 File Offset: 0x0023D6F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 34U)
				{
					if (num == 24U)
					{
						this.TakeDays = input.ReadUInt32();
						continue;
					}
					if (num == 34U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.Id = input.ReadUInt32();
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

		// Token: 0x0400560D RID: 22029
		private static readonly MessageParser<TakeLoginActivityRewardScRsp> _parser = new MessageParser<TakeLoginActivityRewardScRsp>(() => new TakeLoginActivityRewardScRsp());

		// Token: 0x0400560E RID: 22030
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400560F RID: 22031
		public const int RetcodeFieldNumber = 15;

		// Token: 0x04005610 RID: 22032
		private uint retcode_;

		// Token: 0x04005611 RID: 22033
		public const int RewardFieldNumber = 4;

		// Token: 0x04005612 RID: 22034
		private ItemList reward_;

		// Token: 0x04005613 RID: 22035
		public const int IdFieldNumber = 9;

		// Token: 0x04005614 RID: 22036
		private uint id_;

		// Token: 0x04005615 RID: 22037
		public const int TakeDaysFieldNumber = 3;

		// Token: 0x04005616 RID: 22038
		private uint takeDays_;
	}
}
