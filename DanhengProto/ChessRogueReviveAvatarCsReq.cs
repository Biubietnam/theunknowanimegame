using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200028B RID: 651
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueReviveAvatarCsReq : IMessage<ChessRogueReviveAvatarCsReq>, IMessage, IEquatable<ChessRogueReviveAvatarCsReq>, IDeepCloneable<ChessRogueReviveAvatarCsReq>, IBufferMessage
	{
		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x000534E9 File Offset: 0x000516E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueReviveAvatarCsReq> Parser
		{
			get
			{
				return ChessRogueReviveAvatarCsReq._parser;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001D02 RID: 7426 RVA: 0x000534F0 File Offset: 0x000516F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueReviveAvatarCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x00053502 File Offset: 0x00051702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueReviveAvatarCsReq.Descriptor;
			}
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00053509 File Offset: 0x00051709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReviveAvatarCsReq()
		{
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x0005351C File Offset: 0x0005171C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReviveAvatarCsReq(ChessRogueReviveAvatarCsReq other) : this()
		{
			this.baseAvatarIdList_ = other.baseAvatarIdList_.Clone();
			this.interactedPropEntityId_ = other.interactedPropEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00053552 File Offset: 0x00051752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueReviveAvatarCsReq Clone()
		{
			return new ChessRogueReviveAvatarCsReq(this);
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0005355A File Offset: 0x0005175A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> BaseAvatarIdList
		{
			get
			{
				return this.baseAvatarIdList_;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001D08 RID: 7432 RVA: 0x00053562 File Offset: 0x00051762
		// (set) Token: 0x06001D09 RID: 7433 RVA: 0x0005356A File Offset: 0x0005176A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint InteractedPropEntityId
		{
			get
			{
				return this.interactedPropEntityId_;
			}
			set
			{
				this.interactedPropEntityId_ = value;
			}
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00053573 File Offset: 0x00051773
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueReviveAvatarCsReq);
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00053584 File Offset: 0x00051784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueReviveAvatarCsReq other)
		{
			return other != null && (other == this || (this.baseAvatarIdList_.Equals(other.baseAvatarIdList_) && this.InteractedPropEntityId == other.InteractedPropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x000535D4 File Offset: 0x000517D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.baseAvatarIdList_.GetHashCode();
			if (this.InteractedPropEntityId != 0U)
			{
				num ^= this.InteractedPropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001D0D RID: 7437 RVA: 0x00053621 File Offset: 0x00051821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001D0E RID: 7438 RVA: 0x00053629 File Offset: 0x00051829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00053634 File Offset: 0x00051834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractedPropEntityId != 0U)
			{
				output.WriteRawTag(64);
				output.WriteUInt32(this.InteractedPropEntityId);
			}
			this.baseAvatarIdList_.WriteTo(ref output, ChessRogueReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00053684 File Offset: 0x00051884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.baseAvatarIdList_.CalculateSize(ChessRogueReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
			if (this.InteractedPropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.InteractedPropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000536D8 File Offset: 0x000518D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueReviveAvatarCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this.baseAvatarIdList_.Add(other.baseAvatarIdList_);
			if (other.InteractedPropEntityId != 0U)
			{
				this.InteractedPropEntityId = other.InteractedPropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x00053725 File Offset: 0x00051925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x00053730 File Offset: 0x00051930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 64U)
				{
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.baseAvatarIdList_.AddEntriesFrom(ref input, ChessRogueReviveAvatarCsReq._repeated_baseAvatarIdList_codec);
					}
				}
				else
				{
					this.InteractedPropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000C24 RID: 3108
		private static readonly MessageParser<ChessRogueReviveAvatarCsReq> _parser = new MessageParser<ChessRogueReviveAvatarCsReq>(() => new ChessRogueReviveAvatarCsReq());

		// Token: 0x04000C25 RID: 3109
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000C26 RID: 3110
		public const int BaseAvatarIdListFieldNumber = 13;

		// Token: 0x04000C27 RID: 3111
		private static readonly FieldCodec<uint> _repeated_baseAvatarIdList_codec = FieldCodec.ForUInt32(106U);

		// Token: 0x04000C28 RID: 3112
		private readonly RepeatedField<uint> baseAvatarIdList_ = new RepeatedField<uint>();

		// Token: 0x04000C29 RID: 3113
		public const int InteractedPropEntityIdFieldNumber = 8;

		// Token: 0x04000C2A RID: 3114
		private uint interactedPropEntityId_;
	}
}
