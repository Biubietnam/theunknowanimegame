using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200123D RID: 4669
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingRestoreGameCsReq : IMessage<SwordTrainingRestoreGameCsReq>, IMessage, IEquatable<SwordTrainingRestoreGameCsReq>, IDeepCloneable<SwordTrainingRestoreGameCsReq>, IBufferMessage
	{
		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0600D089 RID: 53385 RVA: 0x0022E4BF File Offset: 0x0022C6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingRestoreGameCsReq> Parser
		{
			get
			{
				return SwordTrainingRestoreGameCsReq._parser;
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0600D08A RID: 53386 RVA: 0x0022E4C6 File Offset: 0x0022C6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingRestoreGameCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0600D08B RID: 53387 RVA: 0x0022E4D8 File Offset: 0x0022C6D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingRestoreGameCsReq.Descriptor;
			}
		}

		// Token: 0x0600D08C RID: 53388 RVA: 0x0022E4DF File Offset: 0x0022C6DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingRestoreGameCsReq()
		{
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x0022E4E7 File Offset: 0x0022C6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingRestoreGameCsReq(SwordTrainingRestoreGameCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D08E RID: 53390 RVA: 0x0022E500 File Offset: 0x0022C700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingRestoreGameCsReq Clone()
		{
			return new SwordTrainingRestoreGameCsReq(this);
		}

		// Token: 0x0600D08F RID: 53391 RVA: 0x0022E508 File Offset: 0x0022C708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingRestoreGameCsReq);
		}

		// Token: 0x0600D090 RID: 53392 RVA: 0x0022E516 File Offset: 0x0022C716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingRestoreGameCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D091 RID: 53393 RVA: 0x0022E534 File Offset: 0x0022C734
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

		// Token: 0x0600D092 RID: 53394 RVA: 0x0022E55A File Offset: 0x0022C75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x0022E562 File Offset: 0x0022C762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x0022E56B File Offset: 0x0022C76B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D095 RID: 53397 RVA: 0x0022E584 File Offset: 0x0022C784
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

		// Token: 0x0600D096 RID: 53398 RVA: 0x0022E5AA File Offset: 0x0022C7AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingRestoreGameCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D097 RID: 53399 RVA: 0x0022E5C7 File Offset: 0x0022C7C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D098 RID: 53400 RVA: 0x0022E5D0 File Offset: 0x0022C7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040053CC RID: 21452
		private static readonly MessageParser<SwordTrainingRestoreGameCsReq> _parser = new MessageParser<SwordTrainingRestoreGameCsReq>(() => new SwordTrainingRestoreGameCsReq());

		// Token: 0x040053CD RID: 21453
		private UnknownFieldSet _unknownFields;
	}
}
