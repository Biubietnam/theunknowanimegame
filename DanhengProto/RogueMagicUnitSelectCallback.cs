using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F33 RID: 3891
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicUnitSelectCallback : IMessage<RogueMagicUnitSelectCallback>, IMessage, IEquatable<RogueMagicUnitSelectCallback>, IDeepCloneable<RogueMagicUnitSelectCallback>, IBufferMessage
	{
		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x0600AD92 RID: 44434 RVA: 0x001D2ACB File Offset: 0x001D0CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicUnitSelectCallback> Parser
		{
			get
			{
				return RogueMagicUnitSelectCallback._parser;
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x0600AD93 RID: 44435 RVA: 0x001D2AD2 File Offset: 0x001D0CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicUnitSelectCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x0600AD94 RID: 44436 RVA: 0x001D2AE4 File Offset: 0x001D0CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicUnitSelectCallback.Descriptor;
			}
		}

		// Token: 0x0600AD95 RID: 44437 RVA: 0x001D2AEB File Offset: 0x001D0CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectCallback()
		{
		}

		// Token: 0x0600AD96 RID: 44438 RVA: 0x001D2AF3 File Offset: 0x001D0CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectCallback(RogueMagicUnitSelectCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD97 RID: 44439 RVA: 0x001D2B0C File Offset: 0x001D0D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicUnitSelectCallback Clone()
		{
			return new RogueMagicUnitSelectCallback(this);
		}

		// Token: 0x0600AD98 RID: 44440 RVA: 0x001D2B14 File Offset: 0x001D0D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicUnitSelectCallback);
		}

		// Token: 0x0600AD99 RID: 44441 RVA: 0x001D2B22 File Offset: 0x001D0D22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicUnitSelectCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600AD9A RID: 44442 RVA: 0x001D2B40 File Offset: 0x001D0D40
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

		// Token: 0x0600AD9B RID: 44443 RVA: 0x001D2B66 File Offset: 0x001D0D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AD9C RID: 44444 RVA: 0x001D2B6E File Offset: 0x001D0D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD9D RID: 44445 RVA: 0x001D2B77 File Offset: 0x001D0D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD9E RID: 44446 RVA: 0x001D2B90 File Offset: 0x001D0D90
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

		// Token: 0x0600AD9F RID: 44447 RVA: 0x001D2BB6 File Offset: 0x001D0DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicUnitSelectCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ADA0 RID: 44448 RVA: 0x001D2BD3 File Offset: 0x001D0DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ADA1 RID: 44449 RVA: 0x001D2BDC File Offset: 0x001D0DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046A6 RID: 18086
		private static readonly MessageParser<RogueMagicUnitSelectCallback> _parser = new MessageParser<RogueMagicUnitSelectCallback>(() => new RogueMagicUnitSelectCallback());

		// Token: 0x040046A7 RID: 18087
		private UnknownFieldSet _unknownFields;
	}
}
