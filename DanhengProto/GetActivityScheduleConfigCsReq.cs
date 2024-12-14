using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005F7 RID: 1527
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetActivityScheduleConfigCsReq : IMessage<GetActivityScheduleConfigCsReq>, IMessage, IEquatable<GetActivityScheduleConfigCsReq>, IDeepCloneable<GetActivityScheduleConfigCsReq>, IBufferMessage
	{
		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x0600447D RID: 17533 RVA: 0x000BBF97 File Offset: 0x000BA197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetActivityScheduleConfigCsReq> Parser
		{
			get
			{
				return GetActivityScheduleConfigCsReq._parser;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x0600447E RID: 17534 RVA: 0x000BBF9E File Offset: 0x000BA19E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetActivityScheduleConfigCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x0600447F RID: 17535 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetActivityScheduleConfigCsReq.Descriptor;
			}
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x000BBFB7 File Offset: 0x000BA1B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetActivityScheduleConfigCsReq()
		{
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x000BBFBF File Offset: 0x000BA1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetActivityScheduleConfigCsReq(GetActivityScheduleConfigCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x000BBFD8 File Offset: 0x000BA1D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetActivityScheduleConfigCsReq Clone()
		{
			return new GetActivityScheduleConfigCsReq(this);
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x000BBFE0 File Offset: 0x000BA1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetActivityScheduleConfigCsReq);
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x000BBFEE File Offset: 0x000BA1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetActivityScheduleConfigCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x000BC00C File Offset: 0x000BA20C
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

		// Token: 0x06004486 RID: 17542 RVA: 0x000BC032 File Offset: 0x000BA232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x000BC03A File Offset: 0x000BA23A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x000BC043 File Offset: 0x000BA243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x000BC05C File Offset: 0x000BA25C
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

		// Token: 0x0600448A RID: 17546 RVA: 0x000BC082 File Offset: 0x000BA282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetActivityScheduleConfigCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x000BC09F File Offset: 0x000BA29F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x000BC0A8 File Offset: 0x000BA2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001B6E RID: 7022
		private static readonly MessageParser<GetActivityScheduleConfigCsReq> _parser = new MessageParser<GetActivityScheduleConfigCsReq>(() => new GetActivityScheduleConfigCsReq());

		// Token: 0x04001B6F RID: 7023
		private UnknownFieldSet _unknownFields;
	}
}
