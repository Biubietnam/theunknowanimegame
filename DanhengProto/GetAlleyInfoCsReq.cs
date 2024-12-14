using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000603 RID: 1539
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetAlleyInfoCsReq : IMessage<GetAlleyInfoCsReq>, IMessage, IEquatable<GetAlleyInfoCsReq>, IDeepCloneable<GetAlleyInfoCsReq>, IBufferMessage
	{
		// Token: 0x170013B4 RID: 5044
		// (get) Token: 0x06004507 RID: 17671 RVA: 0x000BD56A File Offset: 0x000BB76A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetAlleyInfoCsReq> Parser
		{
			get
			{
				return GetAlleyInfoCsReq._parser;
			}
		}

		// Token: 0x170013B5 RID: 5045
		// (get) Token: 0x06004508 RID: 17672 RVA: 0x000BD571 File Offset: 0x000BB771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetAlleyInfoCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170013B6 RID: 5046
		// (get) Token: 0x06004509 RID: 17673 RVA: 0x000BD583 File Offset: 0x000BB783
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetAlleyInfoCsReq.Descriptor;
			}
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x000BD58A File Offset: 0x000BB78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAlleyInfoCsReq()
		{
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x000BD592 File Offset: 0x000BB792
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAlleyInfoCsReq(GetAlleyInfoCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x000BD5AB File Offset: 0x000BB7AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetAlleyInfoCsReq Clone()
		{
			return new GetAlleyInfoCsReq(this);
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x000BD5B3 File Offset: 0x000BB7B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetAlleyInfoCsReq);
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x000BD5C1 File Offset: 0x000BB7C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetAlleyInfoCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x000BD5E0 File Offset: 0x000BB7E0
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

		// Token: 0x06004510 RID: 17680 RVA: 0x000BD606 File Offset: 0x000BB806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004511 RID: 17681 RVA: 0x000BD60E File Offset: 0x000BB80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004512 RID: 17682 RVA: 0x000BD617 File Offset: 0x000BB817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004513 RID: 17683 RVA: 0x000BD630 File Offset: 0x000BB830
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

		// Token: 0x06004514 RID: 17684 RVA: 0x000BD656 File Offset: 0x000BB856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetAlleyInfoCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004515 RID: 17685 RVA: 0x000BD673 File Offset: 0x000BB873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004516 RID: 17686 RVA: 0x000BD67C File Offset: 0x000BB87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001BA4 RID: 7076
		private static readonly MessageParser<GetAlleyInfoCsReq> _parser = new MessageParser<GetAlleyInfoCsReq>(() => new GetAlleyInfoCsReq());

		// Token: 0x04001BA5 RID: 7077
		private UnknownFieldSet _unknownFields;
	}
}
