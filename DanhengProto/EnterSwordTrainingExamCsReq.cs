using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000473 RID: 1139
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EnterSwordTrainingExamCsReq : IMessage<EnterSwordTrainingExamCsReq>, IMessage, IEquatable<EnterSwordTrainingExamCsReq>, IDeepCloneable<EnterSwordTrainingExamCsReq>, IBufferMessage
	{
		// Token: 0x17000E7D RID: 3709
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x0008BAC3 File Offset: 0x00089CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EnterSwordTrainingExamCsReq> Parser
		{
			get
			{
				return EnterSwordTrainingExamCsReq._parser;
			}
		}

		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x060032BF RID: 12991 RVA: 0x0008BACA File Offset: 0x00089CCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EnterSwordTrainingExamCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000E7F RID: 3711
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x0008BADC File Offset: 0x00089CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterSwordTrainingExamCsReq.Descriptor;
			}
		}

		// Token: 0x060032C1 RID: 12993 RVA: 0x0008BAE3 File Offset: 0x00089CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSwordTrainingExamCsReq()
		{
		}

		// Token: 0x060032C2 RID: 12994 RVA: 0x0008BAEB File Offset: 0x00089CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSwordTrainingExamCsReq(EnterSwordTrainingExamCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032C3 RID: 12995 RVA: 0x0008BB04 File Offset: 0x00089D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterSwordTrainingExamCsReq Clone()
		{
			return new EnterSwordTrainingExamCsReq(this);
		}

		// Token: 0x060032C4 RID: 12996 RVA: 0x0008BB0C File Offset: 0x00089D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterSwordTrainingExamCsReq);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x0008BB1A File Offset: 0x00089D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterSwordTrainingExamCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x0008BB38 File Offset: 0x00089D38
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

		// Token: 0x060032C7 RID: 12999 RVA: 0x0008BB5E File Offset: 0x00089D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x0008BB66 File Offset: 0x00089D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x0008BB6F File Offset: 0x00089D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x0008BB88 File Offset: 0x00089D88
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

		// Token: 0x060032CB RID: 13003 RVA: 0x0008BBAE File Offset: 0x00089DAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterSwordTrainingExamCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x0008BBCB File Offset: 0x00089DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x0008BBD4 File Offset: 0x00089DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001438 RID: 5176
		private static readonly MessageParser<EnterSwordTrainingExamCsReq> _parser = new MessageParser<EnterSwordTrainingExamCsReq>(() => new EnterSwordTrainingExamCsReq());

		// Token: 0x04001439 RID: 5177
		private UnknownFieldSet _unknownFields;
	}
}
