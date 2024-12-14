using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CAD RID: 3245
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerAssistInfo : IMessage<PlayerAssistInfo>, IMessage, IEquatable<PlayerAssistInfo>, IDeepCloneable<PlayerAssistInfo>, IBufferMessage
	{
		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x06009034 RID: 36916 RVA: 0x0017CCF7 File Offset: 0x0017AEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerAssistInfo> Parser
		{
			get
			{
				return PlayerAssistInfo._parser;
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x06009035 RID: 36917 RVA: 0x0017CCFE File Offset: 0x0017AEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerAssistInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002883 RID: 10371
		// (get) Token: 0x06009036 RID: 36918 RVA: 0x0017CD10 File Offset: 0x0017AF10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerAssistInfo.Descriptor;
			}
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x0017CD17 File Offset: 0x0017AF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAssistInfo()
		{
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x0017CD20 File Offset: 0x0017AF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAssistInfo(PlayerAssistInfo other) : this()
		{
			this.assistAvatar_ = ((other.assistAvatar_ != null) ? other.assistAvatar_.Clone() : null);
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0017CD7C File Offset: 0x0017AF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAssistInfo Clone()
		{
			return new PlayerAssistInfo(this);
		}

		// Token: 0x17002884 RID: 10372
		// (get) Token: 0x0600903A RID: 36922 RVA: 0x0017CD84 File Offset: 0x0017AF84
		// (set) Token: 0x0600903B RID: 36923 RVA: 0x0017CD8C File Offset: 0x0017AF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarDetailInfo AssistAvatar
		{
			get
			{
				return this.assistAvatar_;
			}
			set
			{
				this.assistAvatar_ = value;
			}
		}

		// Token: 0x17002885 RID: 10373
		// (get) Token: 0x0600903C RID: 36924 RVA: 0x0017CD95 File Offset: 0x0017AF95
		// (set) Token: 0x0600903D RID: 36925 RVA: 0x0017CD9D File Offset: 0x0017AF9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSimpleInfo PlayerInfo
		{
			get
			{
				return this.playerInfo_;
			}
			set
			{
				this.playerInfo_ = value;
			}
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x0017CDA6 File Offset: 0x0017AFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerAssistInfo);
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x0017CDB4 File Offset: 0x0017AFB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerAssistInfo other)
		{
			return other != null && (other == this || (object.Equals(this.AssistAvatar, other.AssistAvatar) && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009040 RID: 36928 RVA: 0x0017CE08 File Offset: 0x0017B008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.assistAvatar_ != null)
			{
				num ^= this.AssistAvatar.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0017CE5A File Offset: 0x0017B05A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x0017CE62 File Offset: 0x0017B062
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x0017CE6C File Offset: 0x0017B06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.assistAvatar_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AssistAvatar);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009044 RID: 36932 RVA: 0x0017CEC8 File Offset: 0x0017B0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.assistAvatar_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AssistAvatar);
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x0017CF20 File Offset: 0x0017B120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerAssistInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.assistAvatar_ != null)
			{
				if (this.assistAvatar_ == null)
				{
					this.AssistAvatar = new DisplayAvatarDetailInfo();
				}
				this.AssistAvatar.MergeFrom(other.AssistAvatar);
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new PlayerSimpleInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x0017CFA0 File Offset: 0x0017B1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x0017CFAC File Offset: 0x0017B1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new PlayerSimpleInfo();
						}
						input.ReadMessage(this.PlayerInfo);
					}
				}
				else
				{
					if (this.assistAvatar_ == null)
					{
						this.AssistAvatar = new DisplayAvatarDetailInfo();
					}
					input.ReadMessage(this.AssistAvatar);
				}
			}
		}

		// Token: 0x0400376C RID: 14188
		private static readonly MessageParser<PlayerAssistInfo> _parser = new MessageParser<PlayerAssistInfo>(() => new PlayerAssistInfo());

		// Token: 0x0400376D RID: 14189
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400376E RID: 14190
		public const int AssistAvatarFieldNumber = 1;

		// Token: 0x0400376F RID: 14191
		private DisplayAvatarDetailInfo assistAvatar_;

		// Token: 0x04003770 RID: 14192
		public const int PlayerInfoFieldNumber = 5;

		// Token: 0x04003771 RID: 14193
		private PlayerSimpleInfo playerInfo_;
	}
}
