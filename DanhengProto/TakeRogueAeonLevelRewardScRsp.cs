using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200131F RID: 4895
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueAeonLevelRewardScRsp : IMessage<TakeRogueAeonLevelRewardScRsp>, IMessage, IEquatable<TakeRogueAeonLevelRewardScRsp>, IDeepCloneable<TakeRogueAeonLevelRewardScRsp>, IBufferMessage
	{
		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600DA65 RID: 55909 RVA: 0x00245BB7 File Offset: 0x00243DB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueAeonLevelRewardScRsp> Parser
		{
			get
			{
				return TakeRogueAeonLevelRewardScRsp._parser;
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600DA66 RID: 55910 RVA: 0x00245BBE File Offset: 0x00243DBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueAeonLevelRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600DA67 RID: 55911 RVA: 0x00245BD0 File Offset: 0x00243DD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueAeonLevelRewardScRsp.Descriptor;
			}
		}

		// Token: 0x0600DA68 RID: 55912 RVA: 0x00245BD7 File Offset: 0x00243DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueAeonLevelRewardScRsp()
		{
		}

		// Token: 0x0600DA69 RID: 55913 RVA: 0x00245BE0 File Offset: 0x00243DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueAeonLevelRewardScRsp(TakeRogueAeonLevelRewardScRsp other) : this()
		{
			this.level_ = other.level_;
			this.aeonId_ = other.aeonId_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DA6A RID: 55914 RVA: 0x00245C44 File Offset: 0x00243E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueAeonLevelRewardScRsp Clone()
		{
			return new TakeRogueAeonLevelRewardScRsp(this);
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600DA6B RID: 55915 RVA: 0x00245C4C File Offset: 0x00243E4C
		// (set) Token: 0x0600DA6C RID: 55916 RVA: 0x00245C54 File Offset: 0x00243E54
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

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x0600DA6D RID: 55917 RVA: 0x00245C5D File Offset: 0x00243E5D
		// (set) Token: 0x0600DA6E RID: 55918 RVA: 0x00245C65 File Offset: 0x00243E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AeonId
		{
			get
			{
				return this.aeonId_;
			}
			set
			{
				this.aeonId_ = value;
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x0600DA6F RID: 55919 RVA: 0x00245C6E File Offset: 0x00243E6E
		// (set) Token: 0x0600DA70 RID: 55920 RVA: 0x00245C76 File Offset: 0x00243E76
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

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x0600DA71 RID: 55921 RVA: 0x00245C7F File Offset: 0x00243E7F
		// (set) Token: 0x0600DA72 RID: 55922 RVA: 0x00245C87 File Offset: 0x00243E87
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

		// Token: 0x0600DA73 RID: 55923 RVA: 0x00245C90 File Offset: 0x00243E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueAeonLevelRewardScRsp);
		}

		// Token: 0x0600DA74 RID: 55924 RVA: 0x00245CA0 File Offset: 0x00243EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueAeonLevelRewardScRsp other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.AeonId == other.AeonId && object.Equals(this.Reward, other.Reward) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DA75 RID: 55925 RVA: 0x00245D10 File Offset: 0x00243F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.AeonId != 0U)
			{
				num ^= this.AeonId.GetHashCode();
			}
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

		// Token: 0x0600DA76 RID: 55926 RVA: 0x00245D97 File Offset: 0x00243F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DA77 RID: 55927 RVA: 0x00245D9F File Offset: 0x00243F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DA78 RID: 55928 RVA: 0x00245DA8 File Offset: 0x00243FA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.reward_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Reward);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.Retcode);
			}
			if (this.AeonId != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AeonId);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DA79 RID: 55929 RVA: 0x00245E3C File Offset: 0x0024403C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.AeonId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AeonId);
			}
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

		// Token: 0x0600DA7A RID: 55930 RVA: 0x00245EC4 File Offset: 0x002440C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueAeonLevelRewardScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.AeonId != 0U)
			{
				this.AeonId = other.AeonId;
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DA7B RID: 55931 RVA: 0x00245F54 File Offset: 0x00244154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DA7C RID: 55932 RVA: 0x00245F60 File Offset: 0x00244160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 64U)
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
					if (num == 64U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.AeonId = input.ReadUInt32();
						continue;
					}
					if (num == 96U)
					{
						this.Level = input.ReadUInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040056F9 RID: 22265
		private static readonly MessageParser<TakeRogueAeonLevelRewardScRsp> _parser = new MessageParser<TakeRogueAeonLevelRewardScRsp>(() => new TakeRogueAeonLevelRewardScRsp());

		// Token: 0x040056FA RID: 22266
		private UnknownFieldSet _unknownFields;

		// Token: 0x040056FB RID: 22267
		public const int LevelFieldNumber = 12;

		// Token: 0x040056FC RID: 22268
		private uint level_;

		// Token: 0x040056FD RID: 22269
		public const int AeonIdFieldNumber = 10;

		// Token: 0x040056FE RID: 22270
		private uint aeonId_;

		// Token: 0x040056FF RID: 22271
		public const int RewardFieldNumber = 3;

		// Token: 0x04005700 RID: 22272
		private ItemList reward_;

		// Token: 0x04005701 RID: 22273
		public const int RetcodeFieldNumber = 8;

		// Token: 0x04005702 RID: 22274
		private uint retcode_;
	}
}
