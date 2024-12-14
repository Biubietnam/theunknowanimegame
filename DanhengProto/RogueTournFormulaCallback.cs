using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000FB7 RID: 4023
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournFormulaCallback : IMessage<RogueTournFormulaCallback>, IMessage, IEquatable<RogueTournFormulaCallback>, IDeepCloneable<RogueTournFormulaCallback>, IBufferMessage
	{
		// Token: 0x1700328E RID: 12942
		// (get) Token: 0x0600B348 RID: 45896 RVA: 0x001E1B5B File Offset: 0x001DFD5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournFormulaCallback> Parser
		{
			get
			{
				return RogueTournFormulaCallback._parser;
			}
		}

		// Token: 0x1700328F RID: 12943
		// (get) Token: 0x0600B349 RID: 45897 RVA: 0x001E1B62 File Offset: 0x001DFD62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournFormulaCallbackReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003290 RID: 12944
		// (get) Token: 0x0600B34A RID: 45898 RVA: 0x001E1B74 File Offset: 0x001DFD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournFormulaCallback.Descriptor;
			}
		}

		// Token: 0x0600B34B RID: 45899 RVA: 0x001E1B7B File Offset: 0x001DFD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaCallback()
		{
		}

		// Token: 0x0600B34C RID: 45900 RVA: 0x001E1B83 File Offset: 0x001DFD83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaCallback(RogueTournFormulaCallback other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B34D RID: 45901 RVA: 0x001E1B9C File Offset: 0x001DFD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFormulaCallback Clone()
		{
			return new RogueTournFormulaCallback(this);
		}

		// Token: 0x0600B34E RID: 45902 RVA: 0x001E1BA4 File Offset: 0x001DFDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournFormulaCallback);
		}

		// Token: 0x0600B34F RID: 45903 RVA: 0x001E1BB2 File Offset: 0x001DFDB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournFormulaCallback other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600B350 RID: 45904 RVA: 0x001E1BD0 File Offset: 0x001DFDD0
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

		// Token: 0x0600B351 RID: 45905 RVA: 0x001E1BF6 File Offset: 0x001DFDF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B352 RID: 45906 RVA: 0x001E1BFE File Offset: 0x001DFDFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B353 RID: 45907 RVA: 0x001E1C07 File Offset: 0x001DFE07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B354 RID: 45908 RVA: 0x001E1C20 File Offset: 0x001DFE20
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

		// Token: 0x0600B355 RID: 45909 RVA: 0x001E1C46 File Offset: 0x001DFE46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournFormulaCallback other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x001E1C63 File Offset: 0x001DFE63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x001E1C6C File Offset: 0x001DFE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048CF RID: 18639
		private static readonly MessageParser<RogueTournFormulaCallback> _parser = new MessageParser<RogueTournFormulaCallback>(() => new RogueTournFormulaCallback());

		// Token: 0x040048D0 RID: 18640
		private UnknownFieldSet _unknownFields;
	}
}
