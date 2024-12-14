using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001313 RID: 4883
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakePunkLordPointRewardScRsp : IMessage<TakePunkLordPointRewardScRsp>, IMessage, IEquatable<TakePunkLordPointRewardScRsp>, IDeepCloneable<TakePunkLordPointRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x0600D9D7 RID: 55767 RVA: 0x00244537 File Offset: 0x00242737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakePunkLordPointRewardScRsp> Parser
		{
			get
			{
				return TakePunkLordPointRewardScRsp._parser;
			}
		}

		// Token: 0x17003D35 RID: 15669
		// (get) Token: 0x0600D9D8 RID: 55768 RVA: 0x0024453E File Offset: 0x0024273E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakePunkLordPointRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D36 RID: 15670
		// (get) Token: 0x0600D9D9 RID: 55769 RVA: 0x00244550 File Offset: 0x00242750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakePunkLordPointRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600D9DA RID: 55770 RVA: 0x00244557 File Offset: 0x00242757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePunkLordPointRewardScRsp()
		{
		}

		// Token: 0x0600D9DB RID: 55771 RVA: 0x00244560 File Offset: 0x00242760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePunkLordPointRewardScRsp(TakePunkLordPointRewardScRsp other) : this()
		{
			this.level_ = other.level_;
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.mGCIACFKBFM_ = other.mGCIACFKBFM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D9DC RID: 55772 RVA: 0x002445C4 File Offset: 0x002427C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakePunkLordPointRewardScRsp Clone()
		{
			return new TakePunkLordPointRewardScRsp(this);
		}

		// Token: 0x17003D37 RID: 15671
		// (get) Token: 0x0600D9DD RID: 55773 RVA: 0x002445CC File Offset: 0x002427CC
		// (set) Token: 0x0600D9DE RID: 55774 RVA: 0x002445D4 File Offset: 0x002427D4
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

		// Token: 0x17003D38 RID: 15672
		// (get) Token: 0x0600D9DF RID: 55775 RVA: 0x002445DD File Offset: 0x002427DD
		// (set) Token: 0x0600D9E0 RID: 55776 RVA: 0x002445E5 File Offset: 0x002427E5
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

		// Token: 0x17003D39 RID: 15673
		// (get) Token: 0x0600D9E1 RID: 55777 RVA: 0x002445EE File Offset: 0x002427EE
		// (set) Token: 0x0600D9E2 RID: 55778 RVA: 0x002445F6 File Offset: 0x002427F6
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

		// Token: 0x17003D3A RID: 15674
		// (get) Token: 0x0600D9E3 RID: 55779 RVA: 0x002445FF File Offset: 0x002427FF
		// (set) Token: 0x0600D9E4 RID: 55780 RVA: 0x00244607 File Offset: 0x00242807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MGCIACFKBFM
		{
			get
			{
				return this.mGCIACFKBFM_;
			}
			set
			{
				this.mGCIACFKBFM_ = value;
			}
		}

		// Token: 0x0600D9E5 RID: 55781 RVA: 0x00244610 File Offset: 0x00242810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakePunkLordPointRewardScRsp);
		}

		// Token: 0x0600D9E6 RID: 55782 RVA: 0x00244620 File Offset: 0x00242820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakePunkLordPointRewardScRsp other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && this.MGCIACFKBFM == other.MGCIACFKBFM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D9E7 RID: 55783 RVA: 0x00244690 File Offset: 0x00242890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.reward_ != null)
			{
				num ^= this.Reward.GetHashCode();
			}
			if (this.MGCIACFKBFM)
			{
				num ^= this.MGCIACFKBFM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D9E8 RID: 55784 RVA: 0x00244717 File Offset: 0x00242917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D9E9 RID: 55785 RVA: 0x0024471F File Offset: 0x0024291F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D9EA RID: 55786 RVA: 0x00244728 File Offset: 0x00242928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MGCIACFKBFM)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.MGCIACFKBFM);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Level);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Reward);
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

		// Token: 0x0600D9EB RID: 55787 RVA: 0x002447BC File Offset: 0x002429BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.reward_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Reward);
			}
			if (this.MGCIACFKBFM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D9EC RID: 55788 RVA: 0x00244838 File Offset: 0x00242A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakePunkLordPointRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
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
			if (other.MGCIACFKBFM)
			{
				this.MGCIACFKBFM = other.MGCIACFKBFM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D9ED RID: 55789 RVA: 0x002448C8 File Offset: 0x00242AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D9EE RID: 55790 RVA: 0x002448D4 File Offset: 0x00242AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.MGCIACFKBFM = input.ReadBool();
						continue;
					}
					if (num == 64U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 82U)
					{
						if (this.reward_ == null)
						{
							this.Reward = new ItemList();
						}
						input.ReadMessage(this.Reward);
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

		// Token: 0x040056C7 RID: 22215
		private static readonly MessageParser<TakePunkLordPointRewardScRsp> _parser = new MessageParser<TakePunkLordPointRewardScRsp>(() => new TakePunkLordPointRewardScRsp());

		// Token: 0x040056C8 RID: 22216
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056C9 RID: 22217
		public const int LevelFieldNumber = 8;

		// Token: 0x040056CA RID: 22218
		private uint level_;

		// Token: 0x040056CB RID: 22219
		public const int RetcodeFieldNumber = 15;

		// Token: 0x040056CC RID: 22220
		private uint retcode_;

		// Token: 0x040056CD RID: 22221
		public const int RewardFieldNumber = 10;

		// Token: 0x040056CE RID: 22222
		private ItemList reward_;

		// Token: 0x040056CF RID: 22223
		public const int MGCIACFKBFMFieldNumber = 4;

		// Token: 0x040056D0 RID: 22224
		private bool mGCIACFKBFM_;
	}
}
