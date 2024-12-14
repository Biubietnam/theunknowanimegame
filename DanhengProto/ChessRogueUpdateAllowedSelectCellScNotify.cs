using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002AB RID: 683
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateAllowedSelectCellScNotify : IMessage<ChessRogueUpdateAllowedSelectCellScNotify>, IMessage, IEquatable<ChessRogueUpdateAllowedSelectCellScNotify>, IDeepCloneable<ChessRogueUpdateAllowedSelectCellScNotify>, IBufferMessage
	{
		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00057883 File Offset: 0x00055A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateAllowedSelectCellScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateAllowedSelectCellScNotify._parser;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x0005788A File Offset: 0x00055A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateAllowedSelectCellScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0005789C File Offset: 0x00055A9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateAllowedSelectCellScNotify.Descriptor;
			}
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x000578A3 File Offset: 0x00055AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateAllowedSelectCellScNotify()
		{
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x000578B6 File Offset: 0x00055AB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateAllowedSelectCellScNotify(ChessRogueUpdateAllowedSelectCellScNotify other) : this()
		{
			this.allowSelectCellIdList_ = other.allowSelectCellIdList_.Clone();
			this.boardId_ = other.boardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x000578EC File Offset: 0x00055AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateAllowedSelectCellScNotify Clone()
		{
			return new ChessRogueUpdateAllowedSelectCellScNotify(this);
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x000578F4 File Offset: 0x00055AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AllowSelectCellIdList
		{
			get
			{
				return this.allowSelectCellIdList_;
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x000578FC File Offset: 0x00055AFC
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x00057904 File Offset: 0x00055B04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint BoardId
		{
			get
			{
				return this.boardId_;
			}
			set
			{
				this.boardId_ = value;
			}
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0005790D File Offset: 0x00055B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateAllowedSelectCellScNotify);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0005791C File Offset: 0x00055B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateAllowedSelectCellScNotify other)
		{
			return other != null && (other == this || (this.allowSelectCellIdList_.Equals(other.allowSelectCellIdList_) && this.BoardId == other.BoardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0005796C File Offset: 0x00055B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.allowSelectCellIdList_.GetHashCode();
			if (this.BoardId != 0U)
			{
				num ^= this.BoardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x000579B9 File Offset: 0x00055BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x000579C1 File Offset: 0x00055BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x000579CC File Offset: 0x00055BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.allowSelectCellIdList_.WriteTo(ref output, ChessRogueUpdateAllowedSelectCellScNotify._repeated_allowSelectCellIdList_codec);
			if (this.BoardId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.BoardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00057A1C File Offset: 0x00055C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.allowSelectCellIdList_.CalculateSize(ChessRogueUpdateAllowedSelectCellScNotify._repeated_allowSelectCellIdList_codec);
			if (this.BoardId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.BoardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00057A70 File Offset: 0x00055C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateAllowedSelectCellScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.allowSelectCellIdList_.Add(other.allowSelectCellIdList_);
			if (other.BoardId != 0U)
			{
				this.BoardId = other.BoardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00057ABD File Offset: 0x00055CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00057AC8 File Offset: 0x00055CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U && num != 50U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BoardId = input.ReadUInt32();
					}
				}
				else
				{
					this.allowSelectCellIdList_.AddEntriesFrom(ref input, ChessRogueUpdateAllowedSelectCellScNotify._repeated_allowSelectCellIdList_codec);
				}
			}
		}

		// Token: 0x04000CBD RID: 3261
		private static readonly MessageParser<ChessRogueUpdateAllowedSelectCellScNotify> _parser = new MessageParser<ChessRogueUpdateAllowedSelectCellScNotify>(() => new ChessRogueUpdateAllowedSelectCellScNotify());

		// Token: 0x04000CBE RID: 3262
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CBF RID: 3263
		public const int AllowSelectCellIdListFieldNumber = 6;

		// Token: 0x04000CC0 RID: 3264
		private static readonly FieldCodec<uint> _repeated_allowSelectCellIdList_codec = FieldCodec.ForUInt32(50U);

		// Token: 0x04000CC1 RID: 3265
		private readonly RepeatedField<uint> allowSelectCellIdList_ = new RepeatedField<uint>();

		// Token: 0x04000CC2 RID: 3266
		public const int BoardIdFieldNumber = 7;

		// Token: 0x04000CC3 RID: 3267
		private uint boardId_;
	}
}
