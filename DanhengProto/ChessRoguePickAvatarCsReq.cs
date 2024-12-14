using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000265 RID: 613
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRoguePickAvatarCsReq : IMessage<ChessRoguePickAvatarCsReq>, IMessage, IEquatable<ChessRoguePickAvatarCsReq>, IDeepCloneable<ChessRoguePickAvatarCsReq>, IBufferMessage
	{
		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x0004ECE9 File Offset: 0x0004CEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRoguePickAvatarCsReq> Parser
		{
			get
			{
				return ChessRoguePickAvatarCsReq._parser;
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0004ECF0 File Offset: 0x0004CEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRoguePickAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0004ED02 File Offset: 0x0004CF02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRoguePickAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0004ED09 File Offset: 0x0004CF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRoguePickAvatarCsReq()
		{
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0004ED1C File Offset: 0x0004CF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRoguePickAvatarCsReq(ChessRoguePickAvatarCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0004ED52 File Offset: 0x0004CF52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRoguePickAvatarCsReq Clone()
		{
			return new ChessRoguePickAvatarCsReq(this);
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0004ED5A File Offset: 0x0004CF5A
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x0004ED62 File Offset: 0x0004CF62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PropEntityId
		{
			get
			{
				return this.propEntityId_;
			}
			set
			{
				this.propEntityId_ = value;
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x0004ED6B File Offset: 0x0004CF6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0004ED73 File Offset: 0x0004CF73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRoguePickAvatarCsReq);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0004ED84 File Offset: 0x0004CF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRoguePickAvatarCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0004EDD4 File Offset: 0x0004CFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0004EE21 File Offset: 0x0004D021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0004EE29 File Offset: 0x0004D029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0004EE34 File Offset: 0x0004D034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseAvatarIdList_.WriteTo(ref output, ChessRoguePickAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0004EE84 File Offset: 0x0004D084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			num += this.baseAvatarIdList_.CalculateSize(ChessRoguePickAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0004EED8 File Offset: 0x0004D0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRoguePickAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001B6B RID: 7019 RVA: 0x0004EF25 File Offset: 0x0004D125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0004EF30 File Offset: 0x0004D130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U && num != 18U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PropEntityId = input.ReadUInt32();
					}
				}
				else
				{
					this.baseAvatarIdList_.AddEntriesFrom(ref input, ChessRoguePickAvatarCsReq._repeated_baseAvatarIdList_codec);
				}
			}
		}

		// Token: 0x04000B85 RID: 2949
		private static readonly MessageParser<ChessRoguePickAvatarCsReq> _parser = new MessageParser<ChessRoguePickAvatarCsReq>(() => new ChessRoguePickAvatarCsReq());

		// Token: 0x04000B86 RID: 2950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B87 RID: 2951
		public const int PropEntityIdFieldNumber = 13;

		// Token: 0x04000B88 RID: 2952
		private uint propEntityId_;

		// Token: 0x04000B89 RID: 2953
		public const int BaseAvatarIdListFieldNumber = 2;

		// Token: 0x04000B8A RID: 2954
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(18U);

		// Token: 0x04000B8B RID: 2955
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();
	}
}
