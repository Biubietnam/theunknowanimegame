using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000031 RID: 49
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ActivateFarmElementCsReq : IMessage<ActivateFarmElementCsReq>, IMessage, IEquatable<ActivateFarmElementCsReq>, IDeepCloneable<ActivateFarmElementCsReq>, IBufferMessage
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000062E5 File Offset: 0x000044E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ActivateFarmElementCsReq> Parser
		{
			get
			{
				return ActivateFarmElementCsReq._parser;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001CC RID: 460 RVA: 0x000062EC File Offset: 0x000044EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ActivateFarmElementCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000062FE File Offset: 0x000044FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActivateFarmElementCsReq.Descriptor;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00006305 File Offset: 0x00004505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateFarmElementCsReq()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000630D File Offset: 0x0000450D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateFarmElementCsReq(ActivateFarmElementCsReq other) : this()
		{
			this.entityId_ = other.entityId_;
			this.worldLevel_ = other.worldLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000633E File Offset: 0x0000453E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivateFarmElementCsReq Clone()
		{
			return new ActivateFarmElementCsReq(this);
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00006346 File Offset: 0x00004546
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x0000634E File Offset: 0x0000454E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00006357 File Offset: 0x00004557
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000635F File Offset: 0x0000455F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint WorldLevel
		{
			get
			{
				return this.worldLevel_;
			}
			set
			{
				this.worldLevel_ = value;
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00006368 File Offset: 0x00004568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActivateFarmElementCsReq);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00006376 File Offset: 0x00004576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActivateFarmElementCsReq other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.WorldLevel == other.WorldLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000063B4 File Offset: 0x000045B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.WorldLevel != 0U)
			{
				num ^= this.WorldLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000640C File Offset: 0x0000460C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00006414 File Offset: 0x00004614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00006420 File Offset: 0x00004620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.EntityId);
			}
			if (this.WorldLevel != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000647C File Offset: 0x0000467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this.WorldLevel != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.WorldLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000064D4 File Offset: 0x000046D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActivateFarmElementCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			if (other.WorldLevel != 0U)
			{
				this.WorldLevel = other.WorldLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00006524 File Offset: 0x00004724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00006530 File Offset: 0x00004730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WorldLevel = input.ReadUInt32();
					}
				}
				else
				{
					this.EntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400009E RID: 158
		private static readonly MessageParser<ActivateFarmElementCsReq> _parser = new MessageParser<ActivateFarmElementCsReq>(() => new ActivateFarmElementCsReq());

		// Token: 0x0400009F RID: 159
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000A0 RID: 160
		public const int EntityIdFieldNumber = 4;

		// Token: 0x040000A1 RID: 161
		private uint entityId_;

		// Token: 0x040000A2 RID: 162
		public const int WorldLevelFieldNumber = 11;

		// Token: 0x040000A3 RID: 163
		private uint worldLevel_;
	}
}
