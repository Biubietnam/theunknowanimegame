using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E95 RID: 3733
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGetGambleInfoCsReq : IMessage<RogueGetGambleInfoCsReq>, IMessage, IEquatable<RogueGetGambleInfoCsReq>, IDeepCloneable<RogueGetGambleInfoCsReq>, IBufferMessage
	{
		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x0600A6C7 RID: 42695 RVA: 0x001C14C0 File Offset: 0x001BF6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGetGambleInfoCsReq> Parser
		{
			get
			{
				return RogueGetGambleInfoCsReq._parser;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x0600A6C8 RID: 42696 RVA: 0x001C14C7 File Offset: 0x001BF6C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGetGambleInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x0600A6C9 RID: 42697 RVA: 0x001C14D9 File Offset: 0x001BF6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGetGambleInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x001C14E0 File Offset: 0x001BF6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetGambleInfoCsReq()
		{
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x001C14E8 File Offset: 0x001BF6E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetGambleInfoCsReq(RogueGetGambleInfoCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6CC RID: 42700 RVA: 0x001C150D File Offset: 0x001BF70D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetGambleInfoCsReq Clone()
		{
			return new RogueGetGambleInfoCsReq(this);
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x0600A6CD RID: 42701 RVA: 0x001C1515 File Offset: 0x001BF715
		// (set) Token: 0x0600A6CE RID: 42702 RVA: 0x001C151D File Offset: 0x001BF71D
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

		// Token: 0x0600A6CF RID: 42703 RVA: 0x001C1526 File Offset: 0x001BF726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGetGambleInfoCsReq);
		}

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x001C1534 File Offset: 0x001BF734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGetGambleInfoCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x001C1564 File Offset: 0x001BF764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PropEntityId != 0U)
			{
				num ^= this.PropEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6D2 RID: 42706 RVA: 0x001C15A3 File Offset: 0x001BF7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x001C15AB File Offset: 0x001BF7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x001C15B4 File Offset: 0x001BF7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x001C15E8 File Offset: 0x001BF7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PropEntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x001C1626 File Offset: 0x001BF826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGetGambleInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PropEntityId != 0U)
			{
				this.PropEntityId = other.PropEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x001C1657 File Offset: 0x001BF857
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6D8 RID: 42712 RVA: 0x001C1660 File Offset: 0x001BF860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400443C RID: 17468
		private static readonly MessageParser<RogueGetGambleInfoCsReq> _parser = new MessageParser<RogueGetGambleInfoCsReq>(() => new RogueGetGambleInfoCsReq());

		// Token: 0x0400443D RID: 17469
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400443E RID: 17470
		public const int PropEntityIdFieldNumber = 9;

		// Token: 0x0400443F RID: 17471
		private uint propEntityId_;
	}
}
