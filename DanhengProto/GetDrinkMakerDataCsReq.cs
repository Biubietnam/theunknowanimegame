using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000683 RID: 1667
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetDrinkMakerDataCsReq : IMessage<GetDrinkMakerDataCsReq>, IMessage, IEquatable<GetDrinkMakerDataCsReq>, IDeepCloneable<GetDrinkMakerDataCsReq>, IBufferMessage
	{
		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06004AA8 RID: 19112 RVA: 0x000CB117 File Offset: 0x000C9317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetDrinkMakerDataCsReq> Parser
		{
			get
			{
				return GetDrinkMakerDataCsReq._parser;
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06004AA9 RID: 19113 RVA: 0x000CB11E File Offset: 0x000C931E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetDrinkMakerDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06004AAA RID: 19114 RVA: 0x000CB130 File Offset: 0x000C9330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDrinkMakerDataCsReq.Descriptor;
			}
		}

		// Token: 0x06004AAB RID: 19115 RVA: 0x000CB137 File Offset: 0x000C9337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDrinkMakerDataCsReq()
		{
		}

		// Token: 0x06004AAC RID: 19116 RVA: 0x000CB13F File Offset: 0x000C933F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDrinkMakerDataCsReq(GetDrinkMakerDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004AAD RID: 19117 RVA: 0x000CB158 File Offset: 0x000C9358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDrinkMakerDataCsReq Clone()
		{
			return new GetDrinkMakerDataCsReq(this);
		}

		// Token: 0x06004AAE RID: 19118 RVA: 0x000CB160 File Offset: 0x000C9360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDrinkMakerDataCsReq);
		}

		// Token: 0x06004AAF RID: 19119 RVA: 0x000CB16E File Offset: 0x000C936E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDrinkMakerDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004AB0 RID: 19120 RVA: 0x000CB18C File Offset: 0x000C938C
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

		// Token: 0x06004AB1 RID: 19121 RVA: 0x000CB1B2 File Offset: 0x000C93B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004AB2 RID: 19122 RVA: 0x000CB1BA File Offset: 0x000C93BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004AB3 RID: 19123 RVA: 0x000CB1C3 File Offset: 0x000C93C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004AB4 RID: 19124 RVA: 0x000CB1DC File Offset: 0x000C93DC
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

		// Token: 0x06004AB5 RID: 19125 RVA: 0x000CB202 File Offset: 0x000C9402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDrinkMakerDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004AB6 RID: 19126 RVA: 0x000CB21F File Offset: 0x000C941F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004AB7 RID: 19127 RVA: 0x000CB228 File Offset: 0x000C9428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001D9C RID: 7580
		private static readonly MessageParser<GetDrinkMakerDataCsReq> _parser = new MessageParser<GetDrinkMakerDataCsReq>(() => new GetDrinkMakerDataCsReq());

		// Token: 0x04001D9D RID: 7581
		private UnknownFieldSet _unknownFields;
	}
}
