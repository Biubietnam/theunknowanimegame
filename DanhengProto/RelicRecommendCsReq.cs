using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DAD RID: 3501
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicRecommendCsReq : IMessage<RelicRecommendCsReq>, IMessage, IEquatable<RelicRecommendCsReq>, IDeepCloneable<RelicRecommendCsReq>, IBufferMessage
	{
		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x06009C83 RID: 40067 RVA: 0x001A0DD0 File Offset: 0x0019EFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicRecommendCsReq> Parser
		{
			get
			{
				return RelicRecommendCsReq._parser;
			}
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x06009C84 RID: 40068 RVA: 0x001A0DD7 File Offset: 0x0019EFD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicRecommendCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x06009C85 RID: 40069 RVA: 0x001A0DE9 File Offset: 0x0019EFE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicRecommendCsReq.Descriptor;
			}
		}

		// Token: 0x06009C86 RID: 40070 RVA: 0x001A0DF0 File Offset: 0x0019EFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicRecommendCsReq()
		{
		}

		// Token: 0x06009C87 RID: 40071 RVA: 0x001A0DF8 File Offset: 0x0019EFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicRecommendCsReq(RelicRecommendCsReq other) : this()
		{
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x001A0E1D File Offset: 0x0019F01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicRecommendCsReq Clone()
		{
			return new RelicRecommendCsReq(this);
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x06009C89 RID: 40073 RVA: 0x001A0E25 File Offset: 0x0019F025
		// (set) Token: 0x06009C8A RID: 40074 RVA: 0x001A0E2D File Offset: 0x0019F02D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x001A0E36 File Offset: 0x0019F036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicRecommendCsReq);
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x001A0E44 File Offset: 0x0019F044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicRecommendCsReq other)
		{
			return other != null && (other == this || (this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x001A0E74 File Offset: 0x0019F074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C8E RID: 40078 RVA: 0x001A0EB3 File Offset: 0x0019F0B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009C8F RID: 40079 RVA: 0x001A0EBB File Offset: 0x0019F0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C90 RID: 40080 RVA: 0x001A0EC4 File Offset: 0x0019F0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C91 RID: 40081 RVA: 0x001A0EF8 File Offset: 0x0019F0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x001A0F36 File Offset: 0x0019F136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicRecommendCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x001A0F67 File Offset: 0x0019F167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C94 RID: 40084 RVA: 0x001A0F70 File Offset: 0x0019F170
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
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003CD3 RID: 15571
		private static readonly MessageParser<RelicRecommendCsReq> _parser = new MessageParser<RelicRecommendCsReq>(() => new RelicRecommendCsReq());

		// Token: 0x04003CD4 RID: 15572
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CD5 RID: 15573
		public const int AvatarIdFieldNumber = 6;

		// Token: 0x04003CD6 RID: 15574
		private uint avatarId_;
	}
}
