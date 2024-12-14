using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005CB RID: 1483
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendSimpleInfo : IMessage<FriendSimpleInfo>, IMessage, IEquatable<FriendSimpleInfo>, IDeepCloneable<FriendSimpleInfo>, IBufferMessage
	{
		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x0600421F RID: 16927 RVA: 0x000B3EEB File Offset: 0x000B20EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendSimpleInfo> Parser
		{
			get
			{
				return FriendSimpleInfo._parser;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06004220 RID: 16928 RVA: 0x000B3EF2 File Offset: 0x000B20F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendSimpleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06004221 RID: 16929 RVA: 0x000B3F04 File Offset: 0x000B2104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendSimpleInfo.Descriptor;
			}
		}

		// Token: 0x06004222 RID: 16930 RVA: 0x000B3F0B File Offset: 0x000B210B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendSimpleInfo()
		{
		}

		// Token: 0x06004223 RID: 16931 RVA: 0x000B3F20 File Offset: 0x000B2120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendSimpleInfo(FriendSimpleInfo other) : this()
		{
			this.remarkName_ = other.remarkName_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this.isMarked_ = other.isMarked_;
			this.playingState_ = other.playingState_;
			this.eFAEALKEIPD_ = ((other.eFAEALKEIPD_ != null) ? other.eFAEALKEIPD_.Clone() : null);
			this.createTime_ = other.createTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004224 RID: 16932 RVA: 0x000B3FAC File Offset: 0x000B21AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendSimpleInfo Clone()
		{
			return new FriendSimpleInfo(this);
		}

		// Token: 0x170012CC RID: 4812
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x000B3FB4 File Offset: 0x000B21B4
		// (set) Token: 0x06004226 RID: 16934 RVA: 0x000B3FBC File Offset: 0x000B21BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RemarkName
		{
			get
			{
				return this.remarkName_;
			}
			set
			{
				this.remarkName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170012CD RID: 4813
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x000B3FCF File Offset: 0x000B21CF
		// (set) Token: 0x06004228 RID: 16936 RVA: 0x000B3FD7 File Offset: 0x000B21D7
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

		// Token: 0x170012CE RID: 4814
		// (get) Token: 0x06004229 RID: 16937 RVA: 0x000B3FE0 File Offset: 0x000B21E0
		// (set) Token: 0x0600422A RID: 16938 RVA: 0x000B3FE8 File Offset: 0x000B21E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMarked
		{
			get
			{
				return this.isMarked_;
			}
			set
			{
				this.isMarked_ = value;
			}
		}

		// Token: 0x170012CF RID: 4815
		// (get) Token: 0x0600422B RID: 16939 RVA: 0x000B3FF1 File Offset: 0x000B21F1
		// (set) Token: 0x0600422C RID: 16940 RVA: 0x000B3FF9 File Offset: 0x000B21F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayingState PlayingState
		{
			get
			{
				return this.playingState_;
			}
			set
			{
				this.playingState_ = value;
			}
		}

		// Token: 0x170012D0 RID: 4816
		// (get) Token: 0x0600422D RID: 16941 RVA: 0x000B4002 File Offset: 0x000B2202
		// (set) Token: 0x0600422E RID: 16942 RVA: 0x000B400A File Offset: 0x000B220A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NAAJKLMNIJI EFAEALKEIPD
		{
			get
			{
				return this.eFAEALKEIPD_;
			}
			set
			{
				this.eFAEALKEIPD_ = value;
			}
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x0600422F RID: 16943 RVA: 0x000B4013 File Offset: 0x000B2213
		// (set) Token: 0x06004230 RID: 16944 RVA: 0x000B401B File Offset: 0x000B221B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CreateTime
		{
			get
			{
				return this.createTime_;
			}
			set
			{
				this.createTime_ = value;
			}
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x000B4024 File Offset: 0x000B2224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendSimpleInfo);
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x000B4034 File Offset: 0x000B2234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendSimpleInfo other)
		{
			return other != null && (other == this || (!(this.RemarkName != other.RemarkName) && object.Equals(this.PlayerInfo, other.PlayerInfo) && this.IsMarked == other.IsMarked && this.PlayingState == other.PlayingState && object.Equals(this.EFAEALKEIPD, other.EFAEALKEIPD) && this.CreateTime == other.CreateTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x000B40CC File Offset: 0x000B22CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RemarkName.Length != 0)
			{
				num ^= this.RemarkName.GetHashCode();
			}
			if (this.playerInfo_ != null)
			{
				num ^= this.PlayerInfo.GetHashCode();
			}
			if (this.IsMarked)
			{
				num ^= this.IsMarked.GetHashCode();
			}
			if (this.PlayingState != PlayingState.None)
			{
				num ^= this.PlayingState.GetHashCode();
			}
			if (this.eFAEALKEIPD_ != null)
			{
				num ^= this.EFAEALKEIPD.GetHashCode();
			}
			if (this.CreateTime != 0L)
			{
				num ^= this.CreateTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x000B418A File Offset: 0x000B238A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x000B4192 File Offset: 0x000B2392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x000B419C File Offset: 0x000B239C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CreateTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.CreateTime);
			}
			if (this.PlayingState != PlayingState.None)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.PlayingState);
			}
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this.IsMarked)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsMarked);
			}
			if (this.RemarkName.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.RemarkName);
			}
			if (this.eFAEALKEIPD_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.EFAEALKEIPD);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x000B426C File Offset: 0x000B246C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RemarkName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RemarkName);
			}
			if (this.playerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PlayerInfo);
			}
			if (this.IsMarked)
			{
				num += 2;
			}
			if (this.PlayingState != PlayingState.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PlayingState);
			}
			if (this.eFAEALKEIPD_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EFAEALKEIPD);
			}
			if (this.CreateTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CreateTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x000B431C File Offset: 0x000B251C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendSimpleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RemarkName.Length != 0)
			{
				this.RemarkName = other.RemarkName;
			}
			if (other.playerInfo_ != null)
			{
				if (this.playerInfo_ == null)
				{
					this.PlayerInfo = new PlayerSimpleInfo();
				}
				this.PlayerInfo.MergeFrom(other.PlayerInfo);
			}
			if (other.IsMarked)
			{
				this.IsMarked = other.IsMarked;
			}
			if (other.PlayingState != PlayingState.None)
			{
				this.PlayingState = other.PlayingState;
			}
			if (other.eFAEALKEIPD_ != null)
			{
				if (this.eFAEALKEIPD_ == null)
				{
					this.EFAEALKEIPD = new NAAJKLMNIJI();
				}
				this.EFAEALKEIPD.MergeFrom(other.EFAEALKEIPD);
			}
			if (other.CreateTime != 0L)
			{
				this.CreateTime = other.CreateTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x000B43F1 File Offset: 0x000B25F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x000B43FC File Offset: 0x000B25FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 66U)
				{
					if (num == 48U)
					{
						this.CreateTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.PlayingState = (PlayingState)input.ReadEnum();
						continue;
					}
					if (num == 66U)
					{
						if (this.playerInfo_ == null)
						{
							this.PlayerInfo = new PlayerSimpleInfo();
						}
						input.ReadMessage(this.PlayerInfo);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.IsMarked = input.ReadBool();
						continue;
					}
					if (num == 98U)
					{
						this.RemarkName = input.ReadString();
						continue;
					}
					if (num == 106U)
					{
						if (this.eFAEALKEIPD_ == null)
						{
							this.EFAEALKEIPD = new NAAJKLMNIJI();
						}
						input.ReadMessage(this.EFAEALKEIPD);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001A3D RID: 6717
		private static readonly MessageParser<FriendSimpleInfo> _parser = new MessageParser<FriendSimpleInfo>(() => new FriendSimpleInfo());

		// Token: 0x04001A3E RID: 6718
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A3F RID: 6719
		public const int RemarkNameFieldNumber = 12;

		// Token: 0x04001A40 RID: 6720
		private string remarkName_ = "";

		// Token: 0x04001A41 RID: 6721
		public const int PlayerInfoFieldNumber = 8;

		// Token: 0x04001A42 RID: 6722
		private PlayerSimpleInfo playerInfo_;

		// Token: 0x04001A43 RID: 6723
		public const int IsMarkedFieldNumber = 11;

		// Token: 0x04001A44 RID: 6724
		private bool isMarked_;

		// Token: 0x04001A45 RID: 6725
		public const int PlayingStateFieldNumber = 7;

		// Token: 0x04001A46 RID: 6726
		private PlayingState playingState_;

		// Token: 0x04001A47 RID: 6727
		public const int EFAEALKEIPDFieldNumber = 13;

		// Token: 0x04001A48 RID: 6728
		private NAAJKLMNIJI eFAEALKEIPD_;

		// Token: 0x04001A49 RID: 6729
		public const int CreateTimeFieldNumber = 6;

		// Token: 0x04001A4A RID: 6730
		private long createTime_;
	}
}
