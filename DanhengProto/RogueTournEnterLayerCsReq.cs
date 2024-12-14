using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FA3 RID: 4003
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnterLayerCsReq : IMessage<RogueTournEnterLayerCsReq>, IMessage, IEquatable<RogueTournEnterLayerCsReq>, IDeepCloneable<RogueTournEnterLayerCsReq>, IBufferMessage
	{
		// Token: 0x1700324C RID: 12876
		// (get) Token: 0x0600B258 RID: 45656 RVA: 0x001DF311 File Offset: 0x001DD511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnterLayerCsReq> Parser
		{
			get
			{
				return RogueTournEnterLayerCsReq._parser;
			}
		}

		// Token: 0x1700324D RID: 12877
		// (get) Token: 0x0600B259 RID: 45657 RVA: 0x001DF318 File Offset: 0x001DD518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnterLayerCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700324E RID: 12878
		// (get) Token: 0x0600B25A RID: 45658 RVA: 0x001DF32A File Offset: 0x001DD52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnterLayerCsReq.Descriptor;
			}
		}

		// Token: 0x0600B25B RID: 45659 RVA: 0x001DF331 File Offset: 0x001DD531
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterLayerCsReq()
		{
		}

		// Token: 0x0600B25C RID: 45660 RVA: 0x001DF339 File Offset: 0x001DD539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterLayerCsReq(RogueTournEnterLayerCsReq other) : this()
		{
			this.curLevelIndex_ = other.curLevelIndex_;
			this.nextRoomType_ = other.nextRoomType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B25D RID: 45661 RVA: 0x001DF36A File Offset: 0x001DD56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnterLayerCsReq Clone()
		{
			return new RogueTournEnterLayerCsReq(this);
		}

		// Token: 0x1700324F RID: 12879
		// (get) Token: 0x0600B25E RID: 45662 RVA: 0x001DF372 File Offset: 0x001DD572
		// (set) Token: 0x0600B25F RID: 45663 RVA: 0x001DF37A File Offset: 0x001DD57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurLevelIndex
		{
			get
			{
				return this.curLevelIndex_;
			}
			set
			{
				this.curLevelIndex_ = value;
			}
		}

		// Token: 0x17003250 RID: 12880
		// (get) Token: 0x0600B260 RID: 45664 RVA: 0x001DF383 File Offset: 0x001DD583
		// (set) Token: 0x0600B261 RID: 45665 RVA: 0x001DF38B File Offset: 0x001DD58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NextRoomType
		{
			get
			{
				return this.nextRoomType_;
			}
			set
			{
				this.nextRoomType_ = value;
			}
		}

		// Token: 0x0600B262 RID: 45666 RVA: 0x001DF394 File Offset: 0x001DD594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnterLayerCsReq);
		}

		// Token: 0x0600B263 RID: 45667 RVA: 0x001DF3A2 File Offset: 0x001DD5A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnterLayerCsReq other)
		{
			return other != null && (other == this || (this.CurLevelIndex == other.CurLevelIndex && this.NextRoomType == other.NextRoomType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B264 RID: 45668 RVA: 0x001DF3E0 File Offset: 0x001DD5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurLevelIndex != 0U)
			{
				num ^= this.CurLevelIndex.GetHashCode();
			}
			if (this.NextRoomType != 0U)
			{
				num ^= this.NextRoomType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B265 RID: 45669 RVA: 0x001DF438 File Offset: 0x001DD638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B266 RID: 45670 RVA: 0x001DF440 File Offset: 0x001DD640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B267 RID: 45671 RVA: 0x001DF44C File Offset: 0x001DD64C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NextRoomType != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.NextRoomType);
			}
			if (this.CurLevelIndex != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.CurLevelIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B268 RID: 45672 RVA: 0x001DF4A8 File Offset: 0x001DD6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurLevelIndex != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurLevelIndex);
			}
			if (this.NextRoomType != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NextRoomType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B269 RID: 45673 RVA: 0x001DF500 File Offset: 0x001DD700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnterLayerCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurLevelIndex != 0U)
			{
				this.CurLevelIndex = other.CurLevelIndex;
			}
			if (other.NextRoomType != 0U)
			{
				this.NextRoomType = other.NextRoomType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B26A RID: 45674 RVA: 0x001DF550 File Offset: 0x001DD750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B26B RID: 45675 RVA: 0x001DF55C File Offset: 0x001DD75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurLevelIndex = input.ReadUInt32();
					}
				}
				else
				{
					this.NextRoomType = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400487B RID: 18555
		private static readonly MessageParser<RogueTournEnterLayerCsReq> _parser = new MessageParser<RogueTournEnterLayerCsReq>(() => new RogueTournEnterLayerCsReq());

		// Token: 0x0400487C RID: 18556
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400487D RID: 18557
		public const int CurLevelIndexFieldNumber = 13;

		// Token: 0x0400487E RID: 18558
		private uint curLevelIndex_;

		// Token: 0x0400487F RID: 18559
		public const int NextRoomTypeFieldNumber = 12;

		// Token: 0x04004880 RID: 18560
		private uint nextRoomType_;
	}
}
