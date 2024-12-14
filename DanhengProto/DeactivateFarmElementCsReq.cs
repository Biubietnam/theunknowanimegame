using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000365 RID: 869
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class DeactivateFarmElementCsReq : IMessage<DeactivateFarmElementCsReq>, IMessage, IEquatable<DeactivateFarmElementCsReq>, IDeepCloneable<DeactivateFarmElementCsReq>, IBufferMessage
	{
		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0006CA14 File Offset: 0x0006AC14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DeactivateFarmElementCsReq> Parser
		{
			get
			{
				return DeactivateFarmElementCsReq._parser;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060026C5 RID: 9925 RVA: 0x0006CA1B File Offset: 0x0006AC1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DeactivateFarmElementCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060026C6 RID: 9926 RVA: 0x0006CA2D File Offset: 0x0006AC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeactivateFarmElementCsReq.Descriptor;
			}
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0006CA34 File Offset: 0x0006AC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeactivateFarmElementCsReq()
		{
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0006CA3C File Offset: 0x0006AC3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeactivateFarmElementCsReq(DeactivateFarmElementCsReq other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0006CA61 File Offset: 0x0006AC61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DeactivateFarmElementCsReq Clone()
		{
			return new DeactivateFarmElementCsReq(this);
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060026CA RID: 9930 RVA: 0x0006CA69 File Offset: 0x0006AC69
		// (set) Token: 0x060026CB RID: 9931 RVA: 0x0006CA71 File Offset: 0x0006AC71
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

		// Token: 0x060026CC RID: 9932 RVA: 0x0006CA7A File Offset: 0x0006AC7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeactivateFarmElementCsReq);
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0006CA88 File Offset: 0x0006AC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DeactivateFarmElementCsReq other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0006CAB8 File Offset: 0x0006ACB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0U)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0006CAF7 File Offset: 0x0006ACF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0006CAFF File Offset: 0x0006ACFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0006CB08 File Offset: 0x0006AD08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0006CB3C File Offset: 0x0006AD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0006CB7A File Offset: 0x0006AD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DeactivateFarmElementCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0U)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0006CBAB File Offset: 0x0006ADAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0006CBB4 File Offset: 0x0006ADB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000FAC RID: 4012
		private static readonly MessageParser<DeactivateFarmElementCsReq> _parser = new MessageParser<DeactivateFarmElementCsReq>(() => new DeactivateFarmElementCsReq());

		// Token: 0x04000FAD RID: 4013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000FAE RID: 4014
		public const int EntityIdFieldNumber = 3;

		// Token: 0x04000FAF RID: 4015
		private uint entityId_;
	}
}
