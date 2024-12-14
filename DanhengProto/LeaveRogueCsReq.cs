using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009FF RID: 2559
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveRogueCsReq : IMessage<LeaveRogueCsReq>, IMessage, IEquatable<LeaveRogueCsReq>, IDeepCloneable<LeaveRogueCsReq>, IBufferMessage
	{
		// Token: 0x17001FED RID: 8173
		// (get) Token: 0x06007191 RID: 29073 RVA: 0x0012E36A File Offset: 0x0012C56A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveRogueCsReq> Parser
		{
			get
			{
				return LeaveRogueCsReq._parser;
			}
		}

		// Token: 0x17001FEE RID: 8174
		// (get) Token: 0x06007192 RID: 29074 RVA: 0x0012E371 File Offset: 0x0012C571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveRogueCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FEF RID: 8175
		// (get) Token: 0x06007193 RID: 29075 RVA: 0x0012E383 File Offset: 0x0012C583
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveRogueCsReq.Descriptor;
			}
		}

		// Token: 0x06007194 RID: 29076 RVA: 0x0012E38A File Offset: 0x0012C58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRogueCsReq()
		{
		}

		// Token: 0x06007195 RID: 29077 RVA: 0x0012E392 File Offset: 0x0012C592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRogueCsReq(LeaveRogueCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007196 RID: 29078 RVA: 0x0012E3AB File Offset: 0x0012C5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRogueCsReq Clone()
		{
			return new LeaveRogueCsReq(this);
		}

		// Token: 0x06007197 RID: 29079 RVA: 0x0012E3B3 File Offset: 0x0012C5B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveRogueCsReq);
		}

		// Token: 0x06007198 RID: 29080 RVA: 0x0012E3C1 File Offset: 0x0012C5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveRogueCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06007199 RID: 29081 RVA: 0x0012E3E0 File Offset: 0x0012C5E0
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

		// Token: 0x0600719A RID: 29082 RVA: 0x0012E406 File Offset: 0x0012C606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x0012E40E File Offset: 0x0012C60E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600719C RID: 29084 RVA: 0x0012E417 File Offset: 0x0012C617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600719D RID: 29085 RVA: 0x0012E430 File Offset: 0x0012C630
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

		// Token: 0x0600719E RID: 29086 RVA: 0x0012E456 File Offset: 0x0012C656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveRogueCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600719F RID: 29087 RVA: 0x0012E473 File Offset: 0x0012C673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071A0 RID: 29088 RVA: 0x0012E47C File Offset: 0x0012C67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BAC RID: 11180
		private static readonly MessageParser<LeaveRogueCsReq> _parser = new MessageParser<LeaveRogueCsReq>(() => new LeaveRogueCsReq());

		// Token: 0x04002BAD RID: 11181
		private UnknownFieldSet _unknownFields;
	}
}
