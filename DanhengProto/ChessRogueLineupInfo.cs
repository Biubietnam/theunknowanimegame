using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000241 RID: 577
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueLineupInfo : IMessage<ChessRogueLineupInfo>, IMessage, IEquatable<ChessRogueLineupInfo>, IDeepCloneable<ChessRogueLineupInfo>, IBufferMessage
	{
		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x0004B9DB File Offset: 0x00049BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueLineupInfo> Parser
		{
			get
			{
				return ChessRogueLineupInfo._parser;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x0004B9E2 File Offset: 0x00049BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueLineupInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x0004B9F4 File Offset: 0x00049BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueLineupInfo.Descriptor;
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0004B9FB File Offset: 0x00049BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupInfo()
		{
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0004BA10 File Offset: 0x00049C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupInfo(ChessRogueLineupInfo other) : this()
		{
			this.chessAvatarList_ = other.chessAvatarList_.Clone();
			this.reviveInfo_ = ((other.reviveInfo_ != null) ? other.reviveInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0004BA61 File Offset: 0x00049C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupInfo Clone()
		{
			return new ChessRogueLineupInfo(this);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0004BA69 File Offset: 0x00049C69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ChessRogueLineupAvatarInfo> ChessAvatarList
		{
			get
			{
				return this.chessAvatarList_;
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0004BA71 File Offset: 0x00049C71
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x0004BA79 File Offset: 0x00049C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueAvatarReviveCost ReviveInfo
		{
			get
			{
				return this.reviveInfo_;
			}
			set
			{
				this.reviveInfo_ = value;
			}
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0004BA82 File Offset: 0x00049C82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueLineupInfo);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0004BA90 File Offset: 0x00049C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueLineupInfo other)
		{
			return other != null && (other == this || (this.chessAvatarList_.Equals(other.chessAvatarList_) && object.Equals(this.ReviveInfo, other.ReviveInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0004BAE4 File Offset: 0x00049CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.chessAvatarList_.GetHashCode();
			if (this.reviveInfo_ != null)
			{
				num ^= this.ReviveInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0004BB2E File Offset: 0x00049D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0004BB36 File Offset: 0x00049D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0004BB40 File Offset: 0x00049D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.chessAvatarList_.WriteTo(ref output, ChessRogueLineupInfo._repeated_chessAvatarList_codec);
			if (this.reviveInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ReviveInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0004BB90 File Offset: 0x00049D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.chessAvatarList_.CalculateSize(ChessRogueLineupInfo._repeated_chessAvatarList_codec);
			if (this.reviveInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ReviveInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0004BBE4 File Offset: 0x00049DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueLineupInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.chessAvatarList_.Add(other.chessAvatarList_);
			if (other.reviveInfo_ != null)
			{
				if (this.reviveInfo_ == null)
				{
					this.ReviveInfo = new RogueAvatarReviveCost();
				}
				this.ReviveInfo.MergeFrom(other.ReviveInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0004BC49 File Offset: 0x00049E49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0004BC54 File Offset: 0x00049E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.reviveInfo_ == null)
						{
							this.ReviveInfo = new RogueAvatarReviveCost();
						}
						input.ReadMessage(this.ReviveInfo);
					}
				}
				else
				{
					this.chessAvatarList_.AddEntriesFrom(ref input, ChessRogueLineupInfo._repeated_chessAvatarList_codec);
				}
			}
		}

		// Token: 0x04000B13 RID: 2835
		private static readonly MessageParser<ChessRogueLineupInfo> _parser = new MessageParser<ChessRogueLineupInfo>(() => new ChessRogueLineupInfo());

		// Token: 0x04000B14 RID: 2836
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B15 RID: 2837
		public const int ChessAvatarListFieldNumber = 9;

		// Token: 0x04000B16 RID: 2838
		private static readonly FieldCodec<ChessRogueLineupAvatarInfo> _repeated_chessAvatarList_codec = FieldCodec.ForMessage<ChessRogueLineupAvatarInfo>(74U, ChessRogueLineupAvatarInfo.Parser);

		// Token: 0x04000B17 RID: 2839
		private readonly RepeatedField<ChessRogueLineupAvatarInfo> chessAvatarList_ = new RepeatedField<ChessRogueLineupAvatarInfo>();

		// Token: 0x04000B18 RID: 2840
		public const int ReviveInfoFieldNumber = 14;

		// Token: 0x04000B19 RID: 2841
		private RogueAvatarReviveCost reviveInfo_;
	}
}
