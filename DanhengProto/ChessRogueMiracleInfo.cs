using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000245 RID: 581
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueMiracleInfo : IMessage<ChessRogueMiracleInfo>, IMessage, IEquatable<ChessRogueMiracleInfo>, IDeepCloneable<ChessRogueMiracleInfo>, IBufferMessage
	{
		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x0004BFE9 File Offset: 0x0004A1E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueMiracleInfo> Parser
		{
			get
			{
				return ChessRogueMiracleInfo._parser;
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0004BFF0 File Offset: 0x0004A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueMiracleInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0004C002 File Offset: 0x0004A202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueMiracleInfo.Descriptor;
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0004C009 File Offset: 0x0004A209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracleInfo()
		{
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0004C011 File Offset: 0x0004A211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracleInfo(ChessRogueMiracleInfo other) : this()
		{
			this.chessRogueMiracleInfo_ = ((other.chessRogueMiracleInfo_ != null) ? other.chessRogueMiracleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0004C046 File Offset: 0x0004A246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracleInfo Clone()
		{
			return new ChessRogueMiracleInfo(this);
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0004C04E File Offset: 0x0004A24E
		// (set) Token: 0x06001A26 RID: 6694 RVA: 0x0004C056 File Offset: 0x0004A256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueMiracle ChessRogueMiracleInfo_
		{
			get
			{
				return this.chessRogueMiracleInfo_;
			}
			set
			{
				this.chessRogueMiracleInfo_ = value;
			}
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0004C05F File Offset: 0x0004A25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueMiracleInfo);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0004C06D File Offset: 0x0004A26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueMiracleInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ChessRogueMiracleInfo_, other.ChessRogueMiracleInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0004C0A0 File Offset: 0x0004A2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chessRogueMiracleInfo_ != null)
			{
				num ^= this.ChessRogueMiracleInfo_.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0004C0DC File Offset: 0x0004A2DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0004C0E4 File Offset: 0x0004A2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0004C0ED File Offset: 0x0004A2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.chessRogueMiracleInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.ChessRogueMiracleInfo_);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0004C120 File Offset: 0x0004A320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chessRogueMiracleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessRogueMiracleInfo_);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0004C160 File Offset: 0x0004A360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueMiracleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chessRogueMiracleInfo_ != null)
			{
				if (this.chessRogueMiracleInfo_ == null)
				{
					this.ChessRogueMiracleInfo_ = new ChessRogueMiracle();
				}
				this.ChessRogueMiracleInfo_.MergeFrom(other.ChessRogueMiracleInfo_);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0004C1B4 File Offset: 0x0004A3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0004C1C0 File Offset: 0x0004A3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.chessRogueMiracleInfo_ == null)
					{
						this.ChessRogueMiracleInfo_ = new ChessRogueMiracle();
					}
					input.ReadMessage(this.ChessRogueMiracleInfo_);
				}
			}
		}

		// Token: 0x04000B21 RID: 2849
		private static readonly MessageParser<ChessRogueMiracleInfo> _parser = new MessageParser<ChessRogueMiracleInfo>(() => new ChessRogueMiracleInfo());

		// Token: 0x04000B22 RID: 2850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B23 RID: 2851
		public const int ChessRogueMiracleInfo_FieldNumber = 12;

		// Token: 0x04000B24 RID: 2852
		private ChessRogueMiracle chessRogueMiracleInfo_;
	}
}
