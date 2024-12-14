using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE5 RID: 3557
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAdventureRoomGameplayWolfGunGameInfo : IMessage<RogueAdventureRoomGameplayWolfGunGameInfo>, IMessage, IEquatable<RogueAdventureRoomGameplayWolfGunGameInfo>, IDeepCloneable<RogueAdventureRoomGameplayWolfGunGameInfo>, IBufferMessage
	{
		// Token: 0x17002CFC RID: 11516
		// (get) Token: 0x06009F31 RID: 40753 RVA: 0x001ABBBF File Offset: 0x001A9DBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAdventureRoomGameplayWolfGunGameInfo> Parser
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunGameInfo._parser;
			}
		}

		// Token: 0x17002CFD RID: 11517
		// (get) Token: 0x06009F32 RID: 40754 RVA: 0x001ABBC6 File Offset: 0x001A9DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunGameInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CFE RID: 11518
		// (get) Token: 0x06009F33 RID: 40755 RVA: 0x001ABBD8 File Offset: 0x001A9DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunGameInfo.Descriptor;
			}
		}

		// Token: 0x06009F34 RID: 40756 RVA: 0x001ABBDF File Offset: 0x001A9DDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunGameInfo()
		{
		}

		// Token: 0x06009F35 RID: 40757 RVA: 0x001ABBF2 File Offset: 0x001A9DF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunGameInfo(RogueAdventureRoomGameplayWolfGunGameInfo other) : this()
		{
			this.gameTargetNum_ = other.gameTargetNum_;
			this.battleTargetList_ = other.battleTargetList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F36 RID: 40758 RVA: 0x001ABC28 File Offset: 0x001A9E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunGameInfo Clone()
		{
			return new RogueAdventureRoomGameplayWolfGunGameInfo(this);
		}

		// Token: 0x17002CFF RID: 11519
		// (get) Token: 0x06009F37 RID: 40759 RVA: 0x001ABC30 File Offset: 0x001A9E30
		// (set) Token: 0x06009F38 RID: 40760 RVA: 0x001ABC38 File Offset: 0x001A9E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GameTargetNum
		{
			get
			{
				return this.gameTargetNum_;
			}
			set
			{
				this.gameTargetNum_ = value;
			}
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x06009F39 RID: 40761 RVA: 0x001ABC41 File Offset: 0x001A9E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueAdventureRoomGameplayWolfGunTarget> BattleTargetList
		{
			get
			{
				return this.battleTargetList_;
			}
		}

		// Token: 0x06009F3A RID: 40762 RVA: 0x001ABC49 File Offset: 0x001A9E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAdventureRoomGameplayWolfGunGameInfo);
		}

		// Token: 0x06009F3B RID: 40763 RVA: 0x001ABC58 File Offset: 0x001A9E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAdventureRoomGameplayWolfGunGameInfo other)
		{
			return other != null && (other == this || (this.GameTargetNum == other.GameTargetNum && this.battleTargetList_.Equals(other.battleTargetList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F3C RID: 40764 RVA: 0x001ABCA8 File Offset: 0x001A9EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GameTargetNum != 0U)
			{
				num ^= this.GameTargetNum.GetHashCode();
			}
			num ^= this.battleTargetList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F3D RID: 40765 RVA: 0x001ABCF5 File Offset: 0x001A9EF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F3E RID: 40766 RVA: 0x001ABCFD File Offset: 0x001A9EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F3F RID: 40767 RVA: 0x001ABD08 File Offset: 0x001A9F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.battleTargetList_.WriteTo(ref output, RogueAdventureRoomGameplayWolfGunGameInfo._repeated_battleTargetList_codec);
			if (this.GameTargetNum != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.GameTargetNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F40 RID: 40768 RVA: 0x001ABD58 File Offset: 0x001A9F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GameTargetNum != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameTargetNum);
			}
			num += this.battleTargetList_.CalculateSize(RogueAdventureRoomGameplayWolfGunGameInfo._repeated_battleTargetList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F41 RID: 40769 RVA: 0x001ABDAC File Offset: 0x001A9FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAdventureRoomGameplayWolfGunGameInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GameTargetNum != 0U)
			{
				this.GameTargetNum = other.GameTargetNum;
			}
			this.battleTargetList_.Add(other.battleTargetList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F42 RID: 40770 RVA: 0x001ABDF9 File Offset: 0x001A9FF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F43 RID: 40771 RVA: 0x001ABE04 File Offset: 0x001AA004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GameTargetNum = input.ReadUInt32();
					}
				}
				else
				{
					this.battleTargetList_.AddEntriesFrom(ref input, RogueAdventureRoomGameplayWolfGunGameInfo._repeated_battleTargetList_codec);
				}
			}
		}

		// Token: 0x0400415A RID: 16730
		private static readonly MessageParser<RogueAdventureRoomGameplayWolfGunGameInfo> _parser = new MessageParser<RogueAdventureRoomGameplayWolfGunGameInfo>(() => new RogueAdventureRoomGameplayWolfGunGameInfo());

		// Token: 0x0400415B RID: 16731
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400415C RID: 16732
		public const int GameTargetNumFieldNumber = 4;

		// Token: 0x0400415D RID: 16733
		private uint gameTargetNum_;

		// Token: 0x0400415E RID: 16734
		public const int BattleTargetListFieldNumber = 2;

		// Token: 0x0400415F RID: 16735
		private static readonly FieldCodec<RogueAdventureRoomGameplayWolfGunTarget> _repeated_battleTargetList_codec = FieldCodec.ForMessage<RogueAdventureRoomGameplayWolfGunTarget>(18U, RogueAdventureRoomGameplayWolfGunTarget.Parser);

		// Token: 0x04004160 RID: 16736
		private readonly RepeatedField<RogueAdventureRoomGameplayWolfGunTarget> battleTargetList_ = new RepeatedField<RogueAdventureRoomGameplayWolfGunTarget>();
	}
}
