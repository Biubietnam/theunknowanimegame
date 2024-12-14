using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000825 RID: 2085
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetTrackPhotoActivityDataCsReq : IMessage<GetTrackPhotoActivityDataCsReq>, IMessage, IEquatable<GetTrackPhotoActivityDataCsReq>, IDeepCloneable<GetTrackPhotoActivityDataCsReq>, IBufferMessage
	{
		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06005CD6 RID: 23766 RVA: 0x000F69EF File Offset: 0x000F4BEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetTrackPhotoActivityDataCsReq> Parser
		{
			get
			{
				return GetTrackPhotoActivityDataCsReq._parser;
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x000F69F6 File Offset: 0x000F4BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetTrackPhotoActivityDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06005CD8 RID: 23768 RVA: 0x000F6A08 File Offset: 0x000F4C08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTrackPhotoActivityDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005CD9 RID: 23769 RVA: 0x000F6A0F File Offset: 0x000F4C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrackPhotoActivityDataCsReq()
		{
		}

		// Token: 0x06005CDA RID: 23770 RVA: 0x000F6A17 File Offset: 0x000F4C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrackPhotoActivityDataCsReq(GetTrackPhotoActivityDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CDB RID: 23771 RVA: 0x000F6A30 File Offset: 0x000F4C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetTrackPhotoActivityDataCsReq Clone()
		{
			return new GetTrackPhotoActivityDataCsReq(this);
		}

		// Token: 0x06005CDC RID: 23772 RVA: 0x000F6A38 File Offset: 0x000F4C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTrackPhotoActivityDataCsReq);
		}

		// Token: 0x06005CDD RID: 23773 RVA: 0x000F6A46 File Offset: 0x000F4C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetTrackPhotoActivityDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005CDE RID: 23774 RVA: 0x000F6A64 File Offset: 0x000F4C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x000F6A8A File Offset: 0x000F4C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x000F6A92 File Offset: 0x000F4C92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x000F6A9B File Offset: 0x000F4C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x000F6AB4 File Offset: 0x000F4CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x000F6ADA File Offset: 0x000F4CDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetTrackPhotoActivityDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x000F6AF7 File Offset: 0x000F4CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x000F6B00 File Offset: 0x000F4D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040023E5 RID: 9189
		private static readonly MessageParser<GetTrackPhotoActivityDataCsReq> _parser = new MessageParser<GetTrackPhotoActivityDataCsReq>(() => new GetTrackPhotoActivityDataCsReq());

		// Token: 0x040023E6 RID: 9190
		private UnknownFieldSet _unknownFields;
	}
}
