using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D61 RID: 3425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RaidCollectionDataCsReq : IMessage<RaidCollectionDataCsReq>, IMessage, IEquatable<RaidCollectionDataCsReq>, IDeepCloneable<RaidCollectionDataCsReq>, IBufferMessage
	{
		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x0600990B RID: 39179 RVA: 0x001977DB File Offset: 0x001959DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RaidCollectionDataCsReq> Parser
		{
			get
			{
				return RaidCollectionDataCsReq._parser;
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x0600990C RID: 39180 RVA: 0x001977E2 File Offset: 0x001959E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RaidCollectionDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x0600990D RID: 39181 RVA: 0x001977F4 File Offset: 0x001959F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RaidCollectionDataCsReq.Descriptor;
			}
		}

		// Token: 0x0600990E RID: 39182 RVA: 0x001977FB File Offset: 0x001959FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataCsReq()
		{
		}

		// Token: 0x0600990F RID: 39183 RVA: 0x00197803 File Offset: 0x00195A03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataCsReq(RaidCollectionDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009910 RID: 39184 RVA: 0x0019781C File Offset: 0x00195A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RaidCollectionDataCsReq Clone()
		{
			return new RaidCollectionDataCsReq(this);
		}

		// Token: 0x06009911 RID: 39185 RVA: 0x00197824 File Offset: 0x00195A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RaidCollectionDataCsReq);
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x00197832 File Offset: 0x00195A32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RaidCollectionDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x00197850 File Offset: 0x00195A50
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

		// Token: 0x06009914 RID: 39188 RVA: 0x00197876 File Offset: 0x00195A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x0019787E File Offset: 0x00195A7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x00197887 File Offset: 0x00195A87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x001978A0 File Offset: 0x00195AA0
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

		// Token: 0x06009918 RID: 39192 RVA: 0x001978C6 File Offset: 0x00195AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RaidCollectionDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x001978E3 File Offset: 0x00195AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600991A RID: 39194 RVA: 0x001978EC File Offset: 0x00195AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003B70 RID: 15216
		private static readonly MessageParser<RaidCollectionDataCsReq> _parser = new MessageParser<RaidCollectionDataCsReq>(() => new RaidCollectionDataCsReq());

		// Token: 0x04003B71 RID: 15217
		private UnknownFieldSet _unknownFields;
	}
}
