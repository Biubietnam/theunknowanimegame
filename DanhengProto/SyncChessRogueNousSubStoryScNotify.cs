using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001269 RID: 4713
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncChessRogueNousSubStoryScNotify : IMessage<SyncChessRogueNousSubStoryScNotify>, IMessage, IEquatable<SyncChessRogueNousSubStoryScNotify>, IDeepCloneable<SyncChessRogueNousSubStoryScNotify>, IBufferMessage
	{
		// Token: 0x17003B3A RID: 15162
		// (get) Token: 0x0600D265 RID: 53861 RVA: 0x002324C5 File Offset: 0x002306C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncChessRogueNousSubStoryScNotify> Parser
		{
			get
			{
				return SyncChessRogueNousSubStoryScNotify._parser;
			}
		}

		// Token: 0x17003B3B RID: 15163
		// (get) Token: 0x0600D266 RID: 53862 RVA: 0x002324CC File Offset: 0x002306CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncChessRogueNousSubStoryScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B3C RID: 15164
		// (get) Token: 0x0600D267 RID: 53863 RVA: 0x002324DE File Offset: 0x002306DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncChessRogueNousSubStoryScNotify.Descriptor;
			}
		}

		// Token: 0x0600D268 RID: 53864 RVA: 0x002324E5 File Offset: 0x002306E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousSubStoryScNotify()
		{
		}

		// Token: 0x0600D269 RID: 53865 RVA: 0x002324ED File Offset: 0x002306ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousSubStoryScNotify(SyncChessRogueNousSubStoryScNotify other) : this()
		{
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D26A RID: 53866 RVA: 0x00232512 File Offset: 0x00230712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncChessRogueNousSubStoryScNotify Clone()
		{
			return new SyncChessRogueNousSubStoryScNotify(this);
		}

		// Token: 0x17003B3D RID: 15165
		// (get) Token: 0x0600D26B RID: 53867 RVA: 0x0023251A File Offset: 0x0023071A
		// (set) Token: 0x0600D26C RID: 53868 RVA: 0x00232522 File Offset: 0x00230722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ChessRogueSubStoryId
		{
			get
			{
				return this.chessRogueSubStoryId_;
			}
			set
			{
				this.chessRogueSubStoryId_ = value;
			}
		}

		// Token: 0x0600D26D RID: 53869 RVA: 0x0023252B File Offset: 0x0023072B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncChessRogueNousSubStoryScNotify);
		}

		// Token: 0x0600D26E RID: 53870 RVA: 0x00232539 File Offset: 0x00230739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncChessRogueNousSubStoryScNotify other)
		{
			return other != null && (other == this || (this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D26F RID: 53871 RVA: 0x00232568 File Offset: 0x00230768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num ^= this.ChessRogueSubStoryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D270 RID: 53872 RVA: 0x002325A7 File Offset: 0x002307A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D271 RID: 53873 RVA: 0x002325AF File Offset: 0x002307AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D272 RID: 53874 RVA: 0x002325B8 File Offset: 0x002307B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D273 RID: 53875 RVA: 0x002325EC File Offset: 0x002307EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChessRogueSubStoryId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ChessRogueSubStoryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D274 RID: 53876 RVA: 0x0023262A File Offset: 0x0023082A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncChessRogueNousSubStoryScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChessRogueSubStoryId != 0U)
			{
				this.ChessRogueSubStoryId = other.ChessRogueSubStoryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D275 RID: 53877 RVA: 0x0023265B File Offset: 0x0023085B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D276 RID: 53878 RVA: 0x00232664 File Offset: 0x00230864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChessRogueSubStoryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005454 RID: 21588
		private static readonly MessageParser<SyncChessRogueNousSubStoryScNotify> _parser = new MessageParser<SyncChessRogueNousSubStoryScNotify>(() => new SyncChessRogueNousSubStoryScNotify());

		// Token: 0x04005455 RID: 21589
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005456 RID: 21590
		public const int ChessRogueSubStoryIdFieldNumber = 9;

		// Token: 0x04005457 RID: 21591
		private uint chessRogueSubStoryId_;
	}
}
