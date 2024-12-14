using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005C1 RID: 1473
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FriendApplyInfo : IMessage<FriendApplyInfo>, IMessage, IEquatable<FriendApplyInfo>, IDeepCloneable<FriendApplyInfo>, IBufferMessage
	{
		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x060041D6 RID: 16854 RVA: 0x000B3345 File Offset: 0x000B1545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FriendApplyInfo> Parser
		{
			get
			{
				return FriendApplyInfo._parser;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x000B334C File Offset: 0x000B154C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FriendApplyInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x000B335E File Offset: 0x000B155E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendApplyInfo.Descriptor;
			}
		}

		// Token: 0x060041D9 RID: 16857 RVA: 0x000B3365 File Offset: 0x000B1565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyInfo()
		{
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x000B3370 File Offset: 0x000B1570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyInfo(FriendApplyInfo other) : this()
		{
			this.applyTime_ = other.applyTime_;
			this.playerInfo_ = ((other.playerInfo_ != null) ? other.playerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060041DB RID: 16859 RVA: 0x000B33BC File Offset: 0x000B15BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendApplyInfo Clone()
		{
			return new FriendApplyInfo(this);
		}

		// Token: 0x170012B8 RID: 4792
		// (get) Token: 0x060041DC RID: 16860 RVA: 0x000B33C4 File Offset: 0x000B15C4
		// (set) Token: 0x060041DD RID: 16861 RVA: 0x000B33CC File Offset: 0x000B15CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ApplyTime
		{
			get
			{
				return this.applyTime_;
			}
			set
			{
				this.applyTime_ = value;
			}
		}

		// Token: 0x170012B9 RID: 4793
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x000B33D5 File Offset: 0x000B15D5
		// (set) Token: 0x060041DF RID: 16863 RVA: 0x000B33DD File Offset: 0x000B15DD
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

		// Token: 0x060041E0 RID: 16864 RVA: 0x000B33E6 File Offset: 0x000B15E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendApplyInfo);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x000B33F4 File Offset: 0x000B15F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendApplyInfo other)
		{
			return other != null && (other == this || (this.ApplyTime == other.ApplyTime && object.Equals(this.PlayerInfo, other.PlayerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x000B3444 File Offset: 0x000B1644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ApplyTime != 0L)
			{
				num ^= this.ApplyTime.GetHashCode();
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

		// Token: 0x060041E3 RID: 16867 RVA: 0x000B3499 File Offset: 0x000B1699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x000B34A1 File Offset: 0x000B16A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x000B34AC File Offset: 0x000B16AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.playerInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.PlayerInfo);
			}
			if (this.ApplyTime != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.ApplyTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060041E6 RID: 16870 RVA: 0x000B3508 File Offset: 0x000B1708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ApplyTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ApplyTime);
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

		// Token: 0x060041E7 RID: 16871 RVA: 0x000B3560 File Offset: 0x000B1760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendApplyInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ApplyTime != 0L)
			{
				this.ApplyTime = other.ApplyTime;
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

		// Token: 0x060041E8 RID: 16872 RVA: 0x000B35C8 File Offset: 0x000B17C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x000B35D4 File Offset: 0x000B17D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ApplyTime = input.ReadInt64();
					}
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
		}

		// Token: 0x04001A1B RID: 6683
		private static readonly MessageParser<FriendApplyInfo> _parser = new MessageParser<FriendApplyInfo>(() => new FriendApplyInfo());

		// Token: 0x04001A1C RID: 6684
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A1D RID: 6685
		public const int ApplyTimeFieldNumber = 15;

		// Token: 0x04001A1E RID: 6686
		private long applyTime_;

		// Token: 0x04001A1F RID: 6687
		public const int PlayerInfoFieldNumber = 9;

		// Token: 0x04001A20 RID: 6688
		private PlayerSimpleInfo playerInfo_;
	}
}
