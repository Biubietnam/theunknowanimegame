using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DE7 RID: 3559
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueAdventureRoomGameplayWolfGunInfo : IMessage<RogueAdventureRoomGameplayWolfGunInfo>, IMessage, IEquatable<RogueAdventureRoomGameplayWolfGunInfo>, IDeepCloneable<RogueAdventureRoomGameplayWolfGunInfo>, IBufferMessage
	{
		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x06009F47 RID: 40775 RVA: 0x001ABF2B File Offset: 0x001AA12B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueAdventureRoomGameplayWolfGunInfo> Parser
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunInfo._parser;
			}
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x06009F48 RID: 40776 RVA: 0x001ABF32 File Offset: 0x001AA132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x06009F49 RID: 40777 RVA: 0x001ABF44 File Offset: 0x001AA144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueAdventureRoomGameplayWolfGunInfo.Descriptor;
			}
		}

		// Token: 0x06009F4A RID: 40778 RVA: 0x001ABF4B File Offset: 0x001AA14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunInfo()
		{
		}

		// Token: 0x06009F4B RID: 40779 RVA: 0x001ABF53 File Offset: 0x001AA153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunInfo(RogueAdventureRoomGameplayWolfGunInfo other) : this()
		{
			this.gameInfo_ = ((other.gameInfo_ != null) ? other.gameInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009F4C RID: 40780 RVA: 0x001ABF88 File Offset: 0x001AA188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunInfo Clone()
		{
			return new RogueAdventureRoomGameplayWolfGunInfo(this);
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x06009F4D RID: 40781 RVA: 0x001ABF90 File Offset: 0x001AA190
		// (set) Token: 0x06009F4E RID: 40782 RVA: 0x001ABF98 File Offset: 0x001AA198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAdventureRoomGameplayWolfGunGameInfo GameInfo
		{
			get
			{
				return this.gameInfo_;
			}
			set
			{
				this.gameInfo_ = value;
			}
		}

		// Token: 0x06009F4F RID: 40783 RVA: 0x001ABFA1 File Offset: 0x001AA1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueAdventureRoomGameplayWolfGunInfo);
		}

		// Token: 0x06009F50 RID: 40784 RVA: 0x001ABFAF File Offset: 0x001AA1AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueAdventureRoomGameplayWolfGunInfo other)
		{
			return other != null && (other == this || (object.Equals(this.GameInfo, other.GameInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009F51 RID: 40785 RVA: 0x001ABFE4 File Offset: 0x001AA1E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gameInfo_ != null)
			{
				num ^= this.GameInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009F52 RID: 40786 RVA: 0x001AC020 File Offset: 0x001AA220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009F53 RID: 40787 RVA: 0x001AC028 File Offset: 0x001AA228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009F54 RID: 40788 RVA: 0x001AC031 File Offset: 0x001AA231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gameInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.GameInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009F55 RID: 40789 RVA: 0x001AC064 File Offset: 0x001AA264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009F56 RID: 40790 RVA: 0x001AC0A4 File Offset: 0x001AA2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueAdventureRoomGameplayWolfGunInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gameInfo_ != null)
			{
				if (this.gameInfo_ == null)
				{
					this.GameInfo = new RogueAdventureRoomGameplayWolfGunGameInfo();
				}
				this.GameInfo.MergeFrom(other.GameInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009F57 RID: 40791 RVA: 0x001AC0F8 File Offset: 0x001AA2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009F58 RID: 40792 RVA: 0x001AC104 File Offset: 0x001AA304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.gameInfo_ == null)
					{
						this.GameInfo = new RogueAdventureRoomGameplayWolfGunGameInfo();
					}
					input.ReadMessage(this.GameInfo);
				}
			}
		}

		// Token: 0x04004162 RID: 16738
		private static readonly MessageParser<RogueAdventureRoomGameplayWolfGunInfo> _parser = new MessageParser<RogueAdventureRoomGameplayWolfGunInfo>(() => new RogueAdventureRoomGameplayWolfGunInfo());

		// Token: 0x04004163 RID: 16739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004164 RID: 16740
		public const int GameInfoFieldNumber = 11;

		// Token: 0x04004165 RID: 16741
		private RogueAdventureRoomGameplayWolfGunGameInfo gameInfo_;
	}
}
