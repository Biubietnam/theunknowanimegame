using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A3D RID: 2621
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LobbyInviteScNotify : IMessage<LobbyInviteScNotify>, IMessage, IEquatable<LobbyInviteScNotify>, IDeepCloneable<LobbyInviteScNotify>, IBufferMessage
	{
		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x0600744C RID: 29772 RVA: 0x0013543F File Offset: 0x0013363F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LobbyInviteScNotify> Parser
		{
			get
			{
				return LobbyInviteScNotify._parser;
			}
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x0600744D RID: 29773 RVA: 0x00135446 File Offset: 0x00133646
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LobbyInviteScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x0600744E RID: 29774 RVA: 0x00135458 File Offset: 0x00133658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LobbyInviteScNotify.Descriptor;
			}
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x0013545F File Offset: 0x0013365F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteScNotify()
		{
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x00135467 File Offset: 0x00133667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteScNotify(LobbyInviteScNotify other) : this()
		{
			this.mGAIAJAKPEI_ = other.mGAIAJAKPEI_;
			this.roomId_ = other.roomId_;
			this.senderId_ = other.senderId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x001354A4 File Offset: 0x001336A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LobbyInviteScNotify Clone()
		{
			return new LobbyInviteScNotify(this);
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06007452 RID: 29778 RVA: 0x001354AC File Offset: 0x001336AC
		// (set) Token: 0x06007453 RID: 29779 RVA: 0x001354B4 File Offset: 0x001336B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FightGameMode MGAIAJAKPEI
		{
			get
			{
				return this.mGAIAJAKPEI_;
			}
			set
			{
				this.mGAIAJAKPEI_ = value;
			}
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x001354BD File Offset: 0x001336BD
		// (set) Token: 0x06007455 RID: 29781 RVA: 0x001354C5 File Offset: 0x001336C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint RoomId
		{
			get
			{
				return this.roomId_;
			}
			set
			{
				this.roomId_ = value;
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06007456 RID: 29782 RVA: 0x001354CE File Offset: 0x001336CE
		// (set) Token: 0x06007457 RID: 29783 RVA: 0x001354D6 File Offset: 0x001336D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		// Token: 0x06007458 RID: 29784 RVA: 0x001354DF File Offset: 0x001336DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LobbyInviteScNotify);
		}

		// Token: 0x06007459 RID: 29785 RVA: 0x001354F0 File Offset: 0x001336F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LobbyInviteScNotify other)
		{
			return other != null && (other == this || (this.MGAIAJAKPEI == other.MGAIAJAKPEI && this.RoomId == other.RoomId && this.SenderId == other.SenderId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x0013554C File Offset: 0x0013374C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num ^= this.MGAIAJAKPEI.GetHashCode();
			}
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this.SenderId != 0U)
			{
				num ^= this.SenderId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x001355C3 File Offset: 0x001337C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x001355CB File Offset: 0x001337CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x001355D4 File Offset: 0x001337D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.RoomId);
			}
			if (this.SenderId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.SenderId);
			}
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.MGAIAJAKPEI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x0013564C File Offset: 0x0013384C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MGAIAJAKPEI != FightGameMode.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.MGAIAJAKPEI);
			}
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this.SenderId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SenderId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600745F RID: 29791 RVA: 0x001356BC File Offset: 0x001338BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LobbyInviteScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MGAIAJAKPEI != FightGameMode.None)
			{
				this.MGAIAJAKPEI = other.MGAIAJAKPEI;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			if (other.SenderId != 0U)
			{
				this.SenderId = other.SenderId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x00135720 File Offset: 0x00133920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x0013572C File Offset: 0x0013392C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 40U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MGAIAJAKPEI = (FightGameMode)input.ReadEnum();
						}
					}
					else
					{
						this.SenderId = input.ReadUInt32();
					}
				}
				else
				{
					this.RoomId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04002CBE RID: 11454
		private static readonly MessageParser<LobbyInviteScNotify> _parser = new MessageParser<LobbyInviteScNotify>(() => new LobbyInviteScNotify());

		// Token: 0x04002CBF RID: 11455
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CC0 RID: 11456
		public const int MGAIAJAKPEIFieldNumber = 11;

		// Token: 0x04002CC1 RID: 11457
		private FightGameMode mGAIAJAKPEI_;

		// Token: 0x04002CC2 RID: 11458
		public const int RoomIdFieldNumber = 3;

		// Token: 0x04002CC3 RID: 11459
		private uint roomId_;

		// Token: 0x04002CC4 RID: 11460
		public const int SenderIdFieldNumber = 5;

		// Token: 0x04002CC5 RID: 11461
		private uint senderId_;
	}
}
