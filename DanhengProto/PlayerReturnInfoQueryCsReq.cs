using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000CD1 RID: 3281
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class PlayerReturnInfoQueryCsReq : IMessage<PlayerReturnInfoQueryCsReq>, IMessage, IEquatable<PlayerReturnInfoQueryCsReq>, IDeepCloneable<PlayerReturnInfoQueryCsReq>, IBufferMessage
	{
		// Token: 0x17002934 RID: 10548
		// (get) Token: 0x0600925C RID: 37468 RVA: 0x00184434 File Offset: 0x00182634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PlayerReturnInfoQueryCsReq> Parser
		{
			get
			{
				return PlayerReturnInfoQueryCsReq._parser;
			}
		}

		// Token: 0x17002935 RID: 10549
		// (get) Token: 0x0600925D RID: 37469 RVA: 0x0018443B File Offset: 0x0018263B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PlayerReturnInfoQueryCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002936 RID: 10550
		// (get) Token: 0x0600925E RID: 37470 RVA: 0x0018444D File Offset: 0x0018264D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerReturnInfoQueryCsReq.Descriptor;
			}
		}

		// Token: 0x0600925F RID: 37471 RVA: 0x00184454 File Offset: 0x00182654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnInfoQueryCsReq()
		{
		}

		// Token: 0x06009260 RID: 37472 RVA: 0x0018445C File Offset: 0x0018265C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnInfoQueryCsReq(PlayerReturnInfoQueryCsReq other) : this()
		{
			this.gJDIBELBCCJ_ = other.gJDIBELBCCJ_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009261 RID: 37473 RVA: 0x00184481 File Offset: 0x00182681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerReturnInfoQueryCsReq Clone()
		{
			return new PlayerReturnInfoQueryCsReq(this);
		}

		// Token: 0x17002937 RID: 10551
		// (get) Token: 0x06009262 RID: 37474 RVA: 0x00184489 File Offset: 0x00182689
		// (set) Token: 0x06009263 RID: 37475 RVA: 0x00184491 File Offset: 0x00182691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GJDIBELBCCJ
		{
			get
			{
				return this.gJDIBELBCCJ_;
			}
			set
			{
				this.gJDIBELBCCJ_ = value;
			}
		}

		// Token: 0x06009264 RID: 37476 RVA: 0x0018449A File Offset: 0x0018269A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerReturnInfoQueryCsReq);
		}

		// Token: 0x06009265 RID: 37477 RVA: 0x001844A8 File Offset: 0x001826A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerReturnInfoQueryCsReq other)
		{
			return other != null && (other == this || (this.GJDIBELBCCJ == other.GJDIBELBCCJ && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009266 RID: 37478 RVA: 0x001844D8 File Offset: 0x001826D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GJDIBELBCCJ != 0U)
			{
				num ^= this.GJDIBELBCCJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009267 RID: 37479 RVA: 0x00184517 File Offset: 0x00182717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009268 RID: 37480 RVA: 0x0018451F File Offset: 0x0018271F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009269 RID: 37481 RVA: 0x00184528 File Offset: 0x00182728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GJDIBELBCCJ != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.GJDIBELBCCJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600926A RID: 37482 RVA: 0x0018455C File Offset: 0x0018275C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GJDIBELBCCJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GJDIBELBCCJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600926B RID: 37483 RVA: 0x0018459A File Offset: 0x0018279A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerReturnInfoQueryCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GJDIBELBCCJ != 0U)
			{
				this.GJDIBELBCCJ = other.GJDIBELBCCJ;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600926C RID: 37484 RVA: 0x001845CB File Offset: 0x001827CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600926D RID: 37485 RVA: 0x001845D4 File Offset: 0x001827D4
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
					this.GJDIBELBCCJ = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400387C RID: 14460
		private static readonly MessageParser<PlayerReturnInfoQueryCsReq> _parser = new MessageParser<PlayerReturnInfoQueryCsReq>(() => new PlayerReturnInfoQueryCsReq());

		// Token: 0x0400387D RID: 14461
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400387E RID: 14462
		public const int GJDIBELBCCJFieldNumber = 1;

		// Token: 0x0400387F RID: 14463
		private uint gJDIBELBCCJ_;
	}
}
