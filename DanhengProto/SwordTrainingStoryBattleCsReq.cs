using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001251 RID: 4689
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingStoryBattleCsReq : IMessage<SwordTrainingStoryBattleCsReq>, IMessage, IEquatable<SwordTrainingStoryBattleCsReq>, IDeepCloneable<SwordTrainingStoryBattleCsReq>, IBufferMessage
	{
		// Token: 0x17003AF8 RID: 15096
		// (get) Token: 0x0600D163 RID: 53603 RVA: 0x00230183 File Offset: 0x0022E383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingStoryBattleCsReq> Parser
		{
			get
			{
				return SwordTrainingStoryBattleCsReq._parser;
			}
		}

		// Token: 0x17003AF9 RID: 15097
		// (get) Token: 0x0600D164 RID: 53604 RVA: 0x0023018A File Offset: 0x0022E38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStoryBattleCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AFA RID: 15098
		// (get) Token: 0x0600D165 RID: 53605 RVA: 0x0023019C File Offset: 0x0022E39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingStoryBattleCsReq.Descriptor;
			}
		}

		// Token: 0x0600D166 RID: 53606 RVA: 0x002301A3 File Offset: 0x0022E3A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryBattleCsReq()
		{
		}

		// Token: 0x0600D167 RID: 53607 RVA: 0x002301AB File Offset: 0x0022E3AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryBattleCsReq(SwordTrainingStoryBattleCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D168 RID: 53608 RVA: 0x002301C4 File Offset: 0x0022E3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryBattleCsReq Clone()
		{
			return new SwordTrainingStoryBattleCsReq(this);
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x002301CC File Offset: 0x0022E3CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingStoryBattleCsReq);
		}

		// Token: 0x0600D16A RID: 53610 RVA: 0x002301DA File Offset: 0x0022E3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingStoryBattleCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x002301F8 File Offset: 0x0022E3F8
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

		// Token: 0x0600D16C RID: 53612 RVA: 0x0023021E File Offset: 0x0022E41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D16D RID: 53613 RVA: 0x00230226 File Offset: 0x0022E426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x0023022F File Offset: 0x0022E42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D16F RID: 53615 RVA: 0x00230248 File Offset: 0x0022E448
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

		// Token: 0x0600D170 RID: 53616 RVA: 0x0023026E File Offset: 0x0022E46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingStoryBattleCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D171 RID: 53617 RVA: 0x0023028B File Offset: 0x0022E48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x00230294 File Offset: 0x0022E494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005406 RID: 21510
		private static readonly MessageParser<SwordTrainingStoryBattleCsReq> _parser = new MessageParser<SwordTrainingStoryBattleCsReq>(() => new SwordTrainingStoryBattleCsReq());

		// Token: 0x04005407 RID: 21511
		private UnknownFieldSet _unknownFields;
	}
}
