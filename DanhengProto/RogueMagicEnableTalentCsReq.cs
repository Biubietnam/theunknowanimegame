using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EBF RID: 3775
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicEnableTalentCsReq : IMessage<RogueMagicEnableTalentCsReq>, IMessage, IEquatable<RogueMagicEnableTalentCsReq>, IDeepCloneable<RogueMagicEnableTalentCsReq>, IBufferMessage
	{
		// Token: 0x17002FA9 RID: 12201
		// (get) Token: 0x0600A8B7 RID: 43191 RVA: 0x001C6934 File Offset: 0x001C4B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicEnableTalentCsReq> Parser
		{
			get
			{
				return RogueMagicEnableTalentCsReq._parser;
			}
		}

		// Token: 0x17002FAA RID: 12202
		// (get) Token: 0x0600A8B8 RID: 43192 RVA: 0x001C693B File Offset: 0x001C4B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicEnableTalentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002FAB RID: 12203
		// (get) Token: 0x0600A8B9 RID: 43193 RVA: 0x001C694D File Offset: 0x001C4B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicEnableTalentCsReq.Descriptor;
			}
		}

		// Token: 0x0600A8BA RID: 43194 RVA: 0x001C6954 File Offset: 0x001C4B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnableTalentCsReq()
		{
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x001C695C File Offset: 0x001C4B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnableTalentCsReq(RogueMagicEnableTalentCsReq other) : this()
		{
			this.talentId_ = other.talentId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x001C6981 File Offset: 0x001C4B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicEnableTalentCsReq Clone()
		{
			return new RogueMagicEnableTalentCsReq(this);
		}

		// Token: 0x17002FAC RID: 12204
		// (get) Token: 0x0600A8BD RID: 43197 RVA: 0x001C6989 File Offset: 0x001C4B89
		// (set) Token: 0x0600A8BE RID: 43198 RVA: 0x001C6991 File Offset: 0x001C4B91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x001C699A File Offset: 0x001C4B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicEnableTalentCsReq);
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x001C69A8 File Offset: 0x001C4BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicEnableTalentCsReq other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x001C69D8 File Offset: 0x001C4BD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0U)
			{
				num ^= this.TalentId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x001C6A17 File Offset: 0x001C4C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x001C6A1F File Offset: 0x001C4C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A8C4 RID: 43204 RVA: 0x001C6A28 File Offset: 0x001C4C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A8C5 RID: 43205 RVA: 0x001C6A5C File Offset: 0x001C4C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TalentId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A8C6 RID: 43206 RVA: 0x001C6A9A File Offset: 0x001C4C9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicEnableTalentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0U)
			{
				this.TalentId = other.TalentId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A8C7 RID: 43207 RVA: 0x001C6ACB File Offset: 0x001C4CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A8C8 RID: 43208 RVA: 0x001C6AD4 File Offset: 0x001C4CD4
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
					this.TalentId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040044F2 RID: 17650
		private static readonly MessageParser<RogueMagicEnableTalentCsReq> _parser = new MessageParser<RogueMagicEnableTalentCsReq>(() => new RogueMagicEnableTalentCsReq());

		// Token: 0x040044F3 RID: 17651
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044F4 RID: 17652
		public const int TalentIdFieldNumber = 6;

		// Token: 0x040044F5 RID: 17653
		private uint talentId_;
	}
}
