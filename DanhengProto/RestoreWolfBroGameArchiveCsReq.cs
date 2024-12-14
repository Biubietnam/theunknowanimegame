using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DD1 RID: 3537
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RestoreWolfBroGameArchiveCsReq : IMessage<RestoreWolfBroGameArchiveCsReq>, IMessage, IEquatable<RestoreWolfBroGameArchiveCsReq>, IDeepCloneable<RestoreWolfBroGameArchiveCsReq>, IBufferMessage
	{
		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x06009E23 RID: 40483 RVA: 0x001A52B0 File Offset: 0x001A34B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RestoreWolfBroGameArchiveCsReq> Parser
		{
			get
			{
				return RestoreWolfBroGameArchiveCsReq._parser;
			}
		}

		// Token: 0x17002CA5 RID: 11429
		// (get) Token: 0x06009E24 RID: 40484 RVA: 0x001A52B7 File Offset: 0x001A34B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RestoreWolfBroGameArchiveCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002CA6 RID: 11430
		// (get) Token: 0x06009E25 RID: 40485 RVA: 0x001A52C9 File Offset: 0x001A34C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestoreWolfBroGameArchiveCsReq.Descriptor;
			}
		}

		// Token: 0x06009E26 RID: 40486 RVA: 0x001A52D0 File Offset: 0x001A34D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestoreWolfBroGameArchiveCsReq()
		{
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x001A52D8 File Offset: 0x001A34D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestoreWolfBroGameArchiveCsReq(RestoreWolfBroGameArchiveCsReq other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x001A52FD File Offset: 0x001A34FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RestoreWolfBroGameArchiveCsReq Clone()
		{
			return new RestoreWolfBroGameArchiveCsReq(this);
		}

		// Token: 0x17002CA7 RID: 11431
		// (get) Token: 0x06009E29 RID: 40489 RVA: 0x001A5305 File Offset: 0x001A3505
		// (set) Token: 0x06009E2A RID: 40490 RVA: 0x001A530D File Offset: 0x001A350D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06009E2B RID: 40491 RVA: 0x001A5316 File Offset: 0x001A3516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestoreWolfBroGameArchiveCsReq);
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x001A5324 File Offset: 0x001A3524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RestoreWolfBroGameArchiveCsReq other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x001A5354 File Offset: 0x001A3554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0U)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009E2E RID: 40494 RVA: 0x001A5393 File Offset: 0x001A3593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x001A539B File Offset: 0x001A359B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x001A53A4 File Offset: 0x001A35A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x001A53D8 File Offset: 0x001A35D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009E32 RID: 40498 RVA: 0x001A5416 File Offset: 0x001A3616
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RestoreWolfBroGameArchiveCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0U)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009E33 RID: 40499 RVA: 0x001A5447 File Offset: 0x001A3647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x001A5450 File Offset: 0x001A3650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003D73 RID: 15731
		private static readonly MessageParser<RestoreWolfBroGameArchiveCsReq> _parser = new MessageParser<RestoreWolfBroGameArchiveCsReq>(() => new RestoreWolfBroGameArchiveCsReq());

		// Token: 0x04003D74 RID: 15732
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D75 RID: 15733
		public const int IdFieldNumber = 10;

		// Token: 0x04003D76 RID: 15734
		private uint id_;
	}
}
