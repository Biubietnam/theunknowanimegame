using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001239 RID: 4665
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingMarkEndingViewedCsReq : IMessage<SwordTrainingMarkEndingViewedCsReq>, IMessage, IEquatable<SwordTrainingMarkEndingViewedCsReq>, IDeepCloneable<SwordTrainingMarkEndingViewedCsReq>, IBufferMessage
	{
		// Token: 0x17003AB9 RID: 15033
		// (get) Token: 0x0600D061 RID: 53345 RVA: 0x0022E097 File Offset: 0x0022C297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingMarkEndingViewedCsReq> Parser
		{
			get
			{
				return SwordTrainingMarkEndingViewedCsReq._parser;
			}
		}

		// Token: 0x17003ABA RID: 15034
		// (get) Token: 0x0600D062 RID: 53346 RVA: 0x0022E09E File Offset: 0x0022C29E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingMarkEndingViewedCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003ABB RID: 15035
		// (get) Token: 0x0600D063 RID: 53347 RVA: 0x0022E0B0 File Offset: 0x0022C2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingMarkEndingViewedCsReq.Descriptor;
			}
		}

		// Token: 0x0600D064 RID: 53348 RVA: 0x0022E0B7 File Offset: 0x0022C2B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingMarkEndingViewedCsReq()
		{
		}

		// Token: 0x0600D065 RID: 53349 RVA: 0x0022E0BF File Offset: 0x0022C2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingMarkEndingViewedCsReq(SwordTrainingMarkEndingViewedCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D066 RID: 53350 RVA: 0x0022E0D8 File Offset: 0x0022C2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingMarkEndingViewedCsReq Clone()
		{
			return new SwordTrainingMarkEndingViewedCsReq(this);
		}

		// Token: 0x0600D067 RID: 53351 RVA: 0x0022E0E0 File Offset: 0x0022C2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingMarkEndingViewedCsReq);
		}

		// Token: 0x0600D068 RID: 53352 RVA: 0x0022E0EE File Offset: 0x0022C2EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingMarkEndingViewedCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D069 RID: 53353 RVA: 0x0022E10C File Offset: 0x0022C30C
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

		// Token: 0x0600D06A RID: 53354 RVA: 0x0022E132 File Offset: 0x0022C332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D06B RID: 53355 RVA: 0x0022E13A File Offset: 0x0022C33A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D06C RID: 53356 RVA: 0x0022E143 File Offset: 0x0022C343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D06D RID: 53357 RVA: 0x0022E15C File Offset: 0x0022C35C
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

		// Token: 0x0600D06E RID: 53358 RVA: 0x0022E182 File Offset: 0x0022C382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingMarkEndingViewedCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D06F RID: 53359 RVA: 0x0022E19F File Offset: 0x0022C39F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D070 RID: 53360 RVA: 0x0022E1A8 File Offset: 0x0022C3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040053C4 RID: 21444
		private static readonly MessageParser<SwordTrainingMarkEndingViewedCsReq> _parser = new MessageParser<SwordTrainingMarkEndingViewedCsReq>(() => new SwordTrainingMarkEndingViewedCsReq());

		// Token: 0x040053C5 RID: 21445
		private UnknownFieldSet _unknownFields;
	}
}
