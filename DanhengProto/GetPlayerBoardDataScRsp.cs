using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000767 RID: 1895
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerBoardDataScRsp : IMessage<GetPlayerBoardDataScRsp>, IMessage, IEquatable<GetPlayerBoardDataScRsp>, IDeepCloneable<GetPlayerBoardDataScRsp>, IBufferMessage
	{
		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x060054A8 RID: 21672 RVA: 0x000E3907 File Offset: 0x000E1B07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerBoardDataScRsp> Parser
		{
			get
			{
				return GetPlayerBoardDataScRsp._parser;
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x060054A9 RID: 21673 RVA: 0x000E390E File Offset: 0x000E1B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerBoardDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x060054AA RID: 21674 RVA: 0x000E3920 File Offset: 0x000E1B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerBoardDataScRsp.Descriptor;
			}
		}

		// Token: 0x060054AB RID: 21675 RVA: 0x000E3927 File Offset: 0x000E1B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerBoardDataScRsp()
		{
		}

		// Token: 0x060054AC RID: 21676 RVA: 0x000E3950 File Offset: 0x000E1B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerBoardDataScRsp(GetPlayerBoardDataScRsp other) : this()
		{
			this.assistAvatarIdList_ = other.assistAvatarIdList_.Clone();
			this.displayAvatarVec_ = ((other.displayAvatarVec_ != null) ? other.displayAvatarVec_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.currentHeadIconId_ = other.currentHeadIconId_;
			this.signature_ = other.signature_;
			this.unlockedHeadIconList_ = other.unlockedHeadIconList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054AD RID: 21677 RVA: 0x000E39D6 File Offset: 0x000E1BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerBoardDataScRsp Clone()
		{
			return new GetPlayerBoardDataScRsp(this);
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x060054AE RID: 21678 RVA: 0x000E39DE File Offset: 0x000E1BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> AssistAvatarIdList
		{
			get
			{
				return this.assistAvatarIdList_;
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x060054AF RID: 21679 RVA: 0x000E39E6 File Offset: 0x000E1BE6
		// (set) Token: 0x060054B0 RID: 21680 RVA: 0x000E39EE File Offset: 0x000E1BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DisplayAvatarVec DisplayAvatarVec
		{
			get
			{
				return this.displayAvatarVec_;
			}
			set
			{
				this.displayAvatarVec_ = value;
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x060054B1 RID: 21681 RVA: 0x000E39F7 File Offset: 0x000E1BF7
		// (set) Token: 0x060054B2 RID: 21682 RVA: 0x000E39FF File Offset: 0x000E1BFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x060054B3 RID: 21683 RVA: 0x000E3A08 File Offset: 0x000E1C08
		// (set) Token: 0x060054B4 RID: 21684 RVA: 0x000E3A10 File Offset: 0x000E1C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CurrentHeadIconId
		{
			get
			{
				return this.currentHeadIconId_;
			}
			set
			{
				this.currentHeadIconId_ = value;
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x060054B5 RID: 21685 RVA: 0x000E3A19 File Offset: 0x000E1C19
		// (set) Token: 0x060054B6 RID: 21686 RVA: 0x000E3A21 File Offset: 0x000E1C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Signature
		{
			get
			{
				return this.signature_;
			}
			set
			{
				this.signature_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x060054B7 RID: 21687 RVA: 0x000E3A34 File Offset: 0x000E1C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HeadIconData> UnlockedHeadIconList
		{
			get
			{
				return this.unlockedHeadIconList_;
			}
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x000E3A3C File Offset: 0x000E1C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerBoardDataScRsp);
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x000E3A4C File Offset: 0x000E1C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerBoardDataScRsp other)
		{
			return other != null && (other == this || (this.assistAvatarIdList_.Equals(other.assistAvatarIdList_) && object.Equals(this.DisplayAvatarVec, other.DisplayAvatarVec) && this.Retcode == other.Retcode && this.CurrentHeadIconId == other.CurrentHeadIconId && !(this.Signature != other.Signature) && this.unlockedHeadIconList_.Equals(other.unlockedHeadIconList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x000E3AEC File Offset: 0x000E1CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.assistAvatarIdList_.GetHashCode();
			if (this.displayAvatarVec_ != null)
			{
				num ^= this.DisplayAvatarVec.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.CurrentHeadIconId != 0U)
			{
				num ^= this.CurrentHeadIconId.GetHashCode();
			}
			if (this.Signature.Length != 0)
			{
				num ^= this.Signature.GetHashCode();
			}
			num ^= this.unlockedHeadIconList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x000E3B91 File Offset: 0x000E1D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x000E3B99 File Offset: 0x000E1D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x000E3BA4 File Offset: 0x000E1DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurrentHeadIconId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CurrentHeadIconId);
			}
			if (this.displayAvatarVec_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.DisplayAvatarVec);
			}
			this.assistAvatarIdList_.WriteTo(ref output, GetPlayerBoardDataScRsp._repeated_assistAvatarIdList_codec);
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this.Signature.Length != 0)
			{
				output.WriteRawTag(114);
				output.WriteString(this.Signature);
			}
			this.unlockedHeadIconList_.WriteTo(ref output, GetPlayerBoardDataScRsp._repeated_unlockedHeadIconList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x000E3C5C File Offset: 0x000E1E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.assistAvatarIdList_.CalculateSize(GetPlayerBoardDataScRsp._repeated_assistAvatarIdList_codec);
			if (this.displayAvatarVec_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DisplayAvatarVec);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.CurrentHeadIconId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CurrentHeadIconId);
			}
			if (this.Signature.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Signature);
			}
			num += this.unlockedHeadIconList_.CalculateSize(GetPlayerBoardDataScRsp._repeated_unlockedHeadIconList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x000E3D10 File Offset: 0x000E1F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerBoardDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.assistAvatarIdList_.Add(other.assistAvatarIdList_);
			if (other.displayAvatarVec_ != null)
			{
				if (this.displayAvatarVec_ == null)
				{
					this.DisplayAvatarVec = new DisplayAvatarVec();
				}
				this.DisplayAvatarVec.MergeFrom(other.DisplayAvatarVec);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.CurrentHeadIconId != 0U)
			{
				this.CurrentHeadIconId = other.CurrentHeadIconId;
			}
			if (other.Signature.Length != 0)
			{
				this.Signature = other.Signature;
			}
			this.unlockedHeadIconList_.Add(other.unlockedHeadIconList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x000E3DC7 File Offset: 0x000E1FC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x000E3DD0 File Offset: 0x000E1FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 96U)
				{
					if (num == 32U)
					{
						this.CurrentHeadIconId = input.ReadUInt32();
						continue;
					}
					if (num == 58U)
					{
						if (this.displayAvatarVec_ == null)
						{
							this.DisplayAvatarVec = new DisplayAvatarVec();
						}
						input.ReadMessage(this.DisplayAvatarVec);
						continue;
					}
					if (num == 96U)
					{
						goto IL_79;
					}
				}
				else if (num <= 104U)
				{
					if (num == 98U)
					{
						goto IL_79;
					}
					if (num == 104U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 114U)
					{
						this.Signature = input.ReadString();
						continue;
					}
					if (num == 122U)
					{
						this.unlockedHeadIconList_.AddEntriesFrom(ref input, GetPlayerBoardDataScRsp._repeated_unlockedHeadIconList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_79:
				this.assistAvatarIdList_.AddEntriesFrom(ref input, GetPlayerBoardDataScRsp._repeated_assistAvatarIdList_codec);
			}
		}

		// Token: 0x04002138 RID: 8504
		private static readonly MessageParser<GetPlayerBoardDataScRsp> _parser = new MessageParser<GetPlayerBoardDataScRsp>(() => new GetPlayerBoardDataScRsp());

		// Token: 0x04002139 RID: 8505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400213A RID: 8506
		public const int AssistAvatarIdListFieldNumber = 12;

		// Token: 0x0400213B RID: 8507
		private static readonly FieldCodec<uint> _repeated_assistAvatarIdList_codec = FieldCodec.ForUInt32(98U);

		// Token: 0x0400213C RID: 8508
		private readonly RepeatedField<uint> assistAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x0400213D RID: 8509
		public const int DisplayAvatarVecFieldNumber = 7;

		// Token: 0x0400213E RID: 8510
		private DisplayAvatarVec displayAvatarVec_;

		// Token: 0x0400213F RID: 8511
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04002140 RID: 8512
		private uint retcode_;

		// Token: 0x04002141 RID: 8513
		public const int CurrentHeadIconIdFieldNumber = 4;

		// Token: 0x04002142 RID: 8514
		private uint currentHeadIconId_;

		// Token: 0x04002143 RID: 8515
		public const int SignatureFieldNumber = 14;

		// Token: 0x04002144 RID: 8516
		private string signature_ = "";

		// Token: 0x04002145 RID: 8517
		public const int UnlockedHeadIconListFieldNumber = 15;

		// Token: 0x04002146 RID: 8518
		private static readonly FieldCodec<HeadIconData> _repeated_unlockedHeadIconList_codec = FieldCodec.ForMessage<HeadIconData>(122U, HeadIconData.Parser);

		// Token: 0x04002147 RID: 8519
		private readonly RepeatedField<HeadIconData> unlockedHeadIconList_ = new RepeatedField<HeadIconData>();
	}
}
