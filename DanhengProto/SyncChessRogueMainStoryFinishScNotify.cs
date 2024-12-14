using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001265 RID: 4709
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncChessRogueMainStoryFinishScNotify : IMessage<SyncChessRogueMainStoryFinishScNotify>, IMessage, IEquatable<SyncChessRogueMainStoryFinishScNotify>, IDeepCloneable<SyncChessRogueMainStoryFinishScNotify>, IBufferMessage
	{
		// Token: 0x17003B2F RID: 15151
		// (get) Token: 0x0600D23A RID: 53818 RVA: 0x00231EFB File Offset: 0x002300FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncChessRogueMainStoryFinishScNotify> Parser
		{
			get
			{
				return SyncChessRogueMainStoryFinishScNotify._parser;
			}
		}

		// Token: 0x17003B30 RID: 15152
		// (get) Token: 0x0600D23B RID: 53819 RVA: 0x00231F02 File Offset: 0x00230102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncChessRogueMainStoryFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B31 RID: 15153
		// (get) Token: 0x0600D23C RID: 53820 RVA: 0x00231F14 File Offset: 0x00230114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncChessRogueMainStoryFinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600D23D RID: 53821 RVA: 0x00231F1B File Offset: 0x0023011B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueMainStoryFinishScNotify()
		{
		}

		// Token: 0x0600D23E RID: 53822 RVA: 0x00231F23 File Offset: 0x00230123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueMainStoryFinishScNotify(SyncChessRogueMainStoryFinishScNotify other) : this()
		{
			this.lACBICGDLJH_ = other.lACBICGDLJH_;
			this.chessRogueMainStoryId_ = other.chessRogueMainStoryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D23F RID: 53823 RVA: 0x00231F54 File Offset: 0x00230154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueMainStoryFinishScNotify Clone()
		{
			return new SyncChessRogueMainStoryFinishScNotify(this);
		}

		// Token: 0x17003B32 RID: 15154
		// (get) Token: 0x0600D240 RID: 53824 RVA: 0x00231F5C File Offset: 0x0023015C
		// (set) Token: 0x0600D241 RID: 53825 RVA: 0x00231F64 File Offset: 0x00230164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LACBICGDLJH
		{
			get
			{
				return this.lACBICGDLJH_;
			}
			set
			{
				this.lACBICGDLJH_ = value;
			}
		}

		// Token: 0x17003B33 RID: 15155
		// (get) Token: 0x0600D242 RID: 53826 RVA: 0x00231F6D File Offset: 0x0023016D
		// (set) Token: 0x0600D243 RID: 53827 RVA: 0x00231F75 File Offset: 0x00230175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueMainStoryId
		{
			get
			{
				return this.chessRogueMainStoryId_;
			}
			set
			{
				this.chessRogueMainStoryId_ = value;
			}
		}

		// Token: 0x0600D244 RID: 53828 RVA: 0x00231F7E File Offset: 0x0023017E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncChessRogueMainStoryFinishScNotify);
		}

		// Token: 0x0600D245 RID: 53829 RVA: 0x00231F8C File Offset: 0x0023018C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncChessRogueMainStoryFinishScNotify other)
		{
			return other != null && (other == this || (this.LACBICGDLJH == other.LACBICGDLJH && this.ChessRogueMainStoryId == other.ChessRogueMainStoryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D246 RID: 53830 RVA: 0x00231FCC File Offset: 0x002301CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LACBICGDLJH != 0U)
			{
				num ^= this.LACBICGDLJH.GetHashCode();
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num ^= this.ChessRogueMainStoryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D247 RID: 53831 RVA: 0x00232024 File Offset: 0x00230224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D248 RID: 53832 RVA: 0x0023202C File Offset: 0x0023022C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D249 RID: 53833 RVA: 0x00232038 File Offset: 0x00230238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChessRogueMainStoryId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.ChessRogueMainStoryId);
			}
			if (this.LACBICGDLJH != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.LACBICGDLJH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D24A RID: 53834 RVA: 0x00232094 File Offset: 0x00230294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LACBICGDLJH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LACBICGDLJH);
			}
			if (this.ChessRogueMainStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueMainStoryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D24B RID: 53835 RVA: 0x002320EC File Offset: 0x002302EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncChessRogueMainStoryFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LACBICGDLJH != 0U)
			{
				this.LACBICGDLJH = other.LACBICGDLJH;
			}
			if (other.ChessRogueMainStoryId != 0U)
			{
				this.ChessRogueMainStoryId = other.ChessRogueMainStoryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D24C RID: 53836 RVA: 0x0023213C File Offset: 0x0023033C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D24D RID: 53837 RVA: 0x00232148 File Offset: 0x00230348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LACBICGDLJH = input.ReadUInt32();
					}
				}
				else
				{
					this.ChessRogueMainStoryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005447 RID: 21575
		private static readonly MessageParser<SyncChessRogueMainStoryFinishScNotify> _parser = new MessageParser<SyncChessRogueMainStoryFinishScNotify>(() => new SyncChessRogueMainStoryFinishScNotify());

		// Token: 0x04005448 RID: 21576
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005449 RID: 21577
		public const int LACBICGDLJHFieldNumber = 7;

		// Token: 0x0400544A RID: 21578
		private uint lACBICGDLJH_;

		// Token: 0x0400544B RID: 21579
		public const int ChessRogueMainStoryIdFieldNumber = 4;

		// Token: 0x0400544C RID: 21580
		private uint chessRogueMainStoryId_;
	}
}
