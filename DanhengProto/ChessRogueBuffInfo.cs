using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020001EB RID: 491
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueBuffInfo : IMessage<ChessRogueBuffInfo>, IMessage, IEquatable<ChessRogueBuffInfo>, IDeepCloneable<ChessRogueBuffInfo>, IBufferMessage
	{
		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0003EF81 File Offset: 0x0003D181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueBuffInfo> Parser
		{
			get
			{
				return ChessRogueBuffInfo._parser;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060015F2 RID: 5618 RVA: 0x0003EF88 File Offset: 0x0003D188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueBuffInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x0003EF9A File Offset: 0x0003D19A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueBuffInfo.Descriptor;
			}
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0003EFA1 File Offset: 0x0003D1A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffInfo()
		{
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0003EFA9 File Offset: 0x0003D1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffInfo(ChessRogueBuffInfo other) : this()
		{
			this.chessRogueBuffInfo_ = ((other.chessRogueBuffInfo_ != null) ? other.chessRogueBuffInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0003EFDE File Offset: 0x0003D1DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuffInfo Clone()
		{
			return new ChessRogueBuffInfo(this);
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0003EFE6 File Offset: 0x0003D1E6
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0003EFEE File Offset: 0x0003D1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueBuff ChessRogueBuffInfo_
		{
			get
			{
				return this.chessRogueBuffInfo_;
			}
			set
			{
				this.chessRogueBuffInfo_ = value;
			}
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x0003EFF7 File Offset: 0x0003D1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueBuffInfo);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x0003F005 File Offset: 0x0003D205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueBuffInfo other)
		{
			return other != null && (other == this || (object.Equals(this.ChessRogueBuffInfo_, other.ChessRogueBuffInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x0003F038 File Offset: 0x0003D238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chessRogueBuffInfo_ != null)
			{
				num ^= this.ChessRogueBuffInfo_.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x0003F074 File Offset: 0x0003D274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x0003F07C File Offset: 0x0003D27C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0003F085 File Offset: 0x0003D285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.chessRogueBuffInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.ChessRogueBuffInfo_);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x0003F0B8 File Offset: 0x0003D2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chessRogueBuffInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChessRogueBuffInfo_);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x0003F0F8 File Offset: 0x0003D2F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueBuffInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chessRogueBuffInfo_ != null)
			{
				if (this.chessRogueBuffInfo_ == null)
				{
					this.ChessRogueBuffInfo_ = new ChessRogueBuff();
				}
				this.ChessRogueBuffInfo_.MergeFrom(other.ChessRogueBuffInfo_);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x0003F14C File Offset: 0x0003D34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x0003F158 File Offset: 0x0003D358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.chessRogueBuffInfo_ == null)
					{
						this.ChessRogueBuffInfo_ = new ChessRogueBuff();
					}
					input.ReadMessage(this.ChessRogueBuffInfo_);
				}
			}
		}

		// Token: 0x0400093F RID: 2367
		private static readonly MessageParser<ChessRogueBuffInfo> _parser = new MessageParser<ChessRogueBuffInfo>(() => new ChessRogueBuffInfo());

		// Token: 0x04000940 RID: 2368
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000941 RID: 2369
		public const int ChessRogueBuffInfo_FieldNumber = 5;

		// Token: 0x04000942 RID: 2370
		private ChessRogueBuff chessRogueBuffInfo_;
	}
}
