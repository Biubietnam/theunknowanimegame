using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020008C3 RID: 2243
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class HeliobusSelectSkillCsReq : IMessage<HeliobusSelectSkillCsReq>, IMessage, IEquatable<HeliobusSelectSkillCsReq>, IDeepCloneable<HeliobusSelectSkillCsReq>, IBufferMessage
	{
		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06006401 RID: 25601 RVA: 0x0010BE84 File Offset: 0x0010A084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HeliobusSelectSkillCsReq> Parser
		{
			get
			{
				return HeliobusSelectSkillCsReq._parser;
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06006402 RID: 25602 RVA: 0x0010BE8B File Offset: 0x0010A08B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return HeliobusSelectSkillCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x0010BE9D File Offset: 0x0010A09D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HeliobusSelectSkillCsReq.Descriptor;
			}
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x0010BEA4 File Offset: 0x0010A0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSelectSkillCsReq()
		{
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x0010BEAC File Offset: 0x0010A0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSelectSkillCsReq(HeliobusSelectSkillCsReq other) : this()
		{
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x0010BED1 File Offset: 0x0010A0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeliobusSelectSkillCsReq Clone()
		{
			return new HeliobusSelectSkillCsReq(this);
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06006407 RID: 25607 RVA: 0x0010BED9 File Offset: 0x0010A0D9
		// (set) Token: 0x06006408 RID: 25608 RVA: 0x0010BEE1 File Offset: 0x0010A0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x0010BEEA File Offset: 0x0010A0EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HeliobusSelectSkillCsReq);
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x0010BEF8 File Offset: 0x0010A0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HeliobusSelectSkillCsReq other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x0010BF28 File Offset: 0x0010A128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0U)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x0010BF67 File Offset: 0x0010A167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x0010BF6F File Offset: 0x0010A16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x0010BF78 File Offset: 0x0010A178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x0010BFAC File Offset: 0x0010A1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x0010BFEA File Offset: 0x0010A1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HeliobusSelectSkillCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0U)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x0010C01B File Offset: 0x0010A21B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x0010C024 File Offset: 0x0010A224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.SkillId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400268E RID: 9870
		private static readonly MessageParser<HeliobusSelectSkillCsReq> _parser = new MessageParser<HeliobusSelectSkillCsReq>(() => new HeliobusSelectSkillCsReq());

		// Token: 0x0400268F RID: 9871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002690 RID: 9872
		public const int SkillIdFieldNumber = 2;

		// Token: 0x04002691 RID: 9873
		private uint skillId_;
	}
}
