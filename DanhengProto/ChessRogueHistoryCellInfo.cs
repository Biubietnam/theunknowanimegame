using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200022F RID: 559
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueHistoryCellInfo : IMessage<ChessRogueHistoryCellInfo>, IMessage, IEquatable<ChessRogueHistoryCellInfo>, IDeepCloneable<ChessRogueHistoryCellInfo>, IBufferMessage
	{
		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00049455 File Offset: 0x00047655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueHistoryCellInfo> Parser
		{
			get
			{
				return ChessRogueHistoryCellInfo._parser;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x0004945C File Offset: 0x0004765C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueHistoryCellInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0004946E File Offset: 0x0004766E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueHistoryCellInfo.Descriptor;
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00049475 File Offset: 0x00047675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueHistoryCellInfo()
		{
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0004947D File Offset: 0x0004767D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueHistoryCellInfo(ChessRogueHistoryCellInfo other) : this()
		{
			this.cellId_ = other.cellId_;
			this.roomId_ = other.roomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x000494AE File Offset: 0x000476AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueHistoryCellInfo Clone()
		{
			return new ChessRogueHistoryCellInfo(this);
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x000494B6 File Offset: 0x000476B6
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x000494BE File Offset: 0x000476BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CellId
		{
			get
			{
				return this.cellId_;
			}
			set
			{
				this.cellId_ = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x000494C7 File Offset: 0x000476C7
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x000494CF File Offset: 0x000476CF
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

		// Token: 0x06001933 RID: 6451 RVA: 0x000494D8 File Offset: 0x000476D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueHistoryCellInfo);
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x000494E6 File Offset: 0x000476E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueHistoryCellInfo other)
		{
			return other != null && (other == this || (this.CellId == other.CellId && this.RoomId == other.RoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001935 RID: 6453 RVA: 0x00049524 File Offset: 0x00047724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CellId != 0U)
			{
				num ^= this.CellId.GetHashCode();
			}
			if (this.RoomId != 0U)
			{
				num ^= this.RoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001936 RID: 6454 RVA: 0x0004957C File Offset: 0x0004777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x00049584 File Offset: 0x00047784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x00049590 File Offset: 0x00047790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CellId);
			}
			if (this.RoomId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x000495EC File Offset: 0x000477EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CellId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CellId);
			}
			if (this.RoomId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.RoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00049644 File Offset: 0x00047844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueHistoryCellInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellId != 0U)
			{
				this.CellId = other.CellId;
			}
			if (other.RoomId != 0U)
			{
				this.RoomId = other.RoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600193B RID: 6459 RVA: 0x00049694 File Offset: 0x00047894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000496A0 File Offset: 0x000478A0
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
						this.RoomId = input.ReadUInt32();
					}
				}
				else
				{
					this.CellId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000AB9 RID: 2745
		private static readonly MessageParser<ChessRogueHistoryCellInfo> _parser = new MessageParser<ChessRogueHistoryCellInfo>(() => new ChessRogueHistoryCellInfo());

		// Token: 0x04000ABA RID: 2746
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000ABB RID: 2747
		public const int CellIdFieldNumber = 4;

		// Token: 0x04000ABC RID: 2748
		private uint cellId_;

		// Token: 0x04000ABD RID: 2749
		public const int RoomIdFieldNumber = 7;

		// Token: 0x04000ABE RID: 2750
		private uint roomId_;
	}
}
