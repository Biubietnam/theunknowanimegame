using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000809 RID: 2057
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStarFightDataCsReq : IMessage<GetStarFightDataCsReq>, IMessage, IEquatable<GetStarFightDataCsReq>, IDeepCloneable<GetStarFightDataCsReq>, IBufferMessage
	{
		// Token: 0x170019D4 RID: 6612
		// (get) Token: 0x06005BB9 RID: 23481 RVA: 0x000F412F File Offset: 0x000F232F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStarFightDataCsReq> Parser
		{
			get
			{
				return GetStarFightDataCsReq._parser;
			}
		}

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x06005BBA RID: 23482 RVA: 0x000F4136 File Offset: 0x000F2336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStarFightDataCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x06005BBB RID: 23483 RVA: 0x000F4148 File Offset: 0x000F2348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStarFightDataCsReq.Descriptor;
			}
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x000F414F File Offset: 0x000F234F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStarFightDataCsReq()
		{
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x000F4157 File Offset: 0x000F2357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStarFightDataCsReq(GetStarFightDataCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x000F4170 File Offset: 0x000F2370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStarFightDataCsReq Clone()
		{
			return new GetStarFightDataCsReq(this);
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x000F4178 File Offset: 0x000F2378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStarFightDataCsReq);
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x000F4186 File Offset: 0x000F2386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStarFightDataCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06005BC1 RID: 23489 RVA: 0x000F41A4 File Offset: 0x000F23A4
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

		// Token: 0x06005BC2 RID: 23490 RVA: 0x000F41CA File Offset: 0x000F23CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005BC3 RID: 23491 RVA: 0x000F41D2 File Offset: 0x000F23D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005BC4 RID: 23492 RVA: 0x000F41DB File Offset: 0x000F23DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005BC5 RID: 23493 RVA: 0x000F41F4 File Offset: 0x000F23F4
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

		// Token: 0x06005BC6 RID: 23494 RVA: 0x000F421A File Offset: 0x000F241A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStarFightDataCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005BC7 RID: 23495 RVA: 0x000F4237 File Offset: 0x000F2437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005BC8 RID: 23496 RVA: 0x000F4240 File Offset: 0x000F2440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002381 RID: 9089
		private static readonly MessageParser<GetStarFightDataCsReq> _parser = new MessageParser<GetStarFightDataCsReq>(() => new GetStarFightDataCsReq());

		// Token: 0x04002382 RID: 9090
		private UnknownFieldSet _unknownFields;
	}
}
