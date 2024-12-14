using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000261 RID: 609
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueNousSubStoryInfo : IMessage<ChessRogueNousSubStoryInfo>, IMessage, IEquatable<ChessRogueNousSubStoryInfo>, IDeepCloneable<ChessRogueNousSubStoryInfo>, IBufferMessage
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001B30 RID: 6960 RVA: 0x0004E7FD File Offset: 0x0004C9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueNousSubStoryInfo> Parser
		{
			get
			{
				return ChessRogueNousSubStoryInfo._parser;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001B31 RID: 6961 RVA: 0x0004E804 File Offset: 0x0004CA04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueNousSubStoryInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0004E816 File Offset: 0x0004CA16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueNousSubStoryInfo.Descriptor;
			}
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x0004E81D File Offset: 0x0004CA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousSubStoryInfo()
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x0004E825 File Offset: 0x0004CA25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousSubStoryInfo(ChessRogueNousSubStoryInfo other) : this()
		{
			this.chessRogueSubStoryId_ = other.chessRogueSubStoryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0004E84A File Offset: 0x0004CA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueNousSubStoryInfo Clone()
		{
			return new ChessRogueNousSubStoryInfo(this);
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001B36 RID: 6966 RVA: 0x0004E852 File Offset: 0x0004CA52
		// (set) Token: 0x06001B37 RID: 6967 RVA: 0x0004E85A File Offset: 0x0004CA5A
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

		// Token: 0x06001B38 RID: 6968 RVA: 0x0004E863 File Offset: 0x0004CA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueNousSubStoryInfo);
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x0004E871 File Offset: 0x0004CA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueNousSubStoryInfo other)
		{
			return other != null && (other == this || (this.ChessRogueSubStoryId == other.ChessRogueSubStoryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
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

		// Token: 0x06001B3B RID: 6971 RVA: 0x0004E8DF File Offset: 0x0004CADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0004E8E7 File Offset: 0x0004CAE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0004E8F0 File Offset: 0x0004CAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChessRogueSubStoryId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.ChessRogueSubStoryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0004E924 File Offset: 0x0004CB24
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

		// Token: 0x06001B3F RID: 6975 RVA: 0x0004E962 File Offset: 0x0004CB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueNousSubStoryInfo other)
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

		// Token: 0x06001B40 RID: 6976 RVA: 0x0004E993 File Offset: 0x0004CB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0004E99C File Offset: 0x0004CB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ChessRogueSubStoryId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000B7B RID: 2939
		private static readonly MessageParser<ChessRogueNousSubStoryInfo> _parser = new MessageParser<ChessRogueNousSubStoryInfo>(() => new ChessRogueNousSubStoryInfo());

		// Token: 0x04000B7C RID: 2940
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B7D RID: 2941
		public const int ChessRogueSubStoryIdFieldNumber = 6;

		// Token: 0x04000B7E RID: 2942
		private uint chessRogueSubStoryId_;
	}
}
