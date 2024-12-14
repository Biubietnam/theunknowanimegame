using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000219 RID: 537
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueFinishCurRoomNotify : IMessage<ChessRogueFinishCurRoomNotify>, IMessage, IEquatable<ChessRogueFinishCurRoomNotify>, IDeepCloneable<ChessRogueFinishCurRoomNotify>, IBufferMessage
	{
		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00044E11 File Offset: 0x00043011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueFinishCurRoomNotify> Parser
		{
			get
			{
				return ChessRogueFinishCurRoomNotify._parser;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x060017ED RID: 6125 RVA: 0x00044E18 File Offset: 0x00043018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueFinishCurRoomNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00044E2A File Offset: 0x0004302A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueFinishCurRoomNotify.Descriptor;
			}
		}

		// Token: 0x060017EF RID: 6127 RVA: 0x00044E31 File Offset: 0x00043031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishCurRoomNotify()
		{
		}

		// Token: 0x060017F0 RID: 6128 RVA: 0x00044E39 File Offset: 0x00043039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishCurRoomNotify(ChessRogueFinishCurRoomNotify other) : this()
		{
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060017F1 RID: 6129 RVA: 0x00044E6E File Offset: 0x0004306E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueFinishCurRoomNotify Clone()
		{
			return new ChessRogueFinishCurRoomNotify(this);
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x00044E76 File Offset: 0x00043076
		// (set) Token: 0x060017F3 RID: 6131 RVA: 0x00044E7E File Offset: 0x0004307E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x060017F4 RID: 6132 RVA: 0x00044E87 File Offset: 0x00043087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueFinishCurRoomNotify);
		}

		// Token: 0x060017F5 RID: 6133 RVA: 0x00044E95 File Offset: 0x00043095
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueFinishCurRoomNotify other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060017F6 RID: 6134 RVA: 0x00044EC8 File Offset: 0x000430C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060017F7 RID: 6135 RVA: 0x00044F04 File Offset: 0x00043104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060017F8 RID: 6136 RVA: 0x00044F0C File Offset: 0x0004310C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060017F9 RID: 6137 RVA: 0x00044F15 File Offset: 0x00043115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060017FA RID: 6138 RVA: 0x00044F48 File Offset: 0x00043148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x00044F88 File Offset: 0x00043188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueFinishCurRoomNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new ChessRogueLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x00044FDC File Offset: 0x000431DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x00044FE8 File Offset: 0x000431E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.levelInfo_ == null)
					{
						this.LevelInfo = new ChessRogueLevelInfo();
					}
					input.ReadMessage(this.LevelInfo);
				}
			}
		}

		// Token: 0x04000A24 RID: 2596
		private static readonly MessageParser<ChessRogueFinishCurRoomNotify> _parser = new MessageParser<ChessRogueFinishCurRoomNotify>(() => new ChessRogueFinishCurRoomNotify());

		// Token: 0x04000A25 RID: 2597
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A26 RID: 2598
		public const int LevelInfoFieldNumber = 14;

		// Token: 0x04000A27 RID: 2599
		private ChessRogueLevelInfo levelInfo_;
	}
}
