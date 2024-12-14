using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E73 RID: 3699
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueDoGambleCsReq : IMessage<RogueDoGambleCsReq>, IMessage, IEquatable<RogueDoGambleCsReq>, IDeepCloneable<RogueDoGambleCsReq>, IBufferMessage
	{
		// Token: 0x17002E92 RID: 11922
		// (get) Token: 0x0600A503 RID: 42243 RVA: 0x001BB898 File Offset: 0x001B9A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueDoGambleCsReq> Parser
		{
			get
			{
				return RogueDoGambleCsReq._parser;
			}
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x0600A504 RID: 42244 RVA: 0x001BB89F File Offset: 0x001B9A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueDoGambleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002E94 RID: 11924
		// (get) Token: 0x0600A505 RID: 42245 RVA: 0x001BB8B1 File Offset: 0x001B9AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueDoGambleCsReq.Descriptor;
			}
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x001BB8B8 File Offset: 0x001B9AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDoGambleCsReq()
		{
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x001BB8C0 File Offset: 0x001B9AC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDoGambleCsReq(RogueDoGambleCsReq other) : this()
		{
			this.propEntityId_ = other.propEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A508 RID: 42248 RVA: 0x001BB8E5 File Offset: 0x001B9AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueDoGambleCsReq Clone()
		{
			return new RogueDoGambleCsReq(this);
		}

		// Token: 0x17002E95 RID: 11925
		// (get) Token: 0x0600A509 RID: 42249 RVA: 0x001BB8ED File Offset: 0x001B9AED
		// (set) Token: 0x0600A50A RID: 42250 RVA: 0x001BB8F5 File Offset: 0x001B9AF5
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

		// Token: 0x0600A50B RID: 42251 RVA: 0x001BB8FE File Offset: 0x001B9AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueDoGambleCsReq);
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x001BB90C File Offset: 0x001B9B0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueDoGambleCsReq other)
		{
			return other != null && (other == this || (this.PropEntityId == other.PropEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x001BB93C File Offset: 0x001B9B3C
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

		// Token: 0x0600A50E RID: 42254 RVA: 0x001BB97B File Offset: 0x001B9B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x001BB983 File Offset: 0x001B9B83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x001BB98C File Offset: 0x001B9B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PropEntityId != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.PropEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x001BB9C0 File Offset: 0x001B9BC0
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

		// Token: 0x0600A512 RID: 42258 RVA: 0x001BB9FE File Offset: 0x001B9BFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueDoGambleCsReq other)
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

		// Token: 0x0600A513 RID: 42259 RVA: 0x001BBA2F File Offset: 0x001B9C2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x001BBA38 File Offset: 0x001B9C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PropEntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004369 RID: 17257
		private static readonly MessageParser<RogueDoGambleCsReq> _parser = new MessageParser<RogueDoGambleCsReq>(() => new RogueDoGambleCsReq());

		// Token: 0x0400436A RID: 17258
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400436B RID: 17259
		public const int PropEntityIdFieldNumber = 1;

		// Token: 0x0400436C RID: 17260
		private uint propEntityId_;
	}
}
