using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006F3 RID: 1779
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetLevelRewardScRsp : IMessage<GetLevelRewardScRsp>, IMessage, IEquatable<GetLevelRewardScRsp>, IDeepCloneable<GetLevelRewardScRsp>, IBufferMessage
	{
		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06004F8D RID: 20365 RVA: 0x000D6D9D File Offset: 0x000D4F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetLevelRewardScRsp> Parser
		{
			get
			{
				return GetLevelRewardScRsp._parser;
			}
		}

		// Token: 0x17001691 RID: 5777
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x000D6DA4 File Offset: 0x000D4FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetLevelRewardScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001692 RID: 5778
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x000D6DB6 File Offset: 0x000D4FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetLevelRewardScRsp.Descriptor;
			}
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x000D6DBD File Offset: 0x000D4FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardScRsp()
		{
		}

		// Token: 0x06004F91 RID: 20369 RVA: 0x000D6DC8 File Offset: 0x000D4FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardScRsp(GetLevelRewardScRsp other) : this()
		{
			this.level_ = other.level_;
			this.retcode_ = other.retcode_;
			this.reward_ = ((other.reward_ != null) ? other.reward_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F92 RID: 20370 RVA: 0x000D6E20 File Offset: 0x000D5020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetLevelRewardScRsp Clone()
		{
			return new GetLevelRewardScRsp(this);
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004F93 RID: 20371 RVA: 0x000D6E28 File Offset: 0x000D5028
		// (set) Token: 0x06004F94 RID: 20372 RVA: 0x000D6E30 File Offset: 0x000D5030
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

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x000D6E39 File Offset: 0x000D5039
		// (set) Token: 0x06004F96 RID: 20374 RVA: 0x000D6E41 File Offset: 0x000D5041
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

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004F97 RID: 20375 RVA: 0x000D6E4A File Offset: 0x000D504A
		// (set) Token: 0x06004F98 RID: 20376 RVA: 0x000D6E52 File Offset: 0x000D5052
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

		// Token: 0x06004F99 RID: 20377 RVA: 0x000D6E5B File Offset: 0x000D505B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetLevelRewardScRsp);
		}

		// Token: 0x06004F9A RID: 20378 RVA: 0x000D6E6C File Offset: 0x000D506C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetLevelRewardScRsp other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.Retcode == other.Retcode && object.Equals(this.Reward, other.Reward) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F9B RID: 20379 RVA: 0x000D6ECC File Offset: 0x000D50CC
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F9C RID: 20380 RVA: 0x000D6F3A File Offset: 0x000D513A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F9D RID: 20381 RVA: 0x000D6F42 File Offset: 0x000D5142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F9E RID: 20382 RVA: 0x000D6F4C File Offset: 0x000D514C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.reward_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Reward);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F9F RID: 20383 RVA: 0x000D6FC4 File Offset: 0x000D51C4
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004FA0 RID: 20384 RVA: 0x000D7034 File Offset: 0x000D5234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetLevelRewardScRsp other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004FA1 RID: 20385 RVA: 0x000D70B0 File Offset: 0x000D52B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004FA2 RID: 20386 RVA: 0x000D70BC File Offset: 0x000D52BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 34U)
					{
						if (num != 56U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Level = input.ReadUInt32();
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

		// Token: 0x04001F5B RID: 8027
		private static readonly MessageParser<GetLevelRewardScRsp> _parser = new MessageParser<GetLevelRewardScRsp>(() => new GetLevelRewardScRsp());

		// Token: 0x04001F5C RID: 8028
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F5D RID: 8029
		public const int LevelFieldNumber = 7;

		// Token: 0x04001F5E RID: 8030
		private uint level_;

		// Token: 0x04001F5F RID: 8031
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04001F60 RID: 8032
		private uint retcode_;

		// Token: 0x04001F61 RID: 8033
		public const int RewardFieldNumber = 4;

		// Token: 0x04001F62 RID: 8034
		private ItemList reward_;
	}
}
